"""Registlet (GemCart) data -> D:\\toram reverse data\\registlet\\
Master (Id, LevelCap, EnhancePowder) + 6-language text + GemCartId enum + buff class per id (symexec of every method,
GetBonusData traced by gem_bonusdata.py) + consumers (who reads each id) + icons.
usage: python build_registlet.py
"""
import os, re, sys, csv, json, glob, struct, shutil, collections
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))

import run_skills as R
from refutil import ENUM, evaluate
import il2
import gem_bonusdata as GB
import emu_desc_value as DV

ROOT = r"D:\toram reverse data"
BIG = os.path.join(ROOT, "TORAM ONLINE BIGDATA")
OUT = os.path.join(ROOT, "registlet")
GBID = {v: n for n, v in il2.enum_values("GemCartBufferId").items()}
BONUS = ENUM.get("Toram.Common.Bonus.BonusType", {})
LANGS = ["th", "us", "jp", "kr", "cnt", "idn"]
ENGINE_DIRECT = {**{i: "GetRecieveDamageRate" for i in (28, 39, 46, 73, 74, 75)}, 27: "GetLastDamageRate",
                 **{i: "GetTalentElementType (Inferred)" for i in range(53, 59)}}    # literal ids found in those methods' disassembly
AGGREGATED = {"ReceiveDmgUpRate", "ReceiveDmgDownRate", "LastDmgUpRate", "LastDmgDownRate", "NormalAttackRate"}   # read by GemCartBufferManager.Get*Rate


def master():
    """RegistletMaster.dec: u32 version, u16 count, count x {i16 Id, i16 LevelCap, i32 EnhancePowder} (GemCartMasterData.CreateGemCartData)."""
    files = glob.glob(os.path.join(BIG, r"data\decoded\BynaryData\*\RegistletMaster.dec"))
    blobs = {open(f, "rb").read() for f in files}
    d = open(sorted(files, key=os.path.getmtime)[-1], "rb").read()
    ver, n = struct.unpack_from("<IH", d, 0)
    assert 6 + n * 8 == len(d), "RegistletMaster layout changed"
    rows = [dict(zip(("id", "level_cap", "enhance_powder"), struct.unpack_from("<hhi", d, 6 + i * 8))) for i in range(n)]
    return rows, len(files), len(blobs)


def texts():
    out = {}
    for lg in LANGS:
        p = os.path.join(BIG, rf"readable\text\GameScene_{lg}\Registlet_{lg}.tsv")
        for r in csv.DictReader(open(p, encoding="utf-8"), delimiter="\t"):
            out.setdefault(int(r["id"]), {})[(lg, int(r["kind"]))] = r["text"].replace("\\n", "\n")
    return out


def enum_ids():
    return {v: n for n, v in il2.enum_values("GemCartId").items()}


def lvx(e):
    return re.sub(r"this\.\+0x14|\blv\b", "Lv", e)


def table(expr, cap, **env):
    vals = []
    for lv in range(1, cap + 1):
        v = evaluate(lvx(expr), Lv=lv, **env)
        if v is None: return None
        vals.append(round(v, 4) if isinstance(v, float) else v)
    return vals


def decode_class(S, cls, cap):
    """every method of GemCartBuffer.<cls>: [{name, paths:[{cond, ret, sets, calls}]}]"""
    out = {}
    for a, n in sorted(S.names.items()):
        if not n.startswith(f"GemCartBuffer.{cls}$$"): continue
        mn = n.split("$$", 1)[1]
        if mn in ("get_Id",): continue
        ex = S.Ex(a, max_paths=60, max_ins=4000); paths = ex.run()
        ps = []
        for st in paths:
            ret = S.render(st.ret[0]) if st.ret is not None else None
            sets = [(e[1], e[2] if isinstance(e[2], (int, float, str)) else S.render(e[2])) for e in st.ev if e[0] == "set"]
            calls = [f"{e[1]}({', '.join(S.render(x)[:60] for x in e[3][1:5])})" if len(e) > 3 else e[1] for e in st.ev if e[0] == "call" and "op_Implicit" not in e[1]]
            ps.append({"cond": [lvx(c) for c in st.cond], "ret": lvx(ret) if ret else None, "sets": [(a_, lvx(str(b_))) for a_, b_ in sets], "calls": calls})
        out.setdefault(mn, []).append({"addr": hex(a), "truncated": bool(ex.truncated), "paths": ps})
    return out


