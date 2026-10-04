"""Layout probes used by the change alerts (same rules as tools/s4_masters.py and tools/s5_text_readable.py)."""
import struct

import toramre.core.paths  # noqa: F401  (puts tools/ on sys.path)
from common import parse_text_table


def master_frame(d: bytes):
    """Fixed-width framing of a master table -> (header_len, count, record_bytes) or None (variable width)."""
    for off in (0, 1, 4):
        for w, f in ((4, "<I"), (2, "<H")):
            if off + w > len(d):
                continue
            n = struct.unpack_from(f, d, off)[0]
            hdr = off + w
            if 0 < n < len(d) and (len(d) - hdr) % n == 0 and (len(d) - hdr) // n >= 2:
                return hdr, n, (len(d) - hdr) // n
    return None


def text_rows(d: bytes):
    """Parse a localized text table with the first accepting format A-D -> (fmt, rows) or None (not a keyed text table)."""
    for fmt in "ABCD":
        try:
            return fmt, parse_text_table(d, fmt)
        except Exception:
            continue
    return None
