"""Skill detail pages: plain-language walkthrough of every skill + all formulas / numbers / buff values (no truncation).
-> skills/damage/details/<tree>.md and DETAILS.md. Reads skill_reference.json + coverage.csv; run after build_reference/render_docs/build_coverage.
Every sentence is derived from a decoded field, call or condition; wording of method/parameter meaning is inferred from client names.
"""
import csv, json, os, re, collections, sys
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import render_docs as R

OUT, recs, byuid = R.OUT, R.recs, R.byuid
DUMP = r"D:\toram_re\dump_android\dump.cs"
COV = {int(r["uid"]): r for r in csv.DictReader(open(os.path.join(OUT, "coverage.csv"), encoding="utf-8-sig"))}


def enum_map(name):
    out, on = {}, False
    for line in open(DUMP, encoding="utf-8", errors="replace"):
        if not on:
            on = line.startswith(f"public enum {name} //")
            continue
        if line.startswith("}"): break
        m = re.match(rf"\s+public const {name} (\w+) = (-?\d+);", line)
        if m: out[int(m.group(2))] = m.group(1)
    return out


ABN = enum_map("AbnormalType")

ROLE_TXT = {
    "attack (deals damage)": "It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.",
    "buff (self)": "It installs a buff on the caster.",
    "buff (party / others)": "It installs a buff on other players / the party.",
    "applies status ailment": "It can inflict a status ailment (chance and type below).",
    "heal / recovery": "It restores HP or MP.",
    "placed object / trap / summon": "It places an object in the world (trap, summon or field object).",
    "circle / song area": "It creates an area (circle / song field) that affects targets standing inside.",
    "passive mastery": "It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.",
    "boosts normal-attack damage": "Its buff raises normal-attack damage (`NormalAttackRate` / `NormalAttackConstantDamage`).",
    "modifies normal-attack behaviour": "`NormalAttackAction` looks its buff up and changes how normal attacks run while it is active.",
    "utility / system action": "It is a utility / system action (movement, state change) rather than a damage or buff skill.",
    "no client action class (system / production / unreleased)": "The client has no action class for it.",
}

PHASE = {
    "OnInitialize": "skill setup (fields the action starts with)",
    "InitializeOthers": "setup used when another player's client replays the action",
    "ActionPreparation": "before the cast starts",
    "ActionStart": "when the cast starts",
    "ActionSkillEvent": "on an animation/skill event during the motion",
    "ActionHit": "when the attack connects",
    "calcPlayerToMobDamage": "damage calculation against a monster",
    "calcFirstDamage": "damage calculation of hit 1",
    "calcSecondDamage": "damage calculation of hit 2",
    "calcAnyDamage": "damage calculation shared by every hit",
    "Damaged": "when the caster takes damage while the action / buff is active",
    "OnEnd": "when the action ends",
    "OnMotionEnd": "when the motion ends",
    "ChangeMpDuringCombo": "MP cost adjustment while inside a combo chain",
    "ReceiveAttackResult": "when the result of the attack comes back",
    "OnInheritance": "state carried over when this action follows another",
    "CheckRangeHit": "range-hit test",
    "NextRangeHit": "next range-hit pass",
    "BattleResult": "when the battle result arrives",
    "DamageFunction": "when damage passes through the buff",
}

