// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RangeHateAttackAction : PlayerAttackBase // TypeDefIndex: 2952
{
	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool NoCost { get; }
	public override SkillTreeType TreeType { get; }
	public override bool IsSupport { get; }
	public override bool IsNoMotionTake { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsExpDefFluctuate { get; }
	public override bool IsNotPlayToOtherPlayer { get; }

	// Methods

	// RVA: 0x22E1430 Offset: 0x22DD430 VA: 0x22E1430 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x22E1438 Offset: 0x22DD438 VA: 0x22E1438 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22E1440 Offset: 0x22DD440 VA: 0x22E1440 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22E1448 Offset: 0x22DD448 VA: 0x22E1448 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22E1450 Offset: 0x22DD450 VA: 0x22E1450 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22E1458 Offset: 0x22DD458 VA: 0x22E1458 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22E1460 Offset: 0x22DD460 VA: 0x22E1460 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22E1468 Offset: 0x22DD468 VA: 0x22E1468 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22E1470 Offset: 0x22DD470 VA: 0x22E1470 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22E1478 Offset: 0x22DD478 VA: 0x22E1478 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22E1480 Offset: 0x22DD480 VA: 0x22E1480 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x22E1488 Offset: 0x22DD488 VA: 0x22E1488 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22E1490 Offset: 0x22DD490 VA: 0x22E1490 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x22E1498 Offset: 0x22DD498 VA: 0x22E1498 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x22E14A0 Offset: 0x22DD4A0 VA: 0x22E14A0 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x22E14A8 Offset: 0x22DD4A8 VA: 0x22E14A8 Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x22E14B0 Offset: 0x22DD4B0 VA: 0x22E14B0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22E1594 Offset: 0x22DD594 VA: 0x22E1594 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22E17E0 Offset: 0x22DD7E0 VA: 0x22E17E0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22E195C Offset: 0x22DD95C VA: 0x22E195C
	public void .ctor() { }
}
