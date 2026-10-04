import json
import os
import sys
import threading
import unittest
import urllib.error
import urllib.request

sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
from toramre.core import paths  # noqa: E402
from toramre.viewer import server  # noqa: E402
from toramre.viewer.store import Store, clean_name, norm  # noqa: E402


class Names(unittest.TestCase):
    def test_clean_name(self):
        self.assertEqual(clean_name("[N]A[N2]B[N]"), "A / B")
        self.assertEqual(clean_name("N$Sonic Blade$R2$Super Sonic Blade"), "Sonic Blade / Super Sonic Blade")
        self.assertEqual(clean_name("First Aid"), "First Aid")
        self.assertEqual(norm("Hard Hit"), "hardhit")


@unittest.skipUnless(os.path.isdir(paths.DECODED), "data not present")
class RealStore(unittest.TestCase):
    @classmethod
    def setUpClass(cls):
        cls.s = Store()

    def test_search_finds_across_languages_and_spacing(self):
        r = self.s.search("hardhit")
        self.assertEqual(r["skill"][0]["id"], "33")
        self.assertEqual(self.s.search("hard hit", lang="us")["skill"][0]["name"], "Hard Hit")
        self.assertEqual(self.s.search("ฮาร์ดฮิต")["skill"][0]["id"], "33")
        self.assertEqual(self.s.search("zzzz-no-such-thing"), {})

    def test_exact_match_ranks_first(self):
        self.assertEqual(self.s.search("1000", types=["item"])["item"][0]["id"], "1000")

    def test_links_both_ways(self):
        item = self.s.entity("item", "14108")
        rec = [l for l in item["links"] if l["rel"] == "made by"]
        self.assertTrue(rec)
        back = self.s.entity("recipe", rec[0]["id"])
        self.assertIn(("item", "14108", "makes"), [(l["type"], l["id"], l["rel"]) for l in back["links"]])
        sk = self.s.entity("skill", "33")
        reg = [l for l in sk["links"] if l["type"] == "registlet"]
        self.assertTrue(reg)
        self.assertIn(("skill", "33"), [(l["type"], l["id"]) for l in self.s.entity("registlet", reg[0]["id"])["links"]])
        prem = self.s.entity("skill", "34")
        self.assertIn(("skill", "33", "needs"), [(l["type"], l["id"], l["rel"]) for l in prem["links"]])

    def test_language_fallback(self):
        self.assertTrue(self.s.name("skill", "33", "kr"))
        self.assertEqual(self.s.name("skill", "33", "us"), "Hard Hit")

    def test_unknown_entity(self):
        self.assertIsNone(self.s.entity("skill", "99999"))


@unittest.skipUnless(os.path.isdir(paths.DECODED), "data not present")
class Api(unittest.TestCase):
    @classmethod
    def setUpClass(cls):
        cls.srv = server.make_server(0)
        cls.port = cls.srv.server_port
        threading.Thread(target=cls.srv.serve_forever, daemon=True).start()

    @classmethod
    def tearDownClass(cls):
        cls.srv.shutdown()
        cls.srv.server_close()

    def get(self, path):
        try:
            with urllib.request.urlopen(f"http://127.0.0.1:{self.port}{path}") as r:
                return r.status, r.headers, r.read()
        except urllib.error.HTTPError as e:
            return e.code, e.headers, e.read()

    def j(self, path):
        code, _, body = self.get(path)
        return code, json.loads(body)

    def test_binds_loopback_only(self):
        self.assertEqual(self.srv.server_address[0], "127.0.0.1")

    def test_routes(self):
        self.assertEqual(self.j("/api/meta")[1]["counts"]["skill"], 577)
        code, e = self.j("/api/entity/recipe/30005?lang=us")
        self.assertEqual(code, 200)
        self.assertIn("balance", e)
        self.assertEqual(self.j("/api/entity/skill/99999")[0], 404)
        self.assertEqual(self.j("/api/nope")[0], 404)
        code, b = self.j("/api/balance?verdict=BUFF&kind=recipe&limit=3")
        self.assertEqual((code, len(b["rows"])), (200, 3))
        self.assertEqual(b["total"], 20)
        code, c = self.j("/api/compare?a=33&b=34")
        self.assertIn("level_notes", c["differs"])
        self.assertEqual(self.j("/api/compare?a=33&b=x")[0], 404)

    def test_static_and_traversal(self):
        self.assertEqual(self.get("/..%2f..%2fetc%2fpasswd")[0], 404)
        self.assertEqual(self.get("/%2e%2e/%2e%2e/etc/passwd")[0], 404)

    def test_skill_list_filters_by_verdict(self):
        code, r = self.j("/api/skills?q=hard&lang=us")
        self.assertEqual(r["rows"][0]["id"], "33")


