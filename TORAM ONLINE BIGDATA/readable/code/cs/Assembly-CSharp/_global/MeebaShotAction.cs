// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MeebaShotAction : PlayerAttackBase, IAbnormalStateSkill, IDualElementSkill // TypeDefIndex: 2995
{
	// Fields
	[CompilerGenerated]
	private bool <IsValidDualElement>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private float bonusSkillRate; // 0x128
	private int fixAddDamage; // 0x12C
	private int slowPercent; // 0x130

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public bool IsValidDualElement { get; set; }

	// Methods

	// RVA: 0x22F7768 Offset: 0x22F3768 VA: 0x22F7768 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22F7770 Offset: 0x22F3770 VA: 0x22F7770 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22F7778 Offset: 0x22F3778 VA: 0x22F7778 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22F7780 Offset: 0x22F3780 VA: 0x22F7780 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22F7788 Offset: 0x22F3788 VA: 0x22F7788 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22F7790 Offset: 0x22F3790 VA: 0x22F7790 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22F7798 Offset: 0x22F3798 VA: 0x22F7798 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22F77A0 Offset: 0x22F37A0 VA: 0x22F77A0 Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x22F77A8 Offset: 0x22F37A8 VA: 0x22F77A8 Slot: 92
	public bool get_IsValidDualElement() { }

	[CompilerGenerated]
	// RVA: 0x22F77B0 Offset: 0x22F37B0 VA: 0x22F77B0
	private void set_IsValidDualElement(bool value) { }

	// RVA: 0x22F77BC Offset: 0x22F37BC VA: 0x22F77BC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22F7A30 Offset: 0x22F3A30 VA: 0x22F7A30 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22F7BD4 Offset: 0x22F3BD4 VA: 0x22F7BD4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22F804C Offset: 0x22F404C VA: 0x22F804C Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22F80B0 Offset: 0x22F40B0 VA: 0x22F80B0
	public void .ctor() { }
}
