// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(TakeController))]
[RequireComponent(typeof(FadeAnimationManager))]
public class CallGolemActionManager : AutoMemberActionManager // TypeDefIndex: 530
{
	// Fields
	[CompilerGenerated]
	private CallGolemType <GolemType>k__BackingField; // 0x164
	[CompilerGenerated]
	private bool <IsNextAttackSkillRateBoost>k__BackingField; // 0x168
	private PlayerStatusBase ownerPlayerStatus; // 0x170
	private AnimationBase autoAnimation; // 0x178
	[SerializeField]
	private bool aiLock; // 0x180
	private Action interrupt; // 0x188
	private CallGolemBattleManager golemBattleManager; // 0x190
	private CallGolemAI callGolemAI; // 0x198
	private float moveSpeed; // 0x1A0

	// Properties
	public override PlayerStatusBase PlayerStatus { get; }
	public CallGolemType GolemType { get; set; }
	public override float MoveSpeed { get; }
	public bool IsNextAttackSkillRateBoost { get; set; }

	// Methods

	// RVA: 0x1830424 Offset: 0x182C424 VA: 0x1830424 Slot: 22
	public override PlayerStatusBase get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x183042C Offset: 0x182C42C VA: 0x183042C
	public CallGolemType get_GolemType() { }

	[CompilerGenerated]
	// RVA: 0x1830434 Offset: 0x182C434 VA: 0x1830434
	private void set_GolemType(CallGolemType value) { }

	// RVA: 0x183043C Offset: 0x182C43C VA: 0x183043C Slot: 10
	public override float get_MoveSpeed() { }

	[CompilerGenerated]
	// RVA: 0x1830444 Offset: 0x182C444 VA: 0x1830444
	public bool get_IsNextAttackSkillRateBoost() { }

	[CompilerGenerated]
	// RVA: 0x183044C Offset: 0x182C44C VA: 0x183044C
	public void set_IsNextAttackSkillRateBoost(bool value) { }

	// RVA: 0x1830458 Offset: 0x182C458 VA: 0x1830458 Slot: 25
	protected override void Update() { }

	// RVA: 0x183076C Offset: 0x182C76C VA: 0x183076C
	public void Initialize(Archetype archetype, CallGolemMemberSettingBase setting) { }

	// RVA: 0x18314E0 Offset: 0x182D4E0 VA: 0x18314E0
	public void OwnerDead() { }

	[IteratorStateMachine(typeof(CallGolemActionManager.<CheckRemoveGolem>d__22))]
	// RVA: 0x1831500 Offset: 0x182D500 VA: 0x1831500
	private IEnumerator CheckRemoveGolem() { }

	// RVA: 0x1831594 Offset: 0x182D594 VA: 0x1831594
	public void EventReserve() { }

	// RVA: 0x18316CC Offset: 0x182D6CC VA: 0x18316CC Slot: 32
	public override void VanishingObject(GameObject enemy) { }

	// RVA: 0x1831998 Offset: 0x182D998 VA: 0x1831998
	public void RemoveCallGolem(bool force) { }

	// RVA: 0x1831B98 Offset: 0x182DB98 VA: 0x1831B98 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1831BBC Offset: 0x182DBBC VA: 0x1831BBC
	public void BattleReservation(MobActionManagerBase target, float assistMoveTargetDistance) { }

	// RVA: 0x1831D50 Offset: 0x182DD50 VA: 0x1831D50
	public void CurrentSkillEnd(SkillActionBase action) { }

	// RVA: 0x183131C Offset: 0x182D31C VA: 0x183131C
	internal void AnimationPlayLock(CallGolemAnimationNo animationNo, WrapMode mode = 1, Action callback) { }

	// RVA: 0x183142C Offset: 0x182D42C VA: 0x183142C
	private void CalcMoveSpeed(ExSkillCallGolem exSkillCallGolem) { }

	// RVA: 0x1831E74 Offset: 0x182DE74 VA: 0x1831E74
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1831E84 Offset: 0x182DE84 VA: 0x1831E84
	private void <RemoveCallGolem>b__25_2() { }

	[CompilerGenerated]
	// RVA: 0x1831EF0 Offset: 0x182DEF0 VA: 0x1831EF0
	private void <RemoveCallGolem>b__25_1() { }
}
