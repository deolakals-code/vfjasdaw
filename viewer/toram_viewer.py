"""Toram data viewer (tkinter, stdlib only).

Tabs:
  Skills    - filter / sort / inspect every skill (icon, description, plain-language details, level tables, proration, buffs, formulas, Variables sub-tab)
  คำอธิบายโดยรวม - per skill: where the damage multiplier comes from, per-weapon splits, states during the cast (invincibility, damage cut), buffs, links to other skills (overview.json)
  Skill variables - glossary of every variable / helper function / enum the skill formulas use: meaning, evidence, decoded definition, who uses it
  Stats     - decoded player stat / weapon calculator / bonus / mob stat / damage-helper functions (skills/damage/stats/raw), filter by group
  Files  - browse any csv / json / md / txt / png under the data root

usage: python toram_viewer.py [--root "D:\\toram reverse data"] [--selftest]
"""
import csv, json, os, re, sys, tkinter as tk
from tkinter import ttk

csv.field_size_limit(1 << 24)
HERE = os.path.dirname(os.path.abspath(__file__))
ROOT = os.path.dirname(HERE)
if "--root" in sys.argv:
    ROOT = sys.argv[sys.argv.index("--root") + 1]
UI_FONT = ("Tahoma", 10)
MONO = ("Consolas", 10)
MAX_ROWS = 20000


def clean_md(s):
    s = re.sub(r"</?(?:details|summary)[^>]*>", "", s)
    s = re.sub(r"<img[^>]*>", "", s)
    return s.replace("**", "").replace("`", "")


def fmt(v):
    return f"{v:g}" if isinstance(v, float) else str(v)


class DetailStore:
    """skills/damage/details/<Tree>.md entries by uid (loaded on first use) + coverage.csv (state per skill)."""

    def __init__(self, base):
        self.dir = os.path.join(base, "details")
        self.blocks, self.lower, self.loaded, self.cov = {}, {}, False, {}
        p = os.path.join(base, "coverage.csv")
        if os.path.exists(p):
            with open(p, encoding="utf-8-sig", newline="") as f:
                self.cov = {int(r["uid"]): r for r in csv.DictReader(f)}

    def load(self):
        if self.loaded: return
        self.loaded = True
        if not os.path.isdir(self.dir): return
        for fn in os.listdir(self.dir):
            if not fn.endswith(".md"): continue
            with open(os.path.join(self.dir, fn), encoding="utf-8") as f:
                for b in f.read().split("\n---\n"):
                    m = re.search(r"\u00b7 uid (\d+)\n", b)
                    if m: self.blocks[int(m.group(1))] = b.strip()

    def get(self, uid):
        self.load()
        return self.blocks.get(uid, "")

    def has(self, uid, q):
        self.load()
        if uid not in self.lower: self.lower[uid] = self.blocks.get(uid, "").lower()
        return q in self.lower[uid]

    def state(self, uid):
        return (self.cov.get(uid) or {}).get("state", "-")

    def th(self, uid):
        """hand-written Thai explanation (skills/damage/explained_th/<Tree>.md), one '### ... uid N' block per skill"""
        if not hasattr(self, "_th"):
            self._th = {}
            d = os.path.join(os.path.dirname(self.dir), "explained_th")
            if os.path.isdir(d):
                for fn in os.listdir(d):
                    if not fn.endswith(".md"): continue
                    with open(os.path.join(d, fn), encoding="utf-8") as f:
                        for b in re.split(r"\n(?=### )", f.read()):
                            m = re.match(r"### .*\u00b7 uid (\d+)", b)
                            if m: self._th[int(m.group(1))] = b.strip()
        return self._th.get(uid, "")


class Sortable(ttk.Treeview):
    """Treeview whose column headers sort (numbers as numbers)."""

    def enable_sort(self):
        for c in self["columns"]:
            self.heading(c, text=c, command=lambda c=c: self.sort_by(c, False))

    def sort_by(self, col, desc):
        def key(k):
            v = self.set(k, col)
            try:
                return (0, float(v))
            except ValueError:
                return (1, v.lower())
        items = sorted(self.get_children(""), key=key, reverse=desc)
        for i, k in enumerate(items):
            self.move(k, "", i)
        self.heading(col, command=lambda: self.sort_by(col, not desc))


def text_widget(parent, mono=True):
    f = ttk.Frame(parent)
    t = tk.Text(f, wrap="word", font=MONO if mono else UI_FONT, undo=False, relief="flat", padx=8, pady=6)
    sb = ttk.Scrollbar(f, command=t.yview)
    t.configure(yscrollcommand=sb.set)
    t.pack(side="left", fill="both", expand=True)
    sb.pack(side="right", fill="y")
    return f, t


def set_text(t, s):
    t.configure(state="normal")
    t.delete("1.0", "end")
    t.insert("1.0", s)
    t.configure(state="disabled")


ENGINE_TEXT = """SHARED DAMAGE ENGINE  (SkillCalcTemplate.GetDamage, RVA 0x21FF504; PlayerAttackBase.TemplateAssignment, RVA 0x206BBB0)
Steps run in CalcStep order 0..40.  Constant steps ADD, Rate steps do  d = (int)(d * rate)  (truncate after every rate step).
AddRate / AddConstant into the same step SUM; SetRate / SetConstant replace.  Empty rate slot = x1, empty constant = +0.

  d  = BaseDamage + SkillConstantDamage + BufferConstantDamage + Def(negative) + FirstAttack ; d = max(d, 0)
  d  = (int)(d * CriticalRate)                 only when the hit crits
  d  = (int)(d * ElementBonusRate) ; d = (int)(d * NormalElementDamageResistRate) ; d = (int)(d * NormalAttackPowerWave)
  d  = (int)(d * SkillRate) ; d = (int)(d * FirstAttackRate) ; d = (int)(d * AutoSkillRate) ; d = (int)(d * StableRate)
  d  = d + AutoSkillConstant
  d  = (int)(d * ExpRate)                      <- PRORATION  = p[slot] / 100   (GetTargetExpRate, RVA 0x1EA9294)
  d  = (int)(d * TypeDamageRate) ; d = (int)(d * LastDamageRate) ; d = (int)(d * DistanceResistRate)
  d  = (int)(d * SpecialLastDamageRate) ; d = (int)(d * GemDamageRate) ; d = (int)(d * AbnormalDamageIncreaseRate)
  d  = max(d, 0) + LastConstantDamage ; guarded: d = (int)(d * GuardPower / 100) ; damage limits ; if d <= 0: d = 1
Skill-specific terms are the ones listed below (SkillRate / SkillConstantDamage / CriticalRate ...); the rest comes from the engine.
Proration state per monster: p[Normal], p[Skill], p[Magic] start at 100; a counted hit moves p[hit slot] DOWN by that slot's step
and the other two slots UP by their own steps; every value is clamped to 50..250 (MobStatus.CalcExpDef, RVA 0x1F37150).
"""


