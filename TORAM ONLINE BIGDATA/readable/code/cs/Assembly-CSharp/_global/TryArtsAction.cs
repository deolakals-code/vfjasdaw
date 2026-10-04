// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TryArtsAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 2817
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int[] criticalPercent; // 0x130

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

	// RVA: 0x2288DD4 Offset: 0x2284DD4 VA: 0x2288DD4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2288DDC Offset: 0x2284DDC VA: 0x2288DDC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2288DE4 Offset: 0x2284DE4 VA: 0x2288DE4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2288DEC Offset: 0x2284DEC VA: 0x2288DEC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2288DF4 Offset: 0x2284DF4 VA: 0x2288DF4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2288DFC Offset: 0x2284DFC VA: 0x2288DFC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2288E04 Offset: 0x2284E04 VA: 0x2288E04 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2288E0C Offset: 0x2284E0C VA: 0x2288E0C Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x2288E14 Offset: 0x2284E14 VA: 0x2288E14 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x2288E1C Offset: 0x2284E1C VA: 0x2288E1C
	private void set_IsInheritance(bool value) { }

	// RVA: 0x2288E28 Offset: 0x2284E28 VA: 0x2288E28 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2289090 Offset: 0x2285090 VA: 0x2289090 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2289158 Offset: 0x2285158 VA: 0x2289158 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22894D8 Offset: 0x22854D8 VA: 0x22894D8 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x22894E4 Offset: 0x22854E4 VA: 0x22894E4
	public void .ctor() { }
}
