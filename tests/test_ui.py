import json
import os
import re
import sys
import unittest

sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
from toramre.core import paths  # noqa: E402
from toramre.ui import build  # noqa: E402


@unittest.skipUnless(os.path.isdir(paths.DECODED), "decoded data not present")
class Dashboard(unittest.TestCase):
    def test_embeds_data_and_matrix_matches_events(self):
        data = build.collect()
        page = build.render(data)
        self.assertNotIn(build.MARK, page)
        blob = re.search(r"const DATA = (\{.*?\});\n", page, re.S).group(1)
        self.assertEqual(json.loads(blob.replace("<\\/", "</"))["generated"], data["generated"])
        bd = data["bundles"]["BynaryData"]
        changed_cells = sum(1 for t in bd["tables"] for st, _ in bd["cells"][t] if st == "changed")
        changed_events = sum(1 for e in data["events"] if e["bundle"] == "BynaryData" and e["tag"] in ("CHANGED", "LAYOUT_BROKEN"))
        self.assertEqual(changed_cells, changed_events)

    def test_fragment_has_no_document_wrapper(self):
        page = build.render({"generated": "x", "bundles": {}, "events": [], "extra": {}}, standalone=False)
        self.assertFalse(page.lstrip().lower().startswith("<!doctype"))
        self.assertIn("<title>Toram Data Watch</title>", page[:8192])


if __name__ == "__main__":
    unittest.main()