def full_code_text(r):
    """everything recovered for one skill, untruncated"""
    L = [ENGINE_TEXT, "=" * 100]
    pr = r.get("proration") or {}
    L.append(f"SKILL uid {r['uid']}   class {r.get('class') or r.get('mastery_class') or '-'}   type {r.get('category')}")
    if pr:
        L.append(f"PRORATION  slot={pr.get('slot')}  mode={pr.get('mode')}  attack_type={pr.get('attack_type')}  action_id={pr.get('action_id')}  "
                 f"IsExpDefFluctuate={pr.get('is_exp_def_fluctuate')}  spawns={pr.get('child_actions') or '-'}")
    L.append("")
    for mname, m in r.get("methods", {}).items():
        L.append(f"--- method {mname}   RVA {m.get('addr')}   paths={m.get('paths')}" + ("   TRUNCATED (path/instruction cap hit)" if m.get("truncated") else ""))
        if m.get("when_all"):
            L.append("    conditions common to every path: " + " AND ".join(m["when_all"]))
        for it in m.get("items", []):
            L.append(f"    [{it['kind']:8}] {it['name']} = {it['text']}")
            if it.get("by_level") is not None:
                bl = it["by_level"]
                L.append("               Lv1..10: " + (", ".join(fmt(x) for x in bl) if isinstance(bl, list) else fmt(bl)))
            if it.get("when") and it["when"] != "always":
                L.append(f"               when: {it['when']}")
        L.append("")
    for bc, b in r.get("buffs", {}).items():
        L.append(f"=== BUFF class {bc}")
        L.append("    hooks: " + (", ".join(b.get("hooks", [])) or "-") + "     flags: " + json.dumps(b.get("flags", {})))
        for i, c in enumerate(b.get("ctors", [])):
            L.append(f"    constructor #{i + 1}({c.get('sig')})" + ("   [calls the previous constructor first]" if c.get("chained") else ""))
            for fk, vs in (c.get("fields_resolved") or c["fields"]).items():
                for v in vs:
                    bl = v.get("by_level")
                    L.append(f"        {fk} = {v['expr']}" + (f"   Lv1..10: {bl}" if bl is not None else "") + (f"   when {v['when']}" if v.get("when") != "always" else ""))
        for g in b.get("get_param", []):
            L.append(f"    GetParam[{g['bonus']} ({g['bonus_id']})] = {g['value']}" + (f"   when {' AND '.join(g['when'])}" if g.get("when") else ""))
        for nm, items in b.get("other", {}).items():
            L.append(f"    hook {nm}:")
            for it in items:
                L.append(f"        [{it['kind']}] {it['name']} = {it['text']}" + (f"   when {it['when']}" if it.get("when") != "always" else ""))
        L.append("")
    m = r.get("mastery")
    if m:
        L.append(f"=== MASTERY class {m.get('class')}  (GetMasteryParam(MasteryId), Lv = skill level)")
        for k, b in m.get("bonuses", {}).items():
            L.append(f"    {k} (id {b.get('id')}) = {b.get('expr')}   Lv1..10: {b.get('by_level')}")
    return "\n".join(L)


PRORATION_SLOTS = ("Normal", "Skill", "Magic")


class ProrationPanel(ttk.Frame):
    """Skill proration facts + a per-hit simulator on a chosen monster (rules: proration_calculator/proration_hit_rules.json)."""

    def __init__(self, master, root, skills_tab):
        super().__init__(master)
        self.sk = skills_tab
        pdir = os.path.join(root, "proration_calculator")
        self.mon_path = os.path.join(root, "monsters", "monster_full.csv")
        self.rules = self._json(os.path.join(pdir, "proration_hit_rules.json"))
        modes = self._json(os.path.join(pdir, "skill_proration_modes.json")) or []
        self.modes = {m["skill_uid"]: m for m in modes}
        self.monsters = None
        self.seq = []
        self.cur = None
        self._build()

    @staticmethod
    def _json(p):
        try: return json.load(open(p, encoding="utf-8"))
        except (OSError, ValueError): return None

    def _build(self):
        f, self.t_facts = text_widget(self)
        self.t_facts.configure(height=13)
        f.pack(fill="x", padx=6, pady=(6, 2))
        mid = ttk.Frame(self)
        mid.pack(fill="both", expand=True, padx=6)
        # monster picker
        lm = ttk.LabelFrame(mid, text="1. Monster (steps = proration_normal / physical(Skill) / magic)")
        lm.pack(side="left", fill="both", expand=True)
        self.mq = tk.StringVar()
        e = ttk.Entry(lm, textvariable=self.mq)
        e.pack(fill="x", padx=4, pady=2)
        e.bind("<KeyRelease>", lambda _e: self.fill_monsters())
        cols = ("name", "lv", "diff", "N", "S", "M", "boss")
        self.mt = ttk.Treeview(lm, columns=cols, show="headings", height=8, selectmode="browse")
        for c, w in zip(cols, (200, 45, 60, 40, 40, 40, 70)):
            self.mt.heading(c, text=c)
            self.mt.column(c, width=w, anchor="w")
        self.mt.pack(fill="both", expand=True, padx=4, pady=2)
        self.mt.bind("<<TreeviewSelect>>", lambda _e: self.run())
        # sequence builder
        ls = ttk.LabelFrame(mid, text="2. Attack sequence (one target)")
        ls.pack(side="left", fill="both", expand=True, padx=(6, 0))
        row = ttk.Frame(ls)
        row.pack(fill="x", padx=4, pady=2)
        self.v_casts, self.v_hits = tk.IntVar(value=3), tk.IntVar(value=1)
        ttk.Label(row, text="casts").pack(side="left")
        ttk.Spinbox(row, from_=1, to=99, width=4, textvariable=self.v_casts).pack(side="left", padx=2)
        ttk.Label(row, text="damaging hits per cast").pack(side="left", padx=(8, 0))
        ttk.Spinbox(row, from_=1, to=99, width=4, textvariable=self.v_hits).pack(side="left", padx=2)
        ttk.Button(row, text="+ this skill", command=lambda: self.add(None)).pack(side="left", padx=(10, 2))
        ttk.Button(row, text="+ normal attack", command=lambda: self.add(0)).pack(side="left", padx=2)
        ttk.Button(row, text="remove", command=self.remove).pack(side="left", padx=2)
        ttk.Button(row, text="clear", command=self.clear_seq).pack(side="left", padx=2)
        self.lb = tk.Listbox(ls, height=5, font=UI_FONT, exportselection=False)
        self.lb.pack(fill="both", expand=True, padx=4, pady=2)
        opt = ttk.Frame(ls)
        opt.pack(fill="x", padx=4, pady=2)
        self.v_dyn = tk.StringVar(value="Skill")
        self.v_time = tk.StringVar(value="before")
        self.v_dmg = tk.StringVar(value="10000")
        ttk.Label(opt, text="slot if 'dynamic'").pack(side="left")
        ttk.Combobox(opt, textvariable=self.v_dyn, values=["Skill", "Magic"], width=7, state="readonly").pack(side="left", padx=2)
        ttk.Label(opt, text="counted hit uses p").pack(side="left", padx=(8, 0))
        ttk.Combobox(opt, textvariable=self.v_time, values=["before", "after"], width=7, state="readonly").pack(side="left", padx=2)
        ttk.Label(opt, text="damage before proration").pack(side="left", padx=(8, 0))
        ttk.Entry(opt, textvariable=self.v_dmg, width=9).pack(side="left", padx=2)
        ttk.Button(opt, text="RUN", command=self.run).pack(side="left", padx=8)
        # result
        rc = ("#", "skill", "cast", "hit", "slot", "counted", "p before N/S/M", "multiplier", "damage", "p after N/S/M")
        self.rt = Sortable(self, columns=rc, show="headings", height=12)
        for c, w in zip(rc, (40, 190, 45, 40, 55, 70, 120, 80, 90, 120)):
            self.rt.heading(c, text=c)
            self.rt.column(c, width=w, anchor="w")
        self.rt.pack(fill="both", expand=True, padx=6, pady=6)

    # ---- monsters
    def load_monsters(self):
        if self.monsters is not None: return
        self.monsters = []
        try:
            with open(self.mon_path, encoding="utf-8-sig", errors="replace", newline="") as f:
                for r in csv.DictReader(f):
                    try: st = (int(r["proration_normal"]), int(r["proration_physical"]), int(r["proration_magic"]))
                    except (ValueError, KeyError): continue
                    self.monsters.append({"name": r.get("name_th") or r.get("name_en") or r.get("name_jp") or r.get("uuid"),
                                          "en": r.get("name_en", ""), "lv": r.get("lv", ""), "diff": r.get("difficulty", ""),
                                          "steps": st, "boss": r.get("boss_kind") or ("boss" if r.get("boss") in ("1", "True", "true") else "")})
        except OSError:
            pass
        self.fill_monsters()

    def fill_monsters(self):
        if self.monsters is None: return
        q = self.mq.get().strip().lower()
        self.mt.delete(*self.mt.get_children())
        n = 0
        for i, m in enumerate(self.monsters):
            if q and q not in (m["name"] + " " + m["en"]).lower(): continue
            self.mt.insert("", "end", iid=str(i), values=(m["name"], m["lv"], m["diff"], *m["steps"], m["boss"]))
            n += 1
            if n >= 600: break

    # ---- skill facts
    def set_skill(self, rec):
        self.cur = rec
        if self.monsters is None: self.load_monsters()
        pr = rec.get("proration") or self.modes.get(rec["uid"]) or {}
        L = [f"Skill {rec['uid']}  {rec.get('name_th') or rec.get('class') or ''}"]
        if not pr:
            L.append("No client action class -> no proration data for this entry.")
        else:
            L += [f"slot = {pr.get('slot')}   mode = {pr.get('mode')}   attack type = {pr.get('attack_type')}   action id = {pr.get('action_id')}",
                  f"IsExpDefFluctuate (class) = {pr.get('is_exp_def_fluctuate')}   spawns = {pr.get('child_actions') or '-'}"]
        R = self.rules or {}
        L += ["", "Gate pipeline in EnemyMobActionManagerBase.Damaged (RVA 0x1EEDE78):"]
        for s in R.get("per_hit_pipeline", []):
            L.append(f"  {s['step']}. {s['check']}  ->  {s['effect']}")
        L += ["", "Default rule: " + str(R.get("default_rule")), "Answer: " + str(R.get("answer", ""))]
        sp = [f"{s['action_id']} {s['skill']}: {s['rule']}" for s in R.get("special_action_ids", [])]
        L += ["Bypass / special skills: " + " | ".join(sp)]
        set_text(self.t_facts, "\n".join(L))

    # ---- sequence
    def label(self, e):
        r = self.sk.by.get(e[0]) or {}
        pr = self.modes.get(e[0], {})
        nm = "Normal attack" if e[0] == 0 else (r.get("name_th") or pr.get("cls") or str(e[0]))
        return f"{nm} (uid {e[0]}) x {e[1]} casts x {e[2]} hits   [{pr.get('slot', '?')} / {pr.get('mode', '?')}]"

    def add(self, uid):
        if uid is None:
            if not self.cur: return
            uid = self.cur["uid"]
        self.seq.append((uid, max(1, self.v_casts.get()), max(1, self.v_hits.get())))
        self.lb.insert("end", self.label(self.seq[-1]))
        self.run()

    def remove(self):
        for i in reversed(self.lb.curselection()):
            self.lb.delete(i)
            del self.seq[i]
        self.run()

    def clear_seq(self):
        self.seq.clear()
        self.lb.delete(0, "end")
        self.rt.delete(*self.rt.get_children())

    @staticmethod
    def step(p, steps, slot):
        """MobStatus.CalcExpDef: hit slot down by its step, the other two up by their own, clamp 50..250"""
        out = {}
        for i, s in enumerate(PRORATION_SLOTS):
            d = -steps[i] if s == slot else steps[i]
            out[s] = min(250, max(50, p[s] + d))
        return out

    def run(self):
        self.rt.delete(*self.rt.get_children())
        sel = self.mt.selection()
        if not sel or not self.seq or self.monsters is None: return
        steps = self.monsters[int(sel[0])]["steps"]
        try: base = float(self.v_dmg.get())
        except ValueError: base = 10000.0
        p = {s: 100 for s in PRORATION_SLOTS}
        n = 0
        for uid, casts, hits in self.seq:
            info = self.modes.get(uid, {})
            mode = info.get("mode", "never")
            slot = info.get("slot", "none")
            if slot == "dynamic": slot = self.v_dyn.get()
            name = "Normal attack" if uid == 0 else ((self.sk.by.get(uid) or {}).get("name_th") or info.get("cls") or str(uid))
            name = re.sub(r"\[N2?\]|\[[A-Z]\]", " / ", name).strip(" /")
            never = mode.startswith("never") or slot not in PRORATION_SLOTS
            every = mode.startswith("every_hit")
            for c in range(1, casts + 1):
                done = False
                for h in range(1, hits + 1):
                    before = dict(p)
                    counted = (not never) and (every or not done)
                    after = self.step(p, steps, slot) if counted else p
                    if never: mult = None
                    else: mult = (before if self.v_time.get() == "before" else after)[slot] / 100 if counted else p[slot] / 100
                    p = after
                    done = done or counted
                    n += 1
                    fp = lambda d: "/".join(str(d[s]) for s in PRORATION_SLOTS)
                    self.rt.insert("", "end", values=(n, name, c, h, slot if not never or slot in PRORATION_SLOTS else "-", "yes" if counted else "no",
                                                       fp(before), "-" if mult is None else f"{mult:.2f}",
                                                       "-" if mult is None else int(base * mult), fp(after)))


