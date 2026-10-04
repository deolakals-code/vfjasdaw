"""The BIGDATA build stages (tools/s1..s6) as named steps. Each stage is still its own script; this module only runs
them in order and stops at the first failure (a parser that does not reach the exact last byte raises)."""
import os
import subprocess
import sys

from toramre.core import paths

STAGES = {
    "extract": ("s1_extract_all.py", "decode every TextAsset of every cached bundle -> data/decoded (needs the game cache, env TORAM_CACHE)"),
    "cdn": ("s2_cdn_catalog.py", "download RevisionInfoBinary of CDN channels A-F -> data/cdn (network: public CDN only)"),
    "code": ("s3_code_readable.py", "split dump.cs.gz into readable/code"),
    "masters": ("s4_masters.py", "frame the newest BynaryData into readable/masters"),
    "text": ("s5_text_readable.py", "localized text tables -> readable/text TSV"),
    "history": ("s6_history.py", "per-version table inventory -> readable/masters/_history.csv"),
}
ORDER = ["extract", "cdn", "code", "masters", "text", "history"]


def run(name):
    script, _ = STAGES[name]
    print(f"== {name} ({script})", flush=True)
    return subprocess.run([sys.executable, os.path.join(paths.TOOLS, script)], cwd=paths.TOOLS).returncode


def run_all(names=None):
    for n in names or ORDER:
        rc = run(n)
        if rc:
            print(f"stage {n} failed with exit code {rc}; later stages not run", file=sys.stderr)
            return rc
    return 0
