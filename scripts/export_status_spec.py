"""Export the Details-screen evaluator as one self-contained JSON for the web backend (vercel/private/status-spec.json).

The Python evaluator (player_status.py) is the reference. This writes everything a port needs and nothing else: the closure of decoded functions the
194 rows can reach (texts already cleaned: float bit patterns, raw loads, unlearned masteries), the rows, the enum constants they read, and the rules
that stand in for what a character does not have. `--golden FILE` also writes sample characters with the reference results for the port's test.

Run (cwd D:\\toram_re):  python "D:\\toram reverse data\\scripts\\export_status_spec.py" [--golden FILE]
"""
import sys, os, re, json, collections  # noqa

sys.path.insert(0, r"D:\toram reverse data\scripts")
sys.path.insert(0, r"D:\toram_re")
import calc_engine as CE
import player_status as P

OUT = r"D:\toram reverse data\player_status\status_spec.json"
ABSTRACT = {"calcEqAtkBonus", "calcAtkParam", "calcMatkParam", "calcAspdParam", "CalcStable", "CalcSubAtk", "SubCalcStable", "SubCalcMatk"}          # `abstract` in dump.cs: EquipItemData.WeaponTypeCalculatorBase
G = P.G


def texts_of(im):
    for c in im["cases"]:
        yield c["value"]
        yield from c["common"]
        for var in c.get("variants") or []:
            yield from var
    yield from im.get("lets", {}).values()


def walk(n, calls, names):
    if not isinstance(n, tuple): return
    k = n[0]
    if k == "call":
        calls.add(n[1])
        for a in n[2]: walk(a, calls, names)
    elif k == "name":
        names.add(n[1])
    elif k == "num":
        pass
    elif k in ("field",):
        walk(n[1], calls, names)
    elif k == "cmp":
        walk(n[2], calls, names); walk(n[3], calls, names)
    else:
        for a in n[1:]:
            walk(a, calls, names)


def handled_by_rule(nm):
    return nm in P.ENV_HANDLED or bool(P.OBJECT_GETTERS.search(nm) or P.ABSENT_BUFFER.search(nm) or P.ABSENT.search(nm) or P.NOT_IN_BATTLE.search(nm) or P.BARRIER.search(nm))


