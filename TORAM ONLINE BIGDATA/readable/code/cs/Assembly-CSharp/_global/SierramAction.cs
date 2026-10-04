// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SierramAction : PlayerAttackBase // TypeDefIndex: 3747
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

	// RVA: 0x23DB97C Offset: 0x23D797C VA: 0x23DB97C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23DB984 Offset: 0x23D7984 VA: 0x23DB984 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23DB98C Offset: 0x23D798C VA: 0x23DB98C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23DB994 Offset: 0x23D7994 VA: 0x23DB994 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23DB99C Offset: 0x23D799C VA: 0x23DB99C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23DB9A4 Offset: 0x23D79A4 VA: 0x23DB9A4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23DB9AC Offset: 0x23D79AC VA: 0x23DB9AC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23DB9B4 Offset: 0x23D79B4 VA: 0x23DB9B4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23DB9BC Offset: 0x23D79BC VA: 0x23DB9BC Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23DB9C4 Offset: 0x23D79C4 VA: 0x23DB9C4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23DBAF0 Offset: 0x23D7AF0 VA: 0x23DBAF0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23DBC7C Offset: 0x23D7C7C VA: 0x23DBC7C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23DBD44 Offset: 0x23D7D44 VA: 0x23DBD44
	public void .ctor() { }
}
