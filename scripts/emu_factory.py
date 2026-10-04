import sys, re, json, struct
import os
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from dis_android import b, names, md, OFF

M32 = 0xffffffff
def sx(v, bits=32): return v - (1 << bits) if v & (1 << (bits - 1)) else v
INS = {}
def ins_at(a):
    if a not in INS:
        INS[a] = next(md.disasm(b[a - OFF:a - OFF + 4], a))
    return INS[a]
COND = {
 "eq": lambda f: f["Z"], "ne": lambda f: not f["Z"], "hs": lambda f: f["C"], "cs": lambda f: f["C"],
 "lo": lambda f: not f["C"], "cc": lambda f: not f["C"], "hi": lambda f: f["C"] and not f["Z"],
 "ls": lambda f: not f["C"] or f["Z"], "lt": lambda f: f["N"] != f["V"], "ge": lambda f: f["N"] == f["V"],
 "gt": lambda f: not f["Z"] and f["N"] == f["V"], "le": lambda f: f["Z"] or f["N"] != f["V"],
 "mi": lambda f: f["N"], "pl": lambda f: not f["N"]}

def run(start, arg, limit=400, hooks=None, loads=None):
    R = {"w0": arg, "w20": arg}      # w0 = id on entry; prologue moves it to w20
    R["x0"] = arg
    fl = None
    pc = start
    for _ in range(limit):
        if hooks and pc in hooks:
            for reg, v in hooks[pc]().items() if callable(hooks[pc]) else hooks[pc].items():
                R[reg] = arg if v == "ARG" else v
        i = ins_at(pc); m = i.mnemonic; o = [x.strip() for x in i.op_str.split(",")]
        def val(t):
            t = t.strip()
            if t.startswith("#"): return int(t[1:], 16) if "0x" in t else int(t[1:])
            if t in ("wzr", "xzr"): return 0
            return R.get(t.replace("x", "w") if t[0] == "x" else t)
        def key(t): return t.replace("x", "w") if t[0] == "x" else t
        nxt = pc + 4
        if m == "mov" and o[0][0] in "wx":
            R[key(o[0])] = val(o[1]) if o[1][0] in "#wx" else None
        elif m == "sxth":
            a = val(o[1]); R[key(o[0])] = None if a is None else sx(a & 0xffff, 16) & M32
        elif m == "ldr" and o[0][0] == "w" and loads is not None and re.match(r"\[x\d+, #(0x[0-9a-f]+|\d+)\]$", ", ".join(o[1:])) and int(re.search(r"#(0x[0-9a-f]+|\d+)", o[2]).group(1), 0) in loads:
            R[key(o[0])] = arg if loads[int(re.search(r"#(0x[0-9a-f]+|\d+)", o[2]).group(1), 0)] == "ARG" else loads[int(re.search(r"#(0x[0-9a-f]+|\d+)", o[2]).group(1), 0)]
        elif m == "sub" and o[0][0] == "w":
            a, c = val(o[1]), val(o[2])
            R[key(o[0])] = None if a is None else (a - c) & M32
        elif m == "cmp" and o[0][0] == "w":
            a, c = val(o[0]), val(o[1])
            if a is None or c is None: return ("unk", pc)
            r = (a - c) & M32
            fl = {"Z": r == 0, "N": bool(r >> 31), "C": a >= c,
                  "V": ((sx(a) - sx(c)) != sx(r))}
        elif m == "csel":
            if fl is None: return ("unk", pc)
            R[key(o[0])] = val(o[1]) if COND[o[3]](fl) else val(o[2])
        elif m == "b":
            nxt = int(o[0][1:], 16)
        elif m.startswith("b.") :
            if fl is None: return ("unk", pc)
            if COND[m[2:]](fl): nxt = int(o[0][1:], 16)
        elif m == "cbz" or m == "cbnz":
            pass  # assume x0 non-null
        elif m == "tbnz":
            nxt = int(o[2][1:], 16)  # static-init guard bytes: assume initialised
        elif m == "adrp":
            R[o[0]] = int(o[1][1:], 16)
        elif m == "adr":
            R[o[0]] = int(o[1][1:], 16)
        elif m == "add" and len(o) == 3 and o[2].startswith("#"):
            a = R.get(o[1]); R[o[0]] = None if a is None else a + val(o[2])
        elif m == "add" and "lsl" in i.op_str:
            a = R.get(o[1]); c = R.get(key(o[2]))
            sh = int(o[3].split("#")[1]) if len(o) > 3 else 0
            R[o[0]] = None if (a is None or c is None) else a + (c << sh)
        elif m == "ldrh":
            mm = re.match(r"(\w+), \[(\w+), (\w+), lsl #1\]", i.op_str)
            base, idx = R.get(mm.group(2)), R.get(mm.group(3).replace("x", "w"))
            if base is None or idx is None: return ("unk", pc)
            R[mm.group(1)] = struct.unpack_from("<H", b, base + idx * 2)[0]  # rodata: RVA used directly
        elif m == "br":
            t = R.get(o[0])
            if t is None: return ("unk", pc)
            nxt = t
        elif m == "bl":
            t = int(o[0][1:], 16); n = names.get(t, "")
            if n.endswith("$$.ctor"): return ("ok", n[:-len("$$.ctor")], pc)
        elif m == "ret":
            return ("ret", pc)
        pc = nxt
    return ("limit", pc)
