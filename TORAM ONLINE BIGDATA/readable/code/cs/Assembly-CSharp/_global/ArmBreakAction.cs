// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ArmBreakAction : PlayerAttackBase, IAbnormalStateSkill, IDualElementSkill // TypeDefIndex: 2968
{
	// Fields
	[CompilerGenerated]
	private bool <IsValidDualElement>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private float bonusSkillRate; // 0x128
	private int fixAddDamage; // 0x12C
	private int abnormalPercent; // 0x130

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

	// RVA: 0x22EB6DC Offset: 0x22E76DC VA: 0x22EB6DC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22EB6E4 Offset: 0x22E76E4 VA: 0x22EB6E4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22EB6EC Offset: 0x22E76EC VA: 0x22EB6EC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22EB6F4 Offset: 0x22E76F4 VA: 0x22EB6F4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22EB6FC Offset: 0x22E76FC VA: 0x22EB6FC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22EB704 Offset: 0x22E7704 VA: 0x22EB704 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22EB70C Offset: 0x22E770C VA: 0x22EB70C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22EB714 Offset: 0x22E7714 VA: 0x22EB714 Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x22EB71C Offset: 0x22E771C VA: 0x22EB71C Slot: 92
	public bool get_IsValidDualElement() { }

	[CompilerGenerated]
	// RVA: 0x22EB724 Offset: 0x22E7724 VA: 0x22EB724
	private void set_IsValidDualElement(bool value) { }

	// RVA: 0x22EB730 Offset: 0x22E7730 VA: 0x22EB730 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22EB9E4 Offset: 0x22E79E4 VA: 0x22EB9E4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22EBBAC Offset: 0x22E7BAC VA: 0x22EBBAC Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22EBFC0 Offset: 0x22E7FC0 VA: 0x22EBFC0 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22EC024 Offset: 0x22E8024 VA: 0x22EC024
	public void .ctor() { }
}
