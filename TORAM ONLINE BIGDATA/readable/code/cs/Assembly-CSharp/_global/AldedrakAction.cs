// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class AldedrakAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 3020
{
	// Fields
	private float skillRate; // 0x120
	private const int CONSTANT_DAMAGE = 300;
	private const float RANGE = 1.5;
	private const float ABNORMAL_HIT_RANGE = 0.5;
	private float rad; // 0x124
	private PlayerActionManagerBase playerAction; // 0x128
	private AldedrakAction.STATE state; // 0x130
	private bool isMoveEnd; // 0x134
	private List<GameObject> CriticalTargetList; // 0x138
	private List<GameObject> hitObjectList; // 0x140

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	protected override bool IsRangeEquipBonus { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x2304EC4 Offset: 0x2300EC4 VA: 0x2304EC4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2304ECC Offset: 0x2300ECC VA: 0x2304ECC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2304ED4 Offset: 0x2300ED4 VA: 0x2304ED4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2304EDC Offset: 0x2300EDC VA: 0x2304EDC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2304EE4 Offset: 0x2300EE4 VA: 0x2304EE4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2304EEC Offset: 0x2300EEC VA: 0x2304EEC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2304EF4 Offset: 0x2300EF4 VA: 0x2304EF4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2304EFC Offset: 0x2300EFC VA: 0x2304EFC Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x2304F04 Offset: 0x2300F04 VA: 0x2304F04 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2304F0C Offset: 0x2300F0C VA: 0x2304F0C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2305208 Offset: 0x2301208 VA: 0x2305208 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2305360 Offset: 0x2301360 VA: 0x2305360 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2305808 Offset: 0x2301808 VA: 0x2305808 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x230587C Offset: 0x230187C VA: 0x230587C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2305AC0 Offset: 0x2301AC0 VA: 0x2305AC0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2305AD8 Offset: 0x2301AD8 VA: 0x2305AD8
	private void SetLaunch() { }

	// RVA: 0x2305D54 Offset: 0x2301D54 VA: 0x2305D54 Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x2305D5C Offset: 0x2301D5C VA: 0x2305D5C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23061D8 Offset: 0x23021D8 VA: 0x23061D8 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2306248 Offset: 0x2302248 VA: 0x2306248 Slot: 50
	public override bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23062F0 Offset: 0x23022F0 VA: 0x23062F0
	public void CreateListCriticalTarget() { }

	// RVA: 0x230688C Offset: 0x230288C VA: 0x230688C
	public void .ctor() { }
}
