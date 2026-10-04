// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrgaslashAction : PlayerAttackBase // TypeDefIndex: 2567
{
	// Fields
	private bool singleAttack; // 0x120
	private float singleAttackSkillRate; // 0x124
	private int singleAttackConstantDamage; // 0x128
	private float explosionSkillRate; // 0x12C
	private int explosionConstantDamage; // 0x130
	private int physicsResistBreaker; // 0x134
	private Transform mainTarget; // 0x138
	private float eventTime; // 0x140
	private float attackStartTargetDist; // 0x144
	private Dictionary<MobActionManagerBase, byte> targetExpList; // 0x148

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }

	// Methods

	// RVA: 0x21F7CD0 Offset: 0x21F3CD0 VA: 0x21F7CD0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21F7CD8 Offset: 0x21F3CD8 VA: 0x21F7CD8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21F7CE0 Offset: 0x21F3CE0 VA: 0x21F7CE0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21F7CE8 Offset: 0x21F3CE8 VA: 0x21F7CE8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21F7CF0 Offset: 0x21F3CF0 VA: 0x21F7CF0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21F7CF8 Offset: 0x21F3CF8 VA: 0x21F7CF8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21F7D00 Offset: 0x21F3D00 VA: 0x21F7D00 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21F7D08 Offset: 0x21F3D08 VA: 0x21F7D08 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21F7D10 Offset: 0x21F3D10 VA: 0x21F7D10 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x21F7D18 Offset: 0x21F3D18 VA: 0x21F7D18 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x21F7D20 Offset: 0x21F3D20 VA: 0x21F7D20 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21F8028 Offset: 0x21F4028 VA: 0x21F8028 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21F8604 Offset: 0x21F4604 VA: 0x21F8604 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x21F87A0 Offset: 0x21F47A0 VA: 0x21F87A0 Slot: 46
	public override void ActionSkillEventPreparation(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x21F8AF8 Offset: 0x21F4AF8 VA: 0x21F8AF8 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x21F8BBC Offset: 0x21F4BBC VA: 0x21F8BBC Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21F8BF0 Offset: 0x21F4BF0 VA: 0x21F8BF0 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x21F8C6C Offset: 0x21F4C6C VA: 0x21F8C6C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21F9398 Offset: 0x21F5398 VA: 0x21F9398
	public static bool CheckStack(PlayerActionManagerBase playerAction) { }

	// RVA: 0x21F93B4 Offset: 0x21F53B4 VA: 0x21F93B4
	public static bool CheckStack(PlayerActionManagerBase playerAction, out byte skillLevel) { }

	// RVA: 0x21F94E4 Offset: 0x21F54E4 VA: 0x21F94E4
	public static void StackAttackArea(PlayerActionManagerBase playerAction, float chargeLeftTime) { }

	// RVA: 0x21F97E0 Offset: 0x21F57E0 VA: 0x21F97E0
	public static void StackDamage(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x21F9980 Offset: 0x21F5980 VA: 0x21F9980
	public static void Damaged(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x21F9A74 Offset: 0x21F5A74 VA: 0x21F9A74 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21F9B94 Offset: 0x21F5B94 VA: 0x21F9B94
	public void .ctor() { }
}
