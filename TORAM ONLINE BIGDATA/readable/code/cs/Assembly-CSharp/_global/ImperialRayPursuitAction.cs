// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ImperialRayPursuitAction : PlayerAttackBase // TypeDefIndex: 1493
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private bool critical; // 0x128

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
	public override bool IsEventIgnoreOther { get; }
	public override bool IsMoveAssistContinue { get; }
	public override string LocalizeKey { get; }
	public override bool IsHideAttackApplied { get; }
	public override bool IsNoMotionTake { get; }
	public override bool IsExpDefFluctuate { get; }

	// Methods

	// RVA: 0x2062510 Offset: 0x205E510 VA: 0x2062510 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2062518 Offset: 0x205E518 VA: 0x2062518 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x2062520 Offset: 0x205E520 VA: 0x2062520 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2062528 Offset: 0x205E528 VA: 0x2062528 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2062530 Offset: 0x205E530 VA: 0x2062530 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2062538 Offset: 0x205E538 VA: 0x2062538 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2062540 Offset: 0x205E540 VA: 0x2062540 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2062548 Offset: 0x205E548 VA: 0x2062548 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2062550 Offset: 0x205E550 VA: 0x2062550 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2062558 Offset: 0x205E558 VA: 0x2062558 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2062560 Offset: 0x205E560 VA: 0x2062560 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2062568 Offset: 0x205E568 VA: 0x2062568 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x2062570 Offset: 0x205E570 VA: 0x2062570 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x2062578 Offset: 0x205E578 VA: 0x2062578 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x2062624 Offset: 0x205E624 VA: 0x2062624 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x206262C Offset: 0x205E62C VA: 0x206262C Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x2062634 Offset: 0x205E634 VA: 0x2062634 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x206263C Offset: 0x205E63C VA: 0x206263C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2062764 Offset: 0x205E764 VA: 0x2062764 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2062768 Offset: 0x205E768 VA: 0x2062768 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2062880 Offset: 0x205E880 VA: 0x2062880 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x206293C Offset: 0x205E93C VA: 0x206293C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2062DAC Offset: 0x205EDAC VA: 0x2062DAC
	public void SetParameter(ElementType element, bool critical) { }

	// RVA: 0x2062E70 Offset: 0x205EE70 VA: 0x2062E70
	public void .ctor() { }
}
