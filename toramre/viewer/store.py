"""Read-only data layer of the viewer: skills, items, monsters, recipes, registlets, quests with names in 6 languages,
cross links and a search index. No UI here. Everything is loaded lazily from the files the exporters already wrote."""
import csv
import json
import os
import re

from toramre.core import paths

csv.field_size_limit(1 << 24)
LANGS = ("th", "us", "jp", "kr", "cnt", "idn")
TYPES = ("skill", "item", "monster", "recipe", "registlet", "quest")
FALLBACK = ("us", "th", "jp")


def _csv(path):
    if not os.path.exists(path):
        return []
    with open(path, encoding="utf-8-sig", newline="") as f:
        return list(csv.DictReader(f))


def _tsv(path):
    """{(id, kind): text} of a localized text table written by tools/s5 (columns id, kind, no, text)."""
    out = {}
    if not os.path.exists(path):
        return out
    with open(path, encoding="utf-8", newline="") as f:
        for r in csv.DictReader(f, delimiter="\t"):
            out[(r["id"], r["kind"])] = r["text"].replace("\\n", "\n").replace("\\t", "\t").replace("\\r", "\r")
    return out


_TAGS = re.compile(r"\[N2?\]|\[[A-Z]\]")
_NORM = re.compile(r"[\W_]+", re.UNICODE)


def clean_name(n):
    """Skill names carry rank markup: '[N]A[N2]B[N]' (th) or 'N$A$R2$B' (other languages) -> 'A / B'."""
    if "$" in n:
        parts = n.split("$")
        if len(parts) % 2 == 0 and all(re.fullmatch(r"[A-Z]\d?", parts[i]) for i in range(0, len(parts), 2)):
            n = " / ".join(dict.fromkeys(parts[i] for i in range(1, len(parts), 2) if parts[i]))
    n = _TAGS.sub(" / ", n)
    return re.sub(r"\s*/\s*(/\s*)*", " / ", n).strip(" /")


_COLOR = re.compile(r"\[[0-9a-fA-F]{6}\]|\[-\]")


def format_notes(raw):
    """Level notes are stored as '<level>$<flag>$<text>$<level>$<flag>$<text>...': -> 'Lv10: text' lines."""
    parts = raw.split("$")
    if len(parts) >= 3 and len(parts) % 3 == 0 and all(p.isdigit() for p in parts[0::3]):
        return "\n".join(f"Lv{parts[i]}: " + _COLOR.sub("", parts[i + 2]).strip().replace("\n\n", "\n") for i in range(0, len(parts), 3))
    return _COLOR.sub("", raw)


def norm(s):
    return _NORM.sub("", s.lower())


def _ids(s, sep=";"):
    return [x.strip() for x in (s or "").replace("|", sep).split(sep) if x.strip() and x.strip() != "0"]


