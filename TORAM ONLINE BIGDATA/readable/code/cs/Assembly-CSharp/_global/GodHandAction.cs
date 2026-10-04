// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GodHandAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 2593
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

	// RVA: 0x2205004 Offset: 0x2201004 VA: 0x2205004 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x220500C Offset: 0x220100C VA: 0x220500C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2205014 Offset: 0x2201014 VA: 0x2205014 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x220501C Offset: 0x220101C VA: 0x220501C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2205024 Offset: 0x2201024 VA: 0x2205024 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x220502C Offset: 0x220102C VA: 0x220502C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2205034 Offset: 0x2201034 VA: 0x2205034 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x220503C Offset: 0x220103C VA: 0x220503C Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x2205044 Offset: 0x2201044 VA: 0x2205044 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x220504C Offset: 0x220104C VA: 0x220504C
	private void set_IsInheritance(bool value) { }

	// RVA: 0x2205058 Offset: 0x2201058 VA: 0x2205058 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22051B0 Offset: 0x22011B0 VA: 0x22051B0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2205274 Offset: 0x2201274 VA: 0x2205274 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22053E0 Offset: 0x22013E0 VA: 0x22053E0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2205898 Offset: 0x2201898 VA: 0x2205898 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2205A60 Offset: 0x2201A60 VA: 0x2205A60 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2205C20 Offset: 0x2201C20 VA: 0x2205C20 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2205E94 Offset: 0x2201E94 VA: 0x2205E94 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x2205EA0 Offset: 0x2201EA0 VA: 0x2205EA0
	public void .ctor() { }
}
