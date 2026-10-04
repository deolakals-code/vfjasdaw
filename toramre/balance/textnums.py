"""Numbers inside skill texts (level notes such as `MP ที่ใช้-100`, `พลัง+50`, `อัตราติดผงะ+50%`).
When two versions of a text differ ONLY in their numbers, the change is reported per number with the words around it;
a verdict is given only for words in COST / POWER (cost words: higher = worse, power words: higher = better)."""
import re

NUM = re.compile(r"[+\-]?\d+(?:\.\d+)?%?")
COST = ("MP ที่ใช้", "MP cost", "MP Cost", "消費MP", "消耗MP", "MP消費", "MP 소비", "MP 소모")
POWER = ("พลัง", "Power", "威力", "威力", "위력")


def skeleton(text):
    return NUM.sub("#", text)


def numbers(text):
    return NUM.findall(text)


def _value(tok):
    return float(tok.rstrip("%"))


def _context(text, pos):
    """The words right before a number: back to the previous newline or number, at most 24 characters."""
    start = max(0, pos - 24)
    nl = text.rfind("\n", 0, pos)
    if nl >= start:
        start = nl + 1
    prev = [m.end() for m in NUM.finditer(text, 0, pos)]
    if prev and prev[-1] > start:
        start = prev[-1]
    return text[start:pos].strip()


def compare(before, after):
    """-> list of {"context", "before", "after", "delta", "pct", "verdict"}; [] when equal or when the wording changed
    (a reworded text is a text change, not a number change: use the plain text diff)."""
    if before == after or skeleton(before) != skeleton(after):
        return []
    out = []
    for mb, ma in zip(NUM.finditer(before), NUM.finditer(after)):
        if mb.group() == ma.group():
            continue
        b, a = _value(mb.group()), _value(ma.group())
        ctx = _context(before, mb.start())
        sense = -1 if any(w in ctx for w in COST) else (+1 if any(w in ctx for w in POWER) else 0)
        verdict = "NEUTRAL" if sense == 0 else ("BUFF" if (a > b) == (sense > 0) else "NERF")
        out.append({"context": ctx, "before": mb.group(), "after": ma.group(), "delta": a - b,
                    "pct": (a - b) / abs(b) * 100 if b else None, "verdict": verdict})
    return out
