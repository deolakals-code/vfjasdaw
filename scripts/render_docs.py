"""Render skill_reference.json into markdown (per tree) + csv."""
import json, os, re, sys, csv, collections
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from refutil import evaluate, ENUM, en

DATA = r"D:\toram reverse data"
OUT = os.path.join(DATA, "skills", "damage")
recs = json.load(open(os.path.join(OUT, "skill_reference.json"), encoding="utf-8"))
byuid = {r["uid"]: r for r in recs}

STEP_EN = {
    "SkillRate": "skill multiplier", "SkillConstantDamage": "flat skill damage", "CriticalRate": "critical multiplier bonus",
    "FirstAttack": "first-attack flat bonus", "FirstAttackRate": "first-attack multiplier", "ExpRate": "proration multiplier",
    "LastDamageRate": "final damage multiplier", "StableRate": "stability", "BaseDamage": "base damage", "Def": "target defence",
    "BufferConstantDamage": "buff flat damage", "ElementBonusRate": "element advantage", "TypeDamageRate": "damage-type multiplier",
    "NormalAttackPowerWave": "normal-attack power wave", "GuardPower": "guard power", "AutoSkillRate": "auto-skill multiplier",
    "NormalElementDamageResistRate": "element resist", "GemDamageRate": "gem multiplier", "SpecificWeaponLastDamage": "weapon-specific final multiplier",
}
PRORATION_TXT = {
    "first_hit_per_target": "Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.",
    "every_hit": "Proration changes on EVERY damaging hit (bypasses the first-hit gate).",
    "custom_check": "Proration change is decided by the skill's own check (`CheckExpDefFluctuate`).",
    "first_hit_and_flag": "Proration changes on the first hit only, and only when the damage flag bit 1 is set.",
}
SLOT_TXT = {"Skill": "physical-skill proration slot", "Magic": "magic proration slot", "Normal": "normal-attack proration slot",
            "dynamic": "slot chosen at runtime (physical or magic by a per-cast flag)", "none": "no proration slot"}


_LV = __import__("re").compile(r"SkillManager\.GetSkillLv\(.{0,120}?, (\d+), 1, 0\)")


def _lv(s):
    """readability only: SkillManager.GetSkillLv(<player skill manager>, N, 1, 0) -> SkillLv(N); nothing is dropped"""
    return _LV.sub(lambda m: f"SkillLv({m.group(1)})", s)


def clean_tree(t):
    return (t or "").lstrip("#").strip()


def fmt(v):
    if isinstance(v, float):
        return f"{v:g}"
    return str(v)


def lvl_row(vals):
    return " | ".join(fmt(x) for x in vals)


def table(rows, cols=10):
    """rows: list of (label, list) -> markdown table Lv1..cols"""
    head = "| | " + " | ".join(f"Lv{i}" for i in range(1, cols + 1)) + " |"
    sep = "|---|" + "---|" * cols
    out = [head, sep]
    for lab, vals in rows:
        vals = list(vals)[:cols] + [""] * (cols - len(vals))
        out.append(f"| {lab} | " + " | ".join(fmt(x) for x in vals) + " |")
    return "\n".join(out)


def all_items(rec):
    for m, v in rec.get("methods", {}).items():
        for it in v["items"]:
            yield m, it


GEM_RX = re.compile(r"gemCart\([^()]*\[\d+\]\)")


def sanitize(t):
    """assume no gem-cart bonus / no optional buff when evaluating tables"""
    t = GEM_RX.sub("0", t)
    t = re.sub(r"has(?:Gem)?(?:Cart|Buff)\([^()]*\)", "0", t)
    return t


def set_variants(rec):
    pool = collections.OrderedDict()
    for m, it in all_items(rec):
        if it["kind"] != "set": continue
        pool.setdefault(it["name"], []).append(it)
    return pool


def _base_variants(name, its):
    """prefer definitions that do not read the field themselves (initial value, not a later adjustment)"""
    rx = rf"\b{re.escape(name)}\b"
    own = [i for i in its if not re.search(rx, i["text"])]
    return own or its


def env_for(rec, lv, pick=None):
    env = {"Lv": lv, "lv": lv}
    pool = set_variants(rec)
    for name, its in pool.items():
        cand = _base_variants(name, its)
        it = (pick or {}).get(name) or next((i for i in cand if i["when"] == "always"), cand[0])
        v = evaluate(sanitize(it["text"]), **env)
        if v is not None: env[name] = v
    return env


