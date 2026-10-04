"""Code hints: table name -> owner classes in the IL2CPP declaration dump -> field order and types.

Link followed: master table `RecipeMaster` -> class `RecipeDBData` (name tokens) -> its constructor
`.ctor(int recipeId, byte type, ..., RecipeDBData.RecipeMaterialData[] materialDatas)` -> element class fields.
The loader bodies are not in the repo (only declarations), so the count width of arrays and the width of enums are
unknown: every combination is tried and only a schema that fits every version to the exact last byte is kept.
"""
import itertools
import json
import os
import re

from toramre.core import paths

CS_ROOT = os.path.join(paths.BIGDATA, "readable", "code", "cs", "Assembly-CSharp")
PRIM = {"int": "i32", "uint": "u32", "short": "i16", "ushort": "u16", "byte": "u8", "sbyte": "i8", "bool": "u8",
        "float": "f32", "Int32": "i32", "Int16": "i16", "Byte": "u8", "Boolean": "u8", "Single": "f32", "UInt32": "u32",
        "UInt16": "u16"}
CTOR = re.compile(r"public void \.ctor\(([^)]*)\)")
FIELD = re.compile(r"^\s*(?:public|private|protected|internal)\s+(?!static|const)([\w.<>\[\], ]+?)\s+(\w+);\s*//\s*0x", re.M)
_index = None


def index():
    """{class name: {"fields": [(type, name)], "ctors": [[(type, name)]], "path": rel}} for Assembly-CSharp."""
    global _index
    if _index is not None:
        return _index
    cache = os.path.join(paths.STATE, "class_index.json")
    if os.path.exists(cache):
        _index = json.load(open(cache))
        return _index
    _index = {}
    for root, _, files in os.walk(CS_ROOT):
        for fn in files:
            if not fn.endswith(".cs"):
                continue
            src = open(os.path.join(root, fn), encoding="utf-8", errors="replace").read()
            name = fn[:-3]
            ctors = []
            for m in CTOR.finditer(src):
                args = [a.strip().rsplit(" ", 1) for a in m.group(1).split(",") if a.strip()]
                if args and all(len(a) == 2 for a in args):
                    ctors.append([tuple(a) for a in args])
            _index[name] = {"fields": [tuple(f) for f in FIELD.findall(src)], "ctors": ctors,
                            "path": os.path.relpath(os.path.join(root, fn), paths.BIGDATA)}
    os.makedirs(paths.STATE, exist_ok=True)
    json.dump(_index, open(cache, "w"))
    return _index


def tokens(name):
    name = re.sub(r"(Master|Data|MasterData|DB)$", "", name)
    return [t.lower() for t in re.findall(r"[A-Z][a-z0-9]*", name.replace("Avater", "Avatar").replace("Pallet", "Pallet"))]


def owners(table, limit=8):
    """Classes whose name carries every token of the table name, most specific first."""
    want = tokens(table)
    out = []
    for cls, info in index().items():
        if "<" in cls or "__" in cls or "_d__" in cls:
            continue
        have = [t.lower() for t in re.findall(r"[A-Z][a-z0-9]*", cls)]
        if want and all(any(h == w or (len(h) >= 4 and len(w) >= 4 and (h.startswith(w) or w.startswith(h))) for h in have) for w in want):
            if info["ctors"] or info["fields"]:
                out.append(cls)
    out.sort(key=lambda c: (not c.endswith(("Data", "DBData", "MasterData")), len(c)))
    return out[:limit]


def _type_options(t, depth=0):
    """Alternatives for one C# type as grammar items."""
    t = t.strip()
    if t in PRIM:
        return [[{"t": PRIM[t]}]]
    if t == "string" or t == "String":
        return [[{"t": "str", "len": "v7"}]]
    if t.endswith("[]") or t.startswith("List<"):
        elem = t[:-2] if t.endswith("[]") else t[5:-1]
        subs = _class_options(elem, depth + 1)
        return [[{"t": "list", "count": c, "elem": s}] for s in subs for c in ("u8", "u16", "u32", "v7")]
    # enum or unknown value type: its width is not in the declarations
    return [[{"t": "u8"}], [{"t": "i16"}], [{"t": "i32"}]]


def _class_options(cls, depth=0):
    info = index().get(cls) or index().get(cls.split(".")[-1])
    if not info or depth > 2:
        return []
    sigs = [c for c in info["ctors"] if c] or ([info["fields"]] if info["fields"] else [])
    out = []
    for sig in sorted(sigs, key=len, reverse=True)[:2]:
        for combo in itertools.islice(itertools.product(*[_type_options(t, depth) for t, _ in sig]), 64):
            out.append([it for part in combo for it in part])
    return out


def candidates(table, limit=400):
    """(owner class, signature names, record items) to verify."""
    seen = 0
    for cls in owners(table):
        info = index()[cls]
        sigs = [c for c in info["ctors"] if len(c) >= 2] + ([info["fields"]] if len(info["fields"]) >= 2 else [])
        for sig in sorted(sigs, key=len, reverse=True):
            opts = [_type_options(t) for t, _ in sig]
            for combo in itertools.product(*opts):
                yield cls, [n for _, n in sig], [it for part in combo for it in part]
                seen += 1
                if seen >= limit:
                    return