BUFF_TXT = {
    "AttackMprecoveryUp": "MP recovered per attack (flat)", "AttackMprecoveryUpRate": "MP recovered per attack (%)",
    "MobLastDamageRateBuf": "final damage multiplier vs monsters (buff category)", "MobLastDamageRateUnique": "final damage multiplier vs monsters (unique category)",
    "MobLastDamageRateSupport": "final damage multiplier vs monsters (support category)", "CrtUp": "critical rate +", "CrtUpRate": "critical rate %",
    "NormalAttackRate": "normal-attack damage multiplier (%)", "NormalAttackConstantDamage": "normal-attack flat damage", "HitRate": "accuracy %", "HitUp": "accuracy +",
    "Aspd": "attack speed +", "AspdRate": "attack speed %", "PowerDmgCut": "physical damage taken reduction", "MagicDmgCut": "magic damage taken reduction",
    "Stable": "stability", "AtkUp": "ATK +", "AtkUpRate": "ATK %", "MatkUp": "MATK +", "MAtkUpRate": "MATK %", "EqAtkUpRate": "weapon ATK %", "BaseEqAtkUpRate": "base weapon ATK %",
    "BaseEqAtk": "base weapon ATK +", "EqAtk": "weapon ATK +", "MotionSpeed": "motion speed +", "MotionSpeedRate": "motion speed %", "LastDmgUpRate": "final damage dealt %",
    "LastDmgDownRate": "final damage dealt reduced %", "MaxHpUpRate": "max HP %", "MaxHpUp": "max HP +", "MaxMpUp": "max MP +", "AvoidUp": "dodge +", "Flee": "dodge +", "FleeRate": "dodge %",
    "FirstAidCost": "First Aid MP cost", "ShortRangeRate": "short-range damage %", "LongRangeRate": "long-range damage %", "CspdUp": "cast speed +", "CspdUpRate": "cast speed %",
    "AbnormalRegist": "ailment resistance", "AbnormalAvoid": "ailment avoidance", "HateRate": "aggro (hate) generation %", "PowerResistBreaker": "physical pierce",
    "MagicResistBreaker": "magic pierce", "FirstAttackRate": "first-attack multiplier", "MdefRate": "MDEF %", "DefRate": "DEF %", "Def": "DEF +", "Mdef": "MDEF +",
    "RateDamageResist": "damage taken multiplier", "CrtDamageUp": "critical damage +", "CrtDamageUpRate": "critical damage %", "CrtDmg": "critical damage", "MagicCrtDamage": "magic critical damage",
    "MoveSpeed": "movement speed", "BaseDamageCut": "base damage reduction", "Guard": "guard (block) rate", "GuardRate": "guard rate %", "SkillConstantDamage": "skill flat damage",
    "MpRecoveryUp": "MP natural recovery +", "MpRecoveryRate": "MP natural recovery %", "HpRecoveryUp": "HP natural recovery +", "HpRecoveryRate": "HP natural recovery %",
    "TargetDefDown": "target DEF reduction", "TargetMdefDown": "target MDEF reduction", "LimitRegistDamage": "damage-limit resistance", "KnockbackDistReduceRate": "knock-back distance reduction",
    "LastDamageRateDecimal": "final damage multiplier (decimal)", "AvoidStack": "dodge stacks", "ReceiveDarkElementDmgRate": "dark-element damage taken %", "ReceiveLightElementDmgRate": "light-element damage taken %",
    "PhysicalPursuitSkillRate": "physical pursuit-skill multiplier", "MagiclPursuitSkillRate": "magic pursuit-skill multiplier",
    "Value": "generic value (meaning set by the code that reads the buff)", "Value2": "second generic value", "Count": "stack / hit counter", "Percent": "generic percent",
}
MASTERY_TXT = {
    "AtkRate": "ATK %", "EqAtkRate": "weapon ATK %", "LastDmgRate": "final damage dealt %", "SkillRate": "skill multiplier bonus", "Crt": "critical rate", "CrtRate": "critical rate %",
    "MaxHp": "max HP", "MaxHpRate": "max HP %", "MaxMp": "max MP", "CutDmgRate": "damage taken reduction %", "Hit": "accuracy", "HitRate": "accuracy %", "Aspd": "attack speed",
    "AspdRate": "attack speed %", "Cspd": "cast speed", "CspdRate": "cast speed %", "MatkRate": "MATK %", "Matk": "MATK", "PowerResistBreaker": "physical pierce", "Guard": "guard rate",
    "GuardPower": "guard power", "Avoid": "dodge", "Flee": "dodge", "DefRate": "DEF %", "MdefRate": "MDEF %", "Def": "DEF", "Mdef": "MDEF", "LimitTimeUp": "time limit extension",
    "MobAttackLastDamageRate": "final damage taken from monster attacks", "DamageTransferRate": "damage transfer rate", "SkillAttackRate": "skill attack multiplier", "LimitLvDown": "level-cap reduction",
    "CrtDmg": "critical damage", "NormalResist": "normal-element resistance", "Stable": "stability", "FirstAttackRate": "first-attack multiplier", "Agi": "AGI", "Trigger": "trigger chance (%)",
    "Percent": "generic percent", "Value": "generic value",
}
AILMENT_FIELDS = re.compile(r"(Percent|abnormalRate)$")
CALL_TXT = {
    "PlayerAttackBase.createMultiHitDamage": "splits the damage into several hits",
    "PlayerAttackBase.SetBufferConstantDamage": "adds the buff-provided flat damage to the template",
    "SkillDamageData.CreateNextDamage": "chains one more damage event",
    "RecoveryAction.AddRecovery": "queues a recovery for a target",
    "GeoImpactAction.MpHeal": "restores MP to the caster",
    "SkillBufferManager.AddSelfDanceBuf": "installs the dance buff on the caster",
}
BUFCALL = re.compile(r"^(Add|Remove)(Self)?Buffer\((.*)$")


