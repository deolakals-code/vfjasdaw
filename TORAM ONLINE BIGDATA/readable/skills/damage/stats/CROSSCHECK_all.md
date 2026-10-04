# Cross-check: Ghidra pseudo-C vs decoded formulas (all)

Per function: numeric constants and callee names present on one side only. A difference is not automatically a bug (Ghidra inlines / renames, we fold `//`, `int()`); every entry needs a look at the disassembly.

Functions compared: 1164; identical constant+callee sets: 925.

- OK `BCollaboBossMobBattleStatus$$CalcDef`
- OK `BCollaboBossMobBattleStatus$$CalcMdef`
- OK `BCollaboBossMobBattleStatus$$SetMobStatus`
- OK `BCollaboBossMobBattleStatus$$get_AvoidProbability`
- OK `BCollaboBossMobBattleStatus$$get_CutAttack`
- OK `BCollaboBossMobBattleStatus$$get_CutMagicAttack`
- OK `BCollaboBossMobBattleStatus$$get_DamagePercent`
- OK `BCollaboBossMobBattleStatus$$get_Def`
- OK `BCollaboBossMobBattleStatus$$get_Element`
- OK `BCollaboBossMobBattleStatus$$get_ExpDefMagic`
- OK `BCollaboBossMobBattleStatus$$get_ExpDefNormal`
- OK `BCollaboBossMobBattleStatus$$get_ExpDefSkill`
- OK `BCollaboBossMobBattleStatus$$get_GuardProbability`
- OK `BCollaboBossMobBattleStatus$$get_Level`
- OK `BCollaboBossMobBattleStatus$$get_MagicDef`
- OK `BCollaboBossMobBattleStatus$$get_MaxHp`
- OK `BCollaboBossMobBattleStatus$$get_MoveSpeed`
- OK `BCollaboBossMobBattleStatus$$get_NecessaryFleePercent`
- OK `BCollaboBossMobBattleStatus$$get_NecessaryHit`
- OK `BCollaboBossMobBattleStatus$$get_PartsStatus`
- OK `BCollaboBossMobBattleStatus$$get_Persona`
- OK `BCollaboBossMobBattleStatus$$get_PersonaValue`
- OK `BCollaboBossMobBattleStatus$$get_Property`
- OK `BCollaboBossMobBattleStatus$$get_StablePercent`
- OK `BCollaboMobBattleStatus$$CalcDef`
- OK `BCollaboMobBattleStatus$$CalcMdef`
- OK `BCollaboMobBattleStatus$$SetMobStatus`
- OK `BCollaboMobBattleStatus$$get_AvoidProbability`
- OK `BCollaboMobBattleStatus$$get_CutAttack`
- OK `BCollaboMobBattleStatus$$get_CutMagicAttack`
- OK `BCollaboMobBattleStatus$$get_DamagePercent`
- OK `BCollaboMobBattleStatus$$get_Def`
- OK `BCollaboMobBattleStatus$$get_Element`
- OK `BCollaboMobBattleStatus$$get_ExpDefMagic`
- OK `BCollaboMobBattleStatus$$get_ExpDefNormal`
- OK `BCollaboMobBattleStatus$$get_ExpDefSkill`
- OK `BCollaboMobBattleStatus$$get_GuardProbability`
- OK `BCollaboMobBattleStatus$$get_Level`
- OK `BCollaboMobBattleStatus$$get_MagicDef`
- OK `BCollaboMobBattleStatus$$get_MaxHp`
- OK `BCollaboMobBattleStatus$$get_MoveSpeed`
- OK `BCollaboMobBattleStatus$$get_NecessaryFleePercent`
- OK `BCollaboMobBattleStatus$$get_NecessaryHit`
- OK `BCollaboMobBattleStatus$$get_Persona`
- OK `BCollaboMobBattleStatus$$get_PersonaValue`
- OK `BCollaboMobBattleStatus$$get_Property`
- OK `BCollaboMobBattleStatus$$get_StablePercent`
- OK `BlackKnightPlayerStatus$$AddAtk`

## BlackKnightPlayerStatus$$AddDef
- call_only_ghidra: ['CONCAT44']
- OK `BlackKnightPlayerStatus$$AddHp`
- OK `BlackKnightPlayerStatus$$AddMAtk`

## BlackKnightPlayerStatus$$ChangeCrstaState
- call_only_ghidra: ['AddWithResize', 'ContainsEquipCrista', 'Remove']
- OK `BlackKnightPlayerStatus$$ContainsEquipCrista`

## BlackKnightPlayerStatus$$Damage
- call_only_ghidra: ['Add', 'ContainsKey', 'get_Item', 'set_Item']
- OK `BlackKnightPlayerStatus$$EnoughMp`

## BlackKnightPlayerStatus$$GetCristaBonus
- call_only_ghidra: ['Contains', 'ContainsEquipCrista', 'Dispose', 'GetEnumerator', 'MoveNext']
- OK `BlackKnightPlayerStatus$$GetDefPercent`
- OK `BlackKnightPlayerStatus$$InitCristaStatus`

## BlackKnightPlayerStatus$$Initialize
- call_only_ghidra: ['CONCAT44', 'InitializeCrista']

## BlackKnightPlayerStatus$$InitializeCrista
- call_only_ghidra: ['ChangeCrstaState', 'InitCristaStatus']

## BlackKnightPlayerStatus$$InvokeMirageStep
- call_only_ghidra: ['Add', 'get_Item']
- OK `BlackKnightPlayerStatus$$PaySkillMp`
- OK `BlackKnightPlayerStatus$$SetHp`
- OK `BlackKnightPlayerStatus$$StartMpRecovery`

## BlackKnightPlayerStatus$$UpdateStatus
- call_only_ghidra: ['Remove', 'ToArray<Int32Enum>', 'get_Keys', 'set_Item']
- OK `BlackKnightPlayerStatus$$get_Atk`
- OK `BlackKnightPlayerStatus$$get_Crt`
- OK `BlackKnightPlayerStatus$$get_Def`
- OK `BlackKnightPlayerStatus$$get_Hp`
- OK `BlackKnightPlayerStatus$$get_IsDead`
- OK `BlackKnightPlayerStatus$$get_IsInit`
- OK `BlackKnightPlayerStatus$$get_IsInvincible`
- OK `BlackKnightPlayerStatus$$get_MAtk`
- OK `BlackKnightPlayerStatus$$get_MaxHp`
- OK `BlackKnightPlayerStatus$$get_Mp`
- OK `BlackKnightPlayerStatus$$get_Name`
- OK `BlackKnightPlayerStatus$$get_RecoveryCount`
- OK `BlackKnightPlayerStatus$$set_IsInit`
- OK `BlackKnightPlayerStatus$$set_RecoveryCount`

## BonusManager$$AddDungeonBonus
- call_only_ghidra: ['Add', 'AddWithResize', 'CountUp', 'CreateBonus', 'Remove', '_ctor']

## BonusManager$$AddEquipCristaBonus
- call_only_ghidra: ['Add', 'AddWithResize', 'ContainsKey', '_ctor', 'get_Item']

## BonusManager$$AddGemBonus
- call_only_ghidra: ['Add', 'AddWithResize', 'CreateBonus']

## BonusManager$$AddGemCartBonus
- call_only_ghidra: ['Add', 'AddWithResize', 'CreateBonus']

## BonusManager$$AddGuildFacilityBonus
- call_only_ghidra: ['Add', 'AddWithResize', 'Clear', 'CreateBonus', 'Remove', '_ctor']

## BonusManager$$AddTreasureHuntBonus
- call_only_ghidra: ['Add', 'AddWithResize', 'CreateBonus', '_ctor']
- OK `BonusManager$$CheckEquipLimitBonusId`

## BonusManager$$ClearDebuff
- call_only_ghidra: ['Clear']

## BonusManager$$ClearDungeonBonus
- call_only_ghidra: ['Clear', 'Dispose', 'GetEnumerator', 'MoveNext', 'Remove', 'get_Values']

## BonusManager$$ClearDurationBonus
- call_only_ghidra: ['Clear', 'Dispose', 'GetEnumerator', 'MoveNext', 'Remove', 'get_Values']

## BonusManager$$ClearGemBonus
- call_only_ghidra: ['Clear', 'Dispose', 'GetEnumerator', 'MoveNext', 'Remove', 'get_Values']

## BonusManager$$ClearGemCartBonus
- call_only_ghidra: ['Clear', 'Dispose', 'GetEnumerator', 'MoveNext', 'Remove', 'get_Values']

## BonusManager$$ClearItemRandomProperty
- call_only_ghidra: ['Clear', 'Dispose', 'GetEnumerator', 'MoveNext', 'Remove', 'get_Values']

## BonusManager$$ClearTreasureHuntBonus
- call_only_ghidra: ['Clear', 'Dispose', 'GetEnumerator', 'MoveNext', 'Remove', 'get_Values']

## BonusManager$$CreateBonus
- call_only_ghidra: ['AddRange', 'AddWithResize', 'Clear', 'Dispose', 'GetEnumerator', 'MoveNext', '_ctor']

## BonusManager$$CreateBonusParameter
- call_only_ghidra: ['AddWithResize', '_ctor']

## BonusManager$$CreateDebuff
- call_only_ghidra: ['_ctor']

## BonusManager$$CulcConvertAtk
- call_only_ghidra: ['Add', 'Dispose', 'GetEnumerator', '_ctor']

## BonusManager$$CulcConvertMAtk
- call_only_ghidra: ['Add', 'Dispose', 'GetEnumerator', '_ctor']

## BonusManager$$EndGemBonus
- call_only_ghidra: ['ContainsKey', 'End', 'Remove', 'get_Item']

## BonusManager$$EndItemRandomProperty
- call_only_ghidra: ['Remove', 'TryGetValue']
- OK `BonusManager$$GetAvatarBonusValue`

## BonusManager$$GetBonusConstant_AvatarConstan_Rate
- call_only_ghidra: ['RunBonus', 'get_Item']

## BonusManager$$GetBonusConstant_Rate
- call_only_ghidra: ['RunBonus', 'get_Item']

## BonusManager$$GetBonusMultiPercentValue
- call_only_ghidra: ['Contains', 'ContainsKey', 'Dispose', 'GetEnumerator', 'MoveNext', 'RunBonus', 'Where<object>', '_ctor']
- OK `BonusManager$$GetBonusPercentValue`
- OK `BonusManager$$GetBonusTime`

## BonusManager$$GetBonusValue
- call_only_ghidra: ['RunBonus', 'get_Item']
- OK `BonusManager$$GetBuffValue`

## BonusManager$$GetCalcBonusValue
- call_only_ghidra: ['Contains', 'Dispose', 'GetEnumerator', 'RunBonus']
- OK `BonusManager$$GetDurationBonus`
- OK `BonusManager$$GetElementKiller`

## BonusManager$$GetEquipElement
- call_only_ghidra: ['FirstOrDefault<object>', '_ctor']

## BonusManager$$GetGuildFacilityElementBonus
- call_only_ghidra: ['ContainsKey', 'get_Item']
- OK `BonusManager$$GetGuildFacilityExpBonus`

## BonusManager$$GetMaxBonusConstant_Rate
- call_only_ghidra: ['RunBonus', 'get_Item']

## BonusManager$$GetMaxHpBonusConstant_Rate
- call_only_ghidra: ['GetMaxBonusConstant_Rate']

## BonusManager$$GetMaxMpBonusConstant_Rate
- call_only_ghidra: ['GetMaxBonusConstant_Rate']
- OK `BonusManager$$GetRestTime`
- OK `BonusManager$$GetTreasureHuntLastDmgRateBonus`
- OK `BonusManager$$GetTreasureHuntLastDmgedDownRateBonus`

## BonusManager$$InitBonus
- call_only_ghidra: ['InitNewBonus', 'Run', 'SetDurationBonus', 'UpdateBonusList']

## BonusManager$$Initialize
- call_only_ghidra: ['_ctor']

## BonusManager$$RemoveGemCartBonus
- call_only_ghidra: ['Remove', 'TryGetValue']