# --------------------------------------------------------------------------------------------- Skills
# --------------------------------------------------------------------------------------------- Variables
def impl_lines(label, im):
    """text lines for one decoded function (build_variables.decode record): cases, effects, shared sub-expressions"""
    sig = ", ".join(f"{t} {n}" for t, n in im.get("params", []))
    L = [f"=== {label}({sig}) -> {im.get('returns')}    @{im.get('addr')}    paths {im.get('npaths')}" + ("   TRUNCATED" if im.get("truncated") else "")]
    if im.get("error"): L.append(f"  decode error: {im['error']}")
    for c in im.get("cases", []):
        when = " AND ".join(c["common"]) or "always"
        L.append(f"  when {when}" + (f"   [{len(c['variants'])} variant(s) of this case]" if c.get("variants") else ""))
        L.append(f"    = {c['value']}")
        for v in c.get("variants", [])[:6]:
            L.append("      or " + (" AND ".join(v) if v else "always"))
        if len(c.get("variants", [])) > 6: L.append(f"      ... {len(c['variants']) - 6} more")
    if im.get("events"):
        L.append("  effects (writes / template terms / calls), each with its condition:")
        for ev in im["events"][:80]:
            L.append(f"    [{ev['kind']}] {ev['name']} = {ev['value']}" + (f"    when {' AND '.join(ev['when'])}" if ev["when"] else ""))
        if len(im["events"]) > 80: L.append(f"    ... {len(im['events']) - 80} more events")
    if im.get("lets"):
        L.append("  named sub-expressions:")
        for k, x in im["lets"].items(): L.append(f"    {k} = {x}")
    L.append("")
    return L


class VarStore:
    """skills/damage/variables.json (glossary of every variable / helper / enum used by the skill formulas) + skill_variables.json."""

    def __init__(self, base):
        self.vars, self.skill, self.meta = {}, {}, {}
        p = os.path.join(base, "variables.json")
        if os.path.exists(p):
            with open(p, encoding="utf-8") as f:
                d = json.load(f)
            self.vars, self.meta = d.get("vars", {}), d.get("meta", {})
        p = os.path.join(base, "skill_variables.json")
        if os.path.exists(p):
            with open(p, encoding="utf-8") as f:
                self.skill = {int(k): v for k, v in json.load(f).items()}

    def describe(self, vid, names=None):
        e = self.vars.get(vid)
        if not e: return f"{vid}\n(not in glossary)"
        L = [f"{e['id']}", f"kind: {e['kind']}    evidence: {e.get('label', '-')}" + ("    (leaf: no client code, accessor / enum / out value)" if e.get("leaf") else ""), "",
             f"TH : {e.get('gloss_th') or '-'}", f"EN : {e.get('gloss_en') or '-'}", ""]
        if e.get("values"):
            L.append(f"values ({e.get('elem_type')}[{len(e['values'])}]): " + ", ".join(f"{n} ({v})" for v, n in zip(e["values"], e.get("names") or e["values"])))
            L.append("")
        for im in e.get("impls", []):
            L += impl_lines(f"{im.get('class')}.{e['member']}", im)
        if e.get("refs"): L += ["references: " + ", ".join(e["refs"][:60]) + (" ..." if len(e["refs"]) > 60 else ""), ""]
        if e.get("used_by"):
            nm = (lambda u: f"{u} {names.get(u, '')}".strip()) if names else str
            L.append(f"used by {len(e['used_by'])} skill(s): " + ", ".join(nm(u) for u in e["used_by"][:40]) + (" ..." if len(e["used_by"]) > 40 else ""))
        return "\n".join(L)


