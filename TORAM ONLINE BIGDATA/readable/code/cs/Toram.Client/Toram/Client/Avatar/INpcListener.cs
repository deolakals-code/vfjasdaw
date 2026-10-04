// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Avatar
public interface INpcListener // TypeDefIndex: 15153
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNaturalRecovery(NaturalRecoveryEvent response);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnChangeState(ArchetypeChangeState response);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnMonsterFollowersPop(MonsterFollowersPop response);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnAbnormalDamage(AbnormalDamageEvent response);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnAbnormalStateEnd(AbnormalStateEndEvent response);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnAddAbnormalState(AddAbnormalStateEvent response);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnSkillBuffEndEvent(SkillBuffEndEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnSkillDelayStandbyOk(SkillReusePermissioneEvent response);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void OnUpdateGameStatus(UpdateGameStatusEvent updateEvent);
}
