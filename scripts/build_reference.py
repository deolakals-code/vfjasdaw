"""Consolidate symbolic recipes + skill metadata into per-skill records (json) and a markdown reference."""
import json, glob, os, re, sys, collections
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from refutil import pretty, evaluate, ENUM, en
import dis2 as D2

DATA = r"D:\toram reverse data"
OUT = os.path.join(DATA, "skills", "damage")
REC = os.environ.get("SYM_OUT", r"D:\toram_re\skillrecipes")
OUT = os.environ.get("SYM_REF_OUT", OUT)   # build into a scratch dir when comparing executors
MREC = r"D:\toram_re\masteryrecipes"

meta = {s["uid"]: s for s in json.load(open(os.path.join(DATA, "skills", "skills_full.json"), encoding="utf-8"))}
prorat = {r["skill_uid"]: r for r in json.load(open(os.path.join(DATA, "proration_calculator", "skill_proration_modes.json"), encoding="utf-8"))}
fac = {int(k): v for k, v in json.load(open(r"D:\toram_re\state\_factory_map.json")).items()}
mfac = {int(k): v for k, v in json.load(open(r"D:\toram_re\state\_mastery_map.json")).items()}

NOISE_FIELDS = {"_motionSpeed", "CurrentTake", "WeaponType", "SubWeaponType", "actarAction", "playerAction", "actorTransform",
                "startPos", "attackPos", "rad", "random", "skinRootBone", "attackStartTime", "attackPosList", "targetMobAction",
                "targetMagicExp", "targetExpLit", "SkillTemplateList", "calcTemplate", "isUnsheatheMode", "PlacePos", "isThorHammer",
                "invincibilityLocalId", "expType", "subWeaponType", "targetSize", "defaultRange", "startTargetDist", "targetDamageData",
                "damageCountList", "attackCount", "IsEnd", "IsMotionEnd", "skillPosition", "SkillPosition", "isStatusTemporary",
                "temporaryApplySkillBuffer", "CurrentEventTake", "HitTakeAppendParam", "isExpDefFluctuate", "isPlace", "attackStartPos"}
CHECK_STEPS = {"HitCheck", "CorrectHitCheck", "AvoidBreakCheck", "GuardBreakCheck", "CriticalCheck", "GuardCheck", "AvoidCheck",
               "InvincibleCheck", "MetalSlimeFlagCheck", "MinusDamageCheck", "WeakElementDamageCheck"}
EFFECT_RX = re.compile(r"(AddSelfBuffer|AddBuffer|RemoveSelfBuffer|RemoveBuffer|SetAbnormalType|AddRecovery|HpHeal|MpHeal|HealHp|"
                       r"SetBufferConstantDamage|createMultiHitDamage|CreateNextDamage|AddSelfDanceBuf|AddOverHeal|AddLocalStack|"
                       r"GetDefaultAnbormalStateTime|RemoveAbnormalState|checkAbnormalPercent|CheckPercent|\.ctor$)")
EFFECT_SKIP = re.compile(r"^(System\.|UnityEngine|SkillCalcTemplate|SkillLinkedTake|SkillActionBase\.DamageData|SkillDamageData\$\$\.ctor|"
                         r"PlayerAttackBase\$\$templateTo)")


def noisy_cond(c):
    return ("+0x" in c and "[" in c) or "opaque" in c or "?x" in c or "0x165" in c or "SkillTemplateList" in c \
        or "targetDamageData" in c or "stkp" in c or c.strip() == "" or "?mi" in c or "?blr eq" in c or "ne ?" in c


def norm(s):
    if not isinstance(s, str): return s
    s = pretty(s)
    s = s.replace("[this.skillData+0x18]", "Lv")
    return s


def _neg(c):
    return c[1:] if c.startswith("!") else "!" + c


def short_when(alts, limit=3):
    if any(len(a) == 0 for a in alts): return "always"
    singles = {a[0] for a in alts if len(a) == 1}
    for x in singles:
        if _neg(x) in singles: return "always"
        for k, v in ((" eq ", " ne "), (" ne ", " eq "), (" == ", " != "), (" != ", " == ")):
            if k in x and x.replace(k, v) in singles: return "always"
    alts = sorted(alts, key=len)[:limit]
    return " OR ".join(" AND ".join(a) for a in alts)