def spec_text(sp):
    """calc_spec/<uid>.json -> plain text (what a damage calculator needs for this skill)"""
    if not sp: return "(no calc spec: run build_calc_spec.py)"
    L = [f"CALC SPEC  uid {sp['uid']}  {sp.get('name_en') or ''}   class {sp.get('class') or '-'}   tree {sp.get('tree')}   max Lv (client) {sp.get('max_level')}",
         f"roles: {' | '.join(sp.get('roles', [])) or '-'}", ""]
    pr = sp.get("proration") or {}
    if pr.get("slot"): L += [f"proration: slot {pr.get('slot')}  mode {pr.get('mode')}  attack type {pr.get('attack_type')}", ""]

    def row(e):
        w = "" if e["when"] in ("always", "") else f"    [when {e['when']}]"
        t = ""
        if e.get("by_level") is not None:
            bl = e["by_level"]
            t = "    Lv1..: " + (", ".join(fmt(x) for x in bl) if isinstance(bl, list) else fmt(bl))
        f = e["formula"] if e["formula"] == e.get("simplified") else f"{e['simplified']}      (raw: {e['formula']})"
        return f, w, t

    if sp["fields"]:
        L.append("INPUT FIELDS (values the skill sets; Lv = skill level)")
        for e in sp["fields"]:
            f, w, t = row(e)
            L.append(f"  [{e['method']}] {e['name']} = {f}{w}{t}")
        L.append("")
    if sp["terms"]:
        L.append("DAMAGE TERMS (put into the shared SkillCalcTemplate; AddRate sums, SetRate replaces, see engine.json)")
        cur = None
        for e in sp["terms"]:
            if e["method"] != cur: cur = e["method"]; L.append(f"  -- {cur}")
            f, w, t = row(e)
            L.append(f"    {e.get('op', '?')}[{e.get('step', e['name'])}] = {f}{w}{t}")
        L.append("")
    if sp["effects"]:
        L.append("EFFECTS (calls: buffs, ailment rolls, helpers) with conditions")
        for e in sp["effects"]:
            f, w, t = row(e)
            L.append(f"  [{e['method']}] {e['name']}({f}){w}")
        L.append("")
    if sp["buffs"]:
        L.append("BUFFS")
        for b in sp["buffs"]:
            L.append(f"  {b['class']}  ({b['kind']})" + (f"   attached via {b['attached_via']}" if b.get("attached_via") else ""))
            for c in b["ctors"]:
                for fk, vs in c["fields"].items():
                    for v in vs: L.append(f"      ctor({c.get('sig')}): {fk} = {v['formula']}" + (f"  [{v['when']}]" if v.get("when") not in (None, "always") else ""))
                if c.get("base_ctor"): L.append(f"      base ctor {c['base_ctor']['class']}({', '.join(c['base_ctor']['args'])})  params {c['base_ctor']['params']}")
            for pm in b["params"]:
                L.append(f"      param {pm['id']} = {pm['simplified']}" + (f"  [{' AND '.join(pm['when'])}]" if pm["when"] else ""))
            for fk, ups in b["state"].items():
                for u in ups: L.append(f"      state {fk} <- {u['method']}: {u['formula']}")
            if b.get("child_args"): L.append(f"      constructor args passed by derived buffs: {b['child_args']}")
        L.append("")
    if sp.get("passives"): L += ["PASSIVE (mastery)", "  " + json.dumps(sp["passives"], ensure_ascii=False)[:1500], ""]
    if sp["hooks"]: L += ["HOOKS (other client functions that read this skill; definitions in the Variables tab)"] + [f"  {h}" for h in sp["hooks"]] + [""]
    L += [f"VARIABLES used ({len(sp['variables'])}): " + ", ".join(sp["variables"][:80]) + (" ..." if len(sp["variables"]) > 80 else ""), ""]
    L.append("RESIDUAL markers: " + ("none" if not sp["residual"] else "; ".join(f"{r['where']} {r['tokens']}" for r in sp["residual"][:12])))
    return "\n".join(L)


class VarPanel(ttk.Frame):
    """Left: variable list (search + kind filter). Right: definition text + clickable references."""

    def __init__(self, master, store, names, goto=None):
        super().__init__(master)
        self.st, self.names, self.goto = store, names, goto
        self.base_ids = None
        top = ttk.Frame(self)
        top.pack(fill="x", padx=6, pady=4)
        self.q = tk.StringVar()
        ttk.Label(top, text="Search").pack(side="left")
        e = ttk.Entry(top, textvariable=self.q, width=28)
        e.pack(side="left", padx=4)
        e.bind("<KeyRelease>", lambda _e: self.refresh())
        self.kind = tk.StringVar(value="(all)")
        kinds = sorted({v["kind"] for v in store.vars.values()})
        ttk.Label(top, text="Kind").pack(side="left", padx=(10, 2))
        cb = ttk.Combobox(top, textvariable=self.kind, values=["(all)"] + kinds, width=16, state="readonly")
        cb.pack(side="left")
        cb.bind("<<ComboboxSelected>>", lambda _e: self.refresh())
        self.in_def = tk.BooleanVar()
        ttk.Checkbutton(top, text="search in definitions", variable=self.in_def, command=self.refresh).pack(side="left", padx=10)
        self.count = ttk.Label(top)
        self.count.pack(side="right")
        pw = ttk.PanedWindow(self, orient="horizontal")
        pw.pack(fill="both", expand=True)
        left = ttk.Frame(pw)
        cols = ("id", "kind", "meaning")
        self.tv = Sortable(left, columns=cols, show="headings", selectmode="browse")
        for c, w in zip(cols, (300, 90, 320)):
            self.tv.column(c, width=w, anchor="w")
        self.tv.enable_sort()
        sb = ttk.Scrollbar(left, command=self.tv.yview)
        self.tv.configure(yscrollcommand=sb.set)
        self.tv.pack(side="left", fill="both", expand=True)
        sb.pack(side="right", fill="y")
        self.tv.bind("<<TreeviewSelect>>", lambda _e: self.show())
        pw.add(left, weight=2)
        right = ttk.Frame(pw)
        f, self.txt = text_widget(right)
        f.pack(fill="both", expand=True)
        self.refs = tk.Listbox(right, height=6, font=MONO)
        self.refs.pack(fill="x", padx=4, pady=(2, 4))
        self.refs.bind("<Double-Button-1>", lambda _e: self.follow())
        pw.add(right, weight=4)

    def set_ids(self, ids):
        """restrict the list to these ids (per-skill view); None = every variable"""
        self.base_ids = ids
        self.refresh()

    def refresh(self):
        self.tv.delete(*self.tv.get_children())
        q = self.q.get().strip().lower()
        k = self.kind.get()
        pool = self.st.vars.keys() if self.base_ids is None else self.base_ids
        n = 0
        for vid in pool:
            e = self.st.vars.get(vid)
            if not e: continue
            if k != "(all)" and e["kind"] != k: continue
            if q and q not in vid.lower() and q not in (e.get("gloss_th") or "").lower() and q not in (e.get("gloss_en") or "").lower():
                if not (self.in_def.get() and q in json.dumps(e.get("impls"), ensure_ascii=False).lower()): continue
            self.tv.insert("", "end", iid=vid, values=(vid, e["kind"], e.get("gloss_th") or ""))
            n += 1
        self.count.configure(text=f"{n} / {len(self.st.vars) if self.base_ids is None else len(self.base_ids)} variables")
        set_text(self.txt, "")
        self.refs.delete(0, "end")

    def select(self, vid):
        if not self.tv.exists(vid):
            self.q.set(""); self.kind.set("(all)"); self.refresh()
        if self.tv.exists(vid):
            self.tv.selection_set(vid); self.tv.see(vid); self.show()

    def show(self):
        sel = self.tv.selection()
        if not sel: return
        vid = sel[0]
        set_text(self.txt, self.st.describe(vid, self.names))
        self.refs.delete(0, "end")
        for r in self.st.vars.get(vid, {}).get("refs", []): self.refs.insert("end", r)

    def follow(self):
        s = self.refs.curselection()
        if not s: return
        vid = self.refs.get(s[0])
        if self.goto: self.goto(vid)
        else: self.select(vid)


