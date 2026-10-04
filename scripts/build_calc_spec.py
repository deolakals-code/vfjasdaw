"""Per-skill calculation spec for a damage calculator: skills/damage/calc_spec/<uid>.json + calc_spec_index.json.
usage (cwd D:\\toram_re): python build_calc_spec.py   (after build_reference / build_glossary)

Spec = everything a calculator needs for one skill, in one machine-readable file:
  fields   : values the skill sets (multipliers, flat damage, ranges, MP, counts ...) with Lv1..10 tables where the formula depends on Lv only
  terms    : damage-template terms (step, op, formula, condition) grouped by calc method -- these are the numbers the shared engine multiplies
  effects  : buffs applied / removed, ailment rolls, other calls the method makes, each with its condition
  buffs    : buff classes (duration, parameter table, counter state, constructor arguments)
  passives : mastery bonuses
  hooks    : other client functions that read this skill (definition lives in variables.json)
  variables: ids of the glossary entries used (see variables.json)
Formulas keep the decoder notation; `simplified` folds compiler idioms (x//2, min/max); condition words lt/gt/le/ge/eq/ne are comparisons.
"""
import os, re, json, collections, sys
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from spec_tidy import tidy
from refutil import pretty
import exprsimp

OUT = r"D:\toram reverse data\skills\damage"
SPEC = os.path.join(OUT, "calc_spec")
CALLTOK = re.compile(r"(?<![\w.])([A-Za-z_][\w`<>]*(?:\.[A-Za-z_][\w`<>]*)*)\.([A-Za-z_]\w*)\(")
ENUMTOK = re.compile(r"\b(BonusType|SkillBufferId|SkillId|AbnormalType|ElementType|SkillAttackType|MasteryId|GemCartBufferId|CalcStep|ItemType|SkillTreeType)\.(\w+)")
RESID = re.compile(r"(?<![\w?])\?[a-z]\w*|\+0x[0-9a-f]+\]|\bmeta\(|\b0x165d\w+\(|stkp\(")
STATREF = re.compile(r"\b(status|target|base)\.(\w+)")


def fx(text):
    """decoder text -> (display formula, simplified formula, defs)"""
    t = tidy(str(text))
    p = pretty(t)
    try:
        simp, defs = exprsimp.simplify(p)
    except Exception:
        simp, defs = p, []
    return p, simp, defs


def variables_in(text, V):
    out = set()
    t = tidy(str(text))
    for m in CALLTOK.finditer(t):
        k = f"{m.group(1)}.{m.group(2)}"
        if k in V: out.add(k)
    for m in ENUMTOK.finditer(t):
        k = f"{m.group(1)}.{m.group(2)}"
        if k in V: out.add(k)
    for m in STATREF.finditer(pretty(t)):
        out.add(f"{m.group(1)}.{m.group(2)}")
    return out


def item_entry(it, method, V, used):
    text = it.get("text", "")
    p, simp, defs = fx(text)
    when = tidy(str(it.get("when", "always")))
    ent = {"method": method, "kind": it["kind"], "name": it.get("name"), "formula": p, "simplified": simp, "when": when}
    if defs: ent["defs"] = defs
    if it.get("by_level") is not None: ent["by_level"] = it["by_level"]
    if it["kind"] == "tpl":
        m = re.match(r"(\w+)\[(\w+)\]", it.get("name", ""))
        if m: ent["op"], ent["step"] = m.group(1), m.group(2)
    vs = variables_in(text, V) | variables_in(when, V)
    if vs:
        ent["vars"] = sorted(vs); used |= vs
    res = RESID.findall(p + " " + when)
    if res: ent["residual"] = res[:5]
    return ent


BIG = {0, 17, 733}      # recipes of these three classes explode (path counts); their methods are taken from the merged-path decode in variables.json


def from_glossary(cls, V, used):
    fields, terms, effects = [], [], []
    for sym, e in V.items():
        if not sym.startswith(cls + ".") or "." in sym[len(cls) + 1:]: continue
        meth = sym[len(cls) + 1:]
        for im in e.get("impls", []):
            for ev in im.get("events", []):
                when = " AND ".join(ev["when"]) or "always"
                p, simp, defs = fx(ev["value"])
                ent = {"method": meth, "kind": ev["kind"], "name": ev["name"], "formula": p, "simplified": simp, "when": when}
                if ev["kind"] == "tpl":
                    m = re.match(r"(\w+)\[(\w+)\]", ev["name"])
                    if m: ent["op"], ent["step"] = m.group(1), m.group(2)
                    terms.append(ent)
                elif ev["kind"] == "call": effects.append(ent)
                else: fields.append(ent)
                vs = variables_in(ev["value"], V) | variables_in(when, V)
                if vs: ent["vars"] = sorted(vs); used |= vs
                res = RESID.findall(p + " " + when)
                if res: ent["residual"] = res[:5]
            for k, x in im.get("lets", {}).items():
                used |= variables_in(x, V)
    return fields, terms, effects