def collapse(vals):
    if vals and all(v == vals[0] for v in vals): return vals[0]
    return vals


def level_table(expr, maxlv):
    vals = []
    for lv in range(1, maxlv + 1):
        v = evaluate(expr, Lv=lv, lv=lv)
        if v is None: return None
        vals.append(round(v, 4) if isinstance(v, float) else v)
    return vals


def interesting_value(v):
    if not isinstance(v, str): return False
    if re.search(r"opaque|0x165|meta\(|stkp|vtab|\?x\d", v): return False
    if re.fullmatch(r"\??[\w.]*\?\w+|\?\w+", v.strip()): return False
    return True


def summarize_paths(paths, maxlv, want_calls=True):
    """-> list of {'kind','text','when','by_level'} de-duplicated across paths"""
    items = collections.OrderedDict()
    allconds = []
    for p in paths:
        conds = frozenset(norm(c) for c in p["cond"] if not noisy_cond(norm(c)))
        allconds.append(conds)
        keys = []
        for k, v in p["fields"].items():
            v = norm(v)
            if k in NOISE_FIELDS or not interesting_value(v): continue
            if k.startswith("+0x") and not re.fullmatch(r"-?[\d.]+", v): continue
            keys.append(("set", k, v))
        for t in p["tpl"]:
            if t[1] in CHECK_STEPS: continue
            keys.append(("tpl", f"{t[0]}[{t[1]}]", norm(t[2])))
        if want_calls:
            seen = set()
            for c in p["calls"]:
                nm = c[0]
                if EFFECT_SKIP.match(nm) or not EFFECT_RX.search(nm): continue
                args = [norm(a) for a in c[1][1:4]]
                text = nm.split("$$")[-1] + "(" + ", ".join(a for a in args if not a.startswith(("0x165", "?x", "meta(0x"))) + ")"
                if text in seen: continue
                seen.add(text)
                keys.append(("call", nm.replace("$$", "."), text))
        nt = sum(1 for c in p["calls"] if c[0] == "PlayerAttackBase$$TemplateAssignment")
        if nt: keys.append(("info", "templates", str(nt)))
        for k in keys:
            items.setdefault(k, []).append(conds)
    base = frozenset.intersection(*allconds) if allconds else frozenset()
    out = []
    for (kind, name, text), cl in items.items():
        alts = []
        for c in cl:
            t = tuple(sorted(x for x in c if x not in base))
            if t not in alts: alts.append(t)
        w = short_when(alts)
        if len(cl) == len(paths) and kind != "call": w = "always"
        item = {"kind": kind, "name": name, "text": text, "when": w}
        if kind == "set":
            bl = level_table(text, maxlv)
            if bl: item["by_level"] = collapse(bl)
        out.append(item)
    return out, sorted(base)


def methods_summary(res, maxlv):
    out = collections.OrderedDict()
    for k, v in res["methods"].items():
        paths = v.get("paths", [])
        if not paths: continue
        items, base = summarize_paths(paths, maxlv)
        if items:
            out[k.split("@")[0]] = {"addr": k.split("@")[-1], "when_all": base, "items": items,
                                     "paths": len(paths), "truncated": bool(v.get("truncated"))}
    return out


def _balanced(x):
    d = 0
    for ch in x:
        d += (ch in "([") - (ch in ")]")
        if d < 0: return False
    return d == 0


def id_ternary(s):
    """[(id, value expr)] from a chain `(id eq K ? A : <rest>)`; empty when s is not such a chain"""
    s = s.strip()
    while s.startswith("(") and s.endswith(")") and _balanced(s[1:-1]): s = s[1:-1].strip()
    m = re.match(r"id eq (-?\d+) \? ", s)
    if not m: return []
    rest, d = s[m.end():], 0
    for i, ch in enumerate(rest):
        d += (ch in "([") - (ch in ")]")
        if ch == ":" and d == 0 and rest[i - 1:i] == " " and rest[i + 1:i + 2] == " ":
            return [(int(m.group(1)), rest[:i].strip())] + id_ternary(rest[i + 1:])
    return []


