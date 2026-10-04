import struct, sys, math
from collections import Counter

def entropy(b):
    if not b:
        return 0.0
    n = len(b)
    return -sum(c / n * math.log2(c / n) for c in Counter(b).values())

for path in sys.argv[1:]:
    b = open(path, "rb").read()
    pe = struct.unpack_from("<I", b, 0x3C)[0]
    nsec = struct.unpack_from("<H", b, pe + 6)[0]
    optsz = struct.unpack_from("<H", b, pe + 20)[0]
    sec = pe + 24 + optsz
    print(path)
    for i in range(nsec):
        name, vsize, va, rsize, rptr = struct.unpack_from("<8sIIII", b, sec + i * 40)
        chars = struct.unpack_from("<I", b, sec + i * 40 + 36)[0]
        data = b[rptr:rptr + min(rsize, 4 << 20)]
        print(f"  {name.rstrip(b'\0').decode(errors='replace'):<10} va={va:#010x} vsize={vsize:>10} rsize={rsize:>10} ent={entropy(data):.2f} chars={chars:#x}")
