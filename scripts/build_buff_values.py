"""Buff numbers, followed to the end: where every buff parameter and every buff duration of every skill actually comes from.

The overview (build_overview.py) evaluates a buff parameter only when its formula is a function of the skill level. The rest were left
as the name of a constructor field (`criticalDamage`, `eqAtkRate`, `time`). Those names are filled in by the code that creates the buff:

  * the buff class constructor stores its arguments and computes fields from them (class and base class, e.g. CircleBufferBase.LeftTime);
  * the skill's own action, or another class that hands out the buff, passes the arguments:  XBuf..ctor(Lv, WeaponType),
    AddSelfBuffer(id, lv, time, val, localId)   (call sites live in skill_reference.json methods and variables.json skill hooks).

This script substitutes those definitions into each formula (class fields, base class, call-site arguments, one level of decoded helper
functions) and then decides, for every (skill, buff class, parameter) and for every buff duration:

  table     a function of the skill level only                        -> values Lv1..10
  cases     the same, but one extra argument picks the table          -> one table per case (caster's weapon type, a flag)
  formula   needs the caster's stats / equipment / the skill's state  -> the expanded formula with every variable explained
  none      (durations) no timer anywhere in the buff's code chain     -> the buff ends by an event, not by time
  open      nothing found; listed with the reason (never silently dropped)

Reads  skills/damage/{skill_reference.json, variables.json, skill_variables.json}.   Writes skills/damage/buff_values.json + BUFF_VALUES.md.
Run:   cd D:\\toram_re && python "D:\\toram reverse data\\scripts\\build_buff_values.py"        (a few seconds; --selftest asserts known cases)
Labels: everything here is Code (decoded from libil2cpp.so) except the lines marked Inferred.
"""
import os, re, sys, json, itertools, collections

HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
sys.path.insert(0, HERE)
import calc_engine as CE
import build_overview as BO

BASE = BO.BASE
OUT_JSON = os.path.join(BASE, "buff_values.json")
OUT_MD = os.path.join(BASE, "BUFF_VALUES.md")
LVS = list(range(1, 11))
NAME = re.compile(r"(?<![\w.])[A-Za-z_]\w*")
DOTTED = re.compile(r"[A-Za-z_]\w*(?:\.[A-Za-z_]\w*)*(?:\[\d+\])?")
SCALAR = {"byte", "int", "float", "bool", "short", "sbyte", "uint", "ushort", "long"}
KEYWORDS = {"int", "min", "max", "abs", "eq", "ne", "lt", "gt", "le", "ge", "hi", "ls", "lo", "hs", "mi", "pl", "AND", "OR", "new", "this"}
WEAPON_ARGS = {"val", "equip", "weaponType"}
FLAG = re.compile(r"^(is|has)[A-Z]")
OTHER_WEAPON = 99
MAX_ALTS = 12

D = BO.Data()
ITEM = BO.ITEMTYPE   # id -> ItemType name
BONUS = {k.split(".", 1)[1]: v.get("gloss_th") for k, v in D.vars.items() if v["kind"] == "bonus_type"}
STAT_NAME = {"Str": "STR", "Int": "INT", "Vit": "VIT", "Agi": "AGI", "Dex": "DEX", "Crt": "CRT", "Luk": "LUK", "Men": "MEN", "Tec": "TEC"}


# ------------------------------------------------------------------ buff class registry (class -> richest decoded entry)
REG = {}
def _size(b): return sum(len(c.get("fields", {})) for c in b.get("ctors", []))
for ref in D.ref.values():
    for cls, b in (ref.get("buffs") or {}).items():
        if cls not in REG or _size(b) > _size(REG[cls]): REG[cls] = b


def ctor_of(cls, nargs=None):
    ctors = (REG.get(cls) or {}).get("ctors") or []
    if nargs is not None:
        for c in ctors:
            if len(sig_names(c)) == nargs: return c
    return ctors[0] if ctors else None


def sig_names(ctor):
    return [s.strip().split()[-1] for s in (ctor.get("sig") or "").split(",") if s.strip()]


def sig_types(ctor):
    return {s.strip().split()[-1]: s.strip().split()[0] for s in (ctor.get("sig") or "").split(",") if s.strip()}


# ------------------------------------------------------------------ text helpers
MAIN_WEAPON = re.compile(r"EquipItemData\.WeaponTypeCalculatorBase\.get_WeaponType\((?:[^()]|\([^()]*\))*\)")


RAW_MAIN_TYPE = re.compile(r"\[WeaponTypeCalculatorBase\.item\+0x38\]")      # ItemType field of the equipped main weapon (dump.cs: item type at +0x38)
EQUIP_PROBE = "System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(equipItem, "


ITEM_TYPE_GETTER = re.compile(r"EquipItemData\.get_(Sub)?WeaponItemType\(PlayerStatusBase\.get_EquipItemData\(\)\)|EquipItemData\.get_(Sub)?Weapon\(PlayerStatusBase\.get_EquipItemData\(\)\)\.Type|\b(sub)Weapon\.Type")