class StatsTab(ttk.Frame):
    """skills/damage/stats/raw: decoded player / weapon / bonus / mob / attack functions (symexec), one entry per client method."""

    def __init__(self, master, base):
        super().__init__(master)
        self.dir = os.path.join(base, "skills", "damage", "stats", "decoded")
        p = os.path.join(self.dir, "index.json")
        self.idx = {}
        if os.path.exists(p):
            with open(p, encoding="utf-8") as f: self.idx = json.load(f)
        top = ttk.Frame(self)
        top.pack(fill="x", padx=6, pady=4)
        self.q = tk.StringVar()
        ttk.Label(top, text="Search").pack(side="left")
        e = ttk.Entry(top, textvariable=self.q, width=28)
        e.pack(side="left", padx=4)
        e.bind("<KeyRelease>", lambda _e: self.refresh())
        self.grp = tk.StringVar(value="(all)")
        ttk.Label(top, text="Group").pack(side="left", padx=(10, 2))
        cb = ttk.Combobox(top, textvariable=self.grp, values=["(all)"] + sorted({v["group"] for v in self.idx.values()}), width=14, state="readonly")
        cb.pack(side="left")
        cb.bind("<<ComboboxSelected>>", lambda _e: self.refresh())
        self.count = ttk.Label(top)
        self.count.pack(side="right")
        pw = ttk.PanedWindow(self, orient="horizontal")
        pw.pack(fill="both", expand=True)
        left = ttk.Frame(pw)
        cols = ("function", "group", "status", "paths")
        self.tv = Sortable(left, columns=cols, show="headings", selectmode="browse")
        for c, w in zip(cols, (330, 80, 60, 50)): self.tv.column(c, width=w, anchor="w")
        self.tv.enable_sort()
        sb = ttk.Scrollbar(left, command=self.tv.yview)
        self.tv.configure(yscrollcommand=sb.set)
        self.tv.pack(side="left", fill="both", expand=True)
        sb.pack(side="right", fill="y")
        self.tv.bind("<<TreeviewSelect>>", lambda _e: self.show())
        pw.add(left, weight=2)
        f, self.txt = text_widget(pw)
        pw.add(f, weight=5)
        self.refresh()

    def refresh(self):
        self.tv.delete(*self.tv.get_children())
        q, g = self.q.get().strip().lower(), self.grp.get()
        n = 0
        for name, v in self.idx.items():
            if (g != "(all)" and v["group"] != g) or (q and q not in name.lower()): continue
            self.tv.insert("", "end", iid=name, values=(name, v["group"], v["status"], v["paths"]))
            n += 1
        self.count.configure(text=f"{n} / {len(self.idx)} functions")
        set_text(self.txt, "")

    def show(self):
        sel = self.tv.selection()
        if not sel: return
        v = self.idx[sel[0]]
        with open(os.path.join(self.dir, v["file"]), encoding="utf-8") as f: r = json.load(f)
        set_text(self.txt, "\n".join(impl_lines(r["name"], r)))


