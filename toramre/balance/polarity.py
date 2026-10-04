"""Is a changed value a buff or a nerf? A plain table, no guessing.

BUFF = the change is better for the player, NERF = worse, NEUTRAL = changed but the direction has no fixed meaning
(or is not known): shown with an arrow only. A field is judged only when this table says so.
`sense` is +1 when a HIGHER value is better for the player, -1 when a LOWER value is better."""

# (kind, field) -> sense. kind = skill | item | recipe | registlet | rate (skill multiplier snapshot) | buff (skill buff value)
SENSE = {
    ("skill", "Level"): +1,            # max skill level
    ("skill", "SkillTreeLv"): -1,      # tree level needed: lower = unlocked earlier
    ("item", "Stack"): +1,             # stack size
    ("item", "Stable"): +1,            # weapon stability
    ("item", "Range"): +1,
    ("item", "SlotMax"): +1,           # crysta slots
    ("item", "Potential"): +1,
    ("item", "Function"): +1,          # weapon ATK / armour DEF base (equipment only, see EQUIP_TYPES)
    ("recipe", "difficulty"): -1,
    ("recipe", "price"): -1,           # crafting fee
    ("recipe", "releaseLv"): -1,       # level needed to craft
    ("recipe", "createVal"): +1,       # amount produced
    ("recipe", "materials"): -1,       # amount of materials needed
    ("registlet", "levelCap"): +1,
    ("registlet", "enhancePowder"): -1,  # powder needed to enhance
    ("rate", "rate"): +1,              # skill multiplier (percent of ATK)
    ("rate", "flat"): +1,              # flat damage added
    ("buff", "timer"): +1,             # buff duration
}
EQUIP_TYPES = range(7, 28)  # ItemMaster TypeId of equipment (items/README.md)
BUFF_PARAM_UP = ("Up",)     # a buff parameter named ...Up raises a stat: higher = better; other names stay neutral


def sense(kind, field, context=None):
    if kind == "buff":
        field = field.rsplit("/", 1)[-1]
        if field.startswith("param:"):
            return +1 if field.endswith(BUFF_PARAM_UP) else 0
    s = SENSE.get((kind, field), 0)
    if kind == "item" and field == "Function" and (context or {}).get("TypeId") not in EQUIP_TYPES:
        return 0
    return s


UNSET_IS_ZERO = ("item", "recipe")  # in these tables 0 means "not set": 0 -> n is a field being introduced, not a change of strength


def verdict(kind, field, before, after, context=None):
    """-> 'BUFF' | 'NERF' | 'NEUTRAL' for one numeric change."""
    if before == after:
        return "NEUTRAL"
    if kind in UNSET_IS_ZERO and (before == 0 or after == 0):
        return "NEUTRAL"
    s = sense(kind, field, context)
    if s == 0:
        return "NEUTRAL"
    return "BUFF" if (after > before) == (s > 0) else "NERF"


def combine(verdicts):
    """Verdict of a whole entry from its changed fields: one direction -> that; both -> MIXED; none judged -> NEUTRAL."""
    v = set(verdicts) - {"NEUTRAL"}
    if not v:
        return "NEUTRAL"
    return v.pop() if len(v) == 1 else "MIXED"
