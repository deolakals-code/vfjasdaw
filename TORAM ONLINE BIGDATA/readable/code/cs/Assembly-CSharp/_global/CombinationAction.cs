// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CombinationAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 2584
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private int critical; // 0x128

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

	// RVA: 0x2200EA0 Offset: 0x21FCEA0 VA: 0x2200EA0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2200EA8 Offset: 0x21FCEA8 VA: 0x2200EA8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2200EB0 Offset: 0x21FCEB0 VA: 0x2200EB0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2200EB8 Offset: 0x21FCEB8 VA: 0x2200EB8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2200EC0 Offset: 0x21FCEC0 VA: 0x2200EC0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2200EC8 Offset: 0x21FCEC8 VA: 0x2200EC8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2200ED0 Offset: 0x21FCED0 VA: 0x2200ED0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2200ED8 Offset: 0x21FCED8 VA: 0x2200ED8 Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x2200EE0 Offset: 0x21FCEE0 VA: 0x2200EE0 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x2200EE8 Offset: 0x21FCEE8 VA: 0x2200EE8
	private void set_IsInheritance(bool value) { }

	// RVA: 0x2200EF4 Offset: 0x21FCEF4 VA: 0x2200EF4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2201000 Offset: 0x21FD000 VA: 0x2201000 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22010C4 Offset: 0x21FD0C4 VA: 0x22010C4 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2201230 Offset: 0x21FD230 VA: 0x2201230 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22012F8 Offset: 0x21FD2F8 VA: 0x22012F8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22016B4 Offset: 0x21FD6B4 VA: 0x22016B4 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x22016C0 Offset: 0x21FD6C0 VA: 0x22016C0
	public void .ctor() { }
}
