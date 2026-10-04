// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ThieshankaiAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2816
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int stunPercent; // 0x128

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsMove { get; }

	// Methods

	// RVA: 0x22882E0 Offset: 0x22842E0 VA: 0x22882E0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22882E8 Offset: 0x22842E8 VA: 0x22882E8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22882F0 Offset: 0x22842F0 VA: 0x22882F0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22882F8 Offset: 0x22842F8 VA: 0x22882F8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2288300 Offset: 0x2284300 VA: 0x2288300 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2288308 Offset: 0x2284308 VA: 0x2288308 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2288310 Offset: 0x2284310 VA: 0x2288310 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2288318 Offset: 0x2284318 VA: 0x2288318 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2288320 Offset: 0x2284320 VA: 0x2288320 Slot: 28
	public override bool get_IsMove() { }

	// RVA: 0x2288328 Offset: 0x2284328 VA: 0x2288328 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2288664 Offset: 0x2284664 VA: 0x2288664 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22886E8 Offset: 0x22846E8 VA: 0x22886E8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22887B0 Offset: 0x22847B0 VA: 0x22887B0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2288A80 Offset: 0x2284A80 VA: 0x2288A80 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2288AE4 Offset: 0x2284AE4 VA: 0x2288AE4
	public bool OnFailedAddAbnormalState(MobActionManagerBase mobActionManager, GameObject actor, AbnormalType type) { }

	// RVA: 0x2288DBC Offset: 0x2284DBC VA: 0x2288DBC
	public void .ctor() { }
}
