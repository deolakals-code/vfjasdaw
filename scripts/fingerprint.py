"""Build-independent fingerprints of decoded units, so a game update re-decodes only what changed.

A unit = a class (plus its nested lambda/iterator classes, its base-class chain and the *Buf classes its code constructs).
Its fingerprint hashes every method body after removing everything that moves between builds:
  bl/b to a function      -> the callee's NAME (script.json) or the il2cpp stub role (il2.stubs)
  other branches          -> offset relative to the function start
  adrp + add/ldr page ops -> the metadata symbol / string the slot resolves to, else the constant `DATA`
Field offsets, enum immediates and all arithmetic stay in the hash, so a layout or value change is detected.

usage: python fingerprint.py build            -> state/fp_current.json  {kind:key -> sha1}   (kinds: skill, mastery, buffer, gemcart, stats)
       python fingerprint.py diff A.json B.json   -> changed / added / removed unit keys
"""
import os, re, sys, json, bisect, hashlib, collections
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import il2
from dis_android import b, names, starts, md, OFF, meta, metam, RELA

STUBS = {v: k for k, v in il2.stubs().items()}
_CLS = collections.defaultdict(list)           # class (text before `$$`) -> [rva]
for a, n in names.items():
    if "$$" in n: _CLS[n.split("$$")[0]].append(a)
_BASE = None
_cache = {}


def bases():
    """{class: base class} from dump.cs"""
    global _BASE
    if _BASE is None:
        _BASE = {}
        cre = re.compile(r"^(?:public |internal |private |protected )?(?:abstract |sealed |static )*class\s+([^\s:<]+)(?:<[^>]*>)?\s*:\s*([^\s,{/<]+)")
        for l in open(os.path.join(il2.DUMP, "dump.cs"), encoding="utf-8", errors="replace"):
            if l and not l.startswith((" ", "\t")):
                m = cre.match(l)
                if m: _BASE[m.group(1)] = m.group(2)
    return _BASE


def norm_fn(rva):
    """normalised instruction text of the function starting at rva"""
    end = il2.fn_end(rva)
    out, pages = [], {}
    for i in md.disasm(b[rva - OFF:end - OFF], rva):
        m, o = i.mnemonic, i.op_str
        if m in ("bl", "b") and o.startswith("#"):
            t = int(o[1:], 16)
            tgt = names.get(t) or ("stub:" + STUBS[t] if t in STUBS else None)
            if tgt is None: tgt = f"rel{t - rva}" if rva <= t < end else "ext"
            out.append(f"{m} {tgt}"); continue
        if m.startswith("b.") or m in ("cbz", "cbnz", "tbz", "tbnz", "adr"):
            parts = o.split(", "); t = int(parts[-1][1:], 16)
            out.append(f"{m} {', '.join(parts[:-1])} rel{t - rva}"); continue
        if m == "adrp":
            r, imm = o.split(", "); pages[r] = int(imm[1:], 16); out.append(f"adrp {r}"); continue
        mm = re.match(r"(\w+), \[(\w+), #(0x[0-9a-f]+)\]$", o)
        if mm and m.startswith("ldr") and mm.group(2) in pages:
            a = pages[mm.group(2)] + int(mm.group(3), 16); t = RELA.get(a, a)
            out.append(f"{m} {mm.group(1)} <{meta.get(a) or metam.get(a) or meta.get(t) or metam.get(t) or 'DATA'}>"); continue
        mm = re.match(r"(\w+), (\w+), #(0x[0-9a-f]+)$", o)
        if mm and m == "add" and mm.group(2) in pages:
            a = pages[mm.group(2)] + int(mm.group(3), 16); out.append(f"add {mm.group(1)} <{meta.get(a, metam.get(a, 'DATA'))}>"); continue
        out.append(f"{m} {o}")
    return "\n".join(out)


