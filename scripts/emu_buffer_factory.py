"""Decode SkillFactory.CreateSkillBuffer(int id, ...) jump table: skill id -> *Buf class. -> _buffer_map.json"""
import sys, json
sys.path.insert(0, r"D:\toram_re")
sys.path.insert(0, r"D:\toram_re\scripts")
from collections import Counter
from dis_android import names
import emu_factory as E

starts = sorted(a for a, n in names.items() if n == "SkillFactory$$CreateSkillBuffer")
print("overloads at", [hex(a) for a in starts])
best = None
for st in starts:
    res = {sid: E.run(st, sid, 800) for sid in range(0, 0x600)}
    ok = {k: v[1] for k, v in res.items() if v[0] == "ok"}
    print(hex(st), Counter(v[0] for v in res.values()), len(ok))
    if best is None or len(ok) > len(best[1]):
        best = (st, ok, res)
st, ok, res = best
json.dump(ok, open(r"D:\toram_re\scripts\_buffer_map.json", "w"))
print("kept", hex(st), len(ok), "unk sample", [(k, v) for k, v in res.items() if v[0] not in ("ok",)][:6])
