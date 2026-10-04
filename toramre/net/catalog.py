"""CDN version tables of channels A-F -> data/cdn (raw + catalog_<ch>.csv), and the choice of the newest channel."""
import csv
import os
import urllib.error

from toramre.core import paths, versions as V
from . import revision

BASE = "https://toram-jp.akamaized.net/resources/android/release{}/"
CHANNELS = "ABCDEF"
CDN_DIR = os.path.join(paths.BIGDATA, "data", "cdn")


def base_url(ch):
    return BASE.format(ch)


def ver_hex(ver):
    return (ver & 0xffffffff).to_bytes(4, "little").hex()


def refresh(client, channels=CHANNELS, out_dir=None, base=None):
    """Download every channel's RevisionInfoBinary.bytes; 404 = channel absent. -> {ch: table}."""
    out_dir = out_dir or CDN_DIR
    os.makedirs(out_dir, exist_ok=True)
    tables = {}
    for ch in channels:
        url = (base or BASE).format(ch) + "RevisionInfoBinary.bytes"
        try:
            with client.open(url) as r:
                raw = r.read()
        except urllib.error.HTTPError as e:
            if e.code in (403, 404):
                continue
            raise
        t = revision.parse(raw)
        with open(os.path.join(out_dir, f"RevisionInfoBinary_{ch}.bytes"), "wb") as f:
            f.write(raw)
        with open(os.path.join(out_dir, f"catalog_{ch}.csv"), "w", newline="", encoding="utf-8") as f:
            w = csv.writer(f, lineterminator="\n")
            w.writerow(["key", "version", "type", "size"])
            for k in sorted(t):
                w.writerow([k, t[k][0] & 0xffffffff, t[k][1], t[k][2]])
        tables[ch] = t
    return tables


def diff(old, new):
    """Version-table changes per channel -> [{"channel", "key", "kind": new|changed|removed, "from", "to"}]."""
    out = []
    for ch in sorted(set(old) | set(new)):
        a, b = old.get(ch, {}), new.get(ch, {})
        for k in sorted(set(a) | set(b)):
            if k not in a:
                out.append({"channel": ch, "key": k, "kind": "new", "from": None, "to": ver_hex(b[k][0])})
            elif k not in b:
                out.append({"channel": ch, "key": k, "kind": "removed", "from": ver_hex(a[k][0]), "to": None})
            elif a[k][0] != b[k][0]:
                out.append({"channel": ch, "key": k, "kind": "changed", "from": ver_hex(a[k][0]), "to": ver_hex(b[k][0])})
    return out


def load(out_dir=None):
    """Stored tables -> {ch: table}."""
    out_dir = out_dir or CDN_DIR
    out = {}
    for ch in CHANNELS:
        p = os.path.join(out_dir, f"RevisionInfoBinary_{ch}.bytes")
        if os.path.exists(p):
            out[ch] = revision.parse(open(p, "rb").read())
    return out


def default_channel(tables):
    """Channel A (the old cdn_fetch default; PROJECT.md: A and D carry the newest BynaryData) unless it is absent.
    Channels carry different version numbers (2026-09-29: A/D a7e43f32, B 61304932, C ebdb3f32) and the number is not
    a release order, so no channel is called newer by its number."""
    return "A" if "A" in tables else (sorted(tables)[0] if tables else None)


def channel_report(tables):
    """{ch: BynaryData version hex}, plus which of them appear in readable/masters/_history.csv."""
    hist = set(V.history_order())
    out = {}
    for ch, t in sorted(tables.items()):
        bd = t.get("BynaryData")
        v = ver_hex(bd[0]) if bd else None
        out[ch] = {"BynaryData": v, "decoded_here": v in hist}
    return out
