import struct, sys, os, glob


def decode(buf: bytes, ver_hash: int) -> bytes:
    key = ver_hash.to_bytes(4, "little")
    out = bytearray(buf)
    # trailing len % 4 bytes are stored plain
    for j in range(len(buf) - len(buf) % 4):
        prev = buf[j - 4] if j >= 4 else 0
        out[j] = buf[j] ^ prev ^ key[j & 3]
    return bytes(out)


if __name__ == "__main__":
    ver = sys.argv[1]
    h = int(ver, 16)
    for p in sorted(glob.glob(rf"D:\toram_re\raw\{ver}\*.bytes")):
        b = open(p, "rb").read()
        d = decode(b, h)
        zeros = d.count(0) / max(len(d), 1)
        n = len(d) // 4
        ints = struct.unpack_from(f"<{min(n, 12)}i", d)
        print(f"{os.path.basename(p)[:-6]:<26} {len(d):>7} zero={zeros:.2f}  {ints}")
