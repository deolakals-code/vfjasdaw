"""Who reads each mastery?  Evidence layers per mastery uid (all Code, static; nothing checked in game):
  level   : skill_consumers.json, via GetSkillLv  (functions that read the learned level of the uid: a read of the mastery)
  buff    : skill_consumers.json, via TryGetBuf / ContainsBuffer (the same uid looked up as a running skill buffer: NOT a read of the mastery; listed so the verdict can say so)
  stat    : decoded stat functions (skills/damage/stats/decoded/*) that contain `SkillMasteryList[SkillId.<Class>]`
  extern  : BL/B callers outside the mastery class of any method of the mastery class (direct calls; .cctor and the vtable overrides excluded; SkillFactory.CreateMasterySkill -> .ctor is creation, not a read, and is dropped)
  dict    : functions that call Dictionary<Int32Enum,object>.TryGetValue / get_Item / ContainsKey with the uid as constant w1 (candidates: the receiver is not checked, other Int32Enum-keyed dictionaries share the stub; confirm by decoding)
Output: player_status/mastery_readers.json = {uid: {class, skill: [...], stat: [...], extern: [...]}} for every mastery of mastery_table.json.
Run (cwd D:\\toram_re):  python "D:\\toram reverse data\\scripts\\mastery_readers.py"
"""
import sys, os, re, json, glob, struct, bisect, collections

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
sys.path.append(r"D:\toram_re")          # after the scripts dir: D:\toram_re holds stale copies of dis_android / symexec / ...
import dis_android as D
import il2

ROOT = r"D:\toram reverse data"
OUT = ROOT + r"\player_status\mastery_readers.json"
STAT = ROOT + r"\skills\damage\stats\decoded"
MASTERY_READS = ("level", "stat", "extern", "dict")          # a read of the mastery itself; "buff" = the same id looked up as a running skill buffer (TryGetBuf / ContainsBuffer), which is not a read of the mastery
NOISE = re.compile(r"\.cctor|\$\$ctor|\$\$(Get|Set)Value$|MoveNext|^System\.")


def cls_of(fn):
    return fn.split("$$", 1)[0]


DICT_CALLEES = ("Dictionary<Int32Enum, object>$$TryGetValue", "Dictionary<Int32Enum, object>$$get_Item", "Dictionary<Int32Enum, object>$$ContainsKey")
BACK = 14


def bl_target(w, pc):
    if (w >> 26) not in (0x25, 0x05):
        return None
    imm = w & 0x3ffffff
    if imm & 0x2000000:
        imm -= 0x4000000
    return pc + imm * 4


def dict_readers(code, s, uids):
    """uid -> functions with `Dictionary<Int32Enum,object>.<TryGetValue|get_Item|ContainsKey>(.., uid ..)`.  The compiler also outlines the call into an unnamed 1-3 instruction thunk
    (`mov w1,#40; bl thunk`), so a branch to the instruction 0-3 words before a branch to the stub counts as the stub."""
    dtgt = {a for a, n in D.names.items() if n.endswith(DICT_CALLEES)}
    assert len(dtgt) == 3, dtgt
    n = len(code) // 4
    words = struct.unpack_from("<%dI" % n, code, 0)
    alias = set(dtgt)
    for i, w in enumerate(words):
        pc = s + i * 4 + D.OFF
        if bl_target(w, pc) in dtgt:
            alias.update(pc - 4 * k for k in range(1, 4))
    hits = collections.defaultdict(set)
    for i, w in enumerate(words):
        pc = s + i * 4 + D.OFF
        t = bl_target(w, pc)
        if t not in alias:
            continue
        fn = D.starts[bisect.bisect_right(D.starts, pc) - 1]
        for k in range(1, BACK + 1):
            if i - k < 0:
                break
            v = words[i - k]
            if ((v >> 23) & 0x1ff) in (0b010100101, 0b110100101) and (v & 0x1f) == 1 and ((v >> 21) & 3) == 0:
                if ((v >> 5) & 0xffff) in uids:
                    hits[(v >> 5) & 0xffff].add(fn)
                break
            if (v >> 26) == 0x25 or v == 0xd65f03c0:
                break
    return {u: {D.names.get(f, hex(f)) for f in fs} for u, fs in hits.items()}


def main():
    mt = json.load(open(ROOT + r"\player_status\mastery_table.json", encoding="utf-8"))["masteries"]
    sc = json.load(open(r"D:\toram_re\skill_consumers.json", encoding="utf-8"))
    classes = {u: m["class"] for u, m in mt.items()}
    by_class = collections.defaultdict(set)          # class -> uids (two uids may share a class)
    for u, c in classes.items():
        by_class[c].add(u)

    stat = collections.defaultdict(set)
    for p in glob.glob(STAT + r"\*\*.json"):
        t = open(p, encoding="utf-8").read()
        fn = os.path.basename(os.path.dirname(p)) + "/" + os.path.basename(p)[:-5]
        for m in re.finditer(r"SkillMasteryList\[SkillId\.(\w+)\]", t):
            stat[m.group(1)].add(fn)

    tgt = {}
    for a, n in D.names.items():
        if "$$" in n:
            c = cls_of(n)
            if c in by_class and not NOISE.search(n):
                tgt[a] = n
    s, e = il2.TEXT_RANGE
    code = D.b[s:e]
    ext = collections.defaultdict(set)
    for i in range(0, len(code) - 3, 4):
        w = struct.unpack_from("<I", code, i)[0]
        if (w >> 26) in (0x25, 0x05):
            imm = w & 0x3ffffff
            if imm & 0x2000000:
                imm -= 0x4000000
            pc = s + i + D.OFF
            t = pc + imm * 4
            if t in tgt:
                j = bisect.bisect_right(D.starts, pc) - 1
                caller = D.names.get(D.starts[j], hex(D.starts[j]))
                c = cls_of(tgt[t])
                if cls_of(caller) != c and not caller.startswith(c + "."):
                    ext[c].add(f"{caller} -> {tgt[t].split('$$', 1)[1]}")

    out = {}
    dic = dict_readers(code, s, set(int(u) for u in classes))
    for u, c in sorted(classes.items(), key=lambda kv: int(kv[0])):
        ex = sorted(x for x in ext.get(c, []) if not x.startswith("SkillFactory$$CreateMasterySkill -> "))
        ids = [x for x in sc.get(u, []) if cls_of(x["fn"]) != c]
        out[u] = {"class": c, "level": sorted({x["fn"] for x in ids if x["via"] == "GetSkillLv"}), "buff": sorted({x["fn"] for x in ids if x["via"] != "GetSkillLv"}),
                  "stat": sorted(stat.get(c, [])), "extern": ex, "dict": sorted(dic.get(int(u), []))}
    json.dump(out, open(OUT, "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    mr = json.load(open(ROOT + r"\player_status\mastery_reach.json", encoding="utf-8"))
    none = [u for u in mr["idle"] if not any(out[str(u)][k] for k in MASTERY_READS)]
    print(len(out), "masteries;", len(mr["idle"]), "idle;", len(none), "idle with no mastery read found:", none)


if __name__ == "__main__":
    main()