def class_hash(cls):
    """hash of every method of `cls` and of its nested classes (`cls.<...>` / `cls.__DisplayClass...`)"""
    if cls not in _cache:
        rvas = sorted(a for c, v in _CLS.items() if c == cls or c.startswith(cls + ".") for a in v)
        h = hashlib.sha1()
        for a in rvas:
            h.update(names[a].encode()); h.update(norm_fn(a).encode())
        _cache[cls] = h.hexdigest()
    return _cache[cls]


def chain(cls):
    seen = []
    while cls and cls not in seen and cls in _CLS:
        seen.append(cls); cls = bases().get(cls)
    return seen


def constructed(cls, known):
    """classes in `known` whose .ctor is called from the methods of cls (the *Buf classes a skill creates)"""
    out = set()
    for c, v in _CLS.items():
        if not (c == cls or c.startswith(cls + ".")): continue
        for a in v:
            for i in md.disasm(b[a - OFF:il2.fn_end(a) - OFF], a):
                if i.mnemonic == "bl" and i.op_str.startswith("#"):
                    n = names.get(int(i.op_str[1:], 16), "")
                    if n.endswith("$$.ctor") and n[:-7] in known and n[:-7] != cls: out.add(n[:-7])
    return sorted(out)


def unit_hash(cls, known_bufs):
    parts = [class_hash(c) for c in chain(cls)] + [class_hash(c) for c in constructed(cls, known_bufs)]
    return hashlib.sha1("|".join(parts).encode()).hexdigest()


def build():
    st = il2.STATE
    fac = json.load(open(os.path.join(st, "_factory_map.json")))
    mas = json.load(open(os.path.join(st, "_mastery_map.json")))
    buf = json.load(open(os.path.join(st, "_buffer_map.json")))
    gem = json.load(open(os.path.join(st, "_gemcart_byid.json")))
    bufs = set(buf.values())
    out = {}
    for sid, c in fac.items(): out[f"skill:{sid}:{c}"] = unit_hash(c, bufs)
    for sid, c in mas.items(): out[f"mastery:{sid}:{c}"] = unit_hash(c, bufs)
    for sid, c in buf.items(): out[f"buffer:{sid}:{c}"] = unit_hash(c, bufs)
    for gid, v in gem.items(): out[f"gemcart:{gid}:{v[0]}"] = unit_hash(v[0], set())
    # stats / engine layer: every function the CORE_FORMULAS / STATS pages were generated from
    fns = set()
    for p in ("CORE_FORMULAS.md", "STATS.md"):
        f = os.path.join(il2.DATA, "skills", "damage", p)
        if os.path.exists(f): fns |= set(re.findall(r"^### ([\w.<>`]+\.\w+)\(", open(f, encoding="utf-8").read(), re.M))
    by_name = collections.defaultdict(list)
    for a, n in names.items(): by_name[n.replace("$$", ".")].append(a)
    h = hashlib.sha1()
    miss = 0
    for fn_ in sorted(fns):
        rv = by_name.get(fn_)
        if not rv: miss += 1; continue
        for a in sorted(rv): h.update(norm_fn(a).encode())
    out["stats:all"] = h.hexdigest()
    out["_meta"] = {"so_sha256": il2.so_sha256(), "stats_functions": len(fns), "stats_unresolved": miss}
    return out


def diff(a, b_):
    ka, kb = {k: v for k, v in a.items() if not k.startswith("_")}, {k: v for k, v in b_.items() if not k.startswith("_")}
    return {"changed": sorted(k for k in ka.keys() & kb.keys() if ka[k] != kb[k]), "added": sorted(kb.keys() - ka.keys()), "removed": sorted(ka.keys() - kb.keys())}


if __name__ == "__main__":
    if sys.argv[1] == "build":
        r = build()
        p = os.path.join(il2.STATE, "fp_current.json")
        json.dump(r, open(p, "w"), indent=0)
        print(len(r) - 1, "units ->", p, r["_meta"])
    elif sys.argv[1] == "diff":
        d = diff(json.load(open(sys.argv[2])), json.load(open(sys.argv[3])))
        print({k: len(v) for k, v in d.items()})
