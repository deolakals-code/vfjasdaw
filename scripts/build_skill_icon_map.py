"""Which atlas sprite the game shows for each skill: UIIconBase.SkillIcon(skillId).
Rule (Code): a switch maps skillId to an icon id (or straight to a named sprite / ShopUtil.GetMaterialIconName), PetSkillIcon remaps a
25-entry range, then "sk_" + id:D3; if the sprite does not exist (CheckSprite) the game shows mapMarker_2.
The method is walked instruction by instruction (capstone, jump tables read from the binary; no hard-coded RVA).
Writes skills/icon_map.json|csv. Run from this directory: python build_skill_icon_map.py"""
import csv, json, os, re, struct, sys
from collections import Counter
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import il2
import dis_android as DA
from export_items import icon_sprites

ROOT = il2.DATA
B = il2.so_bytes()
CC = {"eq": lambda z, n, c, v: z, "ne": lambda z, n, c, v: not z, "gt": lambda z, n, c, v: not z and n == v,
      "le": lambda z, n, c, v: z or n != v, "lt": lambda z, n, c, v: n != v, "ge": lambda z, n, c, v: n == v,
      "hs": lambda z, n, c, v: c, "lo": lambda z, n, c, v: not c, "hi": lambda z, n, c, v: c and not z, "ls": lambda z, n, c, v: not c or z}


def fn(name):
    a = [x for x, n in DA.names.items() if n == name]
    assert len(a) == 1, name
    return a[0]


def code(rva):
    s, e = DA.func(rva)
    return {i.address: i for i in DA.md.disasm(B[s - il2.OFF:e - il2.OFF], s)}


class Regs(dict):
    """w5 and x5 are one register"""
    def __setitem__(self, k, v): super().__setitem__(k[1:], v)
    def __getitem__(self, k): return super().__getitem__(k[1:])
    def __contains__(self, k): return super().__contains__(k[1:])


def imm(s): return int(s.lstrip("#"), 16) if s.lstrip("#-").startswith("0x") else int(s.lstrip("#"))


def cmp_flags(a, b):
    a &= 0xFFFFFFFF; b &= 0xFFFFFFFF
    sa, sb = a - (a >> 31 << 32), b - (b >> 31 << 32)
    r = (a - b) & 0xFFFFFFFF
    return r == 0, bool(r >> 31), a >= b, ((sa < 0) != (sb < 0)) and ((r >> 31 & 1) != (sa < 0))


def pet_table():
    ins = code(fn("UIIconBase$$PetSkillIcon"))
    seq = list(ins.values())
    assert [i.mnemonic for i in seq[:8]] == ["sub", "cmp", "b.hi", "adrp", "add", "ldr", "ret", "mov"]
    lo = imm(seq[0].op_str.split(", ")[2]); n = imm(seq[1].op_str.split(", ")[1])
    page = imm(seq[3].op_str.split(", ")[1]); base = page + imm(seq[4].op_str.split(", ")[2])
    return lo, [struct.unpack_from("<i", B, base + 4 * i)[0] for i in range(n + 1)]


def material_names():
    """ShopUtil.GetMaterialIconName(id) = table[max(id, 0)]; the table is built from the string slots the function loads in order."""
    seq = list(code(fn("ShopUtil$$GetMaterialIconName")).values())
    pages, out = {}, []
    for i in seq:
        if i.mnemonic == "adrp":
            r, p = i.op_str.split(", "); pages[r] = imm(p)
        m = re.match(r"(\w+), \[(\w+), #(0x[0-9a-f]+)\]", i.op_str)
        if i.mnemonic == "ldr" and m and m.group(2) in pages and i.address > seq[0].address + 0x90:
            a = pages[m.group(2)] + int(m.group(3), 16)
            v = DA.meta.get(a) or DA.meta.get(DA.RELA.get(a, a))
            if v and v.startswith("'it_"): out.append(v.strip("'"))
    return out[:6]  # store order in the body is it_100, it_200, it_300, it_400, it_510, it_600


