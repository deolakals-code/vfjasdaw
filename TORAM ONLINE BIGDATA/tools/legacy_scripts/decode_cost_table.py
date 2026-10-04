"""Decode GrantData..cctor (libil2cpp.so RVA 0x1D81F1C): the EnhanceCost / EnhanceElementCost tables.

Walks the instructions with a tiny register tracker (immediates, callee-saved regs survive `bl`,
rodata float loads), captures EnhanceProperties2..ctor args and the key passed to Dictionary.Add.
usage: python decode_cost_table.py > cost_table.tsv
"""
import re, struct, sys
import capstone

SO = r"D:\toram_re\apk\lib\libil2cpp.so"
OFF = 0x4000
START, END = 0x1D81F1C, 0x1D83FE0
CTOR, ADD = 0x36F2178, 0x28A36CC
b = open(SO, "rb").read()

md = capstone.Cs(capstone.CS_ARCH_ARM64, capstone.CS_MODE_ARM)
R, F, pages, stack = {}, {}, {}, {}
dict_reg = {}  # x-reg -> "Bonus" | "Element"
rows = []
pending = None
CALLEE = {f"w{i}" for i in range(19, 29)} | {f"x{i}" for i in range(19, 29)}
FCALLEE = {f"s{i}" for i in range(8, 16)}


def w(r):
    return "w" + r[1:] if r[0] in "wx" else r


def rodata_f32(va):
    return struct.unpack_from("<f", b, va)[0]


for ins in md.disasm(b[START - OFF:END - OFF], START):
    mn, ops = ins.mnemonic, [o.strip() for o in ins.op_str.split(",")]
    if mn == "mov" and len(ops) == 2 and not ops[0].startswith("v"):
        d = w(ops[0])
        if ops[1].startswith("#"):
            R[d] = int(ops[1][1:], 0) & 0xffffffff
        elif ops[1] in ("wzr", "xzr"):
            R[d] = 0
        elif w(ops[1]) in R:
            R[d] = R[w(ops[1])]
        else:
            R.pop(d, None)
        if ops[0].startswith("x") and ops[1].startswith("x") and ops[1] in dict_reg:
            dict_reg[ops[0]] = dict_reg[ops[1]]
    elif mn == "movk":
        d = w(ops[0]); sh = int(ins.op_str.split("lsl #")[1]) if "lsl" in ins.op_str else 0
        R[d] = (R.get(d, 0) & ~(0xffff << sh)) | (int(ops[1][1:], 0) << sh)
    elif mn == "adrp":
        pages[ops[0]] = int(ops[1][1:], 16)
    elif mn == "fmov" and ops[0].startswith("s"):
        src = ops[1]
        if src.startswith("#"):
            F[ops[0]] = float(src[1:])
        elif src == "wzr":
            F[ops[0]] = 0.0
        elif src.startswith("w") and src in R:
            F[ops[0]] = struct.unpack("<f", struct.pack("<I", R[src]))[0]
        elif src.startswith("s") and src in F:
            F[ops[0]] = F[src]
    elif mn == "mov" and ops[0].startswith("v") and ops[1].startswith("v"):
        src, dst = "s" + ops[1][1:].split(".")[0], "s" + ops[0][1:].split(".")[0]
        if src in F: F[dst] = F[src]
    elif mn == "ldr" and ops[0].startswith("s"):
        m = re.match(r"\[(x\d+), #(0x[0-9a-f]+)\]", ", ".join(ops[1:]))
        if m and m.group(1) in pages:
            F[ops[0]] = rodata_f32(pages[m.group(1)] + int(m.group(2), 16))
    elif mn == "str" and ops[0][0] in "wx" and ops[1] in ("[sp", "[sp]"):
        k = int(ops[2].rstrip("]").lstrip("#"), 0) if len(ops) > 2 else 0
        stack[k] = 0 if ops[0] in ("wzr", "xzr") else R.get(w(ops[0]))
    elif mn == "bl":
        t = int(ops[0][1:], 16)
        if t == CTOR:
            pending = dict(UsePotential=R.get("w1"), Coefficient=R.get("w2"), MaterialCategory=R.get("w3"),
                           AbilityCategory=R.get("w4"), Rate=F.get("s0"), BaseMax=R.get("w5"),
                           UpperMax=R.get("w6"), LowerMax=R.get("w7"), OverRate=stack.get(0), DoubleUse=stack.get(8),
                           addr=ins.address)
        elif t == ADD:
            rows.append((ins.address, R.get("w1"), pending))
            pending = None
        R = {k: v for k, v in R.items() if k in CALLEE}
        F = {k: v for k, v in F.items() if k in FCALLEE}

# The Bonus dict is filled first; the element dict is constructed where the ElementType ctor is called.
elem_ctor = 0x28A2828  # same generic ctor for both dicts; split by the second ctor call site
ctor_sites = [i.address for i in md.disasm(b[START - OFF:END - OFF], START)
              if i.mnemonic == "bl" and i.op_str == f"#{elem_ctor:#x}"]
split = ctor_sites[1] if len(ctor_sites) > 1 else END
cols = ["UsePotential", "Coefficient", "MaterialCategory", "AbilityCategory", "Rate", "BaseMax", "UpperMax",
        "LowerMax", "OverRate", "DoubleUse"]
print("dict\tkey\t" + "\t".join(cols) + "\tadd_addr")
for addr, key, p in rows:
    d = "Bonus" if addr < split else "Element"
    print(f"{d}\t{key}\t" + "\t".join(str(p[c]) for c in cols) + f"\t{addr:#x}")
print(f"# {len(rows)} entries, element dict ctor at {split:#x}", file=sys.stderr)
