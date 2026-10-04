"""Download bundles listed in the CDN version table into a Unity-cache-shaped folder, so cache.py can read them as
one more root: <root>/<bundle name>/<24 zeros + version LE hex>/__data. Only public asset files; no login, no game server.
Usage: python cdn_fetch.py <regex on bundle key> [channel=A]"""
import os, re, sys, urllib.request
HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, HERE)
from revision import parse

BASE = "https://toram-jp.akamaized.net/resources/android/release{}/"
ROOT = r"D:\toram_re\cdn_cache"


def fetch(url):
    with urllib.request.urlopen(url, timeout=60) as r:
        return r.read()


def main(pattern, ch="A"):
    base = BASE.format(ch)
    table = parse(fetch(base + "RevisionInfoBinary.bytes"))
    todo = [k for k in sorted(table) if re.search(pattern, k)]
    got = skip = 0
    for key in todo:
        ver = table[key][0] & 0xffffffff
        d = os.path.join(ROOT, key.rsplit("/", 1)[-1], "0" * 24 + ver.to_bytes(4, "little").hex())
        path = os.path.join(d, "__data")
        if os.path.exists(path):
            skip += 1
            continue
        b = fetch(base + key + ".unity3d")
        assert b[:7] == b"UnityFS", key
        os.makedirs(d, exist_ok=True)
        open(path, "wb").write(b)
        got += 1
    print(f"{len(todo)} matched, {got} downloaded, {skip} already present -> {ROOT}")


if __name__ == "__main__":
    main(*sys.argv[1:])