def trim(s): return R._lv(s).strip()


def code(s): return f"`{trim(s)}`"


def bl_txt(it):
    bl = it.get("by_level")
    if isinstance(bl, list): return f" → Lv1..10 {bl}"
    if bl is not None: return f" = {bl}"
    return ""


def when_txt(it): return "" if it["when"] == "always" else f"\n  - when {code(it['when'])}"


def items(rec, kind=None, names=None):
    for m, it in R.all_items(rec):
        if kind and it["kind"] != kind: continue
        if names and not names(it["name"]): continue
        yield m, it


def skill_ref(n):
    if not n.lstrip("-").isdigit(): return None
    r = byuid.get(int(n))
    return f"skill {n} ({r.get('name_en') or r.get('name_th') or r.get('class') or '?'})" if r else f"skill {n}"


def abn(n):
    n = n.strip()
    return f"{ABN.get(int(n), n)} ({n})" if n.lstrip("-").isdigit() else f"`{n}`"


def split_args(s):
    depth, cur, out = 0, "", []
    for ch in s:
        if ch in "([": depth += 1
        if ch in ")]": depth -= 1
        if ch == "," and depth == 0: out.append(cur.strip()); cur = ""
        else: cur += ch
    if cur.strip(): out.append(cur.strip())
    return out


def head_lines(rec):
    uid = rec["uid"]
    name = re.sub(r"\[N2?\]|\[[A-Z]\]", " / ", rec.get("name_th") or rec.get("class") or str(uid)).strip(" /")
    en_ = rec.get("name_en") or ""
    L = [f"### {name}" + (f" ({en_})" if en_ else "") + f" · uid {uid}", ""]
    if rec.get("icon"): L.append(f'<img src="../../{rec["icon"]}" width="40" alt="icon"> ')
    meta = []
    if rec.get("tree"): meta.append(f"**Tree:** {R.clean_tree(rec['tree'])} (`{rec.get('tree_type')}`, tier {rec.get('tree_lv')})")
    if rec.get("category"): meta.append(f"**Type:** {rec['category']}")
    if rec.get("max_level"): meta.append(f"**Max Lv:** {rec['max_level']}")
    if rec.get("eq_limit"): meta.append("**Weapons:** " + ", ".join(rec["eq_limit"]))
    if rec.get("premise_uid"):
        pu = byuid.get(rec["premise_uid"], {})
        meta.append(f"**Requires:** {pu.get('name_th') or rec['premise_uid']}")
    if rec.get("flags"): meta.append("**Flags:** " + ", ".join(rec["flags"]))
    if rec.get("class"): meta.append(f"**Client class:** `{rec['class']}`")
    if rec.get("mastery_class"): meta.append(f"**Client class:** `{rec['mastery_class']}` (passive mastery)")
    if not rec.get("in_skill_tree"): meta.append("_(internal action, not a skill-tree entry)_")
    L += [" · ".join(meta), ""]
    if rec.get("desc_th"): L += ["> " + rec["desc_th"].replace("\n", "\n> "), ""]
    return L


def overview(rec):
    """one paragraph: what kind of skill and what it does, from roles + data"""
    roles = rec.get("roles") or []
    out = []
    cov = COV.get(rec["uid"])
    kinds = [r for r in roles if r in ROLE_TXT]
    for r in kinds: out.append(ROLE_TXT[r])
    for r in roles:
        if r.startswith("changes attack pattern"):
            out.append("Its buff exposes motion / combo hooks, so it changes the attack pattern while active (heuristic: the client has no explicit flag).")
    nt = {}
    for m, it in items(rec, "info"):
        if it["name"] == "templates":
            try: nt[m] = int(it["text"])
            except ValueError: pass
    if nt:
        out.append("Damage templates: " + ", ".join(f"`{m}` x{n}" for m, n in nt.items()) +
                   " (every template is a full damage calculation with its own critical roll).")
    if rec.get("buffs"):
        out.append("Buff objects: " + ", ".join(f"`{b}`" for b in rec["buffs"]) + ".")
    if not rec.get("class") and not rec.get("mastery_class") and cov:
        out.append(f"Client status: **{cov['state']}** — {cov['reason']}.")
    return out


