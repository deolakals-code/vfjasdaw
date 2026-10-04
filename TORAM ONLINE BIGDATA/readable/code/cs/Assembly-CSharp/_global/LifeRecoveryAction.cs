// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LifeRecoveryAction : PlayerAttackBase // TypeDefIndex: 3703
{
	// Fields
	private int range; // 0x120
	private Vector3 checkPos; // 0x124

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23CBA14 Offset: 0x23C7A14 VA: 0x23CBA14 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23CBA1C Offset: 0x23C7A1C VA: 0x23CBA1C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23CBA24 Offset: 0x23C7A24 VA: 0x23CBA24 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23CBA2C Offset: 0x23C7A2C VA: 0x23CBA2C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23CBA34 Offset: 0x23C7A34 VA: 0x23CBA34 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23CBA3C Offset: 0x23C7A3C VA: 0x23CBA3C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23CBA44 Offset: 0x23C7A44 VA: 0x23CBA44 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23CBA4C Offset: 0x23C7A4C VA: 0x23CBA4C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23CBA54 Offset: 0x23C7A54 VA: 0x23CBA54 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23CBA5C Offset: 0x23C7A5C VA: 0x23CBA5C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23CBBCC Offset: 0x23C7BCC VA: 0x23CBBCC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23CBC9C Offset: 0x23C7C9C VA: 0x23CBC9C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23CBE58 Offset: 0x23C7E58 VA: 0x23CBE58 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23CBED4 Offset: 0x23C7ED4 VA: 0x23CBED4
	public void .ctor() { }
}