def main():
    R.init(); S = R._G["S"]
    rows, nver, nuniq = master()
    tx = texts(); enum = enum_ids()
    byid = {int(k): v[0] for k, v in json.load(open(os.path.join(il2.STATE, "_gemcart_byid.json"))).items()}
    fac = {int(k): v for k, v in json.load(open(os.path.join(il2.STATE, "_gemcart_factory.json"))).items()}
    cons = collections.defaultdict(list)
    for f in (os.path.join(il2.STATE, "_gemcart_consumers.json"), os.path.join(il2.STATE, "_gemcart_consumers2.json")):
        for k, v in json.load(open(f)).items():
            if k != "None": cons[int(k)] += v
    ref = json.load(open(os.path.join(ROOT, r"skills\damage\skill_reference.json"), encoding="utf-8"))
    cls2uid = collections.defaultdict(list)
    for r in ref:
        if r.get("class"): cls2uid[r["class"]].append(r["uid"])
    skname = {int(r["SkillUid"]): r["name_th"] for r in csv.DictReader(open(os.path.join(ROOT, r"skills\skills.csv"), encoding="utf-8-sig"))}
    use = collections.defaultdict(list)       # gem id -> decoded skill-side uses (field set / template call whose text or condition reads the registlet)
    for r in ref:
        for mn, mv in (r.get("methods") or {}).items():
            for it in mv.get("items", []):
                for part in ("when", "text"):
                    for g in re.findall(r"hasGemCart\((\d+)\)", str(it.get(part, ""))) + re.findall(r"gemCart\((\d+)\[", str(it.get(part, ""))):
                        e = {"uid": r["uid"], "name_th": skname.get(r["uid"], ""), "method": mn, "kind": it.get("kind"), "field": it.get("name"),
                             "text": str(it.get("text"))[:300], "when": str(it.get("when"))[:300], "read_in": part}
                        if e not in use[int(g)]: use[int(g)].append(e)
    master_ids = {r["id"] for r in rows}
    allids = sorted(master_ids | set(enum))
    recs = []
    for i in allids:
        m = next((r for r in rows if r["id"] == i), {})
        cap = m.get("level_cap") or 10
        t = tx.get(i, {})
        rec = {"id": i, "enum": enum.get(i, ""), "in_master": i in master_ids, "has_text": (("th", 0) in t),
               "level_cap": m.get("level_cap"), "enhance_powder": m.get("enhance_powder"), "base_value": (t.get(("th", 2)) or ""),
               **{f"name_{lg}": t.get((lg, 0), "") for lg in LANGS}, **{f"desc_{lg}": t.get((lg, 1), "") for lg in LANGS}}
        cls = None
        if i in byid: cls = byid[i].split("GemCartBuffer.")[-1]
        elif fac.get(i) == "System.Object": rec["kind"] = "marker"
        rec["class"] = cls or ""
        rec["kind"] = "buff" if cls else ("marker" if fac.get(i) == "System.Object" else "none")
        if i == 1031: rec["class"] = "FireStyleStrengthenBuff"; rec["kind"] = "buff"; cls = "FireStyleStrengthenBuff"
        rec["values"], rec["bonus"], rec["methods"], rec["cooldown"] = {}, [], {}, None
        if cls:
            ms = decode_class(S, cls, cap)
            for mn, lst in ms.items():
                for ent in lst:
                    if mn == "OnGetValue":
                        for p in ent["paths"]:
                            ids = [c for c in p["cond"] if c.startswith("id eq ")]
                            if p["ret"] is None: continue
                            if ids:
                                gid = int(ids[-1].split()[-1]); rec["values"].setdefault(GBID.get(gid, str(gid)), []).append((p["ret"], [c for c in p["cond"] if not c.startswith("id ")]))
                            else:
                                for g, (e, cc) in _id_ternary(p["ret"]):
                                    rec["values"].setdefault(GBID.get(g, str(g)), []).append((e, p["cond"] + cc))
                    elif mn == "get_CoolDownTime":
                        rec["cooldown"] = ent["paths"][0]["ret"] if ent["paths"] else None
                    else:
                        rec["methods"].setdefault(mn, []).extend(ent["paths"])
            bd = next((a for a, n in S.names.items() if n == f"GemCartBuffer.{cls}$$GetBonusData"), None)
            if bd:
                tr = GB.trace(bd)
                if tr:
                    for bid, ex_ in tr:
                        rec["bonus"].append({"bonus_id": bid, "bonus": BONUS.get(bid, str(bid)), "expr": str(ex_), "by_level": table(str(ex_), cap)})
                else: rec["methods"]["GetBonusData"] = [{"cond": [], "ret": "untraced", "sets": [], "calls": []}]
            for g, lst in rec["values"].items():
                rec["values"][g] = [{"expr": e, "when": c, "by_level": table(e, cap, id=0) if not c else None} for e, c in lst]
        code_disp = rec["bonus"][0]["by_level"] if rec["bonus"] else (rec["values"].get("Value", [{}])[0].get("by_level") if rec["values"].get("Value") else None)
        rec["display_by_level"], rec["desc_by_level_th"], rec["display_check"] = None, None, None
        if rec["has_text"] and rec["base_value"].lstrip("-").isdigit() and m:
            base = int(rec["base_value"])
            rec["display_by_level"] = [DV.run(i, lv, base) for lv in range(1, cap + 1)]
            rec["desc_by_level_th"] = [re.sub(r"\[[0-9a-fA-F]{6}\]", "", rec["desc_th"].replace("{0}", str(v))) for v in rec["display_by_level"]]
            if code_disp:
                same = [str(x) == str(y) or (isinstance(x, (int, float)) and y is not None and abs(float(y) - float(x)) < 1e-6) for x, y in zip(code_disp, rec["display_by_level"])]
                rec["display_check"] = "same" if all(same) else "differs"
        c = cons.get(i, [])
        via = []
        if rec["bonus"]: via.append("stat bonus (GetBonusData -> BonusType)")
        eng = [g for g in rec["values"] if g in AGGREGATED]
        if eng: via.append("engine aggregate GemCartBufferManager.GetBufferValue(" + ", ".join(eng) + ")")
        oth = [g for g in rec["values"] if g not in AGGREGATED]
        if oth: via.append("GetValue(" + ", ".join(oth) + ") read by consumer code")
        hooks = rec["methods"].keys() - {".ctor", "GetBonusData"}
        if hooks: via.append("own hooks (" + ", ".join(sorted(hooks)) + ")")
        if use.get(i) or c: via.append("presence/level read by other code (consumers)")
        if i in ENGINE_DIRECT: via.append("read directly by GemCartBufferManager." + ENGINE_DIRECT[i])
        rec["effect_via"] = via or ["none found in client (server-side or unreleased)"]
        rec["consumers"] = [{"via": a, "function": fn, "pc": pc} for a, fn, pc, *_ in c]
        sk = sorted({u for a, fn, pc, *_ in c for k in [re.split(r"[.$<]", fn)[0]] for u in cls2uid.get(k, [])})
        sk = sorted(set(sk) | {e["uid"] for e in use.get(i, [])})
        rec["skills"] = [{"uid": u, "name_th": skname.get(u, "")} for u in sk]
        rec["skill_uses"] = use.get(i, [])
        recs.append(rec)
    os.makedirs(os.path.join(OUT, "icons"), exist_ok=True)
    json.dump({"master_versions": nver, "master_distinct": nuniq, "records": recs}, open(os.path.join(OUT, "registlet.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    cols = ["id", "enum", "kind", "class", "in_master", "level_cap", "enhance_powder", "base_value", "name_th", "name_us", "name_jp", "desc_th", "desc_us", "cooldown"]
    with open(os.path.join(OUT, "registlet.csv"), "w", encoding="utf-8-sig", newline="") as f:
        w = csv.writer(f); w.writerow(cols + ["skills", "consumer_functions"])
        for r in recs:
            w.writerow([str(r.get(c, "")).replace("\n", " / ") for c in cols] + [";".join(str(s["uid"]) for s in r["skills"]), ";".join(sorted({c["function"].split("$$")[0] for c in r["consumers"]}))])
    with open(os.path.join(OUT, "effects_by_level.csv"), "w", encoding="utf-8-sig", newline="") as f:
        w = csv.writer(f); w.writerow(["id", "enum", "source", "key", "level", "value"])
        for r in recs:
            for b_ in r["bonus"]:
                for lv, v in enumerate(b_["by_level"] or [], 1): w.writerow([r["id"], r["enum"], "bonus", b_["bonus"], lv, v])
            for g, lst in r["values"].items():
                for e in lst:
                    for lv, v in enumerate(e["by_level"] or [], 1): w.writerow([r["id"], r["enum"], "value", g, lv, v])
    icons(recs)
    md(recs, nver, nuniq)
    json.dump({"master_versions": nver, "master_distinct": nuniq, "records": recs}, open(os.path.join(OUT, "registlet.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    print(len(recs), collections.Counter(r["kind"] for r in recs))
    return recs


def icons(recs):
    import export_items
    atlas, sprites = export_items.icon_sprites()
    for n in ("GemCart", "GemCartPiece", "stargem", "stargem_peace"):
        x, y, w, h = sprites[n]
        atlas.crop((x, y, x + w, y + h)).save(os.path.join(OUT, "icons", n + ".png"))
    os.makedirs(os.path.join(OUT, "icons", "skill"), exist_ok=True)
    for r in recs:
        for sk in r["skills"]:
            src = os.path.join(ROOT, "skills", "icons", f"sk_{sk['uid']:03d}.png")
            sk["icon"] = f"icons/skill/sk_{sk['uid']:03d}.png" if os.path.exists(src) else ""
            if sk["icon"]: shutil.copyfile(src, os.path.join(OUT, sk["icon"]))


ENGINE = [("GetRecieveDamageRate", "GemCartBufferId ReceiveDmgUpRate / ReceiveDmgDownRate via GetBufferValue; registlets 28, 39, 46, 73, 74, 75 (area shields, MobActionPattern checks) are read directly"),
          ("GetLastDamageRate", "GemCartBufferId LastDmgUpRate / LastDmgDownRate via GetBufferValue; registlet 27 read directly"),
          ("GetNormalAttackRate", "GemCartBufferId NormalAttackRate via GetBufferValue (8-byte tail call)"),
          ("GetTalentElementType", "registlets 1, 2 filtered with Where<>; the 53-58 *Talent markers carry the element (Inferred)"),
          ("GetBufferValue", "sums GetValue(id) over every equipped buff (Dictionary enumerator loop; Inferred from the call list)")]


def md(recs, nver, nuniq):
    kinds = collections.Counter(r["kind"] for r in recs)
    L = ["# Registlet (GemCart) reference", "",
         "Recovered offline from `libil2cpp.so` + the master/text bundles. Evidence labels: **Code** (decoded from the client), **Inferred**, **Text** (in-game string).", "",
         "## Files", "", "| file | content |", "|---|---|",
         "| `registlet.csv` | one row per GemCartId (182): master fields, names (th/us/jp), description, class, skills |",
         "| `registlet.json` | everything: 6-language names/descriptions, per-level display value and description, internal values, decoded buff methods, consumers, skill uses, icons |",
         "| `effects_by_level.csv` | internal effect values per level (BonusType bonuses and `OnGetValue` results) |",
         "| `REGISTLET.md` | per-registlet pages |",
         "| `icons/` | `GemCart` (the icon every registlet uses), `GemCartPiece`, `stargem`, `stargem_peace`; `icons/skill/` = icons of the skills that read each registlet |", "",
         "## How it fits together", "",
         f"- **Master** `RegistletMaster` (Code, `GemCartMasterData.CreateGemCartData`): u32 version, u16 count, then `{{i16 Id, i16 LevelCap, i32 EnhancePowder}}` x 159. Identical in all {nver} cached/CDN versions ({nuniq} distinct blob).",
         "- **Text** `Registlet_<lang>` (477 rows = 159 ids x name / description / base value). Description `{0}` is filled by `UIRegistletMainManager.GetDescriptionValueText(id, lv, baseValue)` (Code, emulated for every id and level by `emu_desc_value.py`): default `baseValue * lv`, with per-id exceptions (`baseValue - lv`, `15 - lv`, `100 - ...`, `/10`, `/100`). That is `display_by_level`; `display_check` compares it with the internal value (`differs` is normal: the UI shows a reduction or a rescaled number).",
         "- **Id enum** `GemCartId` (182 names). 159 are in the master; the other 23 (`Nil` + 22 named ones) have no master row and no text, and no client consumer was found for them either (unreleased or removed).",
         "- **Behaviour** `GemCartBufferFactory.Create(id, lv, status)` builds one `GemCartBuffer.*Buff` class per id (jump table emulated). Classes expose `OnGetValue(GemCartBufferId)`, `GetBonusData(out id[], out val[])`, `CheckTrigger`, hooks, ctor.",
         f"- **Kinds**: buff class {kinds['buff']}, marker (factory returns a bare `System.Object`; the effect lives in the code that tests `ContainsBuffer`) {kinds['marker']}, no object {kinds['none']} (incl. `Nil`).",
         "- **Level cap / powder**: `GemCartMasterData.LevelCap`, `EnhancePowder`. Bag size = `FunctionLimitManager` value 0x8c and slot count = `RegistletData.Slot` are fed by the server; the per-level cost curve is not in the client.",
         "- **Icon**: `UIRegistletListButton.SetButtonData` calls `SetIcon(\"GemCart\")` for every entry (Code). No per-registlet art exists in the client atlas or the CDN catalogs; `icons/skill/` links each registlet to the skill icon it modifies.", "",
         "### Engine readers (`GemCartBufferManager`)", ""]
    L += [f"- `{a}`: {b}" for a, b in ENGINE]
    L += ["", "## All registlets", "", "| id | enum | kind | name (th) | cap | powder | effect via |", "|---|---|---|---|---|---|---|"]
    for r in recs:
        L.append(f"| {r['id']} | {r['enum']} | {r['kind']} | {r['name_th']} | {r['level_cap'] or ''} | {r['enhance_powder'] or ''} | {'; '.join(r['effect_via'])} |")
    L += ["", "## Per registlet", ""]
    for r in recs:
        if not r["in_master"]: continue
        L += [f"### {r['id']} {r['enum']} - {r['name_th']} ({r['name_us']})", "",
              f"![](icons/GemCart.png) kind: **{r['kind']}** `{r['class']}` · cap {r['level_cap']} · enhance powder {r['enhance_powder']} · base value {r['base_value']}", "",
              "Description (th): " + r["desc_th"].replace("\n", " "), "", "Description (us): " + r["desc_us"].replace("\n", " "), ""]
        if r["display_by_level"]: L += ["Displayed `{0}` by level: " + ", ".join(f"Lv{i}={v}" for i, v in enumerate(r["display_by_level"], 1)), ""]
        for bn in r["bonus"]: L += [f"Stat bonus `{bn['bonus']}` = `{bn['expr']}`" + (f" -> {bn['by_level']}" if bn["by_level"] else ""), ""]
        for g, lst in r["values"].items():
            for e in lst: L += [f"`OnGetValue({g})` = `{e['expr']}`" + (f" when {e['when']}" if e["when"] else "") + (f" -> {e['by_level']}" if e["by_level"] else ""), ""]
        if r["cooldown"]: L += [f"Cooldown: `{r['cooldown']}`", ""]
        for mn, ps in r["methods"].items():
            if mn == ".ctor": continue
            for q in ps[:4]:
                L.append(f"- hook `{mn}`: " + (" && ".join(q["cond"])[:160] or "always") + (f" -> {q['ret'][:160]}" if q["ret"] else "") + (f" sets {q['sets'][:3]}" if q["sets"] else ""))
        if r["skills"]: L += ["", "Skills reading it: " + ", ".join(f"![]({s['icon']}) {s['uid']} {s['name_th']}" if s.get("icon") else f"{s['uid']} {s['name_th']}" for s in r["skills"]), ""]
        for u in r["skill_uses"][:6]: L.append(f"- skill {u['uid']} `{u['method']}` {u['kind']} `{u['field']}` = `{u['text'][:140]}` when `{u['when'][:140]}`")
        if r["consumers"]: L += ["", "Consumers (Code): " + ", ".join(sorted({c["function"] for c in r["consumers"]}))[:400], ""]
        L += ["Effect via: " + "; ".join(r["effect_via"]), ""]
    open(os.path.join(OUT, "REGISTLET.md"), "w", encoding="utf-8").write("\n".join(L) + "\n")


def _id_ternary(s):
    """`(id eq K ? A : (id eq J ? B : 0))` -> [(K, (A, [])), ...]"""
    out = []
    while True:
        m = re.match(r"^\(id eq (\d+) \? (.+?) : (.+)\)$", s)
        if not m: break
        out.append((int(m.group(1)), (m.group(2), []))); s = m.group(3)
    return out


if __name__ == "__main__":
    main()
