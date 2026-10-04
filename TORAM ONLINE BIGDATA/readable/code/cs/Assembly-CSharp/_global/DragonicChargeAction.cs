// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class DragonicChargeAction : PlayerAttackBase // TypeDefIndex: 2676
{
	// Fields
	private bool isFirst; // 0x120
	private bool isFirstAtkHit; // 0x121
	private float targetSkillRate; // 0x124
	private int targetFixDamage; // 0x128
	private float rangeSkillRate; // 0x12C
	private int rangeFixDamage; // 0x130
	private float chargeValue; // 0x134
	private GameObject target; // 0x138
	private float rangeRad; // 0x140
	private const float rangeAngle = 60;
	private AbnormalType abnormalType; // 0x144
	private int abnormalPercent; // 0x148
	private bool chargeSkip; // 0x14C
	private int powerRegist; // 0x150
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x158
	private readonly Dictionary<ElementType, AbnormalType> selectAbnormalType; // 0x160

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x222D680 Offset: 0x2229680 VA: 0x222D680 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x222D688 Offset: 0x2229688 VA: 0x222D688 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x222D690 Offset: 0x2229690 VA: 0x222D690 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x222D698 Offset: 0x2229698 VA: 0x222D698 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x222D6A0 Offset: 0x22296A0 VA: 0x222D6A0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x222D6A8 Offset: 0x22296A8 VA: 0x222D6A8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x222D6B0 Offset: 0x22296B0 VA: 0x222D6B0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x222D6B8 Offset: 0x22296B8 VA: 0x222D6B8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x222D6C0 Offset: 0x22296C0 VA: 0x222D6C0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x222D86C Offset: 0x222986C VA: 0x222D86C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x222D990 Offset: 0x2229990 VA: 0x222D990 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x222D9B8 Offset: 0x22299B8 VA: 0x222D9B8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x222DE04 Offset: 0x2229E04 VA: 0x222DE04 Slot: 42
	public override void SetTargetMobOthers(GameObject target) { }

	// RVA: 0x222DE14 Offset: 0x2229E14 VA: 0x222DE14
	public void OnSkillButton() { }

	// RVA: 0x222DE20 Offset: 0x2229E20 VA: 0x222DE20 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x222E1B4 Offset: 0x222A1B4 VA: 0x222E1B4 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x222EE60 Offset: 0x222AE60 VA: 0x222EE60 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x222EF08 Offset: 0x222AF08 VA: 0x222EF08
	public void GuardCancelSkillEvent(GameObject actor) { }

	// RVA: 0x222EF94 Offset: 0x222AF94 VA: 0x222EF94 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x222F86C Offset: 0x222B86C VA: 0x222F86C Slot: 86
	protected override int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x222FBE4 Offset: 0x222BBE4 VA: 0x222FBE4 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x222FE6C Offset: 0x222BE6C VA: 0x222FE6C Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x222FED8 Offset: 0x222BED8 VA: 0x222FED8 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x222ED10 Offset: 0x222AD10 VA: 0x222ED10
	private Vector3 GetWallPushOutPos(RaycastHit ray, Vector3 moveDir) { }

	// RVA: 0x222FF40 Offset: 0x222BF40 VA: 0x222FF40
	public void .ctor() { }
}