def symbolic(text, rec, depth=3):
    """substitute field names by their expressions so a formula reads on its own"""
    pool = set_variants(rec)
    names = sorted(pool, key=len, reverse=True)
    for _ in range(depth):
        changed = False
        for n in names:
            rx = rf"\b{re.escape(n)}\b"
            if re.search(rx, text):
                cand = _base_variants(n, pool[n])
                it = next((i for i in cand if i["when"] == "always"), cand[0])
                if it["text"] == text or re.search(rx, it["text"]): continue
                text = re.sub(rx, lambda m, t=it["text"]: "(" + t + ")", text, count=1)
                changed = True
        if not changed: break
    return re.sub(r"\[\?blr\+(0x[0-9a-f]+)\]", r"primaryStat@\1", text)


def effective(rec, step, cap=8):
    """value tables of a template step: one row per distinct template expression x condition variants of the fields it reads"""
    tpls, seen = [], set()
    for m, it in all_items(rec):
        if it["kind"] == "tpl" and it["name"] == step and it["text"] not in seen:
            seen.add(it["text"]); tpls.append((m, it))
    if not tpls: return None
    pool = set_variants(rec)
    rows, syms = [], []
    for m, it in tpls:
        used = [n for n in pool if re.search(rf"\b{re.escape(n)}\b", it["text"]) and len({i["text"] for i in pool[n]}) > 1]
        combos = [{}]
        for n in used[:2]:
            opts = list({i["text"]: i for i in pool[n]}.values())[:4]
            combos = [dict(c, **{n: o}) for c in combos for o in opts][:6]
        for c in combos:
            vals = []
            for lv in range(1, 11):
                env = env_for(rec, lv, c)
                v = evaluate(sanitize(it["text"]), **env)
                if v is None: vals = None; break
                vals.append(round(v, 4) if isinstance(v, float) else v)
            label = " & ".join(o["when"] for o in c.values() if o["when"] != "always")
            if it["when"] != "always": label = (label + " & " if label else "") + it["when"]
            part = "" if m == "calcPlayerToMobDamage" else m
            label = " ".join(x for x in (part, label) if x) or "base"
            if vals: rows.append({"when": label, "by_level": vals})
            else: syms.append({"when": label, "formula": symbolic(it["text"], rec)})
    return {"text": tpls[0][1]["text"], "rows": rows[:cap], "syms": syms[:cap], "by_level": rows[0]["by_level"] if rows else None,
            "variants": [t[1]["text"] for t in tpls][:4], "when": tpls[0][1]["when"]}


