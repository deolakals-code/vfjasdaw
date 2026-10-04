"""Stage 3: dump.cs.gz -> readable/code/{cs/<assembly>/<namespace>/<Type>.cs, enums.json, enums.txt, classes.json, methods.tsv}.
Structure only (declarations, layouts, RVAs). Method bodies are native ARM64 in libil2cpp.so and are not decompiled."""
import bisect, gzip, json, os, re, shutil
from common import ROOT
OUT = os.path.join(ROOT, "readable", "code")
CS = OUT + r"\cs"
shutil.rmtree(CS, ignore_errors=True)
HEAD = re.compile(r"\b(class|struct|enum|interface) (.*?)(?: : (.*))? // TypeDefIndex: (\d+)\s*$")
FIELD = re.compile(r"^\t(.*?); // 0x([0-9A-Fa-f]+)\s*$")
CONST = re.compile(r"^\t(?:public |private |protected |internal )?const (.*?) (\S+) = (.*?);\s*$")
RVA = re.compile(r"^\t// RVA: 0x([0-9A-Fa-f]+) Offset: 0x[0-9A-Fa-f]+ VA: 0x[0-9A-Fa-f]+(?: Slot: (\d+))?")
MODS = {"public", "private", "protected", "internal", "static", "readonly", "const", "volatile", "new", "unsafe"}
lines = gzip.open(os.path.join(ROOT, "code", "dump.cs.gz"), "rt", encoding="utf-8", errors="replace").read().split("\n")
images = [(int(m.group(3)), m.group(2)) for m in (re.match(r"// Image (\d+): (.+) - (\d+)$", l) for l in lines[:200]) if m]
starts = [s for s, _ in images]
classes, enums, used = {}, {}, set()
meth = open(OUT + r"\methods.tsv", "w", encoding="utf-8")
meth.write("type_def_index\tclass\trva\tslot\tsignature\n")


def field(text):
    left, _, val = text.partition(" = ")
    parts = left.split(" ")
    name = parts[-1]
    i = 0
    while i < len(parts) - 1 and parts[i] in MODS:
        i += 1
    return " ".join(parts[i:-1]), name, val or None


def block(ns, blk):
    hi = next((i for i, l in enumerate(blk) if "// TypeDefIndex:" in l), None)
    if hi is None:
        return
    m = HEAD.search(blk[hi])
    if not m:
        return
    kind, name, base, idx = m.group(1), m.group(2).strip(), (m.group(3) or "").strip(), int(m.group(4))
    asm = images[max(bisect.bisect_right(starts, idx) - 1, 0)][1]
    rec = {"ns": ns, "name": name, "kind": kind, "base": base, "index": idx, "asm": asm, "fields": []}
    pend = None
    for l in blk[hi + 1:]:
        r = RVA.match(l)
        if r:
            pend = (r.group(1), r.group(2) or ""); continue
        if pend and l.startswith("\t") and not l.startswith(("\t//", "\t|", "\t/*", "\t*/")):
            meth.write(f"{idx}\t{name}\t{pend[0]}\t{pend[1]}\t{l.strip()}\n"); pend = None; continue
        if l.startswith("\t// RVA: -1"):
            pend = None; continue
        c = CONST.match(l)
        if c and not FIELD.match(l):
            rec["fields"].append([c.group(2), c.group(3)] if kind == "enum" else [c.group(1), c.group(2), c.group(3), None]); continue
        f = FIELD.match(l)
        if f and "(" not in f.group(1).split(" = ")[0]:
            t, n, v = field(f.group(1))
            if kind == "enum":
                continue
            rec["fields"].append([t, n, v, int(f.group(2), 16)])
    (enums if kind == "enum" else classes)[idx] = rec
    d = os.path.join(CS, re.sub(r"[<>:\"|?*]", "_", asm.replace(".dll", "")), *(re.sub(r"[<>:\"|?*]", "_", p) for p in (ns.split(".") if ns else ["_global"])))
    os.makedirs(d, exist_ok=True)
    fn = re.sub(r"[<>:\"/\|?*, ]", "_", name)[:90]
    if (d, fn) in used:
        fn += f"_{idx}"
    used.add((d, fn))
    with open(os.path.join(d, fn + ".cs"), "w", encoding="utf-8") as o:
        o.write(f"// Assembly: {asm}\n// Namespace: {ns}\n" + "\n".join(blk) + "\n")


ns, blk = "", None
for l in lines:
    if l.startswith("// Namespace: "):
        ns, blk = l[14:].strip(), []
        continue
    if blk is None:
        continue
    if l in ("}", "{}"):
        blk.append(l); block(ns, blk); blk = None
        continue
    if l.endswith("{}") and "// TypeDefIndex:" in "".join(blk[-1:]):
        pass
    blk.append(l)
meth.close()
json.dump(classes, open(OUT + r"\classes.json", "w", encoding="utf-8"), ensure_ascii=False, separators=(",", ":"))
json.dump(enums, open(OUT + r"\enums.json", "w", encoding="utf-8"), ensure_ascii=False, separators=(",", ":"))
with open(OUT + r"\enums.txt", "w", encoding="utf-8") as t:
    for v in sorted(enums.values(), key=lambda v: (v["ns"], v["name"])):
        t.write(f"{v['ns']}.{v['name']} : {v['base']}  // {v['asm']} TypeDefIndex {v['index']}\n")
        for n, val in v["fields"]:
            t.write(f"    {n} = {val}\n")
print(len(classes), "classes/structs,", len(enums), "enums,", sum(len(v["fields"]) for v in classes.values()), "fields,", len(used), ".cs files")
