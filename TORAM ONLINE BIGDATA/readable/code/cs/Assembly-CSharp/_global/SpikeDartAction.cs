// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SpikeDartAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2735
{
	// Fields
	private float skillRate; // 0x120
	private float bonusSkillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int bonusFixAddDamage; // 0x12C
	private int damageCount; // 0x130
	private int slowPercent; // 0x134
	private Action addExcetraDamage; // 0x138

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x224F2A4 Offset: 0x224B2A4 VA: 0x224F2A4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x224F2AC Offset: 0x224B2AC VA: 0x224F2AC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x224F2B4 Offset: 0x224B2B4 VA: 0x224F2B4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x224F2BC Offset: 0x224B2BC VA: 0x224F2BC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x224F2C4 Offset: 0x224B2C4 VA: 0x224F2C4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x224F2CC Offset: 0x224B2CC VA: 0x224F2CC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x224F2D4 Offset: 0x224B2D4 VA: 0x224F2D4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x224F2DC Offset: 0x224B2DC VA: 0x224F2DC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x224F2E4 Offset: 0x224B2E4 VA: 0x224F2E4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x224F660 Offset: 0x224B660 VA: 0x224F660 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x224F6E4 Offset: 0x224B6E4 VA: 0x224F6E4 Slot: 80
	public override void AttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x224F738 Offset: 0x224B738 VA: 0x224F738 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x224FFA0 Offset: 0x224BFA0 VA: 0x224FFA0 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2250004 Offset: 0x224C004 VA: 0x2250004
	public void .ctor() { }
}
