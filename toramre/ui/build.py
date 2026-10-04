"""Build the dashboard: one self-contained HTML page (data embedded as JSON, no server, no network)."""
import csv
import json
import os
import time

from toramre.core import paths, versions
from toramre.watch import diff, snapshot

TEMPLATE = os.path.join(os.path.dirname(os.path.abspath(__file__)), "template.html")
MARK = "/*__TORAMRE_DATA__*/null"


def _dates():
    """version -> cached date, from readable/masters/_history.csv."""
    p = os.path.join(paths.MASTERS, "_history.csv")
    if not os.path.exists(p):
        return {}
    return {r["version"]: r["cached_date"] for r in csv.DictReader(open(p, encoding="utf-8"))}


def collect(snap=None, events=None):
    snap = snap or snapshot.take()
    events = events if events is not None else diff.diff_snapshot(snap)
    dates = _dates()
    bundles = {}
    for b, vers in snap["bundles"].items():
        order = [v for v in versions.list_versions(b) if v in vers]
        tables = sorted({t for v in order for t in vers[v]})
        cells = {}
        for t in tables:
            row, prev = [], None
            for v in order:
                c = vers[v].get(t)
                if c is None:
                    state = "absent"
                elif prev is None:
                    state = "first" if v == order[0] else "new"
                else:
                    state = "same" if c["sha"] == prev["sha"] else "changed"
                row.append([state, c["bytes"] if c else 0])
                prev = c if c else prev
            cells[t] = row
        bundles[b] = {"versions": [{"v": v, "date": dates.get(v, "")} for v in order], "tables": tables, "cells": cells}
    return {
        "generated": time.strftime("%Y-%m-%d %H:%M"),
        "bundles": bundles,
        "events": [e.as_dict() for e in events],
        "extra": snap.get("extra", {}),
    }


def render(data, standalone=True):
    page = open(TEMPLATE, encoding="utf-8").read()
    blob = json.dumps(data, ensure_ascii=False, separators=(",", ":")).replace("</", "<\\/")
    page = page.replace(MARK, blob)
    if standalone:
        page = ("<!doctype html><html lang=\"en\"><head><meta charset=\"utf-8\">"
                "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, viewport-fit=cover\"></head><body>"
                + page + "</body></html>")
    return page


def write(out_path, standalone=True, data=None):
    os.makedirs(os.path.dirname(os.path.abspath(out_path)), exist_ok=True)
    open(out_path, "w", encoding="utf-8").write(render(data or collect(), standalone))
    return out_path
