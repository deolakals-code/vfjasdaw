"""For each marker skill's action class (and buff): which SkillBufferManager/SkillManager methods does it call (any id argument)?"""
import struct, bisect, collections, sys
import dis_android as D
CL = sys.argv[1:]
mine = {a: n for a, n in D.names.items() if n.split("$$")[0].split(".")[0] in CL}
import il2
s, e = il2.TEXT_RANGE        # file offsets of the exec segment
code = D.b[s:e]
out = collections.defaultdict(collections.Counter)
for i in range(0, len(code) - 3, 4):
    w = struct.unpack_from("<I", code, i)[0]
    if (w >> 26) != 0x25: continue
    imm = w & 0x3ffffff
    if imm & 0x2000000: imm -= 0x4000000
    pc = s + i + D.OFF
    caller = D.names.get(D.starts[bisect.bisect_right(D.starts, pc) - 1], "?")
    if caller.split("$$")[0].split(".")[0] not in CL: continue
    callee = D.names.get(pc + imm * 4, "")
    if callee.startswith(("SkillBufferManager$$", "SkillManager$$")) and any(k in callee for k in ("Buf", "SkillLv", "Contains", "Has", "Exist", "Remove")):
        out[caller.split("$$")[0]][caller.split("$$")[1] + " -> " + callee] += 1
for c in CL:
    print("==", c)
    for k, v in sorted(out[c].items()): print("   ", k, v)
