// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(TakeController))]
[RequireComponent(typeof(FadeAnimationManager))]
public class SummonDemonicActionManager : AutoMemberActionManager // TypeDefIndex: 1628
{
	// Fields
	private PlayerDataManager player; // 0x168
	private PlayerStatusBase ownerPlayerStatus; // 0x170
	private SummonDemonicBattleManager summonDemonicBattleManager; // 0x178
	private AnimationBase autoAnimation; // 0x180
	[SerializeField]
	private bool aiLock; // 0x188
	private Action interrupt; // 0x190
	private SummonDemonicAI summonDemonicAI; // 0x198

	// Properties
	public override PlayerStatusBase PlayerStatus { get; }

	// Methods

	// RVA: 0x2099950 Offset: 0x2095950 VA: 0x2099950 Slot: 22
	public override PlayerStatusBase get_PlayerStatus() { }

	// RVA: 0x2099958 Offset: 0x2095958 VA: 0x2099958 Slot: 25
	protected override void Update() { }

	// RVA: 0x2099C70 Offset: 0x2095C70 VA: 0x2099C70
	public void Initialize(Archetype archetype, SummonDemonicMemberSettingBase setting) { }

	// RVA: 0x209A9C8 Offset: 0x20969C8 VA: 0x209A9C8
	public void RemoveSummonDemonic(bool force) { }

	// RVA: 0x209ABC0 Offset: 0x2096BC0 VA: 0x209ABC0
	public void OwnerDead() { }

	[IteratorStateMachine(typeof(SummonDemonicActionManager.<CheckRemoveDemon>d__13))]
	// RVA: 0x209ABE0 Offset: 0x2096BE0 VA: 0x209ABE0
	private IEnumerator CheckRemoveDemon() { }

	// RVA: 0x209AC74 Offset: 0x2096C74 VA: 0x209AC74
	public void EventReserve() { }

	// RVA: 0x209ADAC Offset: 0x2096DAC VA: 0x209ADAC Slot: 32
	public override void VanishingObject(GameObject enemy) { }

	// RVA: 0x209AFD4 Offset: 0x2096FD4 VA: 0x209AFD4 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x209AFF8 Offset: 0x2096FF8 VA: 0x209AFF8
	public void BattleReserveNormalAttack(MobActionManagerBase target, float assistMoveTargetDistance) { }

	// RVA: 0x209B198 Offset: 0x2097198 VA: 0x209B198
	public void BattleReservSpecialAttack(MobActionManagerBase target, float assistMoveTargetDistance) { }

	// RVA: 0x209B338 Offset: 0x2097338 VA: 0x209B338
	public void CurrentSkillEnd(SkillActionBase action) { }

	// RVA: 0x209A8B8 Offset: 0x20968B8 VA: 0x209A8B8
	internal void AnimationPlayLock(SummonDemonicAnimationNo animationNo, WrapMode mode = 1, Action callback) { }

	// RVA: 0x209B4E8 Offset: 0x20974E8 VA: 0x209B4E8
	public void ReserveDarkAttack(MobActionManagerBase mobAction) { }

	// RVA: 0x209B5CC Offset: 0x20975CC VA: 0x209B5CC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x209B5D4 Offset: 0x20975D4 VA: 0x209B5D4
	private void <RemoveSummonDemonic>b__11_2() { }

	[CompilerGenerated]
	// RVA: 0x209B640 Offset: 0x2097640 VA: 0x209B640
	private void <RemoveSummonDemonic>b__11_1() { }
}
