import struct, sys
from collections import Counter


def varint(b, i):
    n = shift = 0
    while True:
        c = b[i]; i += 1
        n |= (c & 0x7f) << shift
        if c < 0x80:
            return n, i
        shift += 7


def parse(b):
    count = struct.unpack_from("<I", b, 0)[0]
    i, out = 4, []
    for _ in range(count):
        tid, kind = struct.unpack_from("<IB", b, i); i += 5
        n, i = varint(b, i)
        out.append((tid, kind, b[i:i + n].decode("utf-8")))
        i += n
    return count, i, out


if __name__ == "__main__":
    b = open(sys.argv[1], "rb").read()
    count, end, rows = parse(b)
    print("count", count, "consumed", end, "of", len(b))
    print("kinds", Counter(k for _, k, _ in rows))
    for r in rows[:int(sys.argv[2]) if len(sys.argv) > 2 else 12]:
        print(r)