if __name__ == "__main__":
    unittest.main()


class Calc(unittest.TestCase):
    def test_proration_matches_the_documented_example(self):
        from toramre.viewer import calc
        h = calc.proration((10, 5, 10), ["Normal", "Skill", "Magic"])
        self.assertEqual(h[0]["state_after"], {"Normal": 90, "Skill": 105, "Magic": 110})
        self.assertEqual(h[2]["state_after"], {"Normal": 110, "Skill": 105, "Magic": 110})
        self.assertEqual(h[0]["multiplier_before"], 1.0)
        self.assertEqual(h[0]["multiplier_after"], 0.9)

    def test_proration_rejects_bad_input(self):
        from toramre.viewer import calc
        for steps, hits in (((10, 5), ["Normal"]), ((10, 5, 10), []), ((10, 5, 10), ["Bogus"]), ((-1, 5, 10), ["Normal"]),
                            ((10, 5, 10), ["Normal"] * 201)):
            with self.assertRaises(ValueError):
                calc.proration(steps, hits)

    def test_claims_status_and_storage(self):
        import tempfile
        from toramre.viewer import calc
        with tempfile.TemporaryDirectory() as d:
            p = os.path.join(d, "claims.json")
            a = calc.add_claim("proration", {"hit": 1}, 0.9, 0.9, path=p)
            b = calc.add_claim("proration", {"hit": 2}, 1.0, 0.8, "off", path=p)
            self.assertEqual((a["status"], b["status"]), ("In-game", "Mismatch"))
            self.assertEqual(len(calc.load_claims(p)), 2)
            with self.assertRaises(ValueError):
                calc.add_claim("nope", {}, 1, 1, path=p)
            with self.assertRaises(ValueError):
                calc.add_claim("proration", {}, "x", 1, path=p)

    def test_capabilities_name_the_blockers(self):
        from toramre.viewer import calc
        c = calc.capabilities()
        self.assertTrue(c["proration"]["available"])
        self.assertIn("D:", c["damage"]["reason"] + c["status"]["reason"])


@unittest.skipUnless(os.path.isdir(paths.DECODED), "data not present")
class PostSecurity(unittest.TestCase):
    @classmethod
    def setUpClass(cls):
        from toramre.viewer import calc
        import tempfile
        cls.tmp = tempfile.mkdtemp()
        cls.old = calc.CLAIMS
        calc.CLAIMS = os.path.join(cls.tmp, "claims.json")
        cls.srv = server.make_server(0)
        cls.port = cls.srv.server_port
        threading.Thread(target=cls.srv.serve_forever, daemon=True).start()

    @classmethod
    def tearDownClass(cls):
        from toramre.viewer import calc
        calc.CLAIMS = cls.old
        cls.srv.shutdown()
        cls.srv.server_close()

    def post(self, body, headers):
        req = urllib.request.Request(f"http://127.0.0.1:{self.port}/api/claims", data=json.dumps(body).encode(), headers=headers)
        try:
            with urllib.request.urlopen(req) as r:
                return r.status
        except urllib.error.HTTPError as e:
            return e.code

    def test_post_needs_the_header_and_json(self):
        body = {"tool": "proration", "computed": 1, "seen": 1}
        self.assertEqual(self.post(body, {"Content-Type": "application/json"}), 403)               # no custom header
        self.assertEqual(self.post(body, {"X-Toramre": "1", "Content-Type": "text/plain"}), 403)    # not JSON
        self.assertEqual(self.post(body, {"X-Toramre": "1", "Content-Type": "application/json"}), 200)
        self.assertEqual(self.post({"tool": "x"}, {"X-Toramre": "1", "Content-Type": "application/json"}), 400)

    def test_other_post_paths_are_refused(self):
        req = urllib.request.Request(f"http://127.0.0.1:{self.port}/api/search", data=b"{}", headers={"X-Toramre": "1", "Content-Type": "application/json"})
        with self.assertRaises(urllib.error.HTTPError) as cm:
            urllib.request.urlopen(req)
        self.assertEqual(cm.exception.code, 403)
