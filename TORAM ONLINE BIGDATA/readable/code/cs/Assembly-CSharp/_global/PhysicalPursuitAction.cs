// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PhysicalPursuitAction : PlayerAttackBase // TypeDefIndex: 1506
{
	// Fields
	private float skillRate; // 0x120
	private readonly int damageCount; // 0x124

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
	public override bool IsEventIgnoreOther { get; }
	public override bool IsNotPlayToOtherPlayer { get; }

	// Methods

	// RVA: 0x206AE88 Offset: 0x2066E88 VA: 0x206AE88 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x206AE90 Offset: 0x2066E90 VA: 0x206AE90 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x206AE98 Offset: 0x2066E98 VA: 0x206AE98 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x206AEA0 Offset: 0x2066EA0 VA: 0x206AEA0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x206AEA8 Offset: 0x2066EA8 VA: 0x206AEA8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x206AEB0 Offset: 0x2066EB0 VA: 0x206AEB0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x206AEB8 Offset: 0x2066EB8 VA: 0x206AEB8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x206AEC0 Offset: 0x2066EC0 VA: 0x206AEC0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x206AEC8 Offset: 0x2066EC8 VA: 0x206AEC8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x206AED0 Offset: 0x2066ED0 VA: 0x206AED0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x206AED8 Offset: 0x2066ED8 VA: 0x206AED8 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x206AEE0 Offset: 0x2066EE0 VA: 0x206AEE0 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x206AEE8 Offset: 0x2066EE8 VA: 0x206AEE8 Slot: 25
	public override bool get_IsChatLog() { }

	// RVA: 0x206AEF0 Offset: 0x2066EF0 VA: 0x206AEF0 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x206AEF8 Offset: 0x2066EF8 VA: 0x206AEF8 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x206AF00 Offset: 0x2066F00 VA: 0x206AF00 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x206AF08 Offset: 0x2066F08 VA: 0x206AF08 Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x206AF10 Offset: 0x2066F10 VA: 0x206AF10 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x206AF1C Offset: 0x2066F1C VA: 0x206AF1C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x206AF28 Offset: 0x2066F28 VA: 0x206AF28 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x206B674 Offset: 0x2067674 VA: 0x206B674 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x206CBA8 Offset: 0x2068BA8 VA: 0x206CBA8
	public void .ctor() { }
}