## BonusManager$$RunBonus
- call_only_ghidra: ['Run', 'UpdateBonusList']

## BonusManager$$SetDebuff
- call_only_ghidra: ['Add', 'AddSystemMessage', 'Dispose', 'GetEnumerator', 'Remove', 'get_Instance']

## BonusManager$$SetDurationBonus
- call_only_ghidra: ['Add', 'AddWithResize', 'ContainsKey', 'Remove', 'get_Item', 'set_Item']

## BonusManager$$SetEquipBonus
- call_only_ghidra: ['Add', 'AddWithResize', 'ContainsKey', 'Dispose', 'GetEnumerator', 'MoveNext', 'Remove', 'get_Item', 'set_Item']

## BonusManager$$StartGemBonus
- call_only_ghidra: ['AddWithResize', 'Contains', 'Dispose', 'GetEnumerator', 'MoveNext', 'get_Values']

## BonusManager$$StartItemRandomProperty
- call_only_ghidra: ['Add', 'AddWithResize', 'Remove', 'TryGetValue']

## BonusManager$$TryGetAvatarSkillEquipType
- call_only_ghidra: ['Dispose', 'GetEnumerator']
- OK `BonusManager$$TryGetDebuff`

## BonusManager$$Update
- call_only_ghidra: ['AddWithResize', 'CreateBonusBuf', 'Dispose', 'GetEnumerator', 'Remove', 'RunBonus', 'ToArray', '_ctor', 'get_IsEnd', 'get_Item', 'get_Values']

## BonusManager$$UpdateEquipLimitBonus
- call_only_ghidra: ['Dispose', 'ForEach', 'GetEnumerator', 'MoveNext', 'RunBonus', '_ctor']

## BonusManager$$UpdateGemCartBonus
- call_only_ghidra: ['Add', 'AddWithResize', 'CreateBonus']

## BonusManager$$add_OnInvokeBonus
- call_only_ghidra: ['Combine']

## BonusManager$$getDataBonusValue
- call_only_ghidra: ['RunBonus']
- OK `BonusManager$$get_AllBonusList`
- OK `BonusManager$$get_BonusScriptManager`

## BonusManager$$get_DebuffList
- call_only_ghidra: ['ToList<object>']

## BonusManager$$get_DurationBonusList
- call_only_ghidra: ['ToList<object>']
- OK `BonusManager$$get_HasGemBonus`
- OK `BonusManager$$get_ItemRandomPropertyBonusList`

## BonusManager$$get_TreasureHuntBonusList
- call_only_ghidra: ['ToArray<object>']

## BonusManager$$remove_OnInvokeBonus
- call_only_ghidra: ['Remove']
- OK `BossMobBattleStatus$$CalcDef`
- OK `BossMobBattleStatus$$CalcMdef`
- OK `BossMobBattleStatus$$SetMobStatus`

## BossMobBattleStatus$$get_AvoidProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']

## BossMobBattleStatus$$get_CutAttack
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']

## BossMobBattleStatus$$get_CutMagicAttack
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']

## BossMobBattleStatus$$get_DamagePercent
- call_only_ghidra: ['ZEXT816']

## BossMobBattleStatus$$get_Def
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `BossMobBattleStatus$$get_Element`
- OK `BossMobBattleStatus$$get_ExpDefMagic`
- OK `BossMobBattleStatus$$get_ExpDefNormal`
- OK `BossMobBattleStatus$$get_ExpDefSkill`

## BossMobBattleStatus$$get_GuardProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `BossMobBattleStatus$$get_Level`

## BossMobBattleStatus$$get_MagicDef
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `BossMobBattleStatus$$get_MaxHp`

## BossMobBattleStatus$$get_MoveSpeed
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `BossMobBattleStatus$$get_NecessaryFleePercent`

## BossMobBattleStatus$$get_NecessaryHit
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `BossMobBattleStatus$$get_PartsStatus`
- OK `BossMobBattleStatus$$get_Persona`
- OK `BossMobBattleStatus$$get_PersonaValue`
- OK `BossMobBattleStatus$$get_Property`
- OK `BossMobBattleStatus$$get_StablePercent`
- OK `DefenceBossBattleStatus$$CalcDef`
- OK `DefenceBossBattleStatus$$CalcMdef`
- OK `DefenceBossBattleStatus$$SetMobStatus`

## DefenceBossBattleStatus$$get_AvoidProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `DefenceBossBattleStatus$$get_CutAttack`
- OK `DefenceBossBattleStatus$$get_CutMagicAttack`
- OK `DefenceBossBattleStatus$$get_DamagePercent`

## DefenceBossBattleStatus$$get_Def
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `DefenceBossBattleStatus$$get_Element`
- OK `DefenceBossBattleStatus$$get_ExpDefMagic`
- OK `DefenceBossBattleStatus$$get_ExpDefNormal`
- OK `DefenceBossBattleStatus$$get_ExpDefSkill`
- OK `DefenceBossBattleStatus$$get_Guard`

## DefenceBossBattleStatus$$get_GuardProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `DefenceBossBattleStatus$$get_Level`

## DefenceBossBattleStatus$$get_MagicDef
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `DefenceBossBattleStatus$$get_MaxHp`

## DefenceBossBattleStatus$$get_MoveSpeed
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `DefenceBossBattleStatus$$get_NecessaryFleePercent`

## DefenceBossBattleStatus$$get_NecessaryHit
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `DefenceBossBattleStatus$$get_PartsStatus`
- OK `DefenceBossBattleStatus$$get_Persona`
- OK `DefenceBossBattleStatus$$get_PersonaValue`
- OK `DefenceBossBattleStatus$$get_Property`
- OK `DefenceBossBattleStatus$$get_StablePercent`
- OK `DefenceMobBattleStatus$$CalcDef`
- OK `DefenceMobBattleStatus$$CalcMdef`
- OK `DefenceMobBattleStatus$$SetMobStatus`
- OK `DefenceMobBattleStatus$$get_AvoidProbability`
- OK `DefenceMobBattleStatus$$get_CutAttack`
- OK `DefenceMobBattleStatus$$get_CutMagicAttack`
- OK `DefenceMobBattleStatus$$get_DamagePercent`
- OK `DefenceMobBattleStatus$$get_Def`
- OK `DefenceMobBattleStatus$$get_Element`
- OK `DefenceMobBattleStatus$$get_ExpDefMagic`
- OK `DefenceMobBattleStatus$$get_ExpDefNormal`
- OK `DefenceMobBattleStatus$$get_ExpDefSkill`
- OK `DefenceMobBattleStatus$$get_Guard`
- OK `DefenceMobBattleStatus$$get_GuardProbability`
- OK `DefenceMobBattleStatus$$get_Level`
- OK `DefenceMobBattleStatus$$get_MagicDef`
- OK `DefenceMobBattleStatus$$get_MaxHp`
- OK `DefenceMobBattleStatus$$get_MoveSpeed`
- OK `DefenceMobBattleStatus$$get_NecessaryFleePercent`
- OK `DefenceMobBattleStatus$$get_NecessaryHit`
- OK `DefenceMobBattleStatus$$get_Persona`
- OK `DefenceMobBattleStatus$$get_PersonaValue`
- OK `DefenceMobBattleStatus$$get_Property`
- OK `DefenceMobBattleStatus$$get_StablePercent`
- OK `DungeonBossMobBattleStatus$$CalcDef`
- OK `DungeonBossMobBattleStatus$$CalcMdef`
- OK `DungeonBossMobBattleStatus$$SetMobStatus`

## DungeonBossMobBattleStatus$$get_AvoidProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `DungeonBossMobBattleStatus$$get_CutAttack`
- OK `DungeonBossMobBattleStatus$$get_CutMagicAttack`
- OK `DungeonBossMobBattleStatus$$get_DamagePercent`

## DungeonBossMobBattleStatus$$get_Def
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `DungeonBossMobBattleStatus$$get_Element`
- OK `DungeonBossMobBattleStatus$$get_ExpDefMagic`
- OK `DungeonBossMobBattleStatus$$get_ExpDefNormal`
- OK `DungeonBossMobBattleStatus$$get_ExpDefSkill`

## DungeonBossMobBattleStatus$$get_GuardProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `DungeonBossMobBattleStatus$$get_Level`

## DungeonBossMobBattleStatus$$get_MagicDef
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `DungeonBossMobBattleStatus$$get_MaxHp`

## DungeonBossMobBattleStatus$$get_MoveSpeed
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `DungeonBossMobBattleStatus$$get_NecessaryFleePercent`

## DungeonBossMobBattleStatus$$get_NecessaryHit
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `DungeonBossMobBattleStatus$$get_PartsStatus`
- OK `DungeonBossMobBattleStatus$$get_Persona`
- OK `DungeonBossMobBattleStatus$$get_PersonaValue`
- OK `DungeonBossMobBattleStatus$$get_Property`
- OK `DungeonBossMobBattleStatus$$get_StablePercent`
- OK `DungeonMobBattleStatus$$CalcDef`
- OK `DungeonMobBattleStatus$$CalcMdef`
- OK `DungeonMobBattleStatus$$SetMobStatus`
- OK `DungeonMobBattleStatus$$get_AvoidProbability`
- OK `DungeonMobBattleStatus$$get_CutAttack`
- OK `DungeonMobBattleStatus$$get_CutMagicAttack`
- OK `DungeonMobBattleStatus$$get_DamagePercent`
- OK `DungeonMobBattleStatus$$get_Def`
- OK `DungeonMobBattleStatus$$get_Element`
- OK `DungeonMobBattleStatus$$get_ExpDefMagic`
- OK `DungeonMobBattleStatus$$get_ExpDefNormal`
- OK `DungeonMobBattleStatus$$get_ExpDefSkill`
- OK `DungeonMobBattleStatus$$get_GuardProbability`
- OK `DungeonMobBattleStatus$$get_Level`
- OK `DungeonMobBattleStatus$$get_MagicDef`
- OK `DungeonMobBattleStatus$$get_MaxHp`
- OK `DungeonMobBattleStatus$$get_MoveSpeed`
- OK `DungeonMobBattleStatus$$get_NecessaryFleePercent`
- OK `DungeonMobBattleStatus$$get_NecessaryHit`
- OK `DungeonMobBattleStatus$$get_Persona`
- OK `DungeonMobBattleStatus$$get_PersonaValue`
- OK `DungeonMobBattleStatus$$get_Property`
- OK `DungeonMobBattleStatus$$get_StablePercent`

## EquipItemData$$CalcDef
- call_only_ghidra: ['NAN', 'get_Option', 'get_Special']
- OK `EquipItemData$$CalcEqDef`

## EquipItemData$$CalcFlee
- call_only_ghidra: ['GetBonusConstant_AvatarConstan_Rate', 'GetSkillBufferParam', 'NAN', 'TryGetValue']

## EquipItemData$$CalcMdef
- call_only_ghidra: ['NAN', 'get_Option', 'get_Special']

## EquipItemData$$CheckEquipItem
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_Values']
- OK `EquipItemData$$GetEquip`

## EquipItemData$$SetEquipItem
- call_only_ghidra: ['Remove']

