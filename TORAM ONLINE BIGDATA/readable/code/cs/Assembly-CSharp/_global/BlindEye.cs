// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlindEye : PetSkillActionBase, IAbnormalStateSkill // TypeDefIndex: 3528
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

	// RVA: 0x236201C Offset: 0x235E01C VA: 0x236201C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2362024 Offset: 0x235E024 VA: 0x2362024 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x236202C Offset: 0x235E02C VA: 0x236202C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2362034 Offset: 0x235E034 VA: 0x2362034 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x236203C Offset: 0x235E03C VA: 0x236203C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2362044 Offset: 0x235E044 VA: 0x2362044 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x236204C Offset: 0x235E04C VA: 0x236204C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2362054 Offset: 0x235E054 VA: 0x2362054 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x236205C Offset: 0x235E05C VA: 0x236205C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2362064 Offset: 0x235E064 VA: 0x2362064 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x236206C Offset: 0x235E06C VA: 0x236206C Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x2362078 Offset: 0x235E078 VA: 0x2362078 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23621A4 Offset: 0x235E1A4 VA: 0x23621A4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2362494 Offset: 0x235E494 VA: 0x2362494 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x23624F8 Offset: 0x235E4F8 VA: 0x23624F8
	public void .ctor() { }
}