def buff_lines(rec):
    out = []
    for bc, b in rec.get("buffs", {}).items():
        out.append(f"**Buff `{bc}`**")
        fl = b.get("flags") or {}
        if fl.get("changes_attack_pattern"):
            out.append("- **Changes the attack pattern**: the buff object drives a motion/combo chain (" + ", ".join(f"`{h}`" for h in b["hooks"] if h in (
                "get_KnifeTakeId", "ChangeHyperMode", "LocalNext", "NextSkip", "Next", "Prev", "SetAttackSkillId", "StartSkill", "SetComboParam",
                "GetComboParam", "TakeEvent", "CheckTake", "ChangeTwinStorm", "get_BufEffectTakeId")) + ").")
        if fl.get("modifies_normal_attack_logic"):
            out.append("- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.")
        if fl.get("boosts_normal_attack_damage"):
            out.append("- **Boosts normal-attack damage** through the `NormalAttackRate` / `NormalAttackConstantDamage` parameters.")
        if b.get("attached_via"):
            out.append(f"- Attached to this skill via `{b['attached_via']}` (no direct constructor call in the skill's own code).")
        if b.get("hooks"):
            out.append("- Buff hook methods: " + ", ".join(f"`{h}`" for h in b["hooks"][:14]))
        ctors = b["ctors"]
        fields = {}
        for ent in ctors:
            f = ent.get("fields_resolved") or ent["fields"]
            for k, vs in f.items():
                if k == "LeftTime" and k in fields:
                    fields[k] = fields[k] + [v for v in vs if v["expr"] not in {x["expr"] for x in fields[k]}]
                else:
                    fields.setdefault(k, vs)
        dur = fields.get("LeftTime")
        if dur:
            out.append("- Duration: " + "; ".join(f"`{v['expr']}` s" + (f" [{v['when']}]" if v["when"] != "always" else "") for v in dur))
        by_level_rows = []
        params = b["get_param"]
        seen = set()
        for g in params:
            key = (g["bonus"], g["value"])
            if key in seen: continue
            seen.add(key)
            expr = g["value"]
            # substitute buff fields by their expressions
            e2 = expr
            for fk, vs in fields.items():
                if re.search(rf"\b{re.escape(fk)}\b", e2) and len(vs) >= 1:
                    e2 = re.sub(rf"\b{re.escape(fk)}\b", "(" + vs[0]["expr"] + ")", e2)
            vals = []
            for lv in range(1, 11):
                v = evaluate(e2, Lv=lv, lv=lv)
                if v is None: vals = None; break
                vals.append(round(v, 3) if isinstance(v, float) else v)
            when = f" _(when {'; '.join(g['when'])})_" if g["when"] else ""
            if vals and any(x != 0 for x in vals):
                by_level_rows.append((g["bonus"], vals))
            else:
                out.append(f"- `{g['bonus']}` = `{e2}`{when}")
        if by_level_rows:
            out.append("")
            out.append(table(by_level_rows))
            out.append("")
        others = [(k, vs) for k, vs in fields.items() if k not in ("LeftTime",)]
        plain_lines, cond_lines = [], []
        for k, vs in others:
            for v in vs:
                bl = v.get("by_level")
                tail = f" → Lv1..10 {bl}" if isinstance(bl, list) else (f" = {bl}" if bl is not None else "")
                line = f"  - `{k}` = `{v['expr']}`{tail}" + (f" when {v['when']}" if v["when"] != "always" else "")
                (cond_lines if (v["when"] != "always" or len(vs) > 1) else plain_lines).append(line)
        if plain_lines:
            out.append("- Buff fields set in the constructor (all recovered):")
            out += plain_lines[:24]
        if cond_lines:
            out.append("- Buff parameters that depend on the weapon/gem (constructor overloads):")
            out += cond_lines[:14]
        for nm, items in b.get("other", {}).items():
            txt = "; ".join(f"`{i['name']}`={i['text']}" for i in items[:4])
            if txt: out.append(f"- Hook `{nm}`: {txt}")
    return out


def prose(rec):
    """auto-generated explanation"""
    s = []
    cat = rec.get("category")
    pr = rec.get("proration") or {}
    tp = [it for m, it in all_items(rec) if it["kind"] == "tpl"]
    nt = [it for m, it in all_items(rec) if it["kind"] == "info" and it["name"] == "templates"]
    if tp:
        n = max((int(i["text"]) for i in nt), default=1)
        hits = "one damage template (one hit)" if n <= 1 else f"{n} separate damage templates (each is a full hit with its own crit roll)"
        s.append(f"The skill builds {hits}. For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, "
                 "stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.")
    if pr.get("slot") and pr.get("slot") != "none":
        s.append(f"Proration uses the **{SLOT_TXT.get(pr['slot'], pr['slot'])}**; {PRORATION_TXT.get(pr['mode'].split(' ')[0].split('+')[0].strip(), pr['mode'])}")
    elif pr.get("mode", "").startswith("never"):
        s.append("This action never changes monster proration: " + pr["mode"].replace("never (", "").rstrip(")") + ".")
    if rec.get("buffs"):
        s.append("It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.")
    return s


