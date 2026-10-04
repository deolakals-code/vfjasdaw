// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummonSkeletonBomb : PlayerAttackBase // TypeDefIndex: 2900
{
	// Fields
	private int skillRate; // 0x120
	private int constDamage; // 0x124
	private Vector3 skillPos; // 0x128

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override SkillAttackType ExpType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool NoCost { get; }
	public override int BaseMp { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsSupport { get; }
	public override bool IsChatLog { get; }
	public override bool IsHideAttackApplied { get; }
	public override bool IsNoMotionTake { get; }
	public override bool IsNotPlayToOtherPlayer { get; }

	// Methods

	// RVA: 0x22C6638 Offset: 0x22C2638 VA: 0x22C6638 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x22C6640 Offset: 0x22C2640 VA: 0x22C6640 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22C6648 Offset: 0x22C2648 VA: 0x22C6648 Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x22C6650 Offset: 0x22C2650 VA: 0x22C6650 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22C6658 Offset: 0x22C2658 VA: 0x22C6658 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22C6660 Offset: 0x22C2660 VA: 0x22C6660 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22C6668 Offset: 0x22C2668 VA: 0x22C6668 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22C6670 Offset: 0x22C2670 VA: 0x22C6670 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22C6678 Offset: 0x22C2678 VA: 0x22C6678 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22C6680 Offset: 0x22C2680 VA: 0x22C6680 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22C6688 Offset: 0x22C2688 VA: 0x22C6688 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22C6690 Offset: 0x22C2690 VA: 0x22C6690 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x22C6698 Offset: 0x22C2698 VA: 0x22C6698 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22C66A0 Offset: 0x22C26A0 VA: 0x22C66A0 Slot: 25
	public override bool get_IsChatLog() { }

	// RVA: 0x22C66A8 Offset: 0x22C26A8 VA: 0x22C66A8 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x22C66B0 Offset: 0x22C26B0 VA: 0x22C66B0 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x22C66B8 Offset: 0x22C26B8 VA: 0x22C66B8 Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x22C66C0 Offset: 0x22C26C0 VA: 0x22C66C0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22C68D0 Offset: 0x22C28D0 VA: 0x22C68D0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22C68DC Offset: 0x22C28DC VA: 0x22C68DC Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22C6908 Offset: 0x22C2908 VA: 0x22C6908 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22C6B90 Offset: 0x22C2B90 VA: 0x22C6B90
	public void SetSkillPosition(Vector3 pos) { }

	// RVA: 0x22C6CF8 Offset: 0x22C2CF8 VA: 0x22C6CF8 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22C6DF4 Offset: 0x22C2DF4 VA: 0x22C6DF4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22C71A8 Offset: 0x22C31A8 VA: 0x22C71A8 Slot: 86
	protected override int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x22C7544 Offset: 0x22C3544 VA: 0x22C7544
	public void .ctor() { }
}