def main():
    import bonus_overrides, armour_overrides
    bonus_overrides.check()          # the hand-decoded bodies must still match the binary
    armour_overrides.check()
    panel = json.load(open(P.PANEL, encoding="utf-8"))
    rows = P.rows_of(panel)
    fns, consts_v, consts_env, bad = {}, {}, {}, {}
    todo = collections.deque()
    row_calls = []

    def scan(text, owner):
        raw = []
        t = P.clean(text, raw)
        try:
            ast = CE.Parser(t).parse()
        except Exception as e:
            bad[owner] = str(e)[:60]
            return t, raw, True
        calls, names = set(), set()
        walk(ast, calls, names)
        for nm in names:
            v = G["vars"].get(nm)
            if v and v.get("values") is not None: consts_v[nm] = v["values"]
            elif v and v.get("value") is not None: consts_v[nm] = v["value"]
            elif nm in P.CONSTS: consts_env[nm] = P.CONSTS[nm]
        for nm in calls:
            todo.append((nm, owner))
        return t, raw, False

    out_rows = []
    for r in rows:
        raw_all = []
        t, raw, failed = scan(r["expr"], f"row {r['type']}")
        when = [scan(w, f"row {r['type']} when")[0] for w in (r["when"] or [])]
        out_rows.append({"section": r["method"][3:], "type": r["type"], "expr": t, "when": when, "format": r["format"], "failed": failed, "raw0": len(raw)})

    seen = set()
    while todo:
        nm, owner = todo.popleft()
        if nm in seen: continue
        seen.add(nm)
        if nm.startswith("IPlayerStatusCalculator."):
            todo.append(("PlayerSecondaryStatus." + nm.split(".", 1)[1], owner)); continue
        cands = [nm]
        if nm.startswith(P.VIRTUAL):          # the dispatcher may pick any concrete calculator
            cands += [f"EquipItemData.{c}Calculator.{nm[len(P.VIRTUAL):]}" for c in list(P.CALC_OF_TYPE.values()) + ["Hund"]]
        for c in cands:
            if c != nm: seen.add(c)
            if handled_by_rule(c) or c in P.CE.Evaluator.BUILTIN: continue
            if c.startswith(P.VIRTUAL) and c[len(P.VIRTUAL):] in ABSTRACT: continue          # no body in the client: the glossary entry is a copy of one subclass
            v = G["vars"].get(c)
            if not v or not v.get("impls"): continue
            for im in v["impls"]:
                if not im.get("cases") or im.get("returns") in (None, "void"): continue
                raw_n = 0
                cases = []
                for cs in im["cases"]:
                    val, r1, f1 = scan(cs["value"], c)
                    com = [scan(w, c)[0] for w in cs["common"]]
                    var = [[scan(w, c)[0] for w in vv] for vv in (cs.get("variants") or [])]
                    cases.append({"value": val, "common": com, "variants": var}); raw_n += len(r1)
                lets = {}
                for k, tx in im.get("lets", {}).items():
                    lets[k], r1, _ = scan(tx, c); raw_n += len(r1)
                fns[c] = {"params": [p[1] for p in im.get("params", [])], "static": bool(im.get("static", False)), "cases": cases, "lets": lets, "raw0": raw_n}
                break
    # per-row flag: does the row reach a function whose text had a raw load taken as 0 (conservative: any branch)
    reach_cache = {}

    def reach(fname, acc):
        if fname in acc: return
        acc.add(fname)
        f = fns.get(fname)
        if not f: return
        for tx in [c["value"] for c in f["cases"]] + list(f["lets"].values()) + [w for c in f["cases"] for w in c["common"]]:
            try:
                calls, names = set(), set(); walk(CE.Parser(tx).parse(), calls, names)
            except Exception:
                continue
            for nm in calls:
                reach(nm, acc)
                if nm.startswith("IPlayerStatusCalculator."): reach("PlayerSecondaryStatus." + nm.split(".", 1)[1], acc)
                if nm.startswith(P.VIRTUAL):
                    for c in list(P.CALC_OF_TYPE.values()) + ["Hund"]: reach(f"EquipItemData.{c}Calculator.{nm[len(P.VIRTUAL):]}", acc)
    for r in out_rows:
        acc = set()
        try:
            calls, names = set(), set(); walk(CE.Parser(r["expr"]).parse(), calls, names)
        except Exception:
            calls = set()
        for nm in calls:
            reach(nm, acc)
            if nm.startswith("IPlayerStatusCalculator."): reach("PlayerSecondaryStatus." + nm.split(".", 1)[1], acc)
        r["assumed0"] = r["raw0"] > 0 or any(fns[a]["raw0"] for a in acc if a in fns)
        del r["raw0"]

    labels = {}
    txt = r"D:\toram reverse data\TORAM ONLINE BIGDATA\readable\text"
    for lang in ("th", "us"):
        for ln in open(f"{txt}\\GameScene_{lang}\\System_{lang}.tsv", encoding="utf-8").read().splitlines()[1:]:
            p = ln.split("\t")
            if len(p) >= 4 and p[0].startswith("StatusDetailType"):
                labels.setdefault(p[0][len("StatusDetailType"):], {})["th" if lang == "th" else "en"] = p[3].strip()
    labels = {t: labels[t] for t in {r["type"] for r in out_rows} if t in labels}
    # a name counts as read when it appears in a row's call closure OR adding it to an empty character moves a row (the evaluator env reads
    # some through helper outs such as GetMaxHpBonusConstant_Rate.out1, which no text scan sees)
    import measure_bonus_reach as M
    named = {n.split(".", 1)[1] for n in list(consts_v) + list(consts_env) if n.startswith("BonusType.")}
    moved = M.reach(sorted(n for n in P.BONUS_BY_ID.values() if re.match(r"b[A-Z]", n)))
    read = sorted(named | {n for n, rows in moved.items() if rows})
    gloss = lambda k: re.sub(r"\s*\(id \d+[^)]*\)", "", (G["vars"].get(f"BonusType.{k}") or {}).get("gloss_th") or "")
    bonus_read = [{"k": k, "th": gloss(k) or None, "rows": moved.get(k, [])} for k in read if re.match(r"b[A-Z]", k)]
    spec = {
        "note": "Generated by scripts/export_status_spec.py from the decoded client (libil2cpp). Code, not verified against an in-game screen.",
        "rows": out_rows, "labels": labels, "bonusRead": bonus_read, "fns": fns, "constsV": consts_v, "constsEnv": consts_env,
        "bonusById": {str(k): v for k, v in P.BONUS_BY_ID.items()},
        # EquipBuffManager (missing-data 01): BonusType id -> how the lines of that type combine into the buffer the rows read
        "equipBuffers": {k: {"bonus": b["bonus"], "cap": b["cap"], "floor": b["floor"], "calcValue": b["calcValue"], "getParam": b["getParam"]} for k, b in P.EQUIP_BUFFERS.items()},
        "calcOfType": {str(k): v for k, v in P.CALC_OF_TYPE.items()},
        # missing-data 07: skill / mastery levels and the weapon element are character inputs. Texts call MasteryLearned(uid) / SkillLv(uid) / MasteryParam(uid, paramId)
        # (builtins, see `skillInputs`) and read the names weaponElement / subWeaponElement / WizardTreeLevelSum / WizardTreeSkillCount / CastMasteryActive.
        "masteries": {u: {"maxLv": m["maxLv"], "p": {str(p["id"]): (p["byLevel"] if p["byLevel"] is not None else {"expr": p["expr"]}) for p in m["params"].values()}}
                      for u, m in P.MASTERY_TABLE.items()},
        "skillEqLimit": {str(u): v for u, v in sorted(P.EQ_LIMIT.items())},          # SkillMasterData.EqLimit (32-bit SkillEqLimitFlag) per skill uid: SkillEqLimit(uid)
        "skillInputs": {
            "SkillEqLimit(uid)": "skillEqLimit[uid] (the mask CheckSkillMainEquipLimit tests the main / sub weapon against)",
            "MasteryLearned(uid)": "1 when skills[uid] > 0 (SkillManager.SkillMasteryList.TryGetValue)",
            "SkillLv(uid)": "skills[uid] or 0 (SkillManager.GetSkillLv; the equipSkillList part, skill levels granted by gear, is not modelled)",
            "MasteryParam(uid, paramId)": "0 when skills[uid] is 0 or the class does not handle paramId; else masteries[uid].p[paramId] at level min(skills[uid], maxLv): an array indexed level - 1, "
                                           "or {expr} in Lv + the inputs below (only CastMastery 1033)",
            "weaponElement / subWeaponElement": "ElementType of the main / sub weapon's own bElement stat line (BonusManager.GetEquipElement(Weapon / SubWeapon)), 0 none; 8 = Mana",
            "WizardTreeLevelSum / WizardTreeSkillCount": "sum of the levels / number of the learned skills of the skills in `wizardTree` (SkillManager.GetAllSkillLvInTree / GetSkillNumInTree, tree 32)",
            "CastMasteryActive": "CastMastery.SetActive flag, default 0",
            "MasteryLv(uid)": "level of SkillMasteryList[uid] (`.skillData.Level`): skills[uid] when > 0, else equipSkills[uid] for a mastery class (SkillManager.CreateMasteryList), else 0",
            "SkillLv(uid)": "SkillManager.GetSkillLv(id, true): max(skills[uid], equipSkills[uid]) when learned, equipSkills[uid] when only equipped, -1 when neither; an equip skill with equipSkillFlags[uid] == 3 (NinjaSkill) is looked up as skill 1218 instead",
            "GemCartBufferManager.ContainsBuffer(mgr, id)": "1 when registlet[id] >= 1",
            "GemCartBufferManager.GetBufferLevel(mgr, id)": "registlet[id] or 0",
            "GemCartBufferManager.GetGemCartBuffer(mgr, id) + GemCartBufferBase.GetValue(buf, Value)": "registlet 37 (Shared Destiny): max(0, partyMembers - 1) when registlet[37] >= 1, every other registlet 0",
            "optionAvoid": "OptionsSystem.Avoid (AvoidType 0 Manual, 1 Auto, 2 NonActive), the player's own client setting, default 0; AvoidStack shifts left by 1 only when it is 0",
            "wizardTree": sorted(P.WIZARD_TREE),
        },
        "rules": {"absent": P.ABSENT.pattern, "objectGetters": P.OBJECT_GETTERS.pattern, "notInBattle": P.NOT_IN_BATTLE.pattern, "barrier": P.BARRIER.pattern,
                  "absentBuffer": P.ABSENT_BUFFER.pattern, "tryEquipBuffer": P.TRY_EQUIP_BUFFER.pattern, "virtual": P.VIRTUAL},
    }
    os.makedirs(os.path.dirname(OUT), exist_ok=True)
    json.dump(spec, open(OUT, "w", encoding="utf-8"), ensure_ascii=False, separators=(",", ":"))
    print(f"fns {len(fns)}  rows {len(out_rows)}  constsV {len(consts_v)}  constsEnv {len(consts_env)}  size {os.path.getsize(OUT) // 1024} KB")
    print("unparseable texts:", len(bad), list(bad.items())[:5])
    if "--golden" in sys.argv:
        golden(sys.argv[sys.argv.index("--golden") + 1])


