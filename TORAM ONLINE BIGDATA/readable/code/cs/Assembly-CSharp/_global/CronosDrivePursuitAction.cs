// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CronosDrivePursuitAction : PlayerAttackBase // TypeDefIndex: 1489
{
	// Fields
	[CompilerGenerated]
	private bool <IsMagicAttack>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private SkillCalcTemplate baseHitReaction; // 0x130
	private float damageIntarval; // 0x138
	private CharacterActionManagerBase targetActionManager; // 0x140
	private bool isGuard; // 0x148
	private int leftTime; // 0x14C

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsHideAttackApplied { get; }
	public override bool IsEventIgnoreOther { get; }
	public override bool IsNoMotionTake { get; }
	public bool IsMagicAttack { get; set; }

	// Methods

	// RVA: 0x206054C Offset: 0x205C54C VA: 0x206054C Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2060554 Offset: 0x205C554 VA: 0x2060554 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x206055C Offset: 0x205C55C VA: 0x206055C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2060564 Offset: 0x205C564 VA: 0x2060564 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x206056C Offset: 0x205C56C VA: 0x206056C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2060574 Offset: 0x205C574 VA: 0x2060574 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x206057C Offset: 0x205C57C VA: 0x206057C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2060584 Offset: 0x205C584 VA: 0x2060584 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x206058C Offset: 0x205C58C VA: 0x206058C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2060594 Offset: 0x205C594 VA: 0x2060594 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x206059C Offset: 0x205C59C VA: 0x206059C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x20605A4 Offset: 0x205C5A4 VA: 0x20605A4 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x20605AC Offset: 0x205C5AC VA: 0x20605AC Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x20605B4 Offset: 0x205C5B4 VA: 0x20605B4 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x20605BC Offset: 0x205C5BC VA: 0x20605BC Slot: 31
	public override bool get_IsNoMotionTake() { }

	[CompilerGenerated]
	// RVA: 0x20605C4 Offset: 0x205C5C4 VA: 0x20605C4
	public bool get_IsMagicAttack() { }

	[CompilerGenerated]
	// RVA: 0x20605CC Offset: 0x205C5CC VA: 0x20605CC
	private void set_IsMagicAttack(bool value) { }

	// RVA: 0x20605D8 Offset: 0x205C5D8 VA: 0x20605D8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x20607D4 Offset: 0x205C7D4 VA: 0x20607D4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x20607F0 Offset: 0x205C7F0 VA: 0x20607F0 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x2060940 Offset: 0x205C940 VA: 0x2060940 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2060B7C Offset: 0x205CB7C VA: 0x2060B7C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2060C50 Offset: 0x205CC50 VA: 0x2060C50 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x20613A8 Offset: 0x205D3A8 VA: 0x20613A8 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2061418 Offset: 0x205D418 VA: 0x2061418
	public void SetParameter(SkillCalcTemplate hitReaction, float intarval) { }

	// RVA: 0x2061470 Offset: 0x205D470 VA: 0x2061470
	public void .ctor() { }
}