def norm_equip(text):
    """`((TryGetValue(equipItem, N, out) & 1) ne 0 ? equipItem[N] : 0)).Type` is the type of the item in equipment slot N: 1 main weapon, 2 sub weapon
    (Inferred from the types compared with: Magictool and Shield). Replaced with a name so the type becomes a selector."""
    while True:
        i = text.find(EQUIP_PROBE)
        if i < 0 or i < 2: return text
        slot = text[i + len(EQUIP_PROBE)]
        end = text.find(f"equipItem[{slot}] : 0", i)
        if end < 0: return text
        k = end + len(f"equipItem[{slot}] : 0")
        m = re.match(r"\)*\.Type", text[k:])
        if not m or text[i - 2:i] != "((" or k >= len(text) or text[k] != ")":
            return text.replace(EQUIP_PROBE, "equipItemProbe(", 1)          # an unknown shape: leave it recognisable and stop rewriting
        closes = m.group(0).count(")")
        start = i - 2 - (closes - 1)
        if start < 0 or text[start:i - 2] != "(" * (closes - 1): return text.replace(EQUIP_PROBE, "equipItemProbe(", 1)
        text = text[:start] + ("WeaponType" if slot == "1" else "SubWeaponType") + text[k + m.end():]


def norm(text):
    """the caster's equipment is written many ways in the call sites and formulas; one name per selector"""
    text = ITEM_TYPE_GETTER.sub(lambda m: "SubWeaponType" if (m.group(1) or m.group(2) or m.group(3)) else "WeaponType", text)
    return norm_equip(RAW_MAIN_TYPE.sub("WeaponType", MAIN_WEAPON.sub("WeaponType", text)))


def split_args(s):
    out, d, cur = [], 0, ""
    for ch in s:
        if ch in "([<{": d += 1
        if ch in ")]>}": d -= 1
        if ch == "," and d == 0: out.append(cur.strip()); cur = ""
        else: cur += ch
    if cur.strip() or out: out.append(cur.strip())
    return out


def inside(text):
    a, b = text.find("("), text.rfind(")")
    return text[a + 1:b] if a >= 0 and b > a else ""


NOISE = re.compile(r"IsInstanceOf|op_Inequality|op_Equality|IsBlank|TryGetValue|TryGetBuf|IsInheritance|MobaMode|get_IsLocalDead|CheckSkillParamFlag|"
                   r"\?x\d|\?mvn|\?ubfx|\?sbfx|\?v\d|\+0x[0-9a-f]+\]|Enumerable|Func<|SkillBufferManager|get_gameObject|IsSelfAction ne 0 AND IsSelfAction")


def clean_when(w):
    """drop the decoder's plumbing from a condition (instance checks, null checks, dictionary lookups); what is left says which case applies"""
    if w in (None, "", "always"): return "always"
    groups = []
    for g in w.split(" OR "):
        atoms = [a for a in g.split(" AND ") if not NOISE.search(a)]
        groups.append(" AND ".join(atoms))
    if any(g == "" for g in groups): return "always"
    return " OR ".join(dict.fromkeys(groups))


AT_METHOD = re.compile(r"^@(\w+)")       # a definition made inside a buff method: "@ActiveFinishingTouch"


def cond_expr(w):
    """spec condition text ('A AND B OR C') -> one expression"""
    if w in (None, "", "always"): return "1"
    return " || ".join("(" + " && ".join(f"({AT_METHOD.sub(r'__in_\1', a)})" for a in g.split(" AND ")) + ")" for g in w.split(" OR "))


def sub(text, mapping):
    """replace whole identifiers (not `x.name`, not `name(`... ) by a parenthesised expression"""
    for n, e in mapping.items():
        text = re.sub(rf"(?<![\w.]){re.escape(n)}(?![\w\[(])", lambda m, e=e: f"({e})", text)
    return text


def idents(text):
    return [n for n in dict.fromkeys(NAME.findall(text)) if n not in KEYWORDS]


# ------------------------------------------------------------------ definitions: class fields, base class, call sites
class Chain:
    """the constructor chain of one buff class: field definitions (derived first, then base classes with their parameters bound)"""

    def __init__(self, cls, nargs=None):
        self.cls = cls
        self.levels = []          # (ctor, bind) ; bind maps this level's parameter names to expressions in the derived class' terms
        self.names = []           # class name of each level
        ctor = ctor_of(cls, nargs)
        bind = {}
        seen = set()
        c = cls
        while ctor and c not in seen:
            seen.add(c)
            self.names.append(c)
            self.levels.append((ctor, dict(bind)))
            bc = ctor.get("base_ctor")
            if not bc: break
            base_ctor = ctor_of(bc["class"], len(bc.get("args", [])))
            names = bc.get("params") or (sig_names(base_ctor) if base_ctor else [])
            # expressions of the next level are written in its own parameter names; map them to this level's argument text
            nb = {}
            for pn, ae in zip(names, bc.get("args", [])): nb[pn] = sub(ae, bind) if bind else ae
            bind, ctor, c = nb, base_ctor, bc["class"]
        self.args = sig_names(self.levels[0][0]) if self.levels else []
        self.types = sig_types(self.levels[0][0]) if self.levels else {}

    def defs(self, name):
        """[(expr, when)] for a field, searching derived then base levels; base expressions are rewritten in derived terms"""
        out = []
        for i, (ctor, bind) in enumerate(self.levels):
            ents = [e for e in (ctor.get("fields") or {}).get(name, []) if e.get("expr") is not None and e["expr"] != name]
            if ents:
                out = [(sub(e["expr"], bind) if bind else e["expr"], sub(e.get("when") or "always", bind) if bind else (e.get("when") or "always")) for e in ents]
                break
        # assignments inside the buff's own methods (Active..., OnDamage ...) that do not just count on the old value: each is an
        # alternative that applies while that method has run ("@Method"); a field the constructor never sets is defined only by these
        for cls in ([] if name in STATE else self.names):          # LeftTime / Count change every tick or hit: state, not definitions
            for m, items in ((REG.get(cls) or {}).get("other") or {}).items():
                for it in items:
                    if it.get("kind") != "set" or it.get("name") != name: continue
                    if re.search(rf"(?<![\w.]){re.escape(name)}(?![\w\[(])", it["text"]): continue
                    w = it.get("when") or "always"
                    out.append((it["text"], f"@{m}" + ("" if w == "always" else f" AND {w}")))
        return out


