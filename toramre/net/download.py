"""Bundle fetcher: parallel, polite, resumable, verified, atomic.

Per file: <dest>.part is written (Range resume when the server answers 206), checked (UnityFS magic, Content-Length,
MD5 when the ETag carries it: the CDN's ETag is "<md5 of body>:<timestamp>", observed 2026-10-04), fsynced and only then
renamed to __data. A file that fails a check never reaches the cache."""
import hashlib
import os
import re
import shutil
import sys
import threading
import time
import urllib.error
from concurrent.futures import ThreadPoolExecutor, as_completed

CHUNK = 1 << 18
MD5_ETAG = re.compile(r'^"?(?:W/)?"?([0-9a-f]{32})(?::[^"]*)?"?$')


class VerifyError(Exception):
    pass


def etag_md5(etag):
    m = MD5_ETAG.match(etag or "")
    return m.group(1) if m else None


class Progress:
    def __init__(self, total_files, total_bytes, out=sys.stderr, every=1.0):
        self.total_files, self.total_bytes = total_files, total_bytes
        self.files = self.bytes = self.failed = 0
        self.t0 = time.monotonic()
        self.lock = threading.Lock()
        self.out, self.every, self.last = out, every, 0.0

    def add_bytes(self, n):
        with self.lock:
            self.bytes += n
        self.show()

    def done(self, ok):
        with self.lock:
            self.files += 1
            self.failed += 0 if ok else 1
        self.show(force=True)

    def show(self, force=False):
        now = time.monotonic()
        if not force and now - self.last < self.every:
            return
        self.last = now
        dt = max(1e-6, now - self.t0)
        rate = self.bytes / dt
        left = max(0, self.total_bytes - self.bytes)
        eta = left / rate if rate > 0 else 0
        if self.out is None:
            return
        self.out.write(f"\r{self.files}/{self.total_files} files  {self.bytes / 1e6:,.1f} MB  {rate / 1e6:,.2f} MB/s  "
                       f"ETA {int(eta // 60)}m{int(eta % 60):02d}s  failed {self.failed}   ")
        self.out.flush()


def fetch_one(client, url, path, progress=None, known=None, revalidate=False, throttle=None, stop=None):
    """-> dict(status=new|resumed|unchanged, bytes, md5, etag, last_modified). Raises on failure (no file written)."""
    os.makedirs(os.path.dirname(path), exist_ok=True)
    part = path + ".part"
    have = os.path.getsize(part) if os.path.exists(part) else 0
    headers = {}
    if revalidate and os.path.exists(path) and known:
        if known.get("etag"):
            headers["If-None-Match"] = known["etag"]
        if known.get("last_modified"):
            headers["If-Modified-Since"] = known["last_modified"]
    elif have:
        headers["Range"] = f"bytes={have}-"
    r = client.open(url, headers=headers)
    try:
        code = getattr(r, "status", None) or r.code
        if code == 304:
            return {"status": "unchanged", **(known or {})}
        etag, lm = r.headers.get("ETag"), r.headers.get("Last-Modified")
        if code == 206 and have:
            mode, total = "ab", have + int(r.headers.get("Content-Length", "0"))
            cr = r.headers.get("Content-Range", "")
            if not cr.startswith(f"bytes {have}-"):
                raise VerifyError(f"unexpected Content-Range {cr!r}")
        else:
            mode, total, have = "wb", int(r.headers.get("Content-Length", "-1")), 0
        with open(part, mode) as f:
            while True:
                b = r.read(CHUNK)
                if not b:
                    break
                f.write(b)
                if progress:
                    progress.add_bytes(len(b))
                if throttle:
                    throttle.take(len(b))
                if stop is not None and stop.is_set():
                    raise KeyboardInterrupt  # .part stays on disk; the next run resumes it
            f.flush()
            os.fsync(f.fileno())
    finally:
        r.close()
    try:
        size = os.path.getsize(part)
        if total >= 0 and size != total:
            raise VerifyError(f"size {size} != expected {total}")
        h = hashlib.md5()
        with open(part, "rb") as f:
            head = f.read(7)
            f.seek(0)
            for b in iter(lambda: f.read(CHUNK), b""):
                h.update(b)
        if head != b"UnityFS":
            raise VerifyError("not a UnityFS bundle")
        want = etag_md5(etag)
        if want and h.hexdigest() != want:
            raise VerifyError(f"md5 {h.hexdigest()} != ETag {want}")
    except VerifyError:
        os.remove(part)  # a resumed file that fails is restarted from zero next time
        raise
    os.replace(part, path)
    return {"status": "resumed" if mode == "ab" else "new", "bytes": size, "md5": h.hexdigest(), "etag": etag,
            "last_modified": lm}


