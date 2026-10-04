"""Cross-check the automatically recovered numbers against the hand-derived Dual Sword notes and in-game notes."""
import sys, os, json
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import render_docs as R

OUT = os.path.join(R.OUT, "VALIDATION.md")
L10 = range(1, 11)


def rows(uid, step):
    ef = R.effective(R.byuid[uid], step)
    return {r["when"]: r["by_level"] for r in (ef or {}).get("rows", [])}


def one(uid, step):
    r = rows(uid, step)
    return list(r.values())[0] if r else None


def approx(a, b):
    return a is not None and len(a) == len(b) and all(abs(x - y) < 1e-6 for x, y in zip(a, b))


checks = []


def chk(label, actual, expected, src):
    ok = approx(actual, expected) if isinstance(expected, list) else actual == expected
    checks.append((label, ok, actual, expected, src))


# Twin Slash 642
chk("642 Twin Slash SkillRate", one(642, "AddRate[SkillRate]"), [(10 * l + 150) / 100 for l in L10], "dual_sword/formula.md 2.1")
chk("642 Twin Slash flat", one(642, "AddConstant[SkillConstantDamage]"), [10 * l + 100 for l in L10], "dual_sword/formula.md 2.1")
# Parrying 643
chk("643 Parrying Sword SkillRate (gem 0)", one(643, "AddRate[SkillRate]"), [(l + 100) / 100 for l in L10], "2.2")
chk("643 Parrying Sword flat", one(643, "AddConstant[SkillConstantDamage]"), [5 * l + 50 for l in L10], "2.2")
# Air Slide 646
r646 = rows(646, "AddRate[SkillRate]")
first = next((v for k, v in r646.items() if "calcFirstDamage" in k), None)
later = next((v for k, v in r646.items() if "calcAnyDamage" in k), None)
chk("646 Air Slide first-hit rate", first, [(int(2.5 * l) + 125) / 100 for l in L10], "2.5 first hit")
chk("646 Air Slide later-hit rate", later, [(2 * l + 30) / 100 for l in L10], "2.5 later hits")
chk("646 Air Slide flat", one(646, "AddConstant[SkillConstantDamage]"), [5 * l + 50 for l in L10], "2.5")
bp = [i for m, i in R.all_items(R.byuid[646]) if i["kind"] == "set" and i["name"] == "blindPercent"]
chk("646 Air Slide blind chance", bp[0].get("by_level") if bp else None, [int(2.5 * l) + 15 for l in L10], "2.5 blind chance")
# Shining Cross 652
chk("652 Shining Cross flat", one(652, "AddConstant[SkillConstantDamage]"), [20 * l + 100 for l in L10], "2.11")
s652 = R.effective(R.byuid[652], "AddRate[SkillRate]")
f652 = " ".join(x["formula"] for x in (s652 or {}).get("syms", []))
checks.append(("652 Shining Cross rate contains 10*Lv+300", "(Lv * 10) + 300" in f652, f652[:100], "10*Lv+300 + stats/5", "2.11"))
# Storm Reaper 653
chk("653 Storm Reaper flat", one(653, "AddConstant[SkillConstantDamage]"), [10 * l + 100 for l in L10], "2.12")
s653 = R.effective(R.byuid[653], "AddRate[SkillRate]")
f653 = " ".join(x["formula"] for x in (s653 or {}).get("syms", []))
checks.append(("653 Storm Reaper rate base 10*Lv+400", "+ 400" in f653, f653[:120], "10*Lv+400+(baseDEX/100)*Lv", "2.12 (DEX divisor differs, see below)"))
# Luna Dither Star 655
chk("655 Luna Dither Star flat", one(655, "AddConstant[SkillConstantDamage]"), [400] * 10, "2.15")
# Twin Buster Blade 656
chk("656 Twin Buster Blade flat", one(656, "AddConstant[SkillConstantDamage]"), [30 * l for l in L10], "2.16")
# Arial Slay 659
chk("659 Aerial Slay flat", one(659, "AddConstant[SkillConstantDamage]"), [20 * l + 100 for l in L10], "2.18")
# Hard Hit in-game notes (Lv10: flinch +50% with one-hand sword)
fp = [i for m, i in R.all_items(R.byuid[33]) if i["kind"] == "set" and i["name"] == "flinchPercent"]
vals = {i["when"]: i.get("by_level") for i in fp}
chk("33 Hard Hit flinch chance (1H sword, in-game note '+50%')", next((v for k, v in vals.items() if "== OneHandSword" in k and "!=" in k), None),
    [int(l * 4.5 + 0.5) + 5 + 50 for l in L10], "skills_full notes Lv10")
# Mastery sanity: Blade mastery weapon ATK% +3/Lv
mb = R.byuid[36]["mastery"]["bonuses"]["EqAtkRate"]["by_level"]
chk("36 Sword Mastery EqAtkRate", mb, [3 * l for l in L10], "3% per level (Toram community value)")

ok = sum(1 for c in checks if c[1])
md = ["# Validation of the automatically recovered formulas", "",
      f"Compared against the hand-derived Dual Sword notes (`calc Reverse/dual_sword/formula.md`) and in-game notes. **{ok}/{len(checks)} checks agree.**", "",
      "| Check | Result | Recovered | Expected | Source |", "|---|---|---|---|---|"]
for label, good, act, exp, src in checks:
    md.append(f"| {label} | {'PASS' if good else 'DIFF'} | `{str(act)[:90]}` | `{str(exp)[:90]}` | {src} |")
md += ["", "## Known difference", "",
       "Storm Reaper (653): the recovered code divides the stat by **25** (`mul x8,x8,#0x51eb851f ; asr x8,x8,#0x23`, i.e. multiply-high by the",
       "magic constant then shift 35 = ÷25) while `dual_sword/formula.md` 2.12 says ÷100. The instruction stream of the Storm Reaper damage method (skill 653 `details/` page) shows the",
       "shift is 35, so the recovered ÷25 follows the code; the earlier note should be re-checked. Not verified in game.", ""]
open(OUT, "w", encoding="utf-8").write("\n".join(md))
print(ok, "/", len(checks))
for c in checks:
    if not c[1]: print("DIFF", c[0], str(c[2])[:100], "|", str(c[3])[:100])
