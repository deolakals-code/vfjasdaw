"""All change events in one list (data versions, balance verdicts, CDN version changes): used by `watch` and the viewer."""
import json
import os

from toramre.core import paths
from . import diff, snapshot
from .tags import Event


def cdn_events(path=None):
    p = path or os.path.join(paths.STATE, "cdn_changes.json")
    out = []
    if os.path.exists(p):
        with open(p, encoding="utf-8") as f:
            changes = json.load(f)
        for x in changes:
            data = x["key"] == "BynaryData" or x["key"].startswith(("Localize/", "FieldScript/"))
            tag = {"new": "NEW", "removed": "REMOVED"}.get(x["kind"], "CHANGED")
            out.append(Event(tag, f"cdn/{x['channel']}", x["key"], x["from"] or "-", x["to"] or "-",
                             "new data version on the CDN: run `toramre fetch get --only data,text --channel "
                             f"{x['channel']}`" if data else "bundle version changed on the CDN"))
    return out


def collect(since=None, balance=True, cdn=True, snap=None):
    """-> (events, snapshot)."""
    snap = snap or snapshot.take()
    events = diff.diff_snapshot(snap, since=since)
    base = os.path.join(paths.STATE, "extra_baseline.json")
    if os.path.exists(base):
        with open(base, encoding="utf-8") as f:
            events += diff.diff_extra(json.load(f), snap["extra"])
    if balance:
        from toramre.balance import api as balance_api
        events += balance_api.events(since=since)
    if cdn:
        events += cdn_events()
    return events, snap
