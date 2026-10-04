import struct, sys


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
    for rec in range(count):
        try:
            n, i = varint(b, i)
            key = b[i:i + n].decode("utf-8"); i += n
            n, i = varint(b, i)
            text = b[i:i + n].decode("utf-8"); i += n
            out.append((key, text))
        except Exception as e:
            print("STOP at record", rec, "offset", i, "err", e, file=sys.stderr)
            break
    return count, i, out


if __name__ == "__main__":
    b = open(sys.argv[1], "rb").read()
    count, end, rows = parse(b)
    print("count", count, "consumed", end, "of", len(b))
    needle = sys.argv[2] if len(sys.argv) > 2 else None
    for k, t in rows:
        if needle is None or needle in k or needle in t:
            print(k, "=>", t)
