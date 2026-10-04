// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicPursuitAction : PlayerAttackBase // TypeDefIndex: 1495
{
	// Fields
	private readonly int damageCount; // 0x120

	// Properties
	public override int ActionID { get; }
	public override bool NoCost { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsSupport { get; }
	public override bool IsChatLog { get; }
	public override bool IsHideAttackApplied { get; }
	public override bool IsExpDefFluctuate { get; }
	public override bool IsNotPlayToOtherPlayer { get; }

	// Methods

	// RVA: 0x20634E8 Offset: 0x205F4E8 VA: 0x20634E8 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x20634F0 Offset: 0x205F4F0 VA: 0x20634F0 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x20634F8 Offset: 0x205F4F8 VA: 0x20634F8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2063500 Offset: 0x205F500 VA: 0x2063500 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2063508 Offset: 0x205F508 VA: 0x2063508 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2063510 Offset: 0x205F510 VA: 0x2063510 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2063518 Offset: 0x205F518 VA: 0x2063518 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2063520 Offset: 0x205F520 VA: 0x2063520 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2063528 Offset: 0x205F528 VA: 0x2063528 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2063530 Offset: 0x205F530 VA: 0x2063530 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2063538 Offset: 0x205F538 VA: 0x2063538 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x2063540 Offset: 0x205F540 VA: 0x2063540 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2063548 Offset: 0x205F548 VA: 0x2063548 Slot: 25
	public override bool get_IsChatLog() { }

	// RVA: 0x2063550 Offset: 0x205F550 VA: 0x2063550 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x2063558 Offset: 0x205F558 VA: 0x2063558 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x2063560 Offset: 0x205F560 VA: 0x2063560 Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x2063568 Offset: 0x205F568 VA: 0x2063568 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2063574 Offset: 0x205F574 VA: 0x2063574 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2063580 Offset: 0x205F580 VA: 0x2063580 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x20635A4 Offset: 0x205F5A4 VA: 0x20635A4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2063920 Offset: 0x205F920 VA: 0x2063920
	public void .ctor() { }
}
