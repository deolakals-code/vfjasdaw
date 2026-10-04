"""Annotated ARM64 disassembly of IL2CPP methods (Android libil2cpp.so).

Adds on top of dis_android.py: this-field names, vtable slot names (for the classes given with -c),
interface method names, float constants built via mov/movk + fmov, and CalcStep names for SkillCalcTemplate calls.

usage: python dis2.py [-c Cls1,Cls2] <Class$$Method | 0xRVA> ...
"""
import re, sys, struct, bisect, capstone
import dis_android as D

DUMP = D.DUMP + r"\dump.cs"
b, names, starts, OFF, RELA, meta, metam = D.b, D.names, D.starts, D.OFF, D.RELA, D.meta, D.metam


def parse_dump():
    classes, cur = {}, None
    rx_cls = re.compile(r"^(?:public|private|internal|protected)?\s*(?:abstract |sealed |static )*(class|interface|struct|enum) ([\w.<>`,]+)(?: : ([\w.<>`, ]+))? // TypeDefIndex")
    pending_slot = None
    for line in open(DUMP, encoding="utf-8"):
        m = rx_cls.match(line)
        if m:
            nm = m.group(2)
            cur = classes[nm] = {"kind": m.group(1), "parent": (m.group(3) or "").split(",")[0].strip(), "fields": {}, "slots": {}, "consts": {}, "imethods": [], "rets": {}}
            continue
        if cur is None:
            continue
        m = re.search(r"\s([\w<>]+); // 0x([0-9A-F]+)$", line)
        if m and not re.search(r"\bconst\b", line):
            cur["fields"][int(m.group(2), 16)] = m.group(1)
            continue
        m = re.search(r"public const [\w.]+ (\w+) = (-?\d+);", line)
        if m:
            cur["consts"][int(m.group(2))] = m.group(1)
            continue
        m = re.search(r"Slot: (\d+)", line)
        if m:
            pending_slot = int(m.group(1)); continue
        m = re.search(r"\s([\w.<>`,\[\] ]+?) ([\w.<>|`]+)\((.*)\)(?: \{ \}|;)", line)
        if m and pending_slot is not None:
            cur["slots"][pending_slot] = m.group(2)
            cur["rets"][pending_slot] = re.sub(r"\b(public|private|protected|internal|static|virtual|override|abstract|sealed|extern)\b ?", "", m.group(1)).strip()
            ps = [p.strip().rsplit(" ", 1) for p in re.sub(r"<[^>]*>", "", m.group(3)).split(",") if p.strip()]
            cur.setdefault("sparams", {})[pending_slot] = [(p[0].replace("out ", "").replace("ref ", ""), p[-1].split("=")[0].strip()) for p in ps]
            if cur["kind"] == "interface":
                cur["imethods"].append(m.group(2))
        pending_slot = None if m else pending_slot
    return classes


C = parse_dump()


def parse_sigs():
    sig, rva = {}, None
    for line in open(DUMP, encoding="utf-8"):
        m = re.search(r"// RVA: 0x([0-9A-F]+) ", line)
        if m: rva = int(m.group(1), 16); continue
        m = re.search(r"\s(static )?[\w.<>`,\[\] ]+? [\w.<>|`]+\((.*)\) \{ \}", line)
        if m and rva is not None:
            ps = [p.strip().rsplit(" ", 1) for p in re.sub(r"<[^>]*>", "", m.group(2)).split(",") if p.strip()]
            sig[rva] = (" static " in line, [(p[0].replace("out ", "").replace("ref ", ""), p[-1].split("=")[0].strip()) for p in ps])
        rva = None
    return sig


SIG = parse_sigs()


def parse_rets():
    """rva -> return type name (generic arguments dropped), from dump.cs method lines"""
    ret, rva = {}, None
    rx = re.compile(r"^\s+(?:public |private |protected |internal )?(?:static |virtual |override |abstract |sealed |extern )*([\w.<>`,\[\]? ]+?) ([\w.<>|`]+)\((.*)\) \{ \}")
    for line in open(DUMP, encoding="utf-8"):
        m = re.search(r"// RVA: 0x([0-9A-F]+) ", line)
        if m: rva = int(m.group(1), 16); continue
        if rva is not None:
            m = rx.match(line)
            if m:
                t = re.sub(r"<.*", "", m.group(1)).strip()
                if "." in t and not t.startswith(("System.", "UnityEngine.")): t = t.rsplit(".", 1)[-1] if t.count(".") == 1 and t.split(".")[0] in C else t
                ret[rva] = t
        rva = None
    return ret


RET = parse_rets()


def chain(cls):
    out = []
    while cls in C and cls not in out:
        out.append(cls); cls = C[cls]["parent"]
    return out


def field(cls, off):
    for c in chain(cls):
        if off in C[c]["fields"]:
            return f"{c}.{C[c]['fields'][off]}"


def slot_ret(cls, n):
    for c in chain(cls):
        if n in C[c]["slots"]:
            return C[c]["rets"].get(n)


def slot_params(cls, n):
    for c in chain(cls):
        if n in C[c]["slots"]:
            return C[c].get("sparams", {}).get(n)


def slot(cls, n):
    for c in chain(cls):
        if n in C[c]["slots"]:
            return f"{c}.{C[c]['slots'][n]}"


STEP = C.get("SkillCalcTemplate.CalcStep", {}).get("consts", {})
STEPFN = {"AddRate", "AddConstant", "SetRate", "SetConstant", "SetCheck", "SetCalcValue", "get_Item", "CheckStepResult", "TakeInCheckCalcStep"}
md = capstone.Cs(capstone.CS_ARCH_ARM64, capstone.CS_MODE_ARM)


