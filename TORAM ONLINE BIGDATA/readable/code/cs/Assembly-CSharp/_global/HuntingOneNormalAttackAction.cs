// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HuntingOneNormalAttackAction : HuntingOneSkillBase // TypeDefIndex: 3366
{
	// Fields
	private readonly SkillId[] validSkillBufIds; // 0x120
	private float skillRate; // 0x128
	private int constantDamage; // 0x12C
	private float assistMoveTargetDistance; // 0x130

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override bool IsMoveAssistContinue { get; }
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
	protected override bool CheckBlank { get; }

	// Methods

	// RVA: 0x2352470 Offset: 0x234E470 VA: 0x2352470 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2352478 Offset: 0x234E478 VA: 0x2352478 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x2352480 Offset: 0x234E480 VA: 0x2352480 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x2352488 Offset: 0x234E488 VA: 0x2352488 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2352490 Offset: 0x234E490 VA: 0x2352490 Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x2352498 Offset: 0x234E498 VA: 0x2352498 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23524A0 Offset: 0x234E4A0 VA: 0x23524A0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23524A8 Offset: 0x234E4A8 VA: 0x23524A8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23524B0 Offset: 0x234E4B0 VA: 0x23524B0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23524B8 Offset: 0x234E4B8 VA: 0x23524B8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23524C0 Offset: 0x234E4C0 VA: 0x23524C0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23524C8 Offset: 0x234E4C8 VA: 0x23524C8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23524D0 Offset: 0x234E4D0 VA: 0x23524D0 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x23524D8 Offset: 0x234E4D8 VA: 0x23524D8 Slot: 73
	protected override bool get_CheckBlank() { }

	// RVA: 0x23524E0 Offset: 0x234E4E0 VA: 0x23524E0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2352564 Offset: 0x234E564 VA: 0x2352564 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23526E8 Offset: 0x234E6E8 VA: 0x23526E8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2352904 Offset: 0x234E904 VA: 0x2352904 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x23542FC Offset: 0x23502FC VA: 0x23542FC
	public void UpdateAssistMoveTargetDistancce(float assistMoveTargetDistance) { }

	// RVA: 0x2354304 Offset: 0x2350304 VA: 0x2354304 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2354384 Offset: 0x2350384 VA: 0x2354384
	public void .ctor() { }
}
