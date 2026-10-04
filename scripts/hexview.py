import sys
import os
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from decode import decode

ver, name = sys.argv[1], sys.argv[2]
start, length = int(sys.argv[3]), int(sys.argv[4])
d = decode(open(rf"D:\toram_re\raw\{ver}\{name}.bytes", "rb").read(), int(ver, 16))
open(rf"D:\toram_re\raw\{ver}\{name}.dec", "wb").write(d)
for off in range(start, min(start + length, len(d)), 32):
    chunk = d[off:off + 32]
    print(f"{off:06x}: {chunk.hex(' ')}  {''.join(chr(c) if 32 <= c < 127 else '.' for c in chunk)}")
