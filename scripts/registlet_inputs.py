"""Inputs for build_registlet.py, all from libil2cpp.so, every function located by name (run once per build, ~1 min):
  state/_gemcart_byid.json        GemCartId -> GemCartBuffer.*Buff class (constant get_Id of every buff class)
  state/_gemcart_factory.json     GemCartId -> class created by GemCartBufferFactory.Create (jump table emulated; System.Object = marker)
  state/_gemcart_consumers.json   GemCartId -> [via, function, pc]: callers of GemCartBufferManager.ContainsBuffer / GetGemCartBuffer / GetBufferLevel / ... with a literal id
  state/_gemcart_consumers2.json  same for `Enumerable.Contains<short>(GemCartBag.GetIDEquipGemCart(), id)` (equipped-list test)
"""
import os, sys, json, bisect
import numpy as np
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import il2
from dis_android import b, names, starts, md, OFF
import emu_factory as E

W = np.frombuffer(b, dtype="<u4", count=len(b) // 4)
BL = np.nonzero((W >> 26) == 0b100101)[0]


def target(i):
    imm = int(W[i] & 0x3ffffff)
    if imm >> 25: imm -= 1 << 26
    return int(i) * 4 + OFF + imm * 4


def func_of(pc):
    return names.get(starts[bisect.bisect_right(starts, pc) - 1], "?")


def literal_id(i):
    """immediate of the closest `movz w1, #imm` before the bl at word i"""
    for k in range(1, 14):
        x = int(W[i - k])
        if (x & 0xffe0001f) == 0x52800001: return (x >> 5) & 0xffff
    return None


def main():
    create = il2.method_rva("GemCartBufferFactory", "Create")
    mgr = {il2.method_rva("GemCartBufferManager", n): n for n in ("ContainsBuffer", "GetGemCartBuffer", "GetBufferLevel", "UpdateEquipGemCartData", "RemoveGemCartBuffer")}
    contains_short = {a for a, n in names.items() if n == "System.Linq.Enumerable$$Contains<short>"}
    ids = sorted(il2.enum_values("GemCartId").values())
    byid = {}
    for a, n in names.items():
        if n.startswith("GemCartBuffer.") and n.endswith("$$get_Id"):
            ins = list(md.disasm(b[a - OFF:a - OFF + 8], a))
            if ins[0].mnemonic == "mov" and ins[1].mnemonic == "ret":
                v = ins[0].op_str.split(", ")[1]
                byid[int(v[1:], 0)] = [n.split("$$")[0]]
    fac = {}
    for i in ids:
        r = E.run(create, i, limit=2000)
        if r[0] == "ok": fac[i] = r[1]
    c1, c2 = {}, {}
    equip_fns = {a for a, n in names.items() if n.startswith(("GemCartBag$$", "RegistletManager$$"))}
    for i in BL:
        t = target(i)
        if t in mgr:
            c1.setdefault(str(literal_id(i)), []).append([mgr[t], func_of(int(i) * 4 + OFF), hex(int(i) * 4 + OFF)])
        elif t in contains_short:
            near = next((names[target(i - k)] for k in range(1, 14) if (W[i - k] >> 26) == 0b100101 and target(i - k) in equip_fns), None)
            gid = literal_id(i)
            if near and gid is not None:
                c2.setdefault(str(gid), []).append(["EquippedContains", func_of(int(i) * 4 + OFF), hex(int(i) * 4 + OFF), near])
    for f, d in (("byid", byid), ("factory", fac), ("consumers", c1), ("consumers2", c2)):
        json.dump(d, open(os.path.join(il2.STATE, f"_gemcart_{f}.json"), "w"))
    print(len(byid), len(fac), len(c1), len(c2))


if __name__ == "__main__":
    main()