def buf_summary(res, maxlv):
    out = collections.OrderedDict()
    for cls, ms in res.get("buffs", {}).items():
        b = {"ctors": [], "get_param": [], "other": {}}
        for k, v in ms.items():
            name = k.split("@")[0]
            paths = v.get("paths", [])
            if not paths: continue
            if name == ".ctor":
                fields = collections.OrderedDict()
                for p in paths:
                    conds = tuple(sorted(norm(c) for c in p["cond"] if not noisy_cond(norm(c))))
                    for fk, fv in p["fields"].items():
                        fv = norm(fv)
                        if interesting_value(fv) or "ctor" in fv: fields.setdefault(fk, []).append((fv, conds))
                sig = ", ".join(f"{t} {n}" for t, n in v.get("params", []))
                ent = {"sig": sig, "fields": {}}
                for fk, lst in fields.items():
                    vs = collections.OrderedDict()
                    for fv, cs in lst: vs.setdefault(fv, []).append(cs)
                    ent["fields"][fk] = [{"expr": fv, "when": short_when(sorted({c for c in cs})),
                                          "by_level": collapse(level_table(fv, min(maxlv, 10)) or []) or None} for fv, cs in vs.items()]
                chained = any(c[0].endswith(cls + "..ctor") or c[0] == cls + "$$.ctor" for p in paths for c in p["calls"])
                ent["chained"] = chained
                bc = next(((c[0], c[1]) for p in paths for c in p["calls"] if c[0].endswith("$$.ctor") and c[0].split("$$")[0] != cls
                           and c[0].split("$$")[0] in D2.C and cls in D2.chain(c[0].split("$$")[0]) + [c[0].split("$$")[0]] or
                           (c[0].endswith("$$.ctor") and c[0].split("$$")[0] in D2.chain(cls)[1:])), None)
                if bc:
                    bcls, bargs = bc[0].split("$$")[0], bc[1][1:]
                    cand = [sg for a, n in D2.names.items() if n == bcls + "$$.ctor" for sg in [D2.SIG.get(a)] if sg and len(sg[1]) == len(bargs)]
                    ent["base_ctor"] = {"class": bcls, "args": [norm(x) for x in bargs], "params": [pn for _t, pn in cand[0][1]] if cand else []}
                b["ctors"].append(ent)
            elif name == "GetParam":
                for p in paths:
                    if not p.get("ret"): continue
                    conds = [norm(c) for c in p["cond"] if not noisy_cond(norm(c))]
                    ids = [c for c in conds if c.startswith("id eq ")]
                    if ids:
                        i = int(ids[-1].split()[-1])
                        b["get_param"].append({"bonus_id": i, "bonus": en("SkillBufferId", i), "value": norm(p["ret"][0]),
                                               "when": [c for c in conds if not c.startswith("id ")]})
                    else:
                        # the id test is inside the returned expression: (id eq K ? A : (id eq J ? B : 0))
                        for i, val in id_ternary(norm(p["ret"][0])):
                            b["get_param"].append({"bonus_id": i, "bonus": en("SkillBufferId", i), "value": val,
                                                   "when": [c for c in conds if not c.startswith("id ")]})
            else:
                items, base = summarize_paths(paths, maxlv, want_calls=False)
                if items: b["other"][name] = items
        if len(b["ctors"]) > 1:
            base = b["ctors"][0]["fields"]
            for ent in b["ctors"][1:]:
                if not ent.get("chained"): continue
                merged = {k: v for k, v in base.items()}
                for fk, vs in ent["fields"].items():
                    newvs = []
                    for v in vs:
                        e2 = v["expr"]
                        for bn, bvs in base.items():
                            if len(bvs) == 1 and re.search(rf"\b{re.escape(bn)}\b", e2):
                                e2 = re.sub(rf"\b{re.escape(bn)}\b", "(" + bvs[0]["expr"] + ")", e2)
                        newvs.append({"expr": e2, "when": v["when"], "by_level": collapse(level_table(e2, min(maxlv, 10)) or []) or None})
                    merged[fk] = newvs
                ent["fields_resolved"] = merged
        b["hooks"] = sorted({k.split("@")[0] for k in ms} - {".ctor", ".cctor", "GetParam", "Updata", "get_SkillId", "get_Flag", "get_BufferType",
                                                             "get_IsViewSelfIcon", "SetViewSelfIcon", "GetBufferEffectAppendParameter"})
        pids = {g["bonus"] for g in b["get_param"]}
        b["flags"] = {
            "boosts_normal_attack_damage": bool(pids & {"NormalAttackRate", "NormalAttackConstantDamage"}),
            "modifies_normal_attack_logic": cls in NA_BUFS or "GetNormalAttackSkillRate" in b["hooks"],
            "changes_attack_pattern": bool(set(b["hooks"]) & PATTERN_HOOKS),
        }
        out[cls] = b
    for cls, b in out.items():       # constructor arguments a derived buff passes to its base buff (SoulHuntBuf -> CountBufferBase(lv, 1, 10))
        for ent in b["ctors"]:
            bc = ent.get("base_ctor")
            if bc and bc["class"] in out and bc["params"]:
                out[bc["class"]].setdefault("child_args", {})[cls] = dict(zip(bc["params"], bc["args"]))
    return out


