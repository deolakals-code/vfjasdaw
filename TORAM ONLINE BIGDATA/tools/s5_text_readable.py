"""Stage 5: localized text tables (newest version of every bundle) -> readable/text/<bundle>/<asset>.tsv.
Formats tried in order, accepted only when they consume the file exactly and every string is valid UTF-8:
  A <I count> x (<I id><B kind><7bit len><utf8>)          Item_th, Skill_th, Enemy_th, ...
  B same, plus <B no> after kind when kind != 0             Quest_*_th, Mission_*_th, sc_*_th
  C <I count> x (<i id><7bit len><utf8>)                    ItemProperty_th
  D <I count> x (<7bit len><key><7bit len><text>)           System_th"""
import csv, json, os, re, struct
from common import ROOT, parse_text_table as parse
man = json.load(open(os.path.join(ROOT, "data", "decoded_manifest.json")))
newest = {}
for k, v in man.items():
    name = k.split("/")[0]
    if name == "BynaryData" or name.startswith("FieldScript"):
        continue
    m = os.path.getmtime(v["src"])
    if name not in newest or m > newest[name][0]:
        newest[name] = (m, k, v)


done, skipped = {}, []
for name, (_, key, v) in sorted(newest.items()):
    ver = key.split("/")[1]
    for a in v["assets"]:
        if len(a) != 4:
            continue
        rel, an = a[0], a[1]
        p = os.path.join(ROOT, "data", "decoded", name, ver, rel, an + ".dec")
        d = open(p, "rb").read()
        rows = fmt = None
        for f in "ABCD":
            try:
                rows = parse(d, f); fmt = f; break
            except Exception:
                continue
        if rows is None:
            try:
                t = d.decode("utf-8")
                if sum(c.isprintable() or c.isspace() for c in t) / max(len(t), 1) > 0.97:
                    od = os.path.join(ROOT, "readable", "text", name, rel)
                    os.makedirs(od, exist_ok=True)
                    open(os.path.join(od, an + ".txt"), "w", encoding="utf-8", newline="").write(t)
                    done[f"{name}/{rel}/{an}"] = ("plain", len(t)); continue
            except UnicodeDecodeError:
                pass
            skipped.append(f"{name}/{rel}/{an}"); continue
        od = os.path.join(ROOT, "readable", "text", name, rel)
        os.makedirs(od, exist_ok=True)
        with open(os.path.join(od, an + ".tsv"), "w", newline="", encoding="utf-8") as f:
            w = csv.writer(f, delimiter="\t", lineterminator="\n")
            w.writerow(["id" if fmt != "D" else "key", "kind", "no", "text"])
            for r in rows:
                w.writerow([r[0], r[1], r[2], r[3].replace("\r", "\\r").replace("\n", "\\n").replace("\t", "\\t")])
        done[f"{name}/{rel}/{an}"] = (fmt, len(rows))
json.dump({"parsed": done, "unparsed": skipped}, open(os.path.join(ROOT, "readable", "text", "_index.json"), "w"), ensure_ascii=False, indent=0)
print(len(done), "tables parsed;", len(skipped), "unparsed")
print("unparsed sample:", skipped[:25])
