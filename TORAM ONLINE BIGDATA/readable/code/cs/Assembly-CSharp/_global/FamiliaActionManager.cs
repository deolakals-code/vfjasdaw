// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(TakeController))]
[RequireComponent(typeof(FadeAnimationManager))]
public class FamiliaActionManager : AutoMemberActionManager // TypeDefIndex: 575
{
	// Fields
	private readonly int[] UseHighFamiliaSkills; // 0x168
	private PlayerDataManager player; // 0x170
	private PlayerStatusBase ownerPlayerStatus; // 0x178
	private AnimationBase autoAnimation; // 0x180
	private FamiliaBattleManager familiaBattleManager; // 0x188
	private SkillManager skillManager; // 0x190
	private FamiliaMovingAI familiaAI; // 0x198
	private bool aiLock; // 0x1A0
	private Action interrupt; // 0x1A8
	private FamiliaActionManager.StateFlag stateFlag; // 0x1B0
	private float actionDelay; // 0x1B4
	[CompilerGenerated]
	private bool <IsHighFamilia>k__BackingField; // 0x1B8

	// Properties
	public override PlayerStatusBase PlayerStatus { get; }
	public bool IsHighFamilia { get; set; }
	public float AICoolDownTime { get; }

	// Methods

	// RVA: 0x18FFE80 Offset: 0x18FBE80 VA: 0x18FFE80 Slot: 22
	public override PlayerStatusBase get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x18FFE88 Offset: 0x18FBE88 VA: 0x18FFE88
	public bool get_IsHighFamilia() { }

	[CompilerGenerated]
	// RVA: 0x18FFE90 Offset: 0x18FBE90 VA: 0x18FFE90
	private void set_IsHighFamilia(bool value) { }

	// RVA: 0x18FFE9C Offset: 0x18FBE9C VA: 0x18FFE9C
	public float get_AICoolDownTime() { }

	// RVA: 0x18FFEA4 Offset: 0x18FBEA4 VA: 0x18FFEA4
	private void Update() { }

	// RVA: 0x1900A30 Offset: 0x18FCA30 VA: 0x1900A30
	public void Initialize(Archetype archetype, FamiliaMemberSettingBase setting) { }

	// RVA: 0x1902054 Offset: 0x18FE054 VA: 0x1902054
	public void RemoveFamilia(bool force) { }

	// RVA: 0x1902A50 Offset: 0x18FEA50 VA: 0x1902A50
	public void SkillActionReserve(PlayerAttackBase baseSkill, GameObject target, int parentUid = -1) { }

	// RVA: 0x1902C54 Offset: 0x18FEC54 VA: 0x1902C54 Slot: 32
	public override void VanishingObject(GameObject enemy) { }

	// RVA: 0x1902D30 Offset: 0x18FED30 VA: 0x1902D30 Slot: 31
	public override void FirstEnemyContact(GameObject actor, bool isActiveInvoke) { }

	// RVA: 0x1902E14 Offset: 0x18FEE14 VA: 0x1902E14 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1903438 Offset: 0x18FF438 VA: 0x1903438 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x190361C Offset: 0x18FF61C VA: 0x190361C
	public void Repop(Vector3 repopPosition) { }

	// RVA: 0x1903774 Offset: 0x18FF774 VA: 0x1903774
	public void Repop(SkillId skillId, Vector3 repopPosition) { }

	// RVA: 0x190378C Offset: 0x18FF78C VA: 0x190378C
	public void FastMove(Vector3 movePos) { }

	// RVA: 0x18FFF48 Offset: 0x18FBF48 VA: 0x18FFF48
	private void UpdateMoveAI() { }

	// RVA: 0x18FFFA4 Offset: 0x18FBFA4 VA: 0x18FFFA4
	private void UpdateHighFamilia() { }

	// RVA: 0x1901F50 Offset: 0x18FDF50 VA: 0x1901F50
	private void AnimationPlayLock(FamiliaAnimationNo animationNo, Action callback) { }

	// RVA: 0x1902248 Offset: 0x18FE248 VA: 0x1902248
	private void CancelManaCrystal() { }

	// RVA: 0x1902358 Offset: 0x18FE358 VA: 0x1902358
	private void CancelSkillToMaster() { }

	// RVA: 0x1903494 Offset: 0x18FF494 VA: 0x1903494
	public void AbnormalCancelFamiliaSkill() { }

	// RVA: 0x1903984 Offset: 0x18FF984 VA: 0x1903984
	public void InterruptCancel() { }

	// RVA: 0x19025AC Offset: 0x18FE5AC VA: 0x19025AC
	public void CancelCastingFamiliaSkill() { }

	// RVA: 0x1903D80 Offset: 0x18FFD80 VA: 0x1903D80
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1903E10 Offset: 0x18FFE10 VA: 0x1903E10
	private void <RemoveFamilia>b__22_2() { }

	[CompilerGenerated]
	// RVA: 0x1903E7C Offset: 0x18FFE7C VA: 0x1903E7C
	private void <RemoveFamilia>b__22_1() { }
}
