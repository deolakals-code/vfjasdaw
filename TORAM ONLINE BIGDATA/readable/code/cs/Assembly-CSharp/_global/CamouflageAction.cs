// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CamouflageAction : PlayerAttackBase // TypeDefIndex: 3626
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x23B2548 Offset: 0x23AE548 VA: 0x23B2548 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B2550 Offset: 0x23AE550 VA: 0x23B2550 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B2558 Offset: 0x23AE558 VA: 0x23B2558 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B2560 Offset: 0x23AE560 VA: 0x23B2560 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B2568 Offset: 0x23AE568 VA: 0x23B2568 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B2570 Offset: 0x23AE570 VA: 0x23B2570 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B2578 Offset: 0x23AE578 VA: 0x23B2578 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B2580 Offset: 0x23AE580 VA: 0x23B2580 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B2588 Offset: 0x23AE588 VA: 0x23B2588 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B2590 Offset: 0x23AE590 VA: 0x23B2590 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B26C4 Offset: 0x23AE6C4 VA: 0x23B26C4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B2794 Offset: 0x23AE794 VA: 0x23B2794 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B2820 Offset: 0x23AE820 VA: 0x23B2820 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B298C Offset: 0x23AE98C VA: 0x23B298C
	public static void ChangeHateMine(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23B2A24 Offset: 0x23AEA24 VA: 0x23B2A24
	public void .ctor() { }
}
