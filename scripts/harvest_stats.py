"""Decode the player stat / weapon calculator / mob stat / damage-inner functions with the forward-merging symbolic executor
(build_variables.decode: MergeEx, `_tN` shared sub-expressions, cases grouped by value).
usage (cwd D:\\toram_re): python harvest_stats.py [group ...]   groups: player weapon bonus mob attack normal
Writes one JSON per function into D:\\toram reverse data\\skills\\damage\\stats\\decoded\\<group>\\ plus index.json (resumable).
"""
import sys, os, re, json, time
import symexec as S
S.MASTERY_RECV = True          # GetMasteryParam / abstract weapon-calculator calls keep their receiver (player_status.clean turns them into MasteryParam(uid, id) / concrete dispatch)
import build_variables as B

OUT = r"D:\toram reverse data\skills\damage\stats\decoded"
MOB_CLS = ("MobBattleStatus|BossMobBattleStatus|DungeonMobBattleStatus|DungeonBossMobBattleStatus|GuildRaidMobBattleStatus|"
           "GuildRaidBossMobBattleStatus|GuildRaidEntourageMobBattleStatus|HighRaidMobBattleStatus|HighRaidBossBattleStatus|"
           "NonTargetDummyMobBattleStatus|WaveMobBattleStatus|WaveBossMobBattleStatus|DefenceMobBattleStatus|DefenceBossBattleStatus|"
           "TreasureHuntMobBattleStatus|TreasureHuntBossBattleStatus|ScoreAttackMobBattleStatus|ScoreAttackBossBattleStatus|"
           "NewWaveMobBattleStatus|NewWaveBossBattleStatus|BCollaboMobBattleStatus|BCollaboBossMobBattleStatus|RezeroMobBattleStatus|"
           "MobaMobBattleStatus|MobaOtherPlayerBattleStatus")
GROUPS = {
    "player": r"^(PlayerSecondaryStatus|PlayerPrimaryStatus|PlayerBattleStatus|BlackKnightPlayerStatus|PlayerStatusBase)\$\$(?!\.ctor|\.cctor)\w+$",
    "weapon": r"^EquipItemData(\.\w+Calculator\w*)?\$\$(?!\.ctor|\.cctor)\w+$",
    "bonus": r"^BonusManager\$\$(?!\.ctor|\.cctor)\w+$",
    "mob": r"^(" + MOB_CLS + r")\$\$(?!\.ctor|\.cctor)(get_\w+|Calc\w+|SetMobStatus)$",
    "attack": r"^(PlayerAttackBase|MobAttackBase)\$\$(Calc\w+|Check\w+|Get\w+)$",
    "normal": r"^(NormalAttackAction|NormalAttackPattern)\$\$(?!\.ctor|\.cctor)\w+$",
}


def main(groups):
    os.makedirs(OUT, exist_ok=True)
    idx_path = os.path.join(OUT, "index.json")
    idx = json.load(open(idx_path, encoding="utf-8")) if os.path.exists(idx_path) else {}
    for g in groups:
        rx = re.compile(GROUPS[g])
        todo = sorted((a, n) for a, n in S.names.items() if rx.match(n))
        os.makedirs(os.path.join(OUT, g), exist_ok=True)
        print(f"## {g}: {len(todo)} functions", flush=True)
        for a, n in todo:
            fn = re.sub(r"[^\w.$-]", "_", n) + ".json"
            p = os.path.join(OUT, g, fn)
            if n in idx and os.path.exists(p): continue
            t = time.time()
            try:
                rec = {"name": n, "rva": hex(a), **B.decode(a)}
                status = "trunc" if rec["truncated"] else "ok"
            except Exception as e:
                rec = {"name": n, "rva": hex(a), "error": repr(e)[:300]}
                status = "error"
            json.dump(rec, open(p, "w", encoding="utf-8"), ensure_ascii=False)
            idx[n] = {"group": g, "rva": hex(a), "status": status, "paths": rec.get("npaths", 0), "returns": rec.get("returns"), "file": f"{g}/{fn}"}
            print(f"{status:5s} {rec.get('npaths', 0):4d} {time.time() - t:6.1f}s {n}", flush=True)
            json.dump(idx, open(idx_path, "w", encoding="utf-8"))


if __name__ == "__main__":
    main(sys.argv[1:] or list(GROUPS))
