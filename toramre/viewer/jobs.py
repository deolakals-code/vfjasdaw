"""Fetch jobs for the viewer: one download at a time, run in a background thread, progress polled by the page.
Safety: the destination folder is always the configured cache root (never a path from the page), only the public CDN is
reachable (guard), and only these options are accepted: categories, channel, jobs, speed cap, force."""
import json
import os
import threading
import time

from toramre.core import paths
from toramre.net import catalog, download, manifest, plan
from toramre.net.http import Client

CATEGORIES = plan.PRIORITY
LIMITS = {"jobs": (1, 32), "max_mbps": (0.0, 1000.0)}


class FetchJobs:
    def __init__(self, root=None, base=None, state_dir=None, client_factory=None):
        self.root = root
        self.base = base or catalog.BASE
        self.state_dir = state_dir or paths.STATE
        self.client_factory = client_factory or (lambda: Client(rate=8.0, retries=4))
        self.lock = threading.Lock()
        self.thread = None
        self.stop_flag = threading.Event()
        self.progress = None
        self.status = {"state": "idle"}

    def _root(self):
        return self.root or catalog.cache_root()

    # ---- catalog -----------------------------------------------------------------------------------------
    def refresh_catalog(self, out_dir=None):
        before = catalog.load(out_dir)
        tables = catalog.refresh(self.client_factory(), out_dir=out_dir, base=self.base)
        changes = catalog.diff(before, tables)
        os.makedirs(self.state_dir, exist_ok=True)
        with open(os.path.join(self.state_dir, "cdn_changes.json"), "w", encoding="utf-8") as f:
            json.dump(changes, f, indent=1)
        return {"channels": catalog.channel_report(tables), "changes": len(changes)}

    # ---- plan --------------------------------------------------------------------------------------------
    def plan_summary(self, only=("all",), channel=None, force=False, tables=None):
        tables = tables if tables is not None else catalog.load()
        if not tables:
            return {"error": "no stored version tables: refresh the catalog first"}
        ch = (channel or catalog.default_channel(tables)).upper()
        if ch not in tables:
            return {"error": f"channel {ch} has no stored version table"}
        man = manifest.load(os.path.join(self.state_dir, "fetch_manifest.json"))
        jobs, skipped = plan.build(tables[ch], ch, self._root(), only=only, manifest=man, include_present=force)
        per = plan.summary(jobs)
        allc = {}
        for k in tables[ch]:
            c = allc.setdefault(plan.category(k), [0, 0])
            c[0] += 1
            c[1] += tables[ch][k][2] * plan.SIZE_UNIT
        everything, _ = plan.build(tables[ch], ch, self._root(), only=("all",), manifest=man)   # bundles missing or outdated on disk
        missing, missing_bytes = {}, {}
        for j in everything:
            c = plan.category(j.key)
            missing[c] = missing.get(c, 0) + 1
            missing_bytes[c] = missing_bytes.get(c, 0) + j.est_bytes
        done = {c: v[0] - missing.get(c, 0) for c, v in allc.items()}
        return {"channel": ch, "root": self._root(), "skipped": skipped, "to_fetch": len(jobs),
                "categories": [{"name": c, "total": allc.get(c, [0, 0])[0], "fetched": done.get(c, 0),
                                "to_fetch": missing.get(c, 0), "bytes": missing_bytes.get(c, 0), "total_bytes": allc.get(c, [0, 0])[1]}
                               for c in CATEGORIES if c in allc], "jobs": jobs}

    # ---- run ---------------------------------------------------------------------------------------------
    def start(self, opts):
        only = [c for c in (opts.get("only") or []) if c in CATEGORIES] or None
        if not only:
            raise ValueError("choose at least one category: " + ", ".join(CATEGORIES))
        jobs_n = int(opts.get("jobs", 8))
        mbps = float(opts.get("max_mbps", 0))
        if not LIMITS["jobs"][0] <= jobs_n <= LIMITS["jobs"][1] or not LIMITS["max_mbps"][0] <= mbps <= LIMITS["max_mbps"][1]:
            raise ValueError("jobs must be 1..32 and max_mbps 0..1000")
        with self.lock:
            if self.thread and self.thread.is_alive():
                raise RuntimeError("a download is already running")
            ps = self.plan_summary(tuple(only), opts.get("channel"), bool(opts.get("force")))
            if "error" in ps:
                raise ValueError(ps["error"])
            if not ps["jobs"]:
                self.status = {"state": "done", "message": "nothing to fetch: everything chosen is current", "files": 0, "total_files": 0}
                return self.status
            self.stop_flag = threading.Event()
            self.progress = download.Progress(len(ps["jobs"]), sum(j.est_bytes for j in ps["jobs"]), out=None)
            self.status = {"state": "running", "channel": ps["channel"], "started": time.strftime("%H:%M:%S")}
            self.thread = threading.Thread(target=self._run, args=(ps, jobs_n, mbps, bool(opts.get("force"))), daemon=True)
            self.thread.start()
            return self.status

    def _run(self, ps, jobs_n, mbps, force):
        man_path = os.path.join(self.state_dir, "fetch_manifest.json")
        man = manifest.load(man_path)
        try:
            rep = download.run(self.client_factory(), ps["jobs"], self._root(), self.base, man, jobs_n=jobs_n, progress_out=None,
                               max_mbps=mbps, progress=self.progress, stop=self.stop_flag, min_free=0)
            state = "stopped" if rep.get("interrupted") else ("failed" if rep["failed"] and not rep["ok"] else "done")
            self.status = {**self.status, "state": state, "report": {"ok": len(rep["ok"]), "failed": rep["failed"][:20],
                                                                      "bytes": rep["bytes"], "seconds": rep["seconds"], "retries": rep["retries"]}}
        except Exception as e:  # the page shows the message instead of a dead job
            self.status = {**self.status, "state": "failed", "error": f"{type(e).__name__}: {e}"}
        finally:
            manifest.save(man, man_path)

    def stop(self):
        self.stop_flag.set()
        return {"state": "stopping"}

    def current(self):
        s = dict(self.status)
        p = self.progress
        if p is not None and s.get("state") in ("running", "done", "stopped", "failed") and p.total_files:
            dt = max(1e-6, time.monotonic() - p.t0)
            rate = p.bytes / dt
            left = max(0, p.total_bytes - p.bytes)
            s.update(files=p.files, total_files=p.total_files, bytes=p.bytes, total_bytes=p.total_bytes, failed=p.failed,
                     rate=rate, eta=(left / rate if rate > 0 and s["state"] == "running" else 0))
        return s
