import json, re, sys, capstone
import il2
from il2 import SO, DUMP, OFF          # OFF = RVA - file offset of the exec segment, read from the ELF program headers
b = il2.so_bytes()
sj = json.load(open(DUMP + r"\script.json", encoding="utf-8"))
names = {m["Address"]: m["Name"] for m in sj["ScriptMethod"]}
meta = {m["Address"]: m["Name"] for m in sj.get("ScriptMetadata", [])}
metam = {m["Address"]: m["Name"] for m in sj.get("ScriptMetadataMethod", [])}
meta.update({m["Address"]: repr(m["Value"]) for m in sj.get("ScriptString", [])})


def relocs():
    """R_AARCH64_RELATIVE slot -> target, so `ldr xN, [page, #off]` pointer slots resolve to metadata names."""
    import struct
    shoff, = struct.unpack_from("<Q", b, 0x28)
    shentsize, shnum = struct.unpack_from("<HH", b, 0x3A)
    out = {}
    for k in range(shnum):
        _, typ, _, _, off, size, _, _, _, _ = struct.unpack_from("<IIQQQQIIQQ", b, shoff + k * shentsize)
        if typ == 4:
            for r_off, r_info, r_add in struct.iter_unpack("<QQq", b[off:off + size]):
                if r_info & 0xffffffff == 1027:
                    out[r_off] = r_add
    return out


RELA = relocs()
starts = sorted(names)
md = capstone.Cs(capstone.CS_ARCH_ARM64, capstone.CS_MODE_ARM); md.detail = False
def func(rva):
    import bisect
    i = bisect.bisect_right(starts, rva)
    end = starts[i] if i < len(starts) else rva + 0x400
    return rva, min(end, rva + 0x1000)
def dis(rva, label=""):
    s, e = func(rva)
    print(f"==== {label or names.get(rva, hex(rva))} @ {rva:#x} ({e - s} bytes)")
    pages = {}
    for ins in md.disasm(b[s - OFF:e - OFF], s):
        note = ""
        if ins.mnemonic in ("bl", "b") and ins.op_str.startswith("#"):
            t = int(ins.op_str[1:], 16); note = names.get(t, "")
        if ins.mnemonic == "adrp":
            r, imm = ins.op_str.split(", "); pages[r] = int(imm[1:], 16)
        m = re.match(r"(\w+), \[(\w+), #(0x[0-9a-f]+)\]", ins.op_str)
        if m and m.group(2) in pages and ins.mnemonic.startswith("ldr"):
            a = pages[m.group(2)] + int(m.group(3), 16); t = RELA.get(a, a)
            note = meta.get(a) or metam.get(a) or meta.get(t) or metam.get(t) or f"[{a:#x}->{t:#x}]"
        m = re.match(r"(\w+), (\w+), #(0x[0-9a-f]+)$", ins.op_str)
        if m and ins.mnemonic == "add" and m.group(2) in pages:
            a = pages[m.group(2)] + int(m.group(3), 16); note = meta.get(a, metam.get(a, f"[{a:#x}]"))
        print(f"  {ins.address:#x}: {ins.mnemonic:8s} {ins.op_str:40s} {('; ' + note) if note else ''}")
if __name__ == "__main__":
    for a in sys.argv[1:]:
        if a.startswith("0x"): dis(int(a, 16))
        else:
            for addr, n in names.items():
                if n == a: dis(addr)
