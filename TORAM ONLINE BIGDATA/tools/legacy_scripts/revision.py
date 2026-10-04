"""RevisionInfoBinary.bytes parser: moved to toramre/net/revision.py (one copy). Kept for old imports and the CLI below."""
import os
import sys

_REPO = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
for _up in range(3):  # scripts/ -> repo, tools/legacy_scripts/ -> repo
    if os.path.isdir(os.path.join(_REPO, "toramre")):
        break
    _REPO = os.path.dirname(_REPO)
sys.path.insert(0, _REPO)
from toramre.net.revision import parse, read_str  # noqa: E402,F401

if __name__ == "__main__":
    t = parse(open(sys.argv[1], "rb").read())
    print(len(t), "bundles")
    for k in sorted(t)[:10]:
        print(k, t[k])
