"""Fold compiler idioms in symbolic-execution formulas back into readable arithmetic.

`(x + (x << 2)) << 1` -> `10*x`, `(x lt 0 ? (x + 1) : x) >> 1` -> `x÷2` (C# int division), `(a lt b ? a : b)` -> `min(a, b)`,
`mul64(x, 0x66666667) >> 34` -> `x÷10`, and repeated sub-terms are named once (A, B, ...).
simplify(text) returns (formula, [(name, subterm), ...]); on any parse failure it returns the input unchanged.
"""
import re

_TOK = re.compile(r"""\s*(?:
    (?P<num>0x[0-9a-fA-F]+|\d+\.\d*(?:e-?\d+)?|\d+)
  | (?P<unk>\?[A-Za-z_]\w*)
  | (?P<op><<|>>|//|==|!=|\?|:|[-+*/%&|^!(),])
  | (?P<br>\[)
  | (?P<name>[A-Za-z_?$~][\w.$~`]*(?:<[^<>\s]*(?:<[^<>]*>)?[^<>\s]*>)?(?:\.[\w$`]+(?:\(\))?)*)
)""", re.X)
CMP = {"lt", "gt", "le", "ge", "eq", "ne", "lo", "hs", "hi", "ls"}


class _P:
    def __init__(self, s):
        self.s, self.i, self.toks = s, 0, []
        while self.i < len(s):
            if s[self.i].isspace(): self.i += 1; continue
            m = _TOK.match(s, self.i)
            if not m or m.end() == self.i: raise ValueError(s[self.i:self.i + 20])
            if m.group("br"):
                d, j = 0, m.start("br")
                while j < len(s):
                    d += s[j] == "["
                    d -= s[j] == "]"
                    if d == 0: break
                    j += 1
                self.toks.append(("raw", s[m.start("br"):j + 1])); self.i = j + 1; continue
            k = m.lastgroup
            v = m.group(k)
            if k == "name" and v in CMP: k = "cmp"
            if k == "unk": k = "name"
            self.toks.append((k, v)); self.i = m.end()
        self.k = 0

    def peek(self, o=0): return self.toks[self.k + o] if self.k + o < len(self.toks) else (None, None)

    def eat(self, v=None):
        t = self.peek()
        if v is not None and t[1] != v: raise ValueError(f"want {v} got {t}")
        self.k += 1
        return t

    def expr(self):
        c = self.cmp()
        if self.peek()[1] == "?":
            self.eat("?"); a = self.expr(); self.eat(":"); b = self.expr()
            return ("tern", c, a, b)
        return c

    def cmp(self):
        a = self.bit()
        t = self.peek()
        if t[0] == "cmp" or t[1] in ("==", "!="):
            self.eat(); return ("cmp", {"==": "eq", "!=": "ne"}.get(t[1], t[1]), a, self.bit())
        return a

    def _left(self, sub, ops):
        a = sub()
        while self.peek()[0] == "op" and self.peek()[1] in ops:
            op = self.eat()[1]; a = ("bin", op, a, sub())
        return a

    def bit(self): return self._left(self.shift, ("&", "|", "^"))
    def shift(self): return self._left(self.add, ("<<", ">>"))
    def add(self): return self._left(self.mul, ("+", "-"))
    def mul(self): return self._left(self.un, ("*", "/", "//", "%"))

    def un(self):
        if self.peek()[1] == "-": self.eat(); return ("neg", self.un())
        if self.peek()[1] == "!": self.eat(); return ("not", self.un())
        return self.atom()

    def atom(self):
        k, v = self.eat()
        if k == "num": return ("num", int(v, 16) if v.startswith("0x") else (float(v) if "." in v else int(v)))
        if k == "raw": return ("var", v)
        if v == "(":
            e = self.expr(); self.eat(")"); return e
        if k == "name":
            if self.peek()[1] == "(" and not v.endswith("()"):
                self.eat("("); args = []
                while self.peek()[1] != ")":
                    args.append(self.expr())
                    if self.peek()[1] == ",": self.eat(",")
                self.eat(")")
                return ("call", v, args)
            return ("var", v)
        raise ValueError(f"unexpected {v}")


# ---------- simplification
_NODES = {}


