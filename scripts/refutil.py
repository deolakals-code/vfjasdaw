"""Helpers for turning symbolic-execution strings into readable formulas."""
import re, csv, math

META = r"D:\toram reverse data\metadata\constants.tsv"
ENUM = {}
for r in csv.DictReader(open(META, encoding="utf-8-sig"), delimiter="\t"):
    try:
        ENUM.setdefault(r["type"], {})[int(r["value"])] = r["field"]
    except (ValueError, KeyError):
        pass


def en(t, v):
    d = ENUM.get(t, {})
    try:
        return d.get(int(v), str(v))
    except (ValueError, TypeError):
        return str(v)


SBID, BONUS, ITEMTYPE, ABN, ELEM, GEM = (ENUM.get(k, {}) for k in (
    "SkillBufferId", "Toram.Common.Bonus.BonusType", "ItemDBData/ItemType", "AbnormalType", "ElementType", "GemCartBufferId"))
STEPN = ENUM.get("SkillCalcTemplate/CalcStep", {})

RECV = r"(?:\?blr|[\w.]+\((?:[^()]|\((?:[^()]|\([^()]*\))*\))*\)(?:\.\w+)*|[\w.]+)"   # receiver: `?blr` (old decoder), a call with nested parens, or a name
PRIM = {"str": "baseSTR", "int": "baseINT", "vit": "baseVIT", "agi": "baseAGI", "dex": "baseDEX", "crt": "baseCRT", "luk": "baseLUK", "men": "baseMEN", "tec": "baseTEC"}

_SUBS = [
    (r"SkillBufferManager\.ContainsBuffer\(" + RECV + r", (\d+)[^()]*\)", lambda m: f"hasBuff({SBID.get(int(m.group(1)), m.group(1))})"),
    (r"GemCartBufferManager\.ContainsBuffer\(" + RECV + r", (\d+)[^()]*\)", lambda m: f"hasGemCart({GEM.get(int(m.group(1)), m.group(1))})"),
    (r"GemCartBufferBase\.GetValue\(GemCartBufferManager\.GetGemCartBuffer\(" + RECV + r", (\d+)[^()]*\), (\d+)[^()]*\)",
     lambda m: f"gemCart({GEM.get(int(m.group(1)), m.group(1))}[{m.group(2)}])"),
    (r"PlayerAttackBase\.ExistWeaponType\((?:actarAction|player), (\d+)[^()]*\)",
     lambda m: f"mainWeapon=={ITEMTYPE.get(int(m.group(1)), m.group(1))}"),
    (r"PlayerAttackBase\.GetWeaponType\((?:actarAction|player)[^()]*(?:\([^()]*\)[^()]*)*\)", lambda m: "mainWeaponType"),
    (r"PlayerAttackBase\.GetSubWeaponType\((?:actarAction|player)[^()]*(?:\([^()]*\)[^()]*)*\)", lambda m: "subWeaponType"),
    (r"SkillBufferManager\.GetSkillBufferParam\(" + RECV + r", (\d+)[^()]*\)", lambda m: f"buffParam({SBID.get(int(m.group(1)), m.group(1))})"),
    (r"PlayerStatusBase\.get_PrimaryStatus\(\)\.(str|int|vit|agi|dex|crt|luk|men|tec)\b", lambda m: PRIM[m.group(1)]),
    (r"IPlayerStatusCalculator\.get_(\w+)\(" + RECV + r"\)", lambda m: f"status.{m.group(1)}"),
    (r"IPlayerStatusCalculator\.get_(\w+)\([^()]*\)", lambda m: f"status.{m.group(1)}"),
    (r"IMobStatusCalculator\.get_(\w+)\(" + RECV + r"\)", lambda m: f"target.{m.group(1)}"),
    (r"IMobStatusCalculator\.get_(\w+)\([^()]*\)", lambda m: f"target.{m.group(1)}"),
    (r"\[PlayerStatusBase\.GetEquip\(\?blr, 1\)\+0x38\]", lambda m: "mainWeaponType"),
    (r"\[PlayerStatusBase\.GetEquip\(\?blr, 2\)\+0x38\]", lambda m: "subWeaponType"),
    (r"\[EquipItemData\.get_SubWeapon\(\?blr[^()]*\)\+0x28\]", lambda m: "subWeaponData"),
    (r"PlayerPrimaryStatus\.", lambda m: "base."),
    (r"PlayerAttackBase\.GetWeaponRange\([^()]*\)", lambda m: "weaponRange"),
    (r"MathUtil\.DisplayMeterToDistance\(([^()]*?), [^(),]*, \?x2, \?x3\)", lambda m: f"meter({m.group(1)})"),
]


# offsets of PlayerPrimaryStatus (dump.cs); a load through an unnamed status object at these offsets is taken as the allocated stat (inferred)
PRIMARY = {"0x14": "baseSTR~", "0x18": "baseINT~", "0x1c": "baseVIT~", "0x20": "baseAGI~", "0x24": "baseDEX~",
           "0x28": "baseCRT~", "0x2c": "baseLUK~", "0x30": "baseMEN~", "0x34": "baseTEC~"}