STAT_RX = [(re.compile(r"status\.(\w+)"), lambda m: m.group(1)), (re.compile(r"base([A-Z]{3})~"), lambda m: m.group(1) + " (allocated points)"),
           (re.compile(r"IMobStatusCalculator\.get_(\w+)"), lambda m: "target " + m.group(1)), (re.compile(r"IPlayerStatusCalculator\.get_(\w+)"), lambda m: m.group(1)),
           (re.compile(r"([A-Z]\w+\.[A-Z]\w+)\(this"), lambda m: "helper " + m.group(1))]
STEPS = (("AddRate[SkillRate]", "SetRate[SkillRate]", "skill multiplier", "×"), ("AddConstant[SkillConstantDamage]", "SetConstant[SkillConstantDamage]", "flat damage", "+"),
         ("AddRate[CriticalRate]", None, "extra crit multiplier", "+"))


def stat_deps(text):
    out = []
    for rx, f in STAT_RX:
        for m in rx.finditer(text):
            s = f(m)
            if s not in out: out.append(s)
    return out


def _ends(vals):
    return f"{R.fmt(vals[0])} at Lv1 to {R.fmt(vals[-1])} at Lv10" if vals and vals[0] != vals[-1] else (R.fmt(vals[0]) if vals else "")


def _split_when(w):
    if w.startswith(("calc", "via")):
        a = w.split(" ", 1)
        return a[0], (a[1] if len(a) > 1 else "")
    return "calcPlayerToMobDamage", "" if w == "base" else w


def hit_sentences(rec):
    groups = collections.OrderedDict()
    for a, b, lab, sign in STEPS:
        ef = R.effective(rec, a) or (R.effective(rec, b) if b else None)
        if not ef: continue
        for r_ in ef["rows"]:
            groups.setdefault(_split_when(r_["when"]), []).append(f"{lab} {sign}{_ends(r_['by_level'])}")
        for s in ef["syms"]:
            deps = stat_deps(s["formula"])
            groups.setdefault(_split_when(s["when"]), []).append(f"{lab} depends on " + (", ".join(deps) if deps else "live values") + " (formula below)")
    out = []
    for (meth, cond), parts in list(groups.items())[:8]:
        out.append(f"`{meth}`" + (f" [{cond}]" if cond else "") + ": " + "; ".join(parts))
    if len(groups) > 8: out.append(f"... and {len(groups) - 8} more variants (see the tables below)")
    return out


def buff_summary(rec):
    out = []
    for bc, b in rec.get("buffs", {}).items():
        fields = {}
        for ent in b["ctors"]:
            for k, vs in (ent.get("fields_resolved") or ent["fields"]).items(): fields.setdefault(k, vs)
        dur = fields.get("LeftTime")
        s = f"`{bc}`" + (": lasts " + " / ".join(f"`{v['expr']}` s" for v in dur[:3]) if dur else "")
        vals = []
        for g in b["get_param"]:
            e2 = g["value"]
            for fk, vs in fields.items():
                if vs and re.search(rf"\b{re.escape(fk)}\b", e2): e2 = re.sub(rf"\b{re.escape(fk)}\b", "(" + vs[0]["expr"] + ")", e2)
            lv = [R.evaluate(e2, Lv=i, lv=i) for i in (1, 10)]
            if None in lv or (lv[0] == 0 and lv[1] == 0): continue
            vals.append(f"{g['bonus']} ({BUFF_TXT.get(g['bonus'], 'see glossary')}) {R.fmt(round(lv[0], 3))} → {R.fmt(round(lv[1], 3))}")
        if vals: s += "; Lv1 → Lv10: " + ", ".join(dict.fromkeys(vals))
        elif not dur and not b["get_param"]: s += ": marker buff (no parameters; other code tests whether it is present)"
        out.append(s)
    return out


