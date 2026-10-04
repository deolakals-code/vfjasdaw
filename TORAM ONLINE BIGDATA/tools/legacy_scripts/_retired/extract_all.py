import glob, os, UnityPy

root = os.path.expandvars(r"%USERPROFILE%\AppData\LocalLow\Unity\Asobimo,Inc_ToramOnline\BynaryData")
out = r"D:\toram_re\raw"
for data in glob.glob(root + r"\*\__data"):
    ver = os.path.basename(os.path.dirname(data))[-8:]
    os.makedirs(os.path.join(out, ver), exist_ok=True)
    env = UnityPy.load(data)
    n = 0
    for obj in env.objects:
        if obj.type.name != "TextAsset":
            continue
        ta = obj.read()
        raw = ta.m_Script
        raw = raw.encode("utf-8", "surrogateescape") if isinstance(raw, str) else bytes(raw)
        open(os.path.join(out, ver, ta.m_Name + ".bytes"), "wb").write(raw)
        n += 1
    print(ver, n, "assets", os.path.getmtime(data))