def dis(rva, extra):
    i = bisect.bisect_right(starts, rva)
    end = starts[i] if i < len(starts) else rva + 0x400
    end = min(end, rva + 0x8000)
    fname = names.get(rva, hex(rva))
    this_cls = fname.split("$$")[0] if "$$" in fname else None
    print(f"==== {fname} @ {rva:#x} ({end - rva} bytes)")
    pages, wimm, this_regs, last_ti, wregs = {}, {}, {"x0"}, None, {}
    static, params = SIG.get(rva, (False, []))
    argty = {}
    for k, (ty, pn) in enumerate(params):
        argty[f"x{k + (0 if static else 1)}"] = (ty, pn)
    if static: this_regs = set()
    if params: print("  args: " + ", ".join(f"{r}={t} {n}" for r, (t, n) in argty.items()))
    vt, tireg = {}, {}
    for ins in md.disasm(b[rva - OFF:end - OFF], rva):
        op, mn, note = ins.op_str, ins.mnemonic, ""
        regs = [r.strip() for r in op.split(",")]
        # immediates for float reconstruction
        if mn == "mov" and len(regs) == 2 and regs[1].startswith("#"):
            v = int(regs[1][1:], 0) & 0xffffffff; wimm["w" + regs[0][1:]] = v; wregs[regs[0]] = v
        elif mn == "movk" and regs[0] in wregs:
            sh = int(op.split("lsl #")[1]) if "lsl" in op else 0
            v = (wregs[regs[0]] & ~(0xffff << sh)) | (int(regs[1][1:], 0) << sh)
            wregs[regs[0]] = v; wimm["w" + regs[0][1:]] = v
            note = f"= {v:#x}"
        if mn == "fmov" and len(regs) == 2 and regs[1] in wimm:
            note = f"= {struct.unpack('<f', struct.pack('<I', wimm[regs[1]]))[0]:g}f"
        # this tracking (x0 at entry)
        if mn == "mov" and len(regs) == 2 and regs[1] in this_regs and ins.address < rva + 0x40:
            this_regs.add(regs[0])
        if mn == "mov" and len(regs) == 2 and regs[1] in argty and ins.address < rva + 0x40:
            argty[regs[0]] = argty[regs[1]]
        mv = re.match(r"(x\d+), \[(x\d+)\]$", op)
        if mn == "ldr" and mv:
            vt[mv.group(1)] = mv.group(2)
        m = re.search(r"\[(x\d+), #(0x[0-9a-f]+)\]", op)
        if m and this_cls and m.group(1) in this_regs - {"x0"} and not note:
            f = field(this_cls, int(m.group(2), 16))
            if f: note = "this." + f.split(".", 1)[1]
        if m and mn in ("ldp", "ldr") and m.group(1) not in this_regs:
            off = int(m.group(2), 16)
            if off >= 0x138 and (off - 0x138) % 16 == 0 and (regs[0].startswith("x9") or regs[0].startswith("x8") or mn == "ldp"):
                n = (off - 0x138) // 16
                owner = vt.get(m.group(1))
                own = [this_cls] if owner in this_regs else [argty[owner][0]] if owner in argty else []
                cands = [s for s in (slot(c, n) for c in own + extra) if s]
                if cands: note = f"vslot {n}: " + " | ".join(dict.fromkeys(cands))
        if mn == "adrp":
            pages[regs[0]] = int(regs[1][1:], 16)
        m2 = re.match(r"(\w+), \[(\w+), #(0x[0-9a-f]+)\]", op)
        if m2 and m2.group(2) in pages and mn.startswith("ldr"):
            a = pages[m2.group(2)] + int(m2.group(3), 16); t = RELA.get(a, a)
            nm = meta.get(a) or metam.get(a) or meta.get(t) or metam.get(t)
            if nm:
                note = nm
                if nm.endswith("_TypeInfo") and C.get(nm[:-9], {}).get("kind") == "interface": tireg[m2.group(1)] = nm[:-9]
        mt = re.match(r"x1, \[(x\d+)\]$", op)
        if mn == "ldr" and mt and mt.group(1) in tireg:
            last_ti = tireg[mt.group(1)]
        # interface dispatch index
        if last_ti in C and C[last_ti]["kind"] == "interface":
            k = None
            if mn == "mov" and regs[0] == "w2" and regs[1].startswith("#"): k = int(regs[1][1:], 0)
            if mn == "add" and len(regs) == 3 and regs[2].startswith("#") and regs[0] == regs[1] and regs[0].startswith("w9"): k = int(regs[2][1:], 0)
            if k is not None and k in C[last_ti]["slots"]:
                note = f"{last_ti}.{C[last_ti]['slots'][k]}"
        if mn in ("bl", "b") and op.startswith("#"):
            t = int(op[1:], 16); tn = names.get(t, "")
            note = tn
            short = tn.split("$$")[-1]
            if short in STEPFN and "SkillCalcTemplate" in tn and "w1" in wimm:
                note += f"  [{STEP.get(wimm['w1'], wimm['w1'])}]"
        if mn in ("bl", "blr"):
            wimm = {}; wregs = {}
        print(f"  {ins.address:#x}: {mn:8s} {op:40s} {('; ' + note) if note else ''}")


if __name__ == "__main__":
    args, extra = sys.argv[1:], []
    if args and args[0] == "-c":
        extra = args[1].split(","); args = args[2:]
    for a in args:
        if a.startswith("0x"):
            dis(int(a, 16), extra)
        else:
            for addr, n in sorted(names.items()):
                if n == a: dis(addr, extra)
