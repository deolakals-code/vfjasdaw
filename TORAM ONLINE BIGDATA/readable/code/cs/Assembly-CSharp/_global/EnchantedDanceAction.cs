// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EnchantedDanceAction : PlayerAttackBase // TypeDefIndex: 3644
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

	// RVA: 0x23B7FA8 Offset: 0x23B3FA8 VA: 0x23B7FA8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B7FB0 Offset: 0x23B3FB0 VA: 0x23B7FB0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B7FB8 Offset: 0x23B3FB8 VA: 0x23B7FB8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B7FC0 Offset: 0x23B3FC0 VA: 0x23B7FC0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B7FC8 Offset: 0x23B3FC8 VA: 0x23B7FC8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B7FD0 Offset: 0x23B3FD0 VA: 0x23B7FD0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B7FD8 Offset: 0x23B3FD8 VA: 0x23B7FD8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B7FE0 Offset: 0x23B3FE0 VA: 0x23B7FE0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B7FE8 Offset: 0x23B3FE8 VA: 0x23B7FE8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B7FF0 Offset: 0x23B3FF0 VA: 0x23B7FF0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B81B4 Offset: 0x23B41B4 VA: 0x23B81B4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B82D0 Offset: 0x23B42D0 VA: 0x23B82D0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B83E4 Offset: 0x23B43E4 VA: 0x23B83E4
	public void .ctor() { }
}