def summary(rec):
    L = []
    cat, tree = rec.get("category"), R.clean_tree(rec.get("tree"))
    first = (cat or ("Internal action (not a skill-tree entry)" if not rec.get("in_skill_tree") else "Skill")) + (f" skill of the {tree} tree (tier {rec.get('tree_lv')}" + (f", max Lv {rec['max_level']}" if rec.get("max_level") else "") + ")" if tree else "")
    if rec.get("eq_limit"): first += "; usable with " + ", ".join(rec["eq_limit"])
    L.append(first + ".")
    for r in rec.get("roles") or []:
        if r.startswith("no client action class"): continue
        if r == "passive mastery" and not rec.get("mastery_class"):
            L.append("Marked as a passive in the skill table (no decoded `GetMasteryParam` class).")
        elif r in ROLE_TXT: L.append(ROLE_TXT[r])
        elif r.startswith("changes attack pattern"):
            L.append("Its buff exposes motion / combo hooks, so it changes the attack pattern while active (heuristic; the client has no explicit flag).")
    cov = COV.get(rec["uid"])
    if not rec.get("class") and not rec.get("mastery_class") and cov: L.append(f"Client status: **{cov['state']}** — {cov['reason']}.")
    mp = [it for m, it in items(rec, "set", lambda n: n in ("baseMp", "mp", "costMp"))]
    if mp:
        it = mp[0]
        L.append("MP: " + (_ends(it["by_level"]) if isinstance(it.get("by_level"), list) else code(it["text"])) + (" (conditional variants below)" if len(mp) > 1 else "") + ".")
    hs = hit_sentences(rec)
    if hs:
        nt = {}
        for m, it in items(rec, "info"):
            if it["name"] == "templates":
                try: nt[m] = int(it["text"])
                except ValueError: pass
        L.append("Damage" + (" (" + ", ".join(f"`{m}` x{n}" for m, n in nt.items()) + "; each template is a full damage roll with its own crit)" if nt else "") + ":")
        L += ["  - " + h for h in hs]
    p = rec.get("proration") or {}
    if p.get("slot") and p["slot"] != "none":
        L.append(f"Proration: {R.SLOT_TXT.get(p['slot'], p['slot'])}, mode `{p['mode']}`.")
    ty = []
    for m, it in items(rec, "call", lambda n: n in ("PlayerAttackBase.checkAbnormalPercent", "SkillDamageData.SetAbnormalType")):
        t = it["text"]
        a = split_args(t[t.index("(") + 1:t.rindex(")")]) if "(" in t else []
        if a and abn(a[0]) not in ty: ty.append(abn(a[0]))
    if ty: L.append("Can inflict on the target: " + ", ".join(ty) + ".")
    if any(m == "Damaged" for m, i in items(rec, "call", lambda n: n.startswith(("AbnormalStateManager.", "MathUtil.")))):
        L.append("If the caster is hit while the action / buff is active, the `Damaged` hook changes the caster's ailment state (details below).")
    bs = buff_summary(rec)
    if bs: L += ["Buffs:"] + ["  - " + x for x in bs]
    m = rec.get("mastery")
    if m and m.get("bonuses"):
        vs = [f"{k} ({MASTERY_TXT.get(k, 'see glossary')}) {_ends(v['by_level'])}" for k, v in m["bonuses"].items() if isinstance(v.get("by_level"), list) and v["by_level"]]
        if vs: L.append("Passive modifiers (negative = penalty): " + ", ".join(vs) + ".")
    fns = sorted({c["fn"] for c in rec.get("consumer_effects", [])})
    if fns and not rec.get("class"): L.append("Its effect is applied by client code: " + ", ".join(f"`{f}`" for f in fns[:8]) + ("" if len(fns) <= 8 else f" and {len(fns) - 8} more") + " (formulas in the last section).")
    if rec.get("consumers"): L.append(f"Other client code reads this skill ({len(rec['consumers'])} lookup{'s' if len(rec['consumers']) != 1 else ''}; see the last section).")
    return L


def cost_range(rec):
    out = []
    seen = set()
    for m, it in items(rec, "set", lambda n: n in ("baseMp", "mp", "costMp", "cost")):
        k = (it["name"], it["text"], it["when"])
        if k in seen: continue
        seen.add(k)
        out.append(f"- **MP cost** (`{it['name']}` in `{m}`): {code(it['text'])}{bl_txt(it)}{when_txt(it)}")
    for m, it in items(rec, "set", lambda n: n in ("CastTime",)):
        k = ("c", it["text"], it["when"])
        if k in seen: continue
        seen.add(k)
        out.append(f"- **Cast time** (`CastTime`): {code(it['text'])}{bl_txt(it)}{when_txt(it)}")
    for m, it in items(rec, "set", lambda n: n in ("ActionRange", "attackRange", "range", "Radius", "healRange", "supportRange", "width")):
        if it["name"] == "ActionRange" and it["text"] in ("-1", "1.4013e-43", "ActionRange"): continue
        k = (it["name"], it["text"], it["when"])
        if k in seen: continue
        seen.add(k)
        unit = " (Unity units, 2 = 1 m)" if it["name"] in ("Radius", "width", "range", "attackRange", "healRange", "supportRange") else ""
        out.append(f"- **{R.FIELD_TXT.get(it['name'], it['name'])}** (`{it['name']}`){unit}: {code(it['text'])}{bl_txt(it)}{when_txt(it)}")
    for m, it in items(rec, "set", lambda n: n == "Element"):
        if "GetWeaponElementType" in it["text"]:
            out.append("- **Element**: follows the element of the equipped weapon.")
            break
    return out