SAMPLES = [
    dict(lv=1), dict(lv=100, str_=50, agi=50, dex=50, vit=50, int_=50),
    dict(lv=200, str_=100, int_=100, vit=150, agi=100, dex=255, weapon=(12, 300, 10, 9), sub=(19, 50, 5, 0), body=(20, 200, 0, 9)),
    dict(lv=200, str_=255, vit=100, agi=200, weapon=(10, 250, 40, 15), sub=(17, 120, 0, 9), body=(20, 400, 0, 12), bonus={"bStr": 30, "bAtk": 120, "bAtkRate": 15, "bMaxHp": 2000, "bMaxHpRate": 10}),
    dict(lv=180, int_=255, men=100, weapon=(15, 150, 0, 7), sub=(19, 0, 0, 0), bonus={"bInt": 20, "bMatk": 80, "bAspd": 300, "bCspd": 500}),
    dict(lv=250, str_=200, dex=255, agi=255, weapon=(8, 280, 30, 12), sub=(23, 0, 0, 0), bonus={"bAspd": 1200, "bCrt": 40, "bHit": 100}),
    dict(lv=210, str_=150, agi=150, weapon=(16, 200, 25, 8), sub=(18, 90, 15, 0)),
    dict(lv=140, vit=255, str_=120, weapon=(11, 330, 15, 10), body=(20, 100, 0, 5)),
    dict(lv=200, str_=150, agi=200, vit=100, weapon=(10, 300, 40, 12), sub=(17, 150, 0, 9), body=(20, 250, 0, 11, 1), option=(21, 40, 0, 8), special=(22, 20, 0, 0), bonus={"bDef": 50, "bDefRate": 20, "bFlee": 30, "bFleeRate": 10}),
    dict(lv=220, int_=255, vit=80, weapon=(14, 200, 0, 14), sub=(15, 0, 0, 0), body=(20, 300, 0, 10, 2), bonus={"bMdef": 70, "bMdefRate": 15, "bAspd": 400}),
    dict(lv=100, agi=100, weapon=(12, 150, 10, 5), sub=(19, 40, 0, 0), body=(20, 120, 0, 3, 0)),
    # added 2026-10-02 (missing-data 01/02/06): conversion lines, MaxHP/MP x10, recovery, equipment buffers, shields, rates
    dict(lv=200, str_=150, int_=90, vit=120, agi=130, dex=110, weapon=(10, 250, 40, 12), sub=(17, 100, 0, 8), body=(20, 300, 0, 10, 1),
         bonus={"bStrToAtk": 1000, "bAgiToAtk": 2500, "bVitToMAtk": -500, "bDexToMAtk": 750, "bMaxHpTo10": 200, "bMaxMpTo10": 30, "bMaxHp": 500, "bMaxHpRate": 12}),
    dict(lv=180, str_=80, int_=200, vit=90, agi=80, dex=120, weapon=(14, 200, 0, 11), sub=(15, 0, 0, 0), body=(20, 200, 0, 9, 2),
         bonus={"bHpRecovery": 60, "bHpRecoveryRate": 35, "bMpRecovery": 12, "bMpRecoveryRate": 40, "bAtkMpRecovery": 5, "bAtkMpRecoveryRate": 20, "bFirstAttackRate": 15,
                "bExpRate": 20, "bDropRate": 30, "bFireShield": 25, "bWindShield": 10, "bNormalShield": 15, "bPowerResist": 12, "bMagicResist": 9}),
    # added 2026-10-03 (missing-data 07): skill / mastery levels and the weapon element
    dict(lv=200, str_=120, int_=150, vit=100, agi=90, dex=130, weapon=(10, 260, 35, 12), sub=(17, 100, 0, 8), body=(20, 280, 0, 10, 1),
         skills={36: 10, 481: 10, 490: 10, 612: 10, 200: 10, 197: 10, 201: 10, 641: 10, 865: 1}, weapon_element=8),
    dict(lv=180, int_=255, men=100, dex=120, weapon=(14, 220, 0, 11), sub=(15, 0, 0, 0), body=(20, 150, 0, 9),
         skills={100: 10, 482: 10, 491: 10, 865: 1, 867: 60, 879: 10, 1033: 15, 1025: 10, 1026: 8, 1027: 5, 200: 10}, weapon_element=3, cast_active=1),
    dict(lv=220, str_=200, dex=200, weapon=(11, 330, 15, 12), sub=(0, 0, 0, 0), body=(20, 100, 0, 5), skills={867: 60, 36: 10, 612: 5, 200: 3, 201: 2, 197: 4}, weapon_element=8,
         bonus={"bStrToMAtk": 1000}),
    dict(lv=200, agi=200, dex=180, weapon=(12, 300, 10, 9), sub=(19, 50, 5, 0), skills={68: 10, 83: 10, 557: 10, 481: 10, 612: 10}, bonus={"bAtkRate": 10}),
    # added 2026-10-03 (follow-up of 07): Cast Mastery / Knight's Will / equip skills / registlets / party / system option Avoid
    dict(lv=190, int_=255, dex=150, weapon=(14, 220, 0, 11), sub=(0, 0, 0, 0), body=(20, 150, 0, 9), skills={1033: 15, 1025: 10, 1026: 8, 1027: 5, 1028: 3, 200: 10}, cast_active=1, weapon_element=8),
    dict(lv=200, str_=150, vit=200, weapon=(10, 250, 40, 12), sub=(17, 120, 0, 9), body=(20, 400, 0, 12, 2), skills={520: 10, 1217: 10, 613: 10}),
    dict(lv=200, int_=200, dex=120, weapon=(15, 150, 0, 9), sub=(15, 0, 0, 0), body=(20, 100, 0, 9), skills={612: 5}, equip_skills={879: 10, 1033: 5, 612: 3, 867: 30, 500: 7}, equip_skill_flags={500: 3}),
    dict(lv=210, str_=120, agi=180, dex=140, weapon=(10, 260, 30, 12), sub=(17, 100, 0, 9), body=(20, 250, 0, 11, 1), registlet={70: 5, 72: 3, 37: 2, 26: 5, 50: 1, 216: 1}, party_members=4, bonus={"bAvoidbreaker": 20, "bGuardbreaker": 30}),
    dict(lv=200, agi=220, dex=150, weapon=(10, 250, 30, 12), sub=(10, 200, 20, 12), skills={1100: 10}, option_avoid=1),
    dict(lv=200, agi=220, dex=150, weapon=(10, 250, 30, 12), sub=(10, 200, 20, 12), skills={1100: 10}, option_avoid=0, registlet={50: 1}),
    dict(lv=210, str_=120, agi=180, dex=140, weapon=(8, 280, 30, 14), sub=(19, 0, 0, 0), body=(20, 250, 0, 12, 1),
         bonus={"bAbsoluteHitRate": 20, "bAbsoluteFreeRate": 45, "bBarrierSpeed": 120, "bDamageReflection": 18, "bAvoidbreaker": 60, "bGuardbreaker": 140, "bPhysicalPursuit": 15,
                "bMagicPursuit": -5, "bSelfDmgRate": 8, "bGrantStopStun": 1, "bGrantStopFlinch": 1, "bPhysicalBarrier": 500, "bShortRange": 12, "bLongRange": 7}),
    # added 2026-10-03 (missing-data/09 item 2): the Def / Mdef / Flee / AtkMpRecovery terms the hand-decoded bodies had left out (ForceShield 259, MagicalShield 261, DefUp 483,
    # KnowledgeOfDefense 492, FleeUp 486, ShinobiWay 1217, OneChance 133, registlet 21 SilentRecharge = GemCartBufferManager.GetBufferValue(AtkMpRecoveryUpRate))
    dict(lv=200, str_=120, int_=150, vit=150, agi=150, dex=120, weapon=(10, 250, 40, 12), sub=(17, 120, 0, 9), body=(20, 300, 0, 10, 1), skills={259: 20, 261: 50, 483: 20, 492: 120, 486: 20}),
    dict(lv=200, int_=150, vit=100, agi=150, weapon=(10, 250, 40, 12), sub=(19, 40, 0, 0), body=(20, 200, 0, 9, 2), skills={483: 20, 492: 60, 486: 10, 1217: 1}),
    dict(lv=200, str_=200, agi=150, dex=150, weapon=(16, 200, 25, 8), sub=(0, 0, 0, 0), skills={133: 10}, registlet={21: 5}, bonus={"bAtkMpRecovery": 5, "bAtkMpRecoveryRate": 20}),
    dict(lv=200, str_=200, agi=150, dex=150, weapon=(10, 250, 40, 12), sub=(16, 100, 0, 9), skills={133: 10}, registlet={21: 20}),
    dict(lv=200, str_=200, agi=150, dex=150, weapon=(10, 250, 40, 12), sub=(17, 100, 0, 9), skills={133: 10}),
]


