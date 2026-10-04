"""List every virtual call the stat-function decoder rendered WITHOUT its receiver, with the receiver expression the executor held, and whether other classes override the method.

A virtual call whose receiver is dropped can only be resolved by guessing (the bug class behind CalcStable / calcAspdParam running the 1H sword class for every weapon, 2026-10-03).
Run (cwd D:\\toram_re):  python "D:\\toram reverse data\\scripts\\sweep_virtual_receivers.py"      -> prints the table, writes player_status/virtual_receivers.json
Groups scanned: the same functions harvest_stats.py decodes for the Details screen (player, weapon, bonus) plus the panel rows / helpers.
Label: Code.
"""
import sys, os, re, json, collections

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import symexec as S
S.MASTERY_RECV = True
import build_variables as B
import harvest_stats as H

OUT = r"D:\toram reverse data\player_status\virtual_receivers.json"
seen = collections.defaultdict(lambda: collections.Counter())
orig = S.Ex.vcall


def vcall(self, st, fn):
    recv = self.get(st, "x0") if isinstance(fn, tuple) and fn[0] == "vfn" else None
    n0 = len(st.ev)
    orig(self, st, fn)
    if recv is None or len(st.ev) == n0:
        return
    ev = st.ev[-1]
    if ev[0] == "call" and str(ev[1]).startswith("virtual "):
        seen[ev[1][len("virtual "):]][S.render(recv)[:90]] += 1


S.Ex.vcall = vcall
by = {n: a for a, n in S.names.items()}
todo = []
for g in ("player", "weapon", "bonus"):
    rx = re.compile(H.GROUPS[g])
    todo += sorted(n for n in by if rx.match(n))
print(len(todo), "functions", flush=True)
for n in todo:
    try:
        B.decode(by[n])
    except Exception as e:
        print("decode error", n, repr(e)[:80])
rows = []
for nm, recvs in sorted(seen.items()):
    cls, _, meth = nm.rpartition(".")
    overridden = sorted({n.split("$$")[0] for n in by if n.endswith("$$" + meth) and n.split("$$")[0] != cls and S.D2.C.get(n.split("$$")[0]) is not None
                         and cls in S.D2.chain(n.split("$$")[0])})
    rows.append({"call": nm, "receivers": dict(recvs), "overriddenIn": overridden})
json.dump(rows, open(OUT, "w", encoding="utf-8"), ensure_ascii=False, indent=1)
for r in rows:
    flag = "OVERRIDDEN x%d" % len(r["overriddenIn"]) if r["overriddenIn"] else "-"
    print(f"{r['call'][:70]:70} {flag:16} {list(r['receivers'])[:2]}")
