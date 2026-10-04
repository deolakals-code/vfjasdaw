// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WarCryAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 3764
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

	// RVA: 0x23E2644 Offset: 0x23DE644 VA: 0x23E2644 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23E264C Offset: 0x23DE64C VA: 0x23E264C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23E2654 Offset: 0x23DE654 VA: 0x23E2654 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23E265C Offset: 0x23DE65C VA: 0x23E265C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23E2664 Offset: 0x23DE664 VA: 0x23E2664 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23E266C Offset: 0x23DE66C VA: 0x23E266C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23E2674 Offset: 0x23DE674 VA: 0x23E2674 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23E267C Offset: 0x23DE67C VA: 0x23E267C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23E2684 Offset: 0x23DE684 VA: 0x23E2684 Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x23E268C Offset: 0x23DE68C VA: 0x23E268C Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x23E2694 Offset: 0x23DE694 VA: 0x23E2694
	private void set_IsInheritance(bool value) { }

	// RVA: 0x23E26A0 Offset: 0x23DE6A0 VA: 0x23E26A0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23E2814 Offset: 0x23DE814 VA: 0x23E2814 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23E28E4 Offset: 0x23DE8E4 VA: 0x23E28E4 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23E29D8 Offset: 0x23DE9D8 VA: 0x23E29D8 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23E2C40 Offset: 0x23DEC40 VA: 0x23E2C40 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x23E2C4C Offset: 0x23DEC4C VA: 0x23E2C4C
	public void .ctor() { }
}