FIELD_TXT = {
    "abnormalPercent": "Chance to inflict the skill's status ailment (%)", "flinchPercent": "Flinch chance (%)", "blindPercent": "Blind chance (%)",
    "stunPercent": "Stun chance (%)", "tumblePercent": "Tumble chance (%)", "slowPercent": "Slow chance (%)", "stopPercent": "Stop chance (%)",
    "poisonPercent": "Poison chance (%)", "freezePercent": "Freeze chance (%)", "sleepPercent": "Sleep chance (%)",
    "criticalPercent": "Extra critical chance (%)", "abnormalRate": "Ailment chance (%)",
    "hpHeal": "HP healed", "hpRecovery": "HP recovered", "maxHpRecovery": "HP recovery cap", "mpRecovery": "MP recovered",
    "costMp": "MP cost", "mp": "MP cost", "baseMp": "Base MP cost", "cost": "Cost",
    "CastTime": "Cast time modifier", "Radius": "Effect radius (Unity units)", "radius": "Effect radius", "attackRange": "Attack range",
    "range": "Range", "healRange": "Heal range", "supportRange": "Support range",
    "LoopParam": "Loop / hit-repeat count", "damageCount": "Number of damage events", "hitCount": "Hit count", "maxAttackCount": "Max attacks",
    "resistBreaker": "Pierce (ignores this % of target DEF/MDEF)", "physicsResistBreaker": "Physical pierce %", "magicResistBreaker": "Magic pierce %",
    "bonusSkillRate": "Alternate skill multiplier (%)", "firstSkillRate": "First-part skill multiplier (%)", "secondSkillRate": "Second-part multiplier",
    "rangeSkillRate": "Range-dependent multiplier (%)", "targetSkillRate": "Per-target multiplier (%)", "skillRateFirst": "First-hit multiplier",
    "firstFixAddDamage": "First-part flat damage", "secondFixAddDamage": "Second-part flat damage", "bonusFixAddDamage": "Bonus flat damage",
    "resist": "Resistance value", "magicResist": "Magic resistance", "consumptionHp": "HP consumed", "percent": "Effect percent",
}


TERM_ORDER = ["AddConstant[SkillConstantDamage]", "SetConstant[SkillConstantDamage]", "AddConstant[BufferConstantDamage]", "SetConstant[BufferConstantDamage]",
              "AddConstant[BaseDamage]", "SetConstant[BaseDamage]", "SetConstant[Def]", "AddConstant[Def]", "AddConstant[FirstAttack]",
              "AddRate[CriticalRate]", "AddRate[ElementBonusRate]", "AddRate[NormalElementDamageResistRate]", "AddRate[SkillRate]", "SetRate[SkillRate]",
              "AddRate[FirstAttackRate]", "AddRate[StableRate]", "SetRate[StableRate]", "SetRate[ExpRate]", "AddRate[ExpRate]", "AddRate[LastDamageRate]",
              "SetRate[LastDamageRate]", "AddRate[NormalAttackPowerWave]"]


def formula_lines(rec):
    seen, out = set(), []
    tpls = [(m, it) for m, it in all_items(rec) if it["kind"] == "tpl"]
    if not tpls: return out
    out.append("- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, "
               "`ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.")
    for key in TERM_ORDER:
        its = [(m, it) for m, it in tpls if f"{it['name']}" == key]
        if not its: continue
        variants = []
        for m, it in its:
            t = symbolic(it["text"], rec)
            if t not in variants: variants.append(t)
        step = key.split("[")[1].rstrip("]")
        verb = "adds" if key.startswith("AddConstant") else "sets" if key.startswith(("SetConstant", "SetRate")) else "multiplies by (adds into)"
        if key.startswith("SetRate[ExpRate]"): verb = "sets"
        if step in seen: continue
        seen.add(step)
        out.append(f"- `{step}` {verb}: " + " | ".join(f"`{v}`" for v in variants[:3]))
    return out


def mechanics(rec):
    out, seen = [], set()
    for m, it in all_items(rec):
        if it["kind"] != "set" or it["name"] not in FIELD_TXT or it["name"] in seen: continue
        seen.add(it["name"])
        vs = [i for mm, i in all_items(rec) if i["kind"] == "set" and i["name"] == it["name"]]
        txt = []
        for i in vs[:3]:
            bl = i.get("by_level")
            piece = f"`{i['text']}`"
            if isinstance(bl, list): piece += f" → Lv1..10 {bl}"
            elif bl is not None: piece += f" = {bl}"
            if i["when"] != "always": piece += f" _(when {i['when']})_"
            txt.append(piece)
        out.append(f"- **{FIELD_TXT[it['name']]}** (`{it['name']}`): " + "; ".join(txt))
    return out


