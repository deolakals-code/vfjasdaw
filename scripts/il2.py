"""Build-independent facts about the analysed libil2cpp.so: nothing here may contain an address copied from one build.

  WORK, DATA, SO, DUMP        paths (override with env TORAM_WORK / TORAM_DATA)
  ELF layout                  TEXT_VA / TEXT_OFF / TEXT_SIZE / OFF (= va - file offset of the exec segment), read from the program headers
  method_rva(cls, name, sig)  RVA of one overload, from dump.cs (Il2CppDumper output), e.g. method_rva("SkillFactory", "CreateSkill", "int")
  stub(role)                  il2cpp runtime thunks that symexec/gem tracers need: object_new, array_new, wb_set_field, class_init, null_ref, bounds
                              (found by structure + call frequency + link to the exported il2cpp_* API, cached per SHA-256 of the .so)
  so_sha256()                 identity of the binary (update_game.py compares it with the stored one)
Run `python il2.py` to print the discovered values.
"""
import os, re, json, struct, hashlib, collections

WORK = os.environ.get("TORAM_WORK", r"D:\toram_re")
DATA = os.environ.get("TORAM_DATA", r"D:\toram reverse data")
SO = os.path.join(WORK, r"apk\lib\libil2cpp.so")
DUMP = os.path.join(WORK, "dump_android")
STATE = os.path.join(WORK, "state")
os.makedirs(STATE, exist_ok=True)

_b = None


def so_bytes():
    global _b
    if _b is None: _b = open(SO, "rb").read()
    return _b


def so_sha256():
    return hashlib.sha256(so_bytes()).hexdigest()


def _elf():
    b = so_bytes()
    phoff, = struct.unpack_from("<Q", b, 0x20)
    phentsize, phnum = struct.unpack_from("<HH", b, 0x36)
    for k in range(phnum):
        t, fl, off, va, _pa, fsz, _msz, _al = struct.unpack_from("<IIQQQQQQ", b, phoff + k * phentsize)
        if t == 1 and fl & 1: return va, off, fsz          # PT_LOAD with PF_X
    raise RuntimeError("no executable PT_LOAD")


TEXT_VA, TEXT_OFF, TEXT_SIZE = _elf()
OFF = TEXT_VA - TEXT_OFF                                    # RVA - file offset, valid inside the exec segment (and rodata below it: RVA == offset)
TEXT_RANGE = (TEXT_OFF, TEXT_OFF + TEXT_SIZE)               # file-offset range of the code (skill_consumers / marker_calls / scan_*)


def exports():
    """{name: rva} of .dynsym entries (il2cpp_* API)"""
    b = so_bytes()
    shoff, = struct.unpack_from("<Q", b, 0x28)
    shentsize, shnum, shstr = struct.unpack_from("<HHH", b, 0x3A)
    secs = [struct.unpack_from("<IIQQQQIIQQ", b, shoff + k * shentsize) for k in range(shnum)]
    ds = next(s for s in secs if s[1] == 11)                # SHT_DYNSYM
    st = secs[ds[6]]                                        # linked string table
    out = {}
    for i in range(0, ds[5], 24):
        nm, _info, _o, _shndx, val, _sz = struct.unpack_from("<IBBHQQ", b, ds[4] + i)
        if val: out[b[st[4] + nm:b.index(b"\0", st[4] + nm)].decode()] = val
    return out


_methods = None


def method_rva(cls, name, sig=None):
    """RVA of `cls.name(...)` from dump.cs; sig = substring of the parameter list to pick one overload"""
    global _methods
    if _methods is None:
        _methods, c = collections.defaultdict(list), None
        L = open(os.path.join(DUMP, "dump.cs"), encoding="utf-8", errors="replace").read().splitlines()
        for i, l in enumerate(L):
            if l and not l.startswith((" ", "\t")):
                m = re.match(r"^(?:public |internal |private |protected )?(?:abstract |sealed |static )*(?:class|struct|interface|enum)\s+([^\s:<]+)", l)
                if m: c = m.group(1)
            elif c and i:
                r = re.search(r"RVA: (0x[0-9A-Fa-f]+)", L[i - 1])
                m = re.search(r"(\w+)\(([^)]*)\)\s*\{", l)
                if r and m: _methods[(c, m.group(1))].append((int(r.group(1), 16), m.group(2)))
    c = [(a, s) for a, s in _methods.get((cls, name), []) if sig is None or sig in s]
    if len(c) != 1: raise LookupError(f"{cls}.{name}({sig}): {len(c)} candidates {[(hex(a), s) for a, s in c]}")
    return c[0][0]


_names = None
_sorted = None


def names():
    """{rva: name} from script.json (Il2CppDumper)"""
    global _names
    if _names is None:
        sj = json.load(open(os.path.join(DUMP, "script.json"), encoding="utf-8"))
        _names = {m["Address"]: m["Name"] for m in sj["ScriptMethod"]}
    return _names


def fn(name):
    """RVA of the one function called exactly `name` in script.json (e.g. 'GrantData$$.cctor'); raises when 0 or several"""
    c = [a for a, n in names().items() if n == name]
    if len(c) != 1: raise LookupError(f"{name}: {len(c)} functions")
    return c[0]


