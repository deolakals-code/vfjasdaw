"""Regenerate the id -> class maps by emulating the SkillFactory jump tables (functions and field offsets located by name / dump.cs):
  state/_factory_map.json   SkillFactory.CreateSkill(int id)                 skill id   -> action class
  state/_mastery_map.json   SkillFactory.CreateMasterySkill(SkillData)       mastery id -> mastery class
  state/_buffer_map.json    SkillFactory.CreateSkillBuffer(int id, ...)      skill id   -> *Buf class
usage: python build_factory_maps.py [--check]      (--check compares with the stored maps and exits 1 on any difference)
"""
import os, sys, json
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import il2
import emu_factory as E

MAX_ID = 0x600


def table(start, **kw):
    res = {sid: E.run(start, sid, 800, **kw) for sid in range(0, MAX_ID)}
    return {k: v[1] for k, v in res.items() if v[0] == "ok"}


def build():
    out = {"_factory_map": table(il2.method_rva("SkillFactory", "CreateSkill", "int id"))}
    # CreateMasterySkill reads the id from SkillData.SkillId and requires SkillMasterData.SkillType == Mastery
    out["_mastery_map"] = table(il2.method_rva("SkillFactory", "CreateMasterySkill"),
                                loads={il2.field_offset("SkillData", "SkillId"): "ARG", il2.field_offset("SkillMasterData", "SkillType"): il2.enum_values("SkillType")["Mastery"]})
    out["_buffer_map"] = table(il2.method_rva("SkillFactory", "CreateSkillBuffer", "int id"))
    return out


if __name__ == "__main__":
    new = build()
    bad = False
    for k, v in new.items():
        p = os.path.join(il2.STATE, k + ".json")
        old = json.load(open(p)) if os.path.exists(p) else None
        if "--check" in sys.argv:
            same = old == json.loads(json.dumps(v))
            print(k, len(v), "same" if same else f"DIFF (stored {len(old or {})})")
            bad |= not same
        else:
            json.dump(v, open(p, "w")); print("wrote", k, len(v))
    sys.exit(1 if bad else 0)