def call_sites(uid, cls):
    """calls that create or add this buff: own action methods and the hooks (other classes) that read the skill"""
    r = D.ref[uid]
    name = r.get("name_en")
    out = []

    def add(where, nm, args, when):
        short = re.split(r"\$\$|\.", nm)[-1] if nm else ""
        if short in ("AddSelfBuffer", "AddBuffer"):
            a = args[1:] if args and "Manager" in args[0] else args
            first = a[0] if a else ""
            if first in (str(uid), f"SkillId.{name}"):
                out.append({"where": where, "kind": "id", "lv": a[1] if len(a) > 1 else None, "time": a[2] if len(a) > 2 else None,
                            "val": a[3] if len(a) > 3 else None, "n": len(a), "when": when})
            elif first == f"new {cls}": out.append({"where": where, "kind": "object", "when": when})
        elif nm.startswith(f"{cls}..ctor") or nm == f"{cls}$$.ctor":
            out.append({"where": where, "kind": "ctor", "args": args, "when": when})

    for m, mv in (r.get("methods") or {}).items():
        for it in mv.get("items", []):
            if it.get("kind") == "call": add(f"own:{m}", it["name"], split_args(inside(it["text"])), it.get("when") or "always")
    for h in HOOKS.get(uid, {}).get("hooks", []):
        for im in (D.vars.get(h) or {}).get("impls", []):
            for ev in im.get("events", []):
                if ev.get("kind") == "call": add(f"hook:{h}", ev["name"], split_args(ev["value"]), " AND ".join(ev.get("when") or []) or "always")
    return out


HOOKS = BO.jload(os.path.join(BASE, "skill_variables.json"))
HOOKS = {int(k): v for k, v in HOOKS.items()}


# ------------------------------------------------------------------ expansion of a formula into definitions
STATE = {"Count", "LeftTime"}          # runtime state, never a definition
LOCAL_ID = re.compile(r"^(Id|localId|id)$")


class Resolver:
    def __init__(self, uid, cls):
        self.uid, self.cls = uid, cls
        self.sites = call_sites(uid, cls)
        ar = collections.Counter(len(s["args"]) for s in self.sites if s["kind"] == "ctor")
        self.chain = Chain(cls, ar.most_common(1)[0][0] if ar else None)
        self.argsrc = collections.defaultdict(list)       # argument name -> [(expr, when, where)]
        for s in self.sites:
            if s["kind"] == "ctor":
                for n, e in zip(self.chain.args, s["args"]): self.argsrc[n].append((e, s["when"], s["where"]))
            elif s["kind"] == "id":
                # AddSelfBuffer(id, lv, time, val, localId): with three arguments the third is the local id, except when it is an expression
                for n, e in (("lv", s["lv"]), ("time", s["time"]), ("val", s["val"])):
                    if e is None or (n == "time" and LOCAL_ID.match(e) and s["n"] <= 4): continue
                    self.argsrc[n].append((e, s["when"], s["where"]))

    def stack_cap(self):
        """the stack limit CountBufferBase is built with (a number, else 5), at most 10 tables"""
        for ctor, bind in self.chain.levels:
            bc = ctor.get("base_ctor")
            if bc and bc.get("class") == "CountBufferBase" and len(bc.get("args", [])) >= 3:
                m = re.fullmatch(r"\(*(\d+)\)*", sub(bc["args"][2], bind).strip())
                if m: return max(1, min(10, int(m.group(1))))
        return 5

    def definitions(self, n):
        """[(expr, when)] that give a name its value: constructor fields (class, base), else what the callers pass for a scalar argument"""
        if n in STATE and n != "LeftTime": return []
        d = self.chain.defs(n)
        if d: return [(norm(e), clean_when(norm(w))) for e, w in d]
        if n in self.chain.args and self.chain.types.get(n) in SCALAR:
            seen, out = set(), []
            for e, w, _ in self.argsrc.get(n, []):
                k = (norm(e), clean_when(norm(w)))
                if k not in seen: seen.add(k); out.append(k)
            return out
        return []

    def expand(self, text, conds=(), depth=0, skip=frozenset()):
        """-> [(expression, [condition expressions])]: every field and argument substituted by what defines it"""
        text = norm(text)
        for n in idents(text):
            if n in ("Lv", "lv") or n in skip or n in STATE: continue
            alts = self.definitions(n)
            alts = [(e, w) for e, w in alts if not re.search(rf"(?<![\w.]){re.escape(n)}(?![\w\[(])", e)]       # a modifier of itself is state, not a definition
            if not alts or depth >= 8: continue
            out = []
            for e, w in alts[:MAX_ALTS]:
                t = re.sub(rf"(?<![\w.]){re.escape(n)}(?![\w\[(])", lambda m, e=e: f"({e})", text)
                nc = conds if w == "always" else conds + (cond_expr(w),)
                out += self.expand(t, nc, depth + 1, skip)
            return out[:MAX_ALTS]
        return [(text, list(conds))]


