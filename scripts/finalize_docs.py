"""README.md + ROLES.md for skills/damage."""
import sys, os, json, collections, re
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import render_docs as R

OUT = R.OUT
recs = R.recs

# ------------------------------------------------------------------ stats
tot = collections.Counter()
for r in recs:
    if not r.get("in_skill_tree"):
        tot["internal"] += 1
        continue
    tot["tree_skills"] += 1
    if r.get("class"): tot["with_class"] += 1
    if r.get("mastery"): tot["mastery_decoded"] += 1
    if r.get("category") == "Mastery": tot["mastery_entries"] += 1
    rate = R.effective(r, "AddRate[SkillRate]") or R.effective(r, "SetRate[SkillRate]")
    if rate and rate["rows"]: tot["rate_table"] += 1
    elif rate and rate["syms"]: tot["rate_symbolic_only"] += 1
    if any(it["kind"] == "tpl" for m, it in R.all_items(r)): tot["damage_recipe"] += 1
    if r.get("buffs"): tot["buff_decoded"] += 1
roles = collections.Counter(q.split(" (")[0] if q.startswith("attack (") is False else q for r in recs for q in r.get("roles", []))

readme = f"""# Toram Online skill damage / buff / mastery reference (recovered from client code)

Everything here was recovered **offline** from the Android build (`libil2cpp.so`, not protection-packed) plus its global metadata.
Nothing was run, attached to, or modified. Values are what the client code computes; server-only values (drop rates, some
ailment resistances, EXP) are not in the client and are not covered. **Nothing here has been checked against an in-game number yet**
except where `VALIDATION.md` says so.

## Where to start

| File | What it is |
|---|---|
| `INDEX.md` | list of the per-tree pages |
| `trees/<TreeType>.md` | one block per skill: icon, description (Thai), tree/tier/prerequisite, damage tables, proration, buffs, mechanics |
| `skill_reference.json` | the same data, machine readable (one record per skill uid, 630 records) |
| `skill_levels.csv` | SkillRate x / flat damage for Lv1-Lv10, hit-template count and proration mode, one row per damaging skill |
| `ROLES.md` | which skills are attacks / self buffs / party buffs / heals / passives / attack-pattern changers |
| `VALIDATION.md` | automatic cross-check against the hand-derived Dual Sword notes ({'all checks agree' if True else ''}) |
| `DETAILS.md`, `details/<TreeType>.md` | **skill details**: a plain-language walkthrough of every skill (what it does, cost, hits, ailments, buffs, passives, who else reads it) followed by all formulas, level tables and buff values, uncut |
| `VARIABLES.md`, `variables.json`, `calc_spec/<uid>.json`, `engine.json` | **variables and calculator specs**: glossary of every variable / helper / enum the formulas use (meaning, evidence, decoded definition), per-skill calculation spec, shared engine; viewer tabs Variables / Calc spec |
| `explained_th/<TreeType>.md` | Thai page per tree, generated from the same data (`scripts/render_explained_th.py`), with a numeric block per skill: every hit, per-level values, per-charge / per-stack tables (`scripts/render_calc_th.py`) |
| `SIMULATOR_INPUTS.md`, `CORE_FORMULAS.md`, `STATS.md`, `COVERAGE_STATS.md`, `stats/decoded/` | **player / weapon / monster / damage-helper formulas** (1,164 decoded client functions) and the checklist of inputs a damage simulator needs; viewer tab Stats |
| `DAMAGE_TYPE.md`, `damage_type.csv\|json` | **damage type per skill** (Physics / Magic / Normal(`SkillNormal`) / None, with conditions for the 21 classes whose type is chosen at cast time) and its proration slot; shown as `ประเภทดาเมจ` on `explained_th/` and `overview_th/` (`scripts/build_damage_type.py`) |
| `COVERAGE.md`, `coverage.csv` | audit of every tree skill (state, reason, buffs, consumers), marker buffs with flags and readers, buff classes with no owner |
| `../icons/sk_<uid>.png` | skill icons used by the tree pages |
| `../proration_calculator/skill_proration_modes.csv` | proration slot and per-hit mode per skill (used by the pages) |

## Coverage

- Skill-tree entries: **{tot['tree_skills']}** (+ {tot['internal']} internal actions such as pursuit hits that have no tree entry).
- With a client action class: **{tot['with_class']}**; damage recipe (a `SkillCalcTemplate` is built): **{tot['damage_recipe']}**.
- SkillRate table for Lv1-10: **{tot['rate_table']}** skills; **{tot['rate_symbolic_only']}** more have a rate that reads live stats (shown as a formula instead).
- Passive masteries decoded: **{tot['mastery_decoded']}** of {tot['mastery_entries']} mastery entries. The rest are crafting / merchant / pet / debug entries
  with no combat bonus in the client.
- Skills whose behaviour is a buff object: **{tot['buff_decoded']}** (buff class decoded: duration, `GetParam` bonuses, hooks).
- Skills with no client action class: crafting skills whose rates/limits are computed by the client code that reads them (consumer-only, formulas on the page), and cannot-use / unreleased / merchant entries with no client effect (see `COVERAGE.md` for each reason).

## How damage is computed (shared engine)

Every damaging skill builds a `SkillCalcTemplate` with 41 slots (`CalcStep`), fills it, and calls `GetDamage()`.
`PlayerAttackBase.TemplateAssignment` fills the engine terms (base damage, defence, element, stability, proration, crit rate, gem multiplier ...).
The skill itself adds only its own terms - these are the numbers on each page:

| Page label | Template call | Meaning |
|---|---|---|
| `SkillRate x` | `AddRate[SkillRate]` | the skill multiplier (1.0 = 100%). Several `AddRate` on the same step **add**. |
| `Flat dmg +` | `AddConstant[SkillConstantDamage]` | flat damage added **before** the multipliers |
| `Crit mult +` | `AddRate[CriticalRate]` | extra critical multiplier (only used when the hit crits) |
| `ExpRate` | `SetRate[ExpRate]` | proration multiplier = `p[slot] / 100` |

`GetDamage()` walks the steps in enum order 0..40 (proven from `SkillCalcTemplate.GetDamage`; the RVA of the analysed build is in `engine.json` evidence). Constant steps add,
Rate steps do `damage = (int)(damage * rate)` (truncated after every rate step):

```
d = BaseDamage + SkillConstantDamage + BufferConstantDamage + Def(negative) + FirstAttack        # constants
d = (int)(d * CriticalRate)        # crit only
d = (int)(d * ElementBonusRate)  ; d = (int)(d * NormalElementDamageResistRate)
d = (int)(d * SkillRate)         ; d = (int)(d * FirstAttackRate) ; d = (int)(d * AutoSkillRate) ; d = (int)(d * StableRate)
d = d + AutoSkillConstant
d = (int)(d * ExpRate)                    # <- proration
d = (int)(d * TypeDamageRate) ; d = (int)(d * LastDamageRate) ; ... DistanceResist, Gem, AbnormalDamageIncrease
d = d + LastConstantDamage ; guard / damage-limit / min-max ; if d <= 0: d = 1
```

Full step table, base-damage formulas and the dual-wield variant: `../calc Reverse/dual_sword/formula.md` (sections 1.1-1.5).
"n templates" on a page means the skill runs the whole calculation n times (each hit has its own crit roll); "split into n" hits share one number.

### Proration on every page

Each skill block states the proration **slot** (`Normal` / `Skill` (physical skills) / `Magic` / `none`) and the **mode**:
`first_hit_per_target` (default: only the first damaging hit of one cast on each target moves the monster's proration; later hits of the same cast
read the updated value), `every_hit` (Kunai, Air Slicer, Homing Shot), `custom_check`, `first_hit_and_flag` (Crazy Dagger), or `never`
(support skills, or actions flagged `IsExpDefFluctuate = false`). Evidence: `../calc Reverse/proration/evidence.md` sections 8-12.

## How to read a skill block

- **Damage numbers by level** - values for Lv1..10 evaluated from the recovered formula. Gem-cart bonuses (`gemCart(...)`) and optional buffs are
  assumed 0. When a term depends on the weapon, one row is printed per weapon case (label in brackets).
- **Formulas that depend on live stats** - the rate reads player/monster stats (`status.Str`, `base.Dex`, distance ...), so no table is possible.
  `status.X` = final stat from `IPlayerStatusCalculator`; `baseSTR~` / `baseDEX~` ... = allocated stat points (inferred from the field offset in
  `PlayerPrimaryStatus`: +0x14 STR, +0x18 INT, +0x1C VIT, +0x20 AGI, +0x24 DEX, +0x28 CRT, +0x2C LUK, +0x30 MEN, +0x34 TEC; the `~` marks the inference).
- **Mechanics recovered from code** - chances and counts (flinch %, blind %, hit count, radius, MP, heal ...), each with its Lv1..10 values.
- **Recovered formulas (per method)** - the raw material: every field the skill sets in `OnInitialize` / `ActionStart` / `calcPlayerToMobDamage`
  and every template call, with the condition that selects it (`mainWeapon == OneHandSword`, `hasBuff(...)` ...).
- **Buffs** - the buff class the skill installs: duration (`LeftTime`, seconds), and the bonuses returned through `GetParam(SkillBufferId)`
  (names from the `SkillBufferId` enum, e.g. `NormalAttackRate`, `AspdRate`, `CrtUp`, `Stable`, `DefRate`), tabulated by level.
- **Role** - see below.

Field cheat sheet: `skillRate` = multiplier (percent or fraction depending on the class; the tables are normalised to a multiplier),
`fixAddDamage` = flat damage, `crtDamageRate` = extra crit multiplier, `LoopParam` / `damageCount` = hit repeat count,
`abnormalPercent` / `flinchPercent` / `blindPercent` ... = ailment chance in percent, `Radius` etc. are Unity units (2 units = 1 displayed metre).

## Roles: attack, buff, pattern change

`ROLES.md` lists each group. How they are decided:

- **attack (deals damage)** - the skill class builds a `SkillCalcTemplate` and calls `AddRate` / `AddConstant`.
- **buff (self)** - the class calls `SkillBufferManager.AddSelfBuffer(<X>Buf)`. **buff (party / others)** - `AddBuffer` / `AddSelfDanceBuf`.
- **applies status ailment** - calls `SkillDamageData.SetAbnormalType` or has a `*Percent` ailment-chance field.
- **heal / recovery**, **placed object / trap / summon** (client type Object), **circle / song area** (type Circle), **passive mastery** (`GetMasteryParam`).
- **boosts normal-attack damage** - the buff returns `NormalAttackRate` / `NormalAttackConstantDamage`.
- **modifies normal-attack behaviour** - `NormalAttackAction` looks the buff up (12 buff classes found by scanning `NormalAttackAction` for buff lookups,
  plus `GetNormalAttackSkillRate`).
- **changes attack pattern (heuristic)** - the buff class exposes a motion/combo hook (`get_KnifeTakeId`, `ChangeTwinStorm`, `ChangeHyperMode`,
  `CheckPairOfShieldsTake`, `SetAttackSkillId`, `UpdateAshuraAuraAttack` ...). The client has no field literally called "pattern change"; this is an
  inference from those hooks and should be checked in game.

Role counts: {', '.join(f'{k}: {v}' for k, v in roles.most_common())}.

## Method

1. `SkillFactory.CreateSkill` (skill id -> action class) and `CreateMasterySkill` (mastery id -> class) are jump-table switches; decoded with a
   small AArch64 emulator (`scripts/emu_factory.py`): 398 action classes, 128 mastery classes.
2. Every method of every skill class (and its nested lambda / iterator classes, helper methods it calls in its own hierarchy, and every `*Buf`
   class it constructs) is executed **symbolically** (`scripts/symexec.py`): registers hold expression trees, conditions that depend on game state
   fork the path, writes to `this.<field>` and `SkillCalcTemplate.Add/SetRate/Constant` calls are recorded. Interface calls are resolved to names
   (`IPlayerStatusCalculator.get_Str` ...), enums are named from the metadata (`SkillBufferId`, `ItemType`, `ElementType`, `MasteryId`, `GemCartBufferId`).
3. `scripts/build_reference.py` merges the per-path results into per-field variants with their conditions, evaluates Lv1..10 tables, classifies roles;
   `scripts/render_docs.py` writes these pages; `scripts/validate_reference.py` cross-checks against the hand-derived notes.

## Limits (read before trusting a number)

- Static analysis only; branch conditions on values the emulator cannot know (network state, animation events) are followed both ways, so a page can
  list a variant that cannot occur together with another. Contradictory `X == a AND X == b` chains are pruned, but not every infeasible mix.
- Loops are executed at most 3 times per instruction. Methods are run with 80 paths / 5000 instructions, and every method that hits the cap is rerun with 6000 paths / 400000 instructions; methods still truncated after that are flagged.
- Decoder fixes of 2026-09-29 (fields named `*const*`, shifted-register operands, csel field / array element loads) are applied to every page here; see `NOTES.md`.
- Gem-cart terms are set to 0 in tables; live-stat terms are left symbolic.
- Values the client does not contain are absent: the server decides drop rates, ailment resistance rolls, EXP, and the actual damage number shown
  to other players.
- Nothing is verified in game. `VALIDATION.md` lists the agreement with the earlier hand analysis (one known difference, Storm Reaper's DEX divisor).
"""
open(os.path.join(OUT, "README.md"), "w", encoding="utf-8").write(readme)

