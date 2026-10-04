import csv
import json
import os
import struct
import sys
import tempfile
import unittest
from collections import Counter

sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
from toramre.core import paths, versions  # noqa: E402
from toramre.watch import diff, report, snapshot  # noqa: E402


def text_table(rows):
    """format A: <I count> x (<I id><B kind><7bit len><utf8>)"""
    out = struct.pack("<I", len(rows))
    for i, t in rows:
        b = t.encode()
        out += struct.pack("<IB", i, 0) + bytes([len(b)]) + b
    return out


def write_bundle(root, bundle, ver, files):
    d = os.path.join(root, bundle, ver)
    os.makedirs(d)
    for n, b in files.items():
        with open(os.path.join(d, n + ".dec"), "wb") as f:
            f.write(b)


class SyntheticTags(unittest.TestCase):
    def setUp(self):
        self.tmp = tempfile.TemporaryDirectory()
        r = self.tmp.name
        fixed = lambda recs: struct.pack("<I", len(recs)) + b"".join(recs)  # noqa: E731
        write_bundle(r, "BynaryData", "00000001", {
            "Same": fixed([b"\x01\x00\x00\x00" * 2] * 3),
            "Edit": fixed([b"\x01\x00\x00\x00" * 2] * 3),
            "Gone": fixed([b"\x09\x00\x00\x00" * 2] * 2)})
        write_bundle(r, "BynaryData", "00000002", {
            "Same": fixed([b"\x01\x00\x00\x00" * 2] * 3),
            "Edit": fixed([b"\x01\x00\x00\x00" * 2, b"\x07\x00\x00\x00" * 2, b"\x01\x00\x00\x00" * 2]),
            "New": fixed([b"\x02\x00\x00\x00" * 2] * 2)})
        write_bundle(r, "GameScene_th", "00000001", {"Item_th": text_table([(1, "a"), (2, "b")])})
        write_bundle(r, "GameScene_th", "00000002", {"Item_th": text_table([(1, "a"), (2, "B"), (3, "c")])})
        self.root = r

    def tearDown(self):
        self.tmp.cleanup()

    def events(self):
        return diff.diff_snapshot(snapshot.take(self.root), root=self.root)

    def test_tags(self):
        by = {(e.bundle, e.item): e.tag for e in self.events()}
        self.assertEqual(by[("BynaryData", "Edit")], "CHANGED")
        self.assertEqual(by[("BynaryData", "New")], "NEW")
        self.assertEqual(by[("BynaryData", "Gone")], "REMOVED")
        self.assertEqual(by[("GameScene_th", "Item_th")], "TEXT_CHANGED")
        self.assertNotIn(("BynaryData", "Same"), by)

    def test_record_and_row_detail(self):
        d = {e.item: e.detail for e in self.events()}
        self.assertIn("1 records differ", d["Edit"])
        self.assertIn("+1 -0 ~1 rows", d["Item_th"])

    def test_unchanged_pair_gives_no_events(self):
        self.assertEqual(diff.compare_tables("BynaryData", "a", "b", {"T": {"bytes": 1, "sha": "x"}},
                                             {"T": {"bytes": 1, "sha": "x"}}, self.root), [])

    def test_broken_text_layout_is_high_and_exit_code(self):
        p = os.path.join(self.root, "GameScene_th", "00000002", "Item_th.dec")
        with open(p, "rb") as f:
            data = f.read()
        with open(p, "wb") as f:
            f.write(data[:-1])  # one byte short: exact-EOF parse fails
        ev = self.events()
        self.assertIn("LAYOUT_BROKEN", [e.tag for e in ev])
        self.assertTrue(report.exceeds(ev, "high"))

    def test_binary_change(self):
        ev = diff.diff_extra({"so_sha256": "aaa"}, {"so_sha256": "bbb"})
        self.assertEqual([e.tag for e in ev], ["BINARY_CHANGED"])
        self.assertEqual(diff.diff_extra({"so_sha256": "aaa"}, {"so_sha256": "aaa"}), [])

    def test_report_files(self):
        out = os.path.join(self.root, "out")
        report.write(self.events(), out)
        self.assertTrue(os.path.exists(os.path.join(out, "CHANGES.md")))
        self.assertEqual(len(json.load(open(os.path.join(out, "changes.json")))), len(self.events()))


@unittest.skipUnless(os.path.isdir(paths.DECODED) and os.path.exists(os.path.join(paths.MASTERS, "_history.csv")),
                     "decoded data not present")
class RealDataReplay(unittest.TestCase):
    def test_matches_project_history(self):
        """Tags on the 20 real BynaryData versions must equal the 'changed' rows of readable/masters/_history.csv."""
        rows = list(csv.DictReader(open(os.path.join(paths.MASTERS, "_history.csv"))))
        want = Counter(r["table"] for r in rows if r["vs_previous"] == "changed")
        snap = snapshot.take()
        snap["bundles"] = {"BynaryData": snap["bundles"]["BynaryData"]}
        got = Counter(e.item for e in diff.diff_snapshot(snap) if e.tag in ("CHANGED", "LAYOUT_BROKEN"))
        self.assertEqual(got, want)

    def test_version_order_follows_history(self):
        """a7e43f32 is the newest data (PROJECT.md) although 6f304932 has the larger version number."""
        order = versions.list_versions("BynaryData")
        self.assertEqual(order[-1], "a7e43f32")
        self.assertLess(order.index("e8e43f32"), order.index("6f304932"))


if __name__ == "__main__":
    unittest.main()
