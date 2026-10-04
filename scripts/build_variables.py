"""Decode every helper / getter the skill pages call, into definitions over named leaves.
usage (cwd D:\\toram_re): python build_variables.py
Input : D:\\toram reverse data\\skills\\damage\\unresolved.csv (callee symbols; python audit_unresolved.py first)
Output: D:\\toram reverse data\\skills\\damage\\variables_raw.json
  {symbol: {used_by:[uid], impls:[{class, addr, params, returns, truncated, cases:[{value, common:[cond], variants:[[cond]], n}]}]}}
Roots = callees on the skill pages + every IPlayerStatusCalculator / IMobStatusCalculator member + engine entry points;
then the closure over engine-class callees found inside decoded bodies (3 rounds).
"""
import il2
import sys, os, re, csv, json, collections
import symexec as S
import dis2 as D2
from run_skills import clean
from spec_tidy import tidy

S.NAME_ENUMS = True
S.LETS_ON = True
OUT = r"D:\toram reverse data\skills\damage"
IMPL = {}   # interface -> [implementing classes]
ENGINE_CLS = re.compile(r"^(PlayerAttackBase|SkillActionBase|PlayerStatusBase|PlayerSecondaryStatus|PlayerBattleStatus|PlayerStatus|BonusManager|BonusParameter|"
                        r"SkillUtil|MathUtil|MobBattleStatus|IMobStatusCalculator|IPlayerStatusCalculator|EquipItemData(\.\w+)?|SkillComboState|SacredTeachings|"
                        r"GemCartBufferManager|GemCartBufferBase|MobProperty\w*|NormalAttackAction|NinjaSkillBase|SkillMasteryBase|SkillBufferManager|"
                        r"SkillBufferDataBase|AbnormalStateManager|ItemData|SkillCalcTemplate|PetStatus|MobAttackBase|CountBufferBase|EquipBuffManager)$")
ROOT_NAMES = ["PlayerAttackBase$$TemplateAssignment", "PlayerAttackBase$$calcBaseDamage", "PlayerAttackBase$$CalcPowerResistDamage",
              "PlayerAttackBase$$CalcMagicResistDamage", "PlayerAttackBase$$CalcSkillTypeBonusRate", "PlayerAttackBase$$CalcStable",
              "PlayerAttackBase$$checkCriticalPercent", "SkillActionBase$$CalcStablePercent", "SkillActionBase$$CalcMagicStablePercent",
              "SkillCalcTemplate$$GetDamage", "ExtensionMethod.ExSkillData.SkillDataExtentionMethod$$GetTargetExpRate",
              "NormalAttackAction$$CalcBaseDamage", "PlayerAttackBase$$CalcElementBonus", "PlayerAttackBase$$CalcHitReaction"]
CALLTOK = re.compile(r"(?<![\w.])([A-Za-z_][\w`]*(?:\.[A-Za-z_][\w`]*)*)\.([A-Za-z_]\w*)\(")


def load_impls():
    rx = re.compile(r"^(?:public|private|internal|protected)?\s*(?:abstract |sealed |static )*(?:class|struct) ([\w.<>`,]+) : ([\w.<>`, ]+?) // TypeDefIndex")
    for ln in open(D2.DUMP, encoding="utf-8"):
        m = rx.match(ln)
        if not m: continue
        for base in (x.strip() for x in m.group(2).split(",")):
            base = re.sub(r"<.*", "", base)
            if D2.C.get(base, {}).get("kind") == "interface": IMPL.setdefault(base, []).append(m.group(1))


NAME2ADDRS = collections.defaultdict(list)
for a, n in S.names.items(): NAME2ADDRS[n].append(a)


SUBS = collections.defaultdict(list)
for _c in D2.C:
    for _anc in D2.chain(_c)[1:]: SUBS[_anc].append(_c)


def addrs_for(sym):
    cls, _, m = sym.rpartition(".")
    out = _addrs_for(sym)
    if "Calculator" in cls and not cls.startswith("I"):      # virtual per-weapon-type dispatch: include every override
        out += [(sub, a) for sub in SUBS.get(cls, []) for a in NAME2ADDRS.get(f"{sub}$${m}", [])]
    return out


def _addrs_for(sym):
    cls, _, m = sym.rpartition(".")
    if cls in IMPL:                      # interface member -> every implementation
        return [(c, a) for c in IMPL[cls] for a in NAME2ADDRS.get(f"{c}$${m}", [])]
    out = [(cls, a) for a in NAME2ADDRS.get(f"{cls}$${m}", [])]
    if out: return out
    for c in D2.chain(cls)[1:]:          # inherited
        out = [(c, a) for a in NAME2ADDRS.get(f"{c}$${m}", [])]
        if out: return out
    return []


EFFECT = re.compile(r"\$\$(Add|Remove|Set|Receive|Update|Change|Start|Stop|Reset|Heal|Pay|Next|Stack|Clear|Calc|Check|Enough|Create|Apply|On)\w*")
NOISE = re.compile(r"UnityEngine|System\.|TypeInfo|il2cpp|UI3D|SoundManager|ChatManager|Effect(Play|Stop)|PopUp|Label")
PLUMB = re.compile(r"meta\(|stkp\(|\+0x0\]|0x165d|_TypeInfo")


