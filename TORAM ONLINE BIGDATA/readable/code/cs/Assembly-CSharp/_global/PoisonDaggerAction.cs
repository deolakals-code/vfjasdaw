// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PoisonDaggerAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2733
{
	// Fields
	private float skillRate; // 0x120
	private float bonusSkillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int bonusFixAddDamage; // 0x12C
	private int poisonPercent; // 0x130
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

	// RVA: 0x224E714 Offset: 0x224A714 VA: 0x224E714 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x224E71C Offset: 0x224A71C VA: 0x224E71C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x224E724 Offset: 0x224A724 VA: 0x224E724 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x224E72C Offset: 0x224A72C VA: 0x224E72C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x224E734 Offset: 0x224A734 VA: 0x224E734 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x224E73C Offset: 0x224A73C VA: 0x224E73C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x224E744 Offset: 0x224A744 VA: 0x224E744 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x224E74C Offset: 0x224A74C VA: 0x224E74C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x224E754 Offset: 0x224A754 VA: 0x224E754 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x224EAB0 Offset: 0x224AAB0 VA: 0x224EAB0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x224EB78 Offset: 0x224AB78 VA: 0x224EB78 Slot: 80
	public override void AttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x224EBCC Offset: 0x224ABCC VA: 0x224EBCC Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x224F1F4 Offset: 0x224B1F4 VA: 0x224F1F4 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x224F258 Offset: 0x224B258 VA: 0x224F258
	public void .ctor() { }
}
