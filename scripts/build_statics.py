"""Static array fields initialised in .cctor via RuntimeHelpers.InitializeArray(new T[n], <PrivateImplementationDetails> blob).
usage (cwd D:\\toram_re): python build_statics.py -> D:\\toram reverse data\\skills\\damage\\static_arrays.json
  {"Class.field": {"type": "SkillId", "n": 6, "values": [228, ...], "names": ["..."], "blob": "<hash>"}}
Field name = k-th static array field of the class (declaration order = offset order) when the counts agree, else matched by element type.
"""
import re, json, struct, csv, collections, os
import symexec as S
import dis2 as D2

OUT = r"D:\toram reverse data\skills\damage"
BLOB = {}
for r in csv.reader(open(r"D:\toram reverse data\metadata\constants.tsv", encoding="utf-8"), delimiter="\t"):
    if len(r) >= 4 and r[0] == "<PrivateImplementationDetails>" and r[3].startswith("hex:"): BLOB[r[1]] = bytes.fromhex(r[3][4:])
ESZ = {"int": 4, "uint": 4, "short": 2, "ushort": 2, "byte": 1, "sbyte": 1, "bool": 1, "float": 4, "long": 8, "ulong": 8, "double": 8}
FMT = {"int": "<i", "uint": "<I", "short": "<h", "ushort": "<H", "byte": "<B", "sbyte": "<b", "bool": "<B", "float": "<f", "long": "<q", "ulong": "<Q", "double": "<d"}


def elem(ty):
    t = ty.split(".")[-1] if ty not in D2.C else ty
    if ty in ESZ: return ty, ESZ[ty], FMT[ty]
    if D2.C.get(ty, {}).get("kind") == "enum": return ty, 4, "<i"
    return ty, 0, None


def main():
    res = {}
    for a, n in S.names.items():
        if not n.endswith("$$.cctor"): continue
        cls = n[:-len("$$.cctor")]
        try:
            ex = S.Ex(a, max_paths=30, max_ins=4000)
            paths = ex.run()
        except Exception:
            continue
        found = []
        for st in paths[:1]:
            for e in st.ev:
                if e[0] == "call" and "InitializeArray" in e[1]:
                    txt = " ".join(S.render(x) for x in e[2])
                    m1 = re.search(r"meta\(0x[0-9a-f]+, ([\w.<>`]+?)\[\]_TypeInfo\), (\d+)", txt)
                    m2 = re.search(r"Field\$<PrivateImplementationDetails>\.([0-9A-F]{64})", txt)
                    if m1 and m2: found.append((m1.group(1), int(m1.group(2)), m2.group(1)))
        if not found: continue
        sfields = [(o, t, nm) for o, (t, nm) in sorted(S.FS.get(cls, {}).items()) if t.endswith("[]")]
        for k, (ty, cnt, h) in enumerate(found):
            cand = [f for f in sfields if f[1][:-2].split("<")[0] == ty or f[1][:-2] == ty]
            if len(sfields) == len(found): fname = sfields[k][2]
            elif len(cand) == 1: fname = cand[0][2]
            else: fname = f"static_array_{k}"
            ety, sz, fm = elem(ty)
            blob = BLOB.get(h)
            vals = []
            if blob is not None and sz and len(blob) >= sz * cnt: vals = [struct.unpack_from(fm, blob, i * sz)[0] for i in range(cnt)]
            names = []
            if D2.C.get(ety, {}).get("kind") == "enum": names = [D2.C[ety]["consts"].get(v, str(v)) for v in vals]
            res[f"{cls}.{fname}"] = {"type": ety, "n": cnt, "values": vals, "names": names, "blob": h}
    json.dump(res, open(os.path.join(OUT, "static_arrays.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=0)
    print(len(res), "static arrays;", sum(1 for v in res.values() if v["values"]), "with values")
    for k in ("SacredTeachings.TargetHealSkills",): print(k, res.get(k))


if __name__ == "__main__":
    main()
