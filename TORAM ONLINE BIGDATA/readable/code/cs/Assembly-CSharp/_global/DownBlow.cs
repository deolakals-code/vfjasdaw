// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DownBlow : PetSkillActionBase, IAbnormalStateSkill // TypeDefIndex: 3537
{
	// Fields
	private float skillRate; // 0x150
	private float fixAddDamage; // 0x154
	private int abnormalPercent; // 0x158

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsSupport { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	protected override bool UseSkillEffect { get; }
	protected override int HitTakeId { get; }

	// Methods

	// RVA: 0x2366B04 Offset: 0x2362B04 VA: 0x2366B04 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2366B0C Offset: 0x2362B0C VA: 0x2366B0C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2366B14 Offset: 0x2362B14 VA: 0x2366B14 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2366B1C Offset: 0x2362B1C VA: 0x2366B1C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2366B24 Offset: 0x2362B24 VA: 0x2366B24 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2366B2C Offset: 0x2362B2C VA: 0x2366B2C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2366B34 Offset: 0x2362B34 VA: 0x2366B34 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2366B3C Offset: 0x2362B3C VA: 0x2366B3C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2366B44 Offset: 0x2362B44 VA: 0x2366B44 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2366B4C Offset: 0x2362B4C VA: 0x2366B4C Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x2366B54 Offset: 0x2362B54 VA: 0x2366B54 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x2366B60 Offset: 0x2362B60 VA: 0x2366B60 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2366CF8 Offset: 0x2362CF8 VA: 0x2366CF8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2367038 Offset: 0x2363038 VA: 0x2367038 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x236709C Offset: 0x236309C VA: 0x236709C
	public void .ctor() { }
}
