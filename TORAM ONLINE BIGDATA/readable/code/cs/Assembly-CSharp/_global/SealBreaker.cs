// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SealBreaker : PetSkillActionBase, IAbnormalStateSkill // TypeDefIndex: 3530
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

	// RVA: 0x2362940 Offset: 0x235E940 VA: 0x2362940 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2362948 Offset: 0x235E948 VA: 0x2362948 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2362950 Offset: 0x235E950 VA: 0x2362950 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2362958 Offset: 0x235E958 VA: 0x2362958 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2362960 Offset: 0x235E960 VA: 0x2362960 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2362968 Offset: 0x235E968 VA: 0x2362968 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2362970 Offset: 0x235E970 VA: 0x2362970 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2362978 Offset: 0x235E978 VA: 0x2362978 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2362980 Offset: 0x235E980 VA: 0x2362980 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2362988 Offset: 0x235E988 VA: 0x2362988 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x2362990 Offset: 0x235E990 VA: 0x2362990 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x236299C Offset: 0x235E99C VA: 0x236299C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2362B04 Offset: 0x235EB04 VA: 0x2362B04 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2362DF4 Offset: 0x235EDF4 VA: 0x2362DF4 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2362E58 Offset: 0x235EE58 VA: 0x2362E58
	public void .ctor() { }
}
