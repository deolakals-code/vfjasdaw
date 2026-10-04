// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StabilisAction : PlayerAttackBase // TypeDefIndex: 3046
{
	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsOverlay { get; }

	// Methods

	// RVA: 0x23157F8 Offset: 0x23117F8 VA: 0x23157F8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2315800 Offset: 0x2311800 VA: 0x2315800 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2315808 Offset: 0x2311808 VA: 0x2315808 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2315810 Offset: 0x2311810 VA: 0x2315810 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2315818 Offset: 0x2311818 VA: 0x2315818 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2315820 Offset: 0x2311820 VA: 0x2315820 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2315828 Offset: 0x2311828 VA: 0x2315828 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2315830 Offset: 0x2311830 VA: 0x2315830 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2315838 Offset: 0x2311838 VA: 0x2315838 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2315840 Offset: 0x2311840 VA: 0x2315840 Slot: 19
	public override bool get_IsOverlay() { }

	// RVA: 0x2315848 Offset: 0x2311848 VA: 0x2315848 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2315960 Offset: 0x2311960 VA: 0x2315960 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2315A18 Offset: 0x2311A18 VA: 0x2315A18 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2315C48 Offset: 0x2311C48 VA: 0x2315C48
	public void .ctor() { }
}
