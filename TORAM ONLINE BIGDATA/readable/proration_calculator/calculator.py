"""Monster proration (expDefNormal/Skill/Magic) state-machine simulator.

Formula source: ../calc Reverse/proration/formula.md + evidence.md (disassembly-confirmed:
MobStatus.CalcExpDef @ RVA 0x1f37150, clamp [50,250]). This file only re-implements that formula
so it can be run; it does not add new claims about the game beyond code_map.md.

Open point inherited from evidence.md: whether a hit's own damage uses the state BEFORE or AFTER
that hit's update was not resolved in the original disassembly (two separate call sites). simulate()
returns the state AFTER each hit; pass state_before[i] instead if you need the pre-update value.
"""
from dataclasses import dataclass

SLOTS = ("Normal", "Skill", "Magic")

# SkillActionBase.ExpType -> proration slot (evidence.md table)
EXP_TYPE_TO_SLOT = {
    "SkillNormal": "Normal",  # ExpType 3, or ActionID == 0 (plain normal attack)
    "Physics": "Skill",       # ExpType 1 (physical skills)
    "Magic": "Magic",         # ExpType 2
}


@dataclass(frozen=True)
class ProrationSteps:
    normal: int
    skill: int
    magic: int

    def step(self, slot: str) -> int:
        return {"Normal": self.normal, "Skill": self.skill, "Magic": self.magic}[slot]


def calc_exp_def(state: dict, steps: ProrationSteps, hit_slot: str) -> dict:
    """One MobStatus.CalcExpDef call: hit slot steps down, the other two step up, clamp 50..250."""
    new_state = {}
    for slot in SLOTS:
        step = steps.step(slot)
        delta = -step if slot == hit_slot else step
        new_state[slot] = min(250, max(50, state[slot] + delta))
    return new_state


def simulate(steps: ProrationSteps, hit_slots: list[str]) -> list[dict]:
    """Run a sequence of hits from a fresh monster (100/100/100). Returns state after each hit."""
    state = {slot: 100 for slot in SLOTS}
    history = []
    for hit_slot in hit_slots:
        state = calc_exp_def(state, steps, hit_slot)
        history.append(dict(state))
    return history


def damage_multiplier(state: dict, hit_slot: str) -> float:
    """damage = (int)(damage * p[slot] / 100), per evidence.md's HuntingOne trace."""
    return state[hit_slot] / 100.0


def demo() -> None:
    # Worked example from formula.md: step 10/5/10, normal -> physical skill -> magic skill.
    steps = ProrationSteps(normal=10, skill=5, magic=10)
    history = simulate(steps, ["Normal", "Skill", "Magic"])
    assert history[0] == {"Normal": 90, "Skill": 105, "Magic": 110}
    assert history[1] == {"Normal": 100, "Skill": 100, "Magic": 120}
    assert history[2] == {"Normal": 110, "Skill": 105, "Magic": 110}

    # Clamp floor: one big hit cannot push its own slot below 50.
    big = ProrationSteps(normal=100, skill=100, magic=100)
    clamped = simulate(big, ["Normal"])[0]
    assert clamped == {"Normal": 50, "Skill": 200, "Magic": 200}

    # Zero step: proration never moves.
    inert = ProrationSteps(normal=0, skill=0, magic=0)
    assert simulate(inert, ["Normal", "Magic", "Skill"])[-1] == {"Normal": 100, "Skill": 100, "Magic": 100}

    print("proration_calculator: self-check passed")


if __name__ == "__main__":
    demo()
