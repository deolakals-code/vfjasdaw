# Stats coverage

| group | functions | decoded | truncated | error |
|---|---|---|---|---|
| player | 217 | 217 | 0 | 0 |
| weapon | 152 | 152 | 0 | 0 |
| bonus | 65 | 65 | 0 | 0 |
| mob | 587 | 587 | 0 | 0 |
| attack | 86 | 86 | 0 | 0 |
| normal | 57 | 57 | 0 | 0 |

## Residual unresolved terms inside value-returning functions

### unnamed field read (10)

- `PlayerStatusBase$$GetEquipSubWeaponElement`: `...([_t244+0x14] eq 0 ? 7 : [_t244+0x14]) Syst...`
- `EquipItemData.WeaponTypeCalculatorBase$$CalcEqAtk`: `...fine(WeaponTypeCalculatorBase.item))) * ((_t325 + [WeaponTypeCalculatorBase.item+0x42]) + int(((min(_t326, 50) * [We...`
- `EquipItemData.BowgunCalculator$$calcAtkParam`: `...nager().SkillMasteryList[SkillId.BowgunHunter]) * [WeaponTypeCalculatorBase.item+0x42]) / 100)) + _t254))...`
- `BonusManager$$CheckEquipLimitBonusId`: `...(0 lt [BonusManager.limitList+0x18] ? 1 : 0) ...`
- `BonusManager$$CreateBonusParameter`: `..._t477 (([type+0x18] eq [val+0x18] && [type+0x18] ...`
- `DefenceMobBattleStatus$$get_GuardProbability`: `...ut) & 1) eq 0 ? invoke(Guard, statusMaster.guard, [Guard+0x28]) : (MobBuffer.GuardUpBuff.get...`
- `MobaOtherPlayerBattleStatus$$get_ExpDefNormal`: `...[<>8__2+0x18] ...`
- `MobaOtherPlayerBattleStatus$$get_ExpDefSkill`: `...[<>8__2+0x1c] ...`
- `MobaOtherPlayerBattleStatus$$get_ExpDefMagic`: `...[<>8__2+0x20] ...`
- `NormalAttackPattern$$OnPostUpdate`: `...((MobAnimation.IsPlay([pattern+0x40]) & 1) ne 0 ? 0 : 2) ...`

### unresolved indirect call (delegate / stub) (1)

- `HighRaidBossBattleStatus$$get_NecessaryHit`: `...aster.necessaryHit : ((_t528 & 1) eq 0 ? _t565 : (?blr + _t566)))...`


Not fully decoded:

- none