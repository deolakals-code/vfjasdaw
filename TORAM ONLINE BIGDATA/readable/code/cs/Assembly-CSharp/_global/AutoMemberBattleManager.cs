// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AutoMemberBattleManager : PlayerBattleManager // TypeDefIndex: 443
{
	// Fields
	protected AutoMemberActionManager autoMemberActionManager; // 0x110
	private ClonePlayerAnimation cloneAnimation; // 0x118
	private PlayerStatusBase autoMemberStatus; // 0x120
	protected ArchetypeUid archetypeUid; // 0x128
	protected PlayerDataManager playerDataManager; // 0x130
	protected UISkillPopupLabel skillPopup; // 0x138
	private IEnumerator battleEndCheckCoroutine; // 0x140

	// Properties
	public override GuardType GuardType { get; }
	public override AvoidType AvoidType { get; }
	public override bool IsPlayer { get; }

	// Methods

	// RVA: 0x1749348 Offset: 0x1745348 VA: 0x1749348 Slot: 4
	public override GuardType get_GuardType() { }

	// RVA: 0x1749350 Offset: 0x1745350 VA: 0x1749350 Slot: 5
	public override AvoidType get_AvoidType() { }

	// RVA: 0x1749358 Offset: 0x1745358 VA: 0x1749358 Slot: 59
	public override bool get_IsPlayer() { }

	// RVA: 0x1749360 Offset: 0x1745360 VA: 0x1749360
	private void Start() { }

	// RVA: 0x1740234 Offset: 0x173C234 VA: 0x1740234
	public void Initialize(ArchetypeUid archetypeUid, PlayerStatusBase status) { }

	// RVA: 0x17494D0 Offset: 0x17454D0 VA: 0x17494D0 Slot: 32
	protected override void OnSkillActionEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x174999C Offset: 0x174599C VA: 0x174999C Slot: 28
	protected override bool OnSkillActionStart(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x174A140 Offset: 0x1746140 VA: 0x174A140 Slot: 60
	protected override bool AbnormalFear(SkillActionBase action) { }

	// RVA: 0x174A340 Offset: 0x1746340 VA: 0x174A340 Slot: 19
	protected override bool OnActionRange(GameObject target, SkillActionBase action) { }

	// RVA: 0x174A380 Offset: 0x1746380 VA: 0x174A380 Slot: 17
	protected override bool CheckActionRange() { }

	// RVA: 0x174A448 Offset: 0x1746448 VA: 0x174A448 Slot: 20
	protected override bool OnActionOutOfRange(GameObject target, SkillActionBase action) { }

	// RVA: 0x1740A70 Offset: 0x173CA70 VA: 0x1740A70
	public void StartAttack(GameObject target) { }

	// RVA: 0x174A014 Offset: 0x1746014 VA: 0x174A014
	protected void targetToEnemy(GameObject target) { }

	// RVA: 0x174A450 Offset: 0x1746450 VA: 0x174A450 Slot: 22
	protected override void OnBattleActive() { }

	// RVA: 0x174A4C0 Offset: 0x17464C0 VA: 0x174A4C0 Slot: 23
	protected override void OnBattleEnd() { }

	// RVA: 0x174A53C Offset: 0x174653C VA: 0x174A53C
	public void BattleEndCheck(float time) { }

	// RVA: 0x174A5AC Offset: 0x17465AC VA: 0x174A5AC
	public void StopBattleEndCheck() { }

	[IteratorStateMachine(typeof(AutoMemberBattleManager.<waitBattleEndCheck>d__27))]
	// RVA: 0x174A5F0 Offset: 0x17465F0 VA: 0x174A5F0
	private IEnumerator waitBattleEndCheck(float time) { }

	// RVA: 0x174A694 Offset: 0x1746694 VA: 0x174A694 Slot: 30
	protected override void OnSkillActionDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x174AAC4 Offset: 0x1746AC4 VA: 0x174AAC4 Slot: 31
	protected override void OnSkillActionRangeDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x174B0F8 Offset: 0x17470F8 VA: 0x174B0F8 Slot: 35
	protected override void OnSkillActionSupport(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x174B6F0 Offset: 0x17476F0 VA: 0x174B6F0 Slot: 34
	protected override void OnSkillActionCancel(GameObject target, SkillActionBase action) { }

	// RVA: 0x174B7F4 Offset: 0x17477F4 VA: 0x174B7F4 Slot: 29
	protected override void OnSkillActionHit(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x174C33C Offset: 0x174833C VA: 0x174C33C Slot: 33
	protected override void OnSkillActionAllEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x174C41C Offset: 0x174841C VA: 0x174C41C Slot: 15
	protected override void OnNextActionCancel() { }

	// RVA: 0x174C420 Offset: 0x1748420 VA: 0x174C420 Slot: 18
	public override void CheckBattleEnd() { }

	// RVA: 0x174C5B0 Offset: 0x17485B0 VA: 0x174C5B0 Slot: 27
	public override void OnAvoid(GameObject actor) { }

	// RVA: 0x174C5B4 Offset: 0x17485B4 VA: 0x174C5B4 Slot: 25
	public override void OnGuard(GameObject actor, SkillDamageData damageData) { }

	// RVA: 0x174C5B8 Offset: 0x17485B8 VA: 0x174C5B8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x174C5C0 Offset: 0x17485C0 VA: 0x174C5C0
	private bool <CheckBattleEnd>b__35_0(MobActionManagerBase m) { }
}
