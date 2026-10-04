"""Reference evaluator for the decoded formulas (proves the spec is executable; the future calculator can port this).

  python calc_engine.py --selftest      parser/evaluator unit tests + a few glossary functions
  python calc_engine.py --coverage      evaluate every term of every calc_spec with sample inputs, report what cannot be evaluated and why

Notation understood: the decoder text of variables.json / calc_spec (C-like ops, `lt gt le ge eq ne lo hs hi ls` comparisons, `&&`, `||`, `c ? a : b`,
`x[i]`, `x.field`, calls, `_tN` named sub-expressions). Leaves (player/mob stats, buff lookups ...) come from `env` by full name (`Class.method`);
functions that have a decoded definition in variables.json are evaluated from it. Anything else raises Unresolved(name).
"""
import os, re, json, sys, collections

OUT = r"D:\toram reverse data\skills\damage"
CMPW = {"lt": lambda a, b: a < b, "gt": lambda a, b: a > b, "le": lambda a, b: a <= b, "ge": lambda a, b: a >= b, "eq": lambda a, b: a == b,
        "ne": lambda a, b: a != b, "lo": lambda a, b: a < b, "hs": lambda a, b: a >= b, "hi": lambda a, b: a > b, "ls": lambda a, b: a <= b,
        "mi": lambda a, b: a < b, "pl": lambda a, b: a >= b}
TOK = re.compile(r"""\s*(?:
    (?P<num>0x[0-9a-fA-F]+|\d+\.\d*(?:e[-+]?\d+)?|\d+(?:e[-+]?\d+)?)
  | (?P<op><<|>>|//|&&|\|\||==|!=|[-+*/%&|^!?:(),\[\]])
  | (?P<name>[A-Za-z_$?~][\w$~`]*(?:\.[A-Za-z_$~`][\w$~`]*)*)
  | (?P<dot>\.)
)""", re.X)


class Unresolved(Exception):
    pass


def tokens(s):
    s = re.sub(r"\bnew\s+", "new_", s)                    # `new X` object construction: an opaque object name
    for _ in range(3): s = re.sub(r"<[^<>()]*>", "", s)
    out, i = [], 0
    while i < len(s):
        m = TOK.match(s, i)
        if not m or m.end() == i:
            if s[i:].strip() == "": break
            raise ValueError(f"bad token near {s[i:i + 20]!r}")
        i = m.end()
        k = m.lastgroup
        out.append((k, m.group(k)))
    return out


class Parser:
    """recursive descent -> nested tuples; evaluation is lazy (short-circuit) so guarded leaves are never touched"""

    def __init__(self, s):
        self.t, self.i = tokens(s), 0

    def peek(self): return self.t[self.i] if self.i < len(self.t) else (None, None)

    def eat(self, v=None):
        k, x = self.peek()
        if v is not None and x != v: raise ValueError(f"expected {v} got {x}")
        self.i += 1
        return x

    def parse(self):
        e = self.ternary()
        if self.i != len(self.t): raise ValueError(f"trailing tokens {self.t[self.i:self.i + 4]}")
        return e

    def ternary(self):
        c = self.orx()
        if self.peek()[1] == "?":
            self.eat("?"); a = self.ternary(); self.eat(":"); b = self.ternary()
            return ("?", c, a, b)
        return c

    def orx(self):
        e = self.andx()
        while self.peek()[1] == "||": self.eat(); e = ("||", e, self.andx())
        return e

    def andx(self):
        e = self.cmp()
        while self.peek()[1] == "&&": self.eat(); e = ("&&", e, self.cmp())
        return e

    def cmp(self):
        e = self.bit()
        k, x = self.peek()
        if k == "name" and x in CMPW:
            self.eat(); return ("cmp", x, e, self.bit())
        if x in ("==", "!="):
            self.eat(); return ("cmp", "eq" if x == "==" else "ne", e, self.bit())
        return e

    def bit(self):
        e = self.shift()
        while self.peek()[1] in ("&", "|", "^"):
            o = self.eat(); e = (o, e, self.shift())
        return e

    def shift(self):
        e = self.add()
        while self.peek()[1] in ("<<", ">>"):
            o = self.eat(); e = (o, e, self.add())
        return e

    def add(self):
        e = self.mul()
        while self.peek()[1] in ("+", "-"):
            o = self.eat(); e = (o, e, self.mul())
        return e

    def mul(self):
        e = self.unary()
        while self.peek()[1] in ("*", "/", "//", "%"):
            o = self.eat(); e = (o, e, self.unary())
        return e

    def unary(self):
        x = self.peek()[1]
        if x == "-": self.eat(); return ("neg", self.unary())
        if x == "!": self.eat(); return ("not", self.unary())
        return self.postfix()

    def postfix(self):
        e = self.atom()
        while True:
            k, x = self.peek()
            if x == "(" and e[0] == "name":
                self.eat("(")
                args = []
                if self.peek()[1] != ")":
                    args.append(self.ternary())
                    while self.peek()[1] == ",": self.eat(); args.append(self.ternary())
                self.eat(")")
                e = ("call", e[1], args)
            elif x == "[":
                self.eat("["); idx = self.ternary(); self.eat("]"); e = ("idx", e, idx)
            elif k == "dot" or (x == "." and k == "op"):
                self.eat(); n = self.peek()
                if n[0] != "name": raise ValueError("field name expected")
                self.eat(); e = ("field", e, n[1])
            else:
                return e

    def atom(self):
        k, x = self.peek()
        if k == "num":
            self.eat()
            if x.lower().startswith("0x"): return ("num", int(x, 16))
            return ("num", float(x) if ("." in x or "e" in x.lower()) else int(x))
        if k == "name": self.eat(); return ("name", x)
        if x == "(":
            self.eat("("); e = self.ternary(); self.eat(")"); return e
        raise ValueError(f"unexpected {x!r}")


