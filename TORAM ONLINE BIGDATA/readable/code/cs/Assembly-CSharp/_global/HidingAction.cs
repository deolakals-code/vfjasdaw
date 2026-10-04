// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HidingAction : PlayerAttackBase // TypeDefIndex: 3675
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

	// RVA: 0x23C1E48 Offset: 0x23BDE48 VA: 0x23C1E48 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23C1E50 Offset: 0x23BDE50 VA: 0x23C1E50 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23C1E58 Offset: 0x23BDE58 VA: 0x23C1E58 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23C1E60 Offset: 0x23BDE60 VA: 0x23C1E60 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23C1E68 Offset: 0x23BDE68 VA: 0x23C1E68 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23C1E70 Offset: 0x23BDE70 VA: 0x23C1E70 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23C1E78 Offset: 0x23BDE78 VA: 0x23C1E78 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23C1E80 Offset: 0x23BDE80 VA: 0x23C1E80 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23C1E88 Offset: 0x23BDE88 VA: 0x23C1E88 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23C1E90 Offset: 0x23BDE90 VA: 0x23C1E90 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C1F74 Offset: 0x23BDF74 VA: 0x23C1F74 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C1FF4 Offset: 0x23BDFF4 VA: 0x23C1FF4
	public void .ctor() { }
}
