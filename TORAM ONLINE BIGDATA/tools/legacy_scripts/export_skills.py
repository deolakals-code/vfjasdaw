import csv, json, os, sys
sys.path.insert(0, r"D:\toram_re")
from skill_table import rows, texts, COLS

# Names come from SkillMasterData in metadata (declaration order matches the 24-byte record).
# Value semantics verified against the tree: SkillUid, SkillTreeLv, PremiseId, SkillTreeType, EqLimit, TreePosX/Y.
VERIFIED = {"SkillUid", "SkillTreeLv", "PremiseId", "SkillTreeType", "EqLimit", "TreePosX", "TreePosY"}
FIELDS = [(c, c in VERIFIED) for c in COLS]

by_kind = {}
for tid, kind, s in texts:
    by_kind.setdefault(tid, {})[kind] = s.replace("\\n", "\n")

tree_name = {r[4]: by_kind.get(r[0], {}).get(0, "") for r in rows if r[2] == 0 and r[0]}

out_dir = r"D:\toram_re\out"
os.makedirs(out_dir, exist_ok=True)
records = []
for r in rows[1:]:
    rec = {name: v for (name, _), v in zip(FIELDS, r)}
    t = by_kind.get(r[0], {})
    rec.update(tree=tree_name.get(r[4], ""), name_th=t.get(0, ""), desc_th=t.get(1, ""), notes_th=t.get(2, ""))
    records.append(rec)

with open(os.path.join(out_dir, "skills.json"), "w", encoding="utf-8") as f:
    json.dump({"verified_fields": [n for n, ok in FIELDS if ok], "skills": records}, f, ensure_ascii=False, indent=1)
with open(os.path.join(out_dir, "skills.csv"), "w", encoding="utf-8-sig", newline="") as f:
    w = csv.DictWriter(f, fieldnames=list(records[0]))
    w.writeheader()
    w.writerows(records)

real = [r for r in records if r["SkillTreeLv"] > 0]
print(len(records), "records,", len(real), "skills,", len(tree_name), "trees")
print("trees:", " | ".join(f"{k}:{v}" for k, v in sorted(tree_name.items())))
print("missing names:", sum(1 for r in records if not r["name_th"]))
