"""Per-skill damage type (SkillAttackType 1 Physics / 2 Magic / 3 SkillNormal / 0 None) and proration slot (SkillExpType).

Static classes come from skill_proration_modes.csv (constant get_AttackType / get_ExpType).
The 21 classes whose getter reads a field are resolved here: getter expression (symexec), ctor default (symexec),
every `set <field>` with its condition (skill_reference.json). DYN below is the reduction of that evidence;
the assert on the getter text fails when the client code stops matching it.
usage: python build_damage_type.py   -> skills/damage/damage_type.csv|json
"""
import sys, re, json, csv
import os
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import il2
import run_skills as R

OUT = r"D:\toram reverse data\skills\damage"
CSV_IN = r"D:\toram reverse data\proration_calculator\skill_proration_modes.csv"
T = {"Physics": ("Physics", "กายภาพ (ใช้ ATK)"), "Magic": ("Magic", "เวท (ใช้ MATK)"),
     "SkillNormal": ("Normal", "ธรรมดา (SkillNormal)"), "None": ("None", "ไม่มีประเภท (None)")}
P, M, N = "Physics", "Magic", "SkillNormal"
SLOT = {"Skill": "ช่องสกิลกายภาพ", "Magic": "ช่องเวท", "Normal": "ช่องตีปกติ", "none": "ไม่มีช่อง"}

# uid -> (getter text expected from symexec, variants [(type, when)], th summary, slot note or None)
DYN = {
 52:  ("this.attackType", [(P, "default (ctor)"), (N, "ActionPreparation: buff-active branch sets attackType=3")],
       "กายภาพ; เป็นธรรมดาเมื่อเข้าเงื่อนไขบัฟตอนเตรียมสกิล", None),
 98:  ("2", [(M, "always")], "เวท; ช่อง proration เป็นช่องตีปกติเมื่อเปิด ExSkill spell tuning (Rod), ไม่งั้นช่องเวท", "Normal if spellTuningJabelin != 0 else Magic"),
 105: ("2", [(M, "always")], "เวท; ช่อง proration เป็นช่องสกิลกายภาพเมื่อมีเจมคาร์ท 403, ไม่งั้นช่องเวท", "Skill if hasGemCart(403) else Magic"),
 114: ("this.attackType", [(M, "default (ctor)"), ("copy", "InitializeChronosShift: = saveSkill.AttackType when a skill is saved and not on cooldown")],
       "เวทเป็นค่าเริ่มต้น; ก๊อปประเภทจากสกิลล่าสุดที่เก็บไว้", None),
 159: ("this.attackType", [("copy", "OnInitialize: = parent action (this+0x128) AttackType (vtable slot 6)"), (M, "InitializeExorcism, not other player"),
                           (P, "InitializeNemesis, not other player")],
       "ได้ประเภทจากสกิลแม่; Exorcism = เวท, Nemesis = กายภาพ", "expType = parent action ExpType (vtable slot 7), unchanged by Exorcism/Nemesis"),
 295: ("this.attackType", [(P, "default (ctor)"), (N, "OnInitialize: Lv == 10")], "กายภาพ; เลเวล 10 เป็นธรรมดา", None),
 558: ("this.attackType", [(P, "InitializeWolfAssault / ChasseGarde / SharpSnipe"), (M, "InitializeHighRainSnipe")],
       "ตามโหมด: Wolf Assault/Chasse Garde/Sharp Snipe = กายภาพ, High Rain Snipe = เวท", None),
 637: ("this.attackType", [(P, "default (ctor); InitializeNagi"), (N, "InitializeKariwatashi / Hibari / Ibuki / Arahae, SkillEventArahae")],
       "กายภาพ; ท่า Kariwatashi/Hibari/Ibuki/Arahae เป็นธรรมดา", None),
 658: ("1", [(P, "always")], "กายภาพ; ช่อง proration เป็นช่องเวท (ctor expType=2)", "Magic (ctor sets expType=2)"),
 659: ("this.attackType", [(P, "default (ctor)"), (M, "OnInitialize: sub weapon is a magic tool")], "กายภาพ; เวทเมื่อถือ magic tool มือรอง", None),
 844: ("(this.isFirst eq 0 ? 2 : 1)", [(P, "isFirst = 1 (ActionPreparation)"), (M, "isFirst = 0 (NextRangeHit)")],
       "ฮิตแรกกายภาพ; ฮิตระยะถัดไป (NextRangeHit) เป็นเวท", None),
 866: ("(this.conversion eq 0 ? 2 : 1)", [(M, "no buff 867 (conversion = 0)"), (P, "buff 867 active (conversion = 1)")], "เวท; กายภาพเมื่อมีบัฟ 867", None),
 868: ("(this.conversion eq 0 ? 2 : 1)", [(M, "no buff 867 (conversion = 0)"), (P, "buff 867 active (conversion = 1)")], "เวท; กายภาพเมื่อมีบัฟ 867", None),
 870: ("(this.conversion ne 0 ? 2 : 1)", [(P, "no buff 867 (conversion = 0)"), (M, "buff 867 active (conversion = 1)")], "กายภาพ; เวทเมื่อมีบัฟ 867 (กลับด้านกับ 866)", None),
 872: ("(this.conversion eq 0 ? 2 : 1)", [(M, "no buff 867 (conversion = 0)"), (P, "buff 867 active (conversion = 1)")], "เวท; กายภาพเมื่อมีบัฟ 867", None),
 874: ("(this.conversion ne 0 ? 2 : 1)", [(P, "no buff 867 (conversion = 0)"), (M, "buff 867 active (conversion = 1)")], "กายภาพ; เวทเมื่อมีบัฟ 867 (กลับด้านกับ 866)", None),
 936: ("this.attackType", [(P, "status.Atk >= status.Matk"), (M, "status.Atk < status.Matk")], "เทียบ ATK กับ MATK ของผู้เล่น: ATK<MATK = เวท, ไม่งั้นกายภาพ", None),
 946: ("this.attackType", [(P, "status.Atk >= status.Matk"), (M, "status.Atk < status.Matk")], "เทียบ ATK กับ MATK ของผู้เล่น: ATK<MATK = เวท, ไม่งั้นกายภาพ", None),
 975: ("(this.isPunishRay ne 0 ? 2 : 1)", [(P, "isPunishRay = 0"), (M, "isPunishRay = 1 (ActionPreparation conditions)")], "กายภาพ; เวทเมื่อเป็นท่า Punish Ray", None),
 980: ("this.attackType", [(P, "always (OnInitialize / CalcFirst/SecondDamageData)")], "กายภาพ; ช่อง proration เป็นช่องเวท (ExpType const 2)", "Magic (const)"),
 1068: ("2", [(M, "always")], "เวท; ช่อง proration ตั้งใน ctor (expType=2) = ช่องเวท", "Magic (ctor sets expType=2)"),
}

