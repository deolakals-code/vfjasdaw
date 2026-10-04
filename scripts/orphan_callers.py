"""For every orphan *Buf class, list which functions call its constructor(s) (level 1) and who calls those functions (level 2).
-> orphan_callers.json {buf: [fn,...]}, orphan_callers2.json {buf: {fn: [caller,...]}}"""
import json, struct, bisect, collections
import dis_android as D

orph = json.load(open(r"D:\toram_re\skillrecipes_orphan_bufs.json", encoding="utf-8"))
tgt = {}
for a, n in D.names.items():
    c, _, m = n.partition("$$")
    if c in orph and m == ".ctor":
        tgt[a] = c

s, e = 0x14cb94c, 0x14cb94c + 0x235d294
code = D.b[s:e]


def calls():
    for i in range(0, len(code) - 3, 4):
        w = struct.unpack_from("<I", code, i)[0]
        if (w >> 26) in (0x25, 0x05):
            imm = w & 0x3ffffff
            if imm & 0x2000000: imm -= 0x4000000
            pc = s + i + D.OFF
            yield pc, pc + imm * 4


def fn_of(pc):
    j = bisect.bisect_right(D.starts, pc) - 1
    return D.starts[j]


L1 = collections.defaultdict(set)          # buf -> {fn start}
allcalls = list(calls())
for pc, t in allcalls:
    if t in tgt:
        L1[tgt[t]].add(fn_of(pc))
wanted = {f for v in L1.values() for f in v}
callers_of = collections.defaultdict(set)
for pc, t in allcalls:
    if t in wanted:
        callers_of[t].add(fn_of(pc))
nm = lambda a: D.names.get(a, hex(a))
json.dump({c: sorted(nm(f) for f in v) for c, v in L1.items()}, open(r"D:\toram_re\orphan_callers.json", "w", encoding="utf-8"), ensure_ascii=False, indent=1)
json.dump({c: {nm(f): sorted(nm(x) for x in callers_of.get(f, ())) for f in v} for c, v in L1.items()},
          open(r"D:\toram_re\orphan_callers2.json", "w", encoding="utf-8"), ensure_ascii=False, indent=1)
print(len(tgt), "ctors,", len(L1), "classes with callers")
