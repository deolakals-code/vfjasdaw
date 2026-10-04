import glob, os, sys, UnityPy
sys.path.insert(0, r"D:\toram_re")
from decode import decode

root = os.path.expandvars(r"%USERPROFILE%\AppData\LocalLow\Unity\Asobimo,Inc_ToramOnline\GameScene_th")
data = max(glob.glob(root + r"\*\__data"), key=os.path.getmtime)
ver = os.path.basename(os.path.dirname(data))[-8:]
out = rf"D:\toram_re\text_{ver}"
os.makedirs(out, exist_ok=True)
print("version", ver)
for o in UnityPy.load(data).objects:
    if o.type.name != "TextAsset":
        continue
    ta = o.read()
    raw = ta.m_Script
    raw = raw.encode("utf-8", "surrogateescape") if isinstance(raw, str) else bytes(raw)
    open(os.path.join(out, ta.m_Name + ".bytes"), "wb").write(raw)
    dec = decode(raw, int(ver, 16))
    open(os.path.join(out, ta.m_Name + ".dec"), "wb").write(dec)
    if ta.m_Name == "Skill_th":
        for label, b in (("raw", raw), ("dec", dec)):
            print(label, b[:160].hex(" "))
            print("   utf8:", b[:400].decode("utf-8", "replace").replace("\n", "\\n")[:200])
