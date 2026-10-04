"""toramre command line. Subcommands are added phase by phase (see the plan in PROJECT.md "Program")."""
import argparse
import json
import os
import sys

from toramre.core import paths, versions
from toramre.data import stages
from toramre.watch import diff, report, snapshot


def cmd_watch(a):
    snap = snapshot.take()
    snapshot.save(snap, os.path.join(paths.STATE, "snapshot_latest.json"))
    events = diff.diff_snapshot(snap, since=a.since)
    base = os.path.join(paths.STATE, "extra_baseline.json")
    if os.path.exists(base):
        import json
        events += diff.diff_extra(json.load(open(base)), snap["extra"])
    out = a.out or paths.STATE
    report.write(events, out)
    for tag, evs in report.summarize(events).items():
        print(f"{tag:15} {len(evs)}")
    print(f"{len(events)} events -> {os.path.join(out, 'CHANGES.md')}")
    return 1 if report.exceeds(events, a.fail_on) else 0


def cmd_ui(a):
    from toramre.ui import build
    out = a.out or os.path.join(paths.STATE, "dashboard.html")
    build.write(out, standalone=not a.fragment)
    print("dashboard ->", out)
    if a.serve:
        import functools
        import http.server
        d, f = os.path.split(os.path.abspath(out))
        h = functools.partial(http.server.SimpleHTTPRequestHandler, directory=d)
        print(f"serving http://127.0.0.1:{a.serve}/{f}  (Ctrl+C to stop)")
        http.server.ThreadingHTTPServer(("127.0.0.1", a.serve), h).serve_forever()
    return 0


def cmd_versions(a):
    for b in versions.history_bundles():
        vs = versions.list_versions(b)
        print(f"{b:16} {len(vs):3} versions, newest {vs[-1] if vs else '-'}")
    return 0


def cmd_stage(a):
    bad = [n for n in a.names if n not in stages.STAGES]
    if bad:
        print(f"unknown stage {', '.join(bad)}; choose from {', '.join(stages.ORDER)}", file=sys.stderr)
        return 2
    return stages.run_all(a.names)


def cmd_brain(a):
    from toramre.brain import engine, grammar as G, kb
    if a.action == "frontier":
        for it in engine.frontier():
            print(f"{it['table']:24} {it['bytes']:>8} bytes  {it['why']}")
        return 0
    if a.action == "status":
        known = kb.all_tables()
        fr = engine.frontier()
        print(f"learned schemas: {len(known)}  open frontier items: {len(fr)}")
        for t in known:
            e = kb.load(t)
            print(f"  [learned] {t:22} {e['strategy']:12} {e['stats']['records']:>6} records  {e['describe'][:90]}")
        for it in fr:
            print(f"  [open]    {it['table']:22} {it['why']}")
        st = kb.stats()
        if st:
            print("strategy record:", ", ".join(f"{k} {v['solved']}/{v['tried']}" for k, v in sorted(st.items())))
        return 0
    if a.action == "show":
        for t in a.tables:
            e = kb.load(t)
            if not e:
                print(f"{t}: not learned"); continue
            print(json.dumps({k: e[k] for k in ("describe", "strategy", "confidence", "stats", "evidence")}, indent=1))
            names, recs = engine.decode_table(t)
            print("names:", names)
            for r in recs[:a.rows]:
                print("  ", r)
        return 0
    results = engine.run(a.tables or None, learn=not a.dry_run)
    for r in results:
        line = r.get("describe") or "; ".join(f"{c['describe']} [{c['confidence']}]" for c in r.get("candidates", [])[:1]) or r.get("why", "")
        print(f"{r['table']:24} {r['status']:8} {r.get('strategy', ''):12} {line[:110]}")
    return 0


def main(argv=None):
    p = argparse.ArgumentParser(prog="toramre", description=__doc__)
    sub = p.add_subparsers(dest="cmd", required=True)
    w = sub.add_parser("watch", help="tag what changed between consecutive data versions")
    w.add_argument("--since", help="only pairs whose newer version is this version or later (8 hex chars)")
    w.add_argument("--out", help="report directory (default: state/)")
    w.add_argument("--fail-on", choices=["low", "medium", "high"], default="high", help="exit 1 when an event of this level exists")
    w.set_defaults(fn=cmd_watch)
    u = sub.add_parser("ui", help="build the dashboard (one self-contained HTML page)")
    u.add_argument("--out", help="output file (default: state/dashboard.html)")
    u.add_argument("--serve", type=int, nargs="?", const=8765, help="also serve it on 127.0.0.1:PORT")
    u.add_argument("--fragment", action="store_true", help="body only, no <html> wrapper (for embedding)")
    u.set_defaults(fn=cmd_ui)
    v = sub.add_parser("versions", help="list kept versions per bundle, oldest to newest")
    v.set_defaults(fn=cmd_versions)
    st = sub.add_parser("stage", help="run BIGDATA build stages in order: " + ", ".join(stages.ORDER),
                        description="\n".join(f"{n:8} {stages.STAGES[n][1]}" for n in stages.ORDER),
                        formatter_class=argparse.RawDescriptionHelpFormatter)
    st.add_argument("names", nargs="*", metavar="STAGE", help="stages to run (default: all)")
    st.set_defaults(fn=cmd_stage)
    br = sub.add_parser("brain", help="learn table layouts: frontier, solve, status, show")
    br.add_argument("action", choices=["status", "frontier", "solve", "show"])
    br.add_argument("tables", nargs="*", help="tables (default: every open frontier item)")
    br.add_argument("--dry-run", action="store_true", help="solve without saving to the knowledge base")
    br.add_argument("--rows", type=int, default=5, help="records printed by `show`")
    br.set_defaults(fn=cmd_brain)
    a = p.parse_args(argv)
    return a.fn(a)


if __name__ == "__main__":
    sys.exit(main())
