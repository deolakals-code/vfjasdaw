"""Concrete emulation of UIRegistletMainManager.GetDescriptionValueText(GemCartId id, int lv, int baseValue) -> the number the game
puts in `{0}` of a registlet description. Pure integer/float arm64 emulation of the ~160 instructions of that function."""
import sys, re, struct
import os
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import il2
from dis_android import b, md, OFF, names, meta, RELA

START = il2.method_rva("UIRegistletMainManager", "GetDescriptionValueText")
END = il2.fn_end(START)
M32, M64 = 0xffffffff, 0xffffffffffffffff
INS = {i.address: i for i in md.disasm(b[START - OFF:END - OFF], START)}
COND = {"eq": lambda f: f["Z"], "ne": lambda f: not f["Z"], "hs": lambda f: f["C"], "lo": lambda f: not f["C"],
        "hi": lambda f: f["C"] and not f["Z"], "ls": lambda f: not f["C"] or f["Z"], "lt": lambda f: f["N"] != f["V"],
        "ge": lambda f: f["N"] == f["V"], "gt": lambda f: not f["Z"] and f["N"] == f["V"], "le": lambda f: f["Z"] or f["N"] != f["V"]}


def s32(v): v &= M32; return v - (1 << 32) if v >> 31 else v


def run(gid, lv, base, skill107_lv=0):
    R = {"x1": gid, "x2": lv, "x3": base}; F = {}; mem = {}; fl = {"N": 0, "Z": 0, "C": 0, "V": 0}
    pc, fmt = START, None
    def g(n):
        n = n.strip()
        if n in ("wzr", "xzr"): return 0
        if n.startswith("#"): return int(n[1:], 0)
        k = "x" + n[1:] if n[0] in "wx" else n
        v = R.get(k, 0)
        return (v & (M32 if n[0] == "w" else M64)) if isinstance(v, int) else 0
    def s(n, v): R["x" + n[1:]] = v & (M32 if n[0] == "w" else M64)
    for _ in range(2000):
        i = INS[pc]; m = i.mnemonic; o = [t.strip() for t in i.op_str.split(",")]; nx = pc + 4
        if m in ("stp", "ldp", "nop") or (m in ("sub", "add") and o[0] == "sp"): pass
        elif m == "adrp": R["x" + o[0][1:]] = int(o[1][1:], 16)
        elif m == "ldrb" and len(o) == 3 and not o[2].startswith("#"):
            R["x" + o[0][1:]] = b[g("x" + o[1].strip("[")[1:]) + g("x" + o[2].strip("]")[1:])]
        elif m == "ldrb": pass
        elif m == "str" and o[1].startswith("[sp"):
            mo = re.search(r"#(0x[0-9a-f]+|\d+)", ",".join(o[1:])); off = int(mo.group(1), 0) if mo else 0
            mem[off] = g(o[0]) if o[0][0] in "wx" else F[o[0]]
        elif m == "mov": s(o[0], g(o[1]))
        elif m == "add" and o[1] == "sp": s(o[0], 0x1000 + int(o[2][1:], 0))
        elif m == "add" and len(o) == 4: s(o[0], g(o[1]) + (g(o[2]) << int(o[3].split("#")[1])))
        elif m == "add": s(o[0], g(o[1]) + g(o[2]))
        elif m == "sub": s(o[0], g(o[1]) - g(o[2]))
        elif m == "mul": s(o[0], g(o[1]) * g(o[2]))
        elif m == "madd": s(o[0], g(o[1]) * g(o[2]) + g(o[3]))
        elif m == "asr": s(o[0], s32(g(o[1])) >> int(o[2][1:], 0))
        elif m == "cmp":
            a, c = g(o[0]), g(o[1]); r = (a - c) & M32
            fl = {"Z": r == 0, "N": bool(r >> 31), "C": a >= c, "V": (s32(a) - s32(c)) != s32(r)}
        elif m == "cinc":
            if COND[o[2]](fl): s(o[0], g(o[1]) + 1)
            else: s(o[0], g(o[1]))
        elif m.startswith("b.") or m == "b":
            if m == "b" or COND[m[2:]](fl): nx = int(o[0][1:], 16)
        elif m == "adr": R["x" + o[0][1:]] = int(o[1][1:], 16)
        elif m == "br": nx = R[o[0]]
        elif m == "scvtf": F[o[0]] = float(s32(g(o[1])))
        elif m == "fmov":
            F[o[0]] = float(o[1][1:]) if o[1].startswith("#") else (struct.unpack("<f", struct.pack("<I", g(o[1])))[0] if o[1][0] == "w" else F[o[1]])
        elif m == "fdiv": F[o[0]] = F[o[1]] / F[o[2]]
        elif m == "fmul": F[o[0]] = F[o[1]] * F[o[2]]
        elif m == "fadd": F[o[0]] = F[o[1]] + F[o[2]]
        elif m == "bl":
            nm = names.get(int(o[0][1:], 16), "")
            if nm.startswith("System.Int32$$ToString"): return str(s32(mem[0xc]))
            if nm == "System.String$$Format": return f"{F['s0']:.{int(re.search(r'F(\d)', fmt).group(1))}f}"
            if nm == "SkillManager$$GetSkillLv": R["x0"] = skill107_lv
        elif m == "ldr" and o[0][0] == "x":                      # string-literal slots: `{0:F1}` / `{0:F2}` (found through the metadata table, not by offset)
            mm = re.match(r"\[(x\d+)(?:, #(0x[0-9a-f]+|\d+))?\]$", ", ".join(o[1:]))
            base, st = R.get(mm.group(1)) if mm else None, None
            if isinstance(base, int):
                slot = base + int(mm.group(2) or "0", 0); st = meta.get(slot) or meta.get(RELA.get(slot, slot))
            elif isinstance(base, tuple): st = base[1]
            R["x" + o[0][1:]] = ("fmt", st) if st and "{0:F" in st else None
            if st and "{0:F" in st: fmt = st
        elif m == "ret": return None
        pc = nx
    return None


if __name__ == "__main__":
    print(run(1, 5, 1), run(3, 5, 10), run(26, 3, 15), run(44, 5, 20), run(205, 5, 7))
