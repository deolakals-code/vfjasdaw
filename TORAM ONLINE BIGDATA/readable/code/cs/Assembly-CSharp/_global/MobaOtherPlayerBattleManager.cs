// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(OtherPlayerSkillActionPlayer))]
public class MobaOtherPlayerBattleManager : BattleManagerBase // TypeDefIndex: 1226
{
	// Fields
	[CompilerGenerated]
	private bool <IsGuard>k__BackingField; // 0x71
	private MobaOtherPlayerActionManager otherActionManager; // 0x78
	private IEnumerator guardIdleAction; // 0x80

	// Properties
	public override GuardType GuardType { get; }
	public override AvoidType AvoidType { get; }
	public bool IsGuard { get; set; }

	// Methods

	// RVA: 0x1F93308 Offset: 0x1F8F308 VA: 0x1F93308 Slot: 4
	public override GuardType get_GuardType() { }

	// RVA: 0x1F93310 Offset: 0x1F8F310 VA: 0x1F93310 Slot: 5
	public override AvoidType get_AvoidType() { }

	[CompilerGenerated]
	// RVA: 0x1F93318 Offset: 0x1F8F318 VA: 0x1F93318
	public bool get_IsGuard() { }

	[CompilerGenerated]
	// RVA: 0x1F93320 Offset: 0x1F8F320 VA: 0x1F93320
	private void set_IsGuard(bool value) { }

	// RVA: 0x1F9332C Offset: 0x1F8F32C VA: 0x1F9332C Slot: 6
	protected override void Awake() { }

	// RVA: 0x1F93390 Offset: 0x1F8F390 VA: 0x1F93390 Slot: 23
	protected override void OnBattleEnd() { }

	[IteratorStateMachine(typeof(MobaOtherPlayerBattleManager.<waitPutUpWeapon>d__12))]
	// RVA: 0x1F933E0 Offset: 0x1F8F3E0 VA: 0x1F933E0
	private IEnumerator waitPutUpWeapon() { }

	// RVA: 0x1F93474 Offset: 0x1F8F474 VA: 0x1F93474 Slot: 28
	protected override bool OnSkillActionStart(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1F93674 Offset: 0x1F8F674 VA: 0x1F93674
	private void FailureActionStart(GameObject target, CharacterActionManagerBase targetActionManager, SkillActionBase action) { }

	// RVA: 0x1F93684 Offset: 0x1F8F684 VA: 0x1F93684 Slot: 29
	protected override void OnSkillActionHit(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1F93688 Offset: 0x1F8F688 VA: 0x1F93688 Slot: 30
	protected override void OnSkillActionDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x1F9368C Offset: 0x1F8F68C VA: 0x1F9368C Slot: 31
	protected override void OnSkillActionRangeDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1F93690 Offset: 0x1F8F690 VA: 0x1F93690 Slot: 32
	protected override void OnSkillActionEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1F936D8 Offset: 0x1F8F6D8 VA: 0x1F936D8 Slot: 33
	protected override void OnSkillActionAllEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1F93718 Offset: 0x1F8F718 VA: 0x1F93718 Slot: 34
	protected override void OnSkillActionCancel(GameObject target, SkillActionBase action) { }

	// RVA: 0x1F9376C Offset: 0x1F8F76C VA: 0x1F9376C
	public void GetCharacterAnimationComponent() { }

	// RVA: 0x1F937C4 Offset: 0x1F8F7C4 VA: 0x1F937C4
	public void FocusBattleActive() { }

	// RVA: 0x1F8F3B0 Offset: 0x1F8B3B0 VA: 0x1F8F3B0
	public void GuardStart(GuardAndAvoidType type, bool shortcut) { }

	[IteratorStateMachine(typeof(MobaOtherPlayerBattleManager.<ManualGuard>d__24))]
	// RVA: 0x1F9381C Offset: 0x1F8F81C VA: 0x1F9381C
	private IEnumerator ManualGuard(GuardAndAvoidType type) { }

	// RVA: 0x1F8F4B8 Offset: 0x1F8B4B8 VA: 0x1F8F4B8
	public void GuardEnd(bool forceEnd) { }

	// RVA: 0x1F8F530 Offset: 0x1F8B530 VA: 0x1F8F530
	public void AvoidStart(float angle, int avoidStateType) { }

	[IteratorStateMachine(typeof(MobaOtherPlayerBattleManager.<LockLook>d__27))]
	// RVA: 0x1F938C8 Offset: 0x1F8F8C8 VA: 0x1F938C8
	private IEnumerator LockLook(bool defaultAutoLook) { }

	// RVA: 0x1F881BC Offset: 0x1F841BC VA: 0x1F881BC
	public void PlayNoMotionSkillEffect(GameObject target, SkillActionBase action) { }

	// RVA: 0x1F93970 Offset: 0x1F8F970 VA: 0x1F93970
	public void .ctor() { }
}
