// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GladiateAction : PlayerAttackBase // TypeDefIndex: 3661
{
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

	// RVA: 0x23BCD4C Offset: 0x23B8D4C VA: 0x23BCD4C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23BCD54 Offset: 0x23B8D54 VA: 0x23BCD54 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23BCD5C Offset: 0x23B8D5C VA: 0x23BCD5C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23BCD64 Offset: 0x23B8D64 VA: 0x23BCD64 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23BCD6C Offset: 0x23B8D6C VA: 0x23BCD6C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23BCD74 Offset: 0x23B8D74 VA: 0x23BCD74 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23BCD7C Offset: 0x23B8D7C VA: 0x23BCD7C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23BCD84 Offset: 0x23B8D84 VA: 0x23BCD84 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23BCD8C Offset: 0x23B8D8C VA: 0x23BCD8C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23BCD94 Offset: 0x23B8D94 VA: 0x23BCD94 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23BCED8 Offset: 0x23B8ED8 VA: 0x23BCED8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BCEE0 Offset: 0x23B8EE0 VA: 0x23BCEE0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23BCFA8 Offset: 0x23B8FA8 VA: 0x23BCFA8 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BD0E4 Offset: 0x23B90E4 VA: 0x23BD0E4
	public void .ctor() { }
}
