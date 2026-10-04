// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BindStrikeAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2743
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int percent; // 0x128
	private float range; // 0x12C
	private bool isEquipShield; // 0x130
	private Transform target; // 0x138

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }

	// Methods

	// RVA: 0x2252B50 Offset: 0x224EB50 VA: 0x2252B50 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2252B58 Offset: 0x224EB58 VA: 0x2252B58 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2252B60 Offset: 0x224EB60 VA: 0x2252B60 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2252B68 Offset: 0x224EB68 VA: 0x2252B68 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2252B70 Offset: 0x224EB70 VA: 0x2252B70 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2252B78 Offset: 0x224EB78 VA: 0x2252B78 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2252B80 Offset: 0x224EB80 VA: 0x2252B80 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2252B88 Offset: 0x224EB88 VA: 0x2252B88 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2252B90 Offset: 0x224EB90 VA: 0x2252B90 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2252E9C Offset: 0x224EE9C VA: 0x2252E9C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2253044 Offset: 0x224F044 VA: 0x2253044 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2253274 Offset: 0x224F274 VA: 0x2253274 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2253800 Offset: 0x224F800 VA: 0x2253800 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x225391C Offset: 0x224F91C VA: 0x225391C Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22539C4 Offset: 0x224F9C4 VA: 0x22539C4
	public void .ctor() { }
}
