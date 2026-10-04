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
        events += diff.diff_extra(json.load(open(base)), snap["extra"])
    cdn = os.path.join(paths.STATE, "cdn_changes.json")
    if os.path.exists(cdn):
        from toramre.watch.tags import Event
        for x in json.load(open(cdn)):
            data = x["key"] == "BynaryData" or x["key"].startswith(("Localize/", "FieldScript/"))
            tag = {"new": "NEW", "removed": "REMOVED"}.get(x["kind"], "CHANGED")
            events.append(Event(tag, f"cdn/{x['channel']}", x["key"], x["from"] or "-", x["to"] or "-",
                                "new data version on the CDN: run `toramre fetch get --only data,text --channel "
                                f"{x['channel']}`" if data else "bundle version changed on the CDN"))
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


def cmd_fetch(a):
    from toramre.net import catalog, download, manifest, plan
    from toramre.net.http import Client
    client = Client(rate=a.rate, retries=a.retries)
    root = a.dest or os.environ.get("TORAM_CDN_CACHE") or os.path.join(paths.REPO, "cdn_cache")
    if a.action == "catalog":
        before = catalog.load()
        tables = catalog.refresh(client)
        changes = catalog.diff(before, tables)
        os.makedirs(paths.STATE, exist_ok=True)
        json.dump(changes, open(os.path.join(paths.STATE, "cdn_changes.json"), "w"), indent=1)
        if changes:
            from collections import Counter
            for (c, kind), n in sorted(Counter((x["channel"], x["kind"]) for x in changes).items()):
                print(f"  channel {c}: {n} bundles {kind}")
        for ch, t in sorted(tables.items()):
            bd = t.get("BynaryData")
            print(f"channel {ch}: {len(t)} bundles, BynaryData {catalog.ver_hex(bd[0]) if bd else '-'}")
        for c, info in catalog.channel_report(tables).items():
            print(f"  {c}: BynaryData {info['BynaryData']}{'  (already decoded here)' if info['decoded_here'] else '  (new to this repo)'}")
        print(f"default channel: {catalog.default_channel(tables)}")
        return 0
    tables = catalog.load()
    if not tables:
        print("no stored version tables; run `toramre fetch catalog` first", file=sys.stderr)
        return 2
    ch = (a.channel or catalog.default_channel(tables)).upper()
    if ch not in tables:
        print(f"channel {ch} has no stored version table", file=sys.stderr)
        return 2
    man = manifest.load()
    if a.action == "status":
        print(f"cache root {root}; manifest {len(man)} bundles, {sum((m.get('bytes') or 0) for m in man.values()) / 1e6:,.1f} MB")
        jobs, skipped = plan.build(tables[ch], ch, root, manifest=man)
        print(f"channel {ch}: {skipped} bundles current, {len(jobs)} not fetched or outdated")
        return 0
    if a.action == "verify":
        bad = download.verify(root, man)
        for k, why in bad:
            print(f"BAD {k}: {why}")
        print(f"{len(man) - len(bad)}/{len(man)} files verified")
        return 1 if bad else 0
    only = tuple(a.only.split(",")) if a.only else ("all",)
    jobs, skipped = plan.build(tables[ch], ch, root, only=only, match=a.match, manifest=man, include_present=a.revalidate)
    summ = plan.summary(jobs)
    print(f"channel {ch} -> {root}")
    for c, (n, b) in sorted(summ.items()):
        print(f"  {c:7} {n:5} bundles  ~{b / 1e6:,.0f} MB (estimate)")
    print(f"  total {len(jobs)} to fetch, {skipped} already current")
    if a.action == "plan" or not jobs:
        return 0
    try:
        rep = download.run(client, jobs, root, catalog.BASE, man, jobs_n=a.jobs, revalidate=a.revalidate)
    finally:
        manifest.save(man)
    out = os.path.join(paths.STATE, "fetch_report.json")
    json.dump(rep, open(out, "w"), indent=1)
    print(f"fetched {len(rep['ok'])}, unchanged {len(rep['unchanged'])}, failed {len(rep['failed'])}; "
          f"{rep['bytes'] / 1e6:,.1f} MB in {rep['seconds']} s, {rep['retries']} retries -> {out}")
    if rep["failed"] or not a.then:
        return 1 if rep["failed"] else 0
    env_cache = os.pathsep.join(x for x in (root, os.environ.get("TORAM_CACHE", "")) if x)
    os.environ["TORAM_CACHE"] = env_cache
    for step in a.then.split(","):
        rc = stages.run_all(["extract"]) if step == "extract" else main(["watch"]) if step == "watch" else 2
        if rc:
            return rc
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
    f = sub.add_parser("fetch", help="download bundles from the public CDN (catalog, plan, get, status, verify)")
    f.add_argument("action", choices=["catalog", "plan", "get", "status", "verify"])
    f.add_argument("--only", help="categories: data,text,script,model,audio,field,other or all (default all)")
    f.add_argument("--match", help="regex on the bundle key")
    f.add_argument("--channel", help="CDN channel A-F (default: the one with the newest data)")
    f.add_argument("--dest", help="cache root (default: env TORAM_CDN_CACHE or <repo>/cdn_cache)")
    f.add_argument("--jobs", type=int, default=8, help="parallel downloads")
    f.add_argument("--rate", type=float, default=8.0, help="max requests per second")
    f.add_argument("--retries", type=int, default=5)
    f.add_argument("--revalidate", action="store_true", help="re-check files already on disk with If-None-Match (304 = keep)")
    f.add_argument("--then", help="after a clean fetch run: extract,watch")
    f.set_defaults(fn=cmd_fetch)
    a = p.parse_args(argv)
    return a.fn(a)


if __name__ == "__main__":
    sys.exit(main())
