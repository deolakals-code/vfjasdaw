"""Boundary guard: the PROJECT.md scope rules as code. Every brain step calls it before touching a file or a URL.

Stops (raises Boundary) on: anti-cheat / protection files, data that looks packed or encrypted with an unknown scheme
(the engine never tries to break protection), and any network host other than the public CDN."""
import math
import os
from urllib.parse import urlparse

FORBIDDEN = ("xigncode", "libxigncode", "appsign", "gameassembly.dll")
ALLOWED_HOSTS = ("toram-jp.akamaized.net",)
ENTROPY_LIMIT = 7.6   # bits per byte; the analysed libil2cpp.so exec segment is 6.6, decoded tables are lower
ENTROPY_MIN_BYTES = 4096


class Boundary(RuntimeError):
    """Raised where the engine must stop and report instead of digging further."""


def entropy(data: bytes) -> float:
    if not data:
        return 0.0
    counts = [0] * 256
    for b in data:
        counts[b] += 1
    n = len(data)
    return -sum(c / n * math.log2(c / n) for c in counts if c)


def check_path(path: str):
    low = path.replace(chr(92), "/").lower()
    for bad in FORBIDDEN:
        if bad in low:
            raise Boundary(f"{path}: anti-cheat / protection file ({bad}); out of scope, not analysed")


def check_data(name: str, data: bytes):
    if len(data) >= ENTROPY_MIN_BYTES:
        e = entropy(data[:1 << 20])
        if e > ENTROPY_LIMIT:
            raise Boundary(f"{name}: entropy {e:.2f} bits/byte; looks packed or encrypted with an unknown scheme. "
                           "Stopped: protection is not broken by this tool. Check whether a known decode step was skipped.")


def check_url(url: str):
    host = urlparse(url).hostname or ""
    if host not in ALLOWED_HOSTS:
        raise Boundary(f"{url}: network access is limited to the public CDN ({', '.join(ALLOWED_HOSTS)})")
