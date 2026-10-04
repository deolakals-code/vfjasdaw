"""Decode the constant per-action flags (IsInterruptable, IsHitRigidity, IsMoveAssistContinue, IsPutUpWeapon, IsUnsheatheWeapon) of every
skill action class with the executor -> skills/damage/overview/action_flags.json  {class: {flag: value | "field:<name>" | "?"}}.
Classes without an override inherit the base class value (reported as "inherit"). usage (cwd D:\\toram_re): python harvest_action_flags.py"""
import sys, os, re, json, csv
import symexec as S
import build_variables as B

OUT = r"D:\toram reverse data\skills\damage\overview\action_flags.json"
COV = r"D:\toram reverse data\skills\damage\coverage.csv"
FLAGS = ("IsInterruptable", "IsHitRigidity", "IsMoveAssistContinue", "IsPutUpWeapon", "IsUnsheatheWeapon")
byname = {n: a for a, n in S.names.items()}


def val(rec):
    cs = rec.get("cases") or []
    if len(cs) != 1: return "?"
    v = str(cs[0]["value"]).strip()
    if v in ("0", "1"): return int(v)
    return "field:" + v if re.match(r"^\w+$", v) else "?"


def main():
    classes = [r["class"] for r in csv.DictReader(open(COV, encoding="utf-8-sig")) if r["class"]]
    out = {}
    for c in sorted(set(classes)):
        d = {}
        for f in FLAGS:
            a = byname.get(f"{c}$$get_{f}")
            if a is None: d[f] = "inherit"; continue
            try: d[f] = val(B.decode(a))
            except Exception as e: d[f] = "?"
        out[c] = d
    os.makedirs(os.path.dirname(OUT), exist_ok=True)
    json.dump(out, open(OUT, "w", encoding="utf-8"), ensure_ascii=False, indent=0)
    n = sum(1 for d in out.values() for v in d.values() if v == "inherit")
    print(len(out), "classes;", n, "inherited flag slots")


if __name__ == "__main__":
    main()
