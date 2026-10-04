"""toramre command line. Subcommands are added phase by phase (see the plan in PROJECT.md "Program")."""
import argparse
import os
import sys

from toramre.core import paths
from toramre.watch import diff, report, snapshot


def cmd_watch(a):
    snap = snapshot.take()
    snapshot.save(snap, os.path.join(paths.STATE, "snapshot_latest.json"))
    events = diff.diff_snapshot(snap, since=a.since)
    base = os.path.join(paths.STATE, "extra_baseline.json")
    if os.path.exists(base):
        import json
        events += diff.diff_extra(json.load(open(base)), snap["extra"])
    out = a.out or paths.STATE
    report.write(events, out)
    for tag, evs in report.summarize(events).items():
        print(f"{tag:15} {len(evs)}")
    print(f"{len(events)} events -> {os.path.join(out, 'CHANGES.md')}")
    return 1 if report.exceeds(events, a.fail_on) else 0


def main(argv=None):
    p = argparse.ArgumentParser(prog="toramre", description=__doc__)
    sub = p.add_subparsers(dest="cmd", required=True)
    w = sub.add_parser("watch", help="tag what changed between consecutive data versions")
    w.add_argument("--since", help="only pairs whose newer version is this version or later (8 hex chars)")
    w.add_argument("--out", help="report directory (default: state/)")
    w.add_argument("--fail-on", choices=["low", "medium", "high"], default="high", help="exit 1 when an event of this level exists")
    w.set_defaults(fn=cmd_watch)
    a = p.parse_args(argv)
    return a.fn(a)


if __name__ == "__main__":
    sys.exit(main())
