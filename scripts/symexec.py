"""Tiny symbolic executor for IL2CPP AArch64 methods (Android libil2cpp.so).

Goal: recover skill-rate / damage-recipe formulas from the skill Action classes.
It follows instructions, keeps registers as expression trees, forks on conditions that depend on real game state
(fields of `this`, method arguments, results of calls) and records:
  * writes to `this.<field>`                          -> ev "set"
  * SkillCalcTemplate.Add/SetRate/Constant(step, v)   -> ev "tpl"
  * every other direct call (name + argument exprs)   -> ev "call"
usage: python symexec.py Class$$Method
"""
import re, sys, struct, bisect, json
import dis2 as D2
import il2
from dis_android import b, names, starts, OFF, md as _md
import capstone

md = capstone.Cs(capstone.CS_ARCH_ARM64, capstone.CS_MODE_ARM)
md.detail = False


def _field_types():
    ft, cur, fs, curs = {}, None, {}, None
    rx_cls = re.compile(r"^(?:public|private|internal|protected)?\s*(?:abstract |sealed |static )*(?:class|struct) ([\w.<>`,]+)")
    rx_f = re.compile(r"^\s(?:public |private |protected |internal )(?:static )?(?:readonly )?([\w.<>\[\],`? ]+?) ([\w<>]+); // 0x([0-9A-Fa-f]+)$")
    for line in open(D2.DUMP, encoding="utf-8"):
        m = rx_cls.match(line)
        if m and not line.startswith((chr(9), " ")):
            cur = ft.setdefault(m.group(1), {}); curs = fs.setdefault(m.group(1), {}); continue
        m = rx_f.match(line.rstrip(chr(10)))
        if m and cur is not None and not re.search(r"\bconst\b", line):
            (curs if re.search(r"\bstatic\b", line) else cur)[int(m.group(3), 16)] = (m.group(1), m.group(2))
    return ft, fs


FT, FS = _field_types()
UNK = {}


def ftype(cls, off):
    for c in D2.chain(cls):
        if off in FT.get(c, {}): return FT[c][off]
    return (None, None)
NAME2ADDR = {}
for a, n in names.items():
    NAME2ADDR.setdefault(n, a)
STEP = dict(D2.STEP)
MATH_FP = {il2.method_rva("Math", n, f"{t} val1") for n in ("Max", "Min") for t in ("float", "double")}   # System.Math.Max/Min(float|double): operands in v0/v1, not x0/x1
_MID = {}


def mastery_id(v):
    if not _MID:
        on = False
        for ln in open(r"D:\toram reverse data\TORAM ONLINE BIGDATA\readable\code\enums.txt", encoding="utf-8"):
            if ln.startswith(".MasteryId :"): on = True; continue
            if on:
                m = re.match(r"\s+(\w+) = (\d+)", ln)
                if not m: break
                _MID[int(m.group(2))] = m.group(1)
    return "MasteryId." + _MID.get(v, str(v))
TPL = {"AddRate", "SetRate", "AddConstant", "SetConstant", "SetCheck", "SetCalcValue"}
RODATA_MAX = il2.TEXT_VA          # below the exec segment RVA == file offset


def f32(bits):
    return struct.unpack("<f", struct.pack("<I", bits & 0xffffffff))[0]


def is_num(x):
    return isinstance(x, (int, float)) and not isinstance(x, bool)


def E(op, *a):
    """expression constructor with constant folding"""
    if all(is_num(x) for x in a):
        try:
            if op == "+": return a[0] + a[1]
            if op == "-": return a[0] - a[1]
            if op == "*": return a[0] * a[1]
            if op == "/": return a[0] / a[1] if a[1] else ("/", *a)
            if op == "idiv": return int(a[0] / a[1]) if a[1] else ("idiv", *a)
            if op == "<<": return int(a[0]) << int(a[1])
            if op == ">>": return int(a[0]) >> int(a[1])
            if op == "&": return int(a[0]) & int(a[1])
            if op == "|": return int(a[0]) | int(a[1])
            if op == "^": return int(a[0]) ^ int(a[1])
            if op == "neg": return -a[0]
            if op == "toF": return float(a[0])
            if op == "trunc": return int(a[0])
            if op == "min": return min(a)
            if op == "max": return max(a)
            if op == "abs": return abs(a[0])
        except Exception:
            pass
    if op == ">>" and isinstance(a[0], tuple) and a[0][0] == "*" and is_num(a[0][2]) and a[0][2] >= (1 << 20) and is_num(a[1]):
        if a[1] == 63: return 0
        d = (1 << int(a[1])) / a[0][2]
        if abs(d - round(d)) < 1e-3 * max(1, d) and not is_num(a[0][1]): return ("idiv", a[0][1], int(round(d)))
    if op == ">>" and isinstance(a[0], tuple) and a[0][0] == "mul64" and a[1] == 63:
        return 0
    if op == ">>" and is_num(a[1]) and isinstance(a[0], tuple) and a[0][0] == ">>" and a[0][2] == 32 \
            and isinstance(a[0][1], tuple) and a[0][1][0] == "mul64":
        x, m = a[0][1][1], a[0][1][2]            # magic-number division: ((x * m) >> 32) >> s == x // (2^(32+s) / m)
        if is_num(m) and not is_num(x) and 0 < m < (1 << 31):
            d = (1 << (32 + int(a[1]))) / m
            if abs(d - round(d)) < 1e-3 * max(1, d): return ("idiv", x, int(round(d)))
    if op == ">>" and is_num(a[1]) and isinstance(a[0], tuple) and a[0][0] == "+" and not is_num(a[0][2]):
        h, x = a[0][1], a[0][2]                   # signed magic with add: (((x * m) >> 32) + x) >> s, m >= 2^31
        if isinstance(h, tuple) and h[0] == ">>" and h[2] == 32 and isinstance(h[1], tuple) and h[1][0] == "mul64" and h[1][1] == x and is_num(h[1][2]):
            mu = int(h[1][2]) & 0xffffffff
            if a[1] == 31: return 0               # sign-correction term of the idiom; operands here are non-negative
            if mu >= (1 << 31):
                d = (1 << (32 + int(a[1]))) / mu
                if abs(d - round(d)) < 1e-3 * max(1, d): return ("idiv", x, int(round(d)))
    if op == ">>" and isinstance(a[0], tuple) and a[0][0] == "mul64" and is_num(a[1]):
        x, m = a[0][1], a[0][2]
        if is_num(m) and m:
            if not is_num(x):
                d = (1 << int(a[1])) / m
                if abs(d - round(d)) < 1e-3 * max(1, d): return ("idiv", x, int(round(d)))
        elif is_num(x) and x and not is_num(m):
            d = (1 << int(a[1])) / x
            if abs(d - round(d)) < 1e-3 * max(1, d): return ("idiv", m, int(round(d)))
    if op == "+" and a[1] == 0: return a[0]
    if op == "+" and a[0] == 0: return a[1]
    if op == "-" and a[1] == 0: return a[0]
    if op == "*" and (a[1] == 1): return a[0]
    if op == "*" and (a[0] == 1): return a[1]
    if op == "toF" and isinstance(a[0], tuple) and a[0][0] == "toF": return a[0]
    if op == "trunc" and isinstance(a[0], tuple) and a[0][0] == "trunc": return a[0]
    return (op,) + tuple(a)


LETS_ON = False        # True: long sub-expressions are named (_tN) once and shared (DAG output); table in LETS
LET_MIN = 220
LETS, _LETREV, _RC = {}, {}, {}
LETOPS = {"sel", "+", "-", "*", "/", "idiv", "min", "max", "trunc", "call", "&", "|"}


def render(e, depth=0):
    if LETS_ON and isinstance(e, tuple) and e and e[0] in LETOPS:
        c = _RC.get(id(e))
        if c is not None and c[0] is e: return c[1]
        s = _render(e, depth)
        if len(s) > LET_MIN:
            nm = _LETREV.get(s)
            if nm is None:
                nm = f"_t{len(LETS) + 1}"; LETS[nm] = s; _LETREV[s] = nm
            s = nm
        _RC[id(e)] = (e, s)
        return s
    return _render(e, depth)


def lets_used(*texts):
    """transitive closure of the `_tN` definitions referenced by the given strings"""
    out, todo = {}, [t for t in texts if isinstance(t, str)]
    while todo:
        t = todo.pop()
        for m in re.findall(r"_t\d+", t):
            if m not in out and m in LETS: out[m] = LETS[m]; todo.append(LETS[m])
    return out


def _render(e, depth=0):
    if isinstance(e, float):
        return f"{e:g}"
    if isinstance(e, int):
        return str(e) if abs(e) < 4096 else hex(e)
    if not isinstance(e, tuple):
        return str(e)
    op = e[0]
    if op == "this": return "this"
    if op == "f": return "this." + e[1]
    if op == "arg": return e[1]
    if op == "call": return e[1] + "(" + ", ".join(render(x) for x in e[2]) + ")"
    if op == "sel": return f"({render(e[1]) if isinstance(e[1], tuple) else e[1]} ? {render(e[2])} : {render(e[3])})"
    if op == "new": return f"new {e[1]}"
    if op == "idx": return render(e[1]) + "[" + render(e[2]) + "]"
    if op == "sfld": return e[1]
    if op == "enum": return e[1].rsplit(".", 1)[-1] + "." + D2.C[e[1]]["consts"][e[2]]
    if op == "cmp": return cond_str(e[1], e[2], e[3])
    if op == "or": return " || ".join("(" + render(x) + ")" for x in e[1:])
    if op == "and": return " && ".join(render(x) for x in e[1:]) if len(e) > 1 else "true"
    if op == "fld": return render(e[1]) + "." + e[2].rsplit(".", 1)[-1]
    if op == "toF": return render(e[1])
    if op == "trunc": return "int(" + render(e[1]) + ")"
    if op in ("+", "-", "*", "/", "idiv", "<<", ">>", "&", "|", "^"):
        s = {"idiv": "//"}.get(op, op)
        return "(" + render(e[1]) + f" {s} " + render(e[2]) + ")"
    if op == "neg": return "-" + render(e[1])
    if op in ("min", "max", "abs"): return op + "(" + ", ".join(render(x) for x in e[1:]) + ")"
    if op == "ld": return f"[{render(e[1])}+{e[2]:#x}]"
    if op == "opaque": return "?" + str(e[1])
    return op + "(" + ", ".join(render(x) for x in e[1:]) + ")"


