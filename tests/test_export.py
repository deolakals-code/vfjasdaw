import json
import os
import struct
import sys
import tempfile
import unittest

sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
from toramre.assets import export as ex  # noqa: E402
from toramre.assets.toram_model import parse_model  # noqa: E402
from toramre.core import paths  # noqa: E402,F401
from common import decode  # noqa: E402


def toram_model():
    """A one-triangle model in Toram's format: header, textures (sec 3), materials (sec 2), meshes (sec 1)."""
    tex = bytes([1]) + bytes([0]) + struct.pack("<HH", 2, 2) + bytes(range(12))          # 1 RGB 2x2 texture (ver 1: index only)
    mat = bytes([1]) + bytes([0, 3, 1]) + bytes([100, 0])                                # material 0: opaque, MainTexture 0
    name = b"body"
    mesh_body = struct.pack("<H", 3) + b"".join(struct.pack("<3f", *v) for v in ((0, 0, 0), (1, 0, 0), (0, 1, 0)))
    mesh_body += bytes([0, 0, 0, 0]) * 3 + b"".join(struct.pack("<2f", u, v) for u, v in ((0, 0), (1, 0), (0, 1)))
    mesh_body += bytes(8 * 3) + bytes([0]) + bytes([1, 0]) * 3 + bytes([1]) + bytes([0]) + struct.pack("<H", 3) + struct.pack("<3H", 0, 1, 2)
    head_len = 2 + 3 * 9
    sec1 = head_len + len(tex) + len(mat)
    mesh_off = sec1 + 1 + 1 + len(name) + 8
    meshes = bytes([1]) + bytes([len(name)]) + name + struct.pack("<II", mesh_off, 0) + mesh_body
    head = bytes([1, 3]) + bytes([3]) + struct.pack("<II", head_len, 0) + bytes([2]) + struct.pack("<II", head_len + len(tex), 0) \
        + bytes([1]) + struct.pack("<II", sec1, 0)
    return head + tex + mat + meshes


class Obj:
    def __init__(self, type_name, data, path_id=1):
        self.type = type("T", (), {"name": type_name})
        self._d, self.path_id = data, path_id

    def read(self):
        return self._d


class TA:
    def __init__(self, name, script):
        self.m_Name, self.m_Script = name, script


class Env:
    def __init__(self, objects):
        self.objects = objects


class Export(unittest.TestCase):
    def test_parse_synthetic_model(self):
        tex, meshes, mats = parse_model(toram_model())
        self.assertEqual((len(tex), meshes[0][0], len(meshes[0][1]), mats[0][0]), (1, "body", 3, "opaque"))

    def test_walk_model_inner_bundle_text_and_errors(self):
        key = int("a7e43f32", 16)  # the XOR key is the cache dir name read as hex (s1, export_models)
        enc = lambda b: decode(b, key)  # the rule is its own inverse only with the original ciphertext; encode explicitly  # noqa: E731

        def encode(p):
            k, c = key.to_bytes(4, "little"), bytearray(p)
            for j in range(len(p) - len(p) % 4):
                c[j] = p[j] ^ (c[j - 4] if j >= 4 else 0) ^ k[j & 3]
            return bytes(c)

        model, data = toram_model(), b"\x01\x02plain data table"
        self.assertEqual(enc(encode(model)), model)
        inner = Env([Obj("TextAsset", TA("inner_table", b"plain inner"))])

        class BadMesh:
            m_Name = "bad"

            def export(self):
                raise RuntimeError("broken mesh")

        outer = Env([Obj("TextAsset", TA("cos90", encode(model))), Obj("TextAsset", TA("tbl", encode(data))),
                     Obj("TextAsset", TA("nested", encode(b"UnityFS" + b"\0" * 9))), Obj("Mesh", BadMesh(), 7)])

        def loader(x):
            return inner if isinstance(x, (bytes, bytearray)) else outer

        with tempfile.TemporaryDirectory() as root, tempfile.TemporaryDirectory() as out:
            d = os.path.join(root, "cos90", "0" * 24 + "a7e43f32")
            os.makedirs(d)
            open(os.path.join(d, "__data"), "wb").write(b"UnityFS")
            s = ex.run(root, out, lambda b: "model", loader=loader, log=lambda *a, **k: None)
            self.assertEqual(s["exported"], 1)
            self.assertEqual(s["files"], {"model": 1, "text": 2})
            self.assertEqual(len(s["errors"]), 1)
            dest = os.path.join(out, "model", "cos90")
            for f in ("cos90.obj", "cos90.mtl", "cos90_0.png", "cos90_preview.png", "tbl.dec", "inner_table.dec"):
                self.assertTrue(os.path.exists(os.path.join(dest, f)), f)
            self.assertEqual(open(os.path.join(dest, "tbl.dec"), "rb").read(), data)
            self.assertEqual(open(os.path.join(dest, "inner_table.dec"), "rb").read(), b"plain inner")  # inner assets stay plain
            self.assertIn("f 1/1 2/2 3/3", open(os.path.join(dest, "cos90.obj")).read())
            again = ex.run(root, out, lambda b: "model", loader=loader, log=lambda *a, **k: None)
            self.assertEqual((again["exported"], again["skipped"]), (0, 1))
            self.assertEqual(json.load(open(os.path.join(dest, ".export.json")))["version"], "a7e43f32")

    def test_filters(self):
        with tempfile.TemporaryDirectory() as root, tempfile.TemporaryDirectory() as out:
            for b in ("BGM_1", "Mob_1"):
                d = os.path.join(root, b, "0" * 32)
                os.makedirs(d)
                open(os.path.join(d, "__data"), "wb").write(b"UnityFS")
            cat = {"BGM_1": "audio", "Mob_1": "model"}
            s = ex.run(root, out, cat.get, only=("audio",), loader=lambda p: Env([]), log=lambda *a, **k: None)
            self.assertEqual(s["bundles"], 1)


if __name__ == "__main__":
    unittest.main()
