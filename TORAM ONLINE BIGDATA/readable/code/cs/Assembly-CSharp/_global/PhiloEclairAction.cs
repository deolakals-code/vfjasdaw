// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PhiloEclairAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 3724
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private byte isDualSword; // 0x121

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
	public bool IsInheritance { get; set; }

	// Methods

	// RVA: 0x23D49E0 Offset: 0x23D09E0 VA: 0x23D49E0 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D49E8 Offset: 0x23D09E8 VA: 0x23D49E8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D49F0 Offset: 0x23D09F0 VA: 0x23D49F0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D49F8 Offset: 0x23D09F8 VA: 0x23D49F8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D4A00 Offset: 0x23D0A00 VA: 0x23D4A00 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D4A08 Offset: 0x23D0A08 VA: 0x23D4A08 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D4A10 Offset: 0x23D0A10 VA: 0x23D4A10 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D4A18 Offset: 0x23D0A18 VA: 0x23D4A18 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D4A20 Offset: 0x23D0A20 VA: 0x23D4A20 Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x23D4A28 Offset: 0x23D0A28 VA: 0x23D4A28 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x23D4A30 Offset: 0x23D0A30 VA: 0x23D4A30
	private void set_IsInheritance(bool value) { }

	// RVA: 0x23D4A3C Offset: 0x23D0A3C VA: 0x23D4A3C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D4BFC Offset: 0x23D0BFC VA: 0x23D4BFC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D4CCC Offset: 0x23D0CCC VA: 0x23D4CCC Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D4D80 Offset: 0x23D0D80 VA: 0x23D4D80 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x23D4D8C Offset: 0x23D0D8C VA: 0x23D4D8C
	public void .ctor() { }
}