def render_skill(rec):
    uid = rec["uid"]
    name = rec.get("name_th") or rec.get("class") or str(uid)
    name = re.sub(r"\[N2?\]|\[[A-Z]\]", " / ", name).strip(" /")
    en_ = rec.get("name_en") or ""
    icon = rec.get("icon") or ""
    head = f"### {name}" + (f" ({en_})" if en_ else "") + f" · uid {uid}"
    L = [head, ""]
    if icon: L.append(f'<img src="../../{icon}" width="40" alt="icon"> ')
    meta = []
    if rec.get("tree"): meta.append(f"**Tree:** {clean_tree(rec['tree'])} (`{rec.get('tree_type')}`, tier {rec.get('tree_lv')})")
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
    L.append(" · ".join(meta))
    L.append("")
    if rec.get("desc_th"):
        L.append("> " + rec["desc_th"].replace("\n", "\n> "))
        L.append("")
    if rec.get("notes"):
        L.append("<details><summary>In-game level notes</summary>\n")
        for n in rec["notes"]:
            t = (n.get("text") or "").replace("\n", " ")
            L.append(f"- Lv{n.get('level')}: {t}")
        L.append("\n</details>\n")
    # quick facts
    rate = effective(rec, "AddRate[SkillRate]") or effective(rec, "SetRate[SkillRate]")
    const = effective(rec, "AddConstant[SkillConstantDamage]") or effective(rec, "SetConstant[SkillConstantDamage]")
    crit = effective(rec, "AddRate[CriticalRate]")
    rows = []
    for lab, ef in (("SkillRate ×", rate), ("Flat dmg +", const), ("Crit mult +", crit)):
        if not ef: continue
        for r_ in ef.get("rows", []):
            rows.append((lab + ("" if r_["when"] == "base" or len(ef["rows"]) == 1 else f" [{r_['when']}]"), r_["by_level"]))
    if rows:
        L.append("**Damage numbers by level** (gem bonuses assumed 0)\n")
        L.append(table(rows))
        L.append("")
    symrows = []
    for lab, ef in (("SkillRate ×", rate), ("Flat dmg +", const), ("Crit mult +", crit)):
        for sy in (ef or {}).get("syms", []):
            symrows.append(f"- {lab} `{sy['formula']}`" + ("" if sy["when"] == "base" else f" — {sy['when']}"))
    if symrows:
        L.append("**Formulas that depend on live stats (not tabulated)**\n")
        L += symrows
        L.append("")
    if rec.get("roles"):
        L.append("**Role:** " + " · ".join(rec["roles"]) + "\n")
    for txt in prose(rec): L.append(txt); L.append("")
    fl = formula_lines(rec)
    if fl:
        L.append("**Damage formula for this skill** (per template; `int()` after every multiplier)\n")
        L += fl
        L.append("")
    mech = mechanics(rec)
    if mech:
        L.append("**Mechanics recovered from code**\n")
        L += mech
        L.append("")
    if rec.get("proration"):
        p = rec["proration"]
        L.append(f"**Proration:** slot `{p['slot']}`, mode `{p['mode']}`, attack type `{p['attack_type']}`, action id {p['action_id']}"
                 + (f", spawns `{p['child_actions']}`" if p.get("child_actions") else "") + "\n")
    # mastery
    m = rec.get("mastery")
    if m and m.get("bonuses"):
        L.append("**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)\n")
        rows = [(k, v["by_level"]) for k, v in m["bonuses"].items() if v.get("by_level")]
        if rows: L.append(table(rows)); L.append("")
        for k, v in m["bonuses"].items():
            if not v.get("by_level"): L.append(f"- `{k}` = `{v['expr']}`")
        L.append("")
    # method detail
    if rec.get("methods"):
        L.append("<details><summary>Recovered formulas (per method)</summary>\n")
        for mname, v in rec["methods"].items():
            items = [it for it in v["items"] if not (it["kind"] == "set" and it["name"] in ("ActionRange", "Element", "SkillParam", "SkillIndividualFlag", "LoopParam", "CastTime") and False)]
            if not items: continue
            L.append(f"**`{mname}`** ({v['paths']} path{'s' if v['paths'] != 1 else ''}{', truncated' if v['truncated'] else ''})\n")
            for it in items:
                bl = f" → Lv1..10: {it['by_level']}" if it.get("by_level") is not None and isinstance(it["by_level"], list) else (f" = {it['by_level']}" if it.get("by_level") is not None else "")
                w = "" if it["when"] == "always" else f" — when {it['when']}"
                lab = {"set": "set", "tpl": "template", "call": "calls", "info": "info"}[it["kind"]]
                L.append(f"- {lab} `{it['name']}` = `{it['text']}`{bl}{w}")
            L.append("")
        L.append("</details>\n")
    bl = buff_lines(rec)
    if bl:
        L.append("**Buffs**\n")
        L += bl
        L.append("")
    for ce in rec.get("consumer_effects", []):
        L.append(f"<details><summary>Effect applied in `{ce['fn']}` ({ce['npaths']} guarded path{'s' if ce['npaths'] != 1 else ''}"
                 f"{', truncated' if ce.get('truncated') else ''})</summary>\n")
        for p_ in ce["paths"][:8]:
            conds = [c for c in p_["cond"] if "+0x" not in c and "?x" not in c][:4]
            L.append("- when " + " AND ".join(f"`{_lv(c)[:400]}`" for c in conds) if conds else "- always")
            if p_.get("ret"): L.append(f"  - returns `{_lv(p_['ret'])}`")
            for k, v in p_["fields"].items(): L.append(f"  - set `{k}` = `{_lv(v)[:400]}`")
            for t in p_["tpl"]: L.append(f"  - template `{t[0]}[{t[1]}]` = `{_lv(t[2])[:400]}`")
            if p_["calls"]: L.append("  - calls " + ", ".join(f"`{c}`" for c in p_["calls"][:8]))
        L.append("\n</details>\n")
    if rec.get("consumers"):
        L.append("**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)\n")
        L += [f"- `{c}`" for c in rec["consumers"]]
        L.append("")
    L.append("---\n")
    return "\n".join(L)


