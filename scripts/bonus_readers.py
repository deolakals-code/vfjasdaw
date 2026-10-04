"""Who reads a BonusType through the BonusManager / EquipBuffManager accessors?  For every BL to an accessor that takes a BonusType, the constant loaded into w1..w3 (movz, up to 14 words back, stops at
BL/RET/B) is the id.  Much tighter than bonus_consumers.py (which matches the immediate anywhere in a function).
Accessors: BonusManager GetBonusValue / GetBonusPercentValue / GetCalcBonusValue / GetBuffValue / GetAvatarBonusValue / GetBonusMultiPercentValue / GetDurationBonus / GetBonusConstant_Rate /
GetBonusConstant_AvatarConstan_Rate / GetMaxBonusConstant_Rate / TryGetDebuff / GetRestTime / GetBonusTime, EquipBuffManager GetParam / TryGetEquipBuffer / CalcBuff / FunctionBuff / IsEquipBuff / IsVilidEquipBuff.
Usage (cwd D:\\toram_re):  python "D:\\toram reverse data\\scripts\\bonus_readers.py" bDamageLimit bElement ...   -> player_status/bonus_readers.json (merged per name)
Label: Code (static), a constant-id read is a reader candidate; absence of any reader across every accessor is the evidence for "no consumer".
"""
import sys, os, re, json, struct, bisect, collections

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
sys.path.append(r"D:\toram_re")          # after the scripts dir: D:\toram_re holds stale copies of dis_android / symexec / ...
import dis_android as D
import il2
import player_status as P

OUT = r"D:\toram reverse data\player_status\bonus_readers.json"
ACC = re.compile(r"^(BonusManager\$\$(GetBonusValue|GetBonusPercentValue|GetCalcBonusValue|GetBuffValue|GetAvatarBonusValue|GetBonusMultiPercentValue|GetDurationBonus|GetBonusConstant_Rate|"
                 r"GetBonusConstant_AvatarConstan_Rate|GetMaxBonusConstant_Rate|TryGetDebuff|GetRestTime|GetBonusTime|getDataBonusValue)|"
                 r"EquipBuffManager\$\$(GetParam|TryGetEquipBuffer.*|CalcBuff|FunctionBuff|IsEquipBuff|IsVilidEquipBuff))$")
BACK = 14
REGS = (1, 2, 3, 4)


def main():
    names = sys.argv[1:]
    ids = {n: i for i, n in P.BONUS_BY_ID.items()}
    want = {ids[n]: n for n in names}
    tgt = {a: n for a, n in D.names.items() if ACC.match(n)}
    s, e = il2.TEXT_RANGE
    code = D.b[s:e]
    words = struct.unpack_from("<%dI" % (len(code) // 4), code, 0)
    res = collections.defaultdict(set)
    for i, w in enumerate(words):
        if (w >> 26) not in (0x25, 0x05):
            continue
        imm = w & 0x3ffffff
        if imm & 0x2000000:
            imm -= 0x4000000
        pc = s + i * 4 + D.OFF
        t = pc + imm * 4
        if t not in tgt:
            continue
        fn = D.names.get(D.starts[bisect.bisect_right(D.starts, pc) - 1], "?")
        seen = set()
        for k in range(1, BACK + 1):
            if i - k < 0:
                break
            v = words[i - k]
            if (v >> 26) in (0x25, 0x05) or v == 0xd65f03c0:
                break
            if ((v >> 23) & 0x1ff) in (0b010100101, 0b110100101) and ((v >> 21) & 3) == 0:
                rd = v & 0x1f
                if rd in REGS and rd not in seen:
                    seen.add(rd)
                    if (v >> 5) & 0xffff in want:
                        res[want[(v >> 5) & 0xffff]].add(f"{fn} -> {tgt[t].split('$$')[1]}(w{rd})")
    old = json.load(open(OUT, encoding="utf-8")) if os.path.exists(OUT) else {}
    for n in names:
        old[n] = sorted(res.get(n, []))
        print(n, len(old[n]))
        for f in old[n][:25]:
            print("    ", f)
    json.dump(old, open(OUT, "w", encoding="utf-8"), ensure_ascii=False, indent=1)


if __name__ == "__main__":
    main()