NA_BUFS = {"AspisSeoulBuf", "BloodSteelBuf", "CrazyDaggerBuf", "HeavenlyStarBuf", "MagicEgelBuf", "OrgaslashBuf", "SamuraiArcheryBuf",
           "ShukuchiBuf", "SwordMoveBuf", "TwinStormBuf", "UnannouncedDestinationBuf", "VenomInjectBuf", "IchijhinnokazeBuf", "KadarElexioBuf"}
PATTERN_HOOKS = {"get_KnifeTakeId", "ChangeTwinStorm", "UseTwinStorm", "CheckTwinStorm", "UseConquester", "ChangeHyperMode",
                 "CheckPairOfShieldsTake", "SetAttackSkillId", "CheckRightAttack", "UpdateAshuraAuraAttack", "get_IsEnhanceAtk",
                 "get_IsEnhanceMatk"}
AILMENT_RX = re.compile(r"(?i)(flinch|blind|stun|tumble|slow|stop|poison|freeze|abnormal|sleep|fear|paralysis|burn|silence|curse)\w*(percent|rate)")


def classify(rec):
    roles = []
    cat = rec.get("category")
    methods = rec.get("methods", {})
    calls = " ".join(it["name"] for m in methods.values() for it in m["items"] if it["kind"] == "call")
    fields = {it["name"] for m in methods.values() for it in m["items"] if it["kind"] == "set"}
    if any(it["kind"] == "tpl" for m in methods.values() for it in m["items"]): roles.append("attack (deals damage)")
    if "AddSelfBuffer" in calls or rec.get("buffs"): roles.append("buff (self)")
    if re.search(r"AddBuffer|AddSelfDanceBuf", calls): roles.append("buff (party / others)")
    if "SetAbnormalType" in calls or any(AILMENT_RX.search(f) for f in fields): roles.append("applies status ailment")
    if {"hpHeal", "hpRecovery", "maxHpRecovery"} & fields or cat == "Heal": roles.append("heal / recovery")
    if cat == "Object": roles.append("placed object / trap / summon")
    if cat == "Circle": roles.append("circle / song area")
    if cat == "Mastery" or rec.get("mastery_class"): roles.append("passive mastery")
    bf = [b["flags"] for b in rec.get("buffs", {}).values()]
    if any(f["changes_attack_pattern"] for f in bf): roles.append("changes attack pattern (motion / combo chain; heuristic)")
    if any(f["modifies_normal_attack_logic"] for f in bf): roles.append("modifies normal-attack behaviour")
    if any(f["boosts_normal_attack_damage"] for f in bf): roles.append("boosts normal-attack damage")
    if not roles and rec.get("class"): roles.append("utility / system action")
    if not rec.get("class") and not rec.get("mastery_class") and rec.get("in_skill_tree"):
        roles.append("no client action class (system / production / unreleased)")
    return roles


