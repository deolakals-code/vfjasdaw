"""Repo-relative locations. Override with env TORAM_BIGDATA (data root) and TORAM_STATE (snapshots, reports)."""
import os
import sys

REPO = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
BIGDATA = os.environ.get("TORAM_BIGDATA") or os.path.join(REPO, "TORAM ONLINE BIGDATA")
DECODED = os.path.join(BIGDATA, "data", "decoded")
MASTERS = os.path.join(BIGDATA, "readable", "masters")
TOOLS = os.path.join(BIGDATA, "tools")
STATE = os.environ.get("TORAM_STATE") or os.path.join(BIGDATA, "state")

# one decoder / text-parser implementation lives in tools/common.py
if TOOLS not in sys.path:
    sys.path.insert(0, TOOLS)
