// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FairyDanceAction : PlayerAttackBase // TypeDefIndex: 3650
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

	// RVA: 0x23B9A0C Offset: 0x23B5A0C VA: 0x23B9A0C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B9A14 Offset: 0x23B5A14 VA: 0x23B9A14 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B9A1C Offset: 0x23B5A1C VA: 0x23B9A1C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B9A24 Offset: 0x23B5A24 VA: 0x23B9A24 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B9A2C Offset: 0x23B5A2C VA: 0x23B9A2C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B9A34 Offset: 0x23B5A34 VA: 0x23B9A34 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B9A3C Offset: 0x23B5A3C VA: 0x23B9A3C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B9A44 Offset: 0x23B5A44 VA: 0x23B9A44 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B9A4C Offset: 0x23B5A4C VA: 0x23B9A4C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B9A54 Offset: 0x23B5A54 VA: 0x23B9A54 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B9C18 Offset: 0x23B5C18 VA: 0x23B9C18 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B9D34 Offset: 0x23B5D34 VA: 0x23B9D34 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B9E48 Offset: 0x23B5E48 VA: 0x23B9E48
	public void .ctor() { }
}
