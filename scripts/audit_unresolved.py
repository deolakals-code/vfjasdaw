"""Master TODO list: every unresolved marker the Thai skill pages still show.
usage: python audit_unresolved.py  -> skills/damage/unresolved.csv (uid, kind, symbol, snippet) + counts per kind
"""
import re, glob, csv, os, collections, sys

BASE = os.path.join(os.path.dirname(os.path.abspath(__file__)), "..", "skills", "damage")
HEAD = re.compile(r"^### .*· uid (\d+)\s*$")
OK_CALLS = {"int", "min", "max", "hasBuff", "System.Math.Max", "System.Math.Min", "meter", "gemCart", "stkp", "player", "Lv", "SkillLv"}

KINDS = [
    ("lookup", re.compile(r"ค่าจากตาราง/บัพที่โค้ดค้นหา")),
    ("opaque_q", re.compile(r"(?<![\w?])\?(?!:)[a-z]\w*")),
    ("stkp", re.compile(r"stkp\(")),
    ("meter", re.compile(r"meter\(\d*\)")),
    ("get_size", re.compile(r"get_Size\(\)")),
    ("raw_offset", re.compile(r"\[[^\]]{0,80}\+0x[0-9a-f]+\]|(?<![\w.])\+0x[0-9a-f]+")),
    ("ret_line", re.compile(r"ค่าที่ `[^`]+` คืนให้")),
    ("marker_buff", re.compile(r"บัพแบบมี/ไม่มี")),
    ("runtime_input", re.compile(r"ขึ้นกับค่าในสถานการณ์จริง")),
]
CALL = re.compile(r"`?([A-Za-z_][\w]*(?:\.[A-Za-z_][\w`<>]*)+)\(")


def main():
    rows, counts = [], collections.Counter()
    uids = set()
    for f in sorted(glob.glob(os.path.join(BASE, "explained_th", "*.md"))):
        uid = None
        for ln in open(f, encoding="utf-8"):
            m = HEAD.match(ln)
            if m: uid = int(m.group(1)); uids.add(uid); continue
            if uid is None or ln.startswith("<!--"): continue
            for kind, rx in KINDS:
                for mm in rx.finditer(ln):
                    rows.append((uid, kind, mm.group(0)[:60], ln.strip()[:300]))
                    counts[kind] += 1
            for mm in CALL.finditer(ln):
                nm = mm.group(1)
                if nm in OK_CALLS: continue
                rows.append((uid, "callee", nm, ln.strip()[:300]))
                counts["callee"] += 1
    out = os.path.join(BASE, "unresolved.csv")
    with open(out, "w", encoding="utf-8-sig", newline="") as fh:
        w = csv.writer(fh); w.writerow(["uid", "kind", "symbol", "snippet"]); w.writerows(rows)
    print(len(uids), "skills,", len(rows), "findings ->", out)
    for k, v in counts.most_common(): print(f"  {k:14s} {v:5d}  skills={len({r[0] for r in rows if r[1] == k})}")
    sym = collections.Counter(r[2] for r in rows if r[1] == "callee")
    print("distinct callees:", len(sym))


if __name__ == "__main__":
    main()
