"""Table schemas as data, and the one parser that runs them.

A schema is JSON:
  {"header": {"prefix": 1, "count": "u16"},      # skip `prefix` bytes, then the record count ("none" = records until EOF)
   "record": [item, ...]}
Items:
  {"t": "raw", "n": 5}                           # fixed bytes, meaning not known yet
  {"t": "u8"|"i16"|"u16"|"i32"|"u32"|"f32"}       # typed fixed field
  {"t": "list", "count": C, "elem": [item, ...]} # count C, then that many elements
  {"t": "str", "len": C}                         # length C, then UTF-8 bytes
  {"t": "switch", "tag": "u8", "cases": {"1": [item, ...], "2": [...]}}   # tagged union: tag, then that case
C is "u8", "u16", "u32" or "v7" (7-bit varint). A schema is accepted only when `parse` ends at the exact last byte.
"""
import struct

FIXED = {"u8": ("<B", 1), "i8": ("<b", 1), "i16": ("<h", 2), "u16": ("<H", 2), "i32": ("<i", 4), "u32": ("<I", 4), "f32": ("<f", 4)}
COUNTS = ("u8", "u16", "u32", "v7")


class ParseError(ValueError):
    def __init__(self, msg, offset):
        super().__init__(f"{msg} at offset {offset}")
        self.offset = offset


def read_count(d, i, kind):
    if kind == "v7":
        n = s = 0
        while True:
            if i >= len(d):
                raise ParseError("varint past end", i)
            c = d[i]
            i += 1
            n |= (c & 0x7f) << s
            s += 7
            if c < 0x80:
                return n, i
            if s > 28:
                raise ParseError("varint too long", i)
    f, w = FIXED[kind]
    if i + w > len(d):
        raise ParseError("count past end", i)
    return struct.unpack_from(f, d, i)[0], i + w


def _items(d, i, items, out):
    for it in items:
        t = it["t"]
        if t == "raw":
            n = it["n"]
            if i + n > len(d):
                raise ParseError("raw past end", i)
            out.append(d[i:i + n])
            i += n
        elif t in FIXED:
            f, w = FIXED[t]
            if i + w > len(d):
                raise ParseError(f"{t} past end", i)
            out.append(struct.unpack_from(f, d, i)[0])
            i += w
        elif t == "str":
            n, i = read_count(d, i, it["len"])
            if i + n > len(d):
                raise ParseError("string past end", i)
            try:
                out.append(d[i:i + n].decode("utf-8"))
            except UnicodeDecodeError:
                raise ParseError("string is not UTF-8", i)
            i += n
        elif t == "switch":
            tag, i = read_count(d, i, it["tag"])
            case = it["cases"].get(str(tag))
            if case is None:
                raise ParseError(f"no case for tag {tag}", i)
            sub = []
            i = _items(d, i, case, sub)
            out.append([tag, sub])
        elif t == "list":
            n, i = read_count(d, i, it["count"])
            if n > len(d) - i + 1 and elem_min(it["elem"]) > 0:
                raise ParseError("list count larger than the rest", i)
            lst = []
            for _ in range(n):
                sub = []
                i = _items(d, i, it["elem"], sub)
                lst.append(sub)
            out.append(lst)
        else:
            raise ValueError(f"unknown item {t}")
    return i


def elem_min(items):
    """Smallest number of bytes the items can take."""
    m = 0
    for it in items:
        t = it["t"]
        if t == "switch":
            m += FIXED[it["tag"]][1] + min(elem_min(c) for c in it["cases"].values())
            continue
        m += it["n"] if t == "raw" else FIXED[t][1] if t in FIXED else 1 if (it.get("count") or it.get("len")) == "v7" else FIXED[it.get("count") or it.get("len")][1]
    return m


def parse(d, schema, max_records=None):
    """-> list of records. Raises ParseError unless the data is consumed to the exact last byte."""
    h = schema.get("header", {})
    i = h.get("prefix", 0)
    if i > len(d):
        raise ParseError("prefix past end", 0)
    kind = h.get("count", "none")
    recs = []
    if kind == "none":
        if elem_min(schema["record"]) == 0:
            raise ParseError("record can be empty", i)
        while i < len(d):
            r = []
            i = _items(d, i, schema["record"], r)
            recs.append(r)
            if max_records and len(recs) > max_records:
                raise ParseError("too many records", i)
    else:
        n, i = read_count(d, i, kind)
        if n > len(d):
            raise ParseError("record count larger than the file", i)
        for _ in range(n):
            r = []
            i = _items(d, i, schema["record"], r)
            recs.append(r)
    if i != len(d):
        raise ParseError(f"{len(d) - i} bytes left", i)
    return recs


def fits(d, schema):
    try:
        parse(d, schema)
        return True
    except (ParseError, struct.error, IndexError):
        return False


def describe(schema):
    """Short text form, e.g. `prefix 1, count u16 x [raw5, list(u8)[raw4], raw3]`."""
    def items(its):
        out = []
        for it in its:
            t = it["t"]
            if t == "switch":
                out.append(f"switch({it['tag']}){{" + "; ".join(f"{k}: {items(v)}" for k, v in sorted(it["cases"].items())) + "}")
                continue
            out.append(f"raw{it['n']}" if t == "raw" else f"str({it['len']})" if t == "str"
                       else f"list({it['count']})[{items(it['elem'])}]" if t == "list" else t)
        return ", ".join(out)
    h = schema.get("header", {})
    head = (f"prefix {h['prefix']}, " if h.get("prefix") else "") + (
        "records until EOF" if h.get("count", "none") == "none" else f"count {h['count']}")
    return f"{head} x [{items(schema['record'])}]"
