"""RevisionInfoBinary.bytes (CDN version table) parser. Layout from AssetBundleManager.createVersionTable(byte[])
(libil2cpp.so arm64 RVA 0x17691B0): <B ?><i64 file size><i16 groups>, per group <7-bit-len string pattern><B type><i32 n>
+ n x <i32 index><i32 version><i32 size>; bundle key = pattern.format(index). Bundle URL = base + key + ".unity3d",
cache dir = version (see NOTES)."""
import struct, sys


def read_str(b, i):
    n = s = 0
    while True:
        c = b[i]; i += 1
        n |= (c & 0x7f) << s; s += 7
        if c < 0x80:
            return b[i:i + n].decode("utf-8"), i + n


def parse(b):
    size, groups = struct.unpack_from("<qh", b, 1)
    assert size == len(b), (size, len(b))
    i, out = 11, {}
    for _ in range(groups):
        pat, i = read_str(b, i)
        typ, n = struct.unpack_from("<Bi", b, i); i += 5
        for _ in range(n):
            idx, ver, sz = struct.unpack_from("<iii", b, i); i += 12
            out[pat.format(idx)] = (ver, typ, sz)
    assert i == len(b), (i, len(b))
    return out


if __name__ == "__main__":
    t = parse(open(sys.argv[1], "rb").read())
    print(len(t), "bundles")
    for k in sorted(t)[:10]:
        print(k, t[k])
