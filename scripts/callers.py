"""List direct BL/B callers of the given RVAs. usage: python callers.py 0xRVA ..."""
import sys, struct, bisect
import dis_android as D
targets = {int(a, 16) for a in sys.argv[1:]}
s, e = 0x14cb94c, 0x14cb94c + 0x235d294
code = D.b[s:e]
for i in range(0, len(code) - 3, 4):
    w = struct.unpack_from("<I", code, i)[0]
    if (w >> 26) in (0x25, 0x05):
        imm = w & 0x3ffffff
        if imm & 0x2000000: imm -= 0x4000000
        pc = s + i + D.OFF; t = pc + imm * 4
        if t in targets:
            j = bisect.bisect_right(D.starts, pc) - 1
            print(f"{D.names.get(t, hex(t))} <- {pc:#x} {D.names.get(D.starts[j])}")
