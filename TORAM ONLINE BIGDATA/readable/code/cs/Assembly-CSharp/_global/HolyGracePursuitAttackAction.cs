// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HolyGracePursuitAttackAction : PlayerAttackBase // TypeDefIndex: 2955
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private int magicResistBreaker; // 0x128
	private float attackRange; // 0x12C
	private Vector3 attackPos; // 0x130

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override SkillAttackType ExpType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool NoCost { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsEventIgnoreOther { get; }
	public override bool IsNoMotionTake { get; }
	protected override bool CheckBlank { get; }
	public override bool IsSupport { get; }
	public override bool IsNotPlayToOtherPlayer { get; }

	// Methods

	// RVA: 0x22E33E8 Offset: 0x22DF3E8 VA: 0x22E33E8 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x22E33F0 Offset: 0x22DF3F0 VA: 0x22E33F0 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x22E33F8 Offset: 0x22DF3F8 VA: 0x22E33F8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22E3400 Offset: 0x22DF400 VA: 0x22E3400 Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x22E3408 Offset: 0x22DF408 VA: 0x22E3408 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22E3410 Offset: 0x22DF410 VA: 0x22E3410 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22E3418 Offset: 0x22DF418 VA: 0x22E3418 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22E3420 Offset: 0x22DF420 VA: 0x22E3420 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22E3428 Offset: 0x22DF428 VA: 0x22E3428 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22E3430 Offset: 0x22DF430 VA: 0x22E3430 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22E3438 Offset: 0x22DF438 VA: 0x22E3438 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22E3440 Offset: 0x22DF440 VA: 0x22E3440 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22E3448 Offset: 0x22DF448 VA: 0x22E3448 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x22E3450 Offset: 0x22DF450 VA: 0x22E3450 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x22E3458 Offset: 0x22DF458 VA: 0x22E3458 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x22E3460 Offset: 0x22DF460 VA: 0x22E3460 Slot: 73
	protected override bool get_CheckBlank() { }

	// RVA: 0x22E3468 Offset: 0x22DF468 VA: 0x22E3468 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22E3470 Offset: 0x22DF470 VA: 0x22E3470 Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x22E3478 Offset: 0x22DF478 VA: 0x22E3478 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22E36E4 Offset: 0x22DF6E4 VA: 0x22E36E4 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E3734 Offset: 0x22DF734 VA: 0x22E3734 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E3890 Offset: 0x22DF890 VA: 0x22E3890 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22E3F38 Offset: 0x22DFF38 VA: 0x22E3F38 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22E3950 Offset: 0x22DF950 VA: 0x22E3950
	public static bool CheckHate(MobActionManagerBase target) { }

	// RVA: 0x22E42B4 Offset: 0x22E02B4 VA: 0x22E42B4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22E42C0 Offset: 0x22E02C0 VA: 0x22E42C0
	public void .ctor() { }
}
