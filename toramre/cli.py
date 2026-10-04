"""toramre command line. Subcommands are added phase by phase (see the plan in PROJECT.md "Program")."""
import argparse
import json
import os
import sys

from toramre.core import config, paths, versions
from toramre.data import stages
from toramre.watch import diff, report, snapshot


def cmd_watch(a):
    from toramre.watch import collect
    events, snap = collect.collect(since=a.since, balance=not a.no_balance)
    snapshot.save(snap, os.path.join(paths.STATE, "snapshot_latest.json"))
    out = a.out or paths.STATE
    report.write(events, out)
    for tag, evs in report.summarize(events).items():
        print(f"{tag:15} {len(evs)}")
    if a.notify:
        from toramre import notify
        from toramre.watch.tags import level
        lvl = level(config.get("notify", "level", "medium"))
        sel = [e for e in events if e.severity >= lvl]
        if sel and notify.send(notify.summarize(sel)):
            print(f"notified: {len(sel)} events at level >= {config.get('notify', 'level', 'medium')}")
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


def _cache_env():
    """TORAM_CACHE for tools/legacy_scripts/cache.py: env, else [paths] cache_roots + the CDN cache folder."""
    if os.environ.get("TORAM_CACHE"):
        return
    roots = list(config.get("paths", "cache_roots", []) or [])
    cdn = config.get("paths", "cdn_cache", env="TORAM_CDN_CACHE") or os.path.join(paths.REPO, "cdn_cache")
    roots += [cdn] if os.path.isdir(cdn) else []
    if roots:
        os.environ["TORAM_CACHE"] = os.pathsep.join(roots)


def cmd_stage(a):
    _cache_env()
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
    a.jobs = a.jobs or int(config.get("fetch", "jobs", 8))
    a.rate = a.rate if a.rate is not None else float(config.get("fetch", "rate", 8.0))
    a.max_mbps = a.max_mbps if a.max_mbps is not None else float(config.get("fetch", "max_mbps", 0.0))
    a.channel = a.channel or config.get("fetch", "channel")
    client = Client(rate=a.rate, retries=a.retries)
    root = a.dest or catalog.cache_root()
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
    if a.action in ("update", "poll"):
        from toramre.net import update
        only = tuple(a.only.split(",")) if a.only else update.DEFAULT_ONLY

        def after(res):
            from toramre import notify
            try:
                notify.send(f"Toram CDN: new bundles on channel {res['channel']}: " + ", ".join(res.get("jobs", [])[:20]))
            except Exception as e:
                print(f"notify failed: {e}", file=sys.stderr)
            if a.then:
                os.environ["TORAM_CACHE"] = os.pathsep.join(x for x in (root, os.environ.get("TORAM_CACHE", "")) if x)
                for step in a.then.split(","):
                    if step == "extract":
                        stages.run_all(["extract"])
                    elif step == "watch":
                        main(["watch", "--fail-on", "high", "--notify"])

        kw = dict(channel=a.channel, only=only, jobs=a.jobs, max_mbps=a.max_mbps)
        if a.action == "update":
            res = update.check_and_fetch(client, root, **kw)
            rep = res.get("fetched")
            if rep:
                print(f"fetched {len(rep['ok'])}, failed {len(rep['failed'])}" + (" (interrupted)" if rep.get("interrupted") else ""))
                if rep["ok"] and not rep["failed"]:
                    after(res)
                return 1 if rep["failed"] else 0
            print("nothing new to fetch")
            return 0
        update.poll(client, root, a.interval * 60, once=a.once, on_new=after, **kw)
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
    if a.action == "export":
        from toramre.assets import export as ex
        names = {k.rsplit("/", 1)[-1]: k for t in tables.values() for k in t}
        out = a.out or config.get("paths", "export", env="TORAM_EXPORT") or os.path.join(paths.REPO, "exported")
        kinds = tuple(a.types.split(",")) if a.types else ex.KINDS
        only = tuple(a.only.split(",")) if a.only else ("all",)
        summ = ex.run(root, out, lambda b: plan.category(names.get(b, b)), only=only, match=a.match, kinds=kinds,
                      preview=not a.no_preview, jobs=a.export_jobs)
        json.dump(summ, open(os.path.join(paths.STATE, "export_report.json"), "w", encoding="utf-8"), indent=1, ensure_ascii=False)
        print(f"{summ['exported']} bundles exported, {summ['skipped']} unchanged; files {summ['files']}; "
              f"{len(summ['errors'])} errors -> {out}")
        for e in summ["errors"][:10]:
            print("  error", e)
        return 1 if summ["errors"] and not summ["exported"] else 0
    if a.action == "verify":
        bad = download.verify(root, man)
        for k, why in bad:
            print(f"BAD {k}: {why}")
        print(f"{len(man) - len(bad)}/{len(man)} files verified")
        return 1 if bad else 0
    only = tuple(a.only.split(",")) if a.only else ("all",)
    jobs, skipped = plan.build(tables[ch], ch, root, only=only, match=a.match, manifest=man,
                               include_present=a.revalidate or a.force)
    summ = plan.summary(jobs)
    print(f"channel {ch} -> {root}")
    for c, (n, b) in sorted(summ.items()):
        print(f"  {c:7} {n:5} bundles  ~{b / 1e6:,.0f} MB (estimate)")
    print(f"  total {len(jobs)} to fetch, {skipped} already current")
    if a.action == "plan" or not jobs:
        return 0
    try:
        rep = download.run(client, jobs, root, catalog.BASE, man, jobs_n=a.jobs, revalidate=a.revalidate, max_mbps=a.max_mbps)
    finally:
        manifest.save(man)
    out = os.path.join(paths.STATE, "fetch_report.json")
    json.dump(rep, open(out, "w"), indent=1)
    if rep.get("interrupted"):
        print("stopped by Ctrl+C: finished files are kept, unfinished ones resume on the next run")
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


