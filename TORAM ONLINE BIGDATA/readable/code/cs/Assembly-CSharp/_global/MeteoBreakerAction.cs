// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MeteoBreakerAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2563
{
	// Fields
	private float targetSkillRate; // 0x120
	private int targetFixAddDamage; // 0x124
	private float rangeSkillRate; // 0x128
	private float range; // 0x12C
	private int abnormalPercent; // 0x130
	private int targetExpRegister; // 0x134
	private CharacterActionManagerBase targetAction; // 0x138
	private bool isFirstAttack; // 0x140
	private Vector3 placePos; // 0x144
	private byte invincibilityLocalId; // 0x150

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }

	// Methods

	// RVA: 0x21F4EA4 Offset: 0x21F0EA4 VA: 0x21F4EA4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21F4EAC Offset: 0x21F0EAC VA: 0x21F4EAC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21F4EB4 Offset: 0x21F0EB4 VA: 0x21F4EB4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21F4EBC Offset: 0x21F0EBC VA: 0x21F4EBC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21F4EC4 Offset: 0x21F0EC4 VA: 0x21F4EC4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21F4ECC Offset: 0x21F0ECC VA: 0x21F4ECC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21F4ED4 Offset: 0x21F0ED4 VA: 0x21F4ED4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21F4EDC Offset: 0x21F0EDC VA: 0x21F4EDC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21F4EE4 Offset: 0x21F0EE4 VA: 0x21F4EE4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21F5258 Offset: 0x21F1258 VA: 0x21F5258 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21F54D8 Offset: 0x21F14D8 VA: 0x21F54D8 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x21F5544 Offset: 0x21F1544 VA: 0x21F5544 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x21F56A4 Offset: 0x21F16A4 VA: 0x21F56A4 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x21F57B0 Offset: 0x21F17B0 VA: 0x21F57B0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21F5878 Offset: 0x21F1878 VA: 0x21F5878 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21F5D5C Offset: 0x21F1D5C VA: 0x21F5D5C Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x21F5DC0 Offset: 0x21F1DC0 VA: 0x21F5DC0
	public void .ctor() { }
}
