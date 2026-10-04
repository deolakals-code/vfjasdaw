"""Active-buff table for the character calculator (missing-data/09 item 5).  Output: player_status/buff_table.json (+ BUFF_TABLE.md summary).

Sources (all Code, decoded from libil2cpp.so; nothing checked in game):
  skills/damage/buff_values.json   every buff class of every skill: parameter -> table / cases / formula(+ machine form `calc`), timer, stack cap (build_buff_values.py)
  player_status/status_spec.json   the functions the Details rows evaluate (their reads of SkillBufferManager are what a buff moves)
  readable/code/enums.txt          SkillBufferId (parameter ids) and SkillId (buff ids)
Per buff (key = skill uid = the id SkillBufferManager.ContainsBuffer / TryGetBuf take):
  classes{}  : buff class -> params{name: {id, status, byLevel | cases | calc}, timer, stack}   (same form as player_status/mastery_table.json)
  reach      : Details rows the buff moves and through which read
               agg    GetSkillBufferParam(SkillBufferId.X)  = SUM over every running buff of buff.GetParam(X)  (SkillBufferManager.GetSkillBufferParam 0x236a65c: loop over skillBufList.Values, w19 += GetParam(id))
               direct TryGetBuf / ContainsBuffer(SkillId.Y)  and  SkillBufferDataBase.GetParam(TryGetBuf.buf(.., SkillId.Y), id)
  statReads  : Details rows whose total a parameter formula reads (inputs *_total), with `at`: "cast" = the value is computed by the caster's call site / constructor when the buff is added
               (so it uses the totals of that moment), "live" = the class's GetParam reads player state on every call (list under live)
  deps       : buff A -> buff B when a parameter of A reads a row that B moves  => cast B first; cycles are listed (a cycle means the calculator cannot get a fixed order from the client alone)
Run (cwd D:\\toram_re):  python "D:\\toram reverse data\\scripts\\build_buff_table.py"
"""
import sys, os, re, json, collections

ROOT = r"D:\toram reverse data"
OUT = ROOT + r"\player_status\buff_table.json"
ENUMS = ROOT + r"\TORAM ONLINE BIGDATA\readable\code\enums.txt"
BV = ROOT + r"\skills\damage\buff_values.json"
REF = ROOT + r"\skills\damage\skill_reference.json"
SPEC = ROOT + r"\player_status\status_spec.json"
STAT_INPUT = re.compile(r"^(STR|INT|VIT|AGI|DEX|CRT|LUK|MEN|TEC|ATK|MATK|MAXHP|MAXMP|HIT|FLEE|ASPD|CSPD)_(total|base)$")
ROW_OF = {"ATK": "Atk", "MATK": "Matk", "MAXHP": "MaxHp", "MAXMP": "MaxMp", "HIT": "Hit", "FLEE": "Flee", "ASPD": "Aspd", "CSPD": "Cspd"}


def enum(name):
    out, on = {}, False
    for ln in open(ENUMS, encoding="utf-8"):
        if ln.startswith("."):
            on = ln.startswith(f".{name} :")
            continue
        if on:
            m = re.match(r"\s+(\w+) = (-?\d+)", ln)
            if m:
                out[m.group(1)] = int(m.group(2))
    return out


SKILL_ID, BUF_ID = enum("SkillId"), enum("SkillBufferId")
BUF_NAME = {v: k for k, v in BUF_ID.items()}