def damage_lines(rec):
    out = []
    rate = R.effective(rec, "AddRate[SkillRate]") or R.effective(rec, "SetRate[SkillRate]")
    const = R.effective(rec, "AddConstant[SkillConstantDamage]") or R.effective(rec, "SetConstant[SkillConstantDamage]")
    crit = R.effective(rec, "AddRate[CriticalRate]")
    rows = []
    for lab, ef in (("SkillRate ×", rate), ("Flat dmg +", const), ("Crit mult +", crit)):
        for r_ in (ef or {}).get("rows", []):
            rows.append((lab + ("" if r_["when"] == "base" or len(ef["rows"]) == 1 else f" [{r_['when']}]"), r_["by_level"]))
    if rows:
        out += ["**Damage numbers by level** (gem bonuses assumed 0)", "", R.table(rows), ""]
    sy = []
    for lab, ef in (("SkillRate ×", rate), ("Flat dmg +", const), ("Crit mult +", crit)):
        for s in (ef or {}).get("syms", []):
            sy.append(f"- {lab} {code(s['formula'])}" + ("" if s["when"] == "base" else f" — {s['when']}"))
    if sy: out += ["**Damage terms that depend on live stats (not tabulated)**", ""] + sy + [""]
    tpls = [(m, it) for m, it in items(rec, "tpl")]
    if tpls:
        out += ["**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)", ""]
        seen = set()
        for m, it in tpls:
            k = (m, it["name"], it["text"], it["when"])
            if k in seen: continue
            seen.add(k)
            out.append(f"- `{m}` ({PHASE.get(m, 'method')}): `{it['name']}` = {code(R.symbolic(it['text'], rec))}{when_txt(it)}")
        out.append("")
    if tpls:
        out += ["Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.", ""]
    p = rec.get("proration")
    if p:
        out.append(f"**Proration:** slot `{p['slot']}`, mode `{p['mode']}`, attack type `{p['attack_type']}`, action id {p['action_id']}"
                   + (f", spawns `{p['child_actions']}`" if p.get("child_actions") else ""))
        if p.get("mode", "").startswith("never"):
            why = p["mode"].replace("never (", "").rstrip(")")
            out.append(("- No proration slot: " if p["slot"] == "none" else "- Uses the " + R.SLOT_TXT.get(p["slot"], p["slot"]) + " but never changes monster proration: ") + why + ".")
        elif p.get("slot") and p["slot"] != "none":
            out.append(f"- Uses the {R.SLOT_TXT.get(p['slot'], p['slot'])}; " + R.PRORATION_TXT.get(p["mode"].split(" ")[0].split("+")[0].strip(), p["mode"]))
        out.append("")
    loop = [(m, it) for m, it in items(rec, "set", lambda n: n in ("LoopParam", "damageCount", "hitCount", "maxAttackCount"))]
    if loop:
        out += ["**Hit counts**", ""]
        seen = set()
        for m, it in loop:
            k = (it["name"], it["text"], it["when"])
            if k in seen: continue
            seen.add(k)
            out.append(f"- {R.FIELD_TXT.get(it['name'], it['name'])} (`{it['name']}`): {code(it['text'])}{bl_txt(it)}{when_txt(it)}")
        out.append("")
    return out