def golden(path):
    cases = []
    for s in SAMPLES:
        kw = dict(s)
        gear = {k: P.item(*kw.pop(k)) for k in ("weapon", "sub", "body", "option", "special") if k in kw}
        ch = P.Character(**kw, **gear)
        res, _ = P.compute(ch)
        cases.append({"in": {"lv": ch.primary["lv"], "stats": {k: v for k, v in ch.primary.items() if k != "lv"}, "weapon": ch.weapon, "sub": ch.sub, "body": ch.body, "option": ch.option, "special": ch.special, "bonus": ch.bonus,
                               "skills": {str(k): v for k, v in ch.skills.items()}, "weaponElement": ch.weapon_element, "subElement": ch.sub_element, "castActive": ch.cast_active,
                               "equipSkills": {str(k): v for k, v in ch.equip_skills.items()}, "equipSkillFlags": {str(k): v for k, v in ch.equip_skill_flags.items()},
                               "registlet": {str(k): v for k, v in ch.registlet.items()}, "partyMembers": ch.party_members, "optionAvoid": ch.option_avoid},
                      "out": [r["value"] for r in res]})
    json.dump(cases, open(path, "w", encoding="utf-8"), ensure_ascii=False)
    print("golden", len(cases), "characters ->", path)


if __name__ == "__main__":
    main()
