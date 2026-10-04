// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ProvokeAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 2750
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private int mp; // 0x124

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

	// RVA: 0x2255E68 Offset: 0x2251E68 VA: 0x2255E68 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2255E70 Offset: 0x2251E70 VA: 0x2255E70 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2255E78 Offset: 0x2251E78 VA: 0x2255E78 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2255E80 Offset: 0x2251E80 VA: 0x2255E80 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2255E88 Offset: 0x2251E88 VA: 0x2255E88 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2255E90 Offset: 0x2251E90 VA: 0x2255E90 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2255E98 Offset: 0x2251E98 VA: 0x2255E98 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2255EA0 Offset: 0x2251EA0 VA: 0x2255EA0 Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x2255EA8 Offset: 0x2251EA8 VA: 0x2255EA8 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x2255EB0 Offset: 0x2251EB0 VA: 0x2255EB0
	private void set_IsInheritance(bool value) { }

	// RVA: 0x2255EBC Offset: 0x2251EBC VA: 0x2255EBC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2256048 Offset: 0x2252048 VA: 0x2256048 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2256110 Offset: 0x2252110 VA: 0x2256110 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22561B8 Offset: 0x22521B8 VA: 0x22561B8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2256334 Offset: 0x2252334 VA: 0x2256334 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x2256340 Offset: 0x2252340 VA: 0x2256340
	public void .ctor() { }
}