def _lin(e):
    """linear form {key: coef}, const; key = printed sub-term"""
    if e[0] == "num": return {}, e[1]
    if e[0] == "neg":
        d, c = _lin(e[1]); return {k: -v for k, v in d.items()}, -c
    if e[0] == "bin" and e[1] in ("+", "-"):
        d1, c1 = _lin(e[2]); d2, c2 = _lin(e[3]); s = 1 if e[1] == "+" else -1
        d = dict(d1)
        for k, v in d2.items(): d[k] = d.get(k, 0) + s * v
        return d, c1 + s * c2
    if e[0] == "bin" and e[1] == "*" and (e[2][0] == "num" or e[3][0] == "num"):
        n, x = (e[2][1], e[3]) if e[2][0] == "num" else (e[3][1], e[2])
        d, c = _lin(x); return {k: v * n for k, v in d.items()}, c * n
    key = pr(e)
    _NODES[key] = e
    return {key: 1}, 0


def _from_lin(d, c):
    terms = sorted(((k, v) for k, v in d.items() if v), key=lambda kv: kv[1] < 0)
    if not terms: return ("num", c)
    out = None
    if c > 0 and terms[0][1] < 0: out, c = ("num", c), 0     # 1 - x, not -x + 1
    for k, v in terms:
        n = _NODES.get(k, ("var", k))
        t = n if abs(v) == 1 else ("bin", "*", ("num", abs(v)), n)
        out = t if out is None else ("bin", "+" if v > 0 else "-", out, t)
        if out is t and v < 0: out = ("neg", t)
    if c: out = ("bin", "+" if c > 0 else "-", out, ("num", abs(c)))
    return out


def _same(a, b): return pr(a) == pr(b)


_UNSIGNED = [False]


def mul64(a, m):
    """smull/smulh operand: 32-bit magic >= 2^31 and 64-bit magic >= 2^63 are negative (umull when _UNSIGNED)"""
    if _UNSIGNED[0]: return a * m
    if 2 ** 31 <= m < 2 ** 32: m -= 2 ** 32
    elif m >= 2 ** 63: m -= 2 ** 64
    return a * m


def _leaves(e, acc):
    if e[0] == "num": return
    if e[0] == "call" and e[1] == "mul64":
        for x in e[2]: _leaves(x, acc)
        return
    if e[0] in ("var", "call"): acc.add(pr(e)); return
    for x in e[1:]:
        if isinstance(x, tuple): _leaves(x, acc)


def _ev(e, env):
    t = e[0]
    if t == "num": return e[1]
    if t in ("var", "call") and pr(e) in env: return env[pr(e)]
    if t == "call" and e[1] == "mul64": return mul64(_ev(e[2][0], env), _ev(e[2][1], env))
    if t == "neg": return -_ev(e[1], env)
    if t == "bin":
        x, y = _ev(e[2], env), _ev(e[3], env)
        return {"+": x + y, "-": x - y, "*": x * y, ">>": x >> y, "<<": x << y, "&": x & y, "|": x | y}[e[1]]
    raise ValueError(t)


def _find_call(e, name):
    if e[0] == "call" and e[1] == name: return e
    kids = e[2] if e[0] == "call" else [x for x in e[1:] if isinstance(x, tuple)]
    for k in kids:
        r = _find_call(k, name)
        if r is not None: return r
    return None


