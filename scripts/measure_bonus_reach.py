"""Which stat lines move a Details row?  Adds `<bonus> +7` to an empty character (once with a 1H sword, once with a Rod) and reports every row that changes.

The 115 stat-line names are those carried by items (gear/gear.json `bonusById`); `--all` measures every BonusType name instead.
Output: player_status/bonus_reach.json = {bonus: {"rows": [...], "items": n}} and a list of names that move nothing.
Run (cwd D:\\toram_re):  python "D:\\toram reverse data\\scripts\\measure_bonus_reach.py" [--all] [--only name,name]
"""
import sys, json, collections

sys.path.insert(0, r"D:\toram reverse data\scripts")
sys.path.insert(0, r"D:\toram_re")
import player_status as P

OUT = r"D:\toram reverse data\player_status\bonus_reach.json"
GEAR = r"D:\toram reverse data\gear\gear.json"
BASES = {"1H": dict(weapon=P.item(10, 100, 50, 0)), "Rod": dict(weapon=P.item(14, 100, 0, 0))}


def values(**kw):
    res, _ = P.compute(P.Character(lv=100, str_=50, int_=50, vit=50, agi=50, dex=50, **kw))
    return [(r["type"], r["value"]) for r in res]


def reach(names, amounts=(7, 1000)):
    """rows moved by `<bonus> +7`; a line that moves nothing is retried at +1000 (the STR..DEX -> ATK lines are per-mille: 7 / 1000 * STR truncates to 0)"""
    base = {k: values(**b) for k, b in BASES.items()}
    out = {}
    for nm in names:
        moved = set()
        for amount in amounts:
            for k, b in BASES.items():
                for (t, v0), (_, v1) in zip(base[k], values(bonus={nm: amount}, **b)):
                    if v0 != v1: moved.add(t)
            if moved: break
        out[nm] = sorted(moved)
    return out


def main():
    gear = json.load(open(GEAR, encoding="utf-8"))
    carried = collections.Counter(b["b"] for it in gear["items"] for b in it.get("lines", it.get("bonuses", [])) if isinstance(b, dict) and "b" in b)
    if "--all" in sys.argv:
        names = sorted(n for n in P.BONUS_BY_ID.values() if n[:1] == "b" and n[1:2].isupper())
    else:
        names = sorted(b["k"] for b in gear["bonuses"])
    if "--only" in sys.argv:
        names = sys.argv[sys.argv.index("--only") + 1].split(",")
    got = reach(names)
    json.dump({n: {"rows": r, "items": carried.get(n, 0)} for n, r in got.items()}, open(OUT, "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    dead = [n for n, r in got.items() if not r]
    print(f"names {len(got)}  move a row {len(got) - len(dead)}  move nothing {len(dead)}")
    print("nothing:", " ".join(dead))


if __name__ == "__main__":
    main()