# ------------------------------------------------------------------ evaluation: Lv 1..10 and the caller-chosen selector
def evaluator(env):
    return CE.Evaluator(env=dict(env))


def free_names(text):
    return [n for n in idents(text) if n not in ("Lv", "lv")]


FIXED = {"isSkillEnd": 0, "BuffEffectActive": 1, "true": 1, "false": 0}      # the buff is running, so it is not at its end


def only_compared(alts, n):
    """every use of the name is `name eq K` / `name ne K` (optionally masked), so only its equality with constants matters"""
    pat = re.compile(rf"(?<![\w.]){re.escape(n)}(?![\w.])[\s()&\d]{{0,24}}?\b(?:eq|ne)\s+-?\d+")
    mirror = re.compile(rf"\b(?:eq|ne)\s+\(?\s*-?\d+\s*\)?\s*[\s()]*{re.escape(n)}\b")
    used = False
    for expr, conds in alts:
        for t in [expr, *conds]:
            t2 = mirror.sub("0", pat.sub("0", t))
            if re.search(rf"(?<![\w.]){re.escape(n)}(?![\w.])", t2): return False
            used = used or t2 != t
    return used


def kind_of(r, n, alts_hint=()):
    """what a free name is: 'weapon' (the caster's weapon type), 'flag' (yes/no the caller or the state decides) or None (not enumerable)"""
    if n in ("WeaponType", "SubWeaponType"): return "weapon"
    if n == "Count": return "stack"                 # how many stacks the buff has: one table per stack count up to the cap
    if n in WEAPON_ARGS and n in r.chain.args and (n == "weaponType" or any("WeaponType" in str(s.get("args", "")) for s in r.sites if s["kind"] == "ctor")):
        return "weapon"
    if FLAG.match(n) or n in ("self", "IsSelfAction"): return "flag"
    if n in r.chain.args and r.chain.types.get(n) == "bool": return "flag"
    # a scalar argument the formula only ever compares with constants (`value = 1 ? 25 : 0`) picks a case; one used in arithmetic does not
    if n in r.chain.args and r.chain.types.get(n) in SCALAR and only_compared(alts_hint, n): return "arg"
    # an argument that a flag-named field stores (`isSupportSpecialty = value`)
    if n in r.chain.args:
        for f in (r.chain.levels[0][0].get("fields") or {}):
            if FLAG.match(f) and any(e[0].strip("() ") == n for e in r.chain.defs(f)): return "flag"
    return None


def free_in(alts):
    free = set()
    for expr, conds in alts:
        for t in [expr, *conds]: free.update(free_names(t))
    return {n for n in free if n not in FIXED}


def compared(alts, names):
    out = set()
    for expr, conds in alts:
        for t in [expr, *conds]:
            for nm in names:
                # `name eq 11`, `(name) eq 11`, `((name) & 255) eq 10` and the mirrored `11 eq name`
                for m in re.finditer(rf"(?<![\w.]){re.escape(nm)}(?![\w.])[\s()&\d]{{0,24}}?\b(?:eq|ne)\s+(-?\d+)", t): out.add(int(m.group(1)))
                for m in re.finditer(rf"\b(?:eq|ne)\s+\(?\s*(-?\d+)\s*\)?\s*[\s()]*{re.escape(nm)}\b", t): out.add(int(m.group(1)))
    return out


def try_table(alts, env_extra):
    """Lv 1..10 table for one assignment of the selectors, or None. Exactly one alternative must apply at every level."""
    row = []
    for L in LVS:
        env = {"Lv": L, "lv": L, **FIXED, **env_extra}
        vals = []
        for expr, conds in alts:
            try:
                ev = evaluator(env)
                if all(ev.eval(cx) for cx in conds): vals.append(ev.eval(expr))
            except Exception:
                return None
        if len(vals) != 1: return None
        v = vals[0]
        if isinstance(v, bool): v = int(v)
        if not isinstance(v, (int, float)): return None
        row.append(round(v, 4) if isinstance(v, float) else v)
    return row


def tabulate(r, alts):
    """-> ('table'|'cases', {...}) or (None, reason). Selectors: the caster's weapon type and yes/no flags; anything else free is not a table."""
    free = free_in(alts)
    kinds = {n: kind_of(r, n, alts) for n in free}
    bad = sorted(n for n, k in kinds.items() if k is None)
    if bad: return None, "needs:" + ",".join(bad[:6])
    sels = sorted(free)
    if not sels:
        row = try_table(alts, {})
        return ("table", {"v": row}) if row else (None, "no-single-alternative")
    if len(sels) > 3: return None, "too-many-selectors"
    cand = {}
    for n in sels:
        if kinds[n] == "flag": cand[n] = [0, 1]
        elif kinds[n] == "stack": cand[n] = list(range(1, r.stack_cap() + 1))
        else: cand[n] = sorted({OTHER_WEAPON, *compared(alts, [n])})
    combos = list(itertools.product(*[cand[n] for n in sels]))
    if len(combos) > 64: return None, "too-many-cases"
    base = tuple((0 if kinds[n] == "flag" else 1 if kinds[n] == "stack" else OTHER_WEAPON) for n in sels)
    tables = {c: try_table(alts, dict(zip(sels, c))) for c in combos}
    if all(t is None for t in tables.values()): return None, "no-case-resolves"
    groups = collections.OrderedDict()
    for c, row in tables.items(): groups.setdefault(json.dumps(row), []).append(c)
    v = tables[base]

    def entry(n, val):
        e = {"sel": n, "kind": kinds[n], "value": val}
        if kinds[n] == "weapon": e["name"] = "Hand" if val == 0 else ITEM.get(val)
        if n == "SubWeaponType": e["sub"] = True
        return e

    cases = []
    for key, cs in groups.items():
        if key == json.dumps(v): continue
        case = {"v": json.loads(key), "combos": [[entry(n, val) for n, val in zip(sels, c)] for c in cs]}
        if len(sels) == 1:                      # the single-selector shape the page already reads
            n = sels[0]
            case.update({"kind": kinds[n], "is": [c[0] for c in cs]})
            if kinds[n] == "weapon": case["names"] = [c[0]["name"] for c in case["combos"] if c[0]["name"]]
            else: case["sel"] = n
        cases.append(case)
    out = {"v": v, **({"cases": cases} if cases else {})}
    if v is None or any(c["v"] is None for c in cases): out["partial"] = True
    return ("cases" if cases else "table", out)