class SkillsTab(ttk.Frame):
    def __init__(self, master, root):
        super().__init__(master)
        self.root_dir = root
        self.base = os.path.join(root, "skills", "damage")
        self.icon_dir = os.path.join(root, "skills")
        self.imgs = {}
        p = os.path.join(self.base, "skill_reference.json")
        self.recs = json.load(open(p, encoding="utf-8")) if os.path.exists(p) else []
        self.by = {r["uid"]: r for r in self.recs}
        self.det = DetailStore(self.base)
        self.vs = VarStore(self.base)
        self.on_goto = None
        self._build()
        self.refresh()

    # ---- ui
    def _build(self):
        top = ttk.Frame(self)
        top.pack(fill="x", padx=6, pady=4)
        self.q = tk.StringVar()
        ttk.Label(top, text="Search").pack(side="left")
        e = ttk.Entry(top, textvariable=self.q, width=28)
        e.pack(side="left", padx=4)
        e.bind("<KeyRelease>", lambda _e: self.refresh())
        self.f_tree, self.f_cat, self.f_role, self.f_pro, self.f_cov = (tk.StringVar(value="(all)") for _ in range(5))
        recs = self.recs
        opts = {
            "Tree": (self.f_tree, sorted({str(r.get("tree_type") or "-") for r in recs})),
            "Type": (self.f_cat, sorted({r.get("category") or "-" for r in recs})),
            "Role": (self.f_role, sorted({q for r in recs for q in r.get("roles", [])})),
            "Proration": (self.f_pro, sorted({(r.get("proration") or {}).get("mode", "-") for r in recs})),
            "Coverage": (self.f_cov, sorted({self.det.state(r["uid"]) for r in recs})),
        }
        for lab, (var, vals) in opts.items():
            ttk.Label(top, text=lab).pack(side="left", padx=(10, 2))
            cb = ttk.Combobox(top, textvariable=var, values=["(all)"] + vals, width=18, state="readonly")
            cb.pack(side="left")
            cb.bind("<<ComboboxSelected>>", lambda _e: self.refresh())
        self.only_dmg = tk.BooleanVar()
        ttk.Checkbutton(top, text="damage only", variable=self.only_dmg, command=self.refresh).pack(side="left", padx=10)
        self.in_det = tk.BooleanVar()
        ttk.Checkbutton(top, text="search in details text", variable=self.in_det, command=self.refresh).pack(side="left")
        self.count = ttk.Label(top)
        self.count.pack(side="right")

        pw = ttk.PanedWindow(self, orient="horizontal")
        pw.pack(fill="both", expand=True)
        left = ttk.Frame(pw)
        cols = ("uid", "name", "tree", "type", "class", "state", "roles")
        self.tv = Sortable(left, columns=cols, show="headings", selectmode="browse")
        for c, w in zip(cols, (50, 170, 90, 70, 150, 90, 40)):
            self.tv.column(c, width=w, anchor="w")
        self.tv.enable_sort()
        sb = ttk.Scrollbar(left, command=self.tv.yview)
        self.tv.configure(yscrollcommand=sb.set)
        self.tv.pack(side="left", fill="both", expand=True)
        sb.pack(side="right", fill="y")
        self.tv.bind("<<TreeviewSelect>>", lambda _e: self.show())
        pw.add(left, weight=2)

        right = ttk.Frame(pw)
        head = ttk.Frame(right)
        head.pack(fill="x", padx=6, pady=4)
        self.icon = ttk.Label(head)
        self.icon.pack(side="left", padx=(0, 8))
        self.title = ttk.Label(head, font=("Tahoma", 13, "bold"), wraplength=700, justify="left")
        self.title.pack(side="left", anchor="w")
        nb = ttk.Notebook(right)
        nb.pack(fill="both", expand=True)
        f1, self.t_over = text_widget(nb, mono=False)
        fth, self.t_th = text_widget(nb, mono=False)
        fd, self.t_details = text_widget(nb, mono=False)
        f3, self.t_det = text_widget(nb)
        f4, self.t_json = text_widget(nb)
        nb.add(f1, text="Overview")
        nb.add(fth, text="อธิบาย (TH)")
        nb.add(fd, text="Details")
        names = {r["uid"]: re.sub(r"\[N2?\]|\[[A-Z]\]", " / ", r.get("name_th") or r.get("class") or "").strip(" /") for r in self.recs}
        self.varp = VarPanel(nb, self.vs, names, goto=self.goto_var)
        nb.add(self.varp, text="Variables")
        fsp, self.t_spec = text_widget(nb)
        nb.add(fsp, text="Calc spec")
        num = ttk.Frame(nb)
        nb.add(num, text="Numbers")
        nb.add(f3, text="Formulas / buffs")
        f5, self.t_code = text_widget(nb)
        nb.add(f5, text="Full code data")
        self.pro = ProrationPanel(nb, self.root_dir, self)
        nb.add(self.pro, text="Proration")
        nb.add(f4, text="Raw JSON")
        cols2 = ["value"] + [f"Lv{i}" for i in range(1, 11)]
        self.num_tv = ttk.Treeview(num, columns=cols2, show="headings", height=8)
        self.num_tv.column("value", width=330, anchor="w")
        for c in cols2[1:]:
            self.num_tv.column(c, width=62, anchor="e")
        for c in cols2:
            self.num_tv.heading(c, text=c)
        self.num_tv.pack(fill="x", padx=6, pady=6)
        f2, self.t_sym = text_widget(num)
        f2.pack(fill="both", expand=True, padx=6, pady=(0, 6))
        pw.add(right, weight=5)

    def goto_var(self, vid):
        if self.on_goto: self.on_goto(vid)
        else: self.varp.select(vid)

    # ---- data
    def match(self, r):
        q = self.q.get().strip().lower()
        if q:
            hay = " ".join(str(x) for x in (r["uid"], r.get("name_th"), r.get("name_en"), r.get("class"), r.get("mastery_class"), r.get("tree"))).lower()
            if q not in hay and not (self.in_det.get() and self.det.has(r["uid"], q)):
                return False
        if self.f_cov.get() != "(all)" and self.det.state(r["uid"]) != self.f_cov.get(): return False
        if self.f_tree.get() != "(all)" and str(r.get("tree_type") or "-") != self.f_tree.get(): return False
        if self.f_cat.get() != "(all)" and (r.get("category") or "-") != self.f_cat.get(): return False
        if self.f_role.get() != "(all)" and self.f_role.get() not in r.get("roles", []): return False
        if self.f_pro.get() != "(all)" and (r.get("proration") or {}).get("mode", "-") != self.f_pro.get(): return False
        if self.only_dmg.get() and not any("attack (deals" in q for q in r.get("roles", [])): return False
        return True

    def refresh(self):
        self.tv.delete(*self.tv.get_children())
        n = 0
        for r in self.recs:
            if not self.match(r): continue
            name = re.sub(r"\[N2?\]|\[[A-Z]\]", " / ", r.get("name_th") or r.get("class") or "").strip(" /")
            self.tv.insert("", "end", iid=str(r["uid"]), values=(
                r["uid"], name, r.get("tree_type") or "", r.get("category") or "", r.get("class") or r.get("mastery_class") or "", self.det.state(r["uid"]), len(r.get("roles", []))))
            n += 1
        self.count.configure(text=f"{n} / {len(self.recs)} skills")

    def show(self):
        sel = self.tv.selection()
        if not sel: return
        r = self.by[int(sel[0])]
        name = re.sub(r"\[N2?\]|\[[A-Z]\]", " / ", r.get("name_th") or r.get("class") or "").strip(" /")
        self.title.configure(text=f"{name}   {r.get('name_en') or ''}   (uid {r['uid']})")
        ic = r.get("icon")
        img = None
        if ic:
            if ic not in self.imgs:
                p = os.path.join(self.icon_dir, ic)
                try: self.imgs[ic] = tk.PhotoImage(file=p).zoom(2) if os.path.exists(p) else None
                except tk.TclError: self.imgs[ic] = None
            img = self.imgs[ic]
        self.icon.configure(image=img or "")
        pr = r.get("proration") or {}
        lines = [
            f"Tree      : {str(r.get('tree') or '').lstrip('#')}  [{r.get('tree_type')}]  tier {r.get('tree_lv')}",
            f"Type      : {r.get('category')}    Max Lv (client): {r.get('max_level')}",
            f"Weapons   : {', '.join(r.get('eq_limit') or []) or '-'}",
            f"Flags     : {', '.join(r.get('flags') or []) or '-'}",
            f"Requires  : {self.by.get(r.get('premise_uid'), {}).get('name_th') or r.get('premise_uid') or '-'}",
            f"Class     : {r.get('class') or r.get('mastery_class') or '-'}",
            f"Coverage  : {self.det.state(r['uid'])}" + (f" - {self.det.cov[r['uid']]['reason']}" if (self.det.cov.get(r["uid"]) or {}).get("reason") else ""),
            "",
            "Roles     : " + (" | ".join(r.get("roles", [])) or "-"),
            f"Proration : slot={pr.get('slot', '-')}  mode={pr.get('mode', '-')}  attack type={pr.get('attack_type', '-')}",
        ]
        if pr.get("child_actions"): lines.append(f"Spawns    : {pr['child_actions']}")
        lines += ["", "Description", "-----------", r.get("desc_th") or "-", ""]
        if r.get("notes"):
            lines.append("In-game level notes")
            for n in r["notes"]:
                lines.append(f"  Lv{n.get('level')}: {(n.get('text') or '').replace(chr(10), ' ')}")
        set_text(self.t_over, "\n".join(lines))
        set_text(self.t_th, clean_md(self.det.th(r["uid"])) or "(ยังไม่มีคำอธิบายภาษาไทยของสกิลนี้ — ดูแท็บ Details)")
        set_text(self.t_details, clean_md(self.det.get(r["uid"])) or "(no detail entry: run scripts/render_details.py)")

        self.num_tv.delete(*self.num_tv.get_children())
        v = r.get("view", {})
        for t in v.get("tables", []):
            self.num_tv.insert("", "end", values=[t["label"]] + [fmt(x) for x in t["by_level"]])
        m = r.get("mastery")
        if m:
            for k, b in m.get("bonuses", {}).items():
                if b.get("by_level"): self.num_tv.insert("", "end", values=[f"mastery: {k}"] + [fmt(x) for x in b["by_level"]])
        sym = ["Formulas that read live stats (not tabulated):"] + [
            f"  {s['label']}: {s['formula']}" + (f"   [{s['when']}]" if s["when"] != "base" else "") for s in v.get("symbolic", [])] if v.get("symbolic") else \
            ["(every number of this skill is tabulated above)" if v.get("tables") else "(no damage numbers for this skill - see Formulas / buffs)"]
        set_text(self.t_sym, "\n".join(sym))
        set_text(self.t_det, clean_md(v.get("md", "")))
        set_text(self.t_code, full_code_text(r))
        self.pro.set_skill(r)
        sp_path = os.path.join(self.base, "calc_spec", f"{r['uid']}.json")
        try:
            with open(sp_path, encoding="utf-8") as fh: spec = json.load(fh)
        except OSError:
            spec = None
        set_text(self.t_spec, spec_text(spec))
        sv = self.vs.skill.get(r["uid"]) or {}
        self.varp.set_ids(list(dict.fromkeys(sv.get("hooks", []) + sv.get("vars", []))))
        raw = {k: x for k, x in r.items() if k != "view"}
        set_text(self.t_json, json.dumps(raw, ensure_ascii=False, indent=1))


