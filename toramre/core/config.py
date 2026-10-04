"""One settings file: toramre.toml at the repo root (or the path in env TORAM_CONFIG).
Precedence everywhere: command-line option > environment variable > toramre.toml > built-in default.

Example toramre.toml:
  [paths]
  cdn_cache = 'D:\\toram_re\\cdn_cache'
  export = 'D:\\toram_re\\exported'
  cache_roots = ['D:\\toram_re\\phone_cache\\UnityCache\\Shared']
  [fetch]
  jobs = 8
  rate = 8.0
  max_mbps = 0
  channel = 'A'
  [notify]
  webhook = 'https://discord.com/api/webhooks/...'
  allowed_hosts = ['discord.com']
  level = 'medium'
"""
import os

from . import paths

_cache = None


def path():
    return os.environ.get("TORAM_CONFIG") or os.path.join(paths.REPO, "toramre.toml")


def load():
    global _cache
    if _cache is not None:
        return _cache
    p = path()
    _cache = {}
    if os.path.exists(p):
        try:
            import tomllib
        except ImportError:  # Python < 3.11: settings file ignored, env and options still work
            return _cache
        with open(p, "rb") as f:
            _cache = tomllib.load(f)
    return _cache


def get(section, key, default=None, env=None):
    if env and os.environ.get(env):
        return os.environ[env]
    return load().get(section, {}).get(key, default)


def reset():
    global _cache
    _cache = None
