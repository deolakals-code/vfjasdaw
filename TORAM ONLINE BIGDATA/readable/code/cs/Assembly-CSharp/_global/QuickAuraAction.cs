// Assembly: Assembly-CSharp.dll
// Namespace: 
public class QuickAuraAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 2688
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private float time; // 0x124
	private bool isLevel1; // 0x128

	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public bool IsInheritance { get; set; }

	// Methods

	// RVA: 0x2235810 Offset: 0x2231810 VA: 0x2235810 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2235818 Offset: 0x2231818 VA: 0x2235818 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2235820 Offset: 0x2231820 VA: 0x2235820 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2235828 Offset: 0x2231828 VA: 0x2235828 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2235830 Offset: 0x2231830 VA: 0x2235830 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2235838 Offset: 0x2231838 VA: 0x2235838 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2235840 Offset: 0x2231840 VA: 0x2235840 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2235848 Offset: 0x2231848 VA: 0x2235848 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2235850 Offset: 0x2231850 VA: 0x2235850 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	[CompilerGenerated]
	// RVA: 0x2235858 Offset: 0x2231858 VA: 0x2235858 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x2235860 Offset: 0x2231860 VA: 0x2235860
	private void set_IsInheritance(bool value) { }

	// RVA: 0x223586C Offset: 0x223186C VA: 0x223586C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2235AE0 Offset: 0x2231AE0 VA: 0x2235AE0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2235BA0 Offset: 0x2231BA0 VA: 0x2235BA0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2235C54 Offset: 0x2231C54 VA: 0x2235C54 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x2235C60 Offset: 0x2231C60 VA: 0x2235C60
	public void .ctor() { }
}
