"""Stage 1: decode every TextAsset of every non-model bundle in all cache roots into BIGDATA/data/decoded.
History bundles (BynaryData, GameScene_*) keep every cached version; the rest keep the newest.
XOR key = last 8 hex chars of the version dir name. Nested UnityFS payloads are unpacked up to 2 levels."""
import glob, hashlib, json, os, re, sys, UnityPy
ROOT = r"D:\toram reverse data"
sys.path.insert(0, ROOT + r"\scripts")
import cache
from decode import decode

OUT = ROOT + r"\TORAM ONLINE BIGDATA\data\decoded"
MODEL = re.compile(r"^(cos|MobMotion|Field|BGM|body|Motion|NpcMotion|acce|arms|options|Npc|Mob|Item|E|SE|Servant|Avatar|Farm|P|Fish|FishMotion|Window|Door|InsideWall|OutsideWall|Roof|Floor|Myroom)_?\d+|^(Head|Hair|HairT|Face|Stamp|BackGround|Texture|CreateBGM|CreateField|ProtoType|NpcBone|ItemTex|SpecialPack_\w+|FontAtlas_\w+|Banner_\w+|WorldMapObject|Cooking)$")
HIST = re.compile(r"^(BynaryData|GameScene_\w+)$")


def versions():
    seen = {}
    for root in cache.ROOTS:
        for d in glob.glob(os.path.join(root, "*", "*", "__data")):
            ver = os.path.basename(os.path.dirname(d))
            name = os.path.basename(os.path.dirname(os.path.dirname(d)))
            if MODEL.search(name):
                continue
            v8 = ver[-8:]
            cur = seen.setdefault(name, {})
            if v8 not in cur or os.path.getmtime(d) > os.path.getmtime(cur[v8]):
                cur[v8] = d
    for name, vs in sorted(seen.items()):
        items = sorted(vs.items(), key=lambda kv: os.path.getmtime(kv[1]))
        if not HIST.match(name):
            items = items[-1:]
        for v8, p in items:
            yield name, v8, p


def walk(env, key, dest, rel, log, depth=0):
    for o in env.objects:
        if o.type.name != "TextAsset":
            continue
        ta = o.read()
        raw = ta.m_Script
        raw = raw.encode("utf-8", "surrogateescape") if isinstance(raw, str) else bytes(raw)
        dec = decode(raw, key) if depth == 0 else raw  # inner bundle assets are stored plain
        if dec[:7] == b"UnityFS" and depth < 2:
            try:
                walk(UnityPy.load(dec), key, dest, os.path.join(rel, ta.m_Name), log, depth + 1)
                continue
            except Exception as e:
                log.append((rel, ta.m_Name, "nested-fail " + str(e)[:60]))
        os.makedirs(os.path.join(dest, rel), exist_ok=True)
        open(os.path.join(dest, rel, ta.m_Name + ".dec"), "wb").write(dec)
        log.append((rel, ta.m_Name, len(dec), hashlib.sha1(dec).hexdigest()[:12]))


def main():
    manifest, n = {}, 0
    for name, v8, path in versions():
        log = []
        try:
            walk(UnityPy.load(path), int(v8, 16), os.path.join(OUT, name, v8), "", log)
        except Exception as e:
            log.append(("", "", "bundle-fail " + str(e)[:80]))
        ok = [l for l in log if len(l) == 4]
        if not ok and not log:
            continue
        manifest[f"{name}/{v8}"] = {"src": path, "assets": [list(l) for l in log]}
        n += len(ok)
    json.dump(manifest, open(os.path.join(os.path.dirname(OUT), "decoded_manifest.json"), "w"), indent=0)
    print(len(manifest), "bundle-versions,", n, "assets")


main()
