// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SenfutsuAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2809
{
	// Fields
	private SenfutsuAction.STATE state; // 0x120
	private float[] skillRate; // 0x128
	private int[] fixAddDamage; // 0x130
	private int[] tumblePercent; // 0x138
	private int buffTime; // 0x140
	private int recoveryAvoidStack; // 0x144
	private bool isSuccessTumble; // 0x148

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override string LocalizeKey { get; }

	// Methods

	// RVA: 0x2283400 Offset: 0x227F400 VA: 0x2283400 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2283408 Offset: 0x227F408 VA: 0x2283408 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2283410 Offset: 0x227F410 VA: 0x2283410 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2283418 Offset: 0x227F418 VA: 0x2283418 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2283420 Offset: 0x227F420 VA: 0x2283420 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2283428 Offset: 0x227F428 VA: 0x2283428 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2283430 Offset: 0x227F430 VA: 0x2283430 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2283438 Offset: 0x227F438 VA: 0x2283438 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2283440 Offset: 0x227F440 VA: 0x2283440 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x22834AC Offset: 0x227F4AC VA: 0x22834AC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x228390C Offset: 0x227F90C VA: 0x228390C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2283990 Offset: 0x227F990 VA: 0x2283990 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2283A58 Offset: 0x227FA58 VA: 0x2283A58 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22841A4 Offset: 0x22801A4 VA: 0x22841A4 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2284310 Offset: 0x2280310 VA: 0x2284310 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2284374 Offset: 0x2280374 VA: 0x2284374
	internal void OnSuccessAddAbnormalState(EnemyMobActionManagerBase enemyMobActionManager, GameObject actor, AbnormalType type) { }

	// RVA: 0x2284388 Offset: 0x2280388 VA: 0x2284388 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x22843A0 Offset: 0x22803A0 VA: 0x22843A0 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x228453C Offset: 0x228053C VA: 0x228453C Slot: 50
	public override bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x228454C Offset: 0x228054C VA: 0x228454C
	public void .ctor() { }
}
