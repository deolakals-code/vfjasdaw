import re, sys, json, csv, bisect
import os
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from dis_android import b, names, starts, md, OFF

import il2
DUMP = os.path.join(il2.DUMP, "dump.cs")
lines = open(DUMP, encoding="utf-8", errors="replace").read().splitlines()
cre = re.compile(r'^(?:public |internal |private |protected )?(?:abstract |sealed |static )*class\s+([^\s:<]+)(?:\s*:\s*([^\s,{/<]+))?')
base, ovr, methods = {}, {}, {}
cls = None
for i, l in enumerate(lines):
    if not l.startswith((" ", "\t")):
        m = cre.match(l)
        if m:
            cls = m.group(1); base[cls] = m.group(2); ovr[cls] = {}; methods[cls] = []
    elif cls:
        m = re.search(r"RVA: (0x[0-9A-Fa-f]+)", lines[i - 1]) if i else None
        if m and "(" in l and "{ }" in l:
            rva = int(m.group(1), 16); methods[cls].append(rva)
            mm = re.search(r"override \S+ (get_ActionID|get_ExpType|get_AttackType|get_IsExpDefFluctuate)\(\)", l)
            if mm: ovr[cls][mm.group(1)] = rva

def chain(c):
    seen = set()
    while c and c not in seen:
        seen.add(c)
        yield c
        c = base.get(c)
def is_action(c): return any(x == "SkillActionBase" for x in chain(c))
def find(c, name):
    for x in chain(c):
        if name in ovr.get(x, {}): return x, ovr[x][name]
    return None, None

def const(rva):
    ins = list(md.disasm(b[rva - OFF:rva - OFF + 12], rva))[:3]
    a, c = ins[0], ins[1]
    if a.mnemonic == "mov" and c.mnemonic == "ret" and a.op_str.startswith("w0, "):
        v = a.op_str.split(", ")[1]
        return 0 if v == "wzr" else int(v[1:], 16)
    return "dynamic"

fac = {int(k): v for k, v in json.load(open(r"D:\toram_re\state\_factory_map.json")).items()}
fac_classes = set(fac.values())
action_classes = {c for c in base if is_action(c)} | fac_classes
ctor_of = {n[:-len("$$.ctor")]: a for a, n in names.items() if n.endswith("$$.ctor")}
ctor_addr = {a for a, n in names.items() if n.endswith("$$.ctor")}

import struct
def child_actions(c):
    out = set()
    for r in methods.get(c, []):
        i = bisect.bisect_right(starts, r); e = starts[i] if i < len(starts) else r + 0x400
        e = min(e, r + 0x3000)
        for off in range(r, e, 4):
            w = struct.unpack_from("<I", b, off - OFF)[0]
            if w >> 26 == 0b100101:
                imm = w & 0x3ffffff
                if imm >> 25: imm -= 1 << 26
                n = names.get(off + imm * 4, "")
                if n.endswith("$$.ctor"):
                    k = n[:-len("$$.ctor")]
                    if k != c and k in action_classes: out.add(k)
    return sorted(out)

ATT = {0: "None", 1: "Physics", 2: "Magic", 3: "SkillNormal"}
NEVER_IDS = {10, 11, 12, 25, 26, 27, 28, 1058}
SPECIAL = {1219: "every_hit", 658: "every_hit", 554: "every_hit", 117: "custom_check", 159: "custom_check",
           301: "first_hit_and_flag"}
skills = {}
for r in csv.DictReader(open(os.path.join(il2.DATA, "skills", "skills.csv"), encoding="utf-8-sig")):
    skills[int(r["SkillUid"])] = r
rows = []
for sid, c in sorted(fac.items()):
    _, r_id = find(c, "get_ActionID"); _, r_at = find(c, "get_AttackType"); _, r_et = find(c, "get_ExpType")
    o_fl, r_fl = find(c, "get_IsExpDefFluctuate")
    aid = const(r_id) if r_id else "dynamic"
    action_id = sid if aid == "dynamic" else aid
    at = const(r_at) if r_at else "dynamic"
    et = const(r_et) if r_et else at
    if o_fl is None or o_fl == "SkillActionBase": fl = "true"
    else:
        v = const(r_fl); fl = "true" if v == 1 else "false" if v == 0 else "conditional"
    if c == "LunaDitherStarAction": fl = "true"
    kids = child_actions(c)
    if action_id in NEVER_IDS: mode = "never (IsExpSkill excludes ActionID)"
    elif fl == "false": mode = "never (IsExpDefFluctuate=false)"
    elif et == 0: mode = "never (ExpType None: no proration slot)"
    elif sid in SPECIAL or c == "SlashReaperAction": mode = SPECIAL.get(sid, "custom_check") + ("" if fl != "conditional" else " + class check")
    elif fl == "conditional": mode = "first_hit_per_target if class check passes"
    else: mode = "first_hit_per_target"
    sk = skills.get(sid, {})
    slot = ("Normal" if action_id == 0 else {1: "Skill", 2: "Magic", 3: "Normal"}.get(et, "dynamic" if et == "dynamic" else "none"))
    rows.append(dict(skill_uid=sid, name_th=sk.get("name_th", ""), tree=sk.get("tree", ""), cls=c, action_id=action_id,
                     attack_type=ATT.get(at, at), exp_type=ATT.get(et, et), slot=slot, is_exp_def_fluctuate=fl,
                     mode=mode, child_actions=";".join(kids)))
OUT = os.path.join(il2.DATA, "proration_calculator")
with open(OUT + r"\skill_proration_modes.csv", "w", encoding="utf-8-sig", newline="") as f:
    w = csv.DictWriter(f, fieldnames=list(rows[0])); w.writeheader(); w.writerows(rows)
json.dump(rows, open(OUT + r"\skill_proration_modes.json", "w", encoding="utf-8"), ensure_ascii=False, indent=1)
json.dump(rows, open(r"D:\toram_re\state\_skill_table.json", "w", encoding="utf-8"), ensure_ascii=False)
from collections import Counter
print(len(rows), Counter(r["mode"] for r in rows)); print(Counter(r["slot"] for r in rows))
print(sum(1 for r in rows if r["child_actions"]), Counter(r["attack_type"] for r in rows))