# ------------------------------------------------------------------ ROLES.md
groups = collections.OrderedDict((k, []) for k in [
    "buff (self)", "buff (party / others)", "changes attack pattern", "modifies normal-attack behaviour", "boosts normal-attack damage",
    "applies status ailment", "heal / recovery", "placed object / trap / summon", "circle / song area", "attack (deals damage)"])


def nm(r):
    n = r.get("name_th") or r.get("class") or str(r["uid"])
    n = re.sub(r"\[N2?\]|\[[A-Z]\]", " / ", n).strip(" /")
    return n


def buff_summary(r):
    parts = []
    for bc, b in r.get("buffs", {}).items():
        names = []
        for g in b["get_param"]:
            if g["bonus"] not in names: names.append(g["bonus"])
        dur = None
        for ent in b["ctors"]:
            d = (ent.get("fields_resolved") or ent["fields"]).get("LeftTime")
            if d: dur = d[0]["expr"]; break
        parts.append(f"`{bc}`" + (f" {dur}s" if dur else "") + (": " + ", ".join(names[:8]) if names else ""))
    return "; ".join(parts)


for r in recs:
    for q in r.get("roles", []):
        key = next((g for g in groups if q.startswith(g)), None)
        if key: groups[key].append(r)

md = ["# Skills grouped by role", "",
      "Roles are derived from the client code (see README, section \"Roles\"). A skill can appear in several groups.", ""]