def ailment_lines(rec):
    out, seen = [], set()
    for m, it in items(rec, "set", lambda n: AILMENT_FIELDS.search(n)):
        k = (it["name"], it["text"], it["when"])
        if k in seen: continue
        seen.add(k)
        out.append(f"- Chance field `{it['name']}` ({R.FIELD_TXT.get(it['name'], 'ailment chance')}): {code(it['text'])}{bl_txt(it)}{when_txt(it)}")
    for m, it in items(rec, "call"):
        n, t = it["name"], it["text"]
        args = split_args(t[t.index("(") + 1:t.rindex(")")]) if "(" in t and ")" in t else []
        k = (n, t, it["when"])
        if k in seen: continue
        if n == "PlayerAttackBase.checkAbnormalPercent" and len(args) >= 2:
            seen.add(k); out.append(f"- Rolls {code(args[1])}% to inflict **{abn(args[0])}** (`{m}`){when_txt(it)}")
        elif n == "SkillDamageData.SetAbnormalType" and args:
            seen.add(k); out.append(f"- Marks the hit with ailment **{abn(args[0])}** (`{m}`){when_txt(it)}")
        elif n == "AbnormalStateManager.RemoveAbnormalState" and args:
            seen.add(k); out.append(f"- Removes ailment **{abn(args[0])}** (`{m}`){when_txt(it)}")
        elif n == "AbnormalStateManager.GetDefaultAnbormalStateTime":
            seen.add(k); out.append(f"- Uses the default ailment duration (`{m}`{', the caster is the one hit' if m == 'Damaged' else ''}){when_txt(it)}")
        elif n == "MathUtil.CheckPercent":
            seen.add(k); out.append(f"- Extra percent roll `CheckPercent` (`{m}`{', the caster is the one hit' if m == 'Damaged' else ''}){when_txt(it)}")
    return out


def buff_call_lines(rec):
    out, seen = [], set()
    for m, it in items(rec, "call"):
        n, t = it["name"], it["text"]
        short = n.split(".")[-1]
        mm = BUFCALL.match(short + t[len(short):]) if t.startswith(short) else None
        k = (n, t, it["when"], m)
        if k in seen: continue
        if mm and n.startswith("SkillBufferManager."):
            seen.add(k)
            args = split_args(t[t.index("(") + 1:t.rindex(")")])
            first = args[0] if args else ""
            ref = skill_ref(first) or ("this skill" if first in ("Id",) else code(first))
            verb = {"Add": "adds", "Remove": "removes"}[mm.group(1)]
            tgt = "the caster's" if mm.group(2) else "a target's"
            out.append(f"- `{m}` ({PHASE.get(m, 'method')}): {verb} {tgt} buff of {ref} — {code(t)}{when_txt(it)}")
        elif n.endswith("..ctor") and n.split(".")[0].endswith(("Buf", "Debuff", "Buff")):
            seen.add(k)
            out.append(f"- `{m}` ({PHASE.get(m, 'method')}): constructs `{n.split('.')[0]}` — {code(t)}{when_txt(it)}")
        elif n in CALL_TXT:
            seen.add(k)
            out.append(f"- `{m}` ({PHASE.get(m, 'method')}): {CALL_TXT[n]} — {code(t)}{when_txt(it)}")
    return out


def buff_section(rec):
    bl = R.buff_lines(rec)
    if not bl: return []
    used = {g["bonus"] for b in rec["buffs"].values() for g in b["get_param"]}
    L = ["**Buff values** (every recovered field; durations in seconds)", ""] + bl + [""]
    gl = [f"- `{k}`: {BUFF_TXT[k]}" for k in sorted(used) if k in BUFF_TXT]
    unk = sorted(k for k in used if k not in BUFF_TXT)
    if gl: L += ["Parameter meanings (inferred from the `SkillBufferId` names):", ""] + gl + [""]
    if unk: L += ["Other parameters (client name only): " + ", ".join(f"`{k}`" for k in unk), ""]
    return L


def mastery_section(rec):
    m = rec.get("mastery")
    if not m or not m.get("bonuses"): return []
    L = ["**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)", ""]
    rows = [(k, v["by_level"]) for k, v in m["bonuses"].items() if v.get("by_level")]
    if rows: L += [R.table(rows), ""]
    for k, v in m["bonuses"].items():
        if not v.get("by_level"): L.append(f"- `{k}` = {code(v['expr'])}")
    gl = [f"- `{k}`: {MASTERY_TXT[k]}" for k in m["bonuses"] if k in MASTERY_TXT]
    L += [""] + (["Bonus meanings (inferred from the names):", ""] + gl + [""] if gl else [])
    return L


