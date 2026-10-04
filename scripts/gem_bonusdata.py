"""Straight-line tracer for GemCartBuffer.*Buff.GetBonusData(out short[] id, out short[] val): returns [(bonusId, expr)] or None.
Handles array allocation (`bl 0x165d9d4`), element stores (`strh/str wN, [arr, #0x20 + size*i]`), `str xA, [out]` and integer
arithmetic on Lv (`ldrh w, [this, #0x14]`). Anything else (branches other than null checks, unknown ops) -> None."""
import re, sys, bisect
import os
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from dis_android import b, names, starts, md, OFF

import il2
ARR_NEW = il2.stub("array_new")
LV = "Lv"


DBG = []


def trace(rva):
    i = bisect.bisect_right(starts, rva)
    end = starts[i] if i < len(starts) else rva + 0x400
    ins = list(md.disasm(b[rva - OFF:end - OFF], rva))
    R = {"x0": "this", "x1": ("out", 1), "x2": ("out", 2), "x20": None}
    arrs, outs, nid = {}, {}, 0
    def reg(n):
        n = n.strip()
        if n in ("wzr", "xzr"): return 0
        if n.startswith("#"): return int(n[1:], 0)
        return R.get(n.replace("w", "x", 1) if n[0] == "w" else n)
    def setr(n, v): R[n.replace("w", "x", 1) if n[0] == "w" else n] = v
    pc2idx = {x.address: k for k, x in enumerate(ins)}
    k = 0
    while k < len(ins):
        x = ins[k]; m = x.mnemonic; o = [t.strip() for t in x.op_str.split(",")]
        k += 1
        if m in ("stp", "ldp", "ret", "nop") or (m == "str" and o[1].startswith("[sp")) or (m in ("ldr", "ldrb") and o[1].startswith("[x") and ("TypeInfo" in "" )):
            if m == "ret": break
            continue
        if m in ("adrp",): setr(o[0], ("page", int(o[1][1:], 16))); continue
        if m == "ldrb" and o[1].startswith("[x"): continue                       # static-init guard byte
        if m == "tbnz": continue                                               # guard branch: assume initialised
        if m in ("cbz", "cbnz"):
            tgt = int(o[1][1:], 16)
            if m == "cbz" and tgt in pc2idx and tgt > x.address: continue     # null/len check: error path is forward
            return None
        if m == "mov":
            v = reg(o[1]); setr(o[0], v if v is not None else R.get(o[1])); continue
        if m == "movz": setr(o[0], int(o[1][1:], 0)); continue
        if m == "ldr" and o[1].startswith("[") and "#" not in o[1]:
            base = R.get(o[1].strip("[]"))
            if isinstance(base, tuple) and base[0] == "page": setr(o[0], ("tinfo",)); continue
            setr(o[0], ("tinfo",)); continue
        if m == "ldr" and "#" in o[1]:
            mm = re.match(r"\[(\w+), #(0x[0-9a-f]+|\d+)\]", ", ".join(o[1:]))
            if mm and mm.group(1) in R and isinstance(R[mm.group(1)], tuple) and R[mm.group(1)][0] == "page":
                setr(o[0], ("tinfo", int(mm.group(2), 0))); continue
            if mm and R.get(mm.group(1)) == "this":
                setr(o[0], f"this+{mm.group(2)}"); continue
            if mm and isinstance(R.get(mm.group(1)), tuple) and R[mm.group(1)][0] == "arr":
                setr(o[0], ("arrlen",)); continue
            setr(o[0], ("unk",)); continue
        if m in ("ldrh", "ldrsh", "ldrb", "ldrsb") and o[1].startswith("[x"):
            mm = re.match(r"\[(\w+), #(0x[0-9a-f]+|\d+)\]", ", ".join(o[1:]))
            if mm and R.get(mm.group(1)) == "this":
                off = int(mm.group(2), 0)
                setr(o[0], LV if off == 0x14 else f"this+{hex(off)}"); continue
            if mm and isinstance(R.get(mm.group(1)), tuple) and R[mm.group(1)][0] == "arr": continue
            return None
        if m == "ldr" and o[1].startswith("[x"): continue
        if m == "bl":
            t = int(o[0][1:], 16)
            if t == ARR_NEW:
                nid += 1; arrs[nid] = {}; setr("x0", ("arr", nid)); continue
            if names.get(t, "").endswith("$$.ctor") or t in (il2.stub("class_init"), il2.stub("wb_set_field")): continue    # type init / write barrier
            if t in (il2.stub("null_ref"), il2.stub("bounds")): continue                             # null / bounds throw helpers
            return None
        if m in ("strh", "str", "strb") and o[1].startswith("["):
            mm = re.match(r"\[(\w+)(?:, #(0x[0-9a-f]+|\d+))?\]", ", ".join(o[1:]))
            if not mm: return None
            base, off = R.get(mm.group(1)), int(mm.group(2) or "0", 0)
            if isinstance(base, tuple) and base[0] == "page": continue         # static-init guard byte
            if isinstance(base, tuple) and base[0] == "out":
                outs[base[1]] = R.get(o[0]); continue
            if isinstance(base, tuple) and base[0] == "arr":
                sz = {"strh": 2, "strb": 1}.get(m, 4 if o[0][0] == "w" else 8)
                arrs[base[1]][(off - 0x20) // sz] = reg(o[0]); continue
            if mm.group(1) in ("sp",): continue
            return None
        if m in ("add", "sub", "mul", "lsl", "neg", "asr", "lsr", "sxth", "uxth", "and"):
            a = reg(o[1]) if m not in ("neg",) else 0
            if m == "neg": a, c = 0, reg(o[1])
            elif m in ("sxth", "uxth"): setr(o[0], reg(o[1])); continue
            else: c = reg(o[2]) if len(o) > 2 else None
            if a is None or c is None: return None
            sym = {"add": "+", "sub": "-", "mul": "*", "neg": "-", "and": "&"}.get(m)
            if m in ("lsl", "asr", "lsr"):
                sh = int(o[2][1:], 0) if o[2].startswith("#") else None
                if sh is None: return None
                setr(o[0], f"({a} {'<<' if m == 'lsl' else '>>'} {sh})" if not isinstance(a, int) else (a << sh if m == 'lsl' else a >> sh)); continue
            if len(o) > 3 and "lsl" in o[3]:
                sh = int(o[3].split("#")[1]); c = f"({c} << {sh})" if not isinstance(c, int) else c << sh
            setr(o[0], (a + c if sym == "+" else a - c if sym == "-" else a * c if sym == "*" else a & c) if isinstance(a, int) and isinstance(c, int) else f"({a} {sym} {c})"); continue
        if m == "madd":
            a, c, d = reg(o[1]), reg(o[2]), reg(o[3])
            setr(o[0], f"(({a} * {c}) + {d})"); continue
        if m in ("sdiv", "udiv"):
            a, c = reg(o[1]), reg(o[2]); setr(o[0], f"({a} / {c})"); continue
        if m == "b": return None
        DBG.append((x.address, x.mnemonic, x.op_str)); return None
    ida, val = outs.get(1), outs.get(2)
    if not (isinstance(ida, tuple) and isinstance(val, tuple)): return None
    A, B = arrs[ida[1]], arrs[val[1]]
    return [(A[i], B.get(i)) for i in sorted(A)]


if __name__ == "__main__":
    for a, n in sorted(names.items()):
        if n.startswith("GemCartBuffer.") and n.endswith("$$GetBonusData"):
            print(n.split("$$")[0], trace(a))