def run(client, jobs, root, base_url, manifest, jobs_n=8, revalidate=False, progress_out=sys.stderr, min_free=2 << 30,
        max_mbps=0.0, progress=None, stop=None):
    """Fetch every job (in the given order); -> report dict. Updates `manifest` (dict) in place.
    `max_mbps` caps the total download speed (MB/s, 0 = no cap). Ctrl+C stops cleanly: finished files are kept and recorded,
    unfinished ones stay as .part and resume on the next run."""
    from .http import TokenBucket
    throttle = TokenBucket(max_mbps * 1e6, burst=max(16384, max_mbps * 1e6 * 0.25)) if max_mbps > 0 else None  # 0.25 s burst
    stop = stop if stop is not None else threading.Event()   # an outside owner (the viewer) can stop the run by setting it
    est = sum(j.est_bytes for j in jobs)
    os.makedirs(root, exist_ok=True)
    free = shutil.disk_usage(root).free
    if est and free - est < min_free:
        raise OSError(f"not enough disk: estimate {est / 1e9:.2f} GB, free {free / 1e9:.2f} GB, margin {min_free / 1e9:.1f} GB")
    prog = progress or Progress(len(jobs), est, out=progress_out)
    if progress is not None:
        prog.total_files, prog.total_bytes = len(jobs), est
    report = {"ok": [], "unchanged": [], "failed": []}
    lock = threading.Lock()

    def work(j):
        url = base_url.format(j.channel) + j.key + ".unity3d"
        try:
            if stop.is_set():
                return
            res = fetch_one(client, url, j.dest(root), prog, manifest.get(j.key), revalidate, throttle, stop)
        except KeyboardInterrupt:
            return
        except (VerifyError, urllib.error.HTTPError, urllib.error.URLError, OSError) as e:
            prog.done(False)
            with lock:
                report["failed"].append({"key": j.key, "error": str(e)})
            return
        prog.done(True)
        with lock:
            if res["status"] == "unchanged":
                report["unchanged"].append(j.key)
            else:
                report["ok"].append(j.key)
            manifest[j.key] = {"channel": j.channel, "version": j.vhex, "bytes": res.get("bytes"), "md5": res.get("md5"),
                               "etag": res.get("etag"), "last_modified": res.get("last_modified"),
                               "fetched_at": time.strftime("%Y-%m-%dT%H:%M:%S")}

    t0 = time.monotonic()
    report["interrupted"] = False
    ex = ThreadPoolExecutor(max_workers=max(1, jobs_n))
    try:
        for f in as_completed([ex.submit(work, j) for j in jobs]):
            f.result()
    except KeyboardInterrupt:
        stop.set()
        report["interrupted"] = True
    finally:
        ex.shutdown(wait=True, cancel_futures=True)
    if stop.is_set():
        report["interrupted"] = True
    if progress_out:
        progress_out.write("\n")
    report.update(seconds=round(time.monotonic() - t0, 1), bytes=prog.bytes, requests=client.stats["requests"],
                  retries=client.stats["retries"])
    return report


def verify(root, manifest):
    """Re-check every manifest entry on disk (size + md5). -> list of problems."""
    from .catalog import ver_hex  # noqa: F401
    bad = []
    for key, m in sorted(manifest.items()):
        p = os.path.join(root, key.rsplit("/", 1)[-1], "0" * 24 + m["version"], "__data")
        if not os.path.exists(p):
            bad.append((key, "missing"))
            continue
        h = hashlib.md5()
        with open(p, "rb") as f:
            for b in iter(lambda: f.read(CHUNK), b""):
                h.update(b)
        if m.get("md5") and h.hexdigest() != m["md5"]:
            bad.append((key, "md5 mismatch"))
    return bad
