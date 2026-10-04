// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ForefistPunchAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 2589
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128

	// Properties
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

	// RVA: 0x2202AA0 Offset: 0x21FEAA0 VA: 0x2202AA0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2202AA8 Offset: 0x21FEAA8 VA: 0x2202AA8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2202AB0 Offset: 0x21FEAB0 VA: 0x2202AB0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2202AB8 Offset: 0x21FEAB8 VA: 0x2202AB8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2202AC0 Offset: 0x21FEAC0 VA: 0x2202AC0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2202AC8 Offset: 0x21FEAC8 VA: 0x2202AC8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2202AD0 Offset: 0x21FEAD0 VA: 0x2202AD0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2202AD8 Offset: 0x21FEAD8 VA: 0x2202AD8 Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x2202AE0 Offset: 0x21FEAE0 VA: 0x2202AE0 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x2202AE8 Offset: 0x21FEAE8 VA: 0x2202AE8
	private void set_IsInheritance(bool value) { }

	// RVA: 0x2202AF4 Offset: 0x21FEAF4 VA: 0x2202AF4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2202C00 Offset: 0x21FEC00 VA: 0x2202C00 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2202CC4 Offset: 0x21FECC4 VA: 0x2202CC4 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2202E30 Offset: 0x21FEE30 VA: 0x2202E30 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22030C0 Offset: 0x21FF0C0 VA: 0x22030C0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2203278 Offset: 0x21FF278 VA: 0x2203278 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x2203284 Offset: 0x21FF284 VA: 0x2203284
	public void .ctor() { }
}