# --------------------------------------------------------------------------------------------- Files
class FilesTab(ttk.Frame):
    SKIP_DIRS = {"__pycache__", ".git"}

    def __init__(self, master, root):
        super().__init__(master)
        self.root_dir = root
        self.img = None
        self.rows = []
        pw = ttk.PanedWindow(self, orient="horizontal")
        pw.pack(fill="both", expand=True)
        left = ttk.Frame(pw)
        self.tree = ttk.Treeview(left, show="tree", selectmode="browse")
        sb = ttk.Scrollbar(left, command=self.tree.yview)
        self.tree.configure(yscrollcommand=sb.set)
        self.tree.pack(side="left", fill="both", expand=True)
        sb.pack(side="right", fill="y")
        pw.add(left, weight=1)
        right = ttk.Frame(pw)
        bar = ttk.Frame(right)
        bar.pack(fill="x", padx=6, pady=4)
        self.info = ttk.Label(bar, text="select a file")
        self.info.pack(side="left")
        self.q = tk.StringVar()
        e = ttk.Entry(bar, textvariable=self.q, width=30)
        e.pack(side="right")
        ttk.Label(bar, text="filter rows").pack(side="right", padx=4)
        e.bind("<KeyRelease>", lambda _e: self.fill_table())
        self.body = ttk.Frame(right)
        self.body.pack(fill="both", expand=True)
        pw.add(right, weight=4)
        self.tree.bind("<<TreeviewOpen>>", self.on_open)
        self.tree.bind("<<TreeviewSelect>>", self.on_select)
        self.add_children("", root)

    def add_children(self, parent, path):
        try:
            names = sorted(os.listdir(path), key=lambda n: (not os.path.isdir(os.path.join(path, n)), n.lower()))
        except OSError:
            return
        for n in names:
            if n in self.SKIP_DIRS: continue
            p = os.path.join(path, n)
            iid = self.tree.insert(parent, "end", iid=p, text=n, open=False)
            if os.path.isdir(p):
                self.tree.insert(iid, "end", iid=p + "\0dummy", text="...")

    def on_open(self, _e):
        iid = self.tree.focus()
        kids = self.tree.get_children(iid)
        if len(kids) == 1 and kids[0].endswith("\0dummy"):
            self.tree.delete(kids[0])
            self.add_children(iid, iid)

    def clear(self):
        self.tv = None
        for w in self.body.winfo_children(): w.destroy()

    def on_select(self, _e):
        p = self.tree.focus()
        if not p or os.path.isdir(p): return
        self.clear()
        ext = os.path.splitext(p)[1].lower()
        size = os.path.getsize(p)
        self.info.configure(text=f"{p}   ({size:,} bytes)")
        self.rows = []
        try:
            if ext in (".csv", ".tsv"): self.open_table(p, "\t" if ext == ".tsv" else ",")
            elif ext in (".png", ".gif"): self.open_image(p)
            elif ext in (".json", ".md", ".txt", ".log", ".py", ".cs", ".yml", ".yaml", ".xml", ".html") and size < 8_000_000: self.open_text(p, ext)
            else:
                f, t = text_widget(self.body)
                f.pack(fill="both", expand=True)
                set_text(t, "(binary or too large - not previewed)")
        except Exception as ex:   # viewer must never die on a bad file
            f, t = text_widget(self.body)
            f.pack(fill="both", expand=True)
            set_text(t, f"cannot open: {ex!r}")

    def open_text(self, p, ext):
        s = open(p, encoding="utf-8", errors="replace").read()
        if ext == ".json":
            try: s = json.dumps(json.loads(s), ensure_ascii=False, indent=1)
            except ValueError: pass
        f, t = text_widget(self.body)
        f.pack(fill="both", expand=True)
        set_text(t, s[:3_000_000])

    def open_image(self, p):
        self.img = tk.PhotoImage(file=p)
        ttk.Label(self.body, image=self.img).pack(padx=10, pady=10, anchor="nw")

    def open_table(self, p, delim):
        with open(p, encoding="utf-8-sig", errors="replace", newline="") as f:
            rd = csv.reader(f, delimiter=delim)
            self.head = next(rd, [])
            self.rows = []
            for i, row in enumerate(rd):
                if i >= MAX_ROWS: break
                self.rows.append(row)
        wrap = ttk.Frame(self.body)
        wrap.pack(fill="both", expand=True)
        self.tv = Sortable(wrap, columns=self.head or ["-"], show="headings")
        self.tv.enable_sort()
        for c in self.head:
            self.tv.column(c, width=110, anchor="w")
        sy = ttk.Scrollbar(wrap, command=self.tv.yview)
        sx = ttk.Scrollbar(wrap, orient="horizontal", command=self.tv.xview)
        self.tv.configure(yscrollcommand=sy.set, xscrollcommand=sx.set)
        sy.pack(side="right", fill="y")
        sx.pack(side="bottom", fill="x")
        self.tv.pack(fill="both", expand=True)
        self.fill_table()

    def fill_table(self):
        if not getattr(self, "tv", None): return
        q = self.q.get().strip().lower()
        self.tv.delete(*self.tv.get_children())
        n = 0
        for row in self.rows:
            if q and q not in " ".join(row).lower(): continue
            self.tv.insert("", "end", values=row[:len(self.head)])
            n += 1
        self.info.configure(text=self.info.cget("text").split("   rows:")[0] + f"   rows: {n}/{len(self.rows)}" + ("  (first 20000)" if len(self.rows) >= MAX_ROWS else ""))