def walk(ins, sid, mats):
    """-> ('id', n) | ('name', s). Interprets the switch part of SkillIcon for one skillId."""
    start = min(ins)
    pc, reg, pages, flags, strs, last_w8 = start, Regs(), {}, None, {}, None
    reg["w1"] = reg["w20"] = sid
    for _ in range(400):
        i = ins[pc]; m, o = i.mnemonic, i.op_str; nxt = pc + 4
        a = [x.strip() for x in o.split(",")] if "[" not in o else None
        if m == "adrp": r, p = o.split(", "); pages[r] = imm(p); reg[r] = imm(p)
        elif m == "adr": r, p = o.split(", "); reg[r] = imm(p)
        elif m == "mov" and a and a[0][0] == "w" and not a[1].startswith("wzr"):
            reg[a[0]] = reg[a[1]] if a[1][0] in "wx" else imm(a[1])
            if a[0] == "w8": last_w8 = reg["w8"]
        elif m == "sub" and a and a[0][0] == "w": reg[a[0]] = (reg[a[1]] - imm(a[2])) & 0xFFFFFFFF
        elif m == "add" and a and a[0] in ("x9",) and a[1] == "x9":
            reg["x9"] = reg["x9"] + imm(a[2])
        elif m == "add" and a and a[0] == "x10":
            reg["x10"] = reg["x10"] + (reg["x11"] << 2)
        elif m == "ldrb":
            r, mem = o.split(", ", 1); mm = re.match(r"\[(x\d+), (x\d+)\]", mem)
            if mm: reg[r] = B[reg[mm.group(1)] + reg[mm.group(2)]]
            else: reg[r] = 1                              # static-init flag: take the "already initialised" branch
        elif m == "cmp":
            a0 = [x.strip() for x in o.split(",")]
            flags = cmp_flags(reg[a0[0]], reg[a0[1]] if a0[1][0] == "w" else imm(a0[1]))
        elif m == "tbnz":
            r, bit, tgt = [x.strip() for x in o.split(",")]
            if reg[r] >> imm(bit) & 1: nxt = imm(tgt)
        elif m == "ldr" and o == "x1, [x9]" and "x9" in reg and isinstance(reg["x9"], tuple):
            return "name", reg["x9"][1]
        elif m == "ldr" and "[" in o:
            mm = re.match(r"(\w+), \[(\w+), #(0x[0-9a-f]+)\]", o)
            if mm and mm.group(2) in pages and mm.group(1)[0] == "x":
                ad = pages[mm.group(2)] + int(mm.group(3), 16)
                v = DA.meta.get(ad) or DA.meta.get(DA.RELA.get(ad, ad))
                reg[mm.group(1)] = ("s", v.strip("'") if v and v.startswith("'") else v)
        elif m == "str" and o.startswith("w8, [sp, #8]"): strs["fmt"] = reg["w8"]
        elif m == "b" and not o.startswith("x"): nxt = imm(o)
        elif m.startswith("b.") and CC[m[2:]](*flags): nxt = imm(o)
        elif m == "br": nxt = reg["x10"]
        elif m == "bl":
            t = DA.names.get(imm(o), "")
            if t == "UIIconBase$$PetSkillIcon": return "id", reg["w20"]
            if t == "ShopUtil$$GetMaterialIconName": return "name", mats[max(reg["w0"], 0)] if "w0" in reg else None
            if t == "System.Int32$$ToString" and "fmt" in strs: return "name", f"it_{strs['fmt']}_0"
        elif m == "sub" and a: pass
        if m == "sub" and a and a[0] == "w0": reg["w0"] = (reg[a[1]] - imm(a[2])) & 0xFFFFFFFF
        pc = nxt
    raise RuntimeError(f"no result for {sid}")


def main():
    ins = code(fn("UIIconBase$$SkillIcon"))
    lo, tbl = pet_table()
    mats = material_names()
    assert mats == ["it_100", "it_200", "it_300", "it_400", "it_510", "it_600"] or len(mats) == 6, mats
    _, sprites = icon_sprites()
    rows = list(csv.DictReader(open(os.path.join(ROOT, "skills", "skills.csv"), encoding="utf-8-sig")))
    uid_of = {}
    for r in rows: uid_of.setdefault(int(r["SkillId"]), []).append(int(r["SkillUid"]))
    out = []
    for sid in sorted(uid_of):
        kind, v = walk(ins, sid, mats)
        if kind == "id":
            via = tbl[v - lo] if 0 <= v - lo < len(tbl) else v
            name = f"sk_{via:03d}"
            src = "direct" if via == sid else ("pet" if via != v else "alias")
        else:
            name, src = v, "named"
        if name not in sprites: name, src = "mapMarker_2", "fallback"
        out.append({"skillId": sid, "uids": uid_of[sid], "sprite": name, "source": src})
    json.dump(out, open(os.path.join(ROOT, "skills", "icon_map.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    with open(os.path.join(ROOT, "skills", "icon_map.csv"), "w", encoding="utf-8", newline="") as f:
        w = csv.writer(f); w.writerow(["skillId", "uids", "sprite", "source"])
        for o in out: w.writerow([o["skillId"], " ".join(map(str, o["uids"])), o["sprite"], o["source"]])
    print(len(out), Counter(o["source"] for o in out), "pet table", lo, tbl, "materials", mats)


if __name__ == "__main__":
    main()