def getter_texts():
    R.init(); S = R._G["S"]
    lines = open(os.path.join(il2.DUMP, "dump.cs"), encoding="utf-8", errors="replace").read().splitlines()
    cre = re.compile(r'^(?:public |internal |private |protected )?(?:abstract |sealed |static )*class\s+([^\s:<]+)(?:\s*:\s*([^\s,{/<]+))?')
    base, rva, cls = {}, {}, None
    for i, l in enumerate(lines):
        if not l.startswith((" ", "\t")):
            m = cre.match(l)
            if m: cls = m.group(1); base[cls] = m.group(2)
        elif cls and i:
            m = re.search(r"RVA: (0x[0-9A-Fa-f]+)", lines[i - 1])
            mm = re.search(r"override \S+ get_AttackType\(\)", l)
            if m and mm and "{ }" in l: rva[cls] = int(m.group(1), 16)
    out = {}
    for r in csv.DictReader(open(CSV_IN, encoding="utf-8-sig")):
        uid = int(r["skill_uid"])
        if uid not in DYN: continue
        c = r["cls"]
        while c and c not in rva: c = base.get(c)
        ex = S.Ex(rva[c], max_paths=80, max_ins=5000)
        out[uid] = [S.render(st.ret[0]) for st in ex.run() if st.ret is not None]
    return out


