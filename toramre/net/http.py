"""Small polite HTTP layer on urllib: shared token bucket, retries with exponential backoff + jitter, Retry-After."""
import random
import threading
import time
import urllib.error
import urllib.request

from toramre.brain import guard

UA = "toramre/0.1 (offline data research; public CDN assets only)"
RETRY_STATUS = {408, 425, 429, 500, 502, 503, 504}


class TokenBucket:
    def __init__(self, rate, burst=None):
        self.rate = float(rate)
        self.cap = burst or max(1.0, rate)
        self.tokens = self.cap
        self.t = time.monotonic()
        self.lock = threading.Lock()

    def take(self, n=1):
        """Wait until n tokens are available (n may exceed the burst: the debt is paid by waiting)."""
        if self.rate <= 0:
            return
        with self.lock:
            now = time.monotonic()
            self.tokens = min(self.cap, self.tokens + (now - self.t) * self.rate) - n
            self.t = now
            wait = -self.tokens / self.rate if self.tokens < 0 else 0
        if wait > 0:
            time.sleep(wait)


class Client:
    def __init__(self, rate=8.0, retries=5, timeout=60, backoff=1.0, sleep=time.sleep):
        self.bucket = TokenBucket(rate)
        self.retries = retries
        self.timeout = timeout
        self.backoff = backoff
        self.sleep = sleep
        self.stats = {"requests": 0, "retries": 0}
        self.lock = threading.Lock()

    def open(self, url, headers=None, method="GET"):
        """-> urllib response (caller closes). 304/206/200 returned; 404 raises HTTPError; retryable errors are retried."""
        guard.check_url(url)
        attempt = 0
        while True:
            self.bucket.take()
            req = urllib.request.Request(url, headers={"User-Agent": UA, **(headers or {})}, method=method)
            with self.lock:
                self.stats["requests"] += 1
            try:
                return urllib.request.urlopen(req, timeout=self.timeout)
            except urllib.error.HTTPError as e:
                if e.code == 304:
                    return e
                if e.code not in RETRY_STATUS or attempt >= self.retries:
                    raise
                wait = self._retry_after(e) or self._delay(attempt)
            except (urllib.error.URLError, TimeoutError, ConnectionError, OSError) as e:
                if attempt >= self.retries:
                    raise
                wait = self._delay(attempt)
            attempt += 1
            with self.lock:
                self.stats["retries"] += 1
            self.sleep(wait)

    def _delay(self, attempt):
        return self.backoff * (2 ** attempt) + random.uniform(0, 0.5)

    @staticmethod
    def _retry_after(e):
        v = e.headers.get("Retry-After") if e.headers else None
        try:
            return min(300.0, float(v)) if v else None
        except ValueError:
            return None
