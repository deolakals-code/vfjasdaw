// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AdversityRoarAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 2660
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private int mpRecovery; // 0x124

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

	// RVA: 0x2225ACC Offset: 0x2221ACC VA: 0x2225ACC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2225AD4 Offset: 0x2221AD4 VA: 0x2225AD4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2225ADC Offset: 0x2221ADC VA: 0x2225ADC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2225AE4 Offset: 0x2221AE4 VA: 0x2225AE4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2225AEC Offset: 0x2221AEC VA: 0x2225AEC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2225AF4 Offset: 0x2221AF4 VA: 0x2225AF4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2225AFC Offset: 0x2221AFC VA: 0x2225AFC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2225B04 Offset: 0x2221B04 VA: 0x2225B04 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2225B0C Offset: 0x2221B0C VA: 0x2225B0C Slot: 15
	public override bool get_IsSupport() { }

	[CompilerGenerated]
	// RVA: 0x2225B14 Offset: 0x2221B14 VA: 0x2225B14 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x2225B1C Offset: 0x2221B1C VA: 0x2225B1C
	private void set_IsInheritance(bool value) { }

	// RVA: 0x2225B28 Offset: 0x2221B28 VA: 0x2225B28 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2225D7C Offset: 0x2221D7C VA: 0x2225D7C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2225E4C Offset: 0x2221E4C VA: 0x2225E4C Slot: 92
	public void OnInheritance() { }

	// RVA: 0x2225E58 Offset: 0x2221E58 VA: 0x2225E58
	public void .ctor() { }
}
