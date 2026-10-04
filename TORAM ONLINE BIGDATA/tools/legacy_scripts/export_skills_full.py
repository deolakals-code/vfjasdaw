"""Enrich skills.json with enum-decoded fields, per-level bonus notes and buff stat tags.
Writes skills/skills_full.json|csv, skills/buff_skills.md and skills/icons/sk_<uid>.png (icons come from the game
install's NGUI atlas via export_items.icon_sprites; everything else is read from this folder).

Verified 2026-09-24 (by skill names across whole table): the column exported as `TargetType` is the real
SkillType enum (1 Attack, 2 Mastery, 3 Support, 4 Buffer, 5 Circle, 6 Object, 7 Heal, 10 Special, 11 Extra);
the column exported as `SkillType` is a different bitmask that no metadata enum explains, kept as `raw_flags`.
"""
import csv, json, re, os, collections
from export_items import icon_sprites

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
enums = collections.defaultdict(dict)
for r in csv.DictReader(open(os.path.join(ROOT, "metadata/constants.tsv"), encoding="utf-8-sig"), delimiter="\t"):
    try:
        enums[r["type"]][r["field"]] = int(r["value"])
    except ValueError:
        pass

by_val = lambda t: {v: k for k, v in enums[t].items()}
SKILL_ID, SKILL_TYPE, TREE_TYPE = by_val("SkillId"), by_val("SkillType"), by_val("SkillTreeType")
SKILL_FLAG = {v: k for k, v in enums["SkillFlag"].items() if v}
EQ = {k: v for k, v in enums["SkillEqLimitFlag"].items() if v and k not in ("AllWeapon", "AllSubWeapon")}

# Thai wording in Skill_th -> stat. Longest phrase first so "ความเร็วการโจมตี" wins over "การโจมตี".
STAT_WORDS = [
    ("ความเร็วการโจมตี", "ASPD"), ("ความเร็วการร่าย", "CSPD"), ("ความเร็วในการร่าย", "CSPD"),
    ("ความเร็วการเคลื่อนที่", "MoveSpeed"), ("ความเร็วเคลื่อนที่", "MoveSpeed"),
    ("ความเสียหายคริติคอล", "CritDamage"), ("อัตราคริติคอล", "CritRate"), ("คริติคอล", "Critical"),
    ("ความเสถียร", "Stability"), ("การโจมตีปกติ", "NormalAttack"), ("การป้องกันเวท", "MDEF"),
    ("MATK", "MATK"), ("ATK", "ATK"), ("MDEF", "MDEF"), ("DEF", "DEF"), ("HIT", "Accuracy"), ("FLEE", "Flee"),
    ("MaxHP", "MaxHP"), ("MaxMP", "MaxMP"), ("HP", "HP"), ("MP", "MP"),
    ("STR", "STR"), ("DEX", "DEX"), ("INT", "INT"), ("AGI", "AGI"), ("VIT", "VIT"),
    ("อัตราการหลบ", "Dodge"), ("หลบหลีก", "Dodge"), ("ป้องกัน", "Guard"), ("ต้านทาน", "Resist"),
    ("ธาตุ", "Element"), ("ผงะ", "Flinch"), ("สภาวะผิดปกติ", "Abnormal"), ("ระยะเวลา", "Duration"),
    ("ความเสียหาย", "Damage"), ("พลังโจมตี", "Power"),
]


def name_variants(raw):
    # "N$base$R2$upgraded" -> {"base": ..., "r2": ...}
    parts = raw.split("$")
    if len(parts) >= 4 and parts[0] == "N" and parts[2] == "R2":
        return parts[1], parts[3]
    return raw, ""


def parse_notes(raw):
    # "10$0$text$11$0$text" -> [{"level": 10, "flag": 0, "text": ...}, ...]; a bare text has no level
    chunks = re.split(r"(?:^|\$)(\d+)\$(\d+)\$", raw)
    if len(chunks) == 1:
        return [{"level": None, "flag": None, "text": raw.strip()}] if raw.strip() else []
    return [
        {"level": int(chunks[i]), "flag": int(chunks[i + 1]), "text": chunks[i + 2].strip()}
        for i in range(1, len(chunks) - 2, 3)
    ]


def strip_color(s):
    return re.sub(r"\[[0-9a-fA-F]{6}\]", "", s)


