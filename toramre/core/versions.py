"""Version ids. A cache dir / data version is 8 hex chars = the version as little-endian bytes (also the XOR key)."""
import os

from . import paths


def version_number(ver: str) -> int:
    return int.from_bytes(bytes.fromhex(ver), "little")


def history_order(path=None):
    """Version order recorded in readable/masters/_history.csv (cache-time order, first appearance). Empty when absent.
    The numeric version is NOT a release order: CDN channels A-D carry different numbers (PROJECT.md), e.g. a7e43f32 is
    newer than 6f304932 although its number is smaller."""
    path = path or os.path.join(paths.MASTERS, "_history.csv")
    if not os.path.exists(path):
        return []
    seen = []
    for line in open(path, encoding="utf-8").read().splitlines()[1:]:
        v = line.split(",", 1)[0]
        if v and v not in seen:
            seen.append(v)
    return seen


def list_versions(bundle: str, decoded=None):
    """Decoded versions of a bundle, oldest first. BynaryData follows _history.csv; other bundles (no recorded order here)
    fall back to the numeric LE order, which can mis-order versions from different channels."""
    d = os.path.join(decoded or paths.DECODED, bundle)
    if not os.path.isdir(d):
        return []
    have = [v for v in os.listdir(d) if len(v) == 8]
    hist = {v: i for i, v in enumerate(history_order())} if bundle == "BynaryData" else {}
    return sorted(have, key=lambda v: (0, hist[v]) if v in hist else (1, version_number(v)))


def history_bundles(decoded=None):
    """Bundles whose every cached version is kept (BynaryData and GameScene_<lang>)."""
    root = decoded or paths.DECODED
    return sorted(b for b in os.listdir(root) if b == "BynaryData" or b.startswith("GameScene_"))
