// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class GeoImpactAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 2591
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private int skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private float range; // 0x12C
	private int breathingMethodHeal; // 0x130
	private int mpHeal; // 0x134
	private Vector3 targetPos; // 0x138

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public bool IsInheritance { get; set; }

	// Methods

	// RVA: 0x2204110 Offset: 0x2200110 VA: 0x2204110 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2204118 Offset: 0x2200118 VA: 0x2204118 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2204120 Offset: 0x2200120 VA: 0x2204120 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2204128 Offset: 0x2200128 VA: 0x2204128 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2204130 Offset: 0x2200130 VA: 0x2204130 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2204138 Offset: 0x2200138 VA: 0x2204138 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2204140 Offset: 0x2200140 VA: 0x2204140 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2204148 Offset: 0x2200148 VA: 0x2204148 Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x2204150 Offset: 0x2200150 VA: 0x2204150 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x2204158 Offset: 0x2200158 VA: 0x2204158
	private void set_IsInheritance(bool value) { }

	// RVA: 0x2204164 Offset: 0x2200164 VA: 0x2204164 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22043A0 Offset: 0x22003A0 VA: 0x22043A0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2204464 Offset: 0x2200464 VA: 0x2204464 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22045F0 Offset: 0x22005F0 VA: 0x22045F0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2204920 Offset: 0x2200920 VA: 0x2204920 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2204A7C Offset: 0x2200A7C VA: 0x2204A7C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2204C90 Offset: 0x2200C90 VA: 0x2204C90 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2204B9C Offset: 0x2200B9C VA: 0x2204B9C
	public void MpHeal(Vector3 position) { }

	// RVA: 0x2204FC4 Offset: 0x2200FC4 VA: 0x2204FC4 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x2204FD0 Offset: 0x2200FD0 VA: 0x2204FD0 Slot: 53
	protected override void OnEnd(bool cancel) { }

	// RVA: 0x2204FDC Offset: 0x2200FDC VA: 0x2204FDC
	public void .ctor() { }
}