def row_reach(spec):
    """row type -> {agg: {SkillBufferId name: [fn]}, direct: {uid: [fn]}, param: {(uid, name): [fn]}}  through the call closure of the row expression"""
    fns, keys = spec["fns"], set(spec["fns"])
    virt = collections.defaultdict(set)
    for k in keys:
        m = re.match(r"(EquipItemData\.\w+Calculator)\.(\w+)$", k)
        if m and m.group(1) != "EquipItemData.WeaponTypeCalculatorBase":
            virt[m.group(2)].add(k)

    def refs(text):
        out = set()
        for m in re.finditer(r"([A-Za-z_][\w.]*(?:<[^<>()]*>)?)\(", text):
            n = m.group(1)
            if n in keys:
                out.add(n)
            mm = re.match(r"EquipItemData\.WeaponTypeCalculatorBase\.(\w+)$", n)
            if mm:
                out |= virt.get(mm.group(1), set())
        return out
    adj = {k: refs(json.dumps(v, ensure_ascii=False)) - {k} for k, v in fns.items()}
    rx_agg = re.compile(r"GetSkillBufferParam\(PlayerStatusBase\.get_SkillBufferManager\(\), SkillBufferId\.(\w+)")
    rx_dir = re.compile(r"(?:TryGetBuf|ContainsBuffer|TryGetBuf\.buf)(?:<\w+>)?\(PlayerStatusBase\.get_SkillBufferManager\(\), (?:SkillId\.(\w+)|(\d+))")
    rx_par = re.compile(r"SkillBufferDataBase\.GetParam\(TryGetBuf\.buf\(PlayerStatusBase\.get_SkillBufferManager\(\), SkillId\.(\w+)\), (?:SkillBufferId\.(\w+)|(\d+))\)")
    res = {}
    for r in spec["rows"]:
        seen, st = set(), list(refs(r["expr"]))
        while st:
            x = st.pop()
            if x in seen:
                continue
            seen.add(x)
            st += list(adj.get(x, ()))
        rec = {"agg": collections.defaultdict(set), "direct": collections.defaultdict(set), "param": collections.defaultdict(set)}
        for fn in seen:
            t = json.dumps(fns[fn], ensure_ascii=False)
            for m in rx_agg.finditer(t):
                rec["agg"][m.group(1)].add(fn)
            for m in rx_dir.finditer(t):
                rec["direct"][SKILL_ID.get(m.group(1), m.group(1)) if m.group(1) else int(m.group(2))].add(fn)
            for m in rx_par.finditer(t):
                nm = m.group(2) or BUF_NAME.get(int(m.group(3)), m.group(3))
                rec["param"][(SKILL_ID.get(m.group(1), m.group(1)), nm)].add(fn)
        res.setdefault(r["type"], []).append(rec)
    return res


KIND_BASE = {"SongBufferBase": "song", "DancerBufferBase": "dance", "CircleBufferBase": "circle", "EquipSkillBufferBase": "equip", "CountBufferBase": "count", "NextAttackBufferBase": "nextAttack"}
MANAGER = {          # SkillBufferManager methods that own the state of the open-timer kinds (names read from methods.tsv, asserted below)
    "song": ["AddSelfSongBuf", "AddOtherSongBuf", "ReceiveOtherSongBuf", "RemoveOtherSongBuf", "UpdateSelfSongBuf", "UpdateOtherSongBuf", "UpdateValidSongBuf", "SuspendedSong", "ResumeSong", "CheckSong", "TryGetImprovisationSongBuf"],
    "dance": ["AddSelfDanceBuf", "AddOtherDanceBuf", "ChangeDanceBufLevel"],
    "circle": ["UpdateCircleBuf", "UpdateCircleSelfBuf", "UpdateCircleOtherBuf", "DrawCircleBufferLine", "RemoveCircleBufferLine"],
    "aggregate": ["GetSkillBufferParam", "ContainsBuffer", "TryGetBuf", "GetSkillBufferLevel"],
}


def base_chain(ref_rec, cls):
    """buff class -> names of its base classes (constructor chain)"""
    chain, seen, c = [], set(), cls
    while c and c not in seen:
        seen.add(c)
        b = ((ref_rec.get("buffs") or {}).get(c) or {})
        ctors = b.get("ctors") or []
        bc = ctors[0].get("base_ctor") if ctors else None
        c = bc["class"] if bc else None
        if c:
            chain.append(c)
    return chain


ORPHAN = r"D:\toram_re\skillrecipes_orphan_bufs.json"
SONGS = ["HealingSongBuf", "EnthusiasticSongBuf", "FairySongBuf", "KnowledgeSongBuf", "PhantomSongBuf", "SongOfLifeBuf"]


