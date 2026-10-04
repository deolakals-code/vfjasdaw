// Assembly: Assembly-CSharp.dll
// Namespace: 
public class KnightStanceAction : PlayerAttackBase // TypeDefIndex: 3700
{
	// Fields
	private ItemDBData.ItemType subWeaponType; // 0x120

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23CAA10 Offset: 0x23C6A10 VA: 0x23CAA10 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23CAA18 Offset: 0x23C6A18 VA: 0x23CAA18 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23CAA20 Offset: 0x23C6A20 VA: 0x23CAA20 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23CAA28 Offset: 0x23C6A28 VA: 0x23CAA28 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23CAA30 Offset: 0x23C6A30 VA: 0x23CAA30 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23CAA38 Offset: 0x23C6A38 VA: 0x23CAA38 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23CAA40 Offset: 0x23C6A40 VA: 0x23CAA40 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23CAA48 Offset: 0x23C6A48 VA: 0x23CAA48 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23CAA50 Offset: 0x23C6A50 VA: 0x23CAA50 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23CAA58 Offset: 0x23C6A58 VA: 0x23CAA58 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23CAB84 Offset: 0x23C6B84 VA: 0x23CAB84 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23CAC94 Offset: 0x23C6C94 VA: 0x23CAC94 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23CB058 Offset: 0x23C7058 VA: 0x23CB058
	public void .ctor() { }
}
