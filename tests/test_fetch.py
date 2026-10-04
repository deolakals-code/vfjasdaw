import hashlib
import http.server
import io
import os
import sys
import tempfile
import threading
import unittest

sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
from toramre.brain import guard  # noqa: E402
from toramre.net import download, plan, revision  # noqa: E402
from toramre.net.http import Client  # noqa: E402


class FakeCDN(http.server.BaseHTTPRequestHandler):
    files = {}          # path -> bytes
    fail_once = {}      # path -> status to return on the first request
    ignore_range = set()
    bad_etag = set()
    seen = []

    def log_message(self, *a):
        pass

    def _send(self, head_only=False):
        self.seen.append((self.path, self.headers.get("Range"), self.headers.get("If-None-Match")))
        if self.path in self.fail_once:
            code = self.fail_once.pop(self.path)
            self.send_response(code)
            self.send_header("Retry-After", "0")
            self.send_header("Content-Length", "0")
            self.end_headers()
            return
        body = self.files.get(self.path)
        if body is None:
            self.send_response(404)
            self.send_header("Content-Length", "0")
            self.end_headers()
            return
        md5 = hashlib.md5(body).hexdigest()
        etag = f'"{"0" * 32 if self.path in self.bad_etag else md5}:1790235536.379049"'
        if self.headers.get("If-None-Match") == etag:
            self.send_response(304)
            self.send_header("ETag", etag)
            self.end_headers()
            return
        rng = self.headers.get("Range")
        if rng and self.path not in self.ignore_range:
            start = int(rng.split("=")[1].split("-")[0])
            part = body[start:]
            self.send_response(206)
            self.send_header("Content-Range", f"bytes {start}-{len(body) - 1}/{len(body)}")
        else:
            part = body
            self.send_response(200)
        self.send_header("Content-Length", str(len(part)))
        self.send_header("ETag", etag)
        self.send_header("Last-Modified", "Fri, 18 Sep 2026 03:01:50 GMT")
        self.end_headers()
        if not head_only:
            self.wfile.write(part)

    def do_GET(self):
        self._send()


def bundle(n):
    return b"UnityFS\x00" + bytes((i * 7 + n) % 256 for i in range(5000 + n))


