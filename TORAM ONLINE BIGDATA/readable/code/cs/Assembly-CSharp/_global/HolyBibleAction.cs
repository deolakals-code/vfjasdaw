// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HolyBibleAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 3680
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120

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

	// RVA: 0x23C3B40 Offset: 0x23BFB40 VA: 0x23C3B40 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23C3B48 Offset: 0x23BFB48 VA: 0x23C3B48 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23C3B50 Offset: 0x23BFB50 VA: 0x23C3B50 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23C3B58 Offset: 0x23BFB58 VA: 0x23C3B58 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23C3B60 Offset: 0x23BFB60 VA: 0x23C3B60 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23C3B68 Offset: 0x23BFB68 VA: 0x23C3B68 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23C3B70 Offset: 0x23BFB70 VA: 0x23C3B70 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23C3B78 Offset: 0x23BFB78 VA: 0x23C3B78 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23C3B80 Offset: 0x23BFB80 VA: 0x23C3B80 Slot: 23
	public override int get_BaseMp() { }

	[CompilerGenerated]
	// RVA: 0x23C3B88 Offset: 0x23BFB88 VA: 0x23C3B88 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x23C3B90 Offset: 0x23BFB90 VA: 0x23C3B90
	private void set_IsInheritance(bool value) { }

	// RVA: 0x23C3B9C Offset: 0x23BFB9C VA: 0x23C3B9C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C3CD0 Offset: 0x23BFCD0 VA: 0x23C3CD0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C3DA0 Offset: 0x23BFDA0 VA: 0x23C3DA0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C3FD0 Offset: 0x23BFFD0 VA: 0x23C3FD0 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x23C3FDC Offset: 0x23BFFDC VA: 0x23C3FDC
	public void .ctor() { }
}
