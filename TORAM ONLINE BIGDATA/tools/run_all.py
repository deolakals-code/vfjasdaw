"""Rebuild BIGDATA end to end. Stage 0 (cdn_fetch.py in ../../scripts) refreshes the cache first; s3 needs D:\toram_re\dump_android."""
import subprocess, sys, os
here = os.path.dirname(os.path.abspath(__file__))
for s in ("s1_extract_all.py", "s2_cdn_catalog.py", "s3_code_readable.py", "s4_masters.py", "s5_text_readable.py"):
    print("==", s, flush=True)
    subprocess.run([sys.executable, os.path.join(here, s)], check=True, cwd=here)