class Fetch(unittest.TestCase):
    @classmethod
    def setUpClass(cls):
        cls.srv = http.server.ThreadingHTTPServer(("127.0.0.1", 0), FakeCDN)
        threading.Thread(target=cls.srv.serve_forever, daemon=True).start()
        cls.base = f"http://127.0.0.1:{cls.srv.server_port}/release{{}}/"
        cls.hosts = guard.ALLOWED_HOSTS
        guard.ALLOWED_HOSTS = cls.hosts + ("127.0.0.1",)  # test-only: the fake CDN

    @classmethod
    def tearDownClass(cls):
        cls.srv.shutdown()
        guard.ALLOWED_HOSTS = cls.hosts

    def setUp(self):
        self.tmp = tempfile.TemporaryDirectory()
        self.root = self.tmp.name
        self.table = {"BynaryData": (843048103, 1, 50), "Localize/th/GameScene_th": (100, 1, 5), "Mob/Mob_1": (200, 0, 9)}
        FakeCDN.files = {f"/releaseA/{k}.unity3d": bundle(i) for i, k in enumerate(self.table)}
        FakeCDN.files["/releaseA/RevisionInfoBinary.bytes"] = revision.build(self.table)
        FakeCDN.fail_once, FakeCDN.ignore_range, FakeCDN.bad_etag, FakeCDN.seen = {}, set(), set(), []
        self.client = Client(rate=0, retries=3, backoff=0, sleep=lambda s: None)

    def tearDown(self):
        self.tmp.cleanup()

    def run_jobs(self, jobs, man=None, **kw):
        man = {} if man is None else man
        return download.run(self.client, jobs, self.root, self.base, man, jobs_n=4, progress_out=io.StringIO(), min_free=0, **kw), man

    def test_revision_roundtrip(self):
        self.assertEqual(revision.parse(revision.build(self.table)), self.table)

    def test_plan_filters_and_skip(self):
        jobs, _ = plan.build(self.table, "A", self.root, only=("text",))
        self.assertEqual([j.key for j in jobs], ["Localize/th/GameScene_th"])
        jobs, _ = plan.build(self.table, "A", self.root, match="^Mob/")
        self.assertEqual([j.key for j in jobs], ["Mob/Mob_1"])
        self.assertEqual(jobs[0].dest(self.root), os.path.join(self.root, "Mob_1", "0" * 24 + "c8000000", "__data"))

    def test_parallel_download_manifest_and_delta(self):
        jobs, _ = plan.build(self.table, "A", self.root)
        rep, man = self.run_jobs(jobs)
        self.assertEqual(len(rep["ok"]), 3)
        self.assertEqual(rep["failed"], [])
        for j in jobs:
            self.assertEqual(open(j.dest(self.root), "rb").read(), FakeCDN.files[f"/releaseA/{j.key}.unity3d"])
            self.assertEqual(man[j.key]["version"], j.vhex)
        again, skipped = plan.build(self.table, "A", self.root, manifest=man)
        self.assertEqual((again, skipped), ([], 3))
        newer = dict(self.table, **{"Mob/Mob_1": (201, 0, 9)})
        again, _ = plan.build(newer, "A", self.root, manifest=man)
        self.assertEqual([j.key for j in again], ["Mob/Mob_1"])

    def test_retry_after_503_and_429(self):
        FakeCDN.fail_once = {"/releaseA/BynaryData.unity3d": 503, "/releaseA/Mob/Mob_1.unity3d": 429}
        jobs, _ = plan.build(self.table, "A", self.root)
        rep, _ = self.run_jobs(jobs)
        self.assertEqual(len(rep["ok"]), 3)
        self.assertGreaterEqual(rep["retries"], 2)

    def test_resume_with_range(self):
        j = plan.build(self.table, "A", self.root, match="BynaryData")[0][0]
        body = FakeCDN.files["/releaseA/BynaryData.unity3d"]
        os.makedirs(os.path.dirname(j.dest(self.root)))
        with open(j.dest(self.root) + ".part", "wb") as f:
            f.write(body[:1234])
        rep, man = self.run_jobs([j])
        self.assertEqual(open(j.dest(self.root), "rb").read(), body)
        self.assertIn(("/releaseA/BynaryData.unity3d", "bytes=1234-", None), FakeCDN.seen)

    def test_server_ignoring_range_restarts(self):
        FakeCDN.ignore_range = {"/releaseA/BynaryData.unity3d"}
        j = plan.build(self.table, "A", self.root, match="BynaryData")[0][0]
        os.makedirs(os.path.dirname(j.dest(self.root)))
        with open(j.dest(self.root) + ".part", "wb") as f:
            f.write(b"garbage")
        self.run_jobs([j])
        self.assertEqual(open(j.dest(self.root), "rb").read(), FakeCDN.files["/releaseA/BynaryData.unity3d"])

    def test_bad_md5_and_bad_magic_never_reach_cache(self):
        FakeCDN.bad_etag = {"/releaseA/BynaryData.unity3d"}
        FakeCDN.files["/releaseA/Mob/Mob_1.unity3d"] = b"<html>error page</html>"
        jobs, _ = plan.build(self.table, "A", self.root)
        rep, _ = self.run_jobs(jobs)
        self.assertEqual(sorted(f["key"] for f in rep["failed"]), ["BynaryData", "Mob/Mob_1"])
        for j in jobs:
            if j.key != "Localize/th/GameScene_th":
                self.assertFalse(os.path.exists(j.dest(self.root)))
                self.assertFalse(os.path.exists(j.dest(self.root) + ".part"))

    def test_revalidate_gets_304(self):
        jobs, _ = plan.build(self.table, "A", self.root)
        _, man = self.run_jobs(jobs)
        jobs, _ = plan.build(self.table, "A", self.root, include_present=True)
        rep, _ = self.run_jobs(jobs, man, revalidate=True)
        self.assertEqual(len(rep["unchanged"]), 3)
        self.assertEqual(download.verify(self.root, man), [])

    def test_guard_blocks_other_hosts(self):
        with self.assertRaises(guard.Boundary):
            Client().open("https://example.com/RevisionInfoBinary.bytes")


class RealCatalog(unittest.TestCase):
    def test_stored_table_matches_csv(self):
        import csv
        from toramre.net import catalog
        p = os.path.join(catalog.CDN_DIR, "RevisionInfoBinary_A.bytes")
        if not os.path.exists(p):
            self.skipTest("no stored table")
        t = revision.parse(open(p, "rb").read())
        rows = {r["key"]: r for r in csv.DictReader(open(os.path.join(catalog.CDN_DIR, "catalog_A.csv"), encoding="utf-8"))}
        self.assertEqual(set(t), set(rows))
        self.assertTrue(all(str(t[k][0] & 0xffffffff) == rows[k]["version"] for k in t))


if __name__ == "__main__":
    unittest.main()


