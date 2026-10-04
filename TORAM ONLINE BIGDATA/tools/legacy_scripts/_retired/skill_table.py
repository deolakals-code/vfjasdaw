import struct, sys
sys.path.insert(0, r"D:\toram_re")
from parse_text import parse

LAYOUT = "<HHBHBHHHBBBBBBBBH"
COLS = ["SkillUid", "SkillId", "SkillTreeLv", "PremiseId", "SkillTreeType", "Level", "EqLimit", "SkillType",
        "TargetType", "AssistFlag", "PremisePosId", "ConnectPosId", "TreePosX", "TreePosY", "SkillFlag",
        "EventId", "SortId"]

sm = open(r"D:\toram_re\raw\02dc3f32\SkillMaster.dec", "rb").read()
fmt, count = struct.unpack_from("<iI", sm, 0)
rows = [struct.unpack_from(LAYOUT, sm, 8 + i * 24) for i in range(count)]

_, _, texts = parse(open(r"D:\toram_re\text_96613d32\Skill_th.dec", "rb").read())
names = {t: s for t, k, s in texts if k == 0}

if __name__ == "__main__":
    lo, hi = int(sys.argv[1]), int(sys.argv[2])
    print("fmt", fmt, "count", count)
    print("   #  " + " ".join(f"{c:>5}" for c in COLS) + "  name")
    for i in range(lo, min(hi, count)):
        r = rows[i]
        print(f"{i:>4}  " + " ".join(f"{v:>5}" for v in r) + "  " + names.get(r[0], "?"))
    for ci, c in enumerate(COLS):
        vals = sorted(set(r[ci] for r in rows))
        print(f"{c}: {len(vals)} distinct, sample {vals[:14]}{' ...' if len(vals) > 14 else ''}")
