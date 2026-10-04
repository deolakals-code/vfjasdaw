import json
import os
import time

from .tags import NAMES, level


def summarize(events):
    by = {}
    for e in events:
        by.setdefault(e.tag, []).append(e)
    return by


def write(events, out_dir):
    os.makedirs(out_dir, exist_ok=True)
    json.dump([e.as_dict() for e in events], open(os.path.join(out_dir, "changes.json"), "w", encoding="utf-8"), indent=1, ensure_ascii=False)
    lines = [f"# Change report ({time.strftime('%Y-%m-%d')})", "", f"{len(events)} events", ""]
    for tag, evs in sorted(summarize(events).items(), key=lambda kv: -kv[1][0].severity):
        lines += [f"## {tag} [{NAMES[evs[0].severity]}] ({len(evs)})", ""]
        lines += [f"- `{e.bundle}/{e.item}` {e.from_ver} -> {e.to_ver}: {e.detail}" for e in evs]
        lines.append("")
    open(os.path.join(out_dir, "CHANGES.md"), "w", encoding="utf-8").write("\n".join(lines))


def worst(events):
    return max((e.severity for e in events), default=0)


def exceeds(events, fail_on):
    return worst(events) >= level(fail_on)
