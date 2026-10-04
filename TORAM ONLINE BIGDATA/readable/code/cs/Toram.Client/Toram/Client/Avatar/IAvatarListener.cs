// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Avatar
public interface IAvatarListener // TypeDefIndex: 15152
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSetEquipProperties(bool isUpdate, NewArchetypeProperties properties);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnStatusUp(StatusUpResponse response);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnLevelUp(LevelupEvent response);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnComboPointUp(ComboPointUpEvent response);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnNaturalRecovery(NaturalRecoveryEvent response);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnSetProperties(NewArchetypeProperties properties);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnChangeState(ArchetypeChangeState response);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnMonsterFollowersPop(MonsterFollowersPop response);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void OnAbnormalDamage(AbnormalDamageEvent response);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void OnAbnormalStateEnd(AbnormalStateEndEvent response);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnAddAbnormalState(AddAbnormalStateEvent response);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void OnStartComboBonus(StartComboBonusEvent response);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void OnEndComboBonus(EndComboBonusEvent response);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void OnSkillBuffEnd(SkillBuffEndEvent endEvnet);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void OnSkillDelayStandbyOk(SkillReusePermissioneEvent response);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnUpdateGameStatus(UpdateGameStatusEvent updateEvent);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void OnItemDurationEnd(ItemDurationEndEvent endEvent);
}