## EquipItemData$$createWeaponCalculator
- call_only_ghidra: ['_ctor']
- OK `EquipItemData$$get_AvatarBottom`
- OK `EquipItemData$$get_AvatarOption`
- OK `EquipItemData$$get_AvatarTop`
- OK `EquipItemData$$get_Body`
- OK `EquipItemData$$get_Decoration`
- OK `EquipItemData$$get_MainWeaponCalculator`
- OK `EquipItemData$$get_Option`
- OK `EquipItemData$$get_Special`
- OK `EquipItemData$$get_SubWeapon`
- OK `EquipItemData$$get_SubWeaponCalculator`
- OK `EquipItemData$$get_SubWeaponItemType`
- OK `EquipItemData$$get_Weapon`
- OK `EquipItemData$$get_WeaponItemType`
- OK `EquipItemData.ArrowCalculator$$CalcStable`
- OK `EquipItemData.ArrowCalculator$$CalcSubAtk`
- OK `EquipItemData.ArrowCalculator$$SubCalcMatk`
- OK `EquipItemData.ArrowCalculator$$SubCalcStable`
- OK `EquipItemData.ArrowCalculator$$calcAspdParam`
- OK `EquipItemData.ArrowCalculator$$calcAtkParam`
- OK `EquipItemData.ArrowCalculator$$calcEqAtkBonus`
- OK `EquipItemData.ArrowCalculator$$calcMatkParam`
- OK `EquipItemData.BowCalculator$$CalcStable`
- OK `EquipItemData.BowCalculator$$CalcSubAtk`
- OK `EquipItemData.BowCalculator$$CorrectHit`
- OK `EquipItemData.BowCalculator$$SubCalcMatk`
- OK `EquipItemData.BowCalculator$$SubCalcStable`
- OK `EquipItemData.BowCalculator$$calcAspdParam`
- OK `EquipItemData.BowCalculator$$calcAtkParam`

## EquipItemData.BowCalculator$$calcEqAtkBonus
- call_only_ghidra: ['TryGetValue']
- OK `EquipItemData.BowCalculator$$calcMatkParam`
- OK `EquipItemData.BowgunCalculator$$CalcStable`
- OK `EquipItemData.BowgunCalculator$$CalcSubAtk`
- OK `EquipItemData.BowgunCalculator$$CorrectHit`
- OK `EquipItemData.BowgunCalculator$$SubCalcMatk`
- OK `EquipItemData.BowgunCalculator$$SubCalcStable`
- OK `EquipItemData.BowgunCalculator$$calcAspdParam`
- OK `EquipItemData.BowgunCalculator$$calcAtkParam`

## EquipItemData.BowgunCalculator$$calcEqAtkBonus
- call_only_ghidra: ['TryGetValue']
- OK `EquipItemData.BowgunCalculator$$calcMatkParam`
- OK `EquipItemData.HalberdCalculator$$CalcStable`
- OK `EquipItemData.HalberdCalculator$$CalcSubAtk`
- OK `EquipItemData.HalberdCalculator$$CorrectHit`
- OK `EquipItemData.HalberdCalculator$$SubCalcMatk`
- OK `EquipItemData.HalberdCalculator$$SubCalcStable`
- OK `EquipItemData.HalberdCalculator$$calcAspdParam`
- OK `EquipItemData.HalberdCalculator$$calcAtkParam`

## EquipItemData.HalberdCalculator$$calcEqAtkBonus
- call_only_ghidra: ['TryGetValue']
- OK `EquipItemData.HalberdCalculator$$calcMatkParam`
- OK `EquipItemData.HundCalculator$$CalcStable`
- OK `EquipItemData.HundCalculator$$CalcSubAtk`
- OK `EquipItemData.HundCalculator$$CalcSubEqAtk`
- OK `EquipItemData.HundCalculator$$CorrectHit`
- OK `EquipItemData.HundCalculator$$SubCalcMatk`
- OK `EquipItemData.HundCalculator$$SubCalcStable`
- OK `EquipItemData.HundCalculator$$calcAspdParam`
- OK `EquipItemData.HundCalculator$$calcAtkParam`

## EquipItemData.HundCalculator$$calcEqAtkBonus
- call_only_ghidra: ['ContainsKey']
- OK `EquipItemData.HundCalculator$$calcMatkParam`
- OK `EquipItemData.KatanaCalculator$$CalcStable`

## EquipItemData.KatanaCalculator$$CalcSubAtk
- call_only_ghidra: ['get_SubWeapon']
- OK `EquipItemData.KatanaCalculator$$CorrectHit`
- OK `EquipItemData.KatanaCalculator$$SubCalcMatk`
- OK `EquipItemData.KatanaCalculator$$SubCalcStable`
- OK `EquipItemData.KatanaCalculator$$calcAspdParam`
- OK `EquipItemData.KatanaCalculator$$calcAtkParam`

## EquipItemData.KatanaCalculator$$calcEqAtkBonus
- call_only_ghidra: ['TryGetValue']
- OK `EquipItemData.KatanaCalculator$$calcMatkParam`
- OK `EquipItemData.KnuckleCalculator$$CalcStable`
- OK `EquipItemData.KnuckleCalculator$$CalcSubAtk`
- OK `EquipItemData.KnuckleCalculator$$CorrectHit`
- OK `EquipItemData.KnuckleCalculator$$SubCalcMatk`
- OK `EquipItemData.KnuckleCalculator$$SubCalcStable`
- OK `EquipItemData.KnuckleCalculator$$calcAspdParam`
- OK `EquipItemData.KnuckleCalculator$$calcAtkParam`

## EquipItemData.KnuckleCalculator$$calcEqAtkBonus
- call_only_ghidra: ['TryGetValue']
- OK `EquipItemData.KnuckleCalculator$$calcMatkParam`
- OK `EquipItemData.MagictoolCalculator$$CalcStable`
- OK `EquipItemData.MagictoolCalculator$$CalcSubAtk`
- OK `EquipItemData.MagictoolCalculator$$CorrectHit`
- OK `EquipItemData.MagictoolCalculator$$SubCalcMatk`
- OK `EquipItemData.MagictoolCalculator$$SubCalcStable`
- OK `EquipItemData.MagictoolCalculator$$calcAspdParam`
- OK `EquipItemData.MagictoolCalculator$$calcAtkParam`

## EquipItemData.MagictoolCalculator$$calcEqAtkBonus
- call_only_ghidra: ['TryGetValue']
- OK `EquipItemData.MagictoolCalculator$$calcMatkParam`
- OK `EquipItemData.NinjutsuScrollCalculator$$CalcStable`
- OK `EquipItemData.NinjutsuScrollCalculator$$CalcSubAtk`
- OK `EquipItemData.NinjutsuScrollCalculator$$SubCalcMatk`
- OK `EquipItemData.NinjutsuScrollCalculator$$SubCalcStable`
- OK `EquipItemData.NinjutsuScrollCalculator$$calcAspdParam`
- OK `EquipItemData.NinjutsuScrollCalculator$$calcAtkParam`
- OK `EquipItemData.NinjutsuScrollCalculator$$calcEqAtkBonus`
- OK `EquipItemData.NinjutsuScrollCalculator$$calcMatkParam`
- OK `EquipItemData.OneHundSwordCalculator$$CalcStable`

## EquipItemData.OneHundSwordCalculator$$CalcSubAtk
- call_only_ghidra: ['GetSkillLv', 'get_SubWeapon']
- OK `EquipItemData.OneHundSwordCalculator$$CalcSubEqAtk`
- OK `EquipItemData.OneHundSwordCalculator$$CorrectHit`
- OK `EquipItemData.OneHundSwordCalculator$$SubCalcMatk`

## EquipItemData.OneHundSwordCalculator$$SubCalcStable
- call_only_ghidra: ['GetSkillLv']
- OK `EquipItemData.OneHundSwordCalculator$$calcAspdParam`
- OK `EquipItemData.OneHundSwordCalculator$$calcAtkParam`

## EquipItemData.OneHundSwordCalculator$$calcEqAtkBonus
- call_only_ghidra: ['TryGetValue']
- OK `EquipItemData.OneHundSwordCalculator$$calcMatkParam`
- OK `EquipItemData.RodCalculator$$CalcStable`
- OK `EquipItemData.RodCalculator$$CalcSubAtk`
- OK `EquipItemData.RodCalculator$$CorrectHit`
- OK `EquipItemData.RodCalculator$$SubCalcMatk`
- OK `EquipItemData.RodCalculator$$SubCalcStable`
- OK `EquipItemData.RodCalculator$$calcAspdParam`
- OK `EquipItemData.RodCalculator$$calcAtkParam`

## EquipItemData.RodCalculator$$calcEqAtkBonus
- call_only_ghidra: ['TryGetValue']
- OK `EquipItemData.RodCalculator$$calcMatkParam`
- OK `EquipItemData.ShieldCalculator$$CalcStable`
- OK `EquipItemData.ShieldCalculator$$CalcSubAtk`
- OK `EquipItemData.ShieldCalculator$$SubCalcMatk`
- OK `EquipItemData.ShieldCalculator$$SubCalcStable`
- OK `EquipItemData.ShieldCalculator$$calcAspdParam`
- OK `EquipItemData.ShieldCalculator$$calcAtkParam`
- OK `EquipItemData.ShieldCalculator$$calcEqAtkBonus`
- OK `EquipItemData.ShieldCalculator$$calcMatkParam`
- OK `EquipItemData.ShortSwordCalculator$$CalcStable`
- OK `EquipItemData.ShortSwordCalculator$$CalcSubAtk`
- OK `EquipItemData.ShortSwordCalculator$$SubCalcMatk`
- OK `EquipItemData.ShortSwordCalculator$$SubCalcStable`
- OK `EquipItemData.ShortSwordCalculator$$calcAspdParam`
- OK `EquipItemData.ShortSwordCalculator$$calcAtkParam`
- OK `EquipItemData.ShortSwordCalculator$$calcEqAtkBonus`
- OK `EquipItemData.ShortSwordCalculator$$calcMatkParam`
- OK `EquipItemData.TwoHundSwordCalculator$$CalcStable`
- OK `EquipItemData.TwoHundSwordCalculator$$CalcSubAtk`
- OK `EquipItemData.TwoHundSwordCalculator$$CorrectHit`
- OK `EquipItemData.TwoHundSwordCalculator$$SubCalcMatk`
- OK `EquipItemData.TwoHundSwordCalculator$$SubCalcStable`
- OK `EquipItemData.TwoHundSwordCalculator$$calcAspdParam`
- OK `EquipItemData.TwoHundSwordCalculator$$calcAtkParam`

## EquipItemData.TwoHundSwordCalculator$$calcEqAtkBonus
- call_only_ghidra: ['TryGetValue']
- OK `EquipItemData.TwoHundSwordCalculator$$calcMatkParam`
- OK `EquipItemData.WeaponTypeCalculatorBase$$CalcAspd`
- OK `EquipItemData.WeaponTypeCalculatorBase$$CalcAtk`