def cmd_balance(a):
    from toramre.balance import api, diff as bdiff, snapshot
    if a.action == "snapshot":
        dv = versions.list_versions("BynaryData")
        label = a.label or (dv[-1] if dv else "current")
        build = a.build or config.get("balance", "build", "unknown")
        p = snapshot.save(snapshot.take(label, build=build, data_version=dv[-1] if dv else None))
        s = snapshot.load(label)
        print(f"snapshot {label} (build {build}): {len(s['rate'])} skills with multipliers, {len(s['buff'])} with buff tables -> {p}")
        return 0
    if a.action == "list":
        for l in snapshot.labels():
            s = snapshot.load(l)
            print(f"{l:12} build {s['build']:10} {s['taken']}  {len(s['rate'])} rates, {len(s['buff'])} buffs")
        if not snapshot.labels():
            print("no snapshots yet: `toramre balance snapshot` stores the multipliers of the currently decoded build")
        return 0
    if a.action == "diff":
        if len(a.args) != 2:
            print("usage: toramre balance diff OLD NEW (snapshot labels)", file=sys.stderr)
            return 2
        entries = api.snapshot_entries(a.args[0], a.args[1])
    else:
        kinds = tuple(a.kind.split(",")) if a.kind else ("skill", "item", "recipe", "registlet")
        entries = api.all_entries(kinds=kinds)
    if a.verdict:
        want = {x.upper() for x in a.verdict.split(",")}
        entries = [e for e in entries if e["verdict"] in want]
    entries.sort(key=lambda e: (V_key(e["to"]), e["kind"], e["id"]), reverse=True)
    for e in entries[:a.limit]:
        print(f"{e['from']}->{e['to']}  {e['verdict']:8} [{e['source']}] {api.describe(e)}")
    print(f"{len(entries)} entries" + (f" (showing {a.limit})" if len(entries) > a.limit else ""))
    return 0


def V_key(v):
    return versions.rank(v)


def cmd_viewer(a):
    from toramre.viewer import server
    if a.selftest:
        return server.selftest()
    return server.serve(port=a.port, open_browser=not a.no_open)


def cmd_doctor(a):
    from toramre import doctor
    return doctor.report(online=a.online)


