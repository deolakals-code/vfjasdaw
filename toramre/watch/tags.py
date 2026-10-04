"""Change tags and their severity."""
from dataclasses import dataclass, asdict

SEVERITY = {
    "LAYOUT_BROKEN": 3,   # a table that parsed before no longer parses: its parser must be fixed
    "BINARY_CHANGED": 3,  # libil2cpp.so differs: rerun the fingerprint step
    "UNIT_CHANGED": 3,    # a decoded skill / buff / registlet class changed
    "NEW": 2,             # new table or new row
    "REMOVED": 2,
    "CHANGED": 2,         # table content or row changed
    "TEXT_CHANGED": 1,    # localized text only
    "STALE_DOC": 1,       # a doc or export cites a changed item
}
NAMES = {3: "high", 2: "medium", 1: "low"}


def level(name: str) -> int:
    return {"high": 3, "medium": 2, "low": 1}[name]


@dataclass
class Event:
    tag: str
    bundle: str
    item: str
    from_ver: str
    to_ver: str
    detail: str = ""

    @property
    def severity(self):
        return SEVERITY[self.tag]

    def as_dict(self):
        d = asdict(self)
        d["severity"] = NAMES[self.severity]
        return d
