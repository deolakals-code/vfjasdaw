"""Unity bundle caches to read: PC cache and a copied phone cache (copies keep the phone's mtimes).
TORAM_CACHE (os.pathsep-separated) overrides the list. For each bundle the newest cached version across
all roots wins (the phone can be on a newer game data version than the PC)."""
import glob, os

ROOTS = [r for r in (os.environ.get("TORAM_CACHE") or os.pathsep.join([
    os.path.expandvars(r"%USERPROFILE%\AppData\LocalLow\Unity\Asobimo,Inc_ToramOnline"),
    r"D:\toram_re\phone_cache\UnityCache\Shared",
    r"D:\toram_re\cdn_cache",  # cdn_fetch.py
])).split(os.pathsep) if os.path.isdir(r)]


def bundles(pattern):
    """{bundle dir name: __data path} for bundle dirs matching the glob pattern."""
    out = {}
    for root in ROOTS:
        for d in glob.glob(os.path.join(root, pattern, "*", "__data")):
            b = os.path.basename(os.path.dirname(os.path.dirname(d)))
            if b not in out or os.path.getmtime(d) > os.path.getmtime(out[b]):
                out[b] = d
    return out


def newest(bundle):
    return bundles(bundle)[bundle]