def boring(e):
    """expression built only from runtime plumbing (vtables, type infos, unresolved thunks)"""
    if isinstance(e, tuple):
        if e[0] in ("vtab", "vfn", "meta", "opaque", "ifc", "sfld", "statics"): return True
        if e[0] == "call" and str(e[1]).startswith("0x"): return True
        return any(boring(x) for x in e[1:] if isinstance(x, tuple)) and not any(
            isinstance(x, tuple) and x[0] in ("f", "arg", "call") for x in e[1:])
    return False


def cond_str(cc, a, b_):
    return f"{render(a)} {cc} {render(b_)}"


CC_NEG = {"eq": "ne", "ne": "eq", "hs": "lo", "lo": "hs", "cs": "cc", "cc": "cs", "hi": "ls", "ls": "hi", "ge": "lt",
          "lt": "ge", "gt": "le", "le": "gt", "mi": "pl", "pl": "mi"}


def eval_cc(cc, a, b_):
    if not (is_num(a) and is_num(b_)): return None
    return {"eq": a == b_, "ne": a != b_, "lt": a < b_, "le": a <= b_, "gt": a > b_, "ge": a >= b_,
            "lo": a < b_, "ls": a <= b_, "hi": a > b_, "hs": a >= b_, "cc": a < b_, "cs": a >= b_,
            "mi": a < b_, "pl": a >= b_}.get(cc)


class St:
    __slots__ = ("R", "stack", "sp", "fl", "cond", "condx", "ev", "fields", "visits", "n", "ret", "known", "excl", "heap", "hier")

    def __init__(self):
        self.R, self.stack, self.sp, self.fl, self.cond, self.ev, self.fields, self.visits, self.n = {}, {}, 0, None, [], [], {}, {}, 0
        self.condx = []
        self.ret = None
        self.known, self.excl = {}, {}
        self.heap = {}
        self.hier = None

    def copy(self):
        s = St()
        s.R, s.stack, s.sp, s.fl = dict(self.R), dict(self.stack), self.sp, self.fl
        s.heap = dict(self.heap)
        s.cond, s.condx, s.ev, s.fields, s.visits, s.n = list(self.cond), list(self.condx), list(self.ev), dict(self.fields), dict(self.visits), self.n
        s.ret = self.ret
        s.known, s.excl = dict(self.known), {k: set(v) for k, v in self.excl.items()}
        s.hier = self.hier
        return s


def rk(name):
    n = name.strip()
    if n in ("wzr", "xzr"): return None
    if n == "sp" or n == "wsp": return "sp"
    if n[0] in "xw": return "x" + n[1:]
    m = re.match(r"^[sdbhqv](\d+)(?:\.\w+)?$", n)
    if m: return "v" + m.group(1)
    return n


def norm_type(t):
    t = re.sub(r"<.*", "", str(t)).replace("[]", "").strip()
    return t if (t in D2.C or t in FT) else None


ENUM_BY_PARAM = {("GetSkillBufferParam", "bufferId"): "SkillBufferId", ("GetSkillBufferParam", "id"): "SkillBufferId",
                 ("GetGemCartBuffer", "id"): "GemCartBufferId", ("Contains", "type"): "AbnormalType",
                 ("CheckAbnormalType", "type"): "AbnormalType", ("ContainsAbnormal", "type"): "AbnormalType"}
MASTERY_RECV = False   # True: SkillMasteryBase.GetMasteryParam(id) also carries its receiver when it is `SkillMasteryList[uid]` (stat functions only; skill pages keep the old text)
NAME_ENUMS = False     # True: constants passed to enum-typed parameters are kept as ("enum", type, value) and rendered by name
_BUF_BY_ID = {}


def buf_class(sid):
    """SkillId -> *Buf class whose get_SkillId returns it (decoded once)"""
    if not _BUF_BY_ID:
        for a, n in names.items():
            if n.endswith("$$get_SkillId") and "Buf" in n.split("$$")[0]:
                try:
                    ex = Ex(a, max_paths=4, max_ins=40)
                    for stt in ex.run():
                        if stt.ret is not None and is_num(stt.ret[0]): _BUF_BY_ID.setdefault(int(stt.ret[0]), n.split("$$")[0])
                except Exception:
                    pass
        _BUF_BY_ID[-1] = None
    return _BUF_BY_ID.get(sid)


INLINE = None          # predicate(name) -> bool; set by tools that want call sites replaced by the callee's formula
INLINE_DEPTH = 3
_INL = {}


def subst(e, m, recv, cls):
    if not isinstance(e, tuple): return e
    if e == ("this",): return recv
    if e[0] == "arg": return m.get(e[1], e)
    if e[0] == "f":
        if recv == ("this",): return e
        ty = next((t for t, n in FT.get(cls, {}).values() if n == e[1]), None) if cls else None
        return ("fld", recv, f"{cls}.{e[1]}", ty)
    return tuple(subst(x, m, recv, cls) if isinstance(x, tuple) else x for x in e)


def piecewise(pieces):
    """[(condx list, value)] from mutually exclusive, exhaustive paths -> nested sel"""
    expr = pieces[-1][1]
    for cx, v in reversed(pieces[:-1]):
        if v == expr: continue
        expr = ("sel", ("and", *cx) if len(cx) != 1 else cx[0], v, expr) if cx else v
    return expr


