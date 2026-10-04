import struct, sys

ver, name = sys.argv[1], sys.argv[2]
skip = int(sys.argv[3]); width = int(sys.argv[4]); rows = int(sys.argv[5])
h = int(ver, 16)
b = open(rf"D:\toram_re\raw\{ver}\{name}.bytes", "rb").read()
ints = struct.unpack_from(f"<{len(b)//4}i", b)

def s32(x):
    return x - (1 << 32) if x & 0x80000000 else x

def show(v):
    u = v & 0xffffffff
    a, x = s32(u), s32(u ^ h)
    if abs(x) < abs(a):
        return f"{x:>8}^"
    return f"{a:>8} "

print("header:", " ".join(show(v) for v in ints[:skip]))
for r in range(rows):
    row = ints[skip + r * width: skip + (r + 1) * width]
    print(f"{r:>4}:", " ".join(show(v) for v in row))