## EquipItemData.WeaponTypeCalculatorBase$$CalcEqAtk
- call_only_ghidra: ['get_SubWeapon', 'get_Weapon']
- OK `EquipItemData.WeaponTypeCalculatorBase$$CalcMatk`
- OK `EquipItemData.WeaponTypeCalculatorBase$$CalcSubEqAtk`
- OK `EquipItemData.WeaponTypeCalculatorBase$$CorrectHit`
- OK `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- OK `GuildRaidBossMobBattleStatus$$CalcDef`
- OK `GuildRaidBossMobBattleStatus$$CalcMdef`
- OK `GuildRaidBossMobBattleStatus$$SetMobStatus`

## GuildRaidBossMobBattleStatus$$get_AvoidProbability
- call_only_ghidra: ['Sum<object>', '_ctor']

## GuildRaidBossMobBattleStatus$$get_CutAttack
- call_only_ghidra: ['Sum<object>', '_ctor']

## GuildRaidBossMobBattleStatus$$get_CutMagicAttack
- call_only_ghidra: ['Sum<object>', '_ctor']
- OK `GuildRaidBossMobBattleStatus$$get_DamagePercent`

## GuildRaidBossMobBattleStatus$$get_Def
- call_only_ghidra: ['Sum<object>', '_ctor']
- OK `GuildRaidBossMobBattleStatus$$get_Element`
- OK `GuildRaidBossMobBattleStatus$$get_ExpDefMagic`
- OK `GuildRaidBossMobBattleStatus$$get_ExpDefNormal`
- OK `GuildRaidBossMobBattleStatus$$get_ExpDefSkill`

## GuildRaidBossMobBattleStatus$$get_GuardProbability
- call_only_ghidra: ['Sum<object>', '_ctor']
- OK `GuildRaidBossMobBattleStatus$$get_Level`

## GuildRaidBossMobBattleStatus$$get_MagicDef
- call_only_ghidra: ['Sum<object>', '_ctor']
- OK `GuildRaidBossMobBattleStatus$$get_MaxHp`

## GuildRaidBossMobBattleStatus$$get_MoveSpeed
- call_only_ghidra: ['Sum<object>', '_ctor']
- OK `GuildRaidBossMobBattleStatus$$get_NecessaryFleePercent`

## GuildRaidBossMobBattleStatus$$get_NecessaryHit
- call_only_ghidra: ['Sum<object>', '_ctor']
- OK `GuildRaidBossMobBattleStatus$$get_PartsStatus`
- OK `GuildRaidBossMobBattleStatus$$get_Persona`
- OK `GuildRaidBossMobBattleStatus$$get_PersonaValue`
- OK `GuildRaidBossMobBattleStatus$$get_Property`
- OK `GuildRaidBossMobBattleStatus$$get_StablePercent`
- OK `GuildRaidEntourageMobBattleStatus$$CalcDef`
- OK `GuildRaidEntourageMobBattleStatus$$CalcMdef`
- OK `GuildRaidEntourageMobBattleStatus$$SetMobStatus`
- OK `GuildRaidEntourageMobBattleStatus$$get_AvoidProbability`
- OK `GuildRaidEntourageMobBattleStatus$$get_CutAttack`
- OK `GuildRaidEntourageMobBattleStatus$$get_CutMagicAttack`
- OK `GuildRaidEntourageMobBattleStatus$$get_DamagePercent`
- OK `GuildRaidEntourageMobBattleStatus$$get_Def`
- OK `GuildRaidEntourageMobBattleStatus$$get_Element`
- OK `GuildRaidEntourageMobBattleStatus$$get_ExpDefMagic`
- OK `GuildRaidEntourageMobBattleStatus$$get_ExpDefNormal`
- OK `GuildRaidEntourageMobBattleStatus$$get_ExpDefSkill`
- OK `GuildRaidEntourageMobBattleStatus$$get_GuardProbability`
- OK `GuildRaidEntourageMobBattleStatus$$get_Level`
- OK `GuildRaidEntourageMobBattleStatus$$get_MagicDef`
- OK `GuildRaidEntourageMobBattleStatus$$get_MaxHp`
- OK `GuildRaidEntourageMobBattleStatus$$get_MoveSpeed`
- OK `GuildRaidEntourageMobBattleStatus$$get_NecessaryFleePercent`
- OK `GuildRaidEntourageMobBattleStatus$$get_NecessaryHit`
- OK `GuildRaidEntourageMobBattleStatus$$get_Persona`
- OK `GuildRaidEntourageMobBattleStatus$$get_PersonaValue`
- OK `GuildRaidEntourageMobBattleStatus$$get_Property`
- OK `GuildRaidEntourageMobBattleStatus$$get_StablePercent`
- OK `GuildRaidMobBattleStatus$$CalcDef`
- OK `GuildRaidMobBattleStatus$$CalcMdef`
- OK `GuildRaidMobBattleStatus$$SetMobStatus`
- OK `GuildRaidMobBattleStatus$$get_AvoidProbability`
- OK `GuildRaidMobBattleStatus$$get_CutAttack`
- OK `GuildRaidMobBattleStatus$$get_CutMagicAttack`

## GuildRaidMobBattleStatus$$get_DamagePercent
- call_only_ghidra: ['ZEXT816']
- OK `GuildRaidMobBattleStatus$$get_Def`
- OK `GuildRaidMobBattleStatus$$get_Element`
- OK `GuildRaidMobBattleStatus$$get_ExpDefMagic`
- OK `GuildRaidMobBattleStatus$$get_ExpDefNormal`
- OK `GuildRaidMobBattleStatus$$get_ExpDefSkill`
- OK `GuildRaidMobBattleStatus$$get_GuardProbability`
- OK `GuildRaidMobBattleStatus$$get_Level`
- OK `GuildRaidMobBattleStatus$$get_MagicDef`
- OK `GuildRaidMobBattleStatus$$get_MaxHp`
- OK `GuildRaidMobBattleStatus$$get_MoveSpeed`
- OK `GuildRaidMobBattleStatus$$get_NecessaryFleePercent`
- OK `GuildRaidMobBattleStatus$$get_NecessaryHit`
- OK `GuildRaidMobBattleStatus$$get_Persona`
- OK `GuildRaidMobBattleStatus$$get_PersonaValue`
- OK `GuildRaidMobBattleStatus$$get_Property`
- OK `GuildRaidMobBattleStatus$$get_StablePercent`
- OK `HighRaidBossBattleStatus$$CalcDef`
- OK `HighRaidBossBattleStatus$$CalcMdef`
- OK `HighRaidBossBattleStatus$$SetMobStatus`

## HighRaidBossBattleStatus$$get_AvoidProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']

## HighRaidBossBattleStatus$$get_CutAttack
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_CutMagicAttack', 'get_IsDead', 'get_Values']

## HighRaidBossBattleStatus$$get_CutMagicAttack
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']

## HighRaidBossBattleStatus$$get_DamagePercent
- call_only_ghidra: ['ZEXT816']

## HighRaidBossBattleStatus$$get_Def
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_Values']
- OK `HighRaidBossBattleStatus$$get_Element`
- OK `HighRaidBossBattleStatus$$get_ExpDefMagic`
- OK `HighRaidBossBattleStatus$$get_ExpDefNormal`
- OK `HighRaidBossBattleStatus$$get_ExpDefSkill`

## HighRaidBossBattleStatus$$get_GuardProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `HighRaidBossBattleStatus$$get_Level`

## HighRaidBossBattleStatus$$get_MagicDef
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_Values']
- OK `HighRaidBossBattleStatus$$get_MaxHp`
- OK `HighRaidBossBattleStatus$$get_MoveSpeed`
- OK `HighRaidBossBattleStatus$$get_NecessaryFleePercent`

## HighRaidBossBattleStatus$$get_NecessaryHit
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_Values']
- OK `HighRaidBossBattleStatus$$get_Persona`
- OK `HighRaidBossBattleStatus$$get_PersonaValue`
- OK `HighRaidBossBattleStatus$$get_Property`
- OK `HighRaidBossBattleStatus$$get_StablePercent`
- OK `HighRaidMobBattleStatus$$CalcDef`
- OK `HighRaidMobBattleStatus$$CalcMdef`
- OK `HighRaidMobBattleStatus$$SetMobStatus`
- OK `HighRaidMobBattleStatus$$get_AvoidProbability`
- OK `HighRaidMobBattleStatus$$get_CutAttack`
- OK `HighRaidMobBattleStatus$$get_CutMagicAttack`

## HighRaidMobBattleStatus$$get_DamagePercent
- call_only_ghidra: ['ZEXT816']
- OK `HighRaidMobBattleStatus$$get_Def`
- OK `HighRaidMobBattleStatus$$get_Element`
- OK `HighRaidMobBattleStatus$$get_ExpDefMagic`
- OK `HighRaidMobBattleStatus$$get_ExpDefNormal`
- OK `HighRaidMobBattleStatus$$get_ExpDefSkill`
- OK `HighRaidMobBattleStatus$$get_GuardProbability`
- OK `HighRaidMobBattleStatus$$get_Level`
- OK `HighRaidMobBattleStatus$$get_MagicDef`
- OK `HighRaidMobBattleStatus$$get_MaxHp`
- OK `HighRaidMobBattleStatus$$get_MoveSpeed`
- OK `HighRaidMobBattleStatus$$get_NecessaryFleePercent`
- OK `HighRaidMobBattleStatus$$get_NecessaryHit`
- OK `HighRaidMobBattleStatus$$get_Persona`
- OK `HighRaidMobBattleStatus$$get_PersonaValue`
- OK `HighRaidMobBattleStatus$$get_Property`
- OK `HighRaidMobBattleStatus$$get_StablePercent`
- OK `MobAttackBase$$CalcBarrier`

## MobAttackBase$$CalcBaseAttack
- call_only_ghidra: ['TryGetValue']

## MobAttackBase$$CalcCriticalDamage
- call_only_ghidra: ['Contains', 'op_Inequality']

## MobAttackBase$$CalcCriticalPercent
- call_only_ghidra: ['Contains', 'GetValue', 'op_Inequality']
- OK `MobAttackBase$$CalcElementBonus`

## MobAttackBase$$CalcFlee
- call_only_ghidra: ['GetAttackRate']
- OK `MobAttackBase$$CalcGuard`
- OK `MobAttackBase$$CalcHighRaidMonsterBaseAttack`

## MobAttackBase$$CalcHit
- call_only_ghidra: ['CalcFlee', 'CheckCriticalPercent', 'CheckInvalidDamage', 'CheckUnavoidable', 'GetNecessaryFreeDownRate', 'GetParam', 'InvalidDamage', 'TryGetBuff', 'TryGetValue', 'checkHighRaidHit', 'checkHit', 'checkScoreAttackHit']

## MobAttackBase$$CalcLastDamage
- call_only_ghidra: ['ApplyDamageCut', 'BufferEnd', 'End', 'GetComponent<object>', 'GetEffectiveArchetypeId', 'InitializeArray', 'SQRT']
- OK `MobAttackBase$$CalcMobaBonusDamageResist`
- OK `MobAttackBase$$CalcScoreAttackBossBaseAttack`

## MobAttackBase$$CalcSkillComboTough
- call_only_ghidra: ['get_PlayerActionManager']
- OK `MobAttackBase$$CalcStable`

## MobAttackBase$$CalcStableRate
- call_only_ghidra: ['CalcStablePercent', 'TryGetValue', 'op_Inequality']

## MobAttackBase$$CalcUnavoidableAttack
- call_only_ghidra: ['CalcLastDamage', 'SetParrySuccess', 'TryGetValue']

## MobAttackBase$$CheckAIRetreatAttack
- call_only_ghidra: ['get_IsMoveAttack']
- OK `MobAttackBase$$CheckAbnormalDamageIncrease`
- OK `MobAttackBase$$CheckActionType`
- OK `MobAttackBase$$CheckAvoid`
- OK `MobAttackBase$$CheckCritical`
- OK `MobAttackBase$$CheckCriticalPercent`

## MobAttackBase$$CheckDamageLimit
- call_only_ghidra: ['TryGetMaxDamageLimit', 'TryGetMinDamageLimit', 'TryGetValue']
- OK `MobAttackBase$$CheckGuard`
- OK `MobAttackBase$$CheckMainTarget`
- OK `MobAttackBase$$CheckPercentageDamage`
- OK `MobAttackBase$$CheckRangeHit`
- OK `MobAttackBase$$CheckUnavoidable`
- OK `MobAttackBase$$GetActionTypeResist`
- OK `MobAttackBase$$GetBarrierBuf`
- OK `MobAttackBase$$GetBarrierType`

## MobAttackBase$$GetDistDamageRegistRate
- call_only_ghidra: ['SQRT']
- OK `MobAttackBase$$GetLimitDamage`
- OK `MobAttackBase$$GetMobPatternAbnormalPercent`
- OK `MobAttackBase$$GetMobPatternSpecialDamegeRate`
- OK `MobAttackBase$$GetSupportValue`
- OK `MobBattleStatus$$CalcDef`
- OK `MobBattleStatus$$CalcMdef`
- OK `MobBattleStatus$$SetMobStatus`
- OK `MobBattleStatus$$get_AvoidProbability`
- OK `MobBattleStatus$$get_CutAttack`
- OK `MobBattleStatus$$get_CutMagicAttack`

## MobBattleStatus$$get_DamagePercent
- call_only_ghidra: ['ZEXT816']
- OK `MobBattleStatus$$get_Def`
- OK `MobBattleStatus$$get_Element`
- OK `MobBattleStatus$$get_ExpDefMagic`
- OK `MobBattleStatus$$get_ExpDefNormal`
- OK `MobBattleStatus$$get_ExpDefSkill`
- OK `MobBattleStatus$$get_GuardProbability`
- OK `MobBattleStatus$$get_Level`
- OK `MobBattleStatus$$get_MagicDef`
- OK `MobBattleStatus$$get_MaxHp`
- OK `MobBattleStatus$$get_MoveSpeed`
- OK `MobBattleStatus$$get_NecessaryFleePercent`
- OK `MobBattleStatus$$get_NecessaryHit`
- OK `MobBattleStatus$$get_Persona`
- OK `MobBattleStatus$$get_PersonaValue`
- OK `MobBattleStatus$$get_Property`
- OK `MobBattleStatus$$get_StablePercent`
- OK `MobaMobBattleStatus$$CalcDef`
- OK `MobaMobBattleStatus$$CalcMdef`
- OK `MobaMobBattleStatus$$SetMobStatus`
- OK `MobaMobBattleStatus$$get_AvoidProbability`
- OK `MobaMobBattleStatus$$get_CutAttack`
- OK `MobaMobBattleStatus$$get_CutMagicAttack`
- OK `MobaMobBattleStatus$$get_DamagePercent`
- OK `MobaMobBattleStatus$$get_Def`
- OK `MobaMobBattleStatus$$get_Element`
- OK `MobaMobBattleStatus$$get_ExpDefMagic`
- OK `MobaMobBattleStatus$$get_ExpDefNormal`
- OK `MobaMobBattleStatus$$get_ExpDefSkill`
- OK `MobaMobBattleStatus$$get_GuardProbability`
- OK `MobaMobBattleStatus$$get_Level`
- OK `MobaMobBattleStatus$$get_MagicDef`
- OK `MobaMobBattleStatus$$get_MaxHp`
- OK `MobaMobBattleStatus$$get_MoveSpeed`
- OK `MobaMobBattleStatus$$get_NecessaryFleePercent`
- OK `MobaMobBattleStatus$$get_NecessaryHit`
- OK `MobaMobBattleStatus$$get_Persona`
- OK `MobaMobBattleStatus$$get_PersonaValue`
- OK `MobaMobBattleStatus$$get_Property`
- OK `MobaMobBattleStatus$$get_StablePercent`
- OK `MobaOtherPlayerBattleStatus$$CalcDef`
- OK `MobaOtherPlayerBattleStatus$$CalcMdef`
- OK `MobaOtherPlayerBattleStatus$$SetMobStatus`
- OK `MobaOtherPlayerBattleStatus$$get_AvoidProbability`
- OK `MobaOtherPlayerBattleStatus$$get_CutAttack`
- OK `MobaOtherPlayerBattleStatus$$get_CutMagicAttack`

## MobaOtherPlayerBattleStatus$$get_DamagePercent
- call_only_ghidra: ['ZEXT816']
- OK `MobaOtherPlayerBattleStatus$$get_Def`
- OK `MobaOtherPlayerBattleStatus$$get_Element`
- OK `MobaOtherPlayerBattleStatus$$get_ExpDefMagic`
- OK `MobaOtherPlayerBattleStatus$$get_ExpDefNormal`
- OK `MobaOtherPlayerBattleStatus$$get_ExpDefSkill`
- OK `MobaOtherPlayerBattleStatus$$get_GuardProbability`
- OK `MobaOtherPlayerBattleStatus$$get_Level`
- OK `MobaOtherPlayerBattleStatus$$get_MagicDef`
- OK `MobaOtherPlayerBattleStatus$$get_MaxHp`
- OK `MobaOtherPlayerBattleStatus$$get_MoveSpeed`
- OK `MobaOtherPlayerBattleStatus$$get_NecessaryFleePercent`
- OK `MobaOtherPlayerBattleStatus$$get_NecessaryHit`
- OK `MobaOtherPlayerBattleStatus$$get_Persona`
- OK `MobaOtherPlayerBattleStatus$$get_PersonaValue`
- OK `MobaOtherPlayerBattleStatus$$get_Property`
- OK `MobaOtherPlayerBattleStatus$$get_StablePercent`
- OK `NewWaveBossBattleStatus$$CalcDef`
- OK `NewWaveBossBattleStatus$$CalcMdef`
- OK `NewWaveBossBattleStatus$$SetMobStatus`

## NewWaveBossBattleStatus$$get_AvoidProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_Values']
- OK `NewWaveBossBattleStatus$$get_CutAttack`
- OK `NewWaveBossBattleStatus$$get_CutMagicAttack`
- OK `NewWaveBossBattleStatus$$get_DamagePercent`

## NewWaveBossBattleStatus$$get_Def
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_Values']
- OK `NewWaveBossBattleStatus$$get_Element`
- OK `NewWaveBossBattleStatus$$get_ExpDefMagic`
- OK `NewWaveBossBattleStatus$$get_ExpDefNormal`
- OK `NewWaveBossBattleStatus$$get_ExpDefSkill`

## NewWaveBossBattleStatus$$get_GuardProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_Values']
- OK `NewWaveBossBattleStatus$$get_Level`

## NewWaveBossBattleStatus$$get_MagicDef
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_Values']
- OK `NewWaveBossBattleStatus$$get_MaxHp`

## NewWaveBossBattleStatus$$get_MoveSpeed
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_Values']
- OK `NewWaveBossBattleStatus$$get_NecessaryFleePercent`

## NewWaveBossBattleStatus$$get_NecessaryHit
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_Values']
- OK `NewWaveBossBattleStatus$$get_PartsStatus`
- OK `NewWaveBossBattleStatus$$get_Persona`
- OK `NewWaveBossBattleStatus$$get_PersonaValue`
- OK `NewWaveBossBattleStatus$$get_Property`
- OK `NewWaveBossBattleStatus$$get_StablePercent`
- OK `NewWaveMobBattleStatus$$CalcDef`
- OK `NewWaveMobBattleStatus$$CalcMdef`
- OK `NewWaveMobBattleStatus$$SetMobStatus`
- OK `NewWaveMobBattleStatus$$get_AvoidProbability`
- OK `NewWaveMobBattleStatus$$get_CutAttack`
- OK `NewWaveMobBattleStatus$$get_CutMagicAttack`
- OK `NewWaveMobBattleStatus$$get_DamagePercent`
- OK `NewWaveMobBattleStatus$$get_Def`
- OK `NewWaveMobBattleStatus$$get_Element`
- OK `NewWaveMobBattleStatus$$get_ExpDefMagic`
- OK `NewWaveMobBattleStatus$$get_ExpDefNormal`
- OK `NewWaveMobBattleStatus$$get_ExpDefSkill`
- OK `NewWaveMobBattleStatus$$get_GuardProbability`
- OK `NewWaveMobBattleStatus$$get_Level`
- OK `NewWaveMobBattleStatus$$get_MagicDef`
- OK `NewWaveMobBattleStatus$$get_MaxHp`
- OK `NewWaveMobBattleStatus$$get_MoveSpeed`
- OK `NewWaveMobBattleStatus$$get_NecessaryFleePercent`
- OK `NewWaveMobBattleStatus$$get_NecessaryHit`
- OK `NewWaveMobBattleStatus$$get_Persona`
- OK `NewWaveMobBattleStatus$$get_PersonaValue`
- OK `NewWaveMobBattleStatus$$get_Property`
- OK `NewWaveMobBattleStatus$$get_StablePercent`
- OK `NonTargetDummyMobBattleStatus$$CalcDef`
- OK `NonTargetDummyMobBattleStatus$$CalcMdef`
- OK `NonTargetDummyMobBattleStatus$$SetMobStatus`
- OK `NonTargetDummyMobBattleStatus$$get_AvoidProbability`
- OK `NonTargetDummyMobBattleStatus$$get_CutAttack`
- OK `NonTargetDummyMobBattleStatus$$get_CutMagicAttack`

## NonTargetDummyMobBattleStatus$$get_DamagePercent
- call_only_ghidra: ['ZEXT816']
- OK `NonTargetDummyMobBattleStatus$$get_Def`
- OK `NonTargetDummyMobBattleStatus$$get_Element`
- OK `NonTargetDummyMobBattleStatus$$get_ExpDefMagic`
- OK `NonTargetDummyMobBattleStatus$$get_ExpDefNormal`
- OK `NonTargetDummyMobBattleStatus$$get_ExpDefSkill`
- OK `NonTargetDummyMobBattleStatus$$get_GuardProbability`
- OK `NonTargetDummyMobBattleStatus$$get_Level`
- OK `NonTargetDummyMobBattleStatus$$get_MagicDef`
- OK `NonTargetDummyMobBattleStatus$$get_MaxHp`
- OK `NonTargetDummyMobBattleStatus$$get_MoveSpeed`

## NonTargetDummyMobBattleStatus$$get_NecessaryFleePercent
- call_only_ghidra: ['ZEXT816']
- OK `NonTargetDummyMobBattleStatus$$get_NecessaryHit`
- OK `NonTargetDummyMobBattleStatus$$get_Persona`
- OK `NonTargetDummyMobBattleStatus$$get_PersonaValue`
- OK `NonTargetDummyMobBattleStatus$$get_Property`

## NonTargetDummyMobBattleStatus$$get_StablePercent
- call_only_ghidra: ['ZEXT816']

## NormalAttackAction$$ActionHit
- call_only_ghidra: ['RemoveSelfBuffer', 'TryGetValue']

## NormalAttackAction$$ActionPreparation
- call_only_ghidra: ['Add', 'AddHitTakeAppendParam', 'AddTemporarySkillBuffer', 'AddWithResize', 'ApplyAuraBlade', 'CheckValidEffect', 'GetComponent<object>', 'GetElementColor', 'Range', 'SetEarthShatteringTake', 'SetPowerWaveTake', 'TryGetValue', '_ctor', 'add_EndFunction', 'add_MotionEndFunction', 'get_Instance']

## NormalAttackAction$$ActionSkillEvent
- call_only_ghidra: ['AddBuf', 'SkillEvent', 'Update', '_ctor', 'add_MotionEndFunction', 'get_gameObject']

## NormalAttackAction$$ActionStart
- call_only_ghidra: ['RemoveAfterSkillBuf']

## NormalAttackAction$$ActionStartOthers
- call_only_ghidra: ['Add', 'GetComponent<object>', 'Range', '_ctor', 'get_position', 'get_transform']

## NormalAttackAction$$CalcBaseDamage
- call_only_ghidra: ['CheckSpecificWeaponBaseDamageRate', 'get_SubWeapon']

## NormalAttackAction$$CalcDef
- call_only_ghidra: ['CheckSkillIndividualFlag', 'TryGetValue']
- OK `NormalAttackAction$$CalcMercenaryDamage`

## NormalAttackAction$$CheckAbnormalSubEffect
- call_only_ghidra: ['GetComponent<object>', 'RemoveBuffer']
- OK `NormalAttackAction$$CheckOneChance`
- OK `NormalAttackAction$$CheckSecondArm`

## NormalAttackAction$$Damaged
- call_only_ghidra: ['AddSelfBuffer', 'AttackStart', 'CountUp', 'NormalAttackDamaged', 'StackStormBlazer', 'TryGetBuf<object>', 'TryGetValue', '_ctor']
- OK `NormalAttackAction$$GetNormalAttackTake`
- OK `NormalAttackAction$$InitializeOthers`
- OK `NormalAttackAction$$IsNormalAttack`

## NormalAttackAction$$OnInitialize
- call_only_ghidra: ['Add', 'CONCAT44', 'ExistWeaponType', 'GetNormalAttackTake', 'NEON_ucvtf', 'Range', 'SetBufferEffectActive', 'TryGetValue', '_ctor']

## NormalAttackAction$$OtherPlayerAttackStartReceive
- call_only_ghidra: ['Add', 'GetElementColor', 'GetNormalAttackTake', 'SetEarthShatteringTake', '_ctor', 'get_Instance']

## NormalAttackAction$$OtherPlayerSkillEventReceive
- call_only_ghidra: ['_ctor']
- OK `NormalAttackAction$$PossibilityAbnormalState`
- OK `NormalAttackAction$$PowerWaveCheck`

## NormalAttackAction$$PrevActionHit
- call_only_ghidra: ['SetAttackSkillId']
- OK `NormalAttackAction$$RampageHitCheck`

## NormalAttackAction$$SetEarthShatteringTake
- call_only_ghidra: ['AddWithResize', 'Dispose', 'GetEnumerator', 'MoveNext', 'Range', 'Remove', '_ctor', 'get_Item']

## NormalAttackAction$$SetPowerWaveTake
- call_only_ghidra: ['Add', '_ctor']

## NormalAttackAction$$UnsheatheWeaponAction
- call_only_ghidra: ['Add', '_ctor']

## NormalAttackAction$$attachOneChanceDamage
- call_only_ghidra: ['AddWithResize', 'CONCAT44', 'CalcPlayerDamageUpLimit', 'CheckSpecificWeaponBaseDamageRate', 'CreateExtensionDamage', 'CreateNextDamage', 'GetLimitDamage', 'GetNextDamageLocalId', 'GetSpecificWeaponLastDamageRate', 'SetDamageLocalId', 'set_Damage']

## NormalAttackAction$$attachSecondArmDamage
- call_only_ghidra: ['AddWithResize', 'CONCAT44', 'CalcPlayerDamageUpLimit', 'CheckSpecificWeaponBaseDamageRate', 'CreateExtensionDamage', 'CreateNextDamage', 'Dispose', 'GetEnumerator', 'GetLimitDamage', 'GetNextDamageLocalId', 'GetSpecificWeaponLastDamageRate', 'MoveNext', 'SetDamageLocalId', 'createExcetraDamage', 'set_Damage']

## NormalAttackAction$$calcDualSwordDamage
- call_only_ghidra: ['AddSelfBuffer', 'CheckSpecificWeaponBaseDamageRate', 'RemoveBuffer', 'TryGetValue']

## NormalAttackAction$$calcDualSwordDamageDate
- call_only_ghidra: ['SetDamageLocalId', '_ctor', 'set_Damage']

## NormalAttackAction$$calcPlayerToMobDamage
- call_only_ghidra: ['AddConstant', 'AddRate', 'AddSelfBuffer', 'AddWithResize', 'CalcBufferLastDamageRate', 'CalcDistanceResistRate', 'CalcGemLastDamageRate', 'CalcMercenaryDamage', 'CalcReduceLastDamageRate', 'CheckAbnormalDamageIncrease', 'CheckActive', 'CheckDamageLimit', 'ContainsBuffer', 'EffectiveAbnormalPoison', 'GetDamage', 'GetLimitDamage', 'GetNormalAttackRate', 'GetNormalAttackSkillRate', 'GetNormalAttackSkillRateBonus', 'GetSpecificWeaponLastDamageRate', 'GetTreasureHuntLastDmgRateBonus', 'InvalidStable', 'InvalidUnannouncedDestination', 'InvokeShukuchi', 'Max']
- OK `NormalAttackAction$$calcRampageConstantDamage`

## NormalAttackAction$$calcRampageFinish
- call_only_ghidra: ['AddConstant', 'AddRate', 'AddWithResize', 'Dispose', 'GetEnumerator', 'SetCheck', 'TryGetValue', '_ctor', 'checkCriticalPercent', 'templateToDamageData']
- OK `NormalAttackAction$$calcRampageSkillRate`
- OK `NormalAttackAction$$get_ActionID`
- OK `NormalAttackAction$$get_AttackType`
- OK `NormalAttackAction$$get_BaseMp`
- OK `NormalAttackAction$$get_IsEarthShattering`
- OK `NormalAttackAction$$get_IsEventIgnoreOther`

## NormalAttackAction$$get_IsExpDefFluctuate
- call_only_ghidra: ['CheckSkillIndividualFlag']
- OK `NormalAttackAction$$get_IsHitRigidity`
- OK `NormalAttackAction$$get_IsInterruptable`
- OK `NormalAttackAction$$get_IsKnifeCombat`
- OK `NormalAttackAction$$get_IsMoveAssistContinue`
- OK `NormalAttackAction$$get_IsPlace`
- OK `NormalAttackAction$$get_IsPutUpWeapon`
- OK `NormalAttackAction$$get_IsRampage`
- OK `NormalAttackAction$$get_IsRange`
- OK `NormalAttackAction$$get_IsSupport`
- OK `NormalAttackAction$$get_IsSwordMoveStart`
- OK `NormalAttackAction$$get_IsUnsheatheWeapon`
- OK `NormalAttackAction$$get_NoCost`
- OK `NormalAttackAction$$get_PassiveList`
- OK `NormalAttackAction$$set_IsSwordMoveStart`
- OK `NormalAttackPattern$$ActionCancel`
- OK `NormalAttackPattern$$Initialize`
- OK `NormalAttackPattern$$OnPostUpdate`
- OK `NormalAttackPattern$$get_VisibleAttackArea`
- OK `PlayerAttackBase$$CalcBonusLastDamageRate`
- OK `PlayerAttackBase$$CalcBufferLastDamageRate`
- OK `PlayerAttackBase$$CalcCastTime`
- OK `PlayerAttackBase$$CalcCobmoRate`

## PlayerAttackBase$$CalcCostMp
- call_only_ghidra: ['TryGetBuf<object>']
- OK `PlayerAttackBase$$CalcDistanceResistRate`

## PlayerAttackBase$$CalcDistanceToTarget
- call_only_ghidra: ['SQRT']

## PlayerAttackBase$$CalcDoubleThrowLastDamageRate
- call_only_ghidra: ['AddSelfBuffer', 'RemoveSelfBuffer', '_ctor']
- OK `PlayerAttackBase$$CalcElementBonus`
- OK `PlayerAttackBase$$CalcElementKillerBonus`

## PlayerAttackBase$$CalcGemLastDamageRate
- call_only_ghidra: ['ZEXT816']

## PlayerAttackBase$$CalcHitReaction
- call_only_ghidra: ['Sum<object>', 'ViewPreventedHitReactionIcon', 'ViewPreventedHitReactionIconToGemCart', '_ctor', 'get_WeaponType', 'get_position', 'get_transform']
- OK `PlayerAttackBase$$CalcLastDamageRate`

## PlayerAttackBase$$CalcMagicResistDamage
- call_only_ghidra: ['NEON_fminnm']
- OK `PlayerAttackBase$$CalcMotionSpeed`
- OK `PlayerAttackBase$$CalcMp`
- OK `PlayerAttackBase$$CalcNormalElementWeaponDamageResistRate`
- OK `PlayerAttackBase$$CalcPlayerDamageUpLimit`

## PlayerAttackBase$$CalcPowerResistDamage
- call_only_ghidra: ['NEON_fminnm']
- OK `PlayerAttackBase$$CalcRegistDamage`
- OK `PlayerAttackBase$$CalcSkillMasteryLastDamageRate`
- OK `PlayerAttackBase$$CalcSkillTypeBonusRate`

## PlayerAttackBase$$CalcStable
- call_only_ghidra: ['CalcStablePercent']

## PlayerAttackBase$$CalcWeaponCharacteristicsLastDamageRate
- call_only_ghidra: ['ZEXT816']
- OK `PlayerAttackBase$$CheckAbnormalDamageIncrease`

## PlayerAttackBase$$CheckAbnormalSubEffect
- call_only_ghidra: ['AbnormalStack']
- OK `PlayerAttackBase$$CheckComboAccept`

## PlayerAttackBase$$CheckDamageLimit
- call_only_ghidra: ['TryGetMaxDamageLimit', 'TryGetMinDamageLimit', 'TryGetValue']
- OK `PlayerAttackBase$$CheckEnchantedSpellMpLessInvoke`
- OK `PlayerAttackBase$$CheckGemCartEmergencyMpRecovery`
- OK `PlayerAttackBase$$CheckHit`
- OK `PlayerAttackBase$$CheckLongRangeAttack`

## PlayerAttackBase$$CheckMagicCritical
- call_only_ghidra: ['CheckActive', 'CheckBonus', 'CheckWeakElemet', 'Contains', 'TryGetBuf<object>', 'TryGetValue', 'checkCriticalPercent', 'get_WeaponType']

## PlayerAttackBase$$CheckMobActionUnobstructable
- call_only_ghidra: ['get_CurrenctPatternManager', 'get_CurrenctPatternPlayer']
- OK `PlayerAttackBase$$CheckPlayerDamageUpLimit`
- OK `PlayerAttackBase$$CheckSkillIndividualFlag`
- OK `PlayerAttackBase$$CheckSkillParamFlag`

## PlayerAttackBase$$CheckSpecificWeaponBaseDamageRate
- call_only_ghidra: ['TryGetValue', 'get_Weapon']

## PlayerAttackBase$$GetElementKillerBonus
- call_only_ghidra: ['GetBonusValue', 'GetElementKiller', 'GetParam', 'TryGetValue']
- OK `PlayerAttackBase$$GetLimitDamage`
- OK `PlayerAttackBase$$GetLocalizeKey`
- OK `PlayerAttackBase$$GetNextDamageLocalId`

## PlayerAttackBase$$GetNextDamageLocalIds
- call_only_ghidra: ['Next']
- OK `PlayerAttackBase$$GetSkillIdData`
- OK `PlayerAttackBase$$GetSkillType`
- OK `PlayerAttackBase$$GetSpecificWeaponLastDamageRate`
- OK `PlayerAttackBase$$GetSubWeaponType`
- OK `PlayerAttackBase$$GetWeaponElementType`

## PlayerAttackBase$$GetWeaponRange
- call_only_ghidra: ['NEON_ucvtf']
- OK `PlayerAttackBase$$GetWeaponType`
- OK `PlayerBattleStatus$$CalcBaseGuardPower`
- OK `PlayerBattleStatus$$GetDamageCut`
- OK `PlayerBattleStatus$$GetDefFact`
- OK `PlayerBattleStatus$$GetMdefFact`
- OK `PlayerBattleStatus$$GetMotionSpeed`
- OK `PlayerBattleStatus$$GetNextAtkTime`
- OK `PlayerBattleStatus$$GetSkillDelayRate1`
- OK `PlayerBattleStatus$$GetSkillDelayRate2`
- OK `PlayerBattleStatus$$SetGuildStatusBoost`
- OK `PlayerBattleStatus$$get_Agi`
- OK `PlayerBattleStatus$$get_AntiVirus`
- OK `PlayerBattleStatus$$get_Aspd`
- OK `PlayerBattleStatus$$get_Atk`
- OK `PlayerBattleStatus$$get_AtkMpRecovery`
- OK `PlayerBattleStatus$$get_AvoidDelay`
- OK `PlayerBattleStatus$$get_AvoidSpeed`
- OK `PlayerBattleStatus$$get_AvoidStack`
- OK `PlayerBattleStatus$$get_Critical`
- OK `PlayerBattleStatus$$get_CriticalDmg`
- OK `PlayerBattleStatus$$get_CriticalMagicDmg`
- OK `PlayerBattleStatus$$get_Crt`
- OK `PlayerBattleStatus$$get_Cspd`
- OK `PlayerBattleStatus$$get_Def`
- OK `PlayerBattleStatus$$get_Dex`
- OK `PlayerBattleStatus$$get_ElementPower`
- OK `PlayerBattleStatus$$get_EqAtk`
- OK `PlayerBattleStatus$$get_EqDef`
- OK `PlayerBattleStatus$$get_Flee`
- OK `PlayerBattleStatus$$get_GuardDelay`
- OK `PlayerBattleStatus$$get_GuardPower`
- OK `PlayerBattleStatus$$get_GuardSpeed`
- OK `PlayerBattleStatus$$get_Hit`
- OK `PlayerBattleStatus$$get_HpRecovery`
- OK `PlayerBattleStatus$$get_Int`
- OK `PlayerBattleStatus$$get_Luk`
- OK `PlayerBattleStatus$$get_Lv`
- OK `PlayerBattleStatus$$get_Matk`
- OK `PlayerBattleStatus$$get_MaxHp`
- OK `PlayerBattleStatus$$get_MaxMp`
- OK `PlayerBattleStatus$$get_Mdef`
- OK `PlayerBattleStatus$$get_Men`
- OK `PlayerBattleStatus$$get_MpRecovery`
- OK `PlayerBattleStatus$$get_Respawn`
- OK `PlayerBattleStatus$$get_Stable`
- OK `PlayerBattleStatus$$get_Str`
- OK `PlayerBattleStatus$$get_SubAtk`
- OK `PlayerBattleStatus$$get_SubEqAtk`
- OK `PlayerBattleStatus$$get_SubMatk`
- OK `PlayerBattleStatus$$get_SubStable`
- OK `PlayerBattleStatus$$get_Tec`
- OK `PlayerBattleStatus$$get_Vit`

## PlayerPrimaryStatus$$Check
- call_only_ghidra: ['CRC32', '_ctor']

## PlayerPrimaryStatus$$CreateStatus
- call_only_ghidra: ['_ctor']
- OK `PlayerPrimaryStatus$$GetAllStatusPoint`

## PlayerPrimaryStatus$$GetCRC32
- call_only_ghidra: ['CRC32', '_ctor']

## PlayerPrimaryStatus$$ToPrimaryStatusData
- call_only_ghidra: ['CONCAT22', 'CONCAT24', 'CONCAT26', '_ctor']
- OK `PlayerPrimaryStatus$$UpdateSkillPoint`
- OK `PlayerPrimaryStatus$$UpdateStatusPoint`
- OK `PlayerPrimaryStatus$$get_Agi`
- OK `PlayerPrimaryStatus$$get_Crt`
- OK `PlayerPrimaryStatus$$get_Dex`
- OK `PlayerPrimaryStatus$$get_Int`
- OK `PlayerPrimaryStatus$$get_Luk`
- OK `PlayerPrimaryStatus$$get_Lv`
- OK `PlayerPrimaryStatus$$get_Men`
- OK `PlayerPrimaryStatus$$get_MoveSpeed`
- OK `PlayerPrimaryStatus$$get_Personality`
- OK `PlayerPrimaryStatus$$get_SkillPoint`
- OK `PlayerPrimaryStatus$$get_StatusPoint`
- OK `PlayerPrimaryStatus$$get_Str`
- OK `PlayerPrimaryStatus$$get_Tec`
- OK `PlayerPrimaryStatus$$get_Vit`
- OK `PlayerSecondaryStatus$$CalcAntiVirus`
- OK `PlayerSecondaryStatus$$CalcBaseGuardPower`

## PlayerSecondaryStatus$$CalcBaseMaxHp
- call_only_ghidra: ['CONCAT44']
- OK `PlayerSecondaryStatus$$CalcBaseMaxMp`
- OK `PlayerSecondaryStatus$$CalcBaseSecondaryStatus`
- OK `PlayerSecondaryStatus$$CalcCritical`
- OK `PlayerSecondaryStatus$$CalcCriticalDmg`
- OK `PlayerSecondaryStatus$$CalcHpRecovery`
- OK `PlayerSecondaryStatus$$CalcMagicCritical`
- OK `PlayerSecondaryStatus$$CalcMpRecovery`
- OK `PlayerSecondaryStatus$$GetCalcMotionSpeed`

## PlayerSecondaryStatus$$GetCrtConstant
- call_only_ghidra: ['get_SubWeapon']
- OK `PlayerSecondaryStatus$$GetCrtRate`
- OK `PlayerSecondaryStatus$$GetDamageCut`
- OK `PlayerSecondaryStatus$$GetDefFact`

## PlayerSecondaryStatus$$GetDisplayBonusCalcHate
- call_only_ghidra: ['modf']
- OK `PlayerSecondaryStatus$$GetDropBonus`

## PlayerSecondaryStatus$$GetDurationBonusTime
- call_only_ghidra: ['_ctor']
- OK `PlayerSecondaryStatus$$GetExpBonus`

## PlayerSecondaryStatus$$GetItemBonusParam
- call_only_ghidra: ['_ctor']
- OK `PlayerSecondaryStatus$$GetMdefFact`
- OK `PlayerSecondaryStatus$$GetMotionSpeed`
- OK `PlayerSecondaryStatus$$GetNextAtkTime`

## PlayerSecondaryStatus$$GetParam
- call_only_ghidra: ['_ctor']
- OK `PlayerSecondaryStatus$$GetRespawnRate`
- OK `PlayerSecondaryStatus$$GetSkillDelayRate1`
- OK `PlayerSecondaryStatus$$GetSkillDelayRate2`
- OK `PlayerSecondaryStatus$$GetbAvoid`
- OK `PlayerSecondaryStatus$$GetbGuardPower`
- OK `PlayerSecondaryStatus$$GetbGuardSpeed`

## PlayerSecondaryStatus$$SetGuildStatusBoost
- call_only_ghidra: ['GetValue', 'get_Instance']
- OK `PlayerSecondaryStatus$$get_Agi`
- OK `PlayerSecondaryStatus$$get_AntiVirus`
- OK `PlayerSecondaryStatus$$get_Aspd`
- OK `PlayerSecondaryStatus$$get_Atk`
- OK `PlayerSecondaryStatus$$get_AtkMpRecovery`
- OK `PlayerSecondaryStatus$$get_AvoidDelay`
- OK `PlayerSecondaryStatus$$get_AvoidSpeed`
- OK `PlayerSecondaryStatus$$get_AvoidStack`
- OK `PlayerSecondaryStatus$$get_Critical`
- OK `PlayerSecondaryStatus$$get_CriticalDmg`
- OK `PlayerSecondaryStatus$$get_CriticalMagicDmg`
- OK `PlayerSecondaryStatus$$get_Crt`

## PlayerSecondaryStatus$$get_Cspd
- call_only_ghidra: ['SetSkillLearnData', 'UpdateMaxValue']
- OK `PlayerSecondaryStatus$$get_CurrectHit`
- OK `PlayerSecondaryStatus$$get_Def`
- OK `PlayerSecondaryStatus$$get_Dex`
- OK `PlayerSecondaryStatus$$get_ElementPower`
- OK `PlayerSecondaryStatus$$get_EqAtk`
- OK `PlayerSecondaryStatus$$get_EqDef`
- OK `PlayerSecondaryStatus$$get_Flee`
- OK `PlayerSecondaryStatus$$get_GuardDelay`

## PlayerSecondaryStatus$$get_GuardPower
- call_only_ghidra: ['Min', 'get_SubWeapon', 'get_Weapon']
- OK `PlayerSecondaryStatus$$get_GuardSpeed`
- OK `PlayerSecondaryStatus$$get_Hit`
- OK `PlayerSecondaryStatus$$get_HpRecovery`
- OK `PlayerSecondaryStatus$$get_Int`
- OK `PlayerSecondaryStatus$$get_Luk`
- OK `PlayerSecondaryStatus$$get_Lv`
- OK `PlayerSecondaryStatus$$get_Matk`
- OK `PlayerSecondaryStatus$$get_MaxHp`
- OK `PlayerSecondaryStatus$$get_MaxMp`
- OK `PlayerSecondaryStatus$$get_Mdef`
- OK `PlayerSecondaryStatus$$get_Men`
- OK `PlayerSecondaryStatus$$get_MpRecovery`
- OK `PlayerSecondaryStatus$$get_Respawn`

## PlayerSecondaryStatus$$get_Stable
- call_only_ghidra: ['get_SubWeapon']
- OK `PlayerSecondaryStatus$$get_Str`
- OK `PlayerSecondaryStatus$$get_SubAtk`
- OK `PlayerSecondaryStatus$$get_SubEqAtk`
- OK `PlayerSecondaryStatus$$get_SubMatk`
- OK `PlayerSecondaryStatus$$get_SubStable`
- OK `PlayerSecondaryStatus$$get_Tec`
- OK `PlayerSecondaryStatus$$get_Vit`

## PlayerStatusBase$$AddLocalHp
- call_only_ghidra: ['SetLocalHp']

## PlayerStatusBase$$AddLocalMp
- call_only_ghidra: ['SetLocalMp']
- OK `PlayerStatusBase$$CheckBodyAbility`

## PlayerStatusBase$$DamageHp
- call_only_ghidra: ['SetLocalExHp', 'SetLocalHp']

## PlayerStatusBase$$EndItemRandomProperty
- call_only_ghidra: ['CreateBonusBuf', 'CreateBuff', 'SetRandomPropertyBonus', 'Stop']
- OK `PlayerStatusBase$$EnoughMp`

## PlayerStatusBase$$GetAvatarSkill
- call_only_ghidra: ['AddWithResize', 'GetAvatarSkillId', 'GetSkillMaster', 'ToArray', '_ctor', 'get_AllBonusList', 'get_Instance']
- OK `PlayerStatusBase$$GetBonusValueWithBuf`
- OK `PlayerStatusBase$$GetEquip`
- OK `PlayerStatusBase$$GetEquipElement`
- OK `PlayerStatusBase$$GetEquipSkill`
- OK `PlayerStatusBase$$GetEquipSkillFlag`

## PlayerStatusBase$$GetEquipSubWeaponElement
- call_only_ghidra: ['FirstOrDefault<object>', '_ctor']
- OK `PlayerStatusBase$$GetFirstAttack`
- OK `PlayerStatusBase$$GetFirstAttackRate`
- OK `PlayerStatusBase$$GetHpPercent`
- OK `PlayerStatusBase$$GetMainEquipSkill`
- OK `PlayerStatusBase$$GetMpPercent`
- OK `PlayerStatusBase$$GetNextExp`

## PlayerStatusBase$$GetNinjaSkill
- call_only_ghidra: ['AddWithResize', 'GetSkillMaster', '_ctor', 'get_CapVal6', 'get_CapVal7', 'get_CapVal8', 'get_Instance', 'get_SubWeapon', 'get_WeaponType']
- OK `PlayerStatusBase$$GetReceiveElementDmgRateBufType`
- OK `PlayerStatusBase$$GetSubEquipSkill`
- OK `PlayerStatusBase$$GetWeaponTypeToEquipLimit`

## PlayerStatusBase$$PaySkillMp
- call_only_ghidra: ['SetLocalExMp', 'SetLocalMp']

## PlayerStatusBase$$ResetItemRandomProperty
- call_only_ghidra: ['ClearItemRandomProperty', 'ClearRandomPropertyBonus', 'CreateBonusBuf', 'CreateBuff', 'ResetRandomProperty']

## PlayerStatusBase$$SetCooking
- call_only_ghidra: ['SetBonus', 'SetEquipBonus', 'UpdateEquipLimitBonus']

## PlayerStatusBase$$SetCristEquipBuff
- call_only_ghidra: ['AddWithResize', 'Dispose', 'FindIndex', 'GetEnumerator', 'MoveNext', '_ctor', 'get_Item']

## PlayerStatusBase$$SetEquip
- call_only_ghidra: ['AddWithResize', 'Dispose', 'FirstOrDefault<object>', 'GetEnumerator', 'GetSkillLv', 'SetBonus', 'SetCristEquipBuff', 'SetEquipBonus', 'SetEquipItem', 'UpdateEquipLimitBonus', 'UpdateItem', '_ctor']
- OK `PlayerStatusBase$$SetExp`

## PlayerStatusBase$$SetGuildRaidBonus
- call_only_ghidra: ['SetBonus', 'SetEquipBonus', 'UpdateEquipLimitBonus']

## PlayerStatusBase$$SetSelfDisclosureBonus
- call_only_ghidra: ['CreateBonusBuf', 'CreateBuff', 'SetBonus', 'SetEquipBonus', 'UpdateEquipLimitBonus']

## PlayerStatusBase$$StartRandomProperty
- call_only_ghidra: ['Active', 'CreateBonusBuf', 'CreateBuff', 'SetRandomPropertyBonus', 'StartItemRandomProperty']
- OK `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`
- OK `PlayerStatusBase$$UpdateSkillPoint`
- OK `PlayerStatusBase$$UpdateStatusPoint`
- OK `PlayerStatusBase$$get_IsEffectiveDeadItemDuration`
- OK `PlayerStatusBase$$get_IsInit`
- OK `PlayerStatusBase$$set_IsEffectiveDeadItemDuration`
- OK `PlayerStatusBase$$set_IsInit`
- OK `RezeroMobBattleStatus$$CalcDef`
- OK `RezeroMobBattleStatus$$CalcMdef`
- OK `RezeroMobBattleStatus$$SetMobStatus`
- OK `RezeroMobBattleStatus$$get_AvoidProbability`
- OK `RezeroMobBattleStatus$$get_CutAttack`
- OK `RezeroMobBattleStatus$$get_CutMagicAttack`

## RezeroMobBattleStatus$$get_DamagePercent
- call_only_ghidra: ['ZEXT816']
- OK `RezeroMobBattleStatus$$get_Def`
- OK `RezeroMobBattleStatus$$get_Element`
- OK `RezeroMobBattleStatus$$get_ExpDefMagic`
- OK `RezeroMobBattleStatus$$get_ExpDefNormal`
- OK `RezeroMobBattleStatus$$get_ExpDefSkill`
- OK `RezeroMobBattleStatus$$get_GuardProbability`
- OK `RezeroMobBattleStatus$$get_Level`
- OK `RezeroMobBattleStatus$$get_MagicDef`
- OK `RezeroMobBattleStatus$$get_MaxHp`
- OK `RezeroMobBattleStatus$$get_MoveSpeed`
- OK `RezeroMobBattleStatus$$get_NecessaryFleePercent`
- OK `RezeroMobBattleStatus$$get_NecessaryHit`
- OK `RezeroMobBattleStatus$$get_Persona`
- OK `RezeroMobBattleStatus$$get_PersonaValue`
- OK `RezeroMobBattleStatus$$get_Property`
- OK `RezeroMobBattleStatus$$get_StablePercent`
- OK `ScoreAttackBossBattleStatus$$CalcDef`
- OK `ScoreAttackBossBattleStatus$$CalcMdef`
- OK `ScoreAttackBossBattleStatus$$SetMobStatus`

## ScoreAttackBossBattleStatus$$get_AvoidProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `ScoreAttackBossBattleStatus$$get_CalcLv`

## ScoreAttackBossBattleStatus$$get_CutAttack
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']

## ScoreAttackBossBattleStatus$$get_CutMagicAttack
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']

## ScoreAttackBossBattleStatus$$get_DamagePercent
- call_only_ghidra: ['ZEXT816']

## ScoreAttackBossBattleStatus$$get_Def
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `ScoreAttackBossBattleStatus$$get_Element`
- OK `ScoreAttackBossBattleStatus$$get_ExpDefMagic`
- OK `ScoreAttackBossBattleStatus$$get_ExpDefNormal`
- OK `ScoreAttackBossBattleStatus$$get_ExpDefSkill`

## ScoreAttackBossBattleStatus$$get_GuardProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `ScoreAttackBossBattleStatus$$get_Level`

## ScoreAttackBossBattleStatus$$get_MagicDef
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `ScoreAttackBossBattleStatus$$get_MaxHp`

## ScoreAttackBossBattleStatus$$get_MoveSpeed
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `ScoreAttackBossBattleStatus$$get_NecessaryFleePercent`

## ScoreAttackBossBattleStatus$$get_NecessaryHit
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `ScoreAttackBossBattleStatus$$get_PartsStatus`
- OK `ScoreAttackBossBattleStatus$$get_Persona`
- OK `ScoreAttackBossBattleStatus$$get_PersonaValue`
- OK `ScoreAttackBossBattleStatus$$get_Property`
- OK `ScoreAttackBossBattleStatus$$get_StablePercent`
- OK `ScoreAttackMobBattleStatus$$CalcDef`
- OK `ScoreAttackMobBattleStatus$$CalcMdef`
- OK `ScoreAttackMobBattleStatus$$SetMobStatus`
- OK `ScoreAttackMobBattleStatus$$get_AvoidProbability`
- OK `ScoreAttackMobBattleStatus$$get_CutAttack`
- OK `ScoreAttackMobBattleStatus$$get_CutMagicAttack`

## ScoreAttackMobBattleStatus$$get_DamagePercent
- call_only_ghidra: ['ZEXT816']
- OK `ScoreAttackMobBattleStatus$$get_Def`
- OK `ScoreAttackMobBattleStatus$$get_Element`
- OK `ScoreAttackMobBattleStatus$$get_ExpDefMagic`
- OK `ScoreAttackMobBattleStatus$$get_ExpDefNormal`
- OK `ScoreAttackMobBattleStatus$$get_ExpDefSkill`
- OK `ScoreAttackMobBattleStatus$$get_GuardProbability`
- OK `ScoreAttackMobBattleStatus$$get_Level`
- OK `ScoreAttackMobBattleStatus$$get_MagicDef`
- OK `ScoreAttackMobBattleStatus$$get_MaxHp`
- OK `ScoreAttackMobBattleStatus$$get_MoveSpeed`
- OK `ScoreAttackMobBattleStatus$$get_NecessaryFleePercent`
- OK `ScoreAttackMobBattleStatus$$get_NecessaryHit`
- OK `ScoreAttackMobBattleStatus$$get_Persona`
- OK `ScoreAttackMobBattleStatus$$get_PersonaValue`
- OK `ScoreAttackMobBattleStatus$$get_Property`
- OK `ScoreAttackMobBattleStatus$$get_StablePercent`
- OK `TreasureHuntBossBattleStatus$$CalcDef`
- OK `TreasureHuntBossBattleStatus$$CalcMdef`
- OK `TreasureHuntBossBattleStatus$$SetMobStatus`

## TreasureHuntBossBattleStatus$$get_AvoidProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']

## TreasureHuntBossBattleStatus$$get_CutAttack
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']

## TreasureHuntBossBattleStatus$$get_CutMagicAttack
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']

## TreasureHuntBossBattleStatus$$get_DamagePercent
- call_only_ghidra: ['ZEXT816']

## TreasureHuntBossBattleStatus$$get_Def
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `TreasureHuntBossBattleStatus$$get_Element`
- OK `TreasureHuntBossBattleStatus$$get_ExpDefMagic`
- OK `TreasureHuntBossBattleStatus$$get_ExpDefNormal`
- OK `TreasureHuntBossBattleStatus$$get_ExpDefSkill`

## TreasureHuntBossBattleStatus$$get_GuardProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `TreasureHuntBossBattleStatus$$get_Level`

## TreasureHuntBossBattleStatus$$get_MagicDef
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `TreasureHuntBossBattleStatus$$get_MaxHp`

## TreasureHuntBossBattleStatus$$get_MoveSpeed
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `TreasureHuntBossBattleStatus$$get_NecessaryFleePercent`

## TreasureHuntBossBattleStatus$$get_NecessaryHit
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `TreasureHuntBossBattleStatus$$get_PartsStatus`
- OK `TreasureHuntBossBattleStatus$$get_Persona`
- OK `TreasureHuntBossBattleStatus$$get_PersonaValue`
- OK `TreasureHuntBossBattleStatus$$get_Property`
- OK `TreasureHuntBossBattleStatus$$get_StablePercent`
- OK `TreasureHuntMobBattleStatus$$CalcDef`
- OK `TreasureHuntMobBattleStatus$$CalcMdef`
- OK `TreasureHuntMobBattleStatus$$SetMobStatus`
- OK `TreasureHuntMobBattleStatus$$get_AvoidProbability`
- OK `TreasureHuntMobBattleStatus$$get_CutAttack`
- OK `TreasureHuntMobBattleStatus$$get_CutMagicAttack`

## TreasureHuntMobBattleStatus$$get_DamagePercent
- call_only_ghidra: ['ZEXT816']
- OK `TreasureHuntMobBattleStatus$$get_Def`
- OK `TreasureHuntMobBattleStatus$$get_Element`
- OK `TreasureHuntMobBattleStatus$$get_ExpDefMagic`
- OK `TreasureHuntMobBattleStatus$$get_ExpDefNormal`
- OK `TreasureHuntMobBattleStatus$$get_ExpDefSkill`
- OK `TreasureHuntMobBattleStatus$$get_GuardProbability`
- OK `TreasureHuntMobBattleStatus$$get_Level`
- OK `TreasureHuntMobBattleStatus$$get_MagicDef`
- OK `TreasureHuntMobBattleStatus$$get_MaxHp`
- OK `TreasureHuntMobBattleStatus$$get_MoveSpeed`
- OK `TreasureHuntMobBattleStatus$$get_NecessaryFleePercent`
- OK `TreasureHuntMobBattleStatus$$get_NecessaryHit`
- OK `TreasureHuntMobBattleStatus$$get_Persona`
- OK `TreasureHuntMobBattleStatus$$get_PersonaValue`
- OK `TreasureHuntMobBattleStatus$$get_Property`
- OK `TreasureHuntMobBattleStatus$$get_StablePercent`
- OK `WaveBossMobBattleStatus$$CalcDef`
- OK `WaveBossMobBattleStatus$$CalcMdef`
- OK `WaveBossMobBattleStatus$$SetMobStatus`

## WaveBossMobBattleStatus$$get_AvoidProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']

## WaveBossMobBattleStatus$$get_CutAttack
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']

## WaveBossMobBattleStatus$$get_CutMagicAttack
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']

## WaveBossMobBattleStatus$$get_DamagePercent
- call_only_ghidra: ['ZEXT816']

## WaveBossMobBattleStatus$$get_Def
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `WaveBossMobBattleStatus$$get_Element`
- OK `WaveBossMobBattleStatus$$get_ExpDefMagic`
- OK `WaveBossMobBattleStatus$$get_ExpDefNormal`
- OK `WaveBossMobBattleStatus$$get_ExpDefSkill`

## WaveBossMobBattleStatus$$get_GuardProbability
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `WaveBossMobBattleStatus$$get_Level`

## WaveBossMobBattleStatus$$get_MagicDef
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `WaveBossMobBattleStatus$$get_MaxHp`

## WaveBossMobBattleStatus$$get_MoveSpeed
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `WaveBossMobBattleStatus$$get_NecessaryFleePercent`

## WaveBossMobBattleStatus$$get_NecessaryHit
- call_only_ghidra: ['Dispose', 'GetEnumerator', 'get_IsDead', 'get_Values']
- OK `WaveBossMobBattleStatus$$get_PartsStatus`
- OK `WaveBossMobBattleStatus$$get_Persona`
- OK `WaveBossMobBattleStatus$$get_PersonaValue`
- OK `WaveBossMobBattleStatus$$get_Property`
- OK `WaveBossMobBattleStatus$$get_StablePercent`
- OK `WaveMobBattleStatus$$CalcDef`
- OK `WaveMobBattleStatus$$CalcMdef`
- OK `WaveMobBattleStatus$$SetMobStatus`
- OK `WaveMobBattleStatus$$get_AvoidProbability`
- OK `WaveMobBattleStatus$$get_CutAttack`
- OK `WaveMobBattleStatus$$get_CutMagicAttack`

## WaveMobBattleStatus$$get_DamagePercent
- call_only_ghidra: ['ZEXT816']
- OK `WaveMobBattleStatus$$get_Def`
- OK `WaveMobBattleStatus$$get_Element`
- OK `WaveMobBattleStatus$$get_ExpDefMagic`
- OK `WaveMobBattleStatus$$get_ExpDefNormal`
- OK `WaveMobBattleStatus$$get_ExpDefSkill`
- OK `WaveMobBattleStatus$$get_GuardProbability`
- OK `WaveMobBattleStatus$$get_Level`
- OK `WaveMobBattleStatus$$get_MagicDef`
- OK `WaveMobBattleStatus$$get_MaxHp`
- OK `WaveMobBattleStatus$$get_MoveSpeed`
- OK `WaveMobBattleStatus$$get_NecessaryFleePercent`
- OK `WaveMobBattleStatus$$get_NecessaryHit`
- OK `WaveMobBattleStatus$$get_Persona`
- OK `WaveMobBattleStatus$$get_PersonaValue`
- OK `WaveMobBattleStatus$$get_Property`
- OK `WaveMobBattleStatus$$get_StablePercent`