// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AssaultAttackAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2742
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int slowRate; // 0x128
	private int knockbackRate; // 0x12C

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

	// RVA: 0x2252184 Offset: 0x224E184 VA: 0x2252184 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x225218C Offset: 0x224E18C VA: 0x225218C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2252194 Offset: 0x224E194 VA: 0x2252194 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x225219C Offset: 0x224E19C VA: 0x225219C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22521A4 Offset: 0x224E1A4 VA: 0x22521A4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22521AC Offset: 0x224E1AC VA: 0x22521AC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22521B4 Offset: 0x224E1B4 VA: 0x22521B4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22521BC Offset: 0x224E1BC VA: 0x22521BC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22521C4 Offset: 0x224E1C4 VA: 0x22521C4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22523D4 Offset: 0x224E3D4 VA: 0x22523D4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x225249C Offset: 0x224E49C VA: 0x225249C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2252670 Offset: 0x224E670 VA: 0x2252670 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2252AD4 Offset: 0x224EAD4 VA: 0x2252AD4 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2252B38 Offset: 0x224EB38 VA: 0x2252B38
	public void .ctor() { }
}