# ------------------------------------------------------------------ readable formulas
KEEP_CALL = {"int", "min", "max", "abs"}


def balanced_call(text, start):
    """text[start] is the '(' of a call; -> index after the matching ')'"""
    d = 0
    for i in range(start, len(text)):
        if text[i] == "(": d += 1
        elif text[i] == ")":
            d -= 1
            if d == 0: return i + 1
    return -1


def inline_helpers(text, depth=0):
    """a call to a decoded helper with one unconditional case is replaced by its value (one or two levels), so its inputs show"""
    if depth >= 3: return text
    out, i = "", 0
    for m in re.finditer(r"(?<![\w.])([A-Za-z_][\w.]*(?:<\w+>)?)\(", text):
        if m.start() < i: continue
        name = m.group(1)
        end = balanced_call(text, m.end() - 1)
        v = D.vars.get(name)
        if name in KEEP_CALL or end < 0 or not v or not v.get("impls"): continue
        im = next((x for x in v["impls"] if len(x.get("cases") or []) == 1 and not x["cases"][0].get("common") and not x["cases"][0].get("variants")), None)
        if not im or im.get("returns") in (None, "void"): continue
        args = split_args(text[m.end():end - 1])
        params = [p[1] for p in im.get("params", [])]
        if not im.get("static", False) and len(args) == len(params) + 1: args = args[1:]
        if len(args) != len(params): continue
        val = im["cases"][0]["value"]
        for k, ex in (im.get("lets") or {}).items(): val = re.sub(rf"\b{re.escape(k)}\b", f"({ex})", val)
        val = sub(val, dict(zip(params, args)))
        out += text[i:m.start()] + "(" + inline_helpers(val, depth + 1) + ")"
        i = end
    return out + text[i:]


def human(text):
    t = inline_helpers(text)
    try: t = BO.names_th(D, BO.pretty(t))
    except Exception: pass
    t = re.sub(r"\bstatus\.(Str|Int|Vit|Agi|Dex|Crt|Luk|Men|Tec)\b", lambda m: STAT_NAME[m.group(1)], t)
    t = re.sub(r"SkillManager\.GetSkillLv\(PlayerStatusBase\.get_SkillManager\(\), (\d+), \d+\)", lambda m: f"Lv สกิล {D.sname(int(m.group(1)))}", t)
    t = re.sub(r"GemCartBufferBase\.GetValue\(GemCartBufferManager\.GetGemCartBuffer\(PlayerStatusBase\.get_GemCartBuffManager\(\), (\d+)\), GemCartBufferId\.\w+\)",
               r"โบนัสคริสตัลเจม#\1", t)
    t = re.sub(r"EnhanceSprite\.GetEnhanceParam\(PlayerStatusBase\.get_SkillManager\(\)\.SkillMasteryList\[(\d+)\], \(\d+\)\)", r"โบนัสเสริมจากมาสเตอรี่#\1", t)
    return t


def legend(texts):
    """the variables left in a formula, each with its Thai meaning from the glossary where it has one"""
    out = {}
    for t in texts:
        for m in re.finditer(r"(?<![\w.])([A-Za-z_]\w*(?:\.[A-Za-z_]\w*)*)(?![\w.(])", t):
            n = m.group(1)
            if n in KEYWORDS or n in ("Lv", "lv") or n in out: continue
            g = (D.vars.get(n) or {}).get("gloss_th")
            out[n] = g if g and g != n else BO.STAT_TH.get(n) or BO.EXTRA_TH.get(n)
    return [{"n": n, "th": th} for n, th in list(out.items())[:14]]


