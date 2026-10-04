"""Find functions that use constant SkillId N (movz any reg, cmp/subs/sub/add imm12) -> list of (fn, kind)."""
import struct, bisect, sys, collections
import dis_android as D
import il2
s, e = il2.TEXT_RANGE        # file offsets of the exec segment
code = D.b[s:e]
want = {int(a) for a in sys.argv[1:]}
res = collections.defaultdict(set)
for i in range(0, len(code) - 3, 4):
    w = struct.unpack_from("<I", code, i)[0]
    kind = imm = None
    if ((w >> 23) & 0x1ff) in (0b010100101, 0b110100101) and ((w >> 21) & 3) == 0:      # MOVZ w/x, #imm16, lsl 0
        imm, kind = (w >> 5) & 0xffff, "movz"
    elif ((w >> 23) & 0xff) in (0b00100010, 0b01100010, 0b01110001 & 0xff) or (w >> 24) & 0x7f in (0x11, 0x31, 0x51, 0x71):   # ADD/ADDS/SUB/SUBS imm
        if (w >> 22) & 3 == 0:
            imm, kind = (w >> 10) & 0xfff, {0x11: "add", 0x31: "adds", 0x51: "sub", 0x71: "cmp/subs"}.get((w >> 24) & 0x7f, "arith")
    if imm in want:
        pc = s + i + D.OFF
        j = bisect.bisect_right(D.starts, pc) - 1
        res[imm].add((D.names.get(D.starts[j], hex(D.starts[j])), kind))
for u in sorted(res):
    print("==", u, len(res[u]))
    for f, k in sorted(res[u]): print("  ", k, f)
