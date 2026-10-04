import struct, sys, os, glob
sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))


from common import decode  # noqa: E402  (single copy lives in tools/common.py)


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
