"""Find `sub wN, wM, #base ; cmp wN, #range ; b.hi` switch prologues whose [base, base+range] covers a target id."""
import struct, bisect, sys, collections
import dis_android as D
import il2
s, e = il2.TEXT_RANGE        # file offsets of the exec segment
code = D.b[s:e]
want = [int(a) for a in sys.argv[1:]]
res = collections.defaultdict(set)
for i in range(0, len(code) - 11, 4):
    a, b_, c = struct.unpack_from("<III", code, i)
    if (a >> 24) & 0x7f != 0x51 or (a >> 22) & 3: continue              # SUB imm12 (lsl 0)
    if (b_ >> 24) & 0x7f != 0x71 or (b_ >> 22) & 3 or (b_ & 0x1f) != 31: continue  # CMP imm12
    if (c >> 24) != 0x54 or (c & 0xf) != 8: continue                       # b.hi
    base, rng = (a >> 10) & 0xfff, (b_ >> 10) & 0xfff
    for t in want:
        if base <= t <= base + rng:
            pc = s + i + D.OFF; j = bisect.bisect_right(D.starts, pc) - 1
            res[t].add((D.names.get(D.starts[j], hex(D.starts[j])), base, rng))
for t in want:
    print("==", t)
    for f, bs, r in sorted(res[t]): print("  ", f, "base", bs, "range", r)
