// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EtherCoatAction : PlayerAttackBase // TypeDefIndex: 3648
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23B92C8 Offset: 0x23B52C8 VA: 0x23B92C8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B92D0 Offset: 0x23B52D0 VA: 0x23B92D0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B92D8 Offset: 0x23B52D8 VA: 0x23B92D8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B92E0 Offset: 0x23B52E0 VA: 0x23B92E0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B92E8 Offset: 0x23B52E8 VA: 0x23B92E8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B92F0 Offset: 0x23B52F0 VA: 0x23B92F0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B92F8 Offset: 0x23B52F8 VA: 0x23B92F8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B9300 Offset: 0x23B5300 VA: 0x23B9300 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B9308 Offset: 0x23B5308 VA: 0x23B9308 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B9310 Offset: 0x23B5310 VA: 0x23B9310 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B9468 Offset: 0x23B5468 VA: 0x23B9468 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B9538 Offset: 0x23B5538 VA: 0x23B9538 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B9624 Offset: 0x23B5624 VA: 0x23B9624
	public void .ctor() { }
}