# --------------------------------------------------------------------------------------------- Overview
class OverviewTab(ttk.Frame):
    """skills/damage/overview/overview.json (scripts/build_overview.py): per skill, where the damage multiplier comes from, per-weapon splits,
    states during the cast, buffs and links to other skills. The same text is written to skills/damage/overview_th/*.md."""
    FLAGS = (("W", "แยกตามอาวุธ", lambda r: r["damage"] and r["damage"]["split"]),
             ("I", "คงกระพัน/Super Armor", lambda r: any(s["kind"] in ("invincible", "super_armor") for s in r["cast_states"])),
             ("D", "บัพ/พาสซีฟลดดาเมจ", lambda r: any(b["group"] == "defense" for b in r["buffs"]) or any(p["id"] in ("CutDmgRate",) for p in r["passives"])),
             ("L", "เชื่อมสกิลอื่น", lambda r: bool(r["boosted_by"] or r["links"]["gives_buff_of"] or any(not e["self"] and e["owner"] for e in r["links"]["read_by"]))),
             ("P", "หลายรูปแบบ/แพตเทิร์น", lambda r: bool(r["variants"] or r.get("pattern"))),
             ("T", "มี damage term", lambda r: r["damage"] and r["damage"]["hits"]))

    def __init__(self, master, base, goto=None):
        super().__init__(master)
        self.dir = os.path.join(base, "skills", "damage")
        self.goto = goto
        self.data, self.meta = {}, {}
        p = os.path.join(self.dir, "overview", "overview.json")
        if os.path.exists(p):
            with open(p, encoding="utf-8") as f: d = json.load(f)
            self.data, self.meta = d["skills"], d["meta"]
        top = ttk.Frame(self)
        top.pack(fill="x", padx=6, pady=4)
        self.q = tk.StringVar()
        ttk.Label(top, text="ค้นหา").pack(side="left")
        e = ttk.Entry(top, textvariable=self.q, width=26)
        e.pack(side="left", padx=4)
        e.bind("<KeyRelease>", lambda _e: self.refresh())
        self.tree = tk.StringVar(value="(ทุกทรี)")
        trees = sorted({r["tree_th"] for r in self.data.values()})
        cb = ttk.Combobox(top, textvariable=self.tree, values=["(ทุกทรี)"] + trees, width=24, state="readonly")
        cb.pack(side="left", padx=4)
        cb.bind("<<ComboboxSelected>>", lambda _e: self.refresh())
        self.fv = {}
        for k, label, _fn in self.FLAGS:
            v = tk.BooleanVar(value=False)
            self.fv[k] = v
            ttk.Checkbutton(top, text=f"{k}={label}", variable=v, command=self.refresh).pack(side="left", padx=3)
        ttk.Button(top, text="วิธีอ่าน / สูตรรวม", command=self.show_engine).pack(side="right", padx=4)
        ttk.Button(top, text="ไปแท็บ Skills", command=self.jump).pack(side="right")
        self.count = ttk.Label(top)
        self.count.pack(side="right", padx=8)
        pw = ttk.PanedWindow(self, orient="horizontal")
        pw.pack(fill="both", expand=True)
        left = ttk.Frame(pw)
        cols = ("uid", "name", "tree") + tuple(k for k, _l, _f in self.FLAGS)
        self.tv = Sortable(left, columns=cols, show="headings", selectmode="browse")
        for c, w in zip(cols, (50, 200, 120) + (28,) * len(self.FLAGS)): self.tv.column(c, width=w, anchor="w")
        self.tv.enable_sort()
        sb = ttk.Scrollbar(left, command=self.tv.yview)
        self.tv.configure(yscrollcommand=sb.set)
        self.tv.pack(side="left", fill="both", expand=True)
        sb.pack(side="right", fill="y")
        self.tv.bind("<<TreeviewSelect>>", lambda _e: self.show())
        pw.add(left, weight=2)
        f, self.txt = text_widget(pw, mono=False)
        pw.add(f, weight=5)
        self.refresh()

    def name(self, r):
        return re.sub(r"\[[A-Z0-9]+\]", " / ", r.get("name_th") or r.get("name_en") or r.get("cls") or "").strip(" /")

    def refresh(self):
        self.tv.delete(*self.tv.get_children())
        q, tr = self.q.get().strip().lower(), self.tree.get()
        n = 0
        for uid, r in self.data.items():
            if tr != "(ทุกทรี)" and r["tree_th"] != tr: continue
            if any(self.fv[k].get() and not fn(r) for k, _l, fn in self.FLAGS): continue
            if q and q not in f"{uid} {self.name(r)} {r.get('name_en') or ''} {r['text']}".lower(): continue
            self.tv.insert("", "end", iid=uid, values=(uid, self.name(r)[:60], r["tree_th"]) + tuple("●" if fn(r) else "" for _k, _l, fn in self.FLAGS))
            n += 1
        self.count.configure(text=f"{n} / {len(self.data)} สกิล")
        set_text(self.txt, "" if self.data else "overview.json ไม่พบ: รัน scripts/build_overview.py")

    def show(self):
        sel = self.tv.selection()
        if sel: set_text(self.txt, clean_md(self.data[sel[0]]["text"]))

    def show_engine(self):
        p = os.path.join(self.dir, "overview_th", "ENGINE.md")
        if os.path.exists(p):
            with open(p, encoding="utf-8") as f: set_text(self.txt, clean_md(f.read()))

    def jump(self):
        sel = self.tv.selection()
        if sel and self.goto: self.goto(int(sel[0]))


# --------------------------------------------------------------------------------------------- main
def main():
    root = tk.Tk()
    root.title(f"Toram data viewer - {ROOT}")
    root.geometry("1500x850")
    style = ttk.Style()
    style.configure("Treeview", font=UI_FONT, rowheight=22)
    style.configure("Treeview.Heading", font=(UI_FONT[0], 10, "bold"))
    nb = ttk.Notebook(root)
    nb.pack(fill="both", expand=True)
    skills = SkillsTab(nb, ROOT)
    files = FilesTab(nb, ROOT)
    names = {r["uid"]: re.sub(r"\[N2?\]|\[[A-Z]\]", " / ", r.get("name_th") or r.get("class") or "").strip(" /") for r in skills.recs}
    gvars = VarPanel(nb, skills.vs, names)
    gvars.refresh()
    skills.on_goto = lambda vid: (nb.select(gvars), gvars.select(vid))
    stats = StatsTab(nb, ROOT)
    overview = OverviewTab(nb, ROOT, goto=lambda uid: (nb.select(skills), skills.tv.selection_set(str(uid)), skills.tv.see(str(uid))))
    nb.add(skills, text="Skills")
    nb.add(overview, text="คำอธิบายโดยรวม")
    nb.add(gvars, text="Skill variables")
    nb.add(stats, text="Stats")
    nb.add(files, text="Files")
    if "--selftest" in sys.argv:
        root.withdraw()
        assert skills.recs, "skill_reference.json not found"
        for uid in (33, 46, 642, 36, 237):
            skills.tv.selection_set(str(uid)); skills.show(); root.update()
            assert "How it works" in skills.t_details.get("1.0", "end"), f"no detail entry for {uid}"
        skills.det.load()
        print("detail entries:", len(skills.det.blocks), "of", len(skills.recs))
        pp = skills.pro
        skills.tv.selection_set("33"); skills.show()
        pp.mq.set("colon"); pp.fill_monsters()
        assert pp.mt.get_children(), "no monsters loaded"
        pp.mt.selection_set(pp.mt.get_children()[0])
        pp.v_casts.set(2); pp.v_hits.set(3)
        pp.add(None); pp.add(0)
        root.update()
        print("proration rows:", len(pp.rt.get_children()), pp.rt.item(pp.rt.get_children()[0])["values"])
        print("full code chars:", len(skills.t_code.get("1.0", "end")))
        vs = skills.vs
        assert vs.vars, "variables.json not found (run build_variables.py + build_glossary.py)"
        dangling = sorted({i for d in vs.skill.values() for i in d["vars"] + d["hooks"] if i not in vs.vars})
        assert not dangling, f"ids without glossary entry: {dangling[:10]}"
        skills.tv.selection_set("1063"); skills.show(); root.update()
        assert skills.varp.tv.get_children(), "no variables listed for skill 1063"
        gvars.select("PlayerAttackBase.CalcLastDamageRate"); root.update()
        assert "when" in gvars.txt.get("1.0", "end"), "no definition shown"
        sp_txt = skills.t_spec.get("1.0", "end")
        assert "DAMAGE TERMS" in sp_txt, "no calc spec shown for skill 1063"
        print("variables:", len(vs.vars), "glossary entries;", sum(len(d["vars"]) + len(d["hooks"]) for d in vs.skill.values()), "skill-variable links; 0 dangling")
        skills.q.set("heal"); skills.refresh()
        p = os.path.join(ROOT, "skills", "damage", "skill_levels.csv")
        if not files.tree.exists(p): files.tree.insert("", "end", iid=p, text="skill_levels.csv")
        files.tree.focus(p)
        files.on_select(None)
        root.update()
        if stats.idx:
            stats.tv.selection_set("PlayerSecondaryStatus$$get_Atk"); stats.show(); root.update()
            assert "CalcAtk" in stats.txt.get("1.0", "end"), "no decoded body in Stats tab"
            trunc = [n for n, v in stats.idx.items() if v["status"] != "ok"]
            print("stats not fully decoded:", len(trunc), trunc[:8])
            print("stats functions:", len(stats.idx))
        if overview.data:
            overview.tv.selection_set("44"); overview.show(); root.update()
            t = overview.txt.get("1.0", "end")
            assert "ดาบสองมือ" in t and "คงกระพัน" in t, "overview of MeteorBreaker incomplete"
            overview.fv["W"].set(True); overview.refresh()
            assert "44" in overview.tv.get_children(), "weapon filter lost MeteorBreaker"
            overview.fv["W"].set(False); overview.refresh()
            print("overview entries:", len(overview.data), overview.meta)
        print("selftest ok:", len(skills.recs), "skills;", len(files.rows), "csv rows;", skills.count.cget("text"))
        root.destroy()
        return
    root.mainloop()


if __name__ == "__main__":
    main()
