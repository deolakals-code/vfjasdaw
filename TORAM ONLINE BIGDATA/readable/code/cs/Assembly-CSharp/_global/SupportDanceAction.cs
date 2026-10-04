// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SupportDanceAction : PlayerAttackBase // TypeDefIndex: 3758
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23E02C8 Offset: 0x23DC2C8 VA: 0x23E02C8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23E02D0 Offset: 0x23DC2D0 VA: 0x23E02D0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23E02D8 Offset: 0x23DC2D8 VA: 0x23E02D8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23E02E0 Offset: 0x23DC2E0 VA: 0x23E02E0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23E02E8 Offset: 0x23DC2E8 VA: 0x23E02E8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23E02F0 Offset: 0x23DC2F0 VA: 0x23E02F0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23E02F8 Offset: 0x23DC2F8 VA: 0x23E02F8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23E0300 Offset: 0x23DC300 VA: 0x23E0300 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23E0308 Offset: 0x23DC308 VA: 0x23E0308 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23E0310 Offset: 0x23DC310 VA: 0x23E0310 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23E04D0 Offset: 0x23DC4D0 VA: 0x23E04D0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23E05E8 Offset: 0x23DC5E8 VA: 0x23E05E8 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23E06FC Offset: 0x23DC6FC VA: 0x23E06FC
	public void .ctor() { }
}
