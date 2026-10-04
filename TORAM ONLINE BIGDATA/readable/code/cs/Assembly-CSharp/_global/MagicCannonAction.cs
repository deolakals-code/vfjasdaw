// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicCannonAction : PlayerAttackBase, IChronosShift // TypeDefIndex: 2774
{
	// Fields
	private float baseSkillRate; // 0x120
	private float[] skillRate; // 0x128
	private int fixAddDamage; // 0x130
	private int guardIgnorePercent; // 0x134
	private int mp; // 0x138
	private float width; // 0x13C
	private Dictionary<MobActionManagerBase, SkillActionBase.DamageData> targetDamageDataList; // 0x140
	private Dictionary<MobActionManagerBase, List<SkillCalcTemplate>> targetTemplateLest; // 0x148
	private SkillComboType chargeComboType; // 0x150
	private int chargeComboRate; // 0x154
	private Vector3 attackPos; // 0x158
	private Vector3 attackDir; // 0x164
	private MagicCannonAction lastUsedSkill; // 0x170
	private GameObject effect; // 0x178
	private bool isRotationTarget; // 0x180
	private int attackCount; // 0x184
	private bool enchantedBurstStack; // 0x188

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x2264E54 Offset: 0x2260E54 VA: 0x2264E54 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2264E5C Offset: 0x2260E5C VA: 0x2264E5C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2264E64 Offset: 0x2260E64 VA: 0x2264E64 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2264E6C Offset: 0x2260E6C VA: 0x2264E6C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2264E74 Offset: 0x2260E74 VA: 0x2264E74 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2264E7C Offset: 0x2260E7C VA: 0x2264E7C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2264E84 Offset: 0x2260E84 VA: 0x2264E84 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2264E8C Offset: 0x2260E8C VA: 0x2264E8C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2264E94 Offset: 0x2260E94 VA: 0x2264E94 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x226511C Offset: 0x226111C VA: 0x226511C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22652D4 Offset: 0x22612D4 VA: 0x22652D4 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22653F4 Offset: 0x22613F4 VA: 0x22653F4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2265B98 Offset: 0x2261B98 VA: 0x2265B98 Slot: 78
	public override int CorrectComboRate() { }

	// RVA: 0x2265BA4 Offset: 0x2261BA4 VA: 0x2265BA4 Slot: 79
	public override bool CheckComboAccept(SkillComboType comboType) { }

	// RVA: 0x2265BC0 Offset: 0x2261BC0 VA: 0x2265BC0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2265BF0 Offset: 0x2261BF0 VA: 0x2265BF0 Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x2265C00 Offset: 0x2261C00 VA: 0x2265C00 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2265D74 Offset: 0x2261D74 VA: 0x2265D74 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2265F20 Offset: 0x2261F20 VA: 0x2265F20 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2265FA0 Offset: 0x2261FA0 VA: 0x2265FA0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2266600 Offset: 0x2262600 VA: 0x2266600
	public void RotationTarget(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2266810 Offset: 0x2262810 VA: 0x2266810 Slot: 91
	public void UseChronosShift(SkillActionBase lastUsedSkill) { }

	// RVA: 0x2265AA8 Offset: 0x2261AA8 VA: 0x2265AA8 Slot: 92
	public void InitializeChronosShift(CharacterActionManagerBase actorAction) { }

	// RVA: 0x22668D0 Offset: 0x22628D0 VA: 0x22668D0
	public void .ctor() { }
}
