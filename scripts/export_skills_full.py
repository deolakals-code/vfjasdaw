"""Enrich skills.json with enum-decoded fields, per-level bonus notes and buff stat tags.
Writes skills/skills_full.json|csv and skills/icons/sk_<uid>.png (icons come from the game
install's NGUI atlas via export_items.icon_sprites; everything else is read from this folder).

Verified 2026-09-24 (by skill names across whole table): the column exported as `TargetType` is the real
SkillType enum (1 Attack, 2 Mastery, 3 Support, 4 Buffer, 5 Circle, 6 Object, 7 Heal, 10 Special, 11 Extra);
the column exported as `SkillType` is the HIGH half of the 32-bit `EqLimit` (SkillMasterData.CreateSkillData reads `EqLimit` as one Int32 at +0x24, then SkillType as a byte; fixed 2026-10-03):
Halberd 0x80000, Katana 0x100000, SubMagictool, NinjutsuScroll, MainKnuckle / MainMagictool / MainKatana, DualSwordImpossible, SubKatana, MainHand, SubWeaponExclusion live there. `eq_limit` now uses the full mask; `eq_limit_mask` is its number.
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

# the game picks the sprite per SkillId (UIIconBase.SkillIcon, see build_skill_icon_map.py); every uid gets icons/sk_<uid>.png = its mapped sprite
icon_of = {}
for e in json.load(open(os.path.join(ROOT, "skills", "icon_map.json"), encoding="utf-8")):
    if e["source"] == "fallback":
        continue
    x, y, w, h = sprites[e["sprite"]]
    for uid in e["uids"]:
        atlas.crop((x, y, x + w, y + h)).save(os.path.join(ROOT, "skills", "icons", f"sk_{uid:03d}.png"))
        icon_of[uid] = e["sprite"]

SKILL_FLAG_CANNOTUSE = next(v for v, n in SKILL_FLAG.items() if n == "CanNotUse")


def icon_reason(s, base):
    """Why UIIconBase.SkillIcon found no sprite (Code): sk_<SkillId:D3> is not in the atlas, CheckSprite fails, the game draws mapMarker_2.
    tree_header = a '#...' tree label or unnamed header row; unreleased = CanNotUse flag; no_sprite_shipped = released, atlas has none."""
    if base.strip().startswith("#"):
        return "tree_header"
    if s["SkillFlag"] & SKILL_FLAG_CANNOTUSE:
        return "unreleased"
    return "no_sprite_shipped"


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
        "eq_limit": eq_names(s["EqLimit"] | (s["SkillType"] << 16)),
        "eq_limit_mask": s["EqLimit"] | (s["SkillType"] << 16),
        "flags": [n for v, n in SKILL_FLAG.items() if s["SkillFlag"] & v],
        "assist": bool(s["AssistFlag"]),
        "icon": f"icons/sk_{s['SkillUid']:03d}.png" if s["SkillUid"] in icon_of else "",
        "icon_sprite": icon_of.get(s["SkillUid"], ""),
        "icon_reason": "" if s["SkillUid"] in icon_of else icon_reason(s, base),
        "desc_th": strip_color(s["desc_th"]),
        "notes": [{**n, "text": strip_color(n["text"])} for n in notes],
        "stat_tags": tags_of(text),
    })

os.makedirs(os.path.join(ROOT, "skills"), exist_ok=True)
json.dump(out, open(os.path.join(ROOT, "skills/skills_full.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
with open(os.path.join(ROOT, "skills/skills_full.csv"), "w", encoding="utf-8-sig", newline="") as f:
    w = csv.writer(f)
    cols = ["uid", "name_en", "name_th", "name_th_r2", "category", "tree", "tree_lv", "max_level", "premise_uid",
            "eq_limit", "eq_limit_mask", "flags", "assist", "icon", "icon_sprite", "icon_reason", "stat_tags", "desc_th", "notes"]
    w.writerow(cols)
    for r in out:
        w.writerow([" | ".join(r[c]) if c in ("eq_limit", "flags", "stat_tags") else
                    " || ".join((f"Lv{n['level']}: " if n["level"] is not None else "") + n["text"] for n in r[c]) if c == "notes"
                    else r[c] for c in cols])

cat = collections.Counter(r["category"] for r in out)
print(len(out), "skills;", dict(cat))
buff = [r for r in out if r["category"] in ("Buffer", "Support", "Circle", "Heal")]
print("buff-like:", len(buff), "| without stat tag:", sum(1 for r in buff if not r["stat_tags"]))
print("no Thai desc:", sum(1 for r in out if not r["desc_th"]), "| no en name:", sum(1 for r in out if not r["name_en"]))