def songs():
    """The six concrete song classes (SongBufferBase subclasses; skill_reference only lists the abstract base for skills 769-775). Per class: constructor fields as formulas of `lv` (+ `mLv` for HealingSong),
    their values for Lv 1..10, and GetParam(id) as decoded.  The Details rows each song moves are the `direct` reach of its SkillId (SkillBufferManager.TryGetBuf / SkillBufferDataBase.GetParam in the HP / MP recovery
    and hit functions); how the ctor fields reach GetParam ids (the song system copies them in Updata / UpdateValidSongBuf) is not traced - residual."""
    sys.path.append(r"D:\toram_re")          # after the scripts dir: D:\toram_re holds stale copies of dis_android / symexec / ...
    import calc_engine as CE
    o = json.load(open(ORPHAN, encoding="utf-8"))
    out = {}
    for c in SONGS:
        rec = o[c]
        ctor = next(v for k, v in rec.items() if k.startswith(".ctor"))
        fields = {}
        for path in ctor["paths"]:
            for f, e in path["fields"].items():
                e2 = e.replace(" & 255", "")
                ev = lambda lv: CE.Evaluator({"lv": lv, "Lv": lv, "mLv": 0}).eval(e2)
                try:
                    fields[f] = {"expr": e2, "byLevel": [ev(lv) for lv in range(1, 11)], **({"inputs": ["mLv"]} if "mLv" in e else {})}
                except Exception:
                    fields[f] = {"expr": e2}
        gp = next(v for k, v in rec.items() if k.startswith("GetParam"))
        params = [{"when": [w for w in p_["cond"] if w != "BuffEffectActive ne 0"], "ret": p_["ret"][0]} for p_ in gp["paths"] if "BuffEffectActive eq 0" not in p_["cond"]]
        out[c] = {"skillId": c[:-3], "uid": SKILL_ID.get(c[:-3]), "fields": fields, "getParam": params, "reachRows": None}
    return out