def process_skill(uid, res):
    s = meta.get(uid, {})
    maxlv = min(s.get("max_level") or 10, 10)
    return {"methods": methods_summary(res, maxlv), "buffs": buf_summary(res, maxlv)}


def process_mastery(uid):
    f = glob.glob(os.path.join(MREC, f"{uid:04d}_*.json"))
    if not f: return None
    r = json.load(open(f[0], encoding="utf-8"))
    for b in r["by_id"].values():
        if b.get("by_level") is None and isinstance(b.get("expr"), str):
            vals = [evaluate(b["expr"], Lv=i, lv=i) for i in range(1, 11)]
            if None not in vals: b["by_level"] = [round(v, 4) if isinstance(v, float) else v for v in vals]
    return {"class": r["class"], "bonuses": r["by_id"]}


ORPH = json.load(open(r"D:\toram_re\skillrecipes_orphan_bufs.json", encoding="utf-8"))
BMAP = {int(k): v for k, v in json.load(open(r"D:\toram_re\state\_buffer_map.json")).items()}
CALLERS = json.load(open(r"D:\toram_re\orphan_callers.json", encoding="utf-8"))
CALLERS2 = json.load(open(r"D:\toram_re\orphan_callers2.json", encoding="utf-8"))
CONSUMERS = json.load(open(r"D:\toram_re\skill_consumers.json", encoding="utf-8"))
_ce = r"D:\toram_re\consumer_effects.json"
CEFFECTS = json.load(open(_ce, encoding="utf-8")) if os.path.exists(_ce) else {}
# uid -> [buf, evidence]: owners no automatic rule can find
MANUAL_OWNERS = {
    80: [("JumpBackShotBuf", "constructed only by PlayerBattleManager.PursuitJumpbackShotAttack, which gates on TryGetBuf(80); ReMark called from JumpbackShotAction.ReceiveAttackResult")],
    95: [("JumpBackShotBuf", "PursuitJumpbackShotAttack reads its per-monster counter (GetCount/Next) and passes it to this action as `count`")],
    104: [("ChainCastStackBuf", "name stem + constructed in monster Damaged hooks (stack of ChainCast); inferred")],
}


def orphan_owners():
    """uid -> {buf class: how it was attached}: factory table, then name stem, then constructor callers"""
    cls_uids = collections.defaultdict(list)
    for u, c in list(fac.items()) + list(mfac.items()): cls_uids[c].append(u)
    byname = collections.defaultdict(list)
    for u, c in fac.items(): byname[re.sub(r"Action$", "", c)].append(u)
    for u, s in meta.items():
        if s.get("name_en"): byname[s["name_en"]].append(u)
    owners = collections.defaultdict(dict)
    for u, b in BMAP.items():
        if b in ORPH: owners[u].setdefault(b, "factory:CreateSkillBuffer")
    for b in ORPH:
        stem = re.sub(r"(?i)(Buf|Buffer|Bufa)$", "", b)
        for u in byname.get(stem, []): owners[u].setdefault(b, "name")
        for caller in CALLERS.get(b, []):
            base = caller.split("$$")[0].split(".")[0]
            for u in cls_uids.get(base, []) + cls_uids.get(base + "Action", []):
                owners[u].setdefault(b, "caller:" + caller)
        for fn, callers in CALLERS2.get(b, {}).items():
            for c2 in callers:
                base = c2.split("$$")[0].split(".")[0]
                for u in cls_uids.get(base, []) + cls_uids.get(base + "Action", []):
                    owners[u].setdefault(b, f"caller2:{fn}<-{c2}")
    for u, lst in MANUAL_OWNERS.items():
        for b, why in lst: owners[u][b] = "manual:" + why
    return owners


OWNERS = orphan_owners()


