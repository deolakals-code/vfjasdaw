// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HideAttackAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 3674
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private int mp; // 0x124

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
	public bool IsInheritance { get; set; }

	// Methods

	// RVA: 0x23C1A20 Offset: 0x23BDA20 VA: 0x23C1A20 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23C1A28 Offset: 0x23BDA28 VA: 0x23C1A28 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23C1A30 Offset: 0x23BDA30 VA: 0x23C1A30 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23C1A38 Offset: 0x23BDA38 VA: 0x23C1A38 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23C1A40 Offset: 0x23BDA40 VA: 0x23C1A40 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23C1A48 Offset: 0x23BDA48 VA: 0x23C1A48 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23C1A50 Offset: 0x23BDA50 VA: 0x23C1A50 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23C1A58 Offset: 0x23BDA58 VA: 0x23C1A58 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23C1A60 Offset: 0x23BDA60 VA: 0x23C1A60 Slot: 23
	public override int get_BaseMp() { }

	[CompilerGenerated]
	// RVA: 0x23C1A68 Offset: 0x23BDA68 VA: 0x23C1A68 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x23C1A70 Offset: 0x23BDA70 VA: 0x23C1A70
	private void set_IsInheritance(bool value) { }

	// RVA: 0x23C1A7C Offset: 0x23BDA7C VA: 0x23C1A7C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C1C1C Offset: 0x23BDC1C VA: 0x23C1C1C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C1CB0 Offset: 0x23BDCB0 VA: 0x23C1CB0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C1E2C Offset: 0x23BDE2C VA: 0x23C1E2C Slot: 92
	public void OnInheritance() { }

	// RVA: 0x23C1E38 Offset: 0x23BDE38 VA: 0x23C1E38
	public void .ctor() { }
}