class UpdateAndControls(Fetch):
    def test_force_redownloads(self):
        jobs, _ = plan.build(self.table, "A", self.root)
        _, man = self.run_jobs(jobs)
        none, _ = plan.build(self.table, "A", self.root, manifest=man)
        forced, _ = plan.build(self.table, "A", self.root, manifest=man, include_present=True)
        self.assertEqual((len(none), len(forced)), (0, 3))
        rep, _ = self.run_jobs(forced, man)
        self.assertEqual(len(rep["ok"]), 3)

    def test_priority_data_first(self):
        jobs, _ = plan.build(self.table, "A", self.root)
        self.assertEqual([plan.category(j.key) for j in jobs], ["data", "text", "model"])

    def test_bandwidth_cap(self):
        import time
        for k in self.table:
            FakeCDN.files[f"/releaseA/{k}.unity3d"] = b"UnityFS" + bytes(200_000)
        jobs, _ = plan.build(self.table, "A", self.root)
        total = sum(len(FakeCDN.files[f"/releaseA/{j.key}.unity3d"]) for j in jobs)
        t0 = time.monotonic()
        download.run(self.client, jobs, self.root, self.base, {}, jobs_n=3, progress_out=io.StringIO(), min_free=0,
                     max_mbps=total / 0.6 / 1e6)  # 600 KB at 1 MB/s with a 0.25 s burst -> >= 0.35 s
        self.assertGreater(time.monotonic() - t0, 0.25)

    def test_update_fetches_only_changed_bundles(self):
        from toramre.net import update
        with tempfile.TemporaryDirectory() as cdn_dir, tempfile.TemporaryDirectory() as state:
            kw = dict(base=self.base, out_dir=cdn_dir, state_dir=state, progress_out=io.StringIO(), log=lambda *a: None)
            first = update.check_and_fetch(self.client, self.root, channel="A", **kw)
            self.assertIsNone(first["fetched"])  # first run only stores the tables
            newer = dict(self.table, **{"BynaryData": (843048104, 1, 50), "Mob/Mob_1": (201, 0, 9)})
            FakeCDN.files["/releaseA/RevisionInfoBinary.bytes"] = revision.build(newer)
            res = update.check_and_fetch(self.client, self.root, channel="A", **kw)
            self.assertEqual(res["jobs"], ["BynaryData"])  # Mob is a model bundle: not in data,text,script
            self.assertEqual(res["fetched"]["ok"], ["BynaryData"])
            j = plan.Job("BynaryData", 843048104, 50, "A")
            self.assertTrue(os.path.exists(j.dest(self.root)))
            again = update.check_and_fetch(self.client, self.root, channel="A", **kw)
            self.assertEqual(again["jobs"], [])

    def test_poll_stops_after_max_polls(self):
        from toramre.net import update
        seen = []
        with tempfile.TemporaryDirectory() as cdn_dir, tempfile.TemporaryDirectory() as state:
            update.poll(self.client, self.root, 60, max_polls=2, sleep=seen.append, log=lambda *a: None,
                        base=self.base, out_dir=cdn_dir, state_dir=state, progress_out=io.StringIO(), channel="A")
        self.assertEqual(seen, [60])


class ViewerJobs(Fetch):
    def jobs(self, state):
        from toramre.viewer.jobs import FetchJobs
        return FetchJobs(root=self.root, base=self.base, state_dir=state, client_factory=lambda: self.client)

    def wait(self, j, seconds=10):
        import time
        t0 = time.time()
        while j.current().get("state") in ("running", "stopping") and time.time() - t0 < seconds:
            time.sleep(0.05)
        return j.current()

    def test_plan_start_progress_and_manifest(self):
        from unittest import mock
        from toramre.net import catalog
        with tempfile.TemporaryDirectory() as state, mock.patch.object(catalog, "load", return_value={"A": self.table}):
            j = self.jobs(state)
            ps = j.plan_summary(("data", "text"))
            self.assertEqual((ps["to_fetch"], {c["name"]: c["to_fetch"] for c in ps["categories"]}), (2, {"data": 1, "text": 1, "model": 1}))
            j.start({"only": ["data", "text"], "jobs": 2, "max_mbps": 0})
            st = self.wait(j)
            self.assertEqual(st["state"], "done")
            self.assertEqual((st["files"], st["total_files"], st["failed"]), (2, 2, 0))
            self.assertTrue(os.path.exists(os.path.join(state, "fetch_manifest.json")))
            ps = j.plan_summary(("all",))
            self.assertEqual({c["name"]: c["fetched"] for c in ps["categories"]}, {"data": 1, "text": 1, "model": 0})
            j.start({"only": ["data"]})
            self.assertEqual(j.current()["state"], "done")           # nothing left: reported, not started
            self.assertIn("nothing to fetch", j.current()["message"])

    def test_rejects_bad_options_and_double_start(self):
        from unittest import mock
        from toramre.net import catalog
        with tempfile.TemporaryDirectory() as state, mock.patch.object(catalog, "load", return_value={"A": self.table}):
            j = self.jobs(state)
            for bad in ({"only": []}, {"only": ["nope"]}, {"only": ["data"], "jobs": 99}, {"only": ["data"], "max_mbps": -1}):
                with self.assertRaises(ValueError):
                    j.start(bad)

    def test_stop_keeps_finished_files(self):
        from unittest import mock
        from toramre.net import catalog
        for k in self.table:
            FakeCDN.files[f"/releaseA/{k}.unity3d"] = b"UnityFS" + bytes(300_000)
        with tempfile.TemporaryDirectory() as state, mock.patch.object(catalog, "load", return_value={"A": self.table}):
            j = self.jobs(state)
            j.start({"only": ["data", "text", "model"], "jobs": 1, "max_mbps": 0.2})   # slow enough to stop in the middle
            import time
            time.sleep(0.4)
            j.stop()
            st = self.wait(j)
            self.assertEqual(st["state"], "stopped")
            self.assertLess(st["files"], 3)
