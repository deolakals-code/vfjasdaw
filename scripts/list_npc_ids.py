"""List every Npc/NpcModel/Npc_<id> bundle on the public CDN (not just locally cached ones).
Re-run after a patch to see if new NPC ids were added before re-fetching with cdn_fetch.py."""
import sys, urllib.request, os
HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, HERE)
from revision import parse

ch = sys.argv[1] if len(sys.argv) > 1 else "A"
with urllib.request.urlopen(f"https://toram-jp.akamaized.net/resources/android/release{ch}/RevisionInfoBinary.bytes", timeout=60) as r:
    t = parse(r.read())
ids = sorted(int(k.rsplit("_", 1)[1]) for k in t if k.startswith("Npc/NpcModel/Npc_"))
print(len(ids), "npc model ids, range", ids[0], "-", ids[-1])
