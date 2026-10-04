"""Stage 4: frame every master table of the newest BynaryData into readable/masters/<name>.csv when it is a fixed-width table.
Header forms tried: count (u16/u32) at offset 0/1/4; accepted when (len-header) % count == 0. Variable-width tables are listed
in _framing.json as 'variable' (they need a per-table parser; see NOTES.md / tools for the solved ones)."""
import csv, json, os, struct
ROOT = r"D:\toram reverse data\TORAM ONLINE BIGDATA"
man = json.load(open(ROOT + r"\data\decoded_manifest.json"))
key = max((k for k in man if k.startswith("BynaryData/")), key=lambda k: os.path.getmtime(man[k]["src"]))
src = os.path.join(ROOT, "data", "decoded", *key.split("/"))
out = ROOT + r"\readable\masters"
os.makedirs(out, exist_ok=True)
info = {"version": key.split("/")[1], "tables": {}}
for fn in sorted(os.listdir(src)):
    d = open(os.path.join(src, fn), "rb").read()
    name = fn[:-4]
    found = None
    for off in (0, 1, 4):
        for w, f in ((4, "<I"), (2, "<H")):
            if off + w > len(d):
                continue
            n = struct.unpack_from(f, d, off)[0]
            hdr = off + w
            if 0 < n < len(d) and (len(d) - hdr) % n == 0 and (len(d) - hdr) // n >= 2:
                found = (off, w, n, hdr, (len(d) - hdr) // n); break
        if found:
            break
    ent = {"bytes": len(d)}
    if found:
        off, w, n, hdr, W = found
        ent.update(count=n, header=hdr, count_at=off, count_width=w, record_bytes=W, prefix_hex=d[:off].hex())
        with open(os.path.join(out, name + ".csv"), "w", newline="", encoding="utf-8") as f:
            cw = csv.writer(f)
            cw.writerow(["idx", "hex"] + ([f"i32_{k}" for k in range(W // 4)] if W % 4 == 0 else []))
            for i in range(n):
                rec = d[hdr + i * W: hdr + (i + 1) * W]
                cw.writerow([i, rec.hex()] + (list(struct.unpack(f"<{W // 4}i", rec)) if W % 4 == 0 else []))
    else:
        ent["framing"] = "variable"
    info["tables"][name] = ent
json.dump(info, open(out + r"\_framing.json", "w"), indent=1)
fixed = [k for k, v in info["tables"].items() if "record_bytes" in v]
print(info["version"], len(info["tables"]), "tables; fixed-width:", len(fixed), fixed)
print("variable:", [k for k in info["tables"] if k not in fixed])
