"""Knowledge base: verified schemas (one JSON per table, kept in the repo so the program keeps what it learned) and
per-strategy statistics that decide which strategy is tried first next time."""
import json
import os
import time

KB = os.path.join(os.path.dirname(os.path.abspath(__file__)), "kb")
SCHEMAS = os.path.join(KB, "schemas")
STATS = os.path.join(KB, "stats.json")


def load(table):
    p = os.path.join(SCHEMAS, table + ".json")
    return json.load(open(p, encoding="utf-8")) if os.path.exists(p) else None


def save(table, entry):
    os.makedirs(SCHEMAS, exist_ok=True)
    entry = {**entry, "table": table, "learned": entry.get("learned") or time.strftime("%Y-%m-%d")}
    json.dump(entry, open(os.path.join(SCHEMAS, table + ".json"), "w", encoding="utf-8"), indent=1, ensure_ascii=False)


def all_tables():
    return sorted(f[:-5] for f in os.listdir(SCHEMAS) if f.endswith(".json")) if os.path.isdir(SCHEMAS) else []


def stats():
    return json.load(open(STATS)) if os.path.exists(STATS) else {}


def record(strategy, ok):
    s = stats()
    e = s.setdefault(strategy, {"tried": 0, "solved": 0})
    e["tried"] += 1
    e["solved"] += int(bool(ok))
    os.makedirs(KB, exist_ok=True)
    json.dump(s, open(STATS, "w"), indent=1, sort_keys=True)
