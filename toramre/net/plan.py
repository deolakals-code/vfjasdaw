"""Work list for a fetch: category / regex filters, skip what is on disk, delta against the last fetch."""
import os
import re
from dataclasses import dataclass

from .catalog import ver_hex

# first path segment of the bundle key -> category (from catalog_A, 2026-10-04)
CATEGORY = {
    "BynaryData": "data", "EventShopData": "data", "CommonAssetBundle": "data",
    "Localize": "text",
    "FieldScript": "script", "MiniGame": "script",
    "Mob": "model", "Npc": "model", "Myroom": "model", "Avatar": "model", "Servant": "model", "Prop": "model",
    "Fish": "model", "UIModel": "model", "Effect": "model",
    "BGM": "audio", "SE": "audio",
    "Field": "field",
}
SIZE_UNIT = 10_400  # bytes per catalog size unit (Inferred from Content-Length samples; estimates only)


def category(key):
    return CATEGORY.get(key.split("/", 1)[0], "other")


@dataclass
class Job:
    key: str
    version: int
    size_units: int
    channel: str

    @property
    def vhex(self):
        return ver_hex(self.version)

    @property
    def bundle(self):
        return self.key.rsplit("/", 1)[-1]

    def dest(self, root):
        """Unity-cache layout read by cache.py: <root>/<bundle>/<24 zeros + version LE hex>/__data"""
        return os.path.join(root, self.bundle, "0" * 24 + self.vhex, "__data")

    @property
    def est_bytes(self):
        return self.size_units * SIZE_UNIT


def build(table, channel, root, only=("all",), match=None, manifest=None, include_present=False):
    """-> (jobs to fetch, skipped count). `only`: categories or 'all'; `match`: regex on the key."""
    rx = re.compile(match) if match else None
    jobs, skipped = [], 0
    for key in sorted(table):
        ver, _typ, sz = table[key]
        if "all" not in only and category(key) not in only:
            continue
        if rx and not rx.search(key):
            continue
        j = Job(key, ver, sz, channel)
        if not include_present and os.path.exists(j.dest(root)):
            m = (manifest or {}).get(key)
            if m is None or m.get("version") == j.vhex:
                skipped += 1
                continue
        jobs.append(j)
    return jobs, skipped


def summary(jobs):
    out = {}
    for j in jobs:
        c = out.setdefault(category(j.key), [0, 0])
        c[0] += 1
        c[1] += j.est_bytes
    return out
