"""Coverage audit of skills/damage/skill_reference.json -> skills/damage/COVERAGE.md + coverage.csv (one row per tree skill)."""
import json, csv, re, collections, os

OUT = r"D:\toram reverse data\skills\damage"
recs = json.load(open(os.path.join(OUT, "skill_reference.json"), encoding="utf-8"))
idx = json.load(open(os.path.join(OUT, "buff_owner_index.json"), encoding="utf-8"))
S = [r for r in recs if r.get("in_skill_tree")]

MARKERS = []
CRAFT_TREES = {"MerchantSkill", "SmithSkill", "AlchemySkill"}
# Proven by scan_const.py / scan_switch.py / dis_android.py on libil2cpp.so (Code):
PROVEN = {
    192: ("no-client-code", "tree-header placeholder: no SkillId enum entry (enum jumps 168 -> 193), max_level 0, no text/icon"),
    931: ("no-client-code", "pet passive slot, client-inert: SkillId const + UI IsPassive bit only; no CreateMasterySkill case, no SkillId 931 constant/switch consumer in the binary"),
    951: ("no-client-code", "pet passive slot, client-inert: SkillId const + UI IsPassive bit only; no CreateMasterySkill case, no SkillId 951 constant/switch consumer in the binary"),
}
LEVEL_RX = re.compile(r"\d")


def status(r):
    """-> (state, reason)"""
    has_cls = bool(r.get("class") or r.get("mastery_class"))
    if not has_cls and r["uid"] in PROVEN: return PROVEN[r["uid"]]
    if not has_cls:
        if "CanNotUse" in r["flags"]: return "no-client-code", "flag CanNotUse (system/unreleased)"
        if r["tree_type"] in CRAFT_TREES and (r.get("consumers") or r.get("consumer_effects")): return "consumer-only", "crafting skill read by client code (rate/limit/unlock, see page)"
        if r["tree_type"] in CRAFT_TREES: return "no-client-code", "crafting/merchant: effect is server-side (text only)"
        if r["tree_type"] == "LuckSkill": return "no-client-code", "unreleased tree (JP-only text)"
        if r.get("consumers") or r.get("consumer_effects"): return "consumer-only", "no action class; effect applied in consumer code (see page)"
        if r.get("buffs"): return "buff-only", "no action class; attached buff decoded"
        return "unresolved", "no class, no buff, no consumer found"
    open_items = []
    trunc = [m for m, v in r.get("methods", {}).items() if v.get("truncated")]
    if trunc: open_items.append("truncated: " + ",".join(trunc)[:80])
    # marker buff: GetParam is constant 0 and the ctor sets nothing -> the buff only signals "active"; its effect is read by the Action/consumer code
    for bn, b in r.get("buffs", {}).items():
        has_data = b.get("get_param") or any(c.get("fields") for c in b.get("ctors", [])) or b.get("other")
        if not has_data: MARKERS.append((r["uid"], bn))
    if open_items: return "partial", "; ".join(open_items)
    return "complete", ""


rows = []
for r in S:
    st, why = status(r)
    rows.append({"uid": r["uid"], "name_th": r["name_th"], "name_en": r.get("name_en") or "", "tree": r["tree_type"],
                 "class": r.get("class") or r.get("mastery_class") or "", "state": st, "reason": why,
                 "buffs": len(r.get("buffs", {})), "consumers": len(r.get("consumers", [])),
                 "consumer_effects": len(r.get("consumer_effects", []))})
with open(os.path.join(OUT, "coverage.csv"), "w", encoding="utf-8-sig", newline="") as f:
    w = csv.DictWriter(f, fieldnames=list(rows[0]))
    w.writeheader(); w.writerows(rows)

cnt = collections.Counter(x["state"] for x in rows)
unattached = [b for b, v in idx.items() if not v["owners"]]
L = ["# Skill data coverage audit", "", f"Generated from `skill_reference.json` ({len(S)} tree skills, {len(recs)} records).", "",
     "| State | Count | Meaning |", "|---|---|---|",
     f"| complete | {cnt['complete']} | class decoded, no truncation (marker buffs listed separately) |",
     f"| partial | {cnt['partial']} | decoded but an open item remains (listed below) |",
     f"| buff-only / consumer-only | {cnt['buff-only'] + cnt['consumer-only']} | no action class; effect found through a buff or consumer code |",
     f"| no-client-code | {cnt['no-client-code']} | proven no combat code: crafting/merchant/system/unreleased |",
     f"| unresolved | {cnt['unresolved']} | nothing found yet: real work left |", ""]
for st in ("unresolved", "partial"):
    L.append(f"## {st}")
    L.append("")
    for x in rows:
        if x["state"] == st: L.append(f"- {x['uid']} {x['name_en'] or x['name_th']} (`{x['tree']}`): {x['reason']}")
    L.append("")
L.append("## Marker buffs (GetParam is constant 0, constructor sets nothing: presence flag only)")
L.append("")
# get_Flag constants read from libil2cpp.so (SkillBufferFlag: 0x400 ChangeEquipRemove, 0x800 HideBufferIcon, 0x4000 Special)
FLAGS = {"FastAttackBuf": "ChangeEquipRemove", "HammerDownBuf": "ChangeEquipRemove|HideBufferIcon", "HorizontalCutBuf": "ChangeEquipRemove",
         "BoomerangBuf": "ChangeEquipRemove|Special", "MagicBalkanBuf": "HideBufferIcon|Special", "ExorcismBuf": "ChangeEquipRemove",
         "ConversionBuf": "ChangeEquipRemove", "DeadlySpearBuf": "ChangeEquipRemove"}
byuid = {r["uid"]: r for r in recs}
for u, bn in sorted(set(MARKERS)):
    cons = sorted({c.split(" (")[0] for c in byuid[u].get("consumers", [])})
    L.append(f"- {u} `{bn}` flags: {FLAGS.get(bn, 'default')}; readers: " + (", ".join(f"`{c}`" for c in cons[:5]) + (" ..." if len(cons) > 5 else "") if cons
             else "none by constant id (buff only shown/timed by the generic buff manager)"))
L.append("")
L.append("## Buff classes with no skill owner")
L.append("")
WHY = {"BloodSuckingBuf": "created by SkillComboState.TemporaryUseSkill (combo system, not a skill id)",
       "GemCartHealStockpileBuf": "gem-cart buff, not a skill", "SensoryBuf": "song helper (SkillBufferManager.UpdateValidSongBuf)",
       "DancerBufferBase": "abstract base of the dance buffs", "EquipSkillBufferBase": "abstract base class",
       "CircleBufferBase": "abstract base class", "CountBufferBase": "abstract base class",
       "NextAttackBufferBase": "abstract base class", "SkillBufferDataBase": "abstract base class", "SongBufferBase": "abstract base of the song buffs"}
for b in unattached: L.append(f"- `{b}`: {WHY.get(b, 'unknown')}")
open(os.path.join(OUT, "COVERAGE.md"), "w", encoding="utf-8").write("\n".join(L) + "\n")
print(dict(cnt), "unattached", len(unattached))
