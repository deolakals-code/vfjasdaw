"""Brute-force search for monster stat records (mob_<map> layout: <I id><I uuid><B room><B len><name_jp><H lv><I exp><I hp>...)
in every readable blob: all cached bundles (TextAssets decoded with the bundle hash, nested UnityFS recursed), the Steam
install and the APK. Prints where records live, so no source of monster data is missed. Offline only."""
import glob, json, os, sys, zipfile
import numpy as np
import UnityPy
HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, HERE)
sys.path.insert(0, os.path.dirname(HERE))
from cache import bundles
from export_items import latest_assets
from export_quests import parse_plain

UUIDS = np.array(sorted(parse_plain(latest_assets("GameScene_th")["Enemy_th"])), dtype=np.uint32)


from common import fast_decode  # noqa: E402


def records(b):
    """(offset, uuid, name) of every plausible mob record."""
    if len(b) < 60:
        return []
    a = np.frombuffer(b, np.uint8)
    m = len(a) - 60
    u = (a[4:4 + m].astype(np.uint32) | a[5:5 + m].astype(np.uint32) << 8 | a[6:6 + m].astype(np.uint32) << 16
         | a[7:7 + m].astype(np.uint32) << 24)
    cand = np.nonzero(np.isin(u, UUIDS) & (a[9:9 + m] > 0) & (a[9:9 + m] < 80))[0]
    out = []
    for i in cand:
        L = b[i + 9]
        j = i + 10 + L
        if j + 10 > len(b):
            continue
        try:
            name = b[i + 10:j].decode("utf-8")
        except UnicodeDecodeError:
            continue
        if not name.strip() or any(ord(c) < 32 for c in name):
            continue
        lv = int.from_bytes(b[j:j + 2], "little")
        hp = int.from_bytes(b[j + 6:j + 10], "little")
        if 1 <= lv <= 600 and hp > 0:
            out.append((int(i), int(u[i]), name))
    return out


HITS = []


def scan_blob(label, b, depth=0):
    r = records(b)
    if r:
        HITS.append({"src": label, "size": len(b), "n": len(r), "uuids": sorted({x[1] for x in r}),
                     "sample": [x[2] for x in r[:3]]})
    if b[:7] == b"UnityFS" and depth < 3:
        scan_env(label, UnityPy.load(b), None, depth + 1)


def scan_env(label, env, h, depth=0):
    for o in env.objects:
        try:
            if o.type.name == "TextAsset":
                ta = o.read()
                raw = ta.m_Script.encode("utf-8", "surrogateescape")
                scan_blob(f"{label}/{ta.m_Name}", raw, depth)
                if h is not None:
                    scan_blob(f"{label}/{ta.m_Name}[dec]", fast_decode(raw, h), depth)
            elif o.type.name == "MonoBehaviour":
                scan_blob(f"{label}/MB#{o.path_id}", o.get_raw_data(), depth)
        except Exception as e:
            print("skip", label, o.type.name, e, file=sys.stderr)


done = 0
for name, data in sorted(bundles("*").items()):
    try:
        h = int(os.path.basename(os.path.dirname(data))[-8:], 16)
        scan_env(name, UnityPy.load(data), h)
    except Exception as e:
        print("bundle fail", name, e, file=sys.stderr)
    done += 1
    if done % 200 == 0:
        print(done, "bundles", len(HITS), "hits", file=sys.stderr)

STEAM = r"D:\SteamLibrary\steamapps\common\Toram Online"
for p in glob.glob(os.path.join(STEAM, "**", "*"), recursive=True):
    if os.path.isfile(p) and os.path.getsize(p) < 600_000_000 and not p.lower().endswith((".dll", ".exe", ".ress", ".ress")):
        b = open(p, "rb").read()
        scan_blob("steam:" + os.path.relpath(p, STEAM), b)
        try:
            scan_env("steam:" + os.path.relpath(p, STEAM), UnityPy.load(p), None)
        except Exception:
            pass

for apk in glob.glob(r"D:\toram_re\apk\*.apk"):
    with zipfile.ZipFile(apk) as z:
        for n in z.namelist():
            if n.endswith(".so") or n.endswith(".dex"):
                continue
            b = z.read(n)
            scan_blob(f"apk:{os.path.basename(apk)}:{n}", b)
            if n.startswith("assets/"):
                try:
                    scan_env(f"apk:{n}", UnityPy.load(b), None)
                except Exception:
                    pass

out = os.path.join(os.environ.get("SCAN_OUT", HERE), "scan_mobs_hits.json")
json.dump(HITS, open(out, "w", encoding="utf-8"), ensure_ascii=False, indent=1)
allu = set().union(*[h["uuids"] for h in HITS]) if HITS else set()
print(len(HITS), "blobs with records;", len(allu), "distinct uuids of", len(UUIDS), "->", out)
