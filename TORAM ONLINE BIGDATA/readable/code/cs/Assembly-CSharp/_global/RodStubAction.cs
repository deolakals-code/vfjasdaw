// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RodStubAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2959
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int percent; // 0x128
	private int resist; // 0x12C

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

	// RVA: 0x22E7380 Offset: 0x22E3380 VA: 0x22E7380 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22E7388 Offset: 0x22E3388 VA: 0x22E7388 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22E7390 Offset: 0x22E3390 VA: 0x22E7390 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22E7398 Offset: 0x22E3398 VA: 0x22E7398 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22E73A0 Offset: 0x22E33A0 VA: 0x22E73A0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22E73A8 Offset: 0x22E33A8 VA: 0x22E73A8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22E73B0 Offset: 0x22E33B0 VA: 0x22E73B0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22E73B8 Offset: 0x22E33B8 VA: 0x22E73B8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22E73C0 Offset: 0x22E33C0 VA: 0x22E73C0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22E765C Offset: 0x22E365C VA: 0x22E765C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22E7720 Offset: 0x22E3720 VA: 0x22E7720 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E7A58 Offset: 0x22E3A58 VA: 0x22E7A58 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22E7D5C Offset: 0x22E3D5C VA: 0x22E7D5C Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22E7980 Offset: 0x22E3980 VA: 0x22E7980
	private bool RangeAttackCheck(CharacterActionManagerBase actor, CharacterActionManagerBase target, ItemData weapon) { }

	// RVA: 0x22E7DC0 Offset: 0x22E3DC0 VA: 0x22E7DC0
	public void .ctor() { }
}
