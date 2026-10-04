// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BreathingMethodAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 3624
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private int mp; // 0x124

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

	// RVA: 0x23B1910 Offset: 0x23AD910 VA: 0x23B1910 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B1918 Offset: 0x23AD918 VA: 0x23B1918 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B1920 Offset: 0x23AD920 VA: 0x23B1920 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B1928 Offset: 0x23AD928 VA: 0x23B1928 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B1930 Offset: 0x23AD930 VA: 0x23B1930 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B1938 Offset: 0x23AD938 VA: 0x23B1938 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B1940 Offset: 0x23AD940 VA: 0x23B1940 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B1948 Offset: 0x23AD948 VA: 0x23B1948 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B1950 Offset: 0x23AD950 VA: 0x23B1950 Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x23B1958 Offset: 0x23AD958 VA: 0x23B1958 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x23B1960 Offset: 0x23AD960 VA: 0x23B1960
	private void set_IsInheritance(bool value) { }

	// RVA: 0x23B196C Offset: 0x23AD96C VA: 0x23B196C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B1B08 Offset: 0x23ADB08 VA: 0x23B1B08 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B1B9C Offset: 0x23ADB9C VA: 0x23B1B9C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B1C9C Offset: 0x23ADC9C VA: 0x23B1C9C Slot: 92
	public void OnInheritance() { }

	// RVA: 0x23B1CA8 Offset: 0x23ADCA8 VA: 0x23B1CA8
	public void .ctor() { }
}
