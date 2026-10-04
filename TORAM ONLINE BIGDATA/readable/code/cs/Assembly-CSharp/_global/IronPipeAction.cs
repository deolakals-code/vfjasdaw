// Assembly: Assembly-CSharp.dll
// Namespace: 
public class IronPipeAction : PlayerAttackBase, IHalloweenSkill // TypeDefIndex: 2656
{
	// Fields
	private float skillRate; // 0x120
	private int criticalRate; // 0x124
	private byte invincibilityId; // 0x128
	private GameObject attackTarget; // 0x130

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public int UseItemId { get; }

	// Methods

	// RVA: 0x2223FA0 Offset: 0x221FFA0 VA: 0x2223FA0 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2223FA8 Offset: 0x221FFA8 VA: 0x2223FA8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2223FB0 Offset: 0x221FFB0 VA: 0x2223FB0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2223FB8 Offset: 0x221FFB8 VA: 0x2223FB8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2223FC0 Offset: 0x221FFC0 VA: 0x2223FC0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2223FC8 Offset: 0x221FFC8 VA: 0x2223FC8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2223FD0 Offset: 0x221FFD0 VA: 0x2223FD0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2223FD8 Offset: 0x221FFD8 VA: 0x2223FD8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2223FE0 Offset: 0x221FFE0 VA: 0x2223FE0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2223FE8 Offset: 0x221FFE8 VA: 0x2223FE8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2224170 Offset: 0x2220170 VA: 0x2224170 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22241F8 Offset: 0x22201F8 VA: 0x22241F8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22242B4 Offset: 0x22202B4 VA: 0x22242B4 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x222441C Offset: 0x222041C VA: 0x222441C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x222470C Offset: 0x222070C VA: 0x222470C Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2224770 Offset: 0x2220770 VA: 0x2224770 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22248A4 Offset: 0x22208A4 VA: 0x22248A4 Slot: 91
	public int get_UseItemId() { }

	// RVA: 0x22248AC Offset: 0x22208AC VA: 0x22248AC Slot: 93
	public void OnInitializeEventRoom() { }

	// RVA: 0x2224928 Offset: 0x2220928 VA: 0x2224928 Slot: 94
	public bool CheckRangeHitEventRoom(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2224B2C Offset: 0x2220B2C VA: 0x2224B2C
	public void .ctor() { }
}