def group(paths, rt):
    fl = rt in ("float", "double")
    by, order = {}, []
    for st in paths:
        if st.ret is None: continue
        v = tidy(clean(S.render(st.ret[1] if fl else st.ret[0])))
        conds = [tidy(clean(c)) for c in st.cond]
        conds = [c for c in conds if not PLUMB.search(c)]
        if v not in by: by[v] = []; order.append(v)
        by[v].append(conds)
    cases = []
    for v in order:
        ps = by[v]
        common = [c for c in ps[0] if all(c in p for p in ps)]
        var = []
        for p in ps:
            r = [c for c in p if c not in common]
            if r not in var: var.append(r)
        cases.append({"value": v, "common": common, "variants": var if var != [[]] else [], "n": len(ps)})
    return cases


def decode(a, mp=4000, mi=60000):
    ex = S.MergeEx(a, max_paths=mp, max_ins=mi)
    paths = ex.run()
    rt = D2.RET.get(a)
    sets = collections.OrderedDict()
    for st in paths:
        for e in st.ev:
            if e[0] == "set": sets.setdefault(e[1], tidy(clean(S.render(e[2]))))
    cases = group(paths, rt) if rt != "void" else []
    events, seen = [], set()
    for st in paths:
        for e in st.ev:
            if e[0] == "set": kind, name, val, cnd = "set", e[1], e[2], e[3]
            elif e[0] == "tpl": kind, name, val, cnd = "tpl", f"{e[1]}[{e[2]}]", e[3], e[4]
            elif e[0] == "call" and EFFECT.search(e[1]) and not NOISE.search(e[1]): kind, name, val, cnd = "call", clean(e[1]), ", ".join(clean(S.render(x)) for x in e[2]), e[4]
            else: continue
            w = [tidy(clean(c)) for c in cnd]
            w = [c for c in w if not PLUMB.search(c)]
            ent = {"kind": kind, "name": name, "value": tidy(clean(S.render(val) if not isinstance(val, str) else val)), "when": w}
            key = json.dumps(ent, sort_keys=True)
            if key in seen: continue
            seen.add(key); events.append(ent)
    events = events[:300]
    texts = [x["value"] for x in events] + [c["value"] for c in cases] + [x for c in cases for x in c["common"]] + [x for c in cases for v in c["variants"] for x in v] + list(sets.values())
    lets = {k: tidy(clean(v)) for k, v in S.lets_used(*texts).items()}
    lets = {k: v for k, v in lets.items()}
    return {"addr": hex(a), "params": [[t, n] for t, n in ex.params], "static": ex.static, "returns": rt,
            "truncated": bool(ex.truncated), "npaths": len(paths), "cases": cases, "sets": dict(sets), "events": events, "lets": lets}


def decode_symbol(sym):
    impls = []
    for cls, a in addrs_for(sym):
        try: impls.append({"class": cls, **decode(a)})
        except Exception as e: impls.append({"class": cls, "error": repr(e)})
    return impls


def refs(impls):
    out = set()
    for im in impls:
        txt = json.dumps([im.get("cases"), im.get("sets"), im.get("lets")], ensure_ascii=False)
        for m in CALLTOK.finditer(txt):
            out.add(f"{m.group(1)}.{m.group(2)}")
    return out


def main():
    load_impls()
    uses = collections.defaultdict(set)
    for r in csv.DictReader(open(os.path.join(OUT, "unresolved.csv"), encoding="utf-8-sig")):
        if r["kind"] == "callee": uses[r["symbol"]].add(int(r["uid"]))
    cons = json.load(open(os.path.join(il2.WORK, "skill_consumers.json"), encoding="utf-8"))
    ui = re.compile(r"^(UI|Ui)|Manager\$\$(Initialize|Setup|Refresh|Update)List|SkillTreeList|ExSkillList")
    for u, lst in cons.items():
        for c in lst:
            if not ui.search(c["fn"]): uses[c["fn"].replace("$$", ".")].add(int(u))
    refp = os.environ.get("SKILL_REF", os.path.join(OUT, "skill_reference.json"))
    for r in json.load(open(refp, encoding="utf-8")):
        found = set()
        def scan(o):
            if isinstance(o, str):
                for m in CALLTOK.finditer(tidy(o)): found.add(f"{m.group(1)}.{m.group(2)}")
            elif isinstance(o, dict):
                for v in o.values(): scan(v)
            elif isinstance(o, list):
                for v in o: scan(v)
        for key in ("methods", "buffs", "mastery"):
            if key in r: scan(r[key])
        for sym in found: uses[sym].add(r["uid"])
    roots = set(uses)
    for iface in ("IPlayerStatusCalculator", "IMobStatusCalculator"):
        for m in D2.C[iface]["imethods"]: roots.add(f"{iface}.{m}")
    for n in ROOT_NAMES: roots.add(n.replace("$$", "."))
    res = {}
    todo = sorted(roots)
    for rnd in range(4):
        nxt = set()
        for sym in todo:
            if sym in res: continue
            res[sym] = {"used_by": sorted(uses.get(sym, ())), "impls": decode_symbol(sym), "round": rnd}
            for ref in refs(res[sym]["impls"]):
                cls = ref.rpartition(".")[0]
                if ref not in res and ENGINE_CLS.match(cls): nxt.add(ref)
        print(f"round {rnd}: decoded {len(todo)}, next {len(nxt)}", flush=True)
        todo = sorted(nxt)
        if not todo: break
    json.dump(res, open(os.path.join(OUT, "variables_raw.json"), "w", encoding="utf-8"), ensure_ascii=False)
    n_dec = sum(1 for v in res.values() if v["impls"])
    print(len(res), "symbols,", n_dec, "with client code,", len(res) - n_dec, "leaf/no code")


if __name__ == "__main__":
    main()
