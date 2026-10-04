"""Duplicate of scripts/cdn_fetch.py kept for old command lines; runs it (implementation: toramre/net)."""
import os
import runpy
import sys

repo = os.path.abspath(os.path.join(os.path.dirname(os.path.abspath(__file__)), "..", "..", ".."))
sys.argv[0] = os.path.join(repo, "scripts", "cdn_fetch.py")
runpy.run_path(sys.argv[0], run_name="__main__")