class Store:
    def __init__(self, repo=None, readable=None):
        self.repo = repo or paths.REPO
        self.readable = readable or os.path.join(paths.BIGDATA, "readable")
        self._cache = {}

    # ---- loading -------------------------------------------------------------------------------------------
    def _once(self, key, fn):
        if key not in self._cache:
            self._cache[key] = fn()
        return self._cache[key]

    def text(self, table, lang):
        """Localized text table, e.g. text('Skill', 'th') -> {(id, kind): text}."""
        return self._once(("text", table, lang), lambda: _tsv(os.path.join(self.readable, "text", f"GameScene_{lang}", f"{table}_{lang}.tsv")))

    @property
    def skills(self):
        def load():
            full = {r["uid"]: r for r in _csv(os.path.join(self.repo, "skills", "skills_full.csv"))}
            levels = {r["uid"]: r for r in _csv(os.path.join(self.repo, "skills", "damage", "skill_levels.csv"))}
            for uid, r in full.items():
                r["levels"] = levels.get(uid)
            return full
        return self._once("skills", load)

    @property
    def items(self):
        return self._once("items", lambda: {r["id"]: r for r in _csv(os.path.join(self.readable, "items", "items.csv"))})

    @property
    def recipes(self):
        return self._once("recipes", lambda: {r["recipe_id"]: r for r in _csv(os.path.join(self.readable, "items", "item_recipes.csv"))})

    @property
    def drops(self):
        """{item id: [rows]} and {mob uuid: [rows]} from item_drop_sources.csv."""
        def load():
            by_item, by_mob = {}, {}
            for r in _csv(os.path.join(self.readable, "items", "item_drop_sources.csv")):
                by_item.setdefault(r["item"], []).append(r)
                if r.get("mob_uuid") not in (None, "", "0"):
                    by_mob.setdefault(r["mob_uuid"], []).append(r)
            return by_item, by_mob
        return self._once("drops", load)

    @property
    def monsters(self):
        return self._once("monsters", lambda: {r["uuid"]: r for r in _csv(os.path.join(self.readable, "monsters", "monster_index.csv"))})

    @property
    def monster_stats(self):
        """Full monster rows (proration steps etc.), first row per uuid, loaded only for the calculator."""
        def load():
            out = {}
            for r in _csv(os.path.join(self.readable, "monsters", "monster_full.csv")):
                out.setdefault(r["uuid"], r)
            return out
        return self._once("monster_stats", load)

    def monster_row(self, ident):
        return self.monster_stats.get(str(ident))

    @property
    def registlets(self):
        return self._once("registlets", lambda: {r["id"]: r for r in _csv(os.path.join(self.readable, "registlet", "registlet.csv")) if r["id"] != "0"})

    @property
    def quests(self):
        def load():
            p = os.path.join(self.readable, "quests", "quests.json")
            if not os.path.exists(p):
                return {}
            with open(p, encoding="utf-8") as f:
                return {f"{q['type']}:{q['id']}": q for q in json.load(f)}
        return self._once("quests", load)

    # ---- names ---------------------------------------------------------------------------------------------
    def name(self, typ, ident, lang="th"):
        ident = str(ident)
        order = (lang,) + tuple(l for l in FALLBACK if l != lang)
        for l in order:
            n = self._name(typ, ident, l)
            if n and n != "null":
                return n
        return ""

    def _name(self, typ, ident, lang):
        if typ == "skill":
            return clean_name(self.text("Skill", lang).get((ident, "0"), "") or (self.skills.get(ident, {}).get("name_th", "") if lang == "th" else ""))
        if typ == "item":
            r = self.items.get(ident)
            return (r or {}).get("name" if lang == "th" else f"name_{'en' if lang == 'us' else lang}", "")
        if typ == "monster":
            return self.text("Enemy", lang).get((ident, "0"), "") or ((self.monsters.get(ident) or {}).get("name_th", "") if lang == "th" else "")
        if typ == "registlet":
            return self.text("Registlet", lang).get((ident, "0"), "")
        if typ == "recipe":
            r = self.recipes.get(ident)
            return f"{r['type']} #{ident}: {r['create_name']}" if r else ""
        if typ == "quest":
            return (self.quests.get(ident) or {}).get("name", "")
        return ""

    def names(self, typ, ident):
        return {l: self.name(typ, ident, l) for l in LANGS}

    # ---- search --------------------------------------------------------------------------------------------
    def _all_ids(self, typ):
        return {"skill": self.skills, "item": self.items, "monster": self.monsters, "recipe": self.recipes,
                "registlet": self.registlets, "quest": self.quests}[typ].keys()

    def _index(self):
        def build():
            rows = []
            for typ in TYPES:
                for ident in self._all_ids(typ):
                    ns = [self._name(typ, ident, l) for l in LANGS]
                    if typ == "skill":
                        r = self.skills[ident]
                        ns += [clean_name(r.get("name_en", "")), clean_name(r.get("name_th_r2", ""))]
                    lines = [ident] + [n for n in dict.fromkeys(ns) if n and n != "null"]
                    hay = "\n".join(lines).lower() + "\n" + "\n".join(norm(x) for x in lines[1:])
                    rows.append((typ, ident, hay))
            return rows
        return self._once("index", build)

    def search(self, q, lang="th", types=None, limit=20):
        """-> {type: [{id, name, match}]}: exact id / exact name first, then name prefix, then substring."""
        q = (q or "").strip().lower()
        out = {}
        if not q:
            return out
        qn = norm(q)
        for typ, ident, hay in self._index():
            if types and typ not in types or (q not in hay and not (qn and qn in hay)):
                continue
            name = self.name(typ, ident, lang)
            lines = hay.split("\n")[1:]
            if ident.lower() == q or q in lines or qn in lines:
                rank = 0
            elif ident.lower().startswith(q) or any(x.startswith(q) or (qn and x.startswith(qn)) for x in lines):
                rank = 1
            else:
                rank = 2
            out.setdefault(typ, []).append((rank, ident, name))
        res = {}
        for typ, rows in out.items():
            rows.sort(key=lambda r: (r[0], len(r[2]), int(r[1]) if r[1].isdigit() else 0, r[1]))
            res[typ] = [{"id": i, "name": n, "match": ("id/name", "prefix", "contains")[r]} for r, i, n in rows[:limit]]
        return res

    # ---- entity pages with links ---------------------------------------------------------------------------
    def link(self, typ, ident, rel, lang):
        return {"type": typ, "id": str(ident), "name": self.name(typ, ident, lang), "rel": rel}

    def entity(self, typ, ident, lang="th"):
        ident = str(ident)
        if ident not in set(self._all_ids(typ)):
            return None
        links, fields = [], {}
        if typ == "skill":
            r = self.skills[ident]
            fields = {k: r.get(k, "") for k in ("name_en", "category", "tree", "tree_lv", "max_level", "premise_uid", "eq_limit", "flags", "assist")}
            fields["description"] = self.text("Skill", lang).get((ident, "1"), r.get("desc_th", "") if lang == "th" else "")
            fields["level_notes"] = format_notes(self.text("Skill", lang).get((ident, "2"), ""))
            if not fields["level_notes"] and lang == "th":
                fields["level_notes"] = r.get("notes", "")
            if r.get("levels"):
                fields["levels"] = {k: [x for x in (r["levels"].get(f"{k}_L{i}") for i in range(1, 11)) if x != "" and x is not None]
                                    for k in ("rate", "flat")}
            if r.get("premise_uid") not in (None, "", "0"):
                links.append(self.link("skill", r["premise_uid"], "needs", lang))
            for s in self.skills.values():
                if s.get("premise_uid") == ident:
                    links.append(self.link("skill", s["uid"], "unlocks", lang))
            for g in self.registlets.values():
                if ident in _ids(g.get("skills")):
                    links.append(self.link("registlet", g["id"], "boosted by", lang))
        elif typ == "item":
            r = self.items[ident]
            fields = {k: r.get(k, "") for k in ("type", "price", "stack", "base_atk_def", "stability", "range", "slot_max", "potential", "stats", "flags")}
            fields["description"] = r.get("description_en" if lang == "us" else "description", "")
            for rid in _ids(r.get("recipes_making")):
                if rid in self.recipes:
                    links.append(self.link("recipe", rid, "made by", lang))
            for rid in _ids(r.get("recipes_using")):
                if rid in self.recipes:
                    links.append(self.link("recipe", rid, "used in", lang))
            for d in self.drops[0].get(ident, []):
                if d.get("mob_uuid") not in (None, "", "0"):
                    links.append(self.link("monster", d["mob_uuid"], "dropped by", lang))
        elif typ == "recipe":
            r = self.recipes[ident]
            fields = {k: r.get(k, "") for k in ("type", "release_lv", "price", "difficulty", "create_num", "materials")}
            links.append(self.link("item", r["create_id"], "makes", lang))
            for m in re.findall(r"#(\d+)", r.get("materials", "")):
                links.append(self.link("item", m, "needs", lang))
        elif typ == "monster":
            r = self.monsters[ident]
            fields = {k: r.get(k, "") for k in ("lv", "boss", "maps", "high_raid_lv", "pet_capture")}
            seen = set()
            for d in self.drops[1].get(ident, []):
                if d["item"] not in seen:
                    seen.add(d["item"])
                    links.append(self.link("item", d["item"], "drops", lang))
        elif typ == "registlet":
            r = self.registlets[ident]
            fields = {k: r.get(k, "") for k in ("enum", "kind", "class", "level_cap", "enhance_powder", "base_value", "cooldown")}
            fields["description"] = r.get("desc_us" if lang == "us" else "desc_th", "")
            for s in _ids(r.get("skills")):
                if s in self.skills:
                    links.append(self.link("skill", s, "boosts", lang))
        elif typ == "quest":
            r = self.quests[ident]
            fields = {k: r.get(k, "") for k in ("type", "order_level", "start_map_name", "end_map_name")}
        return {"type": typ, "id": ident, "name": self.name(typ, ident, lang), "names": self.names(typ, ident),
                "fields": fields, "links": links}