def main():
    TSV = ROOT + r"\TORAM ONLINE BIGDATA\readable\code\methods.tsv"
    rows_ = [ln.rstrip("\r\n").split("\t") for ln in open(TSV, encoding="utf-8")]
    methods = {r[4].split("(")[0].split()[-1] for r in rows_ if len(r) > 4 and r[1] == "SkillBufferManager"}
    missing = [m for v in MANAGER.values() for m in v if m not in methods]
    assert not missing, missing
    bv = json.load(open(BV, encoding="utf-8"))["skills"]
    spec = json.load(open(SPEC, encoding="utf-8"))
    ref = {r["uid"]: r for r in json.load(open(REF, encoding="utf-8")) if r.get("in_skill_tree")}
    reach = row_reach(spec)
    agg_rows = collections.defaultdict(set)          # SkillBufferId name -> rows
    dir_rows = collections.defaultdict(set)          # buff uid -> rows
    par_rows = collections.defaultdict(set)          # (uid, name) -> rows
    for row, recs in reach.items():
        for rec in recs:
            for n in rec["agg"]:
                agg_rows[n].add(row)
            for u in rec["direct"]:
                dir_rows[u].add(row)
            for k in rec["param"]:
                par_rows[k].add(row)
    live = {}
    for uid, r in ref.items():
        for cls, b in (r.get("buffs") or {}).items():
            gp = b.get("get_param")
            if gp is not None and re.search(r"status\.|SecondaryStatus|PlayerStatusBase|BonusManager|SkillMasteryList|GetSkillLv", json.dumps(gp, ensure_ascii=False)):
                live.setdefault(str(uid), []).append(cls)
    buffs, moved_by = {}, collections.defaultdict(set)
    for uid, classes in bv.items():
        u = int(uid)
        rec = {"name": (ref.get(u) or {}).get("name_th"), "classes": {}, "reach": {"agg": {}, "direct": sorted(dir_rows.get(u, [])), "param": {}}, "statReads": []}
        rows_all = set(dir_rows.get(u, []))
        for cls, c in classes.items():
            params = {}
            for pn, p in c["params"].items():
                e = {"id": BUF_ID.get(pn), "status": p["status"]}
                if p["status"] == "table":
                    e["byLevel"] = p["v"]
                elif p["status"] == "cases":
                    e.update(cases=p["cases"], byLevel=p.get("v"), **({"partial": True} if p.get("partial") else {}))
                else:
                    if p.get("calc"):
                        e["calc"] = p["calc"]
                        for nm, spc in p["calc"]["inputs"].items():
                            if STAT_INPUT.match(nm):
                                row = ROW_OF.get(nm.split("_")[0], nm.split("_")[0])
                                rec["statReads"].append({"param": pn, "class": cls, "input": nm, "row": row, "at": "live" if cls in live.get(uid, []) else "cast"})
                    else:
                        e["unsupported"] = p.get("unsupported") or p.get("why")
                if pn in agg_rows:
                    rec["reach"]["agg"].setdefault(pn, sorted(agg_rows[pn]))
                    rows_all |= agg_rows[pn]
                if (u, pn) in par_rows:
                    rec["reach"]["param"][pn] = sorted(par_rows[(u, pn)])
                    rows_all |= par_rows[(u, pn)]
                params[pn] = e
            chain = base_chain(ref.get(u) or {}, cls)
            kinds = sorted({KIND_BASE[b] for b in chain if b in KIND_BASE})
            rec["classes"][cls] = {"params": params, "bases": chain, **({"kind": kinds} if kinds else {}), **({"timer": c["timer"]} if c.get("timer") else {})}
        rec["rows"] = sorted(rows_all)
        for r_ in rows_all:
            moved_by[r_].add(u)
        buffs[uid] = rec
    # every buff class of the reference that buff_values.json did not tabulate: its GetParam entries as decoded (bonus id / name / value expression / condition), else the hooks that carry the effect
    untab = []
    for uid, r in ref.items():
        for cls, b in (r.get("buffs") or {}).items():
            if str(uid) in bv and cls in bv[str(uid)]:
                continue
            hooks = b.get("hooks")
            untab.append({"uid": uid, "class": cls, "bases": base_chain(r, cls),
                          "getParam": [{k: e.get(k) for k in ("bonus_id", "bonus", "value", "when")} for e in (b.get("get_param") or [])],
                          "hooks": sorted(hooks) if isinstance(hooks, (dict, list)) and hooks else []})
    song_tab = songs()
    for s in song_tab.values():
        s["reachRows"] = sorted(dir_rows.get(s["uid"], []))
    deps, nodes = [], {}
    for uid, rec in buffs.items():
        need = {s["row"] for s in rec["statReads"] if s["at"] == "cast" and s["input"].endswith("_total")}          # *_base is the typed-in base stat: no buff changes it
        for r_ in need:
            for b in moved_by.get(r_, ()):
                if b != int(uid):
                    deps.append({"buff": int(uid), "reads": r_, "afterBuff": b})
        nodes[int(uid)] = need
    # cycles: a buff reads a row that another buff moves and the reverse
    edges = collections.defaultdict(set)
    for d in deps:
        edges[d["buff"]].add(d["afterBuff"])
    cycles = sorted({tuple(sorted((a, b))) for a, bs in edges.items() for b in bs if a in edges.get(b, ())})
    self_loops = sorted(int(u) for u, rec in buffs.items() if {s["row"] for s in rec["statReads"] if s["input"].endswith("_total")} & set(rec["rows"]))          # a buff whose own parameter reads a total that the same buff moves
    live_reads = [{"buff": int(u), **s, "buffMovesRows": rec["rows"]} for u, rec in buffs.items() for s in rec["statReads"] if s["at"] == "live"]
    out = {"note": "active buffs for the character calculator. byLevel[i] = buff Lv i+1. `agg` rows: the row reads SkillBufferManager.GetSkillBufferParam(id) = the SUM of that parameter over all running buffs. "
                   "A parameter that reads *_total (statReads) is computed when the buff is added (at = cast) from the totals of that moment; at = live only for the classes in `live`. Code, not checked in game.",
           "aggregation": "GetSkillBufferParam(bufferId) = sum over skillBufList.Values of value.GetParam(bufferId) (virtual call, add)",
           "live": live, "deps": deps, "cycles": [list(c) for c in cycles], "selfReads": self_loops, "liveReads": live_reads, "managerMethods": MANAGER, "untabulated": untab, "songs": song_tab, "buffs": buffs}
    json.dump(out, open(OUT, "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    n_cls = sum(len(b["classes"]) for b in buffs.values())
    n_par = sum(len(c["params"]) for b in buffs.values() for c in b["classes"].values())
    print(f"{len(buffs)} buffs, {n_cls} classes, {n_par} parameters; reach: {sum(1 for b in buffs.values() if b['rows'])} buffs move >=1 Details row; "
          f"statReads {sum(len(b['statReads']) for b in buffs.values())}, deps {len(deps)}, cycles {len(cycles)}, selfReads {len(self_loops)}, liveReads {len(live_reads)}, live classes {sum(len(v) for v in live.values())}; untabulated classes {len(untab)} (with GetParam {sum(1 for u in untab if u['getParam'])}, hooks only {sum(1 for u in untab if not u['getParam'] and u['hooks'])}, neither {sum(1 for u in untab if not u['getParam'] and not u['hooks'])})")


if __name__ == "__main__":
    main()
