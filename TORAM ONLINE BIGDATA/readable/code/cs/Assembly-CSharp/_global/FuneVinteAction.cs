// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FuneVinteAction : PlayerAttackBase // TypeDefIndex: 2537
{
	// Fields
	private int mp; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private Vector3 moveDir; // 0x12C
	private bool targetDeadlyPoison; // 0x138

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsOverMp { get; }
	public override bool NoCost { get; }
	public override bool IsEventIgnoreOther { get; }

	// Methods

	// RVA: 0x21E6864 Offset: 0x21E2864 VA: 0x21E6864 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21E686C Offset: 0x21E286C VA: 0x21E686C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21E6874 Offset: 0x21E2874 VA: 0x21E6874 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21E687C Offset: 0x21E287C VA: 0x21E687C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21E6884 Offset: 0x21E2884 VA: 0x21E6884 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21E688C Offset: 0x21E288C VA: 0x21E688C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21E6894 Offset: 0x21E2894 VA: 0x21E6894 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21E689C Offset: 0x21E289C VA: 0x21E689C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21E68A4 Offset: 0x21E28A4 VA: 0x21E68A4 Slot: 24
	public override bool get_IsOverMp() { }

	// RVA: 0x21E68AC Offset: 0x21E28AC VA: 0x21E68AC Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x21E68B4 Offset: 0x21E28B4 VA: 0x21E68B4 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x21E68BC Offset: 0x21E28BC VA: 0x21E68BC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21E6AA4 Offset: 0x21E2AA4 VA: 0x21E6AA4 Slot: 76
	public override void SetComboType(SkillComboType comboType) { }

	// RVA: 0x21E6AD8 Offset: 0x21E2AD8 VA: 0x21E6AD8 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21E6D70 Offset: 0x21E2D70 VA: 0x21E6D70 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21E7318 Offset: 0x21E3318 VA: 0x21E7318 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x21E7568 Offset: 0x21E3568 VA: 0x21E7568 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21E78C4 Offset: 0x21E38C4 VA: 0x21E78C4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21E7B60 Offset: 0x21E3B60 VA: 0x21E7B60 Slot: 84
	public override void RecalcCostMp(PlayerActionManagerBase playerAction) { }

	// RVA: 0x21E7CC0 Offset: 0x21E3CC0 VA: 0x21E7CC0
	public void .ctor() { }
}
