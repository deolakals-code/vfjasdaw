// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ExplossiveAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2701
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

	// RVA: 0x223B004 Offset: 0x2237004 VA: 0x223B004 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x223B00C Offset: 0x223700C VA: 0x223B00C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x223B014 Offset: 0x2237014 VA: 0x223B014 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x223B01C Offset: 0x223701C VA: 0x223B01C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x223B024 Offset: 0x2237024 VA: 0x223B024 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x223B02C Offset: 0x223702C VA: 0x223B02C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x223B034 Offset: 0x2237034 VA: 0x223B034 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x223B03C Offset: 0x223703C VA: 0x223B03C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x223B044 Offset: 0x2237044 VA: 0x223B044 Slot: 17
	public override bool get_IsBreakable() { }

	// RVA: 0x223B04C Offset: 0x223704C VA: 0x223B04C Slot: 18
	public override bool get_IsNotContactPlaced() { }

	// RVA: 0x223B05C Offset: 0x223705C VA: 0x223B05C Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x223B064 Offset: 0x2237064 VA: 0x223B064 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x223B4B8 Offset: 0x22374B8 VA: 0x223B4B8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x223B620 Offset: 0x2237620 VA: 0x223B620 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x223B6F8 Offset: 0x22376F8 VA: 0x223B6F8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x223BADC Offset: 0x2237ADC VA: 0x223BADC Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x223C008 Offset: 0x2238008 VA: 0x223C008 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x223C010 Offset: 0x2238010 VA: 0x223C010 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x223C0B8 Offset: 0x22380B8 VA: 0x223C0B8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x223C2DC Offset: 0x22382DC VA: 0x223C2DC Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x223C340 Offset: 0x2238340 VA: 0x223C340 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x223C43C Offset: 0x223843C VA: 0x223C43C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x223CB74 Offset: 0x2238B74 VA: 0x223CB74
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x223CBE0 Offset: 0x2238BE0 VA: 0x223CBE0
	private void <ActionStartOthers>b__34_0(bool cancel) { }
}