# ------------------------------------------------------------------ the machine form: canonical input names the page's calculator fills in
MATH = re.compile(r"System\.Math\.(Max|Min|Abs)\(")
RESIDUAL = re.compile(r"\[|\]|\?[a-z]|\+0x|\)\.[A-Za-z_]|^\s*\+")
STATS9 = ["STR", "INT", "VIT", "AGI", "DEX", "CRT", "LUK", "MEN", "TEC"]
STAT_TOTAL = re.compile(r"\bstatus\.(Str|Int|Vit|Agi|Dex|Crt|Luk|Men|Tec)\b")
STAT_BASE = re.compile(r"\bbase(STR|INT|VIT|AGI|DEX|CRT|LUK|MEN|TEC)\b")
SKILL_LV = re.compile(r"SkillManager\.GetSkillLv\(PlayerStatusBase\.get_SkillManager\(\), (\d+), \d+\)")
REFINE = re.compile(r"ItemData\.get_Refine\(\(?EquipItemData\.get_(Sub)?Weapon\(PlayerStatusBase\.get_EquipItemData\(\)\)\)?\)")
MASTERY = re.compile(r"SkillMasteryBase\.GetMasteryParam\(MasteryId\.(\w+)\)")
BONUS_CALL = re.compile(r"BonusManager\.GetBonusValue\(PlayerStatusBase\.get_BonusManager\(\), BonusType\.(\w+)\)")
PLAYER_LV = re.compile(r"\bstatus\.Lv\b")
DERIVED = re.compile(r"\bstatus\.(Atk|Matk|MaxHp|MaxMp|Hit|Flee|Aspd|Cspd)\b")
BONUS_ID = re.compile(r"BonusManager\.GetBonusValue\(PlayerStatusBase\.get_BonusManager\(\), (\d+)\)")
BONUS_BY_ID = {v["value"]: k.split(".", 1)[1] for k, v in D.vars.items() if v["kind"] == "bonus_type" and isinstance(v.get("value"), int)}
# runtime values the buff keeps or the action computes; the page asks for them as plain numbers
MANUAL = {"damageCount", "reduceValue", "hit", "Refine", "refine", "heal", "resist", "level", "level", "treeLevel", "guitaristSavingTime", "cverlayCount",
          "ParrySuccess", "effective", "normalAtkRate", "avoidStackRegist", "atkMpRecovery", "crtUp", "firstAttackRate"}
INPUT_TH = {"PlayerLv": "เลเวลตัวละคร", "Refine_main": "รีไฟน์อาวุธหลัก", "Refine_sub": "รีไฟน์อาวุธรอง"}


def canon(texts):
    """-> (canonical texts, {input name: {kind, th}}, [names that cannot be an input]). Canonical names are plain identifiers."""
    inputs, out = {}, []
    texts = [MATH.sub(lambda m: m.group(1).lower() + "(", t) for t in texts]

    def reg(name, kind, th=None): inputs.setdefault(name, {"kind": kind, "th": th or INPUT_TH.get(name) or name})
    for t in texts:
        t = STAT_BASE.sub(lambda m: (reg(f"{m.group(1)}_base", "stat", f"{m.group(1)} ที่ลงเอง") or f"{m.group(1)}_base"), t)
        t = STAT_TOTAL.sub(lambda m: (reg(f"{m.group(1).upper()}_total", "stat", f"{m.group(1).upper()} รวม") or f"{m.group(1).upper()}_total"), t)
        t = DERIVED.sub(lambda m: (reg(f"{m.group(1).upper()}_total", "stat", f"{m.group(1)} รวม") or f"{m.group(1).upper()}_total"), t)
        t = BONUS_ID.sub(lambda m: (reg(f"Bonus_{BONUS_BY_ID.get(int(m.group(1)), m.group(1))}", "bonus", BONUS.get(BONUS_BY_ID.get(int(m.group(1)), ""), f"โบนัส {m.group(1)}")) or f"Bonus_{BONUS_BY_ID.get(int(m.group(1)), m.group(1))}"), t)
        t = PLAYER_LV.sub(lambda m: (reg("PlayerLv", "level") or "PlayerLv"), t)
        t = SKILL_LV.sub(lambda m: (reg(f"SkillLv_{m.group(1)}", "skill", f"Lv สกิล {D.sname(int(m.group(1)))}") or f"SkillLv_{m.group(1)}"), t)
        t = REFINE.sub(lambda m: (reg("Refine_sub" if m.group(1) else "Refine_main", "refine") or ("Refine_sub" if m.group(1) else "Refine_main")), t)
        t = MASTERY.sub(lambda m: (reg(f"Mastery_{m.group(1)}", "mastery", f"ค่ามาสเตอรี่ {m.group(1)}") or f"Mastery_{m.group(1)}"), t)
        t = BONUS_CALL.sub(lambda m: (reg(f"Bonus_{m.group(1)}", "bonus", BONUS.get(m.group(1)) or f"โบนัส {m.group(1)}") or f"Bonus_{m.group(1)}"), t)
        out.append(t)
    bad = set()
    for t in out:
        if RESIDUAL.search(t): bad.add("decoder-residual")           # a raw offset / opaque value the decoder could not name
        for n in idents(t):
            if n in ("WeaponType", "SubWeaponType"): reg(n, "weapon", "อาวุธหลัก" if n == "WeaponType" else "อาวุธรอง"); continue
            if n in ("Lv", "lv") or n in inputs or n in FIXED: continue
            if n.startswith("__in_"): bad.add(n); continue
            standalone = re.search(rf"(?<![\w.]){re.escape(n)}(?![\w.(])", t)
            if standalone and (n in FLAG_OK or FLAG.match(n)): reg(n, "flag", n)
            elif standalone: reg(n, "state", f"{n} (ค่าระหว่างเล่น)")          # a number the buff or the action keeps: typed in by the player
            else: bad.add(n)
        for m in re.finditer(r"(?<![\w.])([A-Za-z_]\w*(?:\.[A-Za-z_]\w*)+)", t): bad.add(m.group(1))
    return out, inputs, sorted(bad)


BASE_OK = set()
FLAG_OK = {"self", "IsSelfAction", "isTwinStorm", "isEffective", "isBattleActive"}


