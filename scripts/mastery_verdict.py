"""Verdict for every mastery that moves no Details row (missing-data/09 item 2).
Inputs : player_status/mastery_reach.json (idle list: alone, top level), mastery_readers.json (run mastery_readers.py first), status_spec.json (the functions the Details rows evaluate), mastery_table.json.
A "read of the mastery" = the learned level (GetSkillLv), its SkillMasteryList entry (decoded stat functions, constant-uid TryGetValue / get_Item) or a direct call of a method of its class.
The same id looked up as a running skill buffer (TryGetBuf / ContainsBuffer) is NOT a read of the mastery; it is kept under `buffLookups`.
Verdict:
  a  combat / active only: the mastery is read, none of the reading functions is evaluated by a Details row  (`readers` = class.method)
  b  a reading function IS evaluated by a Details row.  `probe` = rows that move when the mastery is learned at its top level, alone or together with every other mastery, over all main x 8 sub weapon
     types x 4 armour abilities (`{row: {main, sub, armour, withOtherMasteries}}`); an empty probe means the row needs an input the calculator does not have (`gate`: buffers / flags the reader tests)
  c  no read of the mastery anywhere in libil2cpp (the class only has its constructor and GetMasteryParam): dead data, or applied by the server  (Code, absence; the cause is Inferred)
Output : player_status/mastery_verdict.json
Run (cwd D:\\toram_re):  python "D:\\toram reverse data\\scripts\\mastery_verdict.py"
Label : Code (static + reference evaluator); not checked in game.
"""
import sys, os, re, json, glob, subprocess

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
sys.path.append(r"D:\toram_re")          # after the scripts dir: D:\toram_re holds stale copies of dis_android / symexec / ...
import player_status as P

ROOT = r"D:\toram reverse data"
TREE = r"D:\toram_re"
OUT = ROOT + r"\player_status\mastery_verdict.json"
DEC = ROOT + r"\skills\damage\stats\decoded"
MAIN = [0] + sorted(P.CALC_OF_TYPE)
SUB = [0, 8, 10, 15, 16, 17, 19, 23]          # sub-slot weapon types (16 Knuckle: OneChance; 23 Ninjutsu scroll: WeaponInBothHands)
BODY = [0, 1, 2, 3]


def norm(f):
    return f.replace("$$", ".")


def rows(main, sub, body, **kw):
    ch = P.Character(lv=200, str_=120, int_=120, vit=100, agi=120, dex=120, weapon=P.item(main, 200, 20, 9), sub=P.item(sub, 60, 5, 5), body=P.item(20, 200, 0, 9, body), **kw)
    res, _ = P.compute(ch)
    return [(r["type"], r["value"]) for r in res]


def probe(uid, maxlv, others):
    """rows moved by learning `uid` at its top level, alone and together with every other mastery at Lv 10; the first (main, sub, body, with) that moves each row"""
    moved = {}
    for with_all in (0, 1):
        skills = {int(u): 10 for u in others} if with_all else {}
        skills[uid] = maxlv          # the top level: many tables are 0 below their first step (DefUp max 20, AfterShield 285)
        for m in MAIN:
            for s in SUB:
                for b in BODY:
                    base = rows(m, s, b, skills={k: v for k, v in skills.items() if k != uid})
                    for (t, a), (_, c) in zip(base, rows(m, s, b, skills=skills)):
                        if a != c and t not in moved:
                            moved[t] = {"main": m, "sub": s, "armour": b, "withOtherMasteries": bool(with_all)}
    return moved


def gate(fn):
    """what the reader function tests: running buffers (SkillId names), in-battle"""
    f = glob.glob(DEC + "\\*\\" + fn + ".json")
    if not f:
        return None
    t = json.dumps(json.load(open(f[0], encoding="utf-8")), ensure_ascii=False)
    out = sorted(set(re.findall(r"TryGetBuf(?:<\w+>)?\([^,]*, (?:SkillId\.)?(\w+)", t)))
    if re.search(r"\(isBattle & 1\)", t):
        out.append("isBattle")
    return out


def main():
    mr = json.load(open(ROOT + r"\player_status\mastery_reach.json", encoding="utf-8"))
    rd = json.load(open(ROOT + r"\player_status\mastery_readers.json", encoding="utf-8"))
    mt = json.load(open(ROOT + r"\player_status\mastery_table.json", encoding="utf-8"))["masteries"]
    spec = {norm(k) for k in json.load(open(ROOT + r"\player_status\status_spec.json", encoding="utf-8"))["fns"]}
    out = {}
    for uid in mr["idle"]:
        x, m = rd[str(uid)], mt[str(uid)]
        readers = sorted({f for f in x["level"] + x["dict"] + [s.split("/", 1)[1] for s in x["stat"]] + [e.split(" -> ")[0] for e in x["extern"]]})
        details = [f for f in readers if norm(f) in spec]
        rec = {"class": m["class"], "name": m["name"], "maxLv": m["maxLv"], "paramIds": sorted(p["id"] for p in m["params"].values()), "readers": readers, "buffLookups": x["buff"]}
        if details:
            # one process per probe: the evaluator keeps every computed character alive, a single process ran out of memory
            r = subprocess.run([sys.executable, os.path.abspath(__file__), "--probe", str(uid)], capture_output=True, text=True, cwd=TREE)
            assert r.returncode == 0, r.stderr[-400:]
            moved = json.loads(r.stdout.strip().splitlines()[-1])
            rec.update(verdict="b", detailsReaders=details, probe=moved, gate={f: gate(f) for f in details})
        elif readers:
            rec["verdict"] = "a"
        else:
            rec["verdict"] = "c"
        out[str(uid)] = rec
        print(uid, m["class"], rec["verdict"], len(readers), (sorted(rec.get("probe", {})) if details else ""), flush=True)
    json.dump(out, open(OUT, "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    cnt = {v: sum(1 for r in out.values() if r["verdict"] == v) for v in "abc"}
    print(len(out), cnt)


if __name__ == "__main__":
    if len(sys.argv) == 3 and sys.argv[1] == "--probe":
        mt_ = json.load(open(ROOT + r"\player_status\mastery_table.json", encoding="utf-8"))["masteries"]
        u_ = int(sys.argv[2])
        print(json.dumps(probe(u_, mt_[str(u_)]["maxLv"], [u for u in mt_ if int(u) != u_])))
    else:
        main()
