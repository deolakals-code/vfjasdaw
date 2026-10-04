// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class IgnitionAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 3035
{
	// Fields
	private float skillRate; // 0x120
	private const float STABLE_RATE = 0.6;
	private const int CONSTANT_DAMAGE = 100;
	private int abnomalParcent; // 0x124
	private PlayerActionManagerBase playerAction; // 0x128

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x230D818 Offset: 0x2309818 VA: 0x230D818 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x230D820 Offset: 0x2309820 VA: 0x230D820 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x230D828 Offset: 0x2309828 VA: 0x230D828 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x230D830 Offset: 0x2309830 VA: 0x230D830 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x230D838 Offset: 0x2309838 VA: 0x230D838 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x230D840 Offset: 0x2309840 VA: 0x230D840 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x230D848 Offset: 0x2309848 VA: 0x230D848 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x230D850 Offset: 0x2309850 VA: 0x230D850 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x230D858 Offset: 0x2309858 VA: 0x230D858 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x230DC2C Offset: 0x2309C2C VA: 0x230DC2C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x230DD5C Offset: 0x2309D5C VA: 0x230DD5C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x230E16C Offset: 0x230A16C VA: 0x230E16C Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x230E1D0 Offset: 0x230A1D0 VA: 0x230E1D0
	public void .ctor() { }
}
