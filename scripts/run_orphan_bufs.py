"""Symbolic-execute *Buf classes that no skill Action constructs directly (songs, dances, ...).
usage: python run_orphan_bufs.py -> D:\\toram_re\\skillrecipes_orphan_bufs.json
"""
import os, glob, json
from multiprocessing import Pool
import run_skills as R

OUT = r"D:\toram_re\skillrecipes_orphan_bufs.json"


def known():
    seen = set()
    for p in glob.glob(os.path.join(R.OUTDIR, "*.json")):
        seen.update(json.load(open(p, encoding="utf-8")).get("buffs", {}))
    return seen


def job(cls):
    return cls, R.analyze_buf(cls)


if __name__ == "__main__":
    R.init()
    S = R._G["S"]
    seen = known()
    cand = sorted(c for c in R._G["m"]
                  if "." not in c and c not in seen
                  and (c.endswith("Buf") or "SkillBufferDataBase" in S.D2.chain(c) or "CountBufferBase" in S.D2.chain(c)))
    print(len(seen), "known,", len(cand), "orphan", flush=True)
    out = {}
    with Pool(10, initializer=R.init) as p:
        for cls, res in p.imap_unordered(job, cand):
            out[cls] = res
    json.dump(out, open(OUT, "w", encoding="utf-8"), ensure_ascii=False)
    print("wrote", OUT, len(out))