def formula_record(alts, extra=None):
    shown = []
    for expr, conds in alts[:6]:
        shown.append({"f": human(expr), "w": [human(c) for c in conds if c != "1"]})
    rec = {"status": "formula", "alts": shown, "vars": legend([human(e) for e, _ in alts[:6]] + [human(c) for _, cs in alts[:6] for c in cs])}
    # machine form, per alternative: the expression must be made only of inputs the page can ask for; a condition that is not (a method that
    # ran, an engine object) is kept as text beside the value instead of blocking it
    calc, inputs, bad_all = [], {}, set()
    for expr, conds in alts[:6]:
        (ce,), ie, bad = canon([expr])
        if bad:
            bad_all.update(bad)
            calc.append(None)
            continue
        w, wt = [], []
        for c in conds:
            (cc,), ic, badc = canon([c])
            if badc: wt.append(human(c))
            else:
                w.append(cc)
                ie.update(ic)
        inputs.update(ie)
        calc.append({"e": ce, "w": w, **({"wt": wt} if wt else {})})
    if any(calc):
        rec["calc"] = {"alts": calc, "inputs": inputs, **({"partial": True} if not all(calc) else {})}
    else:
        rec["unsupported"] = sorted(bad_all)[:8]
    if extra: rec.update(extra)
    return rec


# ------------------------------------------------------------------ per parameter and per timer
BASE_CLASSES = {"SkillBufferDataBase", "CountBufferBase", "NextAttackBufferBase", "CircleBufferBase", "SongBufferBase", "DancerBufferBase", "EquipSkillBufferBase"}
ACTIVE = "BuffEffectActive ne 0"


def param_alts(entries):
    out = []
    for g in entries:
        w = [c for c in (g.get("when") or []) if c != ACTIVE]
        if "BuffEffectActive eq 0" in w: continue
        out.append((g["value"], [cond_expr(" AND ".join(w))] if w else []))
    nonzero = [a for a in out if a[0].strip() not in ("0", "0.0")]
    return nonzero or out[:1]


def resolve_alts(r, raw):
    alts = []
    for expr, conds in raw:
        for e, cs in r.expand(expr, tuple(conds)): alts.append((e, list(cs)))
    return alts[:MAX_ALTS]


def classify(r, raw):
    alts = resolve_alts(r, raw)
    kind, data = tabulate(r, alts)
    if kind: return {"status": kind, **data, "sites": len([s for s in r.sites if s["kind"] != "object"])}
    rec = formula_record(alts, {"why": data})
    rec["sites"] = len([s for s in r.sites if s["kind"] != "object"])
    return rec


def timer_of(r):
    d = r.chain.defs("LeftTime")
    if not d:
        return {"status": "none", "why": "no LeftTime in the class or its base classes (the buff has no timer; it ends by an event)",
                "called": bool([s for s in r.sites if s["kind"] != "ctor"])}
    raw = [(e, [] if w == "always" else [cond_expr(w)]) for e, w in d]
    # LeftTime = time: the buff is told its duration by whoever creates it. A refresh passes the old LeftTime and some calls pass 0
    # (see AddSelfBuffer); the duration of a fresh buff is the other argument.
    if len(d) == 1 and re.fullmatch(r"\(?time\)?", d[0][0].strip()) and "time" in r.chain.args:
        srcs = [(norm(e), w) for e, w, _ in r.argsrc.get("time", [])]
        fresh = [(e, w) for e, w in dict.fromkeys(srcs) if e.strip() != "0" and "LeftTime" not in e]
        lits = [e for e, _ in fresh if re.fullmatch(r"\d+(\.\d+)?", e.strip())]
        if fresh and len(set(lits)) == 1 and len(lits) == len(fresh):          # one number everywhere it is created
            return {"status": "table", "v": [float(lits[0]) if "." in lits[0] else int(lits[0])] * 10, "sites": len(srcs),
                    "note": "passed by the code that creates the buff; calls that pass 0 or the old LeftTime (a refresh) are left out"}
        if fresh:
            rec = classify(r, [(e, [] if cond_expr(clean_when(norm(w))) == "1" else [cond_expr(clean_when(norm(w)))]) for e, w in fresh])
            rec["note"] = "the creator passes the duration; calls that pass 0 or the old LeftTime (refresh) are left out"
            return rec
        if srcs: return {"status": "none", "why": "every call passes 0 or the old LeftTime: the buff has no fresh duration of its own"}
    rec = classify(r, raw)
    if rec["status"] in ("table", "cases") and rec.get("v") and all(x == 0 for x in rec["v"]) and not rec.get("cases"):
        return {"status": "none", "why": "LeftTime is 0 (explicit)"}
    if rec["status"] == "formula" and not r.sites and any(re.search(r"\btime\b", a["f"]) for a in rec["alts"]):
        rec["status"] = "open"
        rec["why"] = "duration is an argument; nothing in the skill's own code or its hooks passes it (the song / dance / circle system does)"
    return rec


