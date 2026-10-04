import re, sys

KW = re.compile(sys.argv[1], re.I)
mode = sys.argv[2] if len(sys.argv) > 2 else "classes"
cls, members, hits = None, [], []
for line in open(r"D:\toram_re\meta\all_types.txt", encoding="utf-8"):
    line = line.rstrip("\n")
    if line.startswith("class "):
        if cls and (KW.search(cls) if mode == "classes" else any(KW.search(m) for m in members)):
            hits.append((cls, members))
        cls, members = line[6:], []
    elif line.strip():
        members.append(line.strip())
if mode == "classes":
    for c, m in hits:
        print(f"{c}  (fields {sum(x.startswith('field') for x in m)}, methods {sum(x.startswith('meth') for x in m)})")
else:
    for c, m in hits:
        sel = [x for x in m if KW.search(x)]
        print(f"{c}: " + " ; ".join(sel[:25]) + (" ..." if len(sel) > 25 else ""))
print("hits:", len(hits))