def build_all():
    os.makedirs(OUT, exist_ok=True)
    recs = collections.OrderedDict()
    for uid in sorted(set(meta) | set(fac)):
        s = meta.get(uid)
        rec = {"uid": uid, "in_skill_tree": s is not None}
        if s:
            for k in ("name_th", "name_en", "name_th_r2", "category", "tree", "tree_type", "tree_lv", "max_level", "premise_uid",
                      "eq_limit", "flags", "assist", "icon", "desc_th", "notes", "stat_tags"):
                rec[k] = s.get(k)
        if uid in fac:
            f = glob.glob(os.path.join(REC, f"{uid:04d}_*.json"))
            rec["class"] = fac[uid]
            if f:
                r = json.load(open(f[0], encoding="utf-8"))
                rec.update(process_skill(uid, r))
            if uid in prorat:
                p = prorat[uid]
                rec["proration"] = {"slot": p["slot"], "mode": p["mode"], "attack_type": p["attack_type"], "action_id": p["action_id"],
                                    "is_exp_def_fluctuate": p["is_exp_def_fluctuate"], "child_actions": p["child_actions"]}
        if uid in mfac:
            rec["mastery_class"] = mfac[uid]
            m = process_mastery(uid)
            if m: rec["mastery"] = m
        maxlv = min((s or {}).get("max_level") or 10, 10)
        if str(uid) in CEFFECTS:
            rec["consumer_effects"] = CEFFECTS[str(uid)]
        if str(uid) in CONSUMERS:
            rec["consumers"] = sorted({c["fn"] + " (" + c["via"] + ")" for c in CONSUMERS[str(uid)]})
        for bcls, via in OWNERS.get(uid, {}).items():
            if bcls in rec.get("buffs", {}): continue
            b = buf_summary({"buffs": {bcls: ORPH[bcls]}}, maxlv)[bcls]
            b["attached_via"] = via
            rec.setdefault("buffs", {})[bcls] = b
        for bcls, b in rec.get("buffs", {}).items():     # derived buff -> base buff constructor arguments (SoulHuntBuf -> CountBufferBase(lv, 1, 10))
            for ent in b.get("ctors", []):
                bc = ent.get("base_ctor")
                if bc and bc["class"] in rec["buffs"] and bc["params"]:
                    rec["buffs"][bc["class"]].setdefault("child_args", {})[bcls] = dict(zip(bc["params"], bc["args"]))
        rec["roles"] = classify(rec)
        recs[uid] = rec
    return recs


if __name__ == "__main__":
    if sys.argv[1:] == ["--all"]:
        recs = build_all()
        json.dump(list(recs.values()), open(os.path.join(OUT, "skill_reference.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
        idx = {b: {"owners": sorted(u for u, d in OWNERS.items() if b in d), "via": sorted({d[b] for d in OWNERS.values() if b in d}),
                   "callers": CALLERS.get(b, [])} for b in sorted(ORPH)}
        json.dump(idx, open(os.path.join(OUT, "buff_owner_index.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
        print(len(recs), "records;", sum(1 for v in idx.values() if not v["owners"]), "orphan buffs still unattached")
    else:
        recs = build_all()
        for u in map(int, sys.argv[1:]):
            r = recs[u]
            print("=====", u, r.get("class"), r.get("name_th"), r.get("category"), "| proration:", r.get("proration", {}).get("slot"), r.get("proration", {}).get("mode"))
            for m, v in r.get("methods", {}).items():
                print(" --", m, f"({v['paths']} paths)", "when_all:", v["when_all"][:2])
                for it in v["items"]:
                    bl = f"  {it['by_level']}" if it.get("by_level") is not None else ""
                    print(f"     {it['kind']:4} {it['name'][:34]:34} {it['text'][:170]}{bl}   [{it['when'][:90]}]")
            for bc, b in r.get("buffs", {}).items():
                print(" BUFF", bc)
                for c in b["ctors"]:
                    print("   ctor", c["sig"])
                    for fk, vs in c["fields"].items():
                        for v in vs: print(f"      {fk} = {v['expr'][:100]}  {v['by_level']}  [{v['when'][:60]}]")
                for g in b["get_param"]: print("   param", g["bonus"], "=", g["value"][:80], g["when"][:2])
            if "mastery" in r: print(" MASTERY", json.dumps(r["mastery"], ensure_ascii=False)[:500])
