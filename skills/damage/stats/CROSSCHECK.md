# Cross-check: Ghidra pseudo-C vs decoded formulas (core)

Per function: numeric constants and callee names present on one side only. A difference is not automatically a bug (Ghidra inlines / renames, we fold `//`, `int()`); every entry needs a look at the disassembly.

Functions compared: 18; identical constant+callee sets: 15.

- OK `DungeonMobBattleStatus$$get_DamagePercent`
- OK `EquipItemData.BowCalculator$$calcAtkParam`
- OK `EquipItemData.OneHundSwordCalculator$$CalcStable`
- OK `EquipItemData.OneHundSwordCalculator$$calcAtkParam`

## MobAttackBase$$CalcBaseAttack
- call_only_ghidra: ['TryGetValue']
- OK `MobBattleStatus$$get_Def`
- OK `MobBattleStatus$$get_StablePercent`
- OK `PlayerAttackBase$$CalcElementBonus`
- OK `PlayerAttackBase$$CalcLastDamageRate`
- OK `PlayerAttackBase$$CalcRegistDamage`
- OK `PlayerAttackBase$$CalcSkillTypeBonusRate`
- OK `PlayerSecondaryStatus$$GetCrtRate`
- OK `PlayerSecondaryStatus$$get_Atk`
- OK `PlayerSecondaryStatus$$get_Critical`
- OK `PlayerSecondaryStatus$$get_CriticalDmg`

## PlayerSecondaryStatus$$get_Cspd
- call_only_ghidra: ['SetSkillLearnData', 'UpdateMaxValue']
- OK `PlayerSecondaryStatus$$get_Hit`

## PlayerSecondaryStatus$$get_Stable
- call_only_ghidra: ['get_SubWeapon']