"""Stage 2: full CDN bundle catalog (RevisionInfoBinary of release A-F, android) -> data/cdn/catalog_<ch>.csv.
Only the small version tables are downloaded; no bundle bodies. Implementation: toramre/net/catalog.py."""
import os
import sys

sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__)))))
from toramre.cli import main  # noqa: E402

sys.exit(main(["fetch", "catalog"]))
