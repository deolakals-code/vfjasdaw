// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MeteorStrikeAction : PlayerAttackBase, IHighFamiliaAttackSkill, IAbnormalStateSkill // TypeDefIndex: 3058
{
	// Fields
	private bool hideAttackApplied; // 0x120
	private GameObject target; // 0x128
	private const int MaxAttackCount = 3;
	private float skillRate; // 0x130
	private int fixAddDamage; // 0x134
	private int ignitionPercent; // 0x138
	private int dizzyPercent; // 0x13C
	private float[] fallRad; // 0x140
	private int[] lukCorrection; // 0x148
	private float attackRange; // 0x150
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x158
	private Vector3 targetPos; // 0x160
	private Vector3[] effectPos; // 0x170
	private int nowAttackCount; // 0x178
	private Random rand; // 0x180
	private int luk; // 0x188
	private bool isSingleShot; // 0x18C

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
	public override bool IsHideAttackApplied { get; }
	public bool IsFailureSkill { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }

	// Methods

	// RVA: 0x231A7B0 Offset: 0x23167B0 VA: 0x231A7B0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x231A7B8 Offset: 0x23167B8 VA: 0x231A7B8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x231A7DC Offset: 0x23167DC VA: 0x231A7DC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x231A7E4 Offset: 0x23167E4 VA: 0x231A7E4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x231A7EC Offset: 0x23167EC VA: 0x231A7EC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x231A7F4 Offset: 0x23167F4 VA: 0x231A7F4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x231A7FC Offset: 0x23167FC VA: 0x231A7FC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x231A804 Offset: 0x2316804 VA: 0x231A804 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x231A80C Offset: 0x231680C VA: 0x231A80C Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x231A82C Offset: 0x231682C VA: 0x231A82C Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x231A860 Offset: 0x2316860 VA: 0x231A860 Slot: 92
	public bool get_IsFailureSkill() { }

	// RVA: 0x231A890 Offset: 0x2316890 VA: 0x231A890 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x231A898 Offset: 0x2316898 VA: 0x231A898 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x231A8A0 Offset: 0x23168A0 VA: 0x231A8A0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x231ABD8 Offset: 0x2316BD8 VA: 0x231ABD8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x231AC88 Offset: 0x2316C88 VA: 0x231AC88 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x231AC8C Offset: 0x2316C8C VA: 0x231AC8C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x231AE28 Offset: 0x2316E28 VA: 0x231AE28 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x231B440 Offset: 0x2317440 VA: 0x231B440 Slot: 53
	protected override void OnEnd(bool cancel) { }

	// RVA: 0x231B44C Offset: 0x231744C VA: 0x231B44C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x231B524 Offset: 0x2317524 VA: 0x231B524 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x231B65C Offset: 0x231765C VA: 0x231B65C Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x231B6D0 Offset: 0x23176D0 VA: 0x231B6D0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x231BE68 Offset: 0x2317E68 VA: 0x231BE68 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x231BF00 Offset: 0x2317F00 VA: 0x231BF00 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x231AF78 Offset: 0x2316F78 VA: 0x231AF78
	private SkillLinkedTake CreateTake(Vector3 targetPos) { }

	// RVA: 0x231BF64 Offset: 0x2317F64 VA: 0x231BF64 Slot: 91
	public void InitializeHighFamilia(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x231BD70 Offset: 0x2317D70 VA: 0x231BD70
	private void SkillBufValid(PlayerActionManagerBase playerAction) { }

	// RVA: 0x231BC78 Offset: 0x2317C78 VA: 0x231BC78
	private void SkillBufInvalid(PlayerActionManagerBase playerAction) { }

	// RVA: 0x231C104 Offset: 0x2318104 VA: 0x231C104
	public void SetHideAttack(bool active) { }

	// RVA: 0x231C110 Offset: 0x2318110 VA: 0x231C110
	public void .ctor() { }
}
