"""Consumer map: which functions read skill <uid> (SkillManager.GetSkillLv / SkillBufferManager.TryGetBuf with a constant id).
Scans every BL to those callees and reads the constant loaded into the id argument register just before it.
-> skill_consumers.json  {uid: [{"fn": caller, "via": callee}]}
"""
import json, struct, bisect, collections
import dis_android as D

CALLEES = {"SkillManager$$GetSkillLv": "w1", "SkillBufferManager$$TryGetBuf": "w1", "SkillBufferManager$$ContainsBuffer": "w1"}
tgt = {a: n for a, n in D.names.items() if n in CALLEES}
print({hex(a): n for a, n in tgt.items()})

import il2
s, e = il2.TEXT_RANGE        # file offsets of the exec segment
code = D.b[s:e]
res = collections.defaultdict(set)
BACK = 14


def const_w1(idx):
    # walk back up to BACK instructions looking for `mov w1, #imm` (movz w1) with no intervening write to w1/x1 other than it
    for k in range(1, BACK + 1):
        j = idx - 4 * k
        if j < 0: return None
        w = struct.unpack_from("<I", code, j)[0]
        rd = w & 0x1f
        if ((w >> 23) & 0x1ff) in (0b010100101, 0b110100101) and rd == 1 and ((w >> 21) & 3) == 0:   # MOVZ w1/x1, #imm16 (no shift)
            return (w >> 5) & 0xffff
        if (w >> 26) in (0x25, 0x05) or w == 0xd65f03c0:                                            # BL/B/RET ends the basic block
            return None
    return None


for i in range(0, len(code) - 3, 4):
    w = struct.unpack_from("<I", code, i)[0]
    if (w >> 26) in (0x25,):
        imm = w & 0x3ffffff
        if imm & 0x2000000: imm -= 0x4000000
        pc = s + i + D.OFF
        t = pc + imm * 4
        if t in tgt:
            uid = const_w1(i)
            if uid is None: continue
            j = bisect.bisect_right(D.starts, pc) - 1
            res[uid].add((D.names.get(D.starts[j], hex(D.starts[j])), tgt[t].split("$$")[1]))
out = {str(u): [{"fn": f, "via": v} for f, v in sorted(x)] for u, x in sorted(res.items())}
json.dump(out, open(r"D:\toram_re\skill_consumers.json", "w", encoding="utf-8"), ensure_ascii=False, indent=1)
print(len(out), "uids with constant-id consumers,", sum(len(v) for v in out.values()), "call sites")