def pretty(s):
    if not isinstance(s, str): return s
    for pat, fn in _SUBS:
        s = re.sub(pat, fn, s)
    s = s.replace(", 0, ?x3)", ")").replace(", ?x2, ?x3)", ")").replace(", ?x3)", ")")
    s = re.sub(r"\((\w+(?:\.\w+)*\(.*?\)) & 1\) ne 0", r"\1", s)
    s = re.sub(r"\((\w+(?:\.\w+)*\(.*?\)) & 1\) eq 0", r"!\1", s)
    s = re.sub(r"&lv\b", "", s)
    s = re.sub(r"(mainWeaponType|subWeaponType) (eq|ne) (\d+)", lambda m: f"{m.group(1)[:-4]} {'==' if m.group(2)=='eq' else '!='} {ITEMTYPE.get(int(m.group(3)), m.group(3))}", s)
    s = s.replace("frintm(", "floor(").replace("fcvt(", "(")
    s = s.replace("(lv & 255)", "Lv").replace("(Lv & 255)", "Lv")
    s = re.sub(r"\(\?blr, ", "(", s)
    s = re.sub(r"\(\?blr\)", "()", s)
    s = re.sub(r"\[\?blr\+(0x[0-9a-f]+)\]", lambda m: PRIMARY.get(m.group(1), "primaryStat@" + m.group(1)), s)
    s = re.sub(r"primaryStat@(0x[0-9a-f]+)", lambda m: PRIMARY.get(m.group(1), m.group(0)), s)
    s = re.sub(r"(\w)\((.*?), 0\)", lambda m: m.group(0) if "(" in m.group(2) else f"{m.group(1)}({m.group(2)})", s)
    return s


# ------- numeric evaluation of Lv formulas
def _int(x):
    return int(x)


SAFE = {"int": _int, "max": max, "min": min, "abs": abs, "floor": math.floor}


def to_py(s):
    s = s.replace("//", "//")
    s = re.sub(r"frintm\(([^()]*(?:\([^()]*\)[^()]*)*)\)", r"floor(\1)", s)
    s = re.sub(r"fcvt\(", "float(", s)
    return s


_CMP = [(" lt ", " < "), (" gt ", " > "), (" le ", " <= "), (" ge ", " >= "), (" eq ", " == "), (" ne ", " != "), (" lo ", " < "), (" hs ", " >= "), (" hi ", " > "), (" ls ", " <= ")]


def _top(s):
    """rewrite the depth-0 ternary of s: 'A ? B : C' -> '((B) if (A) else (C))' (right-associative); None if unbalanced"""
    d, q = 0, -1
    for k, ch in enumerate(s):
        d += ch == "("
        d -= ch == ")"
        if d == 0 and s.startswith(" ? ", k): q = k; break
    if q < 0: return s
    d, n, k = 0, 0, q + 3
    while k < len(s):
        ch = s[k]
        d += ch == "("
        d -= ch == ")"
        if d == 0 and s.startswith(" ? ", k): n += 1
        elif d == 0 and s.startswith(" : ", k):
            if n == 0: break
            n -= 1
        k += 1
    if k >= len(s): return None
    a, b_, c = s[:q], s[q + 3:k], _top(s[k + 3:])
    b_ = _top(b_)
    return None if c is None or b_ is None else f"(({b_}) if ({a}) else ({c}))"


def _ternaries(s):
    """rewrite every ternary, parenthesised groups first; None when one cannot be split"""
    out, i = "", 0
    while i < len(s):
        if s[i] != "(":
            out += s[i]; i += 1
            continue
        d, j = 0, i
        while j < len(s):
            d += s[j] == "("
            d -= s[j] == ")"
            if d == 0: break
            j += 1
        args, d2, cur = [], 0, ""
        for ch in s[i + 1:j]:
            d2 += ch == "("
            d2 -= ch == ")"
            if ch == "," and d2 == 0: args.append(cur); cur = ""
            else: cur += ch
        args.append(cur)
        parts = [_ternaries(a) for a in args]
        if None in parts: return None
        inner = ",".join(parts)
        out += "(" + inner + ")"; i = j + 1
    return _top(out)


def evaluate(expr, **env):
    """Evaluate a rendered expression for a given Lv (and other env). Returns None if it is not purely numeric.
    Understands comparisons (lt gt le ge eq ne lo hs; lo/hs are treated as signed) and `c ? a : b`."""
    if isinstance(expr, (int, float)): return expr
    if not isinstance(expr, str): return None
    if any(t in expr for t in ("meta(", "call(", "this", "opaque")):
        return None
    py = to_py(expr)
    for a, b in _CMP: py = py.replace(a, b)
    if "?" in py:
        py = _ternaries(py)
        if py is None or "?" in py: return None
    try:
        v = eval(py, {"__builtins__": {}}, {**SAFE, **env})
    except Exception:
        return None
    if isinstance(v, int) and not isinstance(v, bool) and "0xfffff" in expr:
        v = (v + 2 ** 31) % 2 ** 32 - 2 ** 31   # 32-bit wrap: `Lv * 0xfffffffa + 120` is 120 - 6*Lv
    return v if isinstance(v, (int, float)) and not isinstance(v, bool) else (int(v) if isinstance(v, bool) else None)
