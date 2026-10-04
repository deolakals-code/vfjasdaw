"""Mastery parameter table for the Details-screen calculator (player_status/mastery_table.json).

Source: `D:\\toram_re\\masteryrecipes\\*.json` (run_masteries.py: every `SkillMasteryBase.GetMasteryParam(MasteryId)` of the 128 mastery classes, symbolic execution of libil2cpp).
Per mastery: skill uid, class, Thai name, tree, max level, and per MasteryId parameter the expression in `Lv` plus the value for every level 1..max.
Decoder residue fixed here (each one asserted, so a changed recipe fails loudly):
  vec(lo, hi)                          a double literal loaded as two 32-bit halves (Bushido AtkRate: 0x3fc999999999999a = 0.2)
  System.Math.Max(a, b, 0, ?x3)        Math.Max takes two arguments, the rest is stray argument registers (Knowledge of Magic Warrior Matk / CspdRate)
  this.allWizardSkillLevel / learnWizardSkillNum / active   CastMastery fields, filled by PlayerSecondaryStatus.get_Cspd (SetSkillLearnData(GetAllSkillLvInTree(0x20), GetSkillNumInTree(0x20)),
                                       SetActive): inputs of the calculator, listed under `inputs`
Run (cwd D:\\toram_re):  python "D:\\toram reverse data\\scripts\\build_mastery_table.py"
Label: Code (decoded from libil2cpp.so); not checked in game.
"""
import sys, os, re, json, glob, csv, struct

sys.path.insert(0, r"D:\toram_re")
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import calc_engine as CE

REC = r"D:\toram_re\masteryrecipes"
SKILLS = r"D:\toram reverse data\skills\skills.csv"
OUT = r"D:\toram reverse data\player_status\mastery_table.json"
WIZARD_TREE = 0x20          # PlayerSecondaryStatus.get_Cspd: mov w1, #0x20 before SkillManager.GetAllSkillLvInTree / GetSkillNumInTree
INPUT_NAMES = {"this.allWizardSkillLevel": "WizardTreeLevelSum", "this.learnWizardSkillNum": "WizardTreeSkillCount", "this.active": "CastMasteryActive"}


def fix(expr):
    def vec(m):
        lo, hi = int(m.group(1), 16), int(m.group(2), 16)
        return repr(struct.unpack("<d", struct.pack("<Q", (hi << 32) | lo))[0])
    expr = re.sub(r"vec\((0x[0-9a-f]+), (0x[0-9a-f]+)\)", vec, expr)
    expr = expr.replace("System.Math.Max((Lv - 5), 0, 0, ?x3)", "System.Math.Max((Lv - 5), 0)")
    for k, v in INPUT_NAMES.items():
        expr = expr.replace(k, v)
    return expr


RAW_SKILLMASTER = r"D:\toram_re\raw\02dc3f32\SkillMaster.dec"          # same table version as skills.csv


def eq_limits():
    """SkillMasterData.EqLimit is a 32-bit SkillEqLimitFlag (CreateSkillData reads an int). The 24-byte record is `<HHBHBH I BBBBBBBB H`; skills.csv kept only the low half as EqLimit
    and the high half under the name `SkillType` (Halberd 0x80000, Katana 0x100000, ..., MainHand 0x10000000 live there)."""
    sm = open(RAW_SKILLMASTER, "rb").read()
    _, count = struct.unpack_from("<iI", sm, 0)
    out = {}
    for i in range(count):
        uid, _id, _lv, _pre, _tt, _lvl, eq = struct.unpack_from("<HHBHBHI", sm, 8 + i * 24)
        out[uid] = eq
    return out


def skills():
    out, eq = {}, eq_limits()
    for r in csv.DictReader(open(SKILLS, encoding="utf-8-sig")):
        uid = int(r["SkillUid"])
        assert eq[uid] & 0xffff == int(r["EqLimit"]) and eq[uid] >> 16 == int(r["SkillType"]), uid          # csv columns = the two halves
        out[uid] = {"name": r["name_th"], "tree": r["tree"], "treeType": int(r["SkillTreeType"]), "maxLv": int(r["Level"]), "eqLimit": eq[uid]}
    return out


DOUBLE_THROW = "(50 + ((2 * (Lv >> 1)) * (Lv >> 1)) + (((Lv & 1) * 2) * (Lv >> 1)))"