def _magic_div(e):
    """compiler division by a constant (magic multiply + shifts, sign fix-ups) -> x ÷ d; None if not that shape"""
    s = pr(e)
    if not re.search(r"0x[0-9a-f]{7,}|>> (?:15|31|63)\b", s): return None
    node = None
    m = _find_call(e, "mul64")
    if m is not None and m[2][0][0] not in ("num", "var"):   # dividend is a sum: treat it as one leaf
        node = m[2][0]
        e = _replace(e, pr(node), "__X")
    acc = set()
    _leaves(e, acc)
    if len(acc) != 1: return None
    x = next(iter(acc))
    try:
        probes = (30_001, 7_777, 12_347) if ">> 15" in s else (1_000_003, 777_777, 123_457)   # 16-bit sign fix-up needs short-range values
        runs = []
        for u in (False, True):   # the executor names smull and umull alike
            _UNSIGNED[0] = u
            runs.append([(_ev(e, {x: v}), v) for v in probes])
        _UNSIGNED[0] = False
    except (ValueError, KeyError, TypeError):
        _UNSIGNED[0] = False
        return None
    for d in range(2, 1001):
        neg = any(all(r in (-(v // d), -((v + d - 1) // d)) for r, v in vals) for vals in runs)   # negative magic (e.g. smull 0xae147ae1)
        if neg or any(all(r == v // d for r, v in vals) for vals in runs):
            node = node if x == "__X" else (_NODES.get(x) or _P(x).expr())
            out = ("idiv", simp(node), ("num", d))
            return ("neg", out) if neg else out
    return None


def simp(e):
    if e[0] in ("num", "var"): return e
    if e[0] == "call": return ("call", e[1], [simp(x) for x in e[2]])
    if e[0] in ("neg", "not"):
        x = simp(e[1])
        if e[0] == "neg" and x[0] == "num": return ("num", -x[1])
        return (e[0], x)
    if e[0] == "cmp": return ("cmp", e[1], simp(e[2]), simp(e[3]))
    if e[0] == "tern":
        c, a, b = simp(e[1]), simp(e[2]), simp(e[3])
        if c[0] == "cmp" and c[1] in ("lt", "le", "gt", "ge"):
            x, y = c[2], c[3]
            if _same(a, x) and _same(b, y): return ("call", "min" if c[1] in ("lt", "le") else "max", [x, y])
            if _same(a, y) and _same(b, x): return ("call", "max" if c[1] in ("lt", "le") else "min", [x, y])
        if c[0] == "cmp" and c[2][0] == "num" and c[3][0] == "num":
            v = {"eq": c[2][1] == c[3][1], "ne": c[2][1] != c[3][1]}.get(c[1])
            if v is not None: return a if v else b
        return ("tern", c, a, b)
    op, a, b = e[1], e[2], e[3]
    # signed division by 2^s: (A lt 0 ? (A + (2^s - 1)) : A) >> s
    if op == ">>" and b[0] == "num" and a[0] == "tern" and a[1][0] == "cmp" and a[1][1] == "lt" and a[1][3] == ("num", 0) \
            and _same(a[3], a[1][2]) and a[2][0] == "bin" and a[2][1] == "+" and _same(a[2][2], a[1][2]) and a[2][3] == ("num", 2 ** b[1] - 1):
        return ("idiv", simp(a[1][2]), ("num", 2 ** b[1]))
    # mul64(x, magic) >> s  ->  x ÷ round(2^s / magic)
    if op == ">>" and b[0] == "num" and a[0] == "call" and a[1] == "mul64" and a[2][1][0] == "num":
        m = a[2][1][1]
        dv = round(2 ** b[1] / m) if m else 0
        if dv and abs(2 ** b[1] / m - dv) < 1e-3 * dv: return ("idiv", simp(a[2][0]), ("num", dv))
    md = _magic_div(e) if op in (">>", "+") else None
    if md: return md
    a, b = simp(a), simp(b)
    if op == "<<" and b[0] == "num": op, b = "*", ("num", 2 ** b[1])
    if op == ">>" and b[0] == "num" and 0 < b[1] < 31: return ("idiv", a, ("num", 2 ** b[1]))
    if a[0] == "num" and b[0] == "num" and op in ("+", "-", "*"):
        return ("num", {"+": a[1] + b[1], "-": a[1] - b[1], "*": a[1] * b[1]}[op])
    if op in ("+", "-", "*"):
        e2 = ("bin", op, a, b)
        d, c = _lin(e2)
        return _from_lin(d, c)
    return ("bin", op, a, b)


PREC = {"tern": 0, "cmp": 1, "|": 2, "^": 2, "&": 2, "<<": 3, ">>": 3, "+": 4, "-": 4, "*": 5, "/": 5, "//": 5, "%": 5, "idiv": 4.5}
SYM = {"*": "×", "/": "/", "//": "//", "idiv": "÷"}
CMPS = {"lt": "<", "gt": ">", "le": "≤", "ge": "≥", "eq": "=", "ne": "≠", "lo": "<", "hs": "≥", "hi": ">", "ls": "≤"}


def _num(v):
    if isinstance(v, float): return f"{v:g}"
    return str(v) if abs(v) < 65536 else hex(v)


def pr(e, parent=-1):
    t = e[0]
    if t == "num": return _num(e[1])
    if t == "var": return e[1]
    if t == "call": return f"{e[1]}(" + ", ".join(pr(x) for x in e[2]) + ")"
    if t == "neg": return "-" + pr(e[1], 6)
    if t == "not": return "!" + pr(e[1], 6)
    if t == "cmp": s, p = f"{pr(e[2], 2)} {CMPS[e[1]]} {pr(e[3], 2)}", 1
    elif t == "tern": s, p = f"{pr(e[1], 1)} ? {pr(e[2], 1)} : {pr(e[3], 1)}", 0
    elif t == "idiv": s, p = f"{pr(e[1], 5)} ÷ {pr(e[2], 6)}", 4.5
    else:
        op = e[1]; p = PREC[op]
        s = f"{pr(e[2], p)} {SYM.get(op, op)} {pr(e[3], p + (1 if op in ('-', '/', '//', '%') else 0))}"
    return f"({s})" if p < parent else s


def _subterms(e, acc):
    if e[0] == "num": return
    s = pr(e)
    if e[0] == "var":
        if len(s) >= 18 and ("(" in s or "[" in s): acc[s] = acc.get(s, 0) + 1
        return
    if len(s) >= 18: acc[s] = acc.get(s, 0) + 1
    kids = e[2] if e[0] == "call" else [x for x in e[1:] if isinstance(x, tuple)]
    for x in kids: _subterms(x, acc)


def _replace(e, s, name):
    if pr(e) == s: return ("var", name)
    if e[0] in ("num", "var"): return e
    if e[0] == "call": return ("call", e[1], [_replace(x, s, name) for x in e[2]])
    return (e[0],) + tuple(_replace(x, s, name) if isinstance(x, tuple) else x for x in e[1:])


def simplify(text):
    try:
        p = _P(text)
        e = p.expr()
        if p.k != len(p.toks): return text, []
        e = simp(e)
    except (ValueError, IndexError, TypeError, ZeroDivisionError, RecursionError):
        return text, []
    names = []
    for _ in range(4):
        acc = {}
        _subterms(e, acc)
        rep = [s for s, n in acc.items() if n >= 2]
        if not rep: break
        s = max(rep, key=len)
        nm = "ABCDEFGH"[len(names)]
        names.append((nm, s))
        e = _replace(e, s, nm)
    return pr(e), names


if __name__ == "__main__":
    assert simplify("(((Lv + (Lv << 2)) << 1) + 300)")[0] == "10 × Lv + 300", simplify("(((Lv + (Lv << 2)) << 1) + 300)")
    assert simplify("((x lt 0 ? (x + 1) : x) >> 1)")[0] == "x ÷ 2"
    assert simplify("((y lt 100 ? y : 100))")[0] == "min(y, 100)"
    assert simplify("((mul64(v, 0x66666667) >> 34))")[0] == "v ÷ 10"
    assert simplify("(1 - min(x, 1))")[0] == "1 - min(x, 1)", simplify("(1 - min(x, 1))")
    f, n = simplify("((Some.LongCall(a, b) * 3) + g(Some.LongCall(a, b)))")
    assert "A" in f, (f, n)
    assert simplify("(((mul64(v, 0x66666667) >> 32) >> 2))")[0] == "v ÷ 10"
    assert simplify("((((mul64(s, 0x88888889) >> 32) + s) >> 4) + ((((mul64(s, 0x88888889) >> 32) + s) >> 31)))")[0] == "s ÷ 30"
    assert simplify("(((0x66666667 * w) >> 32) >> 1)")[0] == "w ÷ 5"
    assert simplify("((((mul64((a + b), 0x66666667) >> 32) >> 1) + 400))")[0] == "(a + b) ÷ 5 + 400", simplify("((((mul64((a + b), 0x66666667) >> 32) >> 1) + 400))")
    assert simplify("(((q + (q >> 15)) >> 1) + 200)")[0] == "q ÷ 2 + 200", simplify("(((q + (q >> 15)) >> 1) + 200)")
    assert simplify("((mul64(d, 0xae147ae1) >> 37) + 15)")[0] == "15 - (d ÷ 100)"
    print("exprsimp ok")