def main():
    ref = {x["uid"]: x for x in json.load(open(OUT + r"\skill_reference.json", encoding="utf-8"))}
    names = {int(r["SkillUid"]): r for r in csv.DictReader(open(r"D:\toram reverse data\skills\skills.csv", encoding="utf-8-sig"))}
    modes = {int(r["skill_uid"]): r for r in csv.DictReader(open(CSV_IN, encoding="utf-8-sig"))}
    got = getter_texts()
    for uid, d in DYN.items():
        assert got[uid] == [d[0]], (uid, got[uid], d[0])
    rows = []
    for uid in sorted(ref):
        rec, m, nm = ref[uid], modes.get(uid), names.get(uid, {})
        row = dict(uid=uid, name_th=nm.get("name_th", ""), tree=nm.get("tree", ""), cls=rec.get("class", ""), in_tree=bool(rec.get("in_skill_tree")),
                   attack_type="", th="", exp_type="", slot="", slot_th="", variants="", note="", evidence="")
        if m is None:
            row.update(attack_type="-", th="ไม่มี action class ฝั่ง client", evidence="no SkillFactory action class")
        elif uid in DYN:
            _, var, th, slot_note = DYN[uid]
            row.update(attack_type="Dynamic", th=th, exp_type=m["exp_type"], slot=m["slot"], slot_th=SLOT.get(m["slot"], m["slot"]),
                       variants="; ".join(f"{T.get(t, (t, t))[0]}: {w}" for t, w in var), note=slot_note or "", evidence="Code (getter + ctor + set statements)")
            if uid == 159: row["evidence"] = "Code (OnInitialize vtable slots 6/7 = AttackType/ExpType of parent action; slot naming Inferred from offset)"
        else:
            t = T[m["attack_type"]]
            row.update(attack_type=t[0], th=t[1], exp_type=m["exp_type"], slot=m["slot"], slot_th=SLOT.get(m["slot"], m["slot"]), evidence="Code (constant getter)")
            if m["attack_type"] != m["exp_type"] and m["attack_type"] != "None":
                row["note"] = f"proration slot ({m['slot']}) differs from damage type ({t[0]}): get_ExpType is a separate override"
        rows.append(row)
    json.dump(rows, open(OUT + r"\damage_type.json", "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    with open(OUT + r"\damage_type.csv", "w", encoding="utf-8-sig", newline="") as f:
        w = csv.DictWriter(f, fieldnames=list(rows[0])); w.writeheader(); w.writerows(rows)
    from collections import Counter
    atk = [r for r in rows if "attack (deals damage)" in (ref[r["uid"]].get("roles") or [])]
    cnt, tot = Counter(r["attack_type"] for r in atk), Counter(r["attack_type"] for r in rows)
    print(len(rows), tot); print("attacking:", len(atk), cnt)
    L = ["# Skill damage type (`SkillAttackType`) and proration slot (`SkillExpType`)", "",
         "Generated by `build_damage_type.py` (evidence label **Code** unless a row says otherwise; nothing checked in game).", "",
         "`SkillAttackType` enum (`SkillAttackType.cs`): 0 None, 1 Physics (ATK), 2 Magic (MATK), 3 SkillNormal (\"normal\" skill: proration slot Normal).",
         "`get_ExpType` is a separate override that picks the proration slot: 1 = Skill (physical), 2 = Magic, 3 = Normal. It usually equals the damage type but not always (see below).", "",
         "Files: `damage_type.csv|json` (one row per skill record, 630). Shown on `explained_th/` and `overview_th/` as `ประเภทดาเมจ`.", "",
         "## Coverage", "", "| group | count |", "|---|---|"]
    L += [f"| attacking skills (role `attack`) | {len(atk)} |"] + [f"| &nbsp;&nbsp;{k} | {cnt[k]} |" for k in ("Physics", "Magic", "Normal", "Dynamic", "None")]
    L += [f"| all 630 records: no client action class | {tot['-']} |", "",
          "`None` on an attacking skill is an explicit constant: CronosDrivePursuit 15, DecoyShooter 78, GuardStrike 262, PetNormalMagic 959 each override `get_AttackType` to return 0 (Code). "
          "How the damage engine treats type 0 is not traced here (element bonus and CalcStable branch on `attackType == 2`, so 0 behaves like Physics there; Inferred).", "",
          "## Dynamic: the getter reads a field (21 classes, all resolved)", "",
          "| uid | class | type by condition | proration slot note |", "|---|---|---|---|"]
    L += [f"| {r['uid']} | {r['cls']} | {r['variants']} | {r['note'] or '-'} |" for r in rows if r["attack_type"] == "Dynamic"]
    L += ["", "## Damage type differs from proration slot (constant getters)", "", "| uid | class | type | slot |", "|---|---|---|---|"]
    L += [f"| {r['uid']} | {r['cls']} | {r['attack_type']} | {r['slot']} |" for r in rows if r["note"].startswith("proration slot")]
    open(OUT + r"\DAMAGE_TYPE.md", "w", encoding="utf-8").write("\n".join(L) + "\n")


if __name__ == "__main__":
    main()
