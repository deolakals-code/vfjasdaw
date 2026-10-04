// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlizzardAction : PlayerAttackBase, IHighFamiliaAttackSkill, IAbnormalStateSkill // TypeDefIndex: 3049
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int percent; // 0x128
	private float attackRange; // 0x12C
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x130
	private Transform mainTarget; // 0x138
	private int maxAttackCount; // 0x140

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

	// Methods

	// RVA: 0x2316128 Offset: 0x2312128 VA: 0x2316128 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2316130 Offset: 0x2312130 VA: 0x2316130 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2316154 Offset: 0x2312154 VA: 0x2316154 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x231615C Offset: 0x231215C VA: 0x231615C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2316164 Offset: 0x2312164 VA: 0x2316164 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x231616C Offset: 0x231216C VA: 0x231616C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2316174 Offset: 0x2312174 VA: 0x2316174 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x231617C Offset: 0x231217C VA: 0x231617C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2316184 Offset: 0x2312184 VA: 0x2316184 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x23161A4 Offset: 0x23121A4 VA: 0x23161A4 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x23161C4 Offset: 0x23121C4 VA: 0x23161C4 Slot: 92
	public bool get_IsFailureSkill() { }

	// RVA: 0x23161F4 Offset: 0x23121F4 VA: 0x23161F4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2316560 Offset: 0x2312560 VA: 0x2316560 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23165F8 Offset: 0x23125F8 VA: 0x23165F8 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x23165FC Offset: 0x23125FC VA: 0x23165FC Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2316758 Offset: 0x2312758 VA: 0x2316758 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2316854 Offset: 0x2312854 VA: 0x2316854 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2316AF0 Offset: 0x2312AF0 VA: 0x2316AF0 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2316B60 Offset: 0x2312B60 VA: 0x2316B60 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2316C94 Offset: 0x2312C94 VA: 0x2316C94 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2317334 Offset: 0x2313334 VA: 0x2317334 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23173CC Offset: 0x23133CC VA: 0x23173CC Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2317430 Offset: 0x2313430 VA: 0x2317430 Slot: 91
	public void InitializeHighFamilia(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x231723C Offset: 0x231323C VA: 0x231723C
	private void SkillBufValid(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2317144 Offset: 0x2313144 VA: 0x2317144
	private void SkillBufInvalid(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2317594 Offset: 0x2313594 VA: 0x2317594
	public void .ctor() { }
}
