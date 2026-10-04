"""Export readable files from fetched bundles (the Unity-cache layout written by `toramre fetch get`).

What each bundle can hold (Code: scripts/export_models.py, export_world.py, tools/s1_extract_all.py):
  - TextAsset: XOR-encoded with the key in the cache dir name. Decoded, it is either an inner UnityFS bundle (Field / BGM /
    FieldScript; its assets are plain) or Toram's own model format (items, costumes, NPCs) or data.
  - Texture2D / Sprite -> PNG, AudioClip -> its samples (WAV/OGG, UnityPy/fmod), Mesh -> OBJ.
Output: <out>/<category>/<bundle>/...; `.export.json` per bundle (version, files, errors) makes reruns incremental.
UnityPy is needed only here (`pip install UnityPy`); everything else in toramre runs without it."""
import json
import os
import re
import struct
import time
from concurrent.futures import ProcessPoolExecutor, as_completed

from toramre.brain import guard
from toramre.core import paths  # noqa: F401  (tools/ on sys.path)
from common import decode

KINDS = ("model", "texture", "audio", "mesh", "text")
SAFE = re.compile(r"[^\w.\-]+")


def _safe(name):
    return SAFE.sub("_", name or "unnamed")[:120]


def cached_bundles(root):
    """-> [(bundle, version hex, path)] newest version per bundle in a Unity-cache-layout root."""
    out = {}
    if not os.path.isdir(root):
        return []
    for bundle in sorted(os.listdir(root)):
        bd = os.path.join(root, bundle)
        if not os.path.isdir(bd):
            continue
        for vdir in os.listdir(bd):
            p = os.path.join(bd, vdir, "__data")
            if len(vdir) == 32 and os.path.exists(p):
                if bundle not in out or os.path.getmtime(p) > os.path.getmtime(out[bundle][1]):
                    out[bundle] = (vdir[-8:], p)
    return [(b, v, p) for b, (v, p) in sorted(out.items())]


def _load_unitypy():
    try:
        import UnityPy  # noqa: F401
        return UnityPy.load
    except ImportError:
        raise SystemExit("UnityPy is not installed: `pip install UnityPy` (needed only for `toramre fetch export`)")


def _script_bytes(ta):
    s = ta.m_Script
    return s if isinstance(s, (bytes, bytearray)) else s.encode("utf-8", "surrogateescape")