def _int(x):
    return int(x)


class Evaluator:
    def __init__(self, env=None, glossary=None):
        self.env = env or {}
        self.V = (glossary or {}).get("vars", {}) if glossary else {}
        self._ast = {}
        self.depth = 0
        self.missing = collections.Counter()

    # ---- public
    def ast(self, text):
        a = self._ast.get(text)
        if a is None: a = self._ast[text] = Parser(text).parse()
        return a

    def eval(self, text, scope=None):
        return self.ev(self.ast(text), scope or {}, {})

    def truth(self, text, scope=None):
        v = self.eval(text, scope)
        return bool(v)

    def when(self, w, scope=None):
        """`A AND B OR C AND D` (spec condition format) -> bool"""
        if w in (None, "", "always"): return True
        for grp in w.split(" OR "):
            if all(self.truth(a, scope) for a in grp.split(" AND ")): return True
        return False

    # ---- core
    def ev(self, n, sc, lets):
        k = n[0]
        if k == "num": return n[1]
        if k == "name": return self.name(n[1], sc, lets)
        if k == "neg": return -self.ev(n[1], sc, lets)
        if k == "not": return int(not self.ev(n[1], sc, lets))
        if k == "?": return self.ev(n[2], sc, lets) if self.ev(n[1], sc, lets) else self.ev(n[3], sc, lets)
        if k == "&&": return int(bool(self.ev(n[1], sc, lets)) and bool(self.ev(n[2], sc, lets)))
        if k == "||": return int(bool(self.ev(n[1], sc, lets)) or bool(self.ev(n[2], sc, lets)))
        if k == "cmp": return int(CMPW[n[1]](self.ev(n[2], sc, lets), self.ev(n[3], sc, lets)))
        if k in ("+", "-", "*", "/", "//", "%", "<<", ">>", "&", "|", "^"):
            a, b = self.ev(n[1], sc, lets), self.ev(n[2], sc, lets)
            if k == "+": return a + b
            if k == "-": return a - b
            if k == "*": return a * b
            if k == "/": return a / b if b else 0
            if k == "//": return int(a / b) if b else 0
            if k == "%": return a % b if b else 0
            a, b = int(a), int(b)
            if k == "<<": return a << b          # one operation only: the old dict built `a << b` for every operator, which is slow (or a MemoryError) for a large shift count
            if k == ">>": return a >> b
            if k == "&": return a & b
            if k == "|": return a | b
            return a ^ b
        if k == "idx":
            base = self.ev(n[1], sc, lets); i = self.ev(n[2], sc, lets)
            try: return base[i]
            except (KeyError, IndexError, TypeError): raise Unresolved(f"index {i!r}")
        if k == "field":
            base = self.ev(n[1], sc, lets)
            if isinstance(base, dict) and n[2] in base: return base[n[2]]
            raise Unresolved(f"field {n[2]}")
        if k == "call": return self.call(n[1], n[2], sc, lets)
        raise ValueError(k)

    def name(self, nm, sc, lets):
        if nm in sc: return sc[nm]
        if nm in lets:
            v = lets[nm]
            if isinstance(v, tuple) and v and v[0] == "__lazy__":
                v = lets[nm] = self.ev(self.ast(v[1]), sc, lets)
            return v
        if nm in self.env: return self.env[nm]
        if nm in ("true", "True"): return 1
        if nm in ("false", "False"): return 0
        low = nm.rsplit(".", 1)[-1]
        if nm in self.V and self.V[nm].get("values") is not None: return self.V[nm]["values"]
        if nm in self.V and self.V[nm].get("value") is not None: return self.V[nm]["value"]          # enum constant
        if nm.startswith("this."): return self.name(nm[5:], sc, lets)
        parts = nm.split(".")
        for i in range(len(parts) - 1, 0, -1):          # `buf.Count`: longest resolvable prefix, rest = fields
            head = ".".join(parts[:i])
            if head in sc or head in lets or head in self.env:
                v = self.name(head, sc, lets)
                for f in parts[i:]:
                    if isinstance(v, dict) and f in v: v = v[f]
                    else: raise Unresolved(nm)
                return v
        if low in sc: return sc[low]
        raise Unresolved(nm)

    BUILTIN = {"int": _int, "min": min, "max": max, "abs": abs, "System.Math.Min": min, "System.Math.Max": max, "System.Math.Abs": abs,
               "System.Math.Floor": lambda x: int(x // 1), "System.Math.Ceiling": lambda x: -int(-x // 1), "frintm": lambda x: int(x // 1)}

    def call(self, nm, args, sc, lets):
        if nm in self.BUILTIN: return self.BUILTIN[nm](*[self.ev(a, sc, lets) for a in args])
        if nm in self.env:
            f = self.env[nm]
            return f(*[self.ev(a, sc, lets) for a in args]) if callable(f) else f
        v = self.V.get(nm)
        if v and v.get("impls") and self.depth < 12:
            for im in v["impls"]:
                if "cases" not in im or not im["cases"] or im.get("returns") in (None, "void"): continue
                return self.call_def(nm, im, args, sc, lets)
        self.missing[nm] += 1
        raise Unresolved(nm)

    def call_def(self, nm, im, args, sc, lets):
        params = [p[1] for p in im.get("params", [])]
        vals = [self.ev(a, sc, lets) for a in args]
        if not im.get("static", False) and len(vals) == len(params) + 1: vals = vals[1:]          # receiver first
        local = dict(zip(params, vals))
        L = {k: ("__lazy__", x) for k, x in im.get("lets", {}).items()}
        self.depth += 1
        try:
            for c in im["cases"]:
                ok = all(self.truth_in(w, local, L) for w in c["common"])
                if ok and c.get("variants"):
                    ok = any(all(self.truth_in(w, local, L) for w in var) for var in c["variants"])
                if ok: return self.ev(self.ast(c["value"]), local, L)
            raise Unresolved(f"{nm}: no case matched")
        finally:
            self.depth -= 1

    def truth_in(self, w, local, L):
        return bool(self.ev(self.ast(w), local, L))


# ------------------------------------------------------------------------------------------------ tests / coverage
def selftest():
    E = Evaluator({"a": 5})
    assert E.eval("(a * 2) + 3") == 13
    assert E.eval("a gt 3 ? 10 : 20") == 10
    assert E.eval("int((7 / 2)) + (1 << 3)") == 11
    assert E.eval("(a & 1) ne 0 && a lt 9") == 1
    assert E.eval("min(a, 3) + max(a, 7)") == 10
    assert E.eval("a lt 3 && Unknown.Leaf(1) ge 0") == 0            # short-circuit: untouched leaf
    try: E.eval("Unknown.Leaf(1)"); raise AssertionError("expected Unresolved")
    except Unresolved: pass
    assert E.when("a gt 3 AND a lt 9 OR a eq 0")
    assert not E.when("a gt 9 AND a lt 9")
    E2 = Evaluator({"d": {"x": [10, 20, 30]}})
    assert E2.eval("d.x[2] + 1") == 31
    G = json.load(open(os.path.join(OUT, "variables.json"), encoding="utf-8"))
    E3 = Evaluator({"PlayerStatusBase.get_SecondaryStatus": lambda *_: 0}, G)
    # glossary function with a decoded definition: weapon-independent pierce helper
    r = E3.V.get("PlayerAttackBase.CalcPowerResistDamage")
    print("CalcPowerResistDamage decoded:", bool(r and r["impls"]))
    print("selftest ok")


def coverage():
    G = json.load(open(os.path.join(OUT, "variables.json"), encoding="utf-8"))
    spec_dir = os.path.join(OUT, "calc_spec")
    tot = ok = 0
    parse_err = collections.Counter(); unres = collections.Counter(); samples = {}
    for fn in sorted(os.listdir(spec_dir)):
        sp = json.load(open(os.path.join(spec_dir, fn), encoding="utf-8"))
        names = {}
        for e in sp["fields"] + sp["terms"]:
            tot += 1
            names[e["name"]] = 100
        E = Evaluator({}, G)
        E.env.update({"Lv": 5, "lv": 5})
        for e in sp["fields"] + sp["terms"]:
            try:
                E.ast(e["formula"])
            except Exception as ex:
                parse_err[str(ex)[:50]] += 1; samples.setdefault(("parse", str(ex)[:50]), (sp["uid"], e["formula"][:120])); continue
            try:
                E.eval(e["formula"], {k: 1 for k in re.findall(r"\b[A-Za-z_]\w*\b", e["formula"]) if k not in E.V})
                ok += 1
            except Unresolved as u:
                unres[str(u).split(":")[0][:60]] += 1
            except Exception as ex:
                parse_err["eval:" + type(ex).__name__ + ":" + str(ex)[:40]] += 1
    print(f"formulas: {tot}; parse/eval errors: {sum(parse_err.values())}; evaluable with sample leaves: {ok}")
    print("parse errors:", parse_err.most_common(8))
    for k, v in list(samples.items())[:6]: print("  sample", k, v)
    print("top unresolved leaves:", unres.most_common(25))


if __name__ == "__main__":
    if "--selftest" in sys.argv: selftest()
    if "--coverage" in sys.argv: coverage()
