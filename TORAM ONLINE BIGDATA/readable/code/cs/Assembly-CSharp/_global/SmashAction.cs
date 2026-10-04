// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmashAction : PlayerAttackBase, IInheritMindimageSenju, IAbnormalStateSkill // TypeDefIndex: 2814
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int flinchPercent; // 0x12C

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

	// RVA: 0x228717C Offset: 0x228317C VA: 0x228717C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2287184 Offset: 0x2283184 VA: 0x2287184 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x228718C Offset: 0x228318C VA: 0x228718C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2287194 Offset: 0x2283194 VA: 0x2287194 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x228719C Offset: 0x228319C VA: 0x228719C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22871A4 Offset: 0x22831A4 VA: 0x22871A4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22871AC Offset: 0x22831AC VA: 0x22871AC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22871B4 Offset: 0x22831B4 VA: 0x22871B4 Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x22871BC Offset: 0x22831BC VA: 0x22871BC Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x22871C4 Offset: 0x22831C4 VA: 0x22871C4
	private void set_IsInheritance(bool value) { }

	// RVA: 0x22871D0 Offset: 0x22831D0 VA: 0x22871D0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22874E4 Offset: 0x22834E4 VA: 0x22874E4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22875AC Offset: 0x22835AC VA: 0x22875AC Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22878B0 Offset: 0x22838B0 VA: 0x22878B0 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2287914 Offset: 0x2283914 VA: 0x2287914 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x2287920 Offset: 0x2283920 VA: 0x2287920
	public void .ctor() { }
}