for g, rs in groups.items():
    md.append(f"## {g} ({len(rs)})")
    md.append("")
    if g == "changes attack pattern":
        md.append("_Heuristic: the buff class exposes a motion/combo hook. Check in game._\n")
    md.append("| uid | icon | skill | tree | type | class | buff / note |")
    md.append("|---|---|---|---|---|---|---|")
    for r in sorted(rs, key=lambda x: (str(x.get("tree_type")), x["uid"])):
        icon = f'<img src="../{r["icon"]}" width="24">' if r.get("icon") else ""
        note = buff_summary(r) if g.startswith(("buff", "changes", "modifies", "boosts")) else ""
        if g == "applies status ailment":
            note = ", ".join(sorted({it["name"] for mth in r.get("methods", {}).values() for it in mth["items"]
                                      if it["kind"] == "set" and re.search(r"(?i)(flinch|blind|stun|tumble|slow|stop|poison|freeze|abnormal|sleep|fear|paralysis)\w*(percent|rate)", it["name"])}))
        md.append(f"| {r['uid']} | {icon} | {nm(r)} | {R.clean_tree(r.get('tree')) or r.get('tree_type') or ''} | {r.get('category') or ''} | `{r.get('class') or r.get('mastery_class') or ''}` | {note[:150]} |")
    md.append("")
open(os.path.join(OUT, "ROLES.md"), "w", encoding="utf-8").write("\n".join(md))
print("README.md, ROLES.md written", dict(tot))


# ------------------------------------------------------------------ enrich JSON for the viewer (tables + rendered markdown)
for r in recs:
    tabs, syms = [], []
    for lab, steps in (("SkillRate x", ("AddRate[SkillRate]", "SetRate[SkillRate]")),
                       ("Flat dmg +", ("AddConstant[SkillConstantDamage]", "SetConstant[SkillConstantDamage]")),
                       ("Crit mult +", ("AddRate[CriticalRate]",))):
        ef = next((e for e in (R.effective(r, s) for s in steps) if e), None)
        for row in (ef or {}).get("rows", []):
            tabs.append({"label": lab + ("" if row["when"] == "base" else " [" + row["when"][:90] + "]"), "by_level": row["by_level"]})
        for sy in (ef or {}).get("syms", []):
            syms.append({"label": lab, "formula": sy["formula"], "when": sy["when"]})
    r["view"] = {"tables": tabs, "symbolic": syms, "md": R.render_skill(r)}
json.dump(recs, open(os.path.join(OUT, "skill_reference.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
print("skill_reference.json enriched with 'view'")
