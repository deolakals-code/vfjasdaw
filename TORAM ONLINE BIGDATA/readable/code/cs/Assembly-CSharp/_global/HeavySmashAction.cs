// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HeavySmashAction : PlayerAttackBase, IInheritMindimageSenju, IAbnormalStateSkill // TypeDefIndex: 2802
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private float baseSkillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int weakPercent; // 0x12C
	private int powerRegisterBreaker; // 0x130

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

	// RVA: 0x227C394 Offset: 0x2278394 VA: 0x227C394 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x227C39C Offset: 0x227839C VA: 0x227C39C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x227C3A4 Offset: 0x22783A4 VA: 0x227C3A4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x227C3AC Offset: 0x22783AC VA: 0x227C3AC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x227C3B4 Offset: 0x22783B4 VA: 0x227C3B4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x227C3BC Offset: 0x22783BC VA: 0x227C3BC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x227C3C4 Offset: 0x22783C4 VA: 0x227C3C4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x227C3CC Offset: 0x22783CC VA: 0x227C3CC Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x227C3D4 Offset: 0x22783D4 VA: 0x227C3D4 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x227C3DC Offset: 0x22783DC VA: 0x227C3DC
	private void set_IsInheritance(bool value) { }

	// RVA: 0x227C3E8 Offset: 0x22783E8 VA: 0x227C3E8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x227C624 Offset: 0x2278624 VA: 0x227C624 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x227C6EC Offset: 0x22786EC VA: 0x227C6EC Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x227CE20 Offset: 0x2278E20 VA: 0x227CE20 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x227CE84 Offset: 0x2278E84 VA: 0x227CE84 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x227CE90 Offset: 0x2278E90 VA: 0x227CE90
	public void .ctor() { }
}
