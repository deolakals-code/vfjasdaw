"""Local web viewer: JSON API + static single page, bound to 127.0.0.1 only. Read-only (the one write is the claims file
in phase 4). `python -m toramre viewer`."""
import functools
import http.server
import json
import mimetypes
import os
import threading
import webbrowser
from urllib.parse import parse_qs, unquote, urlparse

from toramre.balance import api as balance, snapshot
from toramre.core import paths, versions as V
from . import calc
from .store import LANGS, TYPES, Store

WEB = os.path.join(os.path.dirname(os.path.abspath(__file__)), "web")
BALANCE_KIND = {"skill": "skill", "item": "item", "recipe": "recipe", "registlet": "registlet"}
LIMITS = ("Skill multipliers and buff tables exist for one decoded build only; their history starts with the first snapshot "
          "(`toramre balance snapshot`). Master-table and text changes go back to the first kept data version.")


class App:
    def __init__(self, store=None, balance_dir=None):
        self.store = store or Store()
        self.balance_dir = balance_dir
        self._entries = None
        self.lock = threading.Lock()

    def entries(self):
        with self.lock:
            if self._entries is None:
                self._entries = balance.all_entries(directory=self.balance_dir)
            return self._entries

    # ---- API handlers: return (status, json-able) -------------------------------------------------------
    def meta(self, q):
        s = self.store
        dv = V.list_versions("BynaryData")
        return 200, {"langs": LANGS, "types": TYPES, "data_versions": dv, "newest": dv[-1] if dv else None,
                     "counts": {t: len(list(s._all_ids(t))) for t in TYPES}, "snapshots": snapshot.labels(self.balance_dir),
                     "balance_note": LIMITS}

    def search(self, q):
        types = [t for t in q.get("types", "").split(",") if t in TYPES] or None
        return 200, {"query": q.get("q", ""), "results": self.store.search(q.get("q", ""), q.get("lang", "th"), types,
                                                                              min(int(q.get("limit", 20)), 100))}

    def entity(self, typ, ident, q):
        lang = q.get("lang", "th")
        e = self.store.entity(typ, unquote(ident), lang) if typ in TYPES else None
        if not e:
            return 404, {"error": f"no {typ} {ident}"}
        if typ in BALANCE_KIND:
            e["balance"] = self._for_entity(typ, ident)
        return 200, e

    def _for_entity(self, typ, ident):
        es = [e for e in self.entries() if e["kind"] == typ and e["id"] == str(ident)]
        es.sort(key=lambda e: (V.rank(e["to"])), reverse=True)
        return {"entries": es, "note": LIMITS if typ == "skill" else ""}

    def balance_for(self, typ, ident, q):
        if typ not in BALANCE_KIND:
            return 404, {"error": f"no balance data for {typ}"}
        return 200, self._for_entity(typ, ident)

    def balance_list(self, q):
        kind, verdicts = q.get("kind"), {v.upper() for v in q.get("verdict", "").split(",") if v}
        to = q.get("version")
        lang = q.get("lang", "th")
        rows = []
        for e in self.entries():
            if kind and e["kind"] != kind or verdicts and e["verdict"] not in verdicts or to and e["to"] != to:
                continue
            rows.append({**e, "name": self.store.name(e["kind"], e["id"], lang), "line": balance.describe(e)})
        rows.sort(key=lambda e: (V.rank(e["to"]), e["kind"], e["id"]), reverse=True)
        total = len(rows)
        return 200, {"total": total, "rows": rows[:min(int(q.get("limit", 200)), 1000)],
                     "versions": sorted({e["to"] for e in self.entries()}, key=lambda v: V.rank(v),
                                        reverse=True)}

    def skills(self, q):
        lang, text = q.get("lang", "th"), (q.get("q") or "").strip().lower()
        verdict = balance.latest_verdict(self.entries(), "skill")
        want = {v.upper() for v in q.get("verdict", "").split(",") if v}
        rows = []
        for uid, r in self.store.skills.items():
            name = self.store.name("skill", uid, lang)
            if text and text not in (uid + " " + name + " " + r.get("name_en", "")).lower():
                continue
            v = verdict.get(uid, "")
            if want and v not in want:
                continue
            rows.append({"id": uid, "name": name, "category": r.get("category", ""), "tree": r.get("tree", ""), "verdict": v})
        rows.sort(key=lambda r: int(r["id"]))
        return 200, {"total": len(rows), "rows": rows[:min(int(q.get("limit", 600)), 1000)]}

    def compare(self, q):
        lang = q.get("lang", "th")
        a, b = (self.store.entity("skill", q.get(k, ""), lang) for k in ("a", "b"))
        if not a or not b:
            return 404, {"error": "both ?a= and ?b= must be skill ids"}
        keys = sorted(set(a["fields"]) | set(b["fields"]))
        diff = [k for k in keys if a["fields"].get(k) != b["fields"].get(k)]
        return 200, {"a": a, "b": b, "differs": diff}

    def calc_proration(self, q):
        hits = [h for h in q.get("hits", "").split(",") if h]
        if q.get("monster"):
            row = self.store.monster_row(q["monster"])
            if not row:
                return 404, {"error": f"no monster {q['monster']}"}
            steps = calc.steps_for_monster(row)
            who = self.store.name("monster", q["monster"], q.get("lang", "th"))
        else:
            steps = tuple(int(x) for x in q.get("steps", "").split(",") if x != "")
            who = ""
        return 200, {"monster": who, "steps": steps, "hits": calc.proration(steps, hits)}

    def claims(self, body=None):
        if body is None:
            return 200, {"claims": calc.load_claims()}
        e = calc.add_claim(body.get("tool", ""), body.get("inputs", {}), body.get("computed"), body.get("seen"), body.get("note", ""))
        return 200, e

    # ---- routing ----------------------------------------------------------------------------------------
    def route(self, path, q):
        parts = [p for p in path.split("/") if p]
        if parts[:1] != ["api"]:
            return None
        parts = parts[1:]
        try:
            if parts == ["meta"]:
                return self.meta(q)
            if parts == ["search"]:
                return self.search(q)
            if parts == ["skills"]:
                return self.skills(q)
            if parts == ["compare"]:
                return self.compare(q)
            if parts == ["balance"]:
                return self.balance_list(q)
            if parts == ["calc", "capabilities"]:
                return 200, calc.capabilities()
            if parts == ["calc", "proration"]:
                return self.calc_proration(q)
            if parts == ["claims"]:
                return self.claims()
            if len(parts) == 3 and parts[0] == "balance":
                return self.balance_for(parts[1], parts[2], q)
            if len(parts) == 3 and parts[0] == "entity":
                return self.entity(parts[1], parts[2], q)
        except (ValueError, KeyError) as e:
            return 400, {"error": f"{type(e).__name__}: {e}"}
        return 404, {"error": "unknown route"}


