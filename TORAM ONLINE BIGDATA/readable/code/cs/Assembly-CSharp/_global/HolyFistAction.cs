// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HolyFistAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 2954
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private float physicsSkillRate; // 0x124
	private float magicSkillRate; // 0x128
	private int fixAddDamage; // 0x12C

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

	// RVA: 0x22E2938 Offset: 0x22DE938 VA: 0x22E2938 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22E2940 Offset: 0x22DE940 VA: 0x22E2940 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22E2948 Offset: 0x22DE948 VA: 0x22E2948 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22E2950 Offset: 0x22DE950 VA: 0x22E2950 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22E2958 Offset: 0x22DE958 VA: 0x22E2958 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22E2960 Offset: 0x22DE960 VA: 0x22E2960 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22E2968 Offset: 0x22DE968 VA: 0x22E2968 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22E2970 Offset: 0x22DE970 VA: 0x22E2970 Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x22E2978 Offset: 0x22DE978 VA: 0x22E2978 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x22E2980 Offset: 0x22DE980 VA: 0x22E2980
	private void set_IsInheritance(bool value) { }

	// RVA: 0x22E298C Offset: 0x22DE98C VA: 0x22E298C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22E2CE0 Offset: 0x22DECE0 VA: 0x22E2CE0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22E2DA4 Offset: 0x22DEDA4 VA: 0x22E2DA4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22E33C4 Offset: 0x22DF3C4 VA: 0x22E33C4 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x22E33D0 Offset: 0x22DF3D0 VA: 0x22E33D0
	public void .ctor() { }
}
