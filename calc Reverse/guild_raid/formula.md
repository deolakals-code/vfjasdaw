# Guild Raid bosses — formulas

Source: S1 (`libil2cpp.so`), classes `GuildRaidBossMobBattleStatus` (boss) and `GuildRaidEntourageMobBattleStatus`
(adds). Raw dumps: `D:\toram_re\guildraid\all.txt` (171 methods), `createenemy.txt`. Exported by
`scripts/export_monsters.py` (`gr_stats`): `boss_kind = guild_raid`, difficulty `GR<L>` rows in
`monsters/boss_difficulty.csv` and `monster_full.csv|json`.

## Bosses and maps

| System_th | Boss (record uuid) | Map | Element |
|---|---|---|---|
| GuildRaidBossId1 เบลซซิ่งเซลไดท์ | 916 | 100100 | Fire |
| GuildRaidBossId2 ไบซันศิลาน้ำแข็ง | 741 โกรเลอร์ไบซัน | 100200 | Water |
| GuildRaidBossId3 ไรโกเทพอัสนี | 802 | 100300 | Wind |
| GuildRaidBossId4 คิเมร่าชินอิวาโอะ | 830 ไมตี้คิเมร่า | 100400 | Earth |
| GuildRaidBossId5 เทพทรงกลดโซเทเรีย | 1195 (2 forms) | 100500 | Light |
| GuildRaidBossId6 ปีศาจกระดูกมังกร | 742 เดมอนนิคสคัลดราก้อน | 100600 | Dark |

Id order = ElementType 1..6 = map order (the records' element fields match). The name ↔ record link for 2, 4, 6 is
**inferred** from that order (the text names differ from the record names).

## Inputs (server)

- `L` = `GuildRaidRoomData.GuildRaidLevel` (room type 29), passed to the battle status as `Level` (`MobObjectManager.CreateEnemy` 0x1F1A98C).
- `G` = `GuildRaidRoomData.CurrentHpCount` (HP gauge count), `InitializeHpGage` 0x1F1A96C.
- Summon menu level = `4 × maxHpCount` (`RaidHeldData.get_SummonLevel` 0x2109138). The export assumes `L = 4G`.

## Boss (`GuildRaidBossMobBattleStatus`)

```
T      = 4 * G
MaxHp  = (int)( (Round(G²/100, 2) + 50) * (T/10 + 30) * (int)(T²/2.4 + T + 81) )     # record HP is NOT used
Hit    = (int)(L * 1.5 * nh * 0.01)          [then StatusCollection 7, + alive parts]
Def    = (int)(def * L * 0.01)               [StatusCollection 1, + parts, ×(100+buff)/100, ×0.5 under abnormal 10 or 22]
MDef   = (int)(mdef * L * 0.01)              [StatusCollection 2, same live terms]
Cut    = record cut + parts + L/10           (physical and magic)
Guard / Avoid = record + parts (+ buff); ×0.5 under abnormal 14 when the record value ≤ 99
Move   = record + parts
Damage% (attack) = (L/1000 + 0.25) * ((int)(3.21L + (T/2.5)·T/3 + L²/7) + T) * 0.01
NecessaryFlee% = L * 1.5 * 0.01   (×0.7 under abnormal 7)
Stable% = 1.0 (0.75 under abnormal 23)
```

## Adds (`GuildRaidEntourageMobBattleStatus`, record ids ≥ 1000 — split inferred)

```
T      = 4 * startHpCount
MaxHp  = (int)( (int)((Round((T/4)²/100, 2) + 50) * (T/10 + 30) * (int)(T²/2.4 + T + 81)) * hp/100 )
Hit    = (int)(T * 1.5 * nh * 0.01)     [+ (int)(collection rate × T)]
Def    = (int)(def * 0.01 * T)          [+ (int)(collection rate × L)]      MDef likewise
Cut    = record cut + T/10
Damage% = (int)((int)(3.21T + (T/2.5)·T/3 + T²/7) * 0.1) * 0.01
```

## What `DamagePercent` is (Code)

It is the monster's attack stat. `MobNormalAttack.calcMobToPlayerDamage` 0x1F630D8 (and `MobMagicAttack`, same shape):

```
power  = MobAttackBase.CalcBaseAttack(...)        # the attack pattern's own power (MasterActionPattern +0x3C), after
                                                  # buffs / barrier / High Raid or difficulty AttackRate
d      = mobLevel + (int)(DamagePercent * power) - playerLevel      (0x1F63594..0x1F63610)
d      = (int)(d * (100 - player.GetDefFact(DEF)) / 100)            (0x1F63680..0x1F636BC)
         ... then damage cut, guard, criticals, last-damage rates
```

So with `DamagePercent` 31.75 an attack pattern with power 100 hits for about 3,175 + level gap before the player's
defence. `GUILDRAID_BOSS.csv` column `damage_percent` holds this value.

## StatusCollection (MonsterPropertyType 40, new)

`MobPropertyStatusCollection.TryGetValue` 0x1F4A118: entries with `ValueA == stat` (1 Def, 2 MDef, 3 Cut, 4 CutMagic,
5 Guard, 6 Avoid, 7 Hit); `constant = ΣValueB`, `rate = ΣValueC / 100`. Boss: `stat = (int)((1 + rate) * stat + constant)`.
No cached record carries type 40; it comes from the orb-bought random properties (`GuildRaidRandamProperty`,
passed to the boss constructor), so it is not in the export.

## Constants

2.4 = `.rodata` 0x946FFC, 0.01 = 0x946F84, 0.7 = 0x946C40, 0.1 = 0x946BF0; 321 = `mov w10,#0x141`.

## Confidence

- Formulas: **Code**. Not checked against an in-game number.
- `L = 4G` and the level grid 40…320 in the export: **assumption** (the server picks both).
- Boss vs add class by record id: **inferred**.