class Handler(http.server.BaseHTTPRequestHandler):
    app = None

    def log_message(self, *a):
        pass

    def _send(self, code, body, ctype):
        self.send_response(code)
        self.send_header("Content-Type", ctype)
        self.send_header("Content-Length", str(len(body)))
        self.send_header("Cache-Control", "no-store")
        self.send_header("X-Content-Type-Options", "nosniff")
        self.end_headers()
        self.wfile.write(body)

    def do_POST(self):
        u = urlparse(self.path)
        # a browser page on another site cannot send this header without a CORS preflight, which this server never answers
        if u.path != "/api/claims" or self.headers.get("X-Toramre") != "1" or "json" not in (self.headers.get("Content-Type") or ""):
            return self._send(403, b'{"error":"forbidden"}', "application/json")
        n = int(self.headers.get("Content-Length") or 0)
        if n <= 0 or n > 20000:
            return self._send(400, b'{"error":"bad body"}', "application/json")
        try:
            code, obj = self.app.claims(json.loads(self.rfile.read(n)))
        except (ValueError, TypeError) as e:
            code, obj = 400, {"error": str(e)}
        self._send(code, json.dumps(obj, ensure_ascii=False).encode("utf-8"), "application/json; charset=utf-8")

    def do_GET(self):
        u = urlparse(self.path)
        q = {k: v[0] for k, v in parse_qs(u.query).items()}
        r = self.app.route(u.path, q)
        if r is not None:
            code, obj = r
            return self._send(code, json.dumps(obj, ensure_ascii=False).encode("utf-8"), "application/json; charset=utf-8")
        rel = "index.html" if u.path in ("/", "") else unquote(u.path).lstrip("/")
        full = os.path.normpath(os.path.join(WEB, rel))
        if not full.startswith(WEB + os.sep) or not os.path.isfile(full):
            return self._send(404, b'{"error":"not found"}', "application/json")
        ctype = mimetypes.guess_type(full)[0] or "application/octet-stream"
        with open(full, "rb") as f:
            self._send(200, f.read(), ctype + ("; charset=utf-8" if ctype.startswith("text/") or ctype.endswith("javascript") else ""))


def make_server(port=8777, app=None):
    handler = type("H", (Handler,), {"app": app or App()})
    return http.server.ThreadingHTTPServer(("127.0.0.1", port), handler)


def warm(app):
    """Load the heavy parts in the background so the first click is not slow."""
    def run():
        try:
            app.store._index()
            app.entries()
        except Exception as e:  # the API reports the same error when asked; the viewer still starts
            print(f"warm-up failed: {type(e).__name__}: {e}")
    threading.Thread(target=run, daemon=True).start()


def serve(port=8777, open_browser=True):
    app = App()
    warm(app)
    srv = make_server(port, app)
    url = f"http://127.0.0.1:{srv.server_port}/"
    print(f"toramre viewer on {url}  (Ctrl+C to stop; local only)")
    if open_browser:
        threading.Timer(0.5, lambda: webbrowser.open(url)).start()
    try:
        srv.serve_forever()
    except KeyboardInterrupt:
        pass
    return 0


def selftest():
    """Start on a free port and request every route once (CI smoke test, no browser)."""
    import urllib.error
    import urllib.request
    app = App()
    srv = make_server(0, app)
    threading.Thread(target=srv.serve_forever, daemon=True).start()
    base = f"http://127.0.0.1:{srv.server_port}"

    def get(path):
        try:
            with urllib.request.urlopen(base + path) as r:
                return r.status, r.read()
        except urllib.error.HTTPError as e:
            return e.code, e.read()
    checks = [("/", 200), ("/app.js", 200), ("/app.css", 200), ("/api/meta", 200), ("/api/search?q=hit", 200), ("/api/skills", 200),
              ("/api/balance?limit=3", 200), ("/api/calc/capabilities", 200), ("/api/calc/proration?steps=10,5,10&hits=Normal,Skill", 200),
              ("/api/claims", 200), ("/api/entity/skill/99999", 404), ("/api/nope", 404), ("/..%2f..%2fetc%2fpasswd", 404)]
    bad = 0
    for path, want in checks:
        code, _ = get(path)
        ok = code == want
        bad += not ok
        print(f"{'ok ' if ok else 'BAD'} {code} {path}")
    srv.shutdown()
    return 1 if bad else 0
