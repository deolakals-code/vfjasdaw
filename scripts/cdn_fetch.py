"""Old entry point, now a thin wrapper over `toramre fetch` (parallel, resumable, MD5-verified, manifest).
Usage unchanged: python cdn_fetch.py <regex on bundle key> [channel=A]
Destination: env TORAM_CDN_CACHE, else D:\\toram_re\\cdn_cache when it exists (the old place cache.py reads), else <repo>/cdn_cache."""
import os
import sys

REPO = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
sys.path.insert(0, REPO)
from toramre.cli import main  # noqa: E402

OLD_ROOT = r"D:\toram_re\cdn_cache"

if __name__ == "__main__":
    pattern = sys.argv[1] if len(sys.argv) > 1 else "."
    ch = sys.argv[2] if len(sys.argv) > 2 else "A"
    dest = os.environ.get("TORAM_CDN_CACHE") or (OLD_ROOT if os.path.isdir(OLD_ROOT) else os.path.join(REPO, "cdn_cache"))
    if main(["fetch", "catalog"]) != 0:
        sys.exit(1)
    sys.exit(main(["fetch", "get", "--match", pattern, "--channel", ch, "--dest", dest]))