class Exporter:
    def __init__(self, out_dir, kinds=KINDS, preview=True, loader=None):
        self.out_dir, self.kinds, self.preview = out_dir, set(kinds), preview
        self.loader = loader

    def bundle(self, bundle, vhex, path, category):
        guard.check_path(path)
        dest = os.path.join(self.out_dir, category, _safe(bundle))
        mark = os.path.join(dest, ".export.json")
        if os.path.exists(mark):
            prev = json.load(open(mark, encoding="utf-8"))
            if prev.get("version") == vhex and set(prev.get("kinds", [])) >= self.kinds:
                return {**prev, "skipped": True}
        loader = self.loader or _load_unitypy()
        res = {"bundle": bundle, "version": vhex, "category": category, "kinds": sorted(self.kinds), "files": {}, "errors": []}
        os.makedirs(dest, exist_ok=True)
        env = loader(path)
        self._walk(env, dest, int(vhex, 16), res, depth=0)
        res["exported_at"] = time.strftime("%Y-%m-%dT%H:%M:%S")
        json.dump(res, open(mark, "w", encoding="utf-8"), indent=1, ensure_ascii=False)
        return res

    def _count(self, res, kind, n=1):
        res["files"][kind] = res["files"].get(kind, 0) + n

    def _walk(self, env, dest, key, res, depth):
        for obj in env.objects:
            t = obj.type.name
            try:
                if t == "TextAsset":
                    self._text_asset(obj.read(), dest, key, res, depth)
                elif t in ("Texture2D", "Sprite") and "texture" in self.kinds:
                    data = obj.read()
                    name = _safe(data.m_Name) + ("" if t == "Texture2D" else ".sprite")
                    data.image.save(os.path.join(dest, f"{name}_{obj.path_id}.png"))
                    self._count(res, "texture")
                elif t == "AudioClip" and "audio" in self.kinds:
                    clip = obj.read()
                    for fname, raw in clip.samples.items():
                        with open(os.path.join(dest, _safe(fname)), "wb") as f:
                            f.write(raw)
                        self._count(res, "audio")
                elif t == "Mesh" and "mesh" in self.kinds:
                    m = obj.read()
                    with open(os.path.join(dest, f"{_safe(m.m_Name)}_{obj.path_id}.obj"), "w") as f:
                        f.write(m.export())
                    self._count(res, "mesh")
            except Exception as e:  # one bad object never stops the bundle
                res["errors"].append(f"{t} {getattr(obj, 'path_id', '?')}: {type(e).__name__}: {e}")

    def _text_asset(self, ta, dest, key, res, depth):
        raw = _script_bytes(ta)
        data = decode(raw, key) if depth == 0 else raw  # inner bundle assets are stored plain
        name = _safe(ta.m_Name)
        if data[:7] == b"UnityFS" and depth < 2:
            loader = self.loader or _load_unitypy()
            self._walk(loader(data), dest, key, res, depth + 1)
            return
        if "model" in self.kinds and self._model(data, dest, name, res):
            return
        if "text" in self.kinds:
            with open(os.path.join(dest, name + ".dec"), "wb") as f:
                f.write(data)
            self._count(res, "text")

    def _model(self, data, dest, name, res):
        from .toram_model import parse_model, render, write_obj
        try:
            textures, meshes, materials = parse_model(data)
        except (ValueError, IndexError, KeyError, struct.error, TypeError):
            return False
        if not meshes:
            return False
        write_obj(dest, name, textures, meshes, materials)
        self._count(res, "model")
        if self.preview:
            img = render(textures, meshes, materials)
            if img:
                img.save(os.path.join(dest, name + "_preview.png"))
        return True


def _one(args):
    out_dir, kinds, preview, bundle, vhex, path, category = args
    return Exporter(out_dir, kinds, preview).bundle(bundle, vhex, path, category)


def run(root, out_dir, categorize, only=("all",), match=None, kinds=KINDS, preview=True, jobs=1, loader=None, log=print):
    """Export every cached bundle that passes the filters. `categorize(bundle) -> category`."""
    rx = re.compile(match) if match else None
    todo = [(b, v, p, categorize(b)) for b, v, p in cached_bundles(root)]
    todo = [t for t in todo if ("all" in only or t[3] in only) and (not rx or rx.search(t[0]))]
    summary = {"bundles": len(todo), "exported": 0, "skipped": 0, "files": {}, "errors": []}

    def add(r):
        summary["skipped" if r.get("skipped") else "exported"] += 1
        for k, n in r.get("files", {}).items():
            summary["files"][k] = summary["files"].get(k, 0) + (0 if r.get("skipped") else n)
        summary["errors"] += [f"{r['bundle']}: {e}" for e in r.get("errors", [])] if not r.get("skipped") else []

    if jobs > 1 and loader is None:
        with ProcessPoolExecutor(max_workers=jobs) as ex:
            futs = {ex.submit(_one, (out_dir, kinds, preview, b, v, p, c)): b for b, v, p, c in todo}
            for i, f in enumerate(as_completed(futs), 1):
                try:
                    add(f.result())
                except Exception as e:
                    summary["errors"].append(f"{futs[f]}: {type(e).__name__}: {e}")
                log(f"\r{i}/{len(todo)} bundles", end="")
    else:
        ex = Exporter(out_dir, kinds, preview, loader)
        for i, (b, v, p, c) in enumerate(todo, 1):
            try:
                add(ex.bundle(b, v, p, c))
            except Exception as e:
                summary["errors"].append(f"{b}: {type(e).__name__}: {e}")
            log(f"\r{i}/{len(todo)} bundles", end="")
    log("")
    return summary
