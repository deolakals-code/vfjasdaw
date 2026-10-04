"""Name raw `[obj+0xNN]` field reads in stats/decoded/*.json using the il2cpp dump layout (idempotent, in place)."""
import re, json, glob, os
import dis2 as D2

DEC = r"D:\toram reverse data\skills\damage\stats\decoded"
BACK = re.compile(r"<(\w+)>k__BackingField")

# class -> {offset: (type, name)} straight from dump.cs (dis2.C keeps only the names)
FT = {}
_cur = None
for _l in open(r"D:\toram_re\dump_android\dump.cs", encoding="utf-8"):
    m = re.match(r"(?:public|internal)\s+(?:sealed |abstract |static )*(?:class|struct)\s+([\w.<>`]+)", _l)
    if m: _cur = FT.setdefault(m.group(1), {}); continue
    if _cur is not None:
        m = re.match(r"\t(?:[a-z]+ )+([\w.<>\[\],]+) (\w+|<\w+>k__BackingField); // 0x([0-9A-F]+)\s*$", _l)
        if m and "const" not in _l: _cur[int(m.group(3), 16)] = (m.group(1), BACK.sub(r"\1", m.group(2)))


_CH = {}


def _chain(c):
    if c not in _CH:
        try: _CH[c] = D2.chain(c)
        except Exception: _CH[c] = [c]
    return _CH[c]


def finfo(cls, off):
    for c in _chain(cls):
        if off in FT.get(c, {}): return FT[c][off]
    return None


def finfo_sub(cls, off, hint=""):
    """field at `off` declared by exactly one subclass of cls (the code cast the receiver down): (type, name, subclass);
    several candidates: the one whose name stem occurs in the function name (CalcMercenaryDamage -> MercenaryActionManager)"""
    hit = [(c, FT[c][off]) for c in FT if off in FT[c] and cls in _chain(c) and c != cls]
    if len(hit) > 1:
        hit = [h for h in hit if re.sub(r"(ActionManager|Action|Manager)$", "", h[0]) and re.sub(r"(ActionManager|Action|Manager)$", "", h[0]) in hint]
    return (hit[0][1][0], hit[0][1][1], hit[0][0]) if len(hit) == 1 else None


def nm(cls, off):
    f = finfo(cls, off)
    return f[1] if f else None


def fix_text(s, cls, ptypes, fname=""):
    def item_db(m):
        n = nm("ItemDBData", int(m.group(1), 16))
        return f"item.dbData.{n}" if n else m.group(0)

    def item(m):
        n = nm("ItemData", int(m.group(1), 16))
        return f"item.{n}" if n else m.group(0)

    def this(m):
        n = nm(cls, int(m.group(1), 16))
        return f"this.{n}" if n else m.group(0)

    def base_type(b):
        g = re.fullmatch(r"Singleton<(\w+)>\.get_Instance\(\)", b)
        return g.group(1) if g else ptypes.get(b)

    def step(prefix, t, off):
        """-> (new prefix text, new type, field name) or None"""
        f = finfo(t, off)
        if f: return f"{prefix}.{f[1]}", f[0]
        g = finfo_sub(t, off, fname)
        if g: return f"({prefix} as {g[2]}).{g[1]}", g[0]
        return None

    def nested(m):
        t = base_type(m.group(1))
        r1 = step(m.group(1), t, int(m.group(2), 16)) if t else None
        if not r1: return m.group(0)
        r2 = step(r1[0], r1[1], int(m.group(3), 16))
        return r2[0] if r2 else f"{r1[0]}+{m.group(3)}"

    def single(m):
        t = base_type(m.group(1))
        r1 = step(m.group(1), t, int(m.group(2), 16)) if t else None
        return r1[0] if r1 else m.group(0)
    s = re.sub(r"\[\[WeaponTypeCalculatorBase\.item\+0x28\]\+(0x[0-9a-f]+)\]", item_db, s)
    s = re.sub(r"\[WeaponTypeCalculatorBase\.item\+(0x[0-9a-f]+)\]", item, s)
    s = re.sub(r"\[this\+(0x[0-9a-f]+)\]", this, s)
    base = r"(Singleton<\w+>\.get_Instance\(\)|[A-Za-z_]\w*)"
    s = re.sub(r"\[\[" + base + r"\+(0x[0-9a-f]+)\]\+(0x[0-9a-f]+)\]", nested, s)
    s = re.sub(r"\[" + base + r"\+(0x[0-9a-f]+)\]", single, s)
    s = s.replace("0x165d9d4(", "new_array(").replace("0x18baae8(", "UnityColorToRgb(")
    return s


def walk(o, cls, ptypes, fname=""):
    if isinstance(o, str): return fix_text(o, cls, ptypes, fname)
    if isinstance(o, list): return [walk(x, cls, ptypes, fname) for x in o]
    if isinstance(o, dict): return {k: walk(v, cls, ptypes, fname) for k, v in o.items()}
    return o


n = 0
for p in glob.glob(os.path.join(DEC, "*", "*.json")):
    r = json.load(open(p, encoding="utf-8"))
    cls = r["name"].split("$$")[0]
    ptypes = {pn: pt for pt, pn in r.get("params", [])}
    r2 = walk(r, cls, ptypes, r["name"].split("$$")[-1])
    if r2 != r:
        json.dump(r2, open(p, "w", encoding="utf-8"), ensure_ascii=False); n += 1
print("files changed:", n)
