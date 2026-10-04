// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(TakeController))]
public class HuntingOneActionManager : AutoMemberActionManager // TypeDefIndex: 585
{
	// Fields
	private PlayerDataManager player; // 0x168
	private PlayerStatusBase ownerPlayerStatus; // 0x170
	private AnimationBase autoAnimation; // 0x178
	private HuntingOneBattleManager huntingOneBattleManager; // 0x180
	[SerializeField]
	private bool aiLock; // 0x188
	private Action interrupt; // 0x190
	private HuntingOneAI huntingOneAI; // 0x198

	// Properties
	public override PlayerStatusBase PlayerStatus { get; }

	// Methods

	// RVA: 0x1907468 Offset: 0x1903468 VA: 0x1907468 Slot: 22
	public override PlayerStatusBase get_PlayerStatus() { }

	// RVA: 0x1907470 Offset: 0x1903470 VA: 0x1907470 Slot: 25
	protected override void Update() { }

	// RVA: 0x1907784 Offset: 0x1903784 VA: 0x1907784
	public void Initialize(Archetype archetype, HuntingOneMemberSettingBase setting) { }

	// RVA: 0x1908558 Offset: 0x1904558 VA: 0x1908558
	public void RemoveHuntingOne(bool force) { }

	// RVA: 0x1908750 Offset: 0x1904750 VA: 0x1908750
	public void OwnerDead(int value) { }

	[IteratorStateMachine(typeof(HuntingOneActionManager.<CheckResurrect>d__13))]
	// RVA: 0x1908770 Offset: 0x1904770 VA: 0x1908770
	private IEnumerator CheckResurrect(int value) { }

	// RVA: 0x1908814 Offset: 0x1904814 VA: 0x1908814
	public void EventReserve() { }

	// RVA: 0x190894C Offset: 0x190494C VA: 0x190894C Slot: 32
	public override void VanishingObject(GameObject enemy) { }

	// RVA: 0x1908B74 Offset: 0x1904B74 VA: 0x1908B74 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1908B98 Offset: 0x1904B98 VA: 0x1908B98
	public void BattleReservation(MobActionManagerBase target, float assistMoveTargetDistance) { }

	// RVA: 0x1908D2C Offset: 0x1904D2C VA: 0x1908D2C
	public void SupportResevation(PlayerActionManagerBase target, int paramValue) { }

	// RVA: 0x1908DE8 Offset: 0x1904DE8 VA: 0x1908DE8
	public void CurrentSkillEnd(SkillActionBase action) { }

	// RVA: 0x1908448 Offset: 0x1904448 VA: 0x1908448
	internal void AnimationPlayLock(HuntingOneAnimationNo animationNo, WrapMode mode = 1, Action callback) { }

	// RVA: 0x1908FF0 Offset: 0x1904FF0 VA: 0x1908FF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1908FF8 Offset: 0x1904FF8 VA: 0x1908FF8
	private void <RemoveHuntingOne>b__11_2() { }

	[CompilerGenerated]
	// RVA: 0x1909064 Offset: 0x1905064 VA: 0x1909064
	private void <RemoveHuntingOne>b__11_1() { }
}
