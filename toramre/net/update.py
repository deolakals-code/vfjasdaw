"""Update check: refresh the CDN version tables, find the bundles that changed, fetch only those.

What a game update can change, and where it lives (PROJECT.md):
  - master data (SkillMaster: MP cost, levels, flags ...; items, monsters, recipes) -> BynaryData on the CDN
  - texts (skill descriptions, level notes)                                        -> Localize/<lang>/GameScene_<lang>
  - event scripts                                                                  -> FieldScript_<n>
  - skill multipliers, damage formulas, buff values                                -> libil2cpp.so in the APK, NOT on the CDN
So a skill re-balance is caught here only for the parts that live in the data; a formula change needs the new APK."""
import json
import os
import time

from toramre.core import paths
from . import catalog, download, manifest, plan

DEFAULT_ONLY = ("data", "text", "script")


def check_and_fetch(client, root, channel=None, only=DEFAULT_ONLY, jobs=8, max_mbps=0.0, log=print, base=None, out_dir=None,
                    state_dir=None, progress_out=None):
    """-> dict(changes, fetched report or None). Fetches only bundles whose version changed (or is new) on the CDN."""
    before = catalog.load(out_dir)
    after = catalog.refresh(client, out_dir=out_dir, base=base)
    changes = catalog.diff(before, after)
    state = state_dir or paths.STATE
    man_path = os.path.join(state, "fetch_manifest.json")
    os.makedirs(state, exist_ok=True)
    json.dump(changes, open(os.path.join(state, "cdn_changes.json"), "w"), indent=1)
    ch = (channel or catalog.default_channel(after) or "A").upper()
    changed = {c["key"] for c in changes if c["channel"] == ch and c["kind"] in ("new", "changed")}
    man = manifest.load(man_path)
    first_run = not before
    if first_run:
        log(f"no previous version tables: stored the current ones (channel {ch}); nothing compared yet")
        return {"channel": ch, "changes": changes, "fetched": None}
    jobs_list, _ = plan.build(after[ch], ch, root, only=only, manifest=man, keys=changed)
    log(f"channel {ch}: {len(changed)} bundles changed on the CDN, {len(jobs_list)} in {','.join(only)} to fetch")
    for j in jobs_list:
        log(f"  {plan.category(j.key):6} {j.key} -> {j.vhex}")
    rep = None
    if jobs_list:
        try:
            extra = {"progress_out": progress_out} if progress_out is not None else {}
            rep = download.run(client, jobs_list, root, base or catalog.BASE, man, jobs_n=jobs, max_mbps=max_mbps,
                               min_free=0, **extra)
        finally:
            manifest.save(man, man_path)
    return {"channel": ch, "changes": changes, "fetched": rep, "jobs": [j.key for j in jobs_list]}


def poll(client, root, interval_s, once=False, max_polls=0, on_new=None, sleep=time.sleep, log=print, **kw):
    """Check the CDN every `interval_s` seconds; call on_new(result) when something was fetched."""
    n = 0
    while True:
        n += 1
        log(time.strftime("[%Y-%m-%d %H:%M:%S] ") + "checking the CDN")
        try:
            res = check_and_fetch(client, root, log=log, **kw)
        except Exception as e:  # a failed poll is logged and retried next round
            log(f"  check failed: {type(e).__name__}: {e}")
            res = None
        if res and res.get("fetched") and res["fetched"].get("ok") and on_new:
            on_new(res)
        if once or (max_polls and n >= max_polls):
            return res
        sleep(interval_s)
