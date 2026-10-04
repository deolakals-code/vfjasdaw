// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StrikeBackOfSwordAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2864
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int abnormalPercent; // 0x128
	private int stunPercent; // 0x12C

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

	// RVA: 0x22A0748 Offset: 0x229C748 VA: 0x22A0748 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22A0750 Offset: 0x229C750 VA: 0x22A0750 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22A0758 Offset: 0x229C758 VA: 0x22A0758 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22A0760 Offset: 0x229C760 VA: 0x22A0760 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22A0768 Offset: 0x229C768 VA: 0x22A0768 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22A0770 Offset: 0x229C770 VA: 0x22A0770 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22A0778 Offset: 0x229C778 VA: 0x22A0778 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22A0780 Offset: 0x229C780 VA: 0x22A0780 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22A0788 Offset: 0x229C788 VA: 0x22A0788 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22A0940 Offset: 0x229C940 VA: 0x22A0940 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22A0A04 Offset: 0x229CA04 VA: 0x22A0A04 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22A0DC8 Offset: 0x229CDC8 VA: 0x22A0DC8 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22A0E2C Offset: 0x229CE2C VA: 0x22A0E2C
	public void .ctor() { }
}
