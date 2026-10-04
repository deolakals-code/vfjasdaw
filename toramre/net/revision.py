"""RevisionInfoBinary.bytes (CDN version table) parser. Layout from AssetBundleManager.createVersionTable(byte[])
(libil2cpp.so arm64): <B ?><i64 file size><i16 groups>, per group <7-bit-len string pattern><B type><i32 n>
+ n x <i32 index><i32 version><i32 size>; bundle key = pattern.format(index). Bundle URL = base + key + ".unity3d",
cache dir = version. The size field is not bytes: observed ratio to Content-Length is about 10,300-10,600 (Inferred: ~10 KiB units)."""
import struct


def read_str(b, i):
    n = s = 0
    while True:
        c = b[i]
        i += 1
        n |= (c & 0x7f) << s
        s += 7
        if c < 0x80:
            return b[i:i + n].decode("utf-8"), i + n


def parse(b):
    """-> {key: (version int32, type, size units)}; asserts the declared file size and exact EOF."""
    size, groups = struct.unpack_from("<qh", b, 1)
    assert size == len(b), (size, len(b))
    i, out = 11, {}
    for _ in range(groups):
        pat, i = read_str(b, i)
        typ, n = struct.unpack_from("<Bi", b, i)
        i += 5
        for _ in range(n):
            idx, ver, sz = struct.unpack_from("<iii", b, i)
            i += 12
            out[pat.format(idx)] = (ver, typ, sz)
    assert i == len(b), (i, len(b))
    return out


def build(entries):
    """Inverse of parse for tests: entries = {key: (version, type, size)}, one group per key."""
    body = b""
    for k, (ver, typ, sz) in entries.items():
        kb = k.replace("{", "{{").replace("}", "}}").encode()
        body += bytes([len(kb)]) + kb + struct.pack("<Bi", typ, 1) + struct.pack("<iii", 0, ver, sz)
    total = 11 + len(body)
    return b"\x00" + struct.pack("<qh", total, len(entries)) + body
