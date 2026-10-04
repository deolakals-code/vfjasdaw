import os
import sys
import tempfile
import unittest

sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
from toramre.balance import api, diff, polarity, snapshot, textnums  # noqa: E402
from toramre.core import paths  # noqa: E402


class Polarity(unittest.TestCase):
    def test_table(self):
        self.assertEqual(polarity.verdict("rate", "rate", 400, 450), "BUFF")
        self.assertEqual(polarity.verdict("rate", "rate", 400, 350), "NERF")
        self.assertEqual(polarity.verdict("recipe", "releaseLv", 300, 270), "BUFF")   # lower level needed
        self.assertEqual(polarity.verdict("recipe", "difficulty", 10, 20), "NERF")
        self.assertEqual(polarity.verdict("registlet", "enhancePowder", 100, 150), "NERF")
        self.assertEqual(polarity.verdict("buff", "AstuteBuf/timer", 5, 10), "BUFF")
        self.assertEqual(polarity.verdict("buff", "AstuteBuf/param:CrtUp", 25, 20), "NERF")

    def test_unknown_is_neutral(self):
        self.assertEqual(polarity.verdict("skill", "SkillFlag", 0, 2), "NEUTRAL")
        self.assertEqual(polarity.verdict("buff", "X/param:Weird", 1, 5), "NEUTRAL")
        self.assertEqual(polarity.verdict("item", "Price", 100, 200), "NEUTRAL")

    def test_unset_zero_is_not_a_change_of_strength(self):
        self.assertEqual(polarity.verdict("item", "Stack", 0, 1), "NEUTRAL")
        self.assertEqual(polarity.verdict("item", "Stable", 50, 60), "BUFF")

    def test_function_counts_only_for_equipment(self):
        self.assertEqual(polarity.verdict("item", "Function", 10, 20, {"TypeId": 8}), "BUFF")
        self.assertEqual(polarity.verdict("item", "Function", 10, 20, {"TypeId": 1}), "NEUTRAL")

    def test_combine(self):
        self.assertEqual(polarity.combine(["BUFF", "BUFF", "NEUTRAL"]), "BUFF")
        self.assertEqual(polarity.combine(["BUFF", "NERF"]), "MIXED")
        self.assertEqual(polarity.combine(["NEUTRAL"]), "NEUTRAL")


class Diff(unittest.TestCase):
    def test_levels_mixed_and_summary(self):
        old = {"33": {"rate": [100, 110, 120], "flat": [10, 10, 10]}}
        new = {"33": {"rate": [100, 130, 150], "flat": [10, 10, 8]}, "34": {"rate": [1]}}
        r = diff.compare("rate", old, new)
        e = r["changed"]["33"]
        self.assertEqual(e["verdict"], "MIXED")
        rate = next(c for c in e["changes"] if c["field"] == "rate")
        self.assertEqual(rate["verdict"], "BUFF")
        self.assertEqual([l["level"] for l in rate["levels"]], [2, 3])
        self.assertEqual(diff.summarize_levels(rate), "Lv2-3: +20 to +30")
        self.assertEqual(r["added"], ["34"])

    def test_missing_before_gives_no_verdict(self):
        c = diff.field_change("rate", "rate", None, 120)
        self.assertEqual(c["verdict"], "NEUTRAL")
        self.assertIsNone(c["delta"])

    def test_equal_gives_nothing(self):
        self.assertIsNone(diff.field_change("rate", "rate", [1, 2], [1, 2]))
        self.assertEqual(diff.compare("rate", {"1": {"rate": [1]}}, {"1": {"rate": [1]}})["changed"], {})


class TextNumbers(unittest.TestCase):
    def test_cost_and_power(self):
        r = textnums.compare("*MP ที่ใช้-100\n*พลัง+50", "*MP ที่ใช้-120\n*พลัง+40")
        self.assertEqual([x["verdict"] for x in r], ["BUFF", "NERF"])
        self.assertEqual(r[0]["context"], "*MP ที่ใช้")

    def test_reworded_text_is_not_a_number_change(self):
        self.assertEqual(textnums.compare("พลัง+50", "พลังเพิ่ม+50"), [])
        self.assertEqual(textnums.compare("x 1", "x 1"), [])

    def test_unknown_words_are_neutral(self):
        self.assertEqual(textnums.compare("อัตราติดผงะ+50%", "อัตราติดผงะ+60%")[0]["verdict"], "NEUTRAL")


class Snapshots(unittest.TestCase):
    def test_roundtrip_and_compare(self):
        with tempfile.TemporaryDirectory() as d:
            base = {"label": "A", "build": "b1", "data_version": "x", "taken": "2026-10-01 00:00",
                    "rate": {"33": {"rate": [100, 110], "flat": [5, 5]}}, "buff": {"34": {"AstuteBuf/timer": [5, 5]}}}
            new = {**base, "label": "B", "taken": "2026-10-02 00:00",
                   "rate": {"33": {"rate": [100, 100], "flat": [5, 5]}}, "buff": {"34": {"AstuteBuf/timer": [5, 10]}}}
            snapshot.save(base, d)
            snapshot.save(new, d)
            self.assertEqual(snapshot.labels(d), ["A", "B"])
            entries = api.snapshot_entries("A", "B", d)
            by = {(e["source"], e["id"]): e["verdict"] for e in entries}
            self.assertEqual(by[("rate", "33")], "NERF")
            self.assertEqual(by[("buff", "34")], "BUFF")
            self.assertEqual(api.latest_verdict(entries, "skill"), {"33": "NERF", "34": "BUFF"})
            self.assertIn("Lv2 110 -> 100", api.describe(entries[0]) + api.describe(entries[1]))


@unittest.skipUnless(os.path.isdir(paths.DECODED), "decoded data not present")
class RealHistory(unittest.TestCase):
    def test_recipe_release_level_buff(self):
        """dad0fc31 -> 0b170732: 20 recipes need a lower level (RecipeMaster releaseLv)."""
        es = [e for e in api.data_entries("recipe") if e["to"] == "0b170732" and e["verdict"] == "BUFF"]
        self.assertEqual(len(es), 20)
        e = next(e for e in es if e["id"] == "30005")
        self.assertEqual((e["changes"][0]["field"], e["changes"][0]["before"], e["changes"][0]["after"]), ("releaseLv", 300, 270))

    def test_skill_added_between_versions(self):
        es = [e for e in api.data_entries("skill") if e["verdict"] == "ADDED"]
        self.assertEqual(len(es), 13)

    def test_every_data_table_parses_all_versions(self):
        for kind in ("skill", "item", "recipe", "registlet"):
            self.assertGreaterEqual(len(api.history.states(kind)), 20)

    def test_watch_events_are_buff_nerf_mixed_only(self):
        ev = api.events()
        self.assertTrue(ev)
        self.assertTrue(all(e.tag in ("BUFF", "NERF", "MIXED") for e in ev))


if __name__ == "__main__":
    unittest.main()
