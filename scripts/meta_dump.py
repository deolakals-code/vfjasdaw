"""Dump types/fields/methods/constants from an IL2CPP v31 global-metadata.dat (metadata only, no binary)."""
import os, re, struct

import sys
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import il2
# usage: python meta_dump.py <global-metadata.dat> [outdir]   (Android and PC metadata share the format; the Android file matches the analysed binary)
M = sys.argv[1] if len(sys.argv) > 1 else os.path.join(il2.WORK, "apk", "global-metadata.dat")
OUT = sys.argv[2] if len(sys.argv) > 2 else os.path.join(il2.WORK, "meta_android")
b = open(M, "rb").read()
sec = [struct.unpack_from("<Ii", b, 8 + i * 8) for i in range(31)]
S_STR, S_PROP, S_METH, S_FDEF, S_DATA, S_FIELD, S_TYPE = 2, 4, 5, 7, 8, 11, 19


def table(i, size, fmt):
    off, total = sec[i]
    return [struct.unpack_from(fmt, b, off + k * size) for k in range(total // size)]


def s(idx):
    off = sec[S_STR][0] + idx
    return b[off:b.index(b"\0", off)].decode("utf-8", "replace")


types = table(S_TYPE, 88, "<IIiiiiiIiiiiiiii8HII")
fields = table(S_FIELD, 12, "<iiI")
methods = table(S_METH, 36, "<IiiIiiI4H")
props = table(S_PROP, 20, "<IiiII")
fdefs = {f: (t, d) for f, t, d in table(S_FDEF, 12, "<iii")}

byval = {t[2]: i for i, t in enumerate(types)}
PRIM = {"Boolean": "bool", "Byte": "u8", "SByte": "i8", "Char": "char", "Int16": "i16", "UInt16": "u16",
        "Int32": "i32", "UInt32": "u32", "Int64": "i64", "UInt64": "u64", "Single": "f32", "Double": "f64",
        "String": "str"}
prim_of = {t[2]: PRIM[s(t[0])] for t in types if s(t[1]) == "System" and s(t[0]) in PRIM}


def full_name(i, depth=0):
    t = types[i]
    name = s(t[0])
    if t[3] != -1 and t[3] in byval and depth < 16:
        return full_name(byval[t[3]], depth + 1) + "/" + name
    ns = s(t[1])
    return f"{ns}.{name}" if ns else name


def cuint(p):
    c = b[p]
    if c & 0x80 == 0:
        return c, p + 1
    if c & 0xC0 == 0x80:
        return ((c & 0x3F) << 8) | b[p + 1], p + 2
    if c & 0xE0 == 0xC0:
        return ((c & 0x1F) << 24) | (b[p + 1] << 16) | (b[p + 2] << 8) | b[p + 3], p + 4
    if c == 0xF0:
        return struct.unpack_from("<I", b, p + 1)[0], p + 5
    return (0xFFFFFFFE if c == 0xFE else 0xFFFFFFFF), p + 1


def cint(p):
    u, p = cuint(p)
    if u == 0xFFFFFFFF:
        return -2 ** 31, p
    return (-(u >> 1) - 1 if u & 1 else u >> 1), p


def kind_of(type_index):
    if type_index in prim_of:
        return prim_of[type_index]
    ti = byval.get(type_index)
    if ti is not None and types[ti][5] in prim_of:  # enum: elementTypeIndex = underlying type
        return prim_of[types[ti][5]]
    if ti is not None:
        m = re.match(r"__StaticArrayInitTypeSize=(\d+)", s(types[ti][0]))
        if m:
            return f"blob{m.group(1)}"
    return None


def value(type_index, data_index):
    if data_index == -1:
        return None
    p = sec[S_DATA][0] + data_index
    k = kind_of(type_index)
    if k in ("bool", "u8"):
        return b[p]
    if k == "i8":
        return struct.unpack_from("<b", b, p)[0]
    if k in ("u16", "char"):
        return struct.unpack_from("<H", b, p)[0]
    if k == "i16":
        return struct.unpack_from("<h", b, p)[0]
    if k == "u32":
        return cuint(p)[0]
    if k == "i32":
        return cint(p)[0]
    if k in ("i64", "u64"):
        return struct.unpack_from("<q" if k == "i64" else "<Q", b, p)[0]
    if k == "f32":
        return round(struct.unpack_from("<f", b, p)[0], 7)
    if k == "f64":
        return struct.unpack_from("<d", b, p)[0]
    if k == "str":
        n, p = cint(p)
        return None if n < 0 else b[p:p + n].decode("utf-8", "replace")
    if k and k.startswith("blob"):
        return "hex:" + b[p:p + min(int(k[4:]), 256)].hex()
    return f"?raw:{b[p:p + 8].hex()}"


if __name__ == "__main__":
    os.makedirs(OUT, exist_ok=True)
    print("types", len(types), "fields", len(fields), "methods", len(methods), "consts", len(fdefs))
    unknown = 0
    with open(os.path.join(OUT, "all_types.txt"), "w", encoding="utf-8") as fa, \
         open(os.path.join(OUT, "constants.tsv"), "w", encoding="utf-8") as fc:
        fc.write("type\tfield\tkind\tvalue\n")
        for i, t in enumerate(types):
            fname = full_name(i)
            fstart, mstart, pstart = t[8], t[9], t[11]
            mcount, pcount, fcount = t[16], t[17], t[18]
            fa.write(f"\nclass {fname}\n")
            for fi in range(fstart, fstart + fcount):
                name = s(fields[fi][0])
                line = f"    field {name}"
                if fi in fdefs:
                    ti, di = fdefs[fi]
                    v = value(ti, di)
                    k = kind_of(ti)
                    unknown += k is None
                    line += f" = {v!r}  [{k}]"
                    fc.write(f"{fname}\t{name}\t{k}\t{v}\n")
                fa.write(line + "\n")
            for pi in range(pstart, pstart + pcount):
                fa.write(f"    prop  {s(props[pi][0])}\n")
            for mi in range(mstart, mstart + mcount):
                m = methods[mi]
                fa.write(f"    meth  {s(m[0])}({m[10]})\n")
    print("constants with unknown type:", unknown)