def consumer_section(rec):
    L = []
    for ce in rec.get("consumer_effects", []):
        L.append(f"- Effect applied in `{ce['fn']}` ({ce['npaths']} guarded path{'s' if ce['npaths'] != 1 else ''}"
                 f"{', truncated' if ce.get('truncated') else ''}):")
        for p_ in ce["paths"][:8]:
            conds = [c for c in p_["cond"] if "+0x" not in c and "?x" not in c][:4]
            L.append("  - when " + " AND ".join(code(c) for c in conds) if conds else "  - always")
            if p_.get("ret"): L.append(f"    - returns {code(p_['ret'])}")
            for k, v in p_["fields"].items(): L.append(f"    - set `{k}` = {code(v)}")
            for t in p_["tpl"]: L.append(f"    - template `{t[0]}[{t[1]}]` = {code(t[2])}")
            if p_["calls"]: L.append("    - calls " + ", ".join(f"`{c}`" for c in p_["calls"][:8]))
    if rec.get("consumers"):
        L.append("- Code that reads this skill's level / buff by constant id: " + ", ".join(f"`{c}`" for c in rec["consumers"]))
    return ["**Where else this skill takes effect**", ""] + L + [""] if L else []


def entry(rec, treefile):
    L = head_lines(rec)
    L += ["**How it works**", ""] + [x if x.startswith("  ") else f"- {x}" for x in summary(rec)] + [""]
    cr = cost_range(rec)
    if cr: L += ["**Cost, timing and range**", ""] + cr + [""]
    ph = collections.OrderedDict()
    for m, v in rec.get("methods", {}).items():
        n = collections.Counter(it["kind"] for it in v["items"])
        if n.get("tpl") or n.get("call") or n.get("set"): ph[m] = n
    if ph:
        L += ["**When each part runs**", ""]
        for m, n in ph.items():
            L.append(f"- `{m}` — {PHASE.get(m, 'skill-specific method')}: " + ", ".join(f"{c} {k}" for k, c in n.items()))
        L.append("")
    dl = damage_lines(rec)
    if dl: L += dl
    al = ailment_lines(rec)
    if al: L += ["**Status ailments**", ""] + al + [""]
    bc = buff_call_lines(rec)
    if bc: L += ["**Buffs and effects it installs or removes**", ""] + bc + [""]
    mech = [x for x in R.mechanics(rec) if not any(t in x for t in ("Ailment chance", "chance (%)", "Chance to", "Flinch chance"))]
    if mech: L += ["**Other recovered parameters**", ""] + [R._lv(x) for x in mech] + [""]
    L += buff_section(rec) + mastery_section(rec)
    if rec.get("notes"):
        L += ["**In-game level notes**", ""] + [f"- Lv{n.get('level')}: {(n.get('text') or '').replace(chr(10), ' ')}" for n in rec["notes"]] + [""]
    L += consumer_section(rec)
    L.append(f"_Raw recovered data (every method item): [trees/{treefile}](../trees/{treefile}) — uid {rec['uid']}_")
    L += ["", "---", ""]
    return "\n".join(L)


def main():
    os.makedirs(os.path.join(OUT, "details"), exist_ok=True)
    trees = collections.OrderedDict()
    for r in recs:
        key = str(r.get("tree_type") or ("(internal actions)" if not r.get("in_skill_tree") else "(no tree)"))
        trees.setdefault(key, []).append(r)
    idx = ["# Skill details (plain-language walkthrough)", "",
           "One page per skill tree. Every skill gets a short explanation of how it works, followed by **all** recovered numbers, formulas and buff values "
           "(nothing is shortened; the raw per-method dump stays in `../trees/`).", "",
           "Reading notes: method meanings (`ActionStart`, `ActionHit`, `Damaged` ...) and parameter meanings (`AspdRate`, `CrtUp` ...) are inferred from client names; "
           "the numbers and conditions are recovered from code. Nothing here is verified in game.", ""]
    total = 0
    for key, rs in trees.items():
        rs.sort(key=lambda r: (r.get("tree_lv") or 0, r["uid"]))
        fn = re.sub(r"[^\w.-]+", "_", key) + ".md"
        title = R.clean_tree(rs[0].get("tree")) if rs[0].get("tree") else key
        body = [f"# {title} (`{key}`) — skill details", "", f"{len(rs)} entries.", ""]
        for r in rs: body.append(entry(r, fn)); total += 1
        open(os.path.join(OUT, "details", fn), "w", encoding="utf-8").write("\n".join(body))
        idx.append(f"- [{title} `{key}`](details/{fn}) — {len(rs)} entries")
    open(os.path.join(OUT, "DETAILS.md"), "w", encoding="utf-8").write("\n".join(idx) + "\n")
    print("details:", total, "entries in", len(trees), "files")


if __name__ == "__main__":
    main()
