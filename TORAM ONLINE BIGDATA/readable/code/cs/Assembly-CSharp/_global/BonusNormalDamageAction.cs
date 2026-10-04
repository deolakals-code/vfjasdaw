// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BonusNormalDamageAction : PlayerAttackBase // TypeDefIndex: 1486
{
	// Fields
	private int skillRate; // 0x120

	// Properties
	public override int ActionID { get; }
	public override bool NoCost { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsSupport { get; }
	public override bool IsChatLog { get; }
	public override bool IsHideAttackApplied { get; }
	public override bool IsExpDefFluctuate { get; }
	protected override bool CheckBlank { get; }
	public override bool IsNoMotionTake { get; }
	public override bool IsNotPlayToOtherPlayer { get; }

	// Methods

	// RVA: 0x205C538 Offset: 0x2058538 VA: 0x205C538 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x205C540 Offset: 0x2058540 VA: 0x205C540 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x205C548 Offset: 0x2058548 VA: 0x205C548 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x205C550 Offset: 0x2058550 VA: 0x205C550 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x205C558 Offset: 0x2058558 VA: 0x205C558 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x205C560 Offset: 0x2058560 VA: 0x205C560 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x205C568 Offset: 0x2058568 VA: 0x205C568 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x205C570 Offset: 0x2058570 VA: 0x205C570 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x205C578 Offset: 0x2058578 VA: 0x205C578 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x205C580 Offset: 0x2058580 VA: 0x205C580 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x205C588 Offset: 0x2058588 VA: 0x205C588 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x205C590 Offset: 0x2058590 VA: 0x205C590 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x205C598 Offset: 0x2058598 VA: 0x205C598 Slot: 25
	public override bool get_IsChatLog() { }

	// RVA: 0x205C5A0 Offset: 0x20585A0 VA: 0x205C5A0 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x205C5A8 Offset: 0x20585A8 VA: 0x205C5A8 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x205C5B0 Offset: 0x20585B0 VA: 0x205C5B0 Slot: 73
	protected override bool get_CheckBlank() { }

	// RVA: 0x205C5B8 Offset: 0x20585B8 VA: 0x205C5B8 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x205C5C0 Offset: 0x20585C0 VA: 0x205C5C0 Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x205C5C8 Offset: 0x20585C8 VA: 0x205C5C8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x205C5D4 Offset: 0x20585D4 VA: 0x205C5D4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x205C5E0 Offset: 0x20585E0 VA: 0x205C5E0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x205C5E8 Offset: 0x20585E8 VA: 0x205C5E8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x205CA4C Offset: 0x2058A4C VA: 0x205CA4C
	public void .ctor() { }
}
