# Skill data coverage audit

Generated from `skill_reference.json` (577 tree skills, 630 records).

| State | Count | Meaning |
|---|---|---|
| complete | 468 | class decoded, no truncation (marker buffs listed separately) |
| partial | 0 | decoded but an open item remains (listed below) |
| buff-only / consumer-only | 24 | no action class; effect found through a buff or consumer code |
| no-client-code | 85 | proven no combat code: crafting/merchant/system/unreleased |
| unresolved | 0 | nothing found yet: real work left |

## unresolved


## partial


## Marker buffs (GetParam is constant 0, constructor sets nothing: presence flag only)

- 47 `FastAttackBuf` flags: ChangeEquipRemove; readers: `PlayerAttackBase$$CalcCostMp`, `PlayerAttackBase$$RemoveAfterSkillBuf`
- 52 `HammerDownBuf` flags: ChangeEquipRemove|HideBufferIcon; readers: `HammerDownAction$$ActionPreparation`, `HammerDownAction$$OnInitialize`, `PlayerAttackBase$$RemoveAfterSkillBuf`
- 101 `ChargingBuf` flags: default; readers: `MaximuyzerAction$$ActionStart`, `MaximuyzerSwitchingBuff$$ConverterMaximuyzerSwitching`, `PlayerAttackBase$$RemoveAfterSkillBuf`
- 523 `LevenirBuf` flags: default; readers: `LevenirAction$$AbnormalStack`, `LevenirAction$$ActionPreparation`, `LevenirAction$$Damaged`, `PlayerActionManager$$Damaged`
- 624 `OkaranmanBuf` flags: default; readers: `FacticeArmeAction$$ActionSkillEvent`, `IllusionarySceneAction$$ActionSkillEvent`, `IllusionarySceneAction$$Damaged`, `IllusionarySceneAction.<>c__DisplayClass30_0$$<ActionPreparation>b__0`, `MobAttackBase$$CalcLastDamage`
- 660 `HorizontalCutBuf` flags: ChangeEquipRemove; readers: `PlayerAttackBase$$RemoveAfterSkillBuf`
- 673 `BoomerangBuf` flags: ChangeEquipRemove|Special; readers: `L_Boomerang2Action$$ActionPreparation`, `L_Boomerang2Action$$OnInitialize`, `L_Boomerang3Action$$ActionPreparation`, `L_Boomerang3Action$$OnInitialize`, `L_BoomerangAction$$ActionPreparation` ...
- 677 `SoulHuntBuf` flags: default; readers: none by constant id (buff only shown/timed by the generic buff manager)
- 713 `SoulHuntBuf` flags: default; readers: `MobaPlayerActionManager$$Damaged`, `MobaPlayerActionManager$$ReceiveDamaged`, `MobaPlayerSecondaryStatus$$get_AntiVirus`, `PlayerActionManager$$AddEventAbnormal`, `PlayerActionManager$$Damaged` ...
- 714 `MagicBalkanBuf` flags: HideBufferIcon|Special; readers: none by constant id (buff only shown/timed by the generic buff manager)
- 807 `BeautiesOfNatureBuf` flags: default; readers: none by constant id (buff only shown/timed by the generic buff manager)
- 842 `ExorcismBuf` flags: ChangeEquipRemove; readers: `PlayerAttackBase$$CalcCostMp`, `PlayerAttackBase$$RemoveAfterSkillBuf`
- 867 `ConversionBuf` flags: ChangeEquipRemove; readers: `ConversionAction$$ActionHit`, `ElementSlashAction$$OnInitialize`, `EnchantedBurstAction$$OnInitialize`, `EnchantedSwordAction$$OnInitialize`, `EquipItemData.WeaponTypeCalculatorBase$$CalcMatk` ...
- 963 `DeadlySpearBuf` flags: ChangeEquipRemove; readers: `MobaPlayerActionManager$$ReceiveAttack`, `PlayerAttackBase$$CalcCostMp`, `PlayerAttackBase$$RemoveAfterSkillBuf`
- 1058 `SoulHuntBuf` flags: default; readers: none by constant id (buff only shown/timed by the generic buff manager)
- 1059 `SoulHuntBuf` flags: default; readers: none by constant id (buff only shown/timed by the generic buff manager)
- 1063 `SoulHuntBuf` flags: default; readers: `DarkStingerAction$$ActionStart`, `GameManager$$ReceiveActionSupportDelay`, `HealingShotAction$$CheckPayHp`, `ReceiveSupportResult$$OnActionPlayerSupport`, `ReceiveSupportResult$$OnEventPlayerSupport` ...

## Buff classes with no skill owner

- `BloodSuckingBuf`: created by SkillComboState.TemporaryUseSkill (combo system, not a skill id)
- `DancerBufferBase`: abstract base of the dance buffs
- `EquipSkillBufferBase`: abstract base class
- `GemCartHealStockpileBuf`: gem-cart buff, not a skill
- `SensoryBuf`: song helper (SkillBufferManager.UpdateValidSongBuf)
