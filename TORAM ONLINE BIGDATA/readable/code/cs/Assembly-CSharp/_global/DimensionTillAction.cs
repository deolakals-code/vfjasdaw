// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class DimensionTillAction : PlayerAttackBase // TypeDefIndex: 2671
{
	// Fields
	private int skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int flashPercent; // 0x128
	private float radius; // 0x12C
	private Vector3 placePosition; // 0x130
	private MobActionManagerBase targetAction; // 0x140
	private readonly byte maxAttackCount; // 0x148
	private readonly byte splitHitCount; // 0x149
	private bool isCronosDriveBuf; // 0x14A
	private SkillLinkedTake arrowEventTake; // 0x150
	private int arrowAngle; // 0x158
	private int hitCount; // 0x15C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsExpDefFluctuate { get; }
	public bool IsCronosDriveBuf { get; }

	// Methods

	// RVA: 0x222A9AC Offset: 0x22269AC VA: 0x222A9AC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x222A9B4 Offset: 0x22269B4 VA: 0x222A9B4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x222A9BC Offset: 0x22269BC VA: 0x222A9BC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x222A9C4 Offset: 0x22269C4 VA: 0x222A9C4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x222A9CC Offset: 0x22269CC VA: 0x222A9CC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x222A9D4 Offset: 0x22269D4 VA: 0x222A9D4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x222A9DC Offset: 0x22269DC VA: 0x222A9DC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x222A9E4 Offset: 0x22269E4 VA: 0x222A9E4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x222A9EC Offset: 0x22269EC VA: 0x222A9EC Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x222A9F4 Offset: 0x22269F4 VA: 0x222A9F4
	public bool get_IsCronosDriveBuf() { }

	// RVA: 0x222A9FC Offset: 0x22269FC VA: 0x222A9FC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x222ABDC Offset: 0x2226BDC VA: 0x222ABDC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x222B054 Offset: 0x2227054 VA: 0x222B054 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x222B4B8 Offset: 0x22274B8 VA: 0x222B4B8 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x222B5A0 Offset: 0x22275A0 VA: 0x222B5A0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x222B960 Offset: 0x2227960 VA: 0x222B960 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x222BA40 Offset: 0x2227A40 VA: 0x222BA40 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x222BBAC Offset: 0x2227BAC VA: 0x222BBAC Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x222BDA0 Offset: 0x2227DA0 VA: 0x222BDA0 Slot: 50
	public override bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x222BE50 Offset: 0x2227E50 VA: 0x222BE50 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x222BEB4 Offset: 0x2227EB4 VA: 0x222BEB4
	public void .ctor() { }
}
