// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SlashReaperAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 3044
{
	// Fields
	private bool checkBlank; // 0x120
	private float[] skillRate; // 0x128
	private int[] constDamage; // 0x130
	private int magicResist; // 0x138
	private float rad; // 0x13C
	private float inRad; // 0x140
	private SlashReaperAction.STATE state; // 0x144
	private PlayerActionManagerBase playerAction; // 0x148
	private Dictionary<TakePlayer, Dictionary<Transform, float>> bladeTakeList; // 0x150
	private SkillComboType chargeComboType; // 0x158
	private int chargeComboRate; // 0x15C
	private int mp; // 0x160
	private int countCreatingBlade; // 0x164
	private TakePlayer parentTake; // 0x168
	private float lastHitTime; // 0x170
	private const float ROTATION_SECOND = 4;
	private const int MAX_BLADE_NUM = 5;
	private int countStateAtackHit; // 0x174
	private Dictionary<GameObject, SlashReaperAction.DamageLogData> damageLogList; // 0x178
	private GameObject otherPlayerTarget; // 0x180

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	protected override bool IsRangeEquipBonus { get; }
	public override bool IsNoMotionTake { get; }
	public override int BaseMp { get; }
	public override bool IsExpDefFluctuate { get; }
	protected override bool CheckBlank { get; }
	public bool IsFire { get; }
	public int BladeCount { get; }

	// Methods

	// RVA: 0x23114B0 Offset: 0x230D4B0 VA: 0x23114B0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23114B8 Offset: 0x230D4B8 VA: 0x23114B8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23114C0 Offset: 0x230D4C0 VA: 0x23114C0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23114C8 Offset: 0x230D4C8 VA: 0x23114C8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23114D0 Offset: 0x230D4D0 VA: 0x23114D0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23114D8 Offset: 0x230D4D8 VA: 0x23114D8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23114E0 Offset: 0x230D4E0 VA: 0x23114E0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23114E8 Offset: 0x230D4E8 VA: 0x23114E8 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x23114F0 Offset: 0x230D4F0 VA: 0x23114F0 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x2311550 Offset: 0x230D550 VA: 0x2311550 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2311558 Offset: 0x230D558 VA: 0x2311558 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x2311568 Offset: 0x230D568 VA: 0x2311568 Slot: 73
	protected override bool get_CheckBlank() { }

	// RVA: 0x2311570 Offset: 0x230D570 VA: 0x2311570
	public bool get_IsFire() { }

	// RVA: 0x2311584 Offset: 0x230D584 VA: 0x2311584
	public int get_BladeCount() { }

	// RVA: 0x23115D4 Offset: 0x230D5D4 VA: 0x23115D4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2311B00 Offset: 0x230DB00 VA: 0x2311B00
	public void UpdateBradeNum(int num) { }

	// RVA: 0x2311C90 Offset: 0x230DC90 VA: 0x2311C90
	private void RemoveBrade(int count) { }

	// RVA: 0x2312024 Offset: 0x230E024 VA: 0x2312024
	private void UpdateBladePosition() { }

	// RVA: 0x2311BA0 Offset: 0x230DBA0 VA: 0x2311BA0
	private void AddBlade(int count) { }

	// RVA: 0x231232C Offset: 0x230E32C VA: 0x231232C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2312604 Offset: 0x230E604 VA: 0x2312604 Slot: 42
	public override void SetTargetMobOthers(GameObject target) { }

	// RVA: 0x2312634 Offset: 0x230E634 VA: 0x2312634 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x2312674 Offset: 0x230E674 VA: 0x2312674 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x231267C Offset: 0x230E67C VA: 0x231267C
	public void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target, bool isFireTake) { }

	// RVA: 0x23123B8 Offset: 0x230E3B8 VA: 0x23123B8
	private void CreateTake(bool isFireTake) { }

	// RVA: 0x23127DC Offset: 0x230E7DC VA: 0x23127DC Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2312BA0 Offset: 0x230EBA0 VA: 0x2312BA0 Slot: 78
	public override int CorrectComboRate() { }

	// RVA: 0x2312BAC Offset: 0x230EBAC VA: 0x2312BAC Slot: 79
	public override bool CheckComboAccept(SkillComboType comboType) { }

	// RVA: 0x2312BC8 Offset: 0x230EBC8 VA: 0x2312BC8 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2313018 Offset: 0x230F018 VA: 0x2313018
	private bool CheckRange(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23131DC Offset: 0x230F1DC VA: 0x23131DC Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2313258 Offset: 0x230F258 VA: 0x2313258 Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x231344C Offset: 0x230F44C VA: 0x231344C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x231398C Offset: 0x230F98C VA: 0x231398C
	public void OnSkillButton(GameObject target) { }

	// RVA: 0x2314324 Offset: 0x2310324 VA: 0x2314324 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x231434C Offset: 0x231034C VA: 0x231434C Slot: 50
	public override bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23145F4 Offset: 0x23105F4 VA: 0x23145F4 Slot: 53
	protected override void OnEnd(bool cancel) { }

	// RVA: 0x2314900 Offset: 0x2310900 VA: 0x2314900
	internal void RotationEvent(int uid) { }

	// RVA: 0x2314D20 Offset: 0x2310D20 VA: 0x2314D20
	internal void AddDamageData(SkillHitType hitType, GameObject target, int damage) { }

	// RVA: 0x2313C88 Offset: 0x230FC88 VA: 0x2313C88
	private void PushDamageLog(bool isConditionCheck) { }

	// RVA: 0x23130F8 Offset: 0x230F0F8 VA: 0x23130F8
	private void PushDamageLog(GameObject target) { }

	// RVA: 0x2314F00 Offset: 0x2310F00 VA: 0x2314F00
	public bool CheckExpDefFluctuate() { }

	// RVA: 0x2314F10 Offset: 0x2310F10 VA: 0x2314F10
	public void .ctor() { }
}