def tags_of(text):
    found = []
    for word, stat in STAT_WORDS:
        if word in text and stat not in found:
            found.append(stat)
            text = text.replace(word, " ")  # consumed, so "ATK" inside "MATK" is not counted twice
    return found


def eq_names(mask):
    return [k for k, v in EQ.items() if mask & v == v]


atlas, sprites = icon_sprites()
os.makedirs(os.path.join(ROOT, "skills", "icons"), exist_ok=True)
for name, (x, y, w, h) in sprites.items():
    if name.startswith(("sk_", "runn_")):
        atlas.crop((x, y, x + w, y + h)).save(os.path.join(ROOT, "skills", "icons", name + ".png"))

skills = json.load(open(os.path.join(ROOT, "skills/skills.json"), encoding="utf-8"))["skills"]
out = []
for s in skills:
    if s["SkillTreeLv"] <= 0:
        continue
    base, r2 = name_variants(s["name_th"])
    notes = parse_notes(s["notes_th"])
    text = strip_color(s["desc_th"] + " " + " ".join(n["text"] for n in notes))
    out.append({
        "uid": s["SkillUid"],
        "name_en": SKILL_ID.get(s["SkillUid"], ""),
        "name_th": base.strip(),
        "name_th_r2": r2.strip(),
        "category": SKILL_TYPE.get(s["TargetType"], f"?{s['TargetType']}"),
        "tree": s["tree"],
        "tree_type": TREE_TYPE.get(s["SkillTreeType"], s["SkillTreeType"]),
        "tree_lv": s["SkillTreeLv"],
        "max_level": s["Level"],
        "premise_uid": s["PremiseId"],
        "eq_limit": eq_names(s["EqLimit"]),
        "raw_flags": s["SkillType"],
        "flags": [n for v, n in SKILL_FLAG.items() if s["SkillFlag"] & v],
        "assist": bool(s["AssistFlag"]),
        "icon": f"icons/sk_{s['SkillUid']:03d}.png" if f"sk_{s['SkillUid']:03d}" in sprites else "",
        "desc_th": strip_color(s["desc_th"]),
        "notes": [{**n, "text": strip_color(n["text"])} for n in notes],
        "stat_tags": tags_of(text),
    })

os.makedirs(os.path.join(ROOT, "skills"), exist_ok=True)
json.dump(out, open(os.path.join(ROOT, "skills/skills_full.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
with open(os.path.join(ROOT, "skills/skills_full.csv"), "w", encoding="utf-8-sig", newline="") as f:
    w = csv.writer(f)
    cols = ["uid", "name_en", "name_th", "name_th_r2", "category", "tree", "tree_lv", "max_level", "premise_uid",
            "eq_limit", "flags", "assist", "icon", "raw_flags", "stat_tags", "desc_th", "notes"]
    w.writerow(cols)
    for r in out:
        w.writerow([" | ".join(r[c]) if c in ("eq_limit", "flags", "stat_tags") else
                    " || ".join((f"Lv{n['level']}: " if n["level"] is not None else "") + n["text"] for n in r[c]) if c == "notes"
                    else r[c] for c in cols])

with open(os.path.join(ROOT, "skills/buff_skills.md"), "w", encoding="utf-8") as f:
    for cat in ("Buffer", "Support", "Circle", "Heal"):
        rows = [r for r in out if r["category"] == cat]
        f.write(f"## {cat} ({len(rows)})\n\n")
        for r in rows:
            f.write(f"### {r['name_th']} ({r['name_en'] or 'no enum name'}) — {r['tree']}\n")
            f.write(f"- ผลที่กล่าวถึง: {', '.join(r['stat_tags']) or '(ไม่พบคำ stat ในข้อความ)'}\n")
            f.write(f"- {r['desc_th'].replace(chr(10), ' ')}\n")
            for n in r["notes"]:
                f.write(f"- [{'Lv' + str(n['level']) if n['level'] is not None else 'note'}] {n['text'].replace(chr(10), ' ')}\n")
            f.write("\n")

cat = collections.Counter(r["category"] for r in out)
print(len(out), "skills;", dict(cat))
buff = [r for r in out if r["category"] in ("Buffer", "Support", "Circle", "Heal")]
print("buff-like:", len(buff), "| without stat tag:", sum(1 for r in buff if not r["stat_tags"]))
print("no Thai desc:", sum(1 for r in out if not r["desc_th"]), "| no en name:", sum(1 for r in out if not r["name_en"]))
