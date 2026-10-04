"""Compare Ghidra pseudo-C (ghidra_out/<set>/<fn>.c) with our decoded stats (stats/decoded): numeric constants and callee names.
usage: python crosscheck_stats.py <set>   (set = core | all)  -> skills/damage/stats/CROSSCHECK.md (core) or CROSSCHECK_all.md"""
import re, os, sys, json, struct, glob

SET = sys.argv[1] if len(sys.argv) > 1 else "core"
GH = os.path.join(r"D:\toram_re\ghidra_out", SET)
DEC = r"D:\toram reverse data\skills\damage\stats\decoded"
OUT = os.path.join(r"D:\toram reverse data\skills\damage\stats", "CROSSCHECK.md" if SET == "core" else f"CROSSCHECK_{SET}.md")
idx = json.load(open(os.path.join(DEC, "index.json"), encoding="utf-8"))
NUM = re.compile(r"(?<![\w.$])(-?(?:0x[0-9a-fA-F]+|\d+\.\d+(?:e-?\d+)?|\d+))(?:[fFuUlL]{0,3})(?![\w.])")
CALL = re.compile(r"([A-Za-z_][\w$.<>]*)\s*\(")
SKIP_CALLS = {"if", "while", "for", "switch", "return", "sizeof", "int", "float", "double", "long", "char", "byte", "short", "uint", "ulong", "bool",
              "FUN_", "thunk_FUN_", "FUN", "il2cpp_codegen", "isinst", "castclass"}
TRIVIAL = {0.0, 1.0, 2.0, 4.0, 8.0, 16.0, 24.0, 32.0, 31.0, 63.0, 64.0}


def f32(bits):
    return struct.unpack("<f", struct.pack("<I", bits & 0xffffffff))[0]


def strip_ghidra(t):
    t = re.sub(r"/\*.*?\*/", " ", t, flags=re.S)                         # try/catch markers
    t = re.sub(r"\*\(\w[\w ]*\*\)\([^;]*?\+ 0x[0-9a-fA-F]+\)", " FIELD ", t)   # *(T *)(p + 0xNN): struct field reads
    t = re.sub(r"\(\*\*\(code \*\*\)\(\*[^;]*?\+ 0x[0-9a-fA-F]+\)\)", " VCALL", t)  # vtable dispatch
    t = re.sub(r"-0x80000000|0x80000000|INFINITY", " ", t)                   # float->int saturation idiom
    return t


ARITH = re.compile(r"(?:[*/+\-]|<<|>>|%)\s*\(?(-?\d+\.\d+|-?\d+|-?0x[0-9a-fA-F]+)(?:[fFuUlL]{0,3})")
CMP = re.compile(r"(?:<|>|<=|>=|==|!=)\s*(-?\d+\.\d+|-?\d+)")


def consts(text):
    """numeric constants used as arithmetic / comparison operands (not call arguments, offsets or ids); x and 1/x are treated as equal"""
    out = set()
    for rx in (ARITH, CMP):
        for m in rx.finditer(text):
            s = m.group(1)
            try:
                v = float(int(s, 16)) if s.lower().lstrip("-").startswith("0x") else float(s)
            except ValueError:
                continue
            if abs(v) > 1e9 or v in (0.0, 1.0, -1.0): continue
            if isinstance(v, float) and v == int(v) and abs(v) in (2.0, 4.0, 8.0, 16.0, 24.0, 31.0, 32.0, 63.0, 64.0) and False: continue
            out.add(round(v, 5))
            if abs(v) >= 1: out.add(round(1.0 / v, 5))
    return out


def callnames(text):
    out = set()
    for m in CALL.finditer(text):
        n = m.group(1)
        parts = [x for x in re.split(r"[.$]+|__", n) if x]
        short = parts[-1] if parts else ""
        if short in ("constant", "rate", "flag", "buff", "buf") or re.fullmatch(r"out\d*", short): short = parts[-2] if len(parts) > 1 else short
        if not short or short in SKIP_CALLS or n.startswith(("FUN_", "thunk_FUN", "_t", "il2cpp")) or short.startswith("FUN_"): continue
        out.add(short)
    return out


def ours(r):
    parts = []
    for c in r.get("cases", []):
        parts += [c["value"]] + c.get("common", []) + [x for v in c.get("variants", []) for x in v]
    parts += list(r.get("lets", {}).values())
    for ev in r.get("events", []): parts += [str(ev["value"])] + ev.get("when", [])
    return "\n".join(parts)


rows, n_ok = [], 0
for p in sorted(glob.glob(os.path.join(GH, "*.c"))):
    name = os.path.basename(p)[:-2]
    key = name if name in idx else next((k for k in idx if re.sub(r"[^\w$.<>]", "_", k)[:200] == name), None)
    if key is None: rows.append((name, None, None, None)); continue
    g = strip_ghidra(open(p, encoding="utf-8", errors="replace").read())
    r = json.load(open(os.path.join(DEC, idx[key]["file"]), encoding="utf-8"))
    o = ours(r)
    cg, co = consts(g), consts(o)
    ng, no = callnames(g), callnames(o)
    # ghidra shows only the method name for resolved calls; ours also shows it. Compare as sets of short names.
    own = key.split("$$")[-1]
    d = {"const_only_ghidra": sorted(cg - co)[:20], "const_only_ours": sorted(co - cg)[:20],
         "call_only_ghidra": sorted(x for x in ng - no if x not in (own, "catch", "VCALL", "FIELD"))[:25]}
    bad = any(d.values())
    n_ok += not bad
    rows.append((key, d, g, o))

md = [f"# Cross-check: Ghidra pseudo-C vs decoded formulas ({SET})", "",
      "Per function: numeric constants and callee names present on one side only. A difference is not automatically a bug "
      "(Ghidra inlines / renames, we fold `//`, `int()`); every entry needs a look at the disassembly.", "",
      f"Functions compared: {sum(1 for r in rows if r[1] is not None)}; identical constant+callee sets: {n_ok}.", ""]
for key, d, g, o in rows:
    if d is None: md += [f"## {key}", "no decoded record found", ""]; continue
    if not any(d.values()): md += [f"- OK `{key}`"]; continue
    md += ["", f"## {key}"] + [f"- {k}: {v}" for k, v in d.items() if v]
open(OUT, "w", encoding="utf-8").write("\n".join(md))
print(OUT, "compared", sum(1 for r in rows if r[1] is not None), "identical", n_ok)
