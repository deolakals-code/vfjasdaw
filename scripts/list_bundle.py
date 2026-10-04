import glob, os, sys, UnityPy
from collections import Counter

root = os.path.expandvars(r"%USERPROFILE%\AppData\LocalLow\Unity\Asobimo,Inc_ToramOnline")
for name in sys.argv[1:]:
    for data in glob.glob(os.path.join(root, name, "*", "__data")):
        env = UnityPy.load(data)
        types = Counter(o.type.name for o in env.objects)
        print(name, os.path.basename(os.path.dirname(data))[-8:], dict(types))
        for o in env.objects:
            if o.type.name in ("TextAsset", "MonoBehaviour"):
                try:
                    d = o.read()
                    nm = getattr(d, "m_Name", "")
                    size = len(d.m_Script) if o.type.name == "TextAsset" else o.byte_size
                    print(f"   {o.type.name:<14} {nm:<40} {size}")
                except Exception as e:
                    print("   read err", o.type.name, e)