def main():
    os.makedirs(os.path.join(OUT, "trees"), exist_ok=True)
    trees = collections.OrderedDict()
    for r in recs:
        key = str(r.get("tree_type") or ("(internal actions)" if not r.get("in_skill_tree") else "(no tree)"))
        trees.setdefault(key, []).append(r)
    index = ["# Skill reference index", "", "Plain-language walkthrough of every skill: [DETAILS.md](DETAILS.md). Raw recovered data per tree: below.", ""]
    for key, rs in trees.items():
        rs.sort(key=lambda r: (r.get("tree_lv") or 0, r["uid"]))
        fn = re.sub(r"[^\w.-]+", "_", key) + ".md"
        title = clean_tree(rs[0].get("tree")) if rs[0].get("tree") else key
        body = [f"# {title} (`{key}`)", "", f"{len(rs)} entries. See ../README.md for how to read these blocks.", ""]
        for r in rs: body.append(render_skill(r))
        open(os.path.join(OUT, "trees", fn), "w", encoding="utf-8").write("\n".join(body))
        index.append(f"- [{title} `{key}`](trees/{fn}) — {len(rs)} entries")
    open(os.path.join(OUT, "INDEX.md"), "w", encoding="utf-8").write("\n".join(index) + "\n")
    # csv
    with open(os.path.join(OUT, "skill_levels.csv"), "w", encoding="utf-8-sig", newline="") as f:
        w = csv.writer(f)
        w.writerow(["uid", "name_th", "name_en", "tree_type", "category", "class", "proration_slot", "proration_mode", "templates"]
                   + [f"rate_L{i}" for i in range(1, 11)] + [f"flat_L{i}" for i in range(1, 11)])
        for r in recs:
            if not r.get("methods"): continue
            rate = effective(r, "AddRate[SkillRate]") or effective(r, "SetRate[SkillRate]")
            const = effective(r, "AddConstant[SkillConstantDamage]") or effective(r, "SetConstant[SkillConstantDamage]")
            nt = max((int(i["text"]) for m, i in all_items(r) if i["kind"] == "info" and i["name"] == "templates"), default="")
            p = r.get("proration") or {}
            w.writerow([r["uid"], r.get("name_th", ""), r.get("name_en", ""), r.get("tree_type", ""), r.get("category", ""), r.get("class", ""),
                        p.get("slot", ""), p.get("mode", ""), nt] + list((rate or {}).get("by_level") or [""] * 10) + list((const or {}).get("by_level") or [""] * 10))
    print("rendered", len(trees), "tree files")


if __name__ == "__main__":
    main()
