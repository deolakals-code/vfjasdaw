"""Display clean-up for decoded expressions (works on rendered strings).
 - numeric arguments of enum-typed parameters get their enum name (table built from dump.cs signatures)
 - il2cpp plumbing is folded: `0x165db78(meta(.., List<int>_TypeInfo), ?x1..)` -> `new List<int>()`, `meta(.., Method$..)` args dropped,
   trailing `?xN` junk arguments dropped
"""
import re, collections
import dis2 as D2
from dis_android import names

_ENUM_ARG = None
_ENUM_OVERRIDE = {("GetSkillBufferParam", "bufferId"): "SkillBufferId", ("GetSkillBufferParam", "id"): "SkillBufferId",
                  ("GetGemCartBuffer", "id"): "GemCartBufferId", ("GetBufferLevel", "id"): "GemCartBufferId",
                  ("ContainsBuffer", "id"): None, ("Contains", "type"): "AbnormalType", ("CheckAbnormalType", "type"): "AbnormalType"}


def enum_table():
    """'Class.method' -> {arg_index_in_rendered_call: enum type}; only when every overload agrees"""
    global _ENUM_ARG
    if _ENUM_ARG is not None: return _ENUM_ARG
    acc = collections.defaultdict(lambda: collections.defaultdict(set))
    for a, n in names.items():
        if "$$" not in n: continue
        sig = D2.SIG.get(a)
        if not sig: continue
        static, params = sig
        key = n.replace("$$", ".")
        for i, (ty, pn) in enumerate(params):
            ty2 = _ENUM_OVERRIDE.get((n.split("$$")[-1], pn), ty)
            if ty2 and D2.C.get(ty2, {}).get("kind") == "enum":
                acc[key][i + (0 if static else 1)].add(ty2)
    _ENUM_ARG = {k: {i: next(iter(v)) for i, v in d.items() if len(v) == 1} for k, d in acc.items()}
    return _ENUM_ARG


def split_args(s):
    out, d, cur = [], 0, []
    for ch in s:
        if ch in "([": d += 1
        elif ch in ")]": d -= 1
        if ch == "," and d == 0: out.append("".join(cur).strip()); cur = []
        else: cur.append(ch)
    if cur or out: out.append("".join(cur).strip())
    return out


_ID = re.compile(r"[\w.<>$`]+$")


def _walk(s, tab):
    out, i = [], 0
    while i < len(s):
        ch = s[i]
        if ch != "(":
            out.append(ch); i += 1; continue
        m = _ID.search("".join(out))
        name = m.group(0) if m else ""
        d, j = 1, i + 1
        while j < len(s) and d:
            d += (s[j] == "(") - (s[j] == ")"); j += 1
        inner = s[i + 1:j - 1]
        args = [_walk(a, tab) for a in split_args(inner)]
        spec = tab.get(name)
        if spec:
            for k, ty in spec.items():
                if k < len(args) and re.fullmatch(r"-?\d+", args[k]):
                    nm = D2.C[ty]["consts"].get(int(args[k]))
                    if nm: args[k] = f"{ty.rsplit('.', 1)[-1]}.{nm}"
        out.append("(" + ", ".join(args) + ")")
        i = j
    return "".join(out)


import il2
_NEW = re.compile(re.escape(f"{il2.stub('object_new'):#x}") + r"\(meta\(0x[0-9a-f]+, ([^()]*?(?:<[^()]*>)?)_TypeInfo\)(?:, \?x\d)*\)")
_META = re.compile(r",? ?meta\(0x[0-9a-f]+, Method\$[^()]*\(\)\)")
_TAIL = re.compile(r"(?:, \?x\d)+(?=\))")


def tidy(s):
    if not isinstance(s, str) or not s: return s
    s = _NEW.sub(lambda m: f"new {m.group(1)}()", s)
    s = _META.sub("", s)
    s = _TAIL.sub("", s)
    s = re.sub(r"stkp\(-?\d+\)", "out", s)
    s = re.sub(r"meta\(0x[0-9a-f]+, ([\w.<>,`]+)_TypeInfo\)", r"typeof(\1)", s)
    return _walk(s, enum_table())


if __name__ == "__main__":
    t = "SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 && BonusManager.GetBonusPercentValue(m, 105) && Foo(" + f"{il2.stub('object_new'):#x}" + "(meta(0x39738f8, System.Collections.Generic.List<int>_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)"
    print(tidy(t))
    assert "SoulHunt" in tidy(t) and "new System.Collections.Generic.List<int>()" in tidy(t) and "?x" not in tidy(t)
    print("ok")
