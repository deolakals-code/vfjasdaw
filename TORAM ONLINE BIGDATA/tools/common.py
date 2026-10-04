"""Shared helpers for the extraction tools: one copy of the bundle decoder, the 7-bit varint reader and the
localized text-table parser, plus repo-relative paths (no drive letters).

Rule (label Code, `readable/csharp/ToramDecoder.cs` implements the same):
  cache dir name = 24 zeros + version as LE hex, last 8 hex chars = key;
  p[j] = c[j] ^ c[j-4] ^ key_le[j % 4]  (c[-4..-1] = 0); the trailing len % 4 bytes are plain.
"""
import os
import struct

TOOLS = os.path.dirname(os.path.abspath(__file__))
ROOT = os.path.dirname(TOOLS)  # TORAM ONLINE BIGDATA
LEGACY = os.path.join(TOOLS, "legacy_scripts")


# ---- bundle decoder -------------------------------------------------------------------------------------------
def decode(buf: bytes, ver_hash: int) -> bytes:
    key = ver_hash.to_bytes(4, "little")
    out = bytearray(buf)
    for j in range(len(buf) - len(buf) % 4):
        prev = buf[j - 4] if j >= 4 else 0
        out[j] = buf[j] ^ prev ^ key[j & 3]
    return bytes(out)


def fast_decode(buf: bytes, ver_hash: int) -> bytes:
    """numpy version of `decode` (same output, for large blobs)."""
    import numpy as np
    a = np.frombuffer(buf, np.uint8)
    n = len(a) - len(a) % 4
    key = np.frombuffer(ver_hash.to_bytes(4, "little") * (n // 4 + 1), np.uint8)[:n]
    out = a.copy()
    prev = np.zeros(n, np.uint8)
    prev[4:] = a[:n - 4]
    out[:n] = a[:n] ^ prev ^ key
    return out.tobytes()


# ---- 7-bit varint and strings ---------------------------------------------------------------------------------
def read7bit(d, i):
    """-> (value, next offset)."""
    n = s = 0
    while True:
        c = d[i]
        i += 1
        n |= (c & 0x7f) << s
        s += 7
        if c < 0x80:
            return n, i


def read_str(d, i):
    """7-bit length + UTF-8 -> (text, next offset); raises ValueError when the length overruns the buffer."""
    n, i = read7bit(d, i)
    if i + n > len(d):
        raise ValueError
    return d[i:i + n].decode("utf-8"), i + n


# ---- localized text tables (see s5_text_readable.py for the format list) --------------------------------------
def parse_text_table(d, fmt):
    """fmt A/B/C/D -> [(id_or_key, kind, no, text)]; raises ValueError unless the file is consumed exactly."""
    cnt = struct.unpack_from("<I", d, 0)[0]
    i, rows = 4, []
    if cnt > len(d):
        raise ValueError
    for _ in range(cnt):
        if fmt in "AB":
            id_, kind = struct.unpack_from("<IB", d, i)
            i += 5
            no = 0
            if fmt == "B" and kind != 0:
                no = d[i]
                i += 1
            t, i = read_str(d, i)
            rows.append((id_, kind, no, t))
        elif fmt == "C":
            id_ = struct.unpack_from("<i", d, i)[0]
            i += 4
            t, i = read_str(d, i)
            rows.append((id_, 0, 0, t))
        else:
            k, i = read_str(d, i)
            t, i = read_str(d, i)
            rows.append((k, 0, 0, t))
    if i != len(d):
        raise ValueError
    return rows
