"""usage: python showfn.py <Class$$fn> [maxlen]  -- dedupe harvested paths by return expr, print conditions."""
import sys, json, glob, os, collections
R = r"D:\toram reverse data\skills\damage\stats\raw"
q = sys.argv[1]; mx = int(sys.argv[2]) if len(sys.argv) > 2 else 700
for p in glob.glob(os.path.join(R, "*", q.replace("$", "$") + ".json")) or glob.glob(os.path.join(R, "*", "*" + q + "*.json")):
    r = json.load(open(p, encoding="utf-8"))
    print("=====", r["name"], r["rva"], "paths", len(r["paths"]), "TRUNC" if r.get("truncated") else "", r.get("error", ""))
    g = collections.OrderedDict()
    for pa in r["paths"]:
        k = json.dumps(pa["ret"]); g.setdefault(k, []).append(pa["cond"])
    for k, cs in g.items():
        print("  ret", k[:mx])
        seen = set()
        for c in cs[:3]:
            t = " && ".join(x[:150] for x in c)
            if t not in seen: seen.add(t); print("     when", t[:mx])
        if len(cs) > 3: print("     ...", len(cs), "paths")
