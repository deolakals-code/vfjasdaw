// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(OtherPlayerSkillActionPlayer))]
public class OtherPlayerBattleManager : BattleManagerBase // TypeDefIndex: 1251
{
	// Fields
	private OtherPlayerActionManager otherActionManger; // 0x78
	private IEnumerator guardIdleAction; // 0x80
	[CompilerGenerated]
	private bool <IsGuard>k__BackingField; // 0x88

	// Properties
	public override GuardType GuardType { get; }
	public bool IsGuard { get; set; }
	public override AvoidType AvoidType { get; }

	// Methods

	// RVA: 0x1FA93BC Offset: 0x1FA53BC VA: 0x1FA93BC Slot: 4
	public override GuardType get_GuardType() { }

	[CompilerGenerated]
	// RVA: 0x1FA93C4 Offset: 0x1FA53C4 VA: 0x1FA93C4
	public bool get_IsGuard() { }

	[CompilerGenerated]
	// RVA: 0x1FA93CC Offset: 0x1FA53CC VA: 0x1FA93CC
	private void set_IsGuard(bool value) { }

	// RVA: 0x1FA93D8 Offset: 0x1FA53D8 VA: 0x1FA93D8 Slot: 5
	public override AvoidType get_AvoidType() { }

	// RVA: 0x1FA93E0 Offset: 0x1FA53E0 VA: 0x1FA93E0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x1FA9444 Offset: 0x1FA5444 VA: 0x1FA9444 Slot: 23
	protected override void OnBattleEnd() { }

	[IteratorStateMachine(typeof(OtherPlayerBattleManager.<waitPutUpWeapon>d__12))]
	// RVA: 0x1FA9494 Offset: 0x1FA5494 VA: 0x1FA9494
	private IEnumerator waitPutUpWeapon() { }

	// RVA: 0x1FA9528 Offset: 0x1FA5528 VA: 0x1FA9528 Slot: 28
	protected override bool OnSkillActionStart(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1FA9758 Offset: 0x1FA5758 VA: 0x1FA9758 Slot: 29
	protected override void OnSkillActionHit(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1FA975C Offset: 0x1FA575C VA: 0x1FA975C Slot: 30
	protected override void OnSkillActionDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x1FA9760 Offset: 0x1FA5760 VA: 0x1FA9760 Slot: 31
	protected override void OnSkillActionRangeDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1FA9764 Offset: 0x1FA5764 VA: 0x1FA9764 Slot: 32
	protected override void OnSkillActionEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1FA97AC Offset: 0x1FA57AC VA: 0x1FA97AC Slot: 33
	protected override void OnSkillActionAllEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1FA97EC Offset: 0x1FA57EC VA: 0x1FA97EC Slot: 34
	protected override void OnSkillActionCancel(GameObject target, SkillActionBase action) { }

	// RVA: 0x1F9FD40 Offset: 0x1F9BD40 VA: 0x1F9FD40
	public void GetCharacterAnimationComponent() { }

	// RVA: 0x1FA9840 Offset: 0x1FA5840 VA: 0x1FA9840
	public void FocusBattleActive() { }

	// RVA: 0x1FA9898 Offset: 0x1FA5898 VA: 0x1FA9898
	public void GuardStart(GuardAndAvoidType type, bool shortcut) { }

	[IteratorStateMachine(typeof(OtherPlayerBattleManager.<ManualGuard>d__23))]
	// RVA: 0x1FA9CFC Offset: 0x1FA5CFC VA: 0x1FA9CFC
	private IEnumerator ManualGuard(GuardAndAvoidType type) { }

	// RVA: 0x1FA7894 Offset: 0x1FA3894 VA: 0x1FA7894
	public void GuardEnd(bool forceEnd) { }

	// RVA: 0x1FA9DA0 Offset: 0x1FA5DA0 VA: 0x1FA9DA0
	public void AvoidStart(float angle, int avoidStateType, int avoidStateFlag) { }

	[IteratorStateMachine(typeof(OtherPlayerBattleManager.<LockLook>d__26))]
	// RVA: 0x1FAA25C Offset: 0x1FA625C VA: 0x1FAA25C
	private IEnumerator LockLook(bool defaultAutoLook) { }

	// RVA: 0x1FA521C Offset: 0x1FA121C VA: 0x1FA521C
	public void PlayNoMotionSkillEffect(GameObject target, SkillActionBase action) { }

	// RVA: 0x1FAA670 Offset: 0x1FA6670 VA: 0x1FAA670
	public void .ctor() { }
}
