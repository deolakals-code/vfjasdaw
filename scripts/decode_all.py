import glob, os, sys
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from decode import decode

for d in glob.glob(r"D:\toram_re\raw\*") + glob.glob(r"D:\toram_re\text_*"):
    ver = os.path.basename(d)[-8:]
    for p in glob.glob(os.path.join(d, "*.bytes")):
        open(p[:-6] + ".dec", "wb").write(decode(open(p, "rb").read(), int(ver, 16)))
    print(d, len(glob.glob(os.path.join(d, "*.dec"))))
