"""Put the equipment rate bonuses back into the decoded rate accumulators (ATK%, MATK%, ASPD%, HIT%, CSPD%).

The client reads them with `BonusManager.GetBonusConstant_AvatarConstan_Rate(bm, constType, avatarType, rateType, out constant, out rate)`: `rate` is a stack float that
starts at 1.0 and becomes 1 + sum(rateType)/100, and the function then keeps adding to it (skill buffs, masteries, the armour's +-0.5 ...) before it reaches
`calcAtkParam / calcMatkParam / calcAspdParam` or the final multiply in get_Hit / get_Cspd. The decoder only sees the stack slot's initial 1.0 (it prints
`1 + buffer / 100`), so the bonus part is missing from every decoded rate. Read from the disassembly: CalcAtk rate slot sp+0x5c (rateType 18 bAtkRate), CalcMatk sp+0x5c
(20 bMatkRate), CalcAspd sp+0x1c (31 bAspdRate), get_Hit sp+0xc (23 bHitRate), get_Cspd sp+0x18 (33 bCspdRate).

The patch adds `GetBonusValue(rateType) / 100` where the accumulator's initial 1.0 is printed. Labelled `Code` (decoded), not checked in game.
"""
import re

BM = "BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), BonusType.{})"
BUF = r"\(1 \+ \(SkillBufferManager\.GetSkillBufferParam\(PlayerStatusBase\.get_SkillBufferManager\(\), SkillBufferId\.{}(?:, out, out)?\) / 100\)\)"
# function -> (rate buffer id printed next to the accumulator's 1.0, rate BonusType)
BY_BUFFER = {
    "EquipItemData.WeaponTypeCalculatorBase.CalcAtk": ("AtkUpRate", "bAtkRate"),
    "PlayerSecondaryStatus.get_Hit": ("HitRate", "bHitRate"),
    "PlayerSecondaryStatus.get_Cspd": ("CspdUpRate", "bCspdRate"),
}
# function -> (call whose argument is the accumulator, argument index counting `status` as 0, rate BonusType)
BY_ARGUMENT = {"EquipItemData.WeaponTypeCalculatorBase.CalcMatk": ("EquipItemData.WeaponTypeCalculatorBase.calcMatkParam(", 2, "bMatkRate"),
               "EquipItemData.WeaponTypeCalculatorBase.CalcAspd": ("EquipItemData.WeaponTypeCalculatorBase.calcAspdParam(", 1, "bAspdRate")}


def _args(text, start):
    """top-level argument spans of the call whose '(' ends just before `start`"""
    depth, i, from_, spans = 0, start, start, []
    while i < len(text):
        c = text[i]
        if c == "(":
            depth += 1
        elif c == ")":
            if depth == 0:
                spans.append((from_, i))
                return spans, i
            depth -= 1
        elif c == "," and depth == 0:
            spans.append((from_, i))
            from_ = i + 1
        i += 1
    raise ValueError("unbalanced call")


def _texts(im):
    for c in im["cases"]:
        yield c, "value"
    for k in im.get("lets", {}):
        yield im["lets"], k


def apply(V):
    for name, (buf, rate) in BY_BUFFER.items():
        im = V[name]["impls"][0]
        pat = re.compile(BUF.format(buf))
        n = 0
        for holder, key in _texts(im):
            new, k = pat.subn(lambda m: f"((1 + {BM.format(rate)} / 100) + {m.group(0)[5:-1]})", holder[key])
            holder[key], n = new, n + k
        assert n, f"{name}: no accumulator found for {buf}"
    for name, (call, idx, rate) in BY_ARGUMENT.items():
        im = V[name]["impls"][0]
        n = 0
        for holder, key in _texts(im):
            t = holder[key]
            at = t.find(call)
            while at >= 0:
                spans, end = _args(t, at + len(call))
                s, e = spans[idx]
                t = t[:s] + f" ({t[s:e].strip()} + {BM.format(rate)} / 100)" + t[e:]
                n += 1
                at = t.find(call, end + 40)
            holder[key] = t
        assert n, f"{name}: call {call} not found"