def buff_entry(bc, b, V, used):
    ent = {"class": bc, "ctors": [], "params": [], "state": {}, "hooks": b.get("hooks", [])}
    for c in b.get("ctors", []):
        e = {"sig": c.get("sig"), "fields": {}}
        for fk, vs in (c.get("fields_resolved") or c.get("fields") or {}).items():
            e["fields"][fk] = [{"formula": pretty(tidy(v["expr"])), "when": v.get("when"), "by_level": v.get("by_level")} for v in vs]
        if c.get("base_ctor"): e["base_ctor"] = c["base_ctor"]
        ent["ctors"].append(e)
    for g in b.get("get_param", []):
        p, simp, _ = fx(g["value"])
        ent["params"].append({"id": g.get("bonus"), "bonus_id": g.get("bonus_id"), "formula": p, "simplified": simp,
                              "when": [tidy(w) for w in g.get("when", [])]})
        used.add(f"SkillBufferId.{g.get('bonus')}")
    muts = collections.defaultdict(list)
    for mname, its in b.get("other", {}).items():
        for it in its:
            if it.get("kind") == "set":
                muts[it["name"]].append({"method": mname, "formula": pretty(tidy(it["text"])), "when": it.get("when")})
    ent["state"] = dict(muts)
    if b.get("child_args"): ent["child_args"] = b["child_args"]
    if b.get("attached_via"): ent["attached_via"] = b["attached_via"]
    ent["kind"] = "counter" if any(g.get("bonus") == "Count" for g in b.get("get_param", [])) and muts else ("timed" if any(c.get("fields", {}).get("LeftTime") for c in b.get("ctors", [])) else "flag/param")
    return ent


def main():
    ref = json.load(open(os.path.join(OUT, "skill_reference.json"), encoding="utf-8"))
    G = json.load(open(os.path.join(OUT, "variables.json"), encoding="utf-8"))
    SV = json.load(open(os.path.join(OUT, "skill_variables.json"), encoding="utf-8"))
    V = G["vars"]
    os.makedirs(SPEC, exist_ok=True)
    index = []
    for r in ref:
        uid = r["uid"]
        used = set(SV.get(str(uid), {}).get("vars", []))
        fields, terms, effects = [], [], []
        for mname, m in (r.get("methods") or {}).items():
            for it in m.get("items", []):
                e = item_entry(it, mname, V, used)
                (terms if it["kind"] == "tpl" else effects if it["kind"] == "call" else fields).append(e)
        if uid in BIG and (r.get("class") or r.get("mastery_class")):
            fields, terms, effects = from_glossary(r.get("class") or r.get("mastery_class"), V, used)
        spec = {"version": 1, "uid": uid, "name_th": r.get("name_th"), "name_en": r.get("name_en"), "tree": r.get("tree_type"), "category": r.get("category"),
                "max_level": r.get("max_level"), "roles": r.get("roles", []), "class": r.get("class") or r.get("mastery_class"),
                "proration": r.get("proration"), "eq_limit": r.get("eq_limit"),
                "fields": fields, "terms": terms, "effects": effects,
                "buffs": [buff_entry(bc, b, V, used) for bc, b in (r.get("buffs") or {}).items()],
                "passives": r.get("mastery"), "hooks": SV.get(str(uid), {}).get("hooks", [])}
        spec["variables"] = sorted(used)
        resid = [x for sec in ("fields", "terms", "effects") for x in spec[sec] if x.get("residual")]
        spec["residual"] = [{"where": f"{x['method']}:{x.get('name')}", "tokens": x["residual"]} for x in resid]
        json.dump(spec, open(os.path.join(SPEC, f"{uid}.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
        index.append({"uid": uid, "name_en": r.get("name_en"), "class": spec["class"], "fields": len(fields), "terms": len(terms), "effects": len(effects),
                      "buffs": len(spec["buffs"]), "hooks": len(spec["hooks"]), "variables": len(spec["variables"]), "residual": len(spec["residual"])})
    json.dump(index, open(os.path.join(OUT, "calc_spec_index.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=0)
    n_res = sum(1 for x in index if x["residual"])
    print(len(index), "specs;", sum(x["terms"] for x in index), "terms;", sum(x["fields"] for x in index), "fields;", n_res, "skills with residual markers")


if __name__ == "__main__":
    main()