class Ex:
    def __init__(self, rva, cls_extra=(), max_paths=200, max_ins=6000, depth=0):
        self.depth = depth
        self.rva = rva
        self.fname = names.get(rva, hex(rva))
        self.cls = self.fname.split("$$")[0] if "$$" in self.fname else None
        self.extra = list(cls_extra) + ["PlayerActionManagerBase", "CharacterActionManagerBase", "IPlayerStatusCalculator",
                                        "MobActionManagerBase", "PlayerAttackBase", "SkillActionBase"]
        i = bisect.bisect_right(starts, rva)
        self.end = min(starts[i] if i < len(starts) else rva + 0x400, rva + 0x8000)
        self.ins = {}
        for x in md.disasm(b[rva - OFF:self.end - OFF], rva):
            self.ins[x.address] = x
        self.max_paths, self.max_ins = max_paths, max_ins
        self.done = []
        self.static, self.params = D2.SIG.get(rva, (False, []))

    # ---- value helpers
    def get(self, st, r):
        k = rk(r)
        if k is None: return 0
        return st.R.get(k, ("opaque", k))

    def put(self, st, r, v, w=False):
        k = rk(r)
        if k is None: return
        if w and is_num(v) and isinstance(v, int): v &= 0xffffffff
        st.R[k] = v

    def imm(self, s):
        return int(s.strip().lstrip("#"), 0)

    def mem(self, st, op):
        """parse memory operand -> (base_expr, offset_or_expr, writeback, post)"""
        m = re.match(r"\[(\w+)(?:, (#-?0x[0-9a-f]+|#-?\d+))?\](!)?(?:, (#-?0x[0-9a-f]+|#-?\d+))?$", op.strip())
        if m:
            base, off, wb, post = m.groups()
            o = self.imm(off) if off else 0
            p = self.imm(post) if post else None
            return base, o, bool(wb), p
        m = re.match(r"\[(\w+), (\w+)(?:, (?:lsl|sxtw|uxtw) #(\d+))?\]", op.strip())
        if m:
            return m.group(1), ("idx", m.group(2), m.group(3)), False, None
        return None

    def load(self, st, base_r, off, size_hint=None):
        b_ = self.get(st, base_r)
        if rk(base_r) == "sp":
            return st.stack.get(st.sp + off, ("opaque", "stack"))
        if isinstance(b_, tuple) and b_[0] == "+" and b_[1] == ("this",) and is_num(b_[2]) and isinstance(off, int):
            b_, off = ("this",), off + int(b_[2])                # `[(this + c) + off]`: a field of this reached through a computed pointer
        if isinstance(b_, tuple) and b_[0] == "vtab" and off == 0xc8:
            return ("hier", b_[1])                               # klass->typeHierarchy of obj
        if not isinstance(off, int):
            # `ldr s, [this, xN]` where xN = csel of field offsets (e.g. isFirst ? 0x124 : 0x12c) -> ternary of fields
            iv = self.get(st, off[1])
            if b_ == ("this",) and not off[2]:
                def pick(v):
                    # only offsets that name a field of the analysed class (inherited helpers stay opaque: avoids path blow-up)
                    if isinstance(v, int): return self.load(st, base_r, v) if self.cls and D2.field(self.cls, v) else None
                    if isinstance(v, tuple) and v[0] == "sel":
                        a, c = pick(v[2]), pick(v[3])
                        return None if a is None or c is None else ("sel", v[1], a, c)
                    return None
                got = pick(iv)
                if got is not None: return got
            # `ldr w, [arr, xN, lsl #k]` on a T[] field: element (xN - 0x20 >> k) of `field[...]`
            if isinstance(b_, tuple) and b_[0] == "f" and off[2] and is_num(iv):
                es = 1 << int(off[2])
                return ("f", f"{b_[1]}[{iv - 0x20 // es}]")
            return ("opaque", "idx")
        if isinstance(b_, tuple) and b_[0] == "stkp":
            return st.stack.get(b_[1] + off, ("opaque", "stackp"))
        if b_ == ("this",):
            if off == 0: return ("vtab", "this")
            if off in st.fields: return st.fields[off]
            nm = D2.field(self.cls, off) if self.cls else None
            return ("f", nm.split(".", 1)[1] if nm else self.subname(off))
        if isinstance(b_, tuple) and b_[0] == "+" and isinstance(b_[1], tuple) and b_[1][0] == "new" and is_num(b_[2]) and isinstance(off, int):
            b_, off = b_[1], off + int(b_[2])
        if isinstance(b_, tuple) and b_[0] == "new" and isinstance(off, int):
            if off == 0: return ("vtab", b_)
            if (b_[2], off) in st.heap: return st.heap[(b_[2], off)]
            fty, fnm = ftype(b_[1], off)
            if fnm: return ("fld", b_, f"{b_[1]}.{fnm}", fty)
        if isinstance(b_, tuple) and b_[0] == "meta" and len(b_) > 2 and off == 0xb8 and str(b_[2]).endswith("_TypeInfo"):
            return ("statics", str(b_[2])[:-9])                 # Il2CppClass.static_fields
        if isinstance(b_, tuple) and b_[0] == "statics" and isinstance(off, int):
            ty, nm = next(((t, n) for c in D2.chain(b_[1]) for o, (t, n) in FS.get(c, {}).items() if o == off), (None, None))
            return ("sfld", f"{b_[1]}.{nm}" if nm else f"{b_[1]}.static+{off:#x}", None, ty)
        if isinstance(b_, tuple) and b_[0] == "meta" and len(b_) > 2 and off == 0:
            return b_
        if isinstance(b_, tuple) and b_[0] == "vtab" and isinstance(off, int) and off >= 0x138 and (off - 0x138) % 16 == 0:
            return ("vfn", b_[1], (off - 0x138) // 16)      # `ldr x9, [vtab, #0x138+16n]` (plain ldr form of the virtual-call idiom)
        if isinstance(b_, tuple) and b_[0] in ("vtab", "meta"):
            return ("meta", 0)
        if isinstance(b_, tuple) and b_[0] == "adrp":
            a = b_[1] + off
            if a < RODATA_MAX:
                return ("rod", a)
            t = D2.D.RELA.get(a, a)
            nm = D2.D.meta.get(a) or D2.D.metam.get(a) or D2.D.meta.get(t) or D2.D.metam.get(t) or ""
            return ("meta", a, nm)
            pass
        if (isinstance(b_, tuple) and b_[0] == "+" and isinstance(b_[1], tuple) and b_[1][0] in ("f", "fld") and isinstance(b_[2], tuple)
                and b_[2][0] == "<<" and is_num(b_[2][2]) and isinstance(off, int) and off >= 0x20):
            r1 = self.raw_type(b_[1])
            if r1 and r1.endswith("[]"):
                es = 1 << int(b_[2][2])
                return ("idx", b_[1], E("+", b_[2][1], (off - 0x20) // es), r1[:-2])
        el = self.arr_elem(b_, off)
        if el is not None: return st.fields.get(el[1], el)   # value written earlier in this method, else the element name
        if off == 0 and isinstance(b_, tuple) and b_[0] in ("arg", "call", "f", "ld", "fld", "idx", "sfld"):
            return ("vtab", b_)
        r0 = self.raw_type(b_)
        if r0 and isinstance(off, int):
            if r0.endswith("[]") and off == 0x18: return ("fld", b_, "Array.Length", "int")
            if r0.startswith(("System.Collections.Generic.List", "List<")) and off in (0x10, 0x18):
                return ("fld", b_, "List._items" if off == 0x10 else "List.Count", "int" if off == 0x18 else None)
        t = self.rtype(b_)
        if t and isinstance(off, int):
            fty, fnm = ftype(t, off)
            if fnm: return ("fld", b_, f"{t}.{fnm}", fty)
        return ("ld", b_, off)

    _STRUCT = {"Vector3": ("x", "y", "z"), "UnityEngine.Vector3": ("x", "y", "z"), "Vector2": ("x", "y"), "UnityEngine.Vector2": ("x", "y"),
               "Quaternion": ("x", "y", "z", "w"), "UnityEngine.Quaternion": ("x", "y", "z", "w"), "Color": ("r", "g", "b", "a"),
               "UnityEngine.Color": ("r", "g", "b", "a")}

    def subname(self, off):
        """unnamed offset inside a struct-typed field of this (Vector3 ...) -> `field.y`; else the raw offset"""
        if self.cls:
            allf = {}
            for c in D2.chain(self.cls):
                for o, (ty, nm) in FT.get(c, {}).items(): allf.setdefault(o, (ty, nm))
            below = [o for o in allf if o < off]
            if below:                       # `[this+off]` inside the nearest preceding struct-typed field -> `field.member`
                base = max(below)
                ty, nm = allf[base]
                sc = D2.C.get(norm_type(ty) or "")
                if sc and sc["kind"] == "struct" and (off - base) in sc["fields"]: return f"{nm}.{sc['fields'][off - base]}"
            for k in range(1, 4):
                ty, nm = ftype(self.cls, off - 4 * k)
                if nm and ty in self._STRUCT and k < len(self._STRUCT[ty]): return f"{nm}.{self._STRUCT[ty][k]}"
        return f"+{off:#x}"

    def raw_type(self, e):
        """declared (unstripped) type of an object expression, for arrays / lists"""
        if not isinstance(e, tuple): return None
        if e[0] == "f" and self.cls: return next((t for t, n in FT.get(self.cls, {}).values() if n == e[1]), None)
        if e[0] == "fld" and len(e) > 3: return e[3]
        if e[0] == "call" and len(e) > 3 and isinstance(e[3], str): return e[3]
        return None

    def rtype(self, e):
        """static class of an object expression: call return type, argument type, field type"""
        if not isinstance(e, tuple): return None
        if e[0] in ("call", "fld", "recv", "idx") and len(e) > 3 and isinstance(e[3], str): return norm_type(e[3])
        if e[0] == "recv": return e[2]
        if e[0] == "arg": return next((norm_type(t) for t, n in self.params if n == e[1]), None)
        if e[0] == "f" and self.cls:
            return next((norm_type(t) for t, n in FT.get(self.cls, {}).values() if n == e[1]), None)
        return None

    def arr_elem(self, b_, off):
        """`[arrField+0x20+k*es]` or `[(arrField + c)+off]` on a T[] field of this -> ("f", "name[k]")"""
        if not (self.cls and isinstance(b_, tuple)): return None
        if b_[0] == "+" and isinstance(b_[1], tuple) and b_[1][0] == "f" and is_num(b_[2]):
            b_, off = b_[1], off + b_[2]
        if b_[0] != "f" or off < 0x20: return None
        ty = next((t for t, n in FT.get(self.cls, {}).values() if n == b_[1]), None)
        if not ty or not ty.endswith("[]"): return None
        es = 8 if ty[:-2] in ("long", "double", "ulong") else 2 if ty[:-2] in ("short", "ushort") else 1 if ty[:-2] in ("byte", "sbyte", "bool") else 4
        return ("f", f"{b_[1]}[{(off - 0x20) // es}]")

    # ---- resolve callee
    def callee(self, addr):
        return names.get(addr, hex(addr))

    def run(self):
        st = St()
        st.R["x0"] = ("this",) if not self.static else ("opaque", "x0")
        xi, vi = (0 if self.static else 1), 0
        for ty, pn in self.params:
            if ty in ("float", "double"): st.R[f"v{vi}"] = ("arg", pn); vi += 1
            else: st.R[f"x{xi}"] = ("arg", pn); xi += 1
        st.R["sp"] = ("sp",)
        work = [(self.rva, st)]
        npaths = 0
        while work and npaths < self.max_paths:
            pc, st = work.pop()
            self.exec(pc, st, work)
            npaths += 1
        self.truncated = bool(work)
        return self.done

    def exec(self, pc, st, work):
        while True:
            st.n += 1
            if st.n > self.max_ins:
                st.ev.append(("truncated", pc)); self.done.append(st); return
            i = self.ins.get(pc)
            if i is None:
                self.done.append(st); return
            st.visits[pc] = st.visits.get(pc, 0) + 1
            if st.visits[pc] > 3:
                self.done.append(st); return
            r = self.step(i, st, work)
            if r == "end":
                self.done.append(st); return
            pc = r if isinstance(r, int) else pc + 4

    def flags(self, st, a, b_):
        st.fl = (a, b_)

    def fork(self, st, work, cc, target, pc):
        """branch on condition cc using st.fl; returns next pc"""
        if st.fl is None:
            return pc + 4
        a, b_ = st.fl
        hc = st.hier
        if hc is not None and cc in ("eq", "ne") and a == 0 and b_ == 0 and not self.scaffold_side(pc + 4 if cc == "eq" else target):
            meta = next((x for x in hc if isinstance(x, tuple) and x[0] == "meta" and len(x) > 2 and str(x[2]).endswith("_TypeInfo")), None)
            obj = self.find_hier(hc)
            if meta is not None and obj is not None:
                a, b_ = ("call", "IsInstanceOf", [obj, str(meta[2])[:-9]]), 1
        v = eval_cc(cc, a, b_)
        if v is True: return target
        if v is False: return pc + 4
        if boring(a) or boring(b_) or (isinstance(a, tuple) and a[0] in ("opaque", "rod", "meta", "ld") and not is_num(b_) is False and False):
            if self.scaffold_side(target): return pc + 4      # cast / type-check failure side (throw stub): stay on the success side
            return target if target > pc else pc + 4
        # feasibility pruning for  X eq k / X ne k  chains on the same expression
        if cc in ("eq", "ne") and is_num(b_) and not is_num(a):
            key = render(a)
            def feasible(kind):
                if kind == "eq":
                    if key in st.known and st.known[key] != b_: return False
                    if b_ in st.excl.get(key, ()): return False
                else:
                    if st.known.get(key) == b_: return False
                return True
            t_ok = feasible(cc)                      # branch taken
            f_ok = feasible("ne" if cc == "eq" else "eq")   # fall through
            def apply(state, kind):
                if kind == "eq": state.known[key] = b_
                else: state.excl.setdefault(key, set()).add(b_)
            if t_ok and not f_ok:
                apply(st, cc); return target
            if f_ok and not t_ok:
                apply(st, "ne" if cc == "eq" else "eq"); return pc + 4
        ns = st.copy()
        ns.cond.append(cond_str(cc, a, b_)); ns.condx.append(("cmp", cc, a, b_))
        st.cond.append(cond_str(CC_NEG[cc], a, b_)); st.condx.append(("cmp", CC_NEG[cc], a, b_))
        if cc in ("eq", "ne") and is_num(b_) and not is_num(a):
            key = render(a)
            (ns.known.__setitem__(key, b_) if cc == "eq" else ns.excl.setdefault(key, set()).add(b_))
            (st.known.__setitem__(key, b_) if cc == "ne" and False else None)
            if cc == "eq": st.excl.setdefault(key, set()).add(b_)
            else: st.known[key] = b_
        work.append((target, ns))
        return pc + 4

    def step(self, i, st, work):
        mn, op, pc = i.mnemonic, i.op_str, i.address
        o = [x.strip() for x in re.split(r",\s*(?![^\[]*\])", op)] if op else []
        W = o and o[0][0] == "w"

        def V(t):
            t = t.strip()
            if t.startswith("#"):
                return self.imm(t)
            return self.get(st, t)

        def FV(x):
            """scalar float operand: a packed vec -> lane 0; an int that is a float bit pattern -> float"""
            if isinstance(x, tuple) and x and x[0] == "vec": x = x[1]
            if isinstance(x, int) and not isinstance(x, bool) and abs(x) > 0x1000000: return f32(x)
            return x

        try:
            # ---- moves / constants
            if mn in ("mov", "movz") and len(o) == 2:
                if rk(o[1]) == "sp" and rk(o[0]) != "sp":
                    self.put(st, o[0], ("stkp", st.sp)); return pc + 4
                self.put(st, o[0], V(o[1]), W); return pc + 4
            if mn == "movk":
                v = self.get(st, o[0]); sh = int(o[2].split("#")[1]) if len(o) > 2 else 0
                if is_num(v): self.put(st, o[0], (int(v) & ~(0xffff << sh)) | (self.imm(o[1]) << sh), W)
                else: self.put(st, o[0], ("opaque", "movk"))
                return pc + 4
            if mn == "movi":
                self.put(st, o[0], self.imm(o[1]) if o[1].startswith("#") else ("opaque", "movi")); return pc + 4
            if mn == "fmov":
                if o[1].startswith("#"):
                    self.put(st, o[0], float(o[1][1:])); return pc + 4
                v = V(o[1])
                if o[0][0] == "d" and o[1][0] == "x":
                    self.put(st, o[0], struct.unpack("<d", struct.pack("<Q", v & 0xffffffffffffffff))[0] if is_num(v) else ("bits", v))
                elif o[0][0] in "sd" and o[1][0] in "wx":
                    self.put(st, o[0], f32(v) if is_num(v) else ("bits", v))
                elif o[1] in ("wzr", "xzr"):
                    self.put(st, o[0], 0.0)
                else:
                    self.put(st, o[0], v)
                return pc + 4
            if mn == "adrp":
                self.put(st, o[0], ("adrp", self.imm(o[1]))); return pc + 4
            if mn == "adr":
                self.put(st, o[0], ("opaque", "adr")); return pc + 4
            # ---- integer arithmetic
            if mn in ("add", "sub", "adds", "subs") and len(o) >= 3 and "." not in o[0]:
                a, c = V(o[1]), (V(o[2]) if not o[2].startswith("#") else self.imm(o[2]))
                if rk(o[1]) == "sp" and rk(o[0]) != "sp" and is_num(c):
                    self.put(st, o[0], ("stkp", st.sp + (c if mn.startswith("add") else -c))); return pc + 4
                if len(o) > 3 and "lsl" in o[3]: c = E("<<", c, int(o[3].split("#")[1]))
                if len(o) > 3 and ("asr" in o[3] or "lsr" in o[3]): c = E(">>", c, int(o[3].split("#")[1]))   # `add w8, w9, w8, asr #1`
                if len(o) > 3 and ("sxtw" in o[3] or "uxtw" in o[3]):
                    sh = int(o[3].split("#")[1]) if "#" in o[3] else 0
                    c = E("<<", c, sh) if sh else c
                if o[0] == "sp" or (rk(o[0]) == "sp"):
                    st.sp += -c if mn.startswith("sub") and is_num(c) else (c if is_num(c) else 0)
                    return pc + 4
                if isinstance(a, tuple) and a[0] == "adrp" and is_num(c):
                    self.put(st, o[0], ("adrp", a[1] + c) if mn.startswith("add") else ("opaque", "adrp-")); return pc + 4
                res = E("+" if mn.startswith("add") else "-", a, c)
                self.put(st, o[0], res, W)
                if mn.endswith("s"): self.flags(st, a, c) if mn == "subs" else self.flags(st, res, 0)
                return pc + 4
            if mn in ("mul", "mneg", "madd", "msub", "sdiv", "udiv", "and", "orr", "eor", "lsl", "lsr", "asr", "neg", "negs") and len(o) >= 2 and "." not in o[0]:
                if mn == "neg": self.put(st, o[0], E("neg", V(o[1])), W); return pc + 4
                a, c = V(o[1]), (V(o[2]) if len(o) > 2 else 0)
                if mn == "mneg": self.put(st, o[0], E("neg", E("*", a, c)), W); return pc + 4   # msub with xzr accumulator
                if mn in ("and", "orr", "eor") and len(o) > 3 and "#" in o[3]:   # shifted register operand
                    c = E("<<" if "lsl" in o[3] else ">>", c, int(o[3].split("#")[1]))
                if mn == "mul": res = E("*", a, c)
                elif mn == "madd": res = E("+", E("*", a, c), V(o[3]))
                elif mn == "msub": res = E("-", V(o[3]), E("*", a, c))
                elif mn in ("sdiv", "udiv"): res = E("idiv", a, c)
                elif mn == "and": res = E("&", a, c)
                elif mn == "orr": res = E("|", a, c)
                elif mn == "eor": res = E("^", a, c)
                elif mn == "lsl": res = E("<<", a, c)
                else: res = E(">>", a, c)
                self.put(st, o[0], res, W); return pc + 4
            if mn == "bic" and len(o) >= 3:
                a, c = V(o[1]), V(o[2])
                sh = o[3] if len(o) > 3 else ""
                if a == c and "asr #31" in sh: self.put(st, o[0], E("max", a, 0), W)
                elif is_num(a) and is_num(c): self.put(st, o[0], int(a) & ~int(c), W)
                else: self.put(st, o[0], ("bic", a, c)); 
                return pc + 4
            if mn in ("smull", "umull", "smulh", "umulh") and len(o) >= 3:
                self.put(st, o[0], ("mul64", V(o[1]), V(o[2]))); return pc + 4
            if mn in ("sxtw", "sxtb", "sxth", "uxtb", "uxth", "ubfx", "sbfx", "ubfiz", "bfi", "bfxil"):
                self.put(st, o[0], V(o[1]) if mn in ("sxtw", "sxtb", "sxth", "uxtb", "uxth") else ("opaque", mn), W); return pc + 4
            if mn == "cmp":
                a_, c_ = V(o[0]), (V(o[1]) if not o[1].startswith("#") else self.imm(o[1]))
                if boring(a_) and boring(c_): st.fl = (0, 0); st.hier = (a_, c_)   # class-token / hierarchy compares: "is instance" unless the other side is real code
                else: self.flags(st, a_, c_); st.hier = None
                return pc + 4
            if mn == "cmn": self.flags(st, V(o[0]), E("neg", V(o[1]))); return pc + 4
            if mn == "tst": st.fl = (E("&", V(o[0]), V(o[1])), 0); return pc + 4
            if mn == "ccmp": st.fl = (("opaque", "ccmp"), 0); return pc + 4
            if mn in ("csel", "csinc", "csinv", "csneg", "fcsel"):
                a, c, cc = V(o[1]), V(o[2]), o[3]
                if mn == "csinc": c = E("+", c, 1)
                if mn == "csneg": c = E("neg", c)
                self.put(st, o[0], self.sel(st, cc, a, c), W); return pc + 4
            if mn in ("cset", "cinc", "csetm"):
                cc = o[-1]
                if mn == "cset": self.put(st, o[0], self.sel(st, cc, 1, 0), W)
                elif mn == "csetm": self.put(st, o[0], self.sel(st, cc, -1, 0), W)
                else: self.put(st, o[0], self.sel(st, cc, E("+", V(o[1]), 1), V(o[1])), W)
                return pc + 4
            # ---- float
            if mn in ("ucvtf", "scvtf"):
                self.put(st, o[0], E("toF", V(o[1]))); return pc + 4
            if mn in ("fcvtzs", "fcvtzu", "fcvtms", "fcvtmu", "fcvtas", "fcvtns", "fcvtps"):
                x = V(o[1])
                self.put(st, o[0], E("trunc", x) if mn.startswith("fcvtz") else E("trunc", x), W); return pc + 4
            if mn == "dup" and "." in o[0]:
                lane = re.match(r"^v(\d+)\.\w\[(\d)\]$", o[1])
                if lane:
                    src = self.get(st, "v" + lane.group(1))
                    val = src[1 + int(lane.group(2))] if isinstance(src, tuple) and src[0] == "vec" else src
                else:
                    val = V(o[1])
                self.put(st, o[0], ("vec", val, val)); return pc + 4
            if mn in ("mul", "add", "sub", "fmul", "fadd", "fsub", "fdiv") and "." in o[0]:
                a, c = self.get(st, o[1]), self.get(st, o[2])
                if isinstance(a, tuple) and a[0] == "vec" and isinstance(c, tuple) and c[0] == "vec":
                    opn = {"mul": "*", "fmul": "*", "add": "+", "fadd": "+", "sub": "-", "fsub": "-", "fdiv": "/"}[mn]
                    fl = mn.startswith("f")
                    l0 = tuple(f32(x) if (fl and isinstance(x, int) and x > 0x1000000) else x for x in (a[1], c[1]))
                    l1 = tuple(f32(x) if (fl and isinstance(x, int) and x > 0x1000000) else x for x in (a[2], c[2]))
                    self.put(st, o[0], ("vec", E(opn, *l0), E(opn, *l1))); return pc + 4
                self.put(st, o[0], ("opaque", "vecop")); return pc + 4
            if mn in ("fadd", "fsub", "fmul", "fdiv", "fnmul"):
                a, c = FV(V(o[1])), FV(V(o[2]))
                res = E({"fadd": "+", "fsub": "-", "fmul": "*", "fdiv": "/", "fnmul": "*"}[mn], a, c)
                if mn == "fnmul": res = E("neg", res)
                self.put(st, o[0], res); return pc + 4
            if mn in ("fmadd", "fmsub", "fnmadd", "fnmsub"):
                a, c, d = FV(V(o[1])), FV(V(o[2])), FV(V(o[3]))
                p = E("*", a, c)
                res = {"fmadd": E("+", d, p), "fmsub": E("-", d, p), "fnmadd": E("neg", E("+", d, p)), "fnmsub": E("-", p, d)}[mn]
                self.put(st, o[0], res); return pc + 4
            if mn in ("fneg",): self.put(st, o[0], E("neg", V(o[1]))); return pc + 4
            if mn in ("fabs",): self.put(st, o[0], E("abs", V(o[1]))); return pc + 4
            if mn in ("fmin", "fminnm", "fmax", "fmaxnm"):
                self.put(st, o[0], E("min" if "min" in mn else "max", FV(V(o[1])), FV(V(o[2])))); return pc + 4
            if mn in ("fsqrt", "frintm", "frintp", "frintz", "frinta", "fcvt", "frintx", "frinti", "frintn"):
                self.put(st, o[0], (mn, V(o[1]))); return pc + 4
            if mn in ("fcmp", "fcmpe"):
                self.flags(st, FV(V(o[0])), FV(V(o[1])) if not o[1].startswith("#") else 0.0); return pc + 4
            # ---- memory
            if mn in ("ldr", "ldrb", "ldrh", "ldrsw", "ldrsb", "ldrsh", "ldur", "ldurb", "ldurh", "ldursw"):
                mm = self.mem(st, o[1] if len(o) == 2 else ", ".join(o[1:]))
                if mm is None:
                    self.put(st, o[0], ("opaque", "ldr?")); return pc + 4
                base, off, wb, post = mm
                # literal / rodata load
                bv = self.get(st, base)
                val = self.load(st, base, off)
                if isinstance(val, tuple) and val[0] == "rod":
                    a = val[1]
                    if o[0][0] == "s": val = struct.unpack_from("<f", b, a)[0]
                    elif o[0][0] == "w": val = struct.unpack_from("<I", b, a)[0]
                    elif o[0][0] == "d": val = ("vec",) + struct.unpack_from("<II", b, a)
                    else: val = struct.unpack_from("<Q", b, a)[0]
                elif o[0][0] == "d" and bv == ("this",) and isinstance(off, int) and off > 0:
                    val = ("vec", self.load(st, base, off), self.load(st, base, off + 4))
                    for _k in (1, 2):   # float field values live as python floats already; ints written as bits stay ints
                        pass
                self.put(st, o[0], val, o[0][0] == "w")
                if base != "sp" and post is not None: self.put(st, base, E("+", bv, post))
                if wb and rk(base) != "sp" and is_num(off) and base != o[0]: self.put(st, base, E("+", bv, off))   # pre-index `[xN, #off]!`
                if rk(base) == "sp":
                    if wb: st.sp += off
                    if post is not None: st.sp += post
                return pc + 4
            if mn in ("ldp",):
                mm = self.mem(st, ", ".join(o[2:]))
                base, off, wb, post = mm
                bv = self.get(st, base)
                if rk(base) == "sp":
                    sz = 4 if o[0][0] in "ws" else 16 if o[0][0] == "q" else 8
                    self.put(st, o[0], st.stack.get(st.sp + off, ("opaque", "stk")))
                    self.put(st, o[1], st.stack.get(st.sp + off + sz, ("opaque", "stk")))
                    if wb: st.sp += off
                    if post is not None: st.sp += post
                    return pc + 4
                ifc = self.find_ifc(bv) if isinstance(bv, tuple) and off == 0 else None
                if ifc is not None:
                    ti = self.get(st, "x1")
                    tn = ti[2] if isinstance(ti, tuple) and ti[0] == "meta" and len(ti) > 2 else ""
                    tn = tn.replace("_TypeInfo", "")
                    self.put(st, o[0], ("vfn_ifc", tn, ifc)); self.put(st, o[1], ("opaque", "mi"))
                elif isinstance(bv, tuple) and bv[0] == "vtab" and isinstance(off, int) and off >= 0x138:
                    self.put(st, o[0], ("vfn", bv[1], (off - 0x138) // 16)); self.put(st, o[1], ("opaque", "mi"))
                else:
                    sz = 4 if o[0][0] in "ws" else 16 if o[0][0] == "q" else 8       # second register sits one register-width further
                    self.put(st, o[0], self.load(st, base, off))
                    self.put(st, o[1], self.load(st, base, off + sz) if isinstance(off, int) else ("opaque", "ldp"))
                return pc + 4
            if mn in ("str", "strb", "strh", "stur", "sturb", "sturh"):
                mm = self.mem(st, ", ".join(o[1:]))
                base, off, wb, post = mm
                val = V(o[0]) if o[0] not in ("wzr", "xzr") else 0
                if rk(base) == "sp":
                    st.stack[st.sp + (off if isinstance(off, int) else 0) - (0 if not wb else 0)] = val
                    if wb: st.sp += off
                    if post is not None:
                        st.stack[st.sp] = val; st.sp += post
                    return pc + 4
                bv = self.get(st, base)
                if isinstance(bv, tuple) and bv[0] == "+" and isinstance(bv[1], tuple) and bv[1][0] == "new" and is_num(bv[2]) and isinstance(off, int):
                    bv, off = bv[1], off + int(bv[2])                 # `[(new + c) + off]`
                if isinstance(bv, tuple) and bv[0] == "new" and isinstance(off, int):
                    st.heap[(bv[2], off)] = val
                    if wb: self.put(st, base, ("+", bv, off))
                    return pc + 4
                if bv == ("this",) and isinstance(off, int) and off > 0:
                    wide = o[0][0] in "xd" and mn == "str"
                    parts = [(off, val)]
                    if isinstance(val, tuple) and val[0] == "vec":
                        parts = [(off, val[1])] if o[0][0] == "s" else [(off, val[1]), (off + 4, val[2])]
                    elif wide and isinstance(val, int):
                        parts = [(off, val & 0xffffffff), (off + 4, (val >> 32) & 0xffffffff)]
                    for (of, vv) in parts:
                        ty, nm = ftype(self.cls, of) if self.cls else (None, None)
                        if nm is None:
                            nm = D2.field(self.cls, of) if self.cls else None
                            nm = nm.split(".", 1)[1] if nm else self.subname(of)
                        if ty in ("float", "System.Single") and isinstance(vv, int): vv = f32(vv)
                        if ty in ("int", "System.Int32", "uint", "byte", "short", "bool") and isinstance(vv, float) and o[0][0] not in "sd":
                            pass
                        if ty in ("int", "byte", "short", "ushort", "uint", "bool", "sbyte") and isinstance(vv, int) and vv > 0x7fffffff and ty == "int": vv -= 1 << 32
                        st.fields[of] = vv
                        st.ev.append(("set", nm, vv, list(st.cond)))
                    if wb and base != o[0]: self.put(st, base, E("+", bv, off))   # pre-index `str x1, [x20, #0x30]!`: x20 becomes this+0x30
                elif isinstance(bv, tuple) and bv[0] == "f" and isinstance(off, int) and off >= 0x20 and self.cls:
                    # element store into an array field of this: T[] data starts at +0x20
                    ty, _ = next(((t, n) for t, n in FT.get(self.cls, {}).values() if n == bv[1]), (None, None))
                    if ty and ty.endswith("[]"):
                        es = 8 if o[0][0] in "xd" else (1 if mn.endswith("b") else 2 if mn.endswith("h") else 4)
                        if ty.startswith("float") and isinstance(val, int): val = f32(val)
                        st.fields[f"{bv[1]}[{(off - 0x20) // es}]"] = val
                        st.ev.append(("set", f"{bv[1]}[{(off - 0x20) // es}]", val, list(st.cond)))
                return pc + 4
            if mn == "stp":
                mm = self.mem(st, ", ".join(o[2:]))
                base, off, wb, post = mm
                if rk(base) == "sp":
                    if wb: st.sp += off
                    if isinstance(off, int):
                        sz = 4 if o[0][0] in "ws" else 16 if o[0][0] == "q" else 8
                        st.stack[st.sp + (0 if wb else off)] = self.get(st, o[0]) if o[0] not in ("xzr", "wzr") else 0
                        st.stack[st.sp + (0 if wb else off) + sz] = self.get(st, o[1]) if o[1] not in ("xzr", "wzr") else 0
                    if post is not None: st.sp += post
                    return pc + 4
                bv = self.get(st, base)
                if isinstance(bv, tuple) and bv[0] == "new" and isinstance(off, int):
                    stp = 8 if o[0][0] == "x" else 4
                    for k, rname in enumerate(o[:2]):
                        st.heap[(bv[2], off + k * stp)] = self.get(st, rname) if rname not in ("xzr", "wzr") else 0
                    return pc + 4
                if bv == ("this",) and isinstance(off, int) and off > 0:
                    step = 8 if o[0][0] == "x" else 4
                    for k, rname in enumerate(o[:2]):
                        vv = self.get(st, rname) if rname not in ("wzr", "xzr") else 0
                        of = off + k * step
                        ty, nm = ftype(self.cls, of) if self.cls else (None, None)
                        if nm is None:
                            nm = D2.field(self.cls, of) if self.cls else None
                            nm = nm.split(".", 1)[1] if nm else self.subname(of)
                        if ty in ("float", "System.Single") and isinstance(vv, int): vv = f32(vv)
                        if ty == "int" and isinstance(vv, int) and vv > 0x7fffffff: vv -= 1 << 32
                        st.fields[of] = vv
                        st.ev.append(("set", nm, vv, list(st.cond)))
                return pc + 4
            # ---- branches
            if mn == "b":
                t = int(o[0][1:], 16)
                vn = self.veneer(t)
                if vn is not None:                  # linker range-extension veneer: `ldr xN, [...]; b back`
                    self.step(vn[0], st, work)
                    return vn[1]
                if t < self.rva or t >= self.end:   # tail call
                    self.call(st, t, tail=True)
                    st.ret = (self.get(st, "x0"), self.get(st, "v0"))      # `b callee`: the callee's result is ours
                    return "end"
                return t
            if mn.startswith("b."):
                return self.fork(st, work, mn[2:], int(o[0][1:], 16), pc)
            if mn in ("cbz", "cbnz"):
                t = int(o[1][1:], 16); v = self.get(st, o[0])
                if o[0][0] == "x" and not (isinstance(v, tuple) and v[0] == "call" and any(k in str(v[1]) for k in ("OrDefault", "Find", "TryGet"))):
                    return t if mn == "cbnz" else pc + 4       # pointer null-check: assume non-null
                if boring(v):
                    return t if mn == "cbnz" else pc + 4       # interface-table counts / runtime plumbing: assume non-zero
                st.fl = (v, 0)
                return self.fork(st, work, "eq" if mn == "cbz" else "ne", t, pc)
            if mn in ("tbz", "tbnz"):
                t = int(o[2][1:], 16); v = self.get(st, o[0]); bit = self.imm(o[1])
                if isinstance(v, tuple) and v[0] in ("meta", "opaque", "ld", "rod", "vtab"):
                    return t if mn == "tbnz" else pc + 4      # init flags / plumbing: assume set
                st.fl = (E("&", v, 1 << bit) if is_num(v) else ("&", v, 1 << bit), 0)
                return self.fork(st, work, "ne" if mn == "tbnz" else "eq", t, pc)
            if mn == "bl":
                self.call(st, int(o[0][1:], 16)); return pc + 4
            if mn == "blr":
                fn = self.get(st, o[0]); self.vcall(st, fn); return pc + 4
            if mn == "br":
                fn = self.get(st, o[0])
                if isinstance(fn, tuple) and fn[0] in ("vfn", "vfn_ifc"):       # tail-dispatched virtual / interface call
                    self.vcall(st, fn)
                    st.ret = (self.get(st, "x0"), self.get(st, "v0"))
                return "end"
            if mn == "ret":
                st.ret = (self.get(st, "x0"), self.get(st, "v0"))
                return "end"
            if mn in ("nop", "hint", "dmb", "prfm", "brk", "udf"): return pc + 4
            # unknown: destroy destination
            UNK[mn] = UNK.get(mn, 0) + 1
            if o and o[0][0] in "xwsdvqbh":
                self.put(st, o[0], ("opaque", mn))
            return pc + 4
        except Exception as ex:
            st.ev.append(("err", pc, mn, op, repr(ex)))
            return pc + 4

    STUBS = {0x165df00, 0x165da68, 0x165da6c, 0x165da70, 0x165da74, 0x165db84, 0x15d8578, 0x165db78}   # isinst, castclass, box/unbox, null-throw, itable resolve, new (0x165da64 = class init: real code follows)

    def scaffold_side(self, start):
        """True when the code at `start` is il2cpp cast / null-check scaffolding (calls a runtime stub within a few instructions)"""
        n = 0
        a = start
        while n < 8 and a in self.ins:
            i = self.ins[a]
            if i.mnemonic in ("bl", "b") and i.op_str.startswith("#"):
                if int(i.op_str[1:], 16) in self.STUBS: return True
                if i.mnemonic == "b": return False
            if i.mnemonic == "ret": return False
            a += 4; n += 1
        return False

    def find_hier(self, e):
        if isinstance(e, tuple):
            if e and e[0] == "hier": return e[1]
            for x in e:
                r = self.find_hier(x)
                if r is not None: return r
        return None

    def const_ret(self, a):
        ins = list(_md.disasm(b[a - OFF:a - OFF + 8], a))
        if len(ins) != 2 or ins[1].mnemonic != "ret" or ins[0].mnemonic not in ("mov", "fmov"): return None
        d, s = [x.strip() for x in ins[0].op_str.split(",", 1)]
        if d not in ("w0", "x0", "s0"): return None
        if s in ("wzr", "xzr"): return 0.0 if d == "s0" else 0
        if s.startswith("#"):
            try: return float(s[1:]) if ins[0].mnemonic == "fmov" else int(s[1:], 0)
            except ValueError: return None
        return None

    def veneer(self, t):
        if t in names or (self.rva <= t < self.end): return None
        ins = list(_md.disasm(b[t - OFF:t - OFF + 8], t))
        if len(ins) == 2 and ins[0].mnemonic in ("ldr", "adrp", "add", "mov") and ins[1].mnemonic == "b":
            back = int(ins[1].op_str[1:], 16)
            if self.rva <= back < self.end: return ins[0], back
        return None

    def find_ifc(self, e):
        """expression (vt + ((ld + N) << 4)) + 0x138 built by the interface-dispatch idiom -> N"""
        def walk(x):
            if isinstance(x, tuple):
                if x[0] == "<<" and len(x) == 3 and x[2] == 4 and isinstance(x[1], tuple) and x[1][0] == "+" and is_num(x[1][2]):
                    return x[1][2]
                if x[0] == "<<" and len(x) == 3 and x[2] == 4 and isinstance(x[1], tuple) and x[1][0] == "ld":
                    return 0                       # `mov w2, wzr` : interface slot 0 (the `+0` folds away)
                for y in x[1:]:
                    r = walk(y)
                    if r is not None: return r
            return None
        return walk(e) if isinstance(e, tuple) and e[0] == "+" and e[2] == 0x138 else None

    def sel(self, st, cc, a, c):
        if st.fl is None: return ("opaque", "sel")
        if st.fl[1] == float("inf") and cc == "eq": return c
        v = eval_cc(cc, *st.fl)
        if v is True: return a
        if v is False: return c
        return ("sel", ("cmp", cc, st.fl[0], st.fl[1]), a, c)

    def arg(self, st, k, kind="x"):
        return self.get(st, f"{kind}{k}")

    WB_SET_FIELD = il2.stub("wb_set_field")      # il2cpp GC write barrier: (ptr to field, value) == `obj.field = value`

    NEW_OBJ = il2.stub("object_new")            # il2cpp object-new thunk: x0 = Il2CppClass slot

    def call(self, st, addr, tail=False):
        if addr == self.NEW_OBJ:
            k = self.get(st, "x0")
            cn = str(k[2])[:-9] if isinstance(k, tuple) and k[0] == "meta" and len(k) > 2 and str(k[2]).endswith("_TypeInfo") else None
            if cn:
                st.n += 0
                Ex._serial = getattr(Ex, "_serial", 0) + 1
                self.put(st, "x0", ("new", cn, Ex._serial)); self.put(st, "v0", ("new", cn, Ex._serial))
                for k2 in range(1, 8): st.R.pop(f"x{k2}", None)
                return
        if addr == self.WB_SET_FIELD:
            ptr, val = self.get(st, "x0"), self.get(st, "x1")
            if isinstance(ptr, tuple) and ptr[0] == "+" and isinstance(ptr[1], tuple) and ptr[1][0] == "new" and is_num(ptr[2]):
                st.heap[(ptr[1][2], int(ptr[2]))] = val
                return
            if isinstance(ptr, tuple) and ptr[0] == "+" and ptr[1] == ("this",) and is_num(ptr[2]) and self.cls:
                of = int(ptr[2])
                ty, nm = ftype(self.cls, of)
                nm = nm or self.subname(of)
                st.fields[of] = val
                st.ev.append(("set", nm, val, list(st.cond)))
                return
        if addr == 0x165da68:                # il2cpp isinst(obj, class): `obj as T`
            r = ("call", "isinst", [self.get(st, "x0"), self.get(st, "x1")])
            self.put(st, "x0", r); self.put(st, "v0", r)
            for k in range(1, 8): st.R.pop(f"x{k}", None)
            return
        nm = self.callee(addr)
        short = nm.split("$$")[-1]
        cls = nm.split("$$")[0] if "$$" in nm else ""
        if cls == "SkillCalcTemplate" and short in TPL:
            step = self.get(st, "x1")
            val = self.get(st, "v0")
            sname = STEP.get(step, step)
            st.ev.append(("tpl", short, sname, val, list(st.cond)))
            self.put(st, "x0", ("this_tpl",)); return
        if nm in ("UnityEngine.Object$$op_Inequality", "UnityEngine.Object$$op_Equality"):
            ua, ub = self.get(st, "x0"), self.get(st, "x1")
            if isinstance(ua, int) and isinstance(ub, int):       # `null != null` on a path where the object is the constant 0: fold, so the dead branch is not explored
                r = int((ua != ub) if nm.endswith("Inequality") else (ua == ub))
                self.put(st, "x0", r)
                for k in range(1, 8): st.R.pop(f"x{k}", None)
                return
        if INLINE and self.depth < INLINE_DEPTH and INLINE(nm) and not nm.startswith("SkillCalcTemplate"):
            r = self.try_inline(st, addr, nm)
            if r is not None:
                st.ev.append(("inl", nm))
                self.put(st, "x0", r); self.put(st, "v0", r)
                for k in range(1, 8): st.R.pop(f"x{k}", None)
                return
        cv = self.const_ret(addr)
        if cv is not None:                   # `mov w0, wzr; ret` style stub (several names share it): the call is that constant
            self.put(st, "x0", cv); self.put(st, "v0", cv)
            for k in range(1, 8): st.R.pop(f"x{k}", None)
            return
        args = [self.get(st, f"x{k}") for k in range(1, 5)]
        fargs = [self.get(st, f"v{k}") for k in range(0, 3)]
        mi = next((a for a in args if isinstance(a, tuple) and a[0] == "meta" and len(a) > 2), None)
        tv = re.search(r"<[^<>]+, ([^<>]+)>\.TryGetValue", mi[2]) if mi and short == "TryGetValue" else None
        tg = re.search(r"\.(?:TryGetBuf|TryGetEquipBuffer|TryGetBuff|TryGetBuffer)<(\w+)>\(\)", mi[2]) if mi else None
        outty = tv.group(1) if tv else (tg.group(1) if tg else None)
        if outty in ("SkillBufferDataBase", "object") and args and is_num(args[0]) and short in ("TryGetValue", "TryGetBuf"):
            outty = buf_class(int(args[0])) or outty    # constant skill id -> the buffer class registered for it
        regname, rtyp = {}, {}
        sig = D2.SIG.get(addr)
        if sig:
            xi = 0 if sig[0] else 1
            for ty, pn in sig[1]:
                if ty not in ("float", "double"): regname[xi] = pn; rtyp[xi] = ty; xi += 1
        x0v = self.get(st, "x0")
        keyty = re.search(r"<(\w+), [^<>]+>\.TryGetValue", mi[2]).group(1) if (mi and short == "TryGetValue" and re.search(r"<(\w+), [^<>]+>\.TryGetValue", mi[2])) else None

        def outnode(k):
            oname = f"{short}.{regname[k + 1]}" if (k + 1) in regname and re.fullmatch(r"\w+", regname[k + 1]) else f"{short}.out{k + 1}"
            if short == "TryGetValue" and k == 1 and args:             # dict.TryGetValue(key, out v): v is `dict[key]`
                key = args[0]
                if NAME_ENUMS and keyty and is_num(key) and D2.C.get(keyty, {}).get("kind") == "enum" and int(key) in D2.C[keyty]["consts"]: key = ("enum", keyty, int(key))
                return ("idx", x0v, key, outty)
            oargs = [v for v in self.actuals(st, addr, args, fargs) if not (isinstance(v, tuple) and v[0] in ("stkp", "meta"))][:3]
            while oargs and isinstance(oargs[-1], tuple) and oargs[-1][0] == "opaque" and re.fullmatch(r"x\d", str(oargs[-1][1])): oargs.pop()   # trailing unset arg register = hidden MethodInfo*
            oty = outty or (rtyp.get(k + 1) if rtyp.get(k + 1) in D2.C else None)   # declared class of a non-generic out param
            return ("call", oname, oargs, oty) if oty else ("call", oname, oargs)

        for k, av in enumerate(args):
            if isinstance(av, tuple) and av[0] == "+" and av[1] == ("this",) and is_num(av[2]):
                st.fields[int(av[2])] = outnode(k)
            if isinstance(av, tuple) and av[0] == "stkp":
                st.stack[av[1]] = outnode(k)
        vals = self.actuals(st, addr, args, fargs)
        ret = ("call", short if not cls else f"{cls}.{short}", vals[:4])
        gmi = next((a for a in [x0v] + args if isinstance(a, tuple) and a[0] == "meta" and len(a) > 2 and str(a[2]).startswith("Method$")), None)
        if gmi is not None and "<object>" in ret[1]:     # shared generic: the real instantiation is the MethodInfo argument
            gn = str(gmi[2])[len("Method$"):]
            ret = ("call", gn[:-2] if gn.endswith("()") else gn, [v for v in vals[:4] if not (isinstance(v, tuple) and v[0] in ("meta", "opaque"))])
        rt = norm_type(D2.RET.get(addr))
        if rt: ret = ret + (rt,)
        if addr in MATH_FP: ret = ("call", ret[1], fargs[:2])
        st.ev.append(("call", nm, vals, fargs, list(st.cond), addr))
        self.put(st, "x0", ret); self.put(st, "v0", ret)
        if D2.RET.get(addr) in ("Vector3", "UnityEngine.Vector3", "Vector2", "UnityEngine.Vector2"):
            for i, c in enumerate(("x", "y", "z")[:3 if "3" in D2.RET[addr] else 2]):
                self.put(st, f"v{i}", ("fld", ret, f"Vector.{c}", "float"))
        for k in range(1, 8): st.R.pop(f"x{k}", None)

    def actuals(self, st, addr, args, fargs):
        """argument expressions of a call as the callee declares them (receiver first for instance methods);
        unknown signature: x0 + x1..x4 as before"""
        sig = D2.SIG.get(addr)
        if not sig: return [self.get(st, "x0")] + args
        static, params = sig
        out = [] if static else [self.get(st, "x0")]
        xi, vi = (0 if static else 1), 0
        for ty, pn in params:
            if ty in ("float", "double"): out.append(self.get(st, f"v{vi}")); vi += 1
            else:
                v = self.get(st, f"x{xi}"); xi += 1
                ty = ENUM_BY_PARAM.get((names.get(addr, "").split("$$")[-1], pn), ty)
                if NAME_ENUMS and isinstance(v, int) and D2.C.get(ty, {}).get("kind") == "enum" and v in D2.C[ty]["consts"]:
                    v = ("enum", ty, v)
                out.append(v)
        return out

    def try_inline(self, st, addr, nm):
        tpl = _INL.get(addr)
        if tpl is None:
            sub = Ex(addr, max_paths=48, max_ins=6000, depth=self.depth + 1)
            paths = sub.run()
            rt = D2.RET.get(addr)
            ok = paths and not sub.truncated and all(p.ret is not None and not any(e[0] in ("truncated", "err") for e in p.ev) for p in paths)
            if ok:
                fl = rt in ("float", "double", "System.Single", "System.Double")
                tpl = (piecewise([(p.condx, p.ret[1] if fl else p.ret[0]) for p in paths]), sub.params, sub.static, sub.cls)
            else: tpl = False
            _INL[addr] = tpl
        if not tpl: return None
        expr, params, static, cls = tpl
        m, xi, vi = {}, (0 if static else 1), 0
        for ty, pn in params:
            if ty in ("float", "double"): m[pn] = self.get(st, f"v{vi}"); vi += 1
            else: m[pn] = self.get(st, f"x{xi}"); xi += 1
        return subst(expr, m, ("this",) if static else self.get(st, "x0"), cls)

    def vcall(self, st, fn):
        if isinstance(fn, tuple) and fn[0] == "vfn":
            obj, slot = fn[1], fn[2]
            cands = []
            own = []
            if obj == "this" and self.cls: own = [self.cls]
            elif isinstance(obj, tuple) and obj[0] == "arg":
                own = [ty for (ty, pn) in self.params if pn == obj[1]]
            elif isinstance(obj, tuple) and obj[0] == "call" and obj[1] == "isinst" and len(obj) > 2 and len(obj[2]) > 1 \
                    and isinstance(obj[2][1], tuple) and len(obj[2][1]) > 2 and str(obj[2][1][2]).endswith("_TypeInfo"):
                own = [str(obj[2][1][2])[:-9]]          # `obj as T`: the receiver is a T
            elif isinstance(obj, tuple) and obj[0] == "call":
                own = [obj[3]] if len(obj) > 3 else []
            elif isinstance(obj, tuple) and self.rtype(obj):
                own = [self.rtype(obj)]
            for c in own + self.extra:
                s = D2.slot(c, slot)
                if s and s not in cands: cands.append(s)
            # receiver class known but unrelated to every fallback class (e.g. a buff object): the fallback classes' slot of the same number is a different method
            typed_miss = bool(own) and not any(D2.slot(c, slot) for c in own) and not any(oc in D2.chain(e) or e in D2.chain(oc) for oc in own for e in self.extra)
            unknown_recv = not own and (obj == ("opaque", "blr") or (isinstance(obj, tuple) and (obj[0] == "opaque" or (obj[0] == "call" and "TryGet" in str(obj[1])))))
            nm = f"{own[0]}.vslot{slot}" if typed_miss else (f"vslot{slot}" if unknown_recv else (cands[0] if cands else f"vslot{slot}"))
            a1 = self.get(st, "x1")
            vargs = []
            if nm == "SkillMasteryBase.GetMasteryParam" and isinstance(a1, int): vargs = [mastery_id(a1)]
            if MASTERY_RECV and nm.startswith("EquipItemData.WeaponTypeCalculatorBase."):
                recv = self.get(st, "x0")          # abstract calculator method called from outside the class: the receiver picks the concrete weapon class (`mainWeaponCalculator` ...)
                if recv != ("this",): vargs.insert(0, recv)
            if MASTERY_RECV and nm == "SkillMasteryBase.GetMasteryParam" and vargs:
                recv = self.get(st, "x0")
                if isinstance(recv, tuple) and recv and recv[0] == "idx": vargs.append(recv)
            elif not typed_miss and not unknown_recv:   # arguments as the virtual method declares them (receiver omitted, like before)
                sp = next((D2.slot_params(c, slot) for c in own + self.extra if D2.slot(c, slot)), None)
                xi, vi = 1, 0
                for ty, _pn in (sp or []):
                    if ty in ("float", "double"): vargs.append(self.get(st, f"v{vi}")); vi += 1
                    else: vargs.append(self.get(st, f"x{xi}")); xi += 1
            ret = ("call", nm, vargs)
            rt = None if (typed_miss or unknown_recv) else next((norm_type(D2.slot_ret(c, slot)) for c in own + self.extra if D2.slot(c, slot)), None)
            if rt: ret = ret + (rt,)
            st.ev.append(("call", "virtual " + nm, [], [], list(st.cond)))
            self.put(st, "x0", ret); self.put(st, "v0", ret)
        elif isinstance(fn, tuple) and fn[0] == "vfn_ifc":
            iface, n = fn[1], fn[2]
            meths = D2.C.get(iface, {}).get("imethods", [])
            nm = f"{iface}.{meths[n]}" if 0 <= n < len(meths) else f"{iface}#{n}"
            ret = ("call", nm, [self.get(st, "x0")])
            rt = norm_type(D2.C.get(iface, {}).get("rets", {}).get(n))
            if rt: ret = ret + (rt,)
            st.ev.append(("call", "interface " + nm, [self.get(st, "x0")], [], list(st.cond)))
            self.put(st, "x0", ret); self.put(st, "v0", ret)
        elif isinstance(fn, tuple) and fn[0] == "ld" and len(fn) > 2 and fn[2] == 8 and isinstance(fn[1], tuple) and fn[1][0] == "call" and fn[1][1] == "0x165da60":
            # il2cpp generic virtual method: gvm = resolver(slot, MethodInfo); blr [gvm+8](receiver, args..., out*, gvm)
            mi = next((a for a in fn[1][2] if isinstance(a, tuple) and a[0] == "meta" and len(a) > 2 and str(a[2]).startswith("Method$")), None)
            gname = str(mi[2])[len("Method$"):] if mi else "genericVirtual"
            if gname.endswith("()"): gname = gname[:-2]
            a1, a2 = self.get(st, "x1"), self.get(st, "x2")
            gm = re.search(r"<([^<>]+)>$", gname)
            if isinstance(a2, tuple) and a2[0] == "stkp":
                st.stack[a2[1]] = ("call", gname + ".out2", [a1], gm.group(1)) if gm else ("call", gname + ".out2", [a1])
            ret = ("call", gname, [a1])
            st.ev.append(("call", "virtual " + gname, [], [], list(st.cond)))
            self.put(st, "x0", ret); self.put(st, "v0", ret)
        elif isinstance(fn, tuple) and fn[0] == "ld" and len(fn) > 2 and fn[2] == 0x18:
            # delegate invocation: blr [delegate+0x18]
            dargs = [fn[1]] + [a for a in (self.get(st, "x1"), self.get(st, "x2")) if not (isinstance(a, tuple) and a[0] in ("opaque", "meta"))]
            ret = ("call", "invoke", dargs)
            st.ev.append(("call", "delegate invoke", [], [], list(st.cond)))
            self.put(st, "x0", ret); self.put(st, "v0", ret)
        else:
            self.put(st, "x0", ("opaque", "blr")); self.put(st, "v0", ("opaque", "blr"))



class MergeEx(Ex):
    """Forward-merging executor: states reaching the same pc are joined (registers/stack/fields become `sel` nodes), so
    independent branches no longer multiply the path count. Back-edges follow the usual 3-visit bound."""

    def run(self):
        st = St()
        st.R["x0"] = ("this",) if not self.static else ("opaque", "x0")
        xi, vi = (0 if self.static else 1), 0
        for ty, pn in self.params:
            if ty in ("float", "double"): st.R[f"v{vi}"] = ("arg", pn); vi += 1
            else: st.R[f"x{xi}"] = ("arg", pn); xi += 1
        st.R["sp"] = ("sp",)
        pend = {self.rva: [st]}
        budget = self.max_ins * 12
        self.truncated = False
        while pend:
            pc = min(pend)
            st = self.merge(pend.pop(pc))
            while True:
                budget -= 1
                st.n += 1
                if budget < 0 or st.n > self.max_ins:
                    st.ev.append(("truncated", pc)); self.truncated = True; self.done.append(st); break
                i = self.ins.get(pc)
                if i is None: self.done.append(st); break
                st.visits[pc] = st.visits.get(pc, 0) + 1
                if st.visits[pc] > 3: self.done.append(st); break
                work = []
                r = self.step(i, st, work)
                for t, ns in work: pend.setdefault(t, []).append(ns)
                if r == "end": self.done.append(st); break
                nxt = r if isinstance(r, int) else pc + 4
                if nxt in pend or nxt < pc:
                    pend.setdefault(nxt, []).append(st); break
                pc = nxt
            if len(self.done) > self.max_paths: self.truncated = True; break
        return self.done

    @staticmethod
    def _chain(items):
        """items: [(residual condx list, value)] -> value or nested sel (equal values share one condition)"""
        distinct = []
        for rc, v in items:
            for d in distinct:
                if d[1] == v: d[0].append(rc); break
            else: distinct.append([[rc], v])
        if len(distinct) == 1: return distinct[0][1]
        expr = distinct[-1][1]
        for rcs, v in reversed(distinct[:-1]):
            ors = [("and", *rc) if len(rc) != 1 else rc[0] for rc in rcs if rc]
            if len(ors) != len(rcs): continue          # one of the groups is unconditional: v wins nowhere distinct
            c = ors[0] if len(ors) == 1 else ("or", *ors)
            expr = ("sel", c, v, expr)
        return expr

    def merge(self, grp):
        if len(grp) == 1: return grp[0]
        k = 0
        while all(len(g.condx) > k for g in grp) and all(g.condx[k] == grp[0].condx[k] for g in grp): k += 1
        res = St()
        res.cond, res.condx = list(grp[0].cond[:k]), list(grp[0].condx[:k])
        resid = [g.condx[k:] for g in grp]
        for attr in ("R", "stack", "fields", "heap"):
            keys = set().union(*(getattr(g, attr).keys() for g in grp))
            out = {}
            for key in keys:
                vals = [getattr(g, attr).get(key, ("opaque", "undef")) for g in grp]
                out[key] = vals[0] if all(v == vals[0] for v in vals) else self._chain(list(zip(resid, vals)))
            setattr(res, attr, out)
        j = 0
        while all(len(g.ev) > j for g in grp) and all(g.ev[j] == grp[0].ev[j] for g in grp): j += 1
        res.ev = list(grp[0].ev[:j])
        for g in grp:
            for e in g.ev[j:]:
                if e not in res.ev: res.ev.append(e)
        res.sp = grp[0].sp
        res.fl = grp[0].fl if all(g.fl == grp[0].fl for g in grp) else None
        res.visits = {p: max(g.visits.get(p, 0) for g in grp) for p in set().union(*(g.visits for g in grp))}
        res.n = max(g.n for g in grp)
        res.known = {a: b for a, b in grp[0].known.items() if all(g.known.get(a) == b for g in grp)}
        res.excl = {}
        return res


def summarize(ex, paths):
    out = []
    for st in paths:
        sets = [(n, render(v), c) for (k, n, v, c) in [e for e in st.ev if e[0] == "set"]]
        tpl = [(f, s, render(v), c) for (k, f, s, v, c) in [e for e in st.ev if e[0] == "tpl"]]
        out.append({"cond": st.cond, "sets": sets, "tpl": tpl,
                    "calls": [(e[1], [render(x) for x in e[2]], [render(x) for x in e[3]]) for e in st.ev if e[0] == "call"]})
    return out


if __name__ == "__main__":
    rv = NAME2ADDR[sys.argv[1]] if not sys.argv[1].startswith("0x") else int(sys.argv[1], 16)
    ex = Ex(rv)
    paths = ex.run()
    print(ex.fname, "paths", len(paths), "truncated", ex.truncated)
    seen = set()
    for p in summarize(ex, paths):
        key = json.dumps([p["cond"], p["sets"], p["tpl"]], default=str)
        if key in seen: continue
        seen.add(key)
        print("--- when:", " && ".join(p["cond"]) or "always")
        for n, v, c in p["sets"]: print(f"   set this.{n} = {v}")
        for f, s, v, c in p["tpl"]: print(f"   {f}[{s}] {v}")
        if "-c" in sys.argv:
            for c in p["calls"]: print("   call", c[0], c[1], c[2])


def print_ret(ex, paths):
    for st in paths:
        if st.ret is not None:
            print("   ret:", " && ".join(st.cond) or "always", "->", render(st.ret[0]), "|", render(st.ret[1]))
