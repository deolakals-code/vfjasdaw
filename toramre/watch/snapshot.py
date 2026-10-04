"""A snapshot = content hash of every table of every kept version. Light on purpose: row-level detail is
recomputed from the decoded files when two versions are compared."""
import hashlib
import json
import os

from toramre.core import paths, versions


def sha(b: bytes) -> str:
    return hashlib.sha1(b).hexdigest()[:12]


def take(decoded=None, extra=None):
    """{bundle: {version: {table: {"bytes": n, "sha": h}}}} for every history bundle, plus optional extra facts
    (e.g. {"so_sha256": ...} from the IL2CPP side)."""
    root = decoded or paths.DECODED
    snap = {"bundles": {}, "extra": extra or {}}
    for b in versions.history_bundles(root):
        snap["bundles"][b] = {}
        for v in versions.list_versions(b, root):
            vd = os.path.join(root, b, v)
            tabs = {}
            for fn in sorted(os.listdir(vd)):
                if fn.endswith(".dec"):
                    data = open(os.path.join(vd, fn), "rb").read()
                    tabs[fn[:-4]] = {"bytes": len(data), "sha": sha(data)}
            snap["bundles"][b][v] = tabs
    return snap


def save(snap, path):
    os.makedirs(os.path.dirname(path), exist_ok=True)
    json.dump(snap, open(path, "w"), indent=0, sort_keys=True)


def load(path):
    return json.load(open(path))