def run_all():
    res, cov = {}, collections.Counter()
    open_items = []
    for uid, ref in sorted(D.ref.items()):
        if not ref.get("in_skill_tree"): continue
        for cls, b in (ref.get("buffs") or {}).items():
            if not b.get("get_param") and cls in BASE_CLASSES: continue
            r = Resolver(uid, cls)
            ent = {"timer": timer_of(r) if cls not in BASE_CLASSES else None, "params": {}}
            by = collections.OrderedDict()
            for g in b.get("get_param") or []:
                if ACTIVE in (g.get("when") or []): by.setdefault(g["bonus"], []).append(g)
            for g in b.get("get_param") or []:           # a parameter the class returns without any BuffEffectActive test
                if g["bonus"] not in by: by.setdefault(g["bonus"] + "\0", []).append(g)
            by = collections.OrderedDict((k.rstrip("\0"), v) for k, v in by.items())
            for pid, entries in by.items():
                rec = classify(r, param_alts(entries))
                ent["params"][pid] = rec
                cov[("param", rec["status"])] += 1
                if rec["status"] not in ("table", "cases"): open_items.append((uid, cls, pid, rec["status"], rec.get("why", "")))
            if ent["timer"]: cov[("timer", ent["timer"]["status"])] += 1
            res.setdefault(str(uid), {})[cls] = ent
    return res, cov, open_items


def write_md(cov, open_items):
    L = ["# Buff values, followed to the end", "", "Generated by `scripts/build_buff_values.py`; every number is Code (decoded from `libil2cpp.so`), nothing is checked in game.", "",
         "| what | status | count |", "|---|---|---|"]
    for (k, s), n in sorted(cov.items()): L.append(f"| {k} | {s} | {n} |")
    L += ["", "status: `table` a function of the skill level; `cases` one table per caster weapon / flag; `formula` needs the caster's stats or the skill's state "
          "(expanded, each variable explained); `none` (timer) no timer in the code, the buff ends by an event; `open` nothing found, reason given.", "",
          f"## Not a table ({len(open_items)})", "", "| skill | buff | parameter | status | why |", "|---|---|---|---|---|"]
    for u, c, p, s, w in open_items[:400]: L.append(f"| {u} | {c} | {p} | {s} | {str(w)[:80]} |")
    open(OUT_MD, "w", encoding="utf-8").write("\n".join(L) + "\n")


def main():
    res, cov, open_items = run_all()
    json.dump({"meta": {f"{k}:{s}": n for (k, s), n in sorted(cov.items())}, "skills": res}, open(OUT_JSON, "w", encoding="utf-8"), ensure_ascii=False)
    write_md(cov, open_items)
    for (k, s), n in sorted(cov.items()): print(f"{k:6} {s:9} {n}")


def selftest():
    r = Resolver(43, "WarCryBuf")
    p = classify(r, param_alts([g for g in REG["WarCryBuf"]["get_param"] if g["bonus"] == "AtkUpRate" and ACTIVE in (g.get("when") or [])]))
    assert p["status"] == "cases" and p["v"][0] == 1 and p["cases"][0]["v"][0] == 6 and p["cases"][0]["names"] == ["TwoHandSword"], p
    t = timer_of(r)
    assert t["status"] == "cases" and t["v"][0] == 16 and t["cases"][0]["v"][0] == 66, t
    assert timer_of(Resolver(73, "SnipingBuf"))["status"] == "none"
    g = timer_of(Resolver(1158, "GodHandBuf"))
    print("selftest ok", json.dumps(g, ensure_ascii=False)[:300])


def golden(path, n=80):
    """Reference answers for the website's calculator: the stored machine form evaluated by this project's own evaluator (calc_engine.Evaluator)
    on fixed pseudo-random inputs. The website's JS evaluator must reproduce every number (test/skill-calc.mjs)."""
    import random
    rnd = random.Random(7)
    data = BO.jload(OUT_JSON)["skills"]
    pool = []
    for uid, classes in data.items():
        for cls, ent in classes.items():
            for pid, rec in ent["params"].items():
                if rec.get("status") == "formula" and rec.get("calc"):
                    for ai, alt in enumerate(rec["calc"]["alts"]):
                        if alt: pool.append((int(uid), cls, pid, ai, alt, rec["calc"]["inputs"]))
    rnd.shuffle(pool)
    cases = []
    for uid, cls, pid, ai, alt, inputs in pool:
        if len(cases) >= n: break
        given = {name: rnd.randint(1, 300) if spec["kind"] in ("stat", "state", "bonus", "refine", "mastery", "skill", "level") else rnd.choice([0, 1])
                 for name, spec in inputs.items()}
        for name in list(given):
            if name.endswith("_total") and rnd.random() < 0.5: del given[name]
        full = dict(given)
        for name in inputs:                                   # the server's defaults when a value is not given
            if name in full: continue
            if re.fullmatch(r"[A-Z]{3}_total", name): full[name] = given.get(name.replace("_total", "_base"), 0)
            elif re.fullmatch(r"[A-Z]{3}_base", name): full[name] = 0
        if any(name not in full for name in inputs): continue
        values, ok = [], True
        for L in LVS:
            ev = evaluator({"Lv": L, "lv": L, **FIXED, **full, "WeaponType": OTHER_WEAPON, "SubWeaponType": OTHER_WEAPON})
            try:
                values.append(ev.eval(alt["e"]) if all(ev.eval(w) for w in alt["w"]) else None)
            except Exception:
                ok = False
                break
        if ok: cases.append({"uid": uid, "cls": cls, "id": pid, "alt": ai, "inputs": given, "v": [None if x is None else round(float(x), 4) for x in values]})
    json.dump({"cases": cases}, open(path, "w", encoding="utf-8"), ensure_ascii=False)
    print("golden cases", len(cases), "->", path)


if __name__ == "__main__":
    if "--selftest" in sys.argv: selftest()
    elif "--golden" in sys.argv: golden(sys.argv[sys.argv.index("--golden") + 1])
    else: main()