def fn_end(rva):
    """start of the next function after `rva` (script.json order)"""
    import bisect
    global _sorted
    if _sorted is None: _sorted = sorted(names())
    return _sorted[bisect.bisect_right(_sorted, rva)]


def enum_values(name):
    """{member: value} of `public enum <name>` in dump.cs"""
    s = open(os.path.join(DUMP, "dump.cs"), encoding="utf-8", errors="replace").read()
    m = re.search(r"enum " + re.escape(name) + r" // TypeDefIndex[^\n]*\n\{(.*?)\n\}", s, re.S)
    if not m: raise LookupError(f"enum {name}")
    return {a: int(b) for a, b in re.findall(r"const \w+ (\w+) = (-?\d+);", m.group(1))}


def field_offset(cls, field):
    """byte offset of `field` (auto-property backing fields accepted as `<Name>k__BackingField` or `Name`) in class `cls`, from dump.cs"""
    s = open(os.path.join(DUMP, "dump.cs"), encoding="utf-8", errors="replace").read()
    m = re.search(r"(?:class|struct) " + re.escape(cls) + r"\b[^\n]*// TypeDefIndex[^\n]*\n\{(.*?)\n\}", s, re.S)
    if not m: raise LookupError(f"class {cls}")
    for n, off in re.findall(r"\s(\S+); // (0x[0-9A-Fa-f]+)", m.group(1)):
        if n in (field, f"<{field}>k__BackingField"): return int(off, 16)
    raise LookupError(f"{cls}.{field}")


def _bl_counts():
    import numpy as np
    b = so_bytes()
    w = np.frombuffer(b[:TEXT_OFF + TEXT_SIZE], dtype="<u4")
    idx = np.nonzero((w >> 26) == 0b100101)[0]
    imm = (w[idx] & 0x3ffffff).astype(np.int64)
    imm = np.where(imm >> 25, imm - (1 << 26), imm)
    return collections.Counter(((idx.astype(np.int64) * 4 + OFF) + imm * 4).tolist())


def _ins(rva, n=6):
    import capstone
    md = capstone.Cs(capstone.CS_ARCH_ARM64, capstone.CS_MODE_ARM)
    return [(i.mnemonic, i.op_str) for i in md.disasm(so_bytes()[rva - OFF:rva - OFF + 4 * n], rva)]


def _b_target(rva):
    m, o = _ins(rva, 1)[0]
    return int(o[1:], 16) if m == "b" and o.startswith("#") else None


def _discover():
    ex = exports()
    cnt = _bl_counts()
    out = {}
    # object_new / array_new: thunks that tail-branch to the function the exported il2cpp_object_new / il2cpp_array_new_specific use
    t_new = next(int(o[1:], 16) for m, o in _ins(ex["il2cpp_object_new"], 3) if m == "bl")
    t_arr = _b_target(ex["il2cpp_array_new_specific"])
    for t, c in cnt.most_common(400):
        if c < 2000: break
        bt = _b_target(t)
        if bt == t_new and "object_new" not in out: out["object_new"] = t
        if bt is None:
            ins = _ins(t, 2)
            if ins and ins[0][0] == "mov" and ins[0][1] == "w1, w1" and ins[1][0] == "b" and int(ins[1][1][1:], 16) == t_arr and "array_new" not in out: out["array_new"] = t
    # frequency + shape for the rest
    for t, c in cnt.most_common(60):
        ins = _ins(t, 5)
        if not ins: continue
        mn = [m for m, _ in ins]
        if "class_init" not in out and mn[:4] == ["str", "bl", "dmb", "ldr"]: out["class_init"] = t
        elif "wb_set_field" not in out and mn[0] == "b" and len(mn) > 2 and mn[1] == "mov" and ins[1][1] == "x0, x1" and mn[2] == "b" and ins[2][1] == ins[0][1]: out["wb_set_field"] = t
        elif "null_ref" not in out and mn[:4] == ["str", "bl", "str", "bl"] and "bounds" not in out: out["null_ref"] = t
    # bounds helper = the second thrower right after null_ref
    if "null_ref" in out:
        out["bounds"] = out["null_ref"] + 8
    return out


def stubs():
    p = os.path.join(STATE, "il2_stubs.json")
    sha = so_sha256()
    if os.path.exists(p):
        d = json.load(open(p))
        if d.get("sha256") == sha: return {k: int(v) for k, v in d["stubs"].items()}
    s = _discover()
    missing = {"object_new", "array_new", "wb_set_field", "class_init", "null_ref", "bounds"} - set(s)
    if missing: raise RuntimeError(f"il2cpp stub discovery failed for {missing}; inspect il2._discover")
    json.dump({"sha256": sha, "stubs": s}, open(p, "w"), indent=1)
    return s


def stub(role):
    return stubs()[role]


if __name__ == "__main__":
    print("sha256", so_sha256())
    print("exec segment va", hex(TEXT_VA), "off", hex(TEXT_OFF), "size", hex(TEXT_SIZE), "OFF", hex(OFF))
    print({k: hex(v) for k, v in stubs().items()})
    print("SkillFactory.CreateSkill(int)", hex(method_rva("SkillFactory", "CreateSkill", "int")))
