# Proration calculator

Standalone deliverable split out of [`../calc Reverse/proration/`](../calc%20Reverse/proration/),
which stays the authoritative formula/evidence source (state machine, disassembly, addresses).

- `calculator.py` — runnable simulator of the state machine (`python calculator.py` runs the
  self-check; hand-verified against formula.md's worked example, not yet executed in-session —
  the shell tool was down while this was written, see code_map.md).
- `proration_hit_rules.json` — per-hit vs first-hit rule (gate order, bypass skills, addresses, unverified list).
- `skill_proration_modes.csv|json` — every skill id (398) with class, slot and proration mode (multi-hit rule applied).
- `is_exp_def_fluctuate.csv` — return value of every `get_IsExpDefFluctuate` override (46 + base).
- `code_map.md` — new: the full code linkage graph for **every** player attack type and **every**
  game mode's mob, tracing the open point `../calc Reverse/proration/evidence.md` left ("the main
  field damage path was not traced"). A few entries are marked pending disassembly (tool outage);
  the exact `dis_android.py` commands to finish them are listed there.

Status: mechanism (state machine, clamp, universal interface wiring) is Code-confirmed. Exact
arithmetic of the field-attack consumers (`NormalAttackAction.CalcDef`, `GetTargetExpRate`) is
pending disassembly — resume with code_map.md §"Reproduce".
