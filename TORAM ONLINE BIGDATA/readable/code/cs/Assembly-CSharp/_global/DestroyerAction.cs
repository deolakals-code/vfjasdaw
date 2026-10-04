// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DestroyerAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 3632
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120

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

	// RVA: 0x23B430C Offset: 0x23B030C VA: 0x23B430C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B4314 Offset: 0x23B0314 VA: 0x23B4314 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B431C Offset: 0x23B031C VA: 0x23B431C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B4324 Offset: 0x23B0324 VA: 0x23B4324 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B432C Offset: 0x23B032C VA: 0x23B432C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B4334 Offset: 0x23B0334 VA: 0x23B4334 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B433C Offset: 0x23B033C VA: 0x23B433C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B4344 Offset: 0x23B0344 VA: 0x23B4344 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B434C Offset: 0x23B034C VA: 0x23B434C Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x23B4354 Offset: 0x23B0354 VA: 0x23B4354 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x23B435C Offset: 0x23B035C VA: 0x23B435C
	private void set_IsInheritance(bool value) { }

	// RVA: 0x23B4368 Offset: 0x23B0368 VA: 0x23B4368 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B44FC Offset: 0x23B04FC VA: 0x23B44FC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B45CC Offset: 0x23B05CC VA: 0x23B45CC Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B478C Offset: 0x23B078C VA: 0x23B478C Slot: 92
	public void OnInheritance() { }

	// RVA: 0x23B4798 Offset: 0x23B0798 VA: 0x23B4798
	public void .ctor() { }
}
