"""For param-less buff classes: list their methods and the external functions that call them. usage: python buf_users.py Cls [Cls...]"""
import sys, struct, bisect, collections
import dis_android as D

classes = set(sys.argv[1:])
meths = {a: n for a, n in D.names.items() if n.split("$$")[0] in classes}
s, e = 0x14cb94c, 0x14cb94c + 0x235d294
code = D.b[s:e]
users = collections.defaultdict(set)
for i in range(0, len(code) - 3, 4):
    w = struct.unpack_from("<I", code, i)[0]
    if (w >> 26) in (0x25, 0x05):
        imm = w & 0x3ffffff
        if imm & 0x2000000: imm -= 0x4000000
        pc = s + i + D.OFF
        t = pc + imm * 4
        if t in meths:
            caller = D.names.get(D.starts[bisect.bisect_right(D.starts, pc) - 1], "?")
            if caller.split("$$")[0] not in classes:
                users[meths[t].split("$$")[0]].add(f"{caller} -> {meths[t].split('$$')[1]}")
for c in sorted(classes):
    print("==", c, "methods:", sorted(n.split("$$")[1] for n in meths.values() if n.split("$$")[0] == c))
    for u in sorted(users[c])[:12]: print("    used by", u)
