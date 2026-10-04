"""Optional alerts to the user's own chat (Discord / Slack-compatible incoming webhook).
The URL and its host are set by the user in toramre.toml [notify]; only https and an explicitly allowed host are used
(game-side network access stays limited to the CDN by guard.check_url)."""
import json
import urllib.request
from urllib.parse import urlparse

from toramre.brain.guard import Boundary
from toramre.core import config


def check(url, allowed):
    u = urlparse(url or "")
    if u.scheme != "https" or (u.hostname or "") not in set(allowed or ()):
        raise Boundary(f"notify: {u.hostname or url!r} is not https or not in [notify] allowed_hosts")


def send(text, url=None, allowed=None, opener=urllib.request.urlopen):
    url = url or config.get("notify", "webhook", env="TORAM_WEBHOOK")
    if not url:
        return False
    allowed = allowed if allowed is not None else config.get("notify", "allowed_hosts", [])
    check(url, allowed)
    body = json.dumps({"content": text[:1900], "text": text[:1900]}).encode()
    req = urllib.request.Request(url, data=body, headers={"Content-Type": "application/json", "User-Agent": "toramre"})
    with opener(req, timeout=30):
        pass
    return True


def summarize(events, top=8):
    from toramre.watch.tags import NAMES
    by = {}
    for e in events:
        by.setdefault((e.severity, e.tag), []).append(e)
    lines = [f"Toram data watch: {len(events)} changes"]
    for (sev, tag), evs in sorted(by.items(), key=lambda kv: -kv[0][0]):
        lines.append(f"[{NAMES[sev]}] {tag} x{len(evs)}: " + ", ".join(f"{e.bundle}/{e.item}" for e in evs[:top])
                     + (" ..." if len(evs) > top else ""))
    return "\n".join(lines)
