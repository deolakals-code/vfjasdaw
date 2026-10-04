import os
import struct
import sys
import unittest

sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
from toramre.brain import grammar as G, guard, synth  # noqa: E402


def make_table(n, seed=1):
    """count u32 x [i32 id, u8 tag, tag 1: i32 / tag 2: i16, list(u8)[i16]] - a layout the synthesizer must find."""
    import random
    r = random.Random(seed)
    out = struct.pack("<I", n)
    for i in range(n):
        tag = r.choice((1, 2))
        out += struct.pack("<iB", 1000 + i, tag) + (struct.pack("<i", r.randint(0, 9999)) if tag == 1 else struct.pack("<h", r.randint(0, 99)))
        k = r.randint(0, 3)
        out += bytes([k]) + b"".join(struct.pack("<h", r.randint(0, 500)) for _ in range(k))
    return out


class Grammar(unittest.TestCase):
    def test_parse_exact_eof(self):
        s = {"header": {"count": "u8"}, "record": [{"t": "u16"}, {"t": "list", "count": "u8", "elem": [{"t": "raw", "n": 2}]}]}
        self.assertEqual(G.parse(bytes([2, 1, 0, 1, 9, 9, 2, 0, 0]), s), [[1, [[b"\t\t"]]], [2, []]])
        self.assertFalse(G.fits(bytes([2, 1, 0, 1, 9, 9, 2, 0, 0, 7]), s))

    def test_switch_and_str(self):
        s = {"header": {"count": "none"}, "record": [{"t": "switch", "tag": "u8", "cases": {"1": [{"t": "str", "len": "v7"}], "2": [{"t": "i16"}]}}]}
        d = bytes([1, 2]) + b"hi" + bytes([2, 5, 0])
        self.assertEqual(G.parse(d, s), [[[1, ["hi"]]], [[2, [5]]]])
        self.assertIn("switch(u8)", G.describe(s))


class Synthesis(unittest.TestCase):
    def test_finds_layout_on_two_versions(self):
        vers = [make_table(300, 1), make_table(340, 2)]
        found = synth.synthesize(vers)
        self.assertTrue(found, "no schema found")
        best, how, conf, st = found[0]
        self.assertEqual(conf, "strong")
        self.assertEqual(st["records"], 340)
        for v in vers:
            self.assertTrue(G.fits(v, best))

    def test_random_bytes_are_not_strong(self):
        import random
        r = random.Random(3)
        blob = bytes(r.randrange(256) for _ in range(600))
        self.assertFalse(any(c == "strong" for _, _, c, _ in synth.synthesize([blob])))


class Guard(unittest.TestCase):
    def test_boundaries(self):
        with self.assertRaises(guard.Boundary):
            guard.check_path("apk/lib/arm64-v8a/libxigncode.so")
        with self.assertRaises(guard.Boundary):
            guard.check_data("blob", os.urandom(8192))
        with self.assertRaises(guard.Boundary):
            guard.check_url("https://example.com/RevisionInfoBinary.bytes")
        guard.check_url("https://toram-jp.akamaized.net/resources/android/releaseA/RevisionInfoBinary.bytes")
        guard.check_data("table", bytes(8192))


if __name__ == "__main__":
    unittest.main()


class SchemaDiff(unittest.TestCase):
    def test_watch_uses_learned_schema(self):
        import tempfile
        from toramre.brain import kb
        from toramre.watch import diff
        sch = {"header": {"count": "u32"}, "record": [{"t": "i32"}, {"t": "list", "count": "u8", "elem": [{"t": "i16"}]}],
               "names": ["Id", "Mats"]}
        rec = lambda i, m: struct.pack("<iB", i, len(m)) + b"".join(struct.pack("<h", x) for x in m)  # noqa: E731
        a = struct.pack("<I", 2) + rec(1, [5]) + rec(2, [])
        b = struct.pack("<I", 3) + rec(1, [6]) + rec(2, []) + rec(3, [1, 2])
        with tempfile.TemporaryDirectory() as root:
            for v, d in (("00000001", a), ("00000002", b)):
                os.makedirs(os.path.join(root, "BynaryData", v))
                with open(os.path.join(root, "BynaryData", v, "T.dec"), "wb") as f:
                    f.write(d)
            orig = kb.load
            kb.load = lambda t: {"schema": sch} if t == "T" else None
            try:
                ev = diff.compare_tables("BynaryData", "00000001", "00000002", {"T": {"sha": "x"}}, {"T": {"sha": "y"}}, root)
            finally:
                kb.load = orig
        self.assertEqual(ev[0].tag, "CHANGED")
        self.assertIn("+1 -0 ~1 records (schema)", ev[0].detail)
        self.assertIn("fields changed: Mats", ev[0].detail)
