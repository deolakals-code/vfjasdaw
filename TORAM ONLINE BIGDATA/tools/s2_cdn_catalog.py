"""Stage 2: full CDN bundle catalog (RevisionInfoBinary of releaseA-F, android) -> data/cdn/catalog_<ch>.csv + summary.
Only the small version table is downloaded here; no bundle bodies."""
import os, sys, urllib.request, urllib.error, csv, re, collections
ROOT = r"D:\toram reverse data"
sys.path.insert(0, ROOT + r"\scripts")
from revision import parse
OUT = ROOT + r"\TORAM ONLINE BIGDATA\data\cdn"
BASE = "https://toram-jp.akamaized.net/resources/android/release{}/"
for ch in "ABCDEF":
    try:
        raw = urllib.request.urlopen(BASE.format(ch) + "RevisionInfoBinary.bytes", timeout=60).read()
    except urllib.error.HTTPError as e:
        print(ch, "HTTP", e.code); continue
    open(f"{OUT}\RevisionInfoBinary_{ch}.bytes", "wb").write(raw)
    t = parse(raw)
    with open(f"{OUT}\catalog_{ch}.csv", "w", newline="", encoding="utf-8") as f:
        w = csv.writer(f); w.writerow(["key", "version", "type", "size"])
        for k in sorted(t): w.writerow([k, t[k][0] & 0xffffffff, t[k][1], t[k][2]])
    cat = collections.defaultdict(lambda: [0, 0])
    for k, (v, ty, sz) in t.items():
        c = re.sub(r"\d+", "#", k.rsplit("/", 1)[-1]); cat[c][0] += 1; cat[c][1] += sz
    print(ch, len(t), "bundles", round(sum(v[1] for v in cat.values()) / 1e6), "MB")
    if ch == "A":
        for c, (n, s) in sorted(cat.items(), key=lambda x: -x[1][1]): print(f"  {c:40}{n:6}{s/1e6:10.2f}MB")
