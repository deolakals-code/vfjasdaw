// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlankTrapAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2697
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

	// RVA: 0x22384C4 Offset: 0x22344C4 VA: 0x22384C4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22384CC Offset: 0x22344CC VA: 0x22384CC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22384D4 Offset: 0x22344D4 VA: 0x22384D4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22384DC Offset: 0x22344DC VA: 0x22384DC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22384E4 Offset: 0x22344E4 VA: 0x22384E4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22384EC Offset: 0x22344EC VA: 0x22384EC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22384F4 Offset: 0x22344F4 VA: 0x22384F4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22384FC Offset: 0x22344FC VA: 0x22384FC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2238504 Offset: 0x2234504 VA: 0x2238504 Slot: 17
	public override bool get_IsBreakable() { }

	// RVA: 0x223850C Offset: 0x223450C VA: 0x223850C Slot: 18
	public override bool get_IsNotContactPlaced() { }

	// RVA: 0x223851C Offset: 0x223451C VA: 0x223851C Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x2238524 Offset: 0x2234524 VA: 0x2238524 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x223887C Offset: 0x223487C VA: 0x223887C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22389E4 Offset: 0x22349E4 VA: 0x22389E4 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2238ABC Offset: 0x2234ABC VA: 0x2238ABC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2238EA0 Offset: 0x2234EA0 VA: 0x2238EA0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22393CC Offset: 0x22353CC VA: 0x22393CC Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22393D4 Offset: 0x22353D4 VA: 0x22393D4 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x223947C Offset: 0x223547C VA: 0x223947C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2239690 Offset: 0x2235690 VA: 0x2239690 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22396F4 Offset: 0x22356F4 VA: 0x22396F4 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22397F0 Offset: 0x22357F0 VA: 0x22397F0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2239F20 Offset: 0x2235F20 VA: 0x2239F20
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2239F30 Offset: 0x2235F30 VA: 0x2239F30
	private void <ActionStartOthers>b__34_0(bool cancel) { }
}
