import re, sys

b = open(sys.argv[1], "rb").read()
pat = re.compile(sys.argv[2])
after = int(sys.argv[3]) if len(sys.argv) > 3 else 0
names = [s.decode("latin1") for s in b.split(b"\0") if 1 < len(s) < 80 and all(32 <= c < 127 for c in s)]
hits = [i for i, s in enumerate(names) if pat.search(s)]
print("hits:", len(hits))
for i in hits[:int(sys.argv[4]) if len(sys.argv) > 4 else 50]:
    print(" | ".join(names[i:i + after + 1]))
