"""state/fetch_manifest.json: what was fetched (key -> channel, version, bytes, md5, etag, last_modified, fetched_at)."""
import json
import os
import threading

from toramre.core import paths

PATH = os.path.join(paths.STATE, "fetch_manifest.json")
_lock = threading.Lock()


def load(path=None):
    p = path or PATH
    return json.load(open(p, encoding="utf-8")) if os.path.exists(p) else {}


def save(data, path=None):
    p = path or PATH
    os.makedirs(os.path.dirname(p), exist_ok=True)
    tmp = p + ".tmp"
    with _lock, open(tmp, "w", encoding="utf-8") as f:
        json.dump(data, f, indent=0, sort_keys=True)
        f.flush()
        os.fsync(f.fileno())
    os.replace(tmp, p)
