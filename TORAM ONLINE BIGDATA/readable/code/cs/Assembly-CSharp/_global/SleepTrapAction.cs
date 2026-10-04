// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SleepTrapAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2711
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int abnormalPercent; // 0x128
	private Vector3 placePosition; // 0x12C
	private float rad; // 0x138
	private CharacterMove charaMove; // 0x140
	private bool setEffect; // 0x148
	private bool failTrapper; // 0x149
	private bool fastHit; // 0x14A
	private bool selfDamage; // 0x14B

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsBreakable { get; }
	public override bool IsNotContactPlaced { get; }
	public override bool IsEventIgnoreOther { get; }

	// Methods

	// RVA: 0x2243468 Offset: 0x223F468 VA: 0x2243468 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2243470 Offset: 0x223F470 VA: 0x2243470 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2243478 Offset: 0x223F478 VA: 0x2243478 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2243480 Offset: 0x223F480 VA: 0x2243480 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2243488 Offset: 0x223F488 VA: 0x2243488 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2243490 Offset: 0x223F490 VA: 0x2243490 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2243498 Offset: 0x223F498 VA: 0x2243498 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22434A0 Offset: 0x223F4A0 VA: 0x22434A0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22434A8 Offset: 0x223F4A8 VA: 0x22434A8 Slot: 17
	public override bool get_IsBreakable() { }

	// RVA: 0x22434B0 Offset: 0x223F4B0 VA: 0x22434B0 Slot: 18
	public override bool get_IsNotContactPlaced() { }

	// RVA: 0x22434C0 Offset: 0x223F4C0 VA: 0x22434C0 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x22434C8 Offset: 0x223F4C8 VA: 0x22434C8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x224388C Offset: 0x223F88C VA: 0x224388C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22439F4 Offset: 0x223F9F4 VA: 0x22439F4 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2243ACC Offset: 0x223FACC VA: 0x2243ACC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2243EB0 Offset: 0x223FEB0 VA: 0x2243EB0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22443DC Offset: 0x22403DC VA: 0x22443DC Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22443E4 Offset: 0x22403E4 VA: 0x22443E4 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x224448C Offset: 0x224048C VA: 0x224448C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2244740 Offset: 0x2240740 VA: 0x2244740 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22447A4 Offset: 0x22407A4 VA: 0x22447A4 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22448A0 Offset: 0x22408A0 VA: 0x22448A0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2244F84 Offset: 0x2240F84 VA: 0x2244F84
	public void AddSelfAbnormal(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2245138 Offset: 0x2241138 VA: 0x2245138
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x22451AC Offset: 0x22411AC VA: 0x22451AC
	private void <ActionStartOthers>b__35_0(bool cancel) { }
}
