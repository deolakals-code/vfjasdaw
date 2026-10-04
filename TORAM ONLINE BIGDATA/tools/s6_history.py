"""Stage 6: per-version table inventory of BynaryData (every cached/CDN version) -> readable/masters/_history.csv.
Shows which master tables changed size/content between game data versions."""
import csv, hashlib, json, os, time
from common import ROOT
man = json.load(open(os.path.join(ROOT, "data", "decoded_manifest.json")))
vers = sorted((k.split("/")[1] for k in man if k.startswith("BynaryData/")), key=lambda v: os.path.getmtime(man["BynaryData/" + v]["src"]))
rows, prev = [], {}
for v in vers:
    t = time.strftime("%Y-%m-%d", time.localtime(os.path.getmtime(man["BynaryData/" + v]["src"])))
    d = os.path.join(ROOT, "data", "decoded", "BynaryData", v)
    for fn in sorted(os.listdir(d)):
        b = open(os.path.join(d, fn), "rb").read()
        h = hashlib.sha1(b).hexdigest()[:12]
        n = fn[:-4]
        rows.append([v, t, n, len(b), h, "" if n not in prev else ("same" if prev[n] == h else "changed")])
        prev[n] = h
with open(os.path.join(ROOT, "readable", "masters", "_history.csv"), "w", newline="", encoding="utf-8") as f:
    w = csv.writer(f); w.writerow(["version", "cached_date", "table", "bytes", "sha1_12", "vs_previous"]); w.writerows(rows)
ch = {}
for r in rows:
    if r[5] == "changed": ch.setdefault(r[2], []).append(r[0])
print(len(vers), "versions;", {k: len(v) for k, v in ch.items()})
