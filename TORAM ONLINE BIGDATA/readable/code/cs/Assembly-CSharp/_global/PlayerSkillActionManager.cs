// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PlayerSkillActionManager : SkillActionManager // TypeDefIndex: 1470
{
	// Fields
	private bool autoMemberFlag; // 0xC4
	private IMainPlayer playerManager; // 0xC8

	// Methods

	// RVA: 0x2052638 Offset: 0x204E638 VA: 0x2052638 Slot: 12
	protected override void Awake() { }

	// RVA: 0x20526BC Offset: 0x204E6BC VA: 0x20526BC Slot: 9
	public override void SetCurrentSkill(GameObject target, SkillActionBase action) { }

	// RVA: 0x20527D4 Offset: 0x204E7D4 VA: 0x20527D4 Slot: 15
	public override void StopPlaceSkill(SkillActionBase action) { }

	// RVA: 0x2053284 Offset: 0x204F284 VA: 0x2053284
	public void TakeSkipPlaceSkill(SkillId skillId) { }

	// RVA: 0x2053390 Offset: 0x204F390 VA: 0x2053390
	public int GuardAction(GameObject target) { }

	// RVA: 0x205365C Offset: 0x204F65C VA: 0x205365C
	public int GuardDamageAction(GameObject target, bool justGuard) { }

	// RVA: 0x205389C Offset: 0x204F89C VA: 0x205389C
	private void GuardTake(int uid, TakeEventType type, int param) { }

	// RVA: 0x2053A54 Offset: 0x204FA54 VA: 0x2053A54
	public void AvoidAction(GameObject target) { }

	// RVA: 0x2053B08 Offset: 0x204FB08 VA: 0x2053B08 Slot: 18
	protected override void OnTakeEvent(SkillActionManager.SkillActionData skillData, TakeEventType eventType, int param) { }

	// RVA: 0x2053F2C Offset: 0x204FF2C VA: 0x2053F2C Slot: 16
	protected override SkillActionManager.SkillActionData OnPlayHitTake(SkillActionManager.SkillActionData skillData, SkillActionBase.DamageData damageData) { }

	// RVA: 0x2054568 Offset: 0x2050568 VA: 0x2054568 Slot: 17
	protected override SkillActionManager.SkillActionData OnPlayRangeHitTake(SkillActionManager.SkillActionData skillData, SkillActionBase.DamageData damageData) { }

	// RVA: 0x20548C4 Offset: 0x20508C4 VA: 0x20548C4
	public void PlaceEffectPlay(GameObject target, SkillActionBase action) { }

	// RVA: 0x2054C30 Offset: 0x2050C30 VA: 0x2054C30
	public void BreakPlaceSkill(CharacterActionManagerBase targetAction, SkillActionBase action) { }

	// RVA: 0x2055BA0 Offset: 0x2051BA0 VA: 0x2055BA0
	public void ChangeEquipStopPlaceSkill() { }

	// RVA: 0x2056030 Offset: 0x2052030 VA: 0x2056030
	public void HalveCastingTime(SkillActionBase action, out float newCastTime) { }

	// RVA: 0x20560F4 Offset: 0x20520F4 VA: 0x20560F4
	public void HighFamiliaSkillStart(GameObject target, SkillActionBase action) { }

	// RVA: 0x20564A8 Offset: 0x20524A8 VA: 0x20564A8
	public void RequestSkillDamage(GameObject target, SkillActionBase action) { }

	// RVA: 0x2056680 Offset: 0x2052680 VA: 0x2056680 Slot: 19
	protected override void OnCastEnd(SkillActionManager.SkillActionData skill) { }

	// RVA: 0x20566C8 Offset: 0x20526C8 VA: 0x20566C8
	private void StartSkillComboInvincibility(SkillActionManager.SkillActionData skill) { }

	// RVA: 0x2056AC4 Offset: 0x2052AC4 VA: 0x2056AC4
	public void ReceiveMobaHitDamage(AttackResponseData response, MobaPlayerActionManager actarAction, CharacterActionManagerBase targetAction) { }

	// RVA: 0x2056CA8 Offset: 0x2052CA8 VA: 0x2056CA8
	public void .ctor() { }
}
