// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SteelTrapAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2714
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

	// RVA: 0x22452C0 Offset: 0x22412C0 VA: 0x22452C0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22452C8 Offset: 0x22412C8 VA: 0x22452C8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22452D0 Offset: 0x22412D0 VA: 0x22452D0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22452D8 Offset: 0x22412D8 VA: 0x22452D8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22452E0 Offset: 0x22412E0 VA: 0x22452E0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22452E8 Offset: 0x22412E8 VA: 0x22452E8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22452F0 Offset: 0x22412F0 VA: 0x22452F0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22452F8 Offset: 0x22412F8 VA: 0x22452F8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2245300 Offset: 0x2241300 VA: 0x2245300 Slot: 17
	public override bool get_IsBreakable() { }

	// RVA: 0x2245308 Offset: 0x2241308 VA: 0x2245308 Slot: 18
	public override bool get_IsNotContactPlaced() { }

	// RVA: 0x2245318 Offset: 0x2241318 VA: 0x2245318 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x2245320 Offset: 0x2241320 VA: 0x2245320 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22456E4 Offset: 0x22416E4 VA: 0x22456E4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x224584C Offset: 0x224184C VA: 0x224584C Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2245924 Offset: 0x2241924 VA: 0x2245924 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2245D08 Offset: 0x2241D08 VA: 0x2245D08 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2246234 Offset: 0x2242234 VA: 0x2246234 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x224623C Offset: 0x224223C VA: 0x224623C Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x22462E4 Offset: 0x22422E4 VA: 0x22462E4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22464F8 Offset: 0x22424F8 VA: 0x22464F8 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x224655C Offset: 0x224255C VA: 0x224655C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2246658 Offset: 0x2242658 VA: 0x2246658 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2246D90 Offset: 0x2242D90 VA: 0x2246D90
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2246E04 Offset: 0x2242E04 VA: 0x2246E04
	private void <ActionStartOthers>b__34_0(bool cancel) { }
}
