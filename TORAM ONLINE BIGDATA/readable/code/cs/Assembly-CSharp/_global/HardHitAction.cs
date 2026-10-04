// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HardHitAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2561
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int flinchPercent; // 0x128

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

	// RVA: 0x21F46F0 Offset: 0x21F06F0 VA: 0x21F46F0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21F46F8 Offset: 0x21F06F8 VA: 0x21F46F8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21F4700 Offset: 0x21F0700 VA: 0x21F4700 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21F4708 Offset: 0x21F0708 VA: 0x21F4708 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21F4710 Offset: 0x21F0710 VA: 0x21F4710 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21F4718 Offset: 0x21F0718 VA: 0x21F4718 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21F4720 Offset: 0x21F0720 VA: 0x21F4720 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21F4728 Offset: 0x21F0728 VA: 0x21F4728 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21F4730 Offset: 0x21F0730 VA: 0x21F4730 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21F4988 Offset: 0x21F0988 VA: 0x21F4988 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21F4A50 Offset: 0x21F0A50 VA: 0x21F4A50 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21F4B18 Offset: 0x21F0B18 VA: 0x21F4B18 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21F4E28 Offset: 0x21F0E28 VA: 0x21F4E28 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x21F4E8C Offset: 0x21F0E8C VA: 0x21F4E8C
	public void .ctor() { }
}
