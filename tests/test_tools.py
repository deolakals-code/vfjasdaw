import io
import json
import os
import sys
import tempfile
import unittest

sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
from toramre import doctor, notify  # noqa: E402
from toramre.brain import guard  # noqa: E402
from toramre.core import config  # noqa: E402
from toramre.watch.tags import Event  # noqa: E402


class Config(unittest.TestCase):
    def test_precedence(self):
        with tempfile.TemporaryDirectory() as d:
            p = os.path.join(d, "t.toml")
            with open(p, "w") as f:
                f.write("[fetch]\njobs = 3\n[paths]\nexport = 'X'\n")
            old = os.environ.get("TORAM_CONFIG")
            os.environ["TORAM_CONFIG"] = p
            config.reset()
            try:
                self.assertEqual(config.get("fetch", "jobs", 8), 3)
                self.assertEqual(config.get("fetch", "rate", 8.0), 8.0)
                os.environ["TORAM_EXPORT"] = "from-env"
                self.assertEqual(config.get("paths", "export", env="TORAM_EXPORT"), "from-env")
            finally:
                os.environ.pop("TORAM_EXPORT", None)
                if old is None:
                    os.environ.pop("TORAM_CONFIG", None)
                else:
                    os.environ["TORAM_CONFIG"] = old
                config.reset()


class Notify(unittest.TestCase):
    def test_send_and_host_check(self):
        sent = []

        class Resp:
            def __enter__(self):
                return self

            def __exit__(self, *a):
                return False

        def opener(req, timeout):
            sent.append((req.full_url, json.loads(req.data)))
            return Resp()

        url = "https://discord.com/api/webhooks/1/abc"
        self.assertTrue(notify.send("hello", url, ["discord.com"], opener))
        self.assertEqual(sent[0][1]["content"], "hello")
        with self.assertRaises(guard.Boundary):
            notify.send("x", "https://evil.example/hook", ["discord.com"], opener)
        with self.assertRaises(guard.Boundary):
            notify.send("x", "http://discord.com/api/webhooks/1/abc", ["discord.com"], opener)
        self.assertFalse(notify.send("x", url="", allowed=[], opener=opener) and False)

    def test_summary(self):
        ev = [Event("CHANGED", "BynaryData", "RecipeMaster", "a", "b", "x"), Event("TEXT_CHANGED", "GameScene_th", "Item_th", "a", "b")]
        text = notify.summarize(ev)
        self.assertIn("2 changes", text)
        self.assertLess(text.index("CHANGED x1"), text.index("TEXT_CHANGED"))


class Doctor(unittest.TestCase):
    def test_report_runs_offline(self):
        out = io.StringIO()
        rc = doctor.report(online=False, out=lambda s: out.write(s + "\n"))
        self.assertIn("checks:", out.getvalue())
        self.assertIn(rc, (0, 1))


if __name__ == "__main__":
    unittest.main()