def main(argv=None):
    p = argparse.ArgumentParser(prog="toramre", description=__doc__)
    sub = p.add_subparsers(dest="cmd", required=True)
    w = sub.add_parser("watch", help="tag what changed between consecutive data versions")
    w.add_argument("--since", help="only pairs whose newer version is this version or later (8 hex chars)")
    w.add_argument("--out", help="report directory (default: state/)")
    w.add_argument("--fail-on", choices=["low", "medium", "high"], default="high", help="exit 1 when an event of this level exists")
    w.add_argument("--no-balance", action="store_true", help="leave out the BUFF / NERF / MIXED entries")
    w.add_argument("--notify", action="store_true", help="send a summary to the webhook in toramre.toml [notify]")
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
    bl = sub.add_parser("balance", help="what got stronger or weaker between versions (BUFF / NERF / MIXED)")
    bl.add_argument("action", choices=["changes", "snapshot", "list", "diff"])
    bl.add_argument("args", nargs="*", help="diff: OLD NEW snapshot labels")
    bl.add_argument("--kind", help="skill,item,recipe,registlet (changes)")
    bl.add_argument("--verdict", help="BUFF,NERF,MIXED,NEUTRAL,ADDED,REMOVED")
    bl.add_argument("--label", help="snapshot label (default: newest data version)")
    bl.add_argument("--build", help="snapshot: build id of libil2cpp.so the values were decoded from (or [balance] build)")
    bl.add_argument("--limit", type=int, default=40)
    bl.set_defaults(fn=cmd_balance)
    vw = sub.add_parser("viewer", help="local web viewer: search, links, balance history, compare (127.0.0.1 only)")
    vw.add_argument("--port", type=int, default=8777)
    vw.add_argument("--no-open", action="store_true", help="do not open the browser")
    vw.add_argument("--selftest", action="store_true", help="request every route once and exit (CI smoke test)")
    vw.set_defaults(fn=cmd_viewer)
    dr = sub.add_parser("doctor", help="check what this machine can run and what is missing")
    dr.add_argument("--online", action="store_true", help="also check that the CDN answers")
    dr.set_defaults(fn=cmd_doctor)
    br = sub.add_parser("brain", help="learn table layouts: frontier, solve, status, show")
    br.add_argument("action", choices=["status", "frontier", "solve", "show"])
    br.add_argument("tables", nargs="*", help="tables (default: every open frontier item)")
    br.add_argument("--dry-run", action="store_true", help="solve without saving to the knowledge base")
    br.add_argument("--rows", type=int, default=5, help="records printed by `show`")
    br.set_defaults(fn=cmd_brain)
    f = sub.add_parser("fetch", help="download bundles from the public CDN (catalog, plan, get, status, verify)")
    f.add_argument("action", choices=["catalog", "plan", "get", "update", "poll", "status", "verify", "export"],
                   help="update = fetch only bundles that changed on the CDN since the last check (default --only data,text,script); "
                        "poll = run update every --interval minutes")
    f.add_argument("--force", action="store_true", help="get: download again even when the file is on disk and current")
    f.add_argument("--max-mbps", type=float, help="cap the total download speed in MB/s (0 = no cap; default [fetch] max_mbps)")
    f.add_argument("--interval", type=float, default=60.0, help="poll: minutes between checks")
    f.add_argument("--once", action="store_true", help="poll: check once and exit")
    f.add_argument("--out", help="export: output folder (default: env TORAM_EXPORT or <repo>/exported)")
    f.add_argument("--types", help="export: model,texture,audio,mesh,text (default all)")
    f.add_argument("--no-preview", action="store_true", help="export: skip the PNG preview of Toram models")
    f.add_argument("--only", help="categories: data,text,script,model,audio,field,other or all (default all)")
    f.add_argument("--match", help="regex on the bundle key")
    f.add_argument("--channel", help="CDN channel A-F (default: the one with the newest data)")
    f.add_argument("--dest", help="cache root (default: env TORAM_CDN_CACHE or <repo>/cdn_cache)")
    f.add_argument("--jobs", type=int, help="parallel downloads (default 8 or [fetch] jobs)")
    f.add_argument("--export-jobs", type=int, default=1, help="export: worker processes")
    f.add_argument("--rate", type=float, help="max requests per second (default 8 or [fetch] rate)")
    f.add_argument("--retries", type=int, default=5)
    f.add_argument("--revalidate", action="store_true", help="re-check files already on disk with If-None-Match (304 = keep)")
    f.add_argument("--then", help="after a clean fetch / update with new files: extract,watch")
    f.set_defaults(fn=cmd_fetch)
    a = p.parse_args(argv)
    return a.fn(a)


if __name__ == "__main__":
    sys.exit(main())
