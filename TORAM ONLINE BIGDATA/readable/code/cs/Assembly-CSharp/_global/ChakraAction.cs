// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ChakraAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 3627
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }
	public bool IsInheritance { get; set; }

	// Methods

	// RVA: 0x23B2A2C Offset: 0x23AEA2C VA: 0x23B2A2C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B2A34 Offset: 0x23AEA34 VA: 0x23B2A34 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B2A3C Offset: 0x23AEA3C VA: 0x23B2A3C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B2A44 Offset: 0x23AEA44 VA: 0x23B2A44 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B2A4C Offset: 0x23AEA4C VA: 0x23B2A4C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B2A54 Offset: 0x23AEA54 VA: 0x23B2A54 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B2A5C Offset: 0x23AEA5C VA: 0x23B2A5C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B2A64 Offset: 0x23AEA64 VA: 0x23B2A64 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B2A6C Offset: 0x23AEA6C VA: 0x23B2A6C Slot: 15
	public override bool get_IsSupport() { }

	[CompilerGenerated]
	// RVA: 0x23B2A74 Offset: 0x23AEA74 VA: 0x23B2A74 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x23B2A7C Offset: 0x23AEA7C VA: 0x23B2A7C
	private void set_IsInheritance(bool value) { }

	// RVA: 0x23B2A88 Offset: 0x23AEA88 VA: 0x23B2A88 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B2BEC Offset: 0x23AEBEC VA: 0x23B2BEC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B2CB4 Offset: 0x23AECB4 VA: 0x23B2CB4 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B2DE8 Offset: 0x23AEDE8 VA: 0x23B2DE8 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x23B2DF4 Offset: 0x23AEDF4 VA: 0x23B2DF4
	public void .ctor() { }
}