def double_throw_trigger_neon(lv):
    """DoubleThrow.GetMasteryParam(Trigger) 0x2359020 is an auto-vectorised loop (NEON: addv / cmhi / bsl): lane accumulator starts at the rodata vector 0x945480 = (50, 0, 0, 0), lane indices start at
    0x946360 = (0, 1, 2, 3) and step 4, each step adds (index & 0x7ffffffe); lanes whose index is above Lv keep the previous value. Emulated here from the binary's own constants."""
    import dis_android as D
    acc = list(struct.unpack("<4I", D.b[0x945480:0x945490]))
    idx = list(struct.unpack("<4I", D.b[0x946360:0x946370]))
    steps = ((lv + 4) & 0x1fc) // 4
    for _ in range(steps):
        prev = acc[:]
        acc = [((i & 0x7ffffffe) + a) & 0xffffffff for i, a in zip(idx, prev)]
        last = idx[:]
        idx = [i + 4 for i in idx]
    return sum(prev[k] if last[k] > lv else acc[k] for k in range(4)) & 0xffffffff


def main():
    sk = skills()
    G = {"vars": {}}
    res, residue = {}, []
    for f in sorted(glob.glob(os.path.join(REC, "*.json"))):
        r = json.load(open(f, encoding="utf-8"))
        uid = r["uid"]
        s = sk.get(uid, {})
        maxlv = s.get("maxLv") or 10
        params, inputs = {}, set()
        for name, b in r["by_id"].items():
            e = fix(b["expr"])
            if uid == 293 and name == "Trigger":          # the decoder cannot read the NEON loop: closed form, asserted against an emulation of the instructions at every level
                assert e == "?addv", e
                assert all(double_throw_trigger_neon(n) == CE.Evaluator({"Lv": n}, G).eval(DOUBLE_THROW) for n in range(1, maxlv + 1))
                e = DOUBLE_THROW
            if re.search(r"\?\w|\+0x|vec\(", e):
                residue.append((uid, r["class"], name, e))
            used = sorted(set(INPUT_NAMES.values()) & set(re.findall(r"\w+", e)))
            inputs.update(used)
            lv = None
            if not used and not re.search(r"\?\w|\+0x", e):
                try:
                    lv = [CE.Evaluator({"Lv": n, "id": b["id"], "System.Math.Max": max}, G).eval(e) for n in range(1, maxlv + 1)]
                except CE.Unresolved as u:          # a free `id` left by the decoder (a parameter that is not a MasteryId branch)
                    residue.append((uid, r["class"], name, f"{e}  [unresolved {u}]"))
            params[name] = {"id": b["id"], "expr": e, "byLevel": lv}
        res[uid] = {"class": r["class"], "name": s.get("name", ""), "tree": s.get("tree", ""), "treeType": s.get("treeType"), "maxLv": maxlv, "eqLimit": s.get("eqLimit"),
                    "params": params, "inputs": sorted(inputs)}
    # residue left in masteries the Details screen never reads is reported, not hidden
    # evidence for the two hand fixes: the recipe still has the residue shape we replaced
    bush = json.load(open(os.path.join(REC, "0612_Bushido.json"), encoding="utf-8"))["by_id"]["AtkRate"]["expr"]
    assert "vec(0x9999999a, 0x3fc99999)" in bush, bush
    kn = json.load(open(os.path.join(REC, "0865_KnowledgeOfMagicWarriorMastary.json"), encoding="utf-8"))["by_id"]["Matk"]["expr"]
    assert "System.Math.Max((Lv - 5), 0, 0, ?x3)" in kn, kn
    json.dump({"note": "mastery parameters per skill level; `byLevel[i]` = Lv i+1; params with `inputs` depend on caster state (CastMastery: wizard-tree skill levels / count, active flag)",
               "inputs": {"WizardTreeLevelSum": f"sum of the levels of the learned skills of skill tree {WIZARD_TREE} (SkillManager.GetAllSkillLvInTree)",
                          "WizardTreeSkillCount": f"number of learned skills in skill tree {WIZARD_TREE} (SkillManager.GetSkillNumInTree)",
                          "CastMasteryActive": "CastMastery.SetActive flag"},
               "residual": [{"uid": u, "class": c, "param": n, "expr": e} for u, c, n, e in residue], "skillEqLimit": {str(u): v["eqLimit"] for u, v in sk.items()}, "masteries": res}, open(OUT, "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    n = sum(len(m["params"]) for m in res.values())
    nl = sum(1 for m in res.values() for p in m["params"].values() if p["byLevel"] is None)
    print("residual:", residue)
    print(f"{len(res)} masteries, {n} parameters, {nl} without a level table (caster inputs): {[(u, m['class']) for u, m in res.items() if any(p['byLevel'] is None for p in m['params'].values())]}")


if __name__ == "__main__":
    main()
