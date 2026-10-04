"""Check the machine form of the damage rows (overview.json alts[].calc, missing-data/08):
  1. every `e` / `w` string parses with the website's own grammar (vercel/src/skillExpr.js `parse`, run through node) - only when node and the file are present
  2. every alternative whose table `values` exist evaluates with the reference evaluator (calc_engine) to the same numbers for Lv 1..10, with the weapon condition satisfied
     (percent rows: `values` are percent, `e` is the percent form) and every other input 0
  3. every input an expression mentions is declared in `inputs`
Writes skills/damage/overview/damage_calc_residual.csv (alternatives without a machine form and why) and prints a coverage table; exits 1 on any failure.
Run (cwd D:\\toram_re):  python "D:\\toram reverse data\\scripts\\validate_damage_calc.py"
"""
import sys, os, re, json, csv, subprocess, tempfile, collections

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
sys.path.append(r"D:\toram_re")          # after the scripts dir: D:\toram_re holds stale copies of dis_android / symexec / ...
import calc_engine as CE

OV = r"D:\toram reverse data\skills\damage\overview\overview.json"
RESIDUAL = r"D:\toram reverse data\skills\damage\overview\damage_calc_residual.csv"
JS = r"D:\dev\toram-guild-tool\toram-tools-MAIN\vercel\src\skillExpr.js"
KEYWORDS = {"Lv", "lv", "int", "min", "max", "abs", "lt", "gt", "le", "ge", "eq", "ne", "lo", "hs", "hi", "ls", "mi", "pl"}
NAME = re.compile(r"(?<![\w.])[A-Za-z_]\w*")


def alts_of(sk):
    d = sk.get("damage")
    if not d:
        return
    for h in d["hits"]:
        for r in h["rows"]:
            for g in r["groups"]:
                for a in g["alts"]:
                    yield r["step"], a
    for x in d["ailments"]:
        for a in x["alts"]:
            yield "Percent", a


def js_parse_failures(exprs):
    if not (os.path.exists(JS) and subprocess.run(["node", "-v"], capture_output=True).returncode == 0):
        return None
    fd, tmp = tempfile.mkstemp(suffix=".json")
    with os.fdopen(fd, "w", encoding="utf-8") as fh:
        json.dump(sorted(set(exprs)), fh)
    url = "file:///" + JS.replace(chr(92), "/")
    script = (f"import {{parse}} from {json.dumps(url)}; import fs from 'node:fs'; const bad=[]; "
              f"for (const e of JSON.parse(fs.readFileSync({json.dumps(tmp)},'utf8'))) {{ try {{ parse(e) }} catch (x) {{ bad.push([e.slice(0,80), String(x.message).slice(0,60)]) }} }} console.log(JSON.stringify(bad))")
    r = subprocess.run(["node", "--input-type=module", "-e", script], capture_output=True, text=True)
    os.remove(tmp)
    return json.loads(r.stdout or "[]") if r.returncode == 0 else [["node failed", r.stderr[:200]]]


def main():
    ov = json.load(open(OV, encoding="utf-8"))["skills"]
    cnt, fails, exprs, residual = collections.Counter(), [], [], []
    rows_all, rows_null, rows_null_calc = set(), set(), set()          # distinct (skill, step, formula): the unit the website lists (build-skills-db.mjs damageOf)
    for uid, sk in ov.items():
        for step, a in alts_of(sk):
            cnt["alts"] += 1
            c = a.get("calc")
            key = (uid, step, a["formula"])
            rows_all.add(key)
            if a["values"] is None:
                rows_null.add(key)
                if c is not None:
                    rows_null_calc.add(key)
            if c is None:
                cnt["no_calc"] += 1
                cnt["no_calc_values_null"] += a["values"] is None
                residual.append((uid, step, a["formula"], ";".join(a.get("calc_why") or [])))
                continue
            cnt["with_calc"] += 1
            cnt["partial"] += bool(c.get("partial"))
            alt = c["alts"][0]
            cnt["with_wt"] += bool(alt.get("wt"))
            exprs += [alt["e"], *alt["w"]]
            used = {n for t in [alt["e"], *alt["w"]] for n in NAME.findall(t) if n not in KEYWORDS}
            if used - set(c["inputs"]):
                fails.append((uid, "undeclared", sorted(used - set(c["inputs"]))))
            if a["values"] is not None and (not alt["w"] or set(c["inputs"]) <= {"WeaponType", "SubWeaponType"}):
                cnt["numeric_checked"] += 1
                for lv in range(1, 11):
                    env = {n: 0 for n in c["inputs"]}
                    env.update({"Lv": lv, "lv": lv, "max": max, "min": min, "abs": abs})
                    try:
                        v = CE.Evaluator(env).eval(alt["e"])
                    except Exception as e:
                        fails.append((uid, "eval", str(e)[:80]))
                        break
                    want = float(a["values"][lv - 1])
                    if abs(v - want) > 0.011 * max(1, abs(want)) and not alt["w"]:
                        fails.append((uid, "value", lv, v, want, alt["e"][:80]))
                        break
    bad = js_parse_failures(exprs)
    if bad is not None:
        cnt["js_checked"], cnt["js_parse_failures"] = len(set(exprs)), len(bad)
        fails += [("js", *b) for b in bad[:10]]
    cnt["rows_distinct"], cnt["rows_values_null"], cnt["rows_values_null_with_calc"] = len(rows_all), len(rows_null), len(rows_null_calc)
    cnt["skills_values_null"] = len({k[0] for k in rows_null})
    cnt["skills_values_null_without_calc"] = len({k[0] for k in rows_null - rows_null_calc})
    with open(RESIDUAL, "w", encoding="utf-8-sig", newline="") as fh:
        w = csv.writer(fh)
        w.writerow(["uid", "step", "formula", "unsupported_names"])
        w.writerows(residual)
    print(dict(cnt))
    for f in fails[:25]:
        print("FAIL", f)
    sys.exit(1 if fails else 0)


if __name__ == "__main__":
    main()
