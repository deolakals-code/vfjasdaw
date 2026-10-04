"""`toramre doctor`: what this machine can run, and what is missing for each command."""
import importlib.util
import os
import shutil
import sys

from toramre.core import config, paths, versions

OK, WARN, MISS = "ok", "warn", "missing"


def checks(online=False):
    out = []

    def add(state, what, detail, needed_for=""):
        out.append((state, what, detail, needed_for))

    add(OK if sys.version_info >= (3, 9) else MISS, "python", sys.version.split()[0], "everything (3.9+, 3.11+ reads toramre.toml)")
    for mod, need in (("UnityPy", "fetch export, stage extract"), ("PIL", "fetch export (models / textures)"),
                      ("numpy", "legacy scan scripts only")):
        add(OK if importlib.util.find_spec(mod) else WARN, f"package {mod}", "installed" if importlib.util.find_spec(mod) else
            f"pip install {'Pillow' if mod == 'PIL' else mod}", need)
    cfg = config.path()
    add(OK if os.path.exists(cfg) else WARN, "settings", cfg if os.path.exists(cfg) else f"no {os.path.basename(cfg)} (defaults used)", "")
    bd = versions.list_versions("BynaryData")
    add(OK if bd else MISS, "decoded data", f"{len(bd)} BynaryData versions, newest {bd[-1] if bd else '-'}", "watch, ui, brain")
    hist = os.path.join(paths.MASTERS, "_history.csv")
    add(OK if os.path.exists(hist) else WARN, "_history.csv", "present" if os.path.exists(hist) else "absent: version order falls back to numbers",
        "watch ordering")
    cdn = os.path.join(paths.BIGDATA, "data", "cdn", "RevisionInfoBinary_A.bytes")
    add(OK if os.path.exists(cdn) else WARN, "CDN version tables", "stored" if os.path.exists(cdn) else "run `toramre fetch catalog`",
        "fetch plan/get/update")
    roots = [r for r in (os.environ.get("TORAM_CACHE") or "").split(os.pathsep) if r] + list(config.get("paths", "cache_roots", []) or [])
    have = [r for r in roots if os.path.isdir(r)]
    add(OK if have else WARN, "game cache roots", ", ".join(have) if have else "none set (TORAM_CACHE or [paths] cache_roots)",
        "stage extract")
    cc = config.get("paths", "cdn_cache", env="TORAM_CDN_CACHE") or os.path.join(paths.REPO, "cdn_cache")
    os.makedirs(paths.STATE, exist_ok=True)
    free = shutil.disk_usage(paths.STATE).free
    add(OK if free > 5e9 else WARN, "disk free", f"{free / 1e9:.1f} GB (full CDN set ~2.6 GB, export more)", "fetch get --only all")
    add(OK if os.path.isdir(cc) else WARN, "CDN cache folder", cc if os.path.isdir(cc) else f"{cc} (created on first fetch)", "fetch")
    try:
        probe = os.path.join(paths.STATE, ".write_test")
        open(probe, "w").close()
        os.remove(probe)
        add(OK, "state folder", paths.STATE, "")
    except OSError as e:
        add(MISS, "state folder", f"{paths.STATE}: {e}", "everything that writes reports")
    from toramre.brain import kb
    add(OK, "brain knowledge", f"{len(kb.all_tables())} learned schemas", "brain, watch record diffs")
    work = os.environ.get("TORAM_WORK") or r"D:\toram_re"
    so = os.path.join(work, "apk", "lib", "arm64", "libil2cpp.so")
    add(OK if os.path.exists(so) else WARN, "libil2cpp.so", so if os.path.exists(so) else f"not found under {work} (TORAM_WORK)",
        "IL2CPP side: skills pipeline, update runbook")
    hook = config.get("notify", "webhook", env="TORAM_WEBHOOK")
    add(OK if hook else WARN, "notify webhook", "set" if hook else "not set ([notify] webhook)", "watch --notify, fetch poll alerts")
    if online:
        from toramre.net.http import Client
        try:
            with Client(retries=1, timeout=20).open("https://toram-jp.akamaized.net/resources/android/releaseA/RevisionInfoBinary.bytes",
                                                     method="HEAD") as r:
                add(OK, "CDN reachable", f"HTTP {getattr(r, 'status', '?')}", "fetch")
        except Exception as e:
            add(MISS, "CDN reachable", f"{type(e).__name__}: {e}", "fetch")
    return out


def report(online=False, out=print):
    rows = checks(online)
    for state, what, detail, need in rows:
        out(f"[{state:7}] {what:20} {detail}" + (f"   (for: {need})" if need and state != OK else ""))
    bad = sum(1 for r in rows if r[0] == MISS)
    out(f"{len(rows)} checks: {sum(1 for r in rows if r[0] == OK)} ok, {sum(1 for r in rows if r[0] == WARN)} warnings, {bad} missing")
    return 1 if bad else 0
