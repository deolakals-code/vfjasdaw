import re, bisect

DUMP = r"D:\toram_re\dump_android\dump.cs"
TARGETS = [70661, 70759, 70857, 70955, 71398, 71497, 71596, 71689, 71953, 72152,
           114196, 114528, 114610, 115920, 118393, 118900, 119048, 120941, 122475,
           123421, 124489, 125962, 127354, 128022, 128527, 129686, 131026, 132139,
           132568, 133144, 134919, 138244, 138507, 138759, 139056, 139265, 139510,
           139856, 140093, 140185, 140311, 151883, 151975, 152061, 152183, 161398]

class_re = re.compile(r'^(?:public|internal|private|protected)?\s*(?:abstract |sealed |static )*class\s+(\S+)')

lines = open(DUMP, encoding="utf-8", errors="replace").read().splitlines()

class_starts = []  # (line_no_1based, name)
for i, line in enumerate(lines, start=1):
    if line.startswith((" ", "\t")):
        continue  # only top-level (non-nested) class declarations
    m = class_re.match(line)
    if m:
        class_starts.append((i, m.group(1)))

starts_lines = [c[0] for c in class_starts]

print(f"total top-level class declarations found: {len(class_starts)}")
for t in TARGETS:
    idx = bisect.bisect_right(starts_lines, t) - 1
    if idx >= 0:
        cls_line, cls_name = class_starts[idx]
        print(f"line {t}\tclass {cls_name}\t(declared line {cls_line})\tmethod line text: {lines[t-1].strip()[:80]}")
    else:
        print(f"line {t}\tNO CLASS FOUND")
