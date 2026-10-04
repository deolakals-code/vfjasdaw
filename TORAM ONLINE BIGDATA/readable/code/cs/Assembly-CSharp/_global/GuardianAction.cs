// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuardianAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 3666
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private int range; // 0x124
	private Vector3 checkPos; // 0x128

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

	// RVA: 0x23BEAC4 Offset: 0x23BAAC4 VA: 0x23BEAC4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23BEACC Offset: 0x23BAACC VA: 0x23BEACC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23BEAD4 Offset: 0x23BAAD4 VA: 0x23BEAD4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23BEADC Offset: 0x23BAADC VA: 0x23BEADC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23BEAE4 Offset: 0x23BAAE4 VA: 0x23BEAE4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23BEAEC Offset: 0x23BAAEC VA: 0x23BEAEC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23BEAF4 Offset: 0x23BAAF4 VA: 0x23BEAF4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23BEAFC Offset: 0x23BAAFC VA: 0x23BEAFC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23BEB04 Offset: 0x23BAB04 VA: 0x23BEB04 Slot: 15
	public override bool get_IsSupport() { }

	[CompilerGenerated]
	// RVA: 0x23BEB0C Offset: 0x23BAB0C VA: 0x23BEB0C Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x23BEB14 Offset: 0x23BAB14 VA: 0x23BEB14
	private void set_IsInheritance(bool value) { }

	// RVA: 0x23BEB20 Offset: 0x23BAB20 VA: 0x23BEB20 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23BECF4 Offset: 0x23BACF4 VA: 0x23BECF4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23BEDC4 Offset: 0x23BADC4 VA: 0x23BEDC4 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BEF08 Offset: 0x23BAF08 VA: 0x23BEF08 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23BEF84 Offset: 0x23BAF84 VA: 0x23BEF84 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x23BEF90 Offset: 0x23BAF90 VA: 0x23BEF90
	public void .ctor() { }
}
