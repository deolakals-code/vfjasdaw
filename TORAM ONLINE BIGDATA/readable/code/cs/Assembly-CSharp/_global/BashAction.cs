// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BashAction : PlayerAttackBase, IInheritMindimageSenju, IAbnormalStateSkill // TypeDefIndex: 2795
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int stunPercent; // 0x12C

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

	// RVA: 0x2278D1C Offset: 0x2274D1C VA: 0x2278D1C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2278D24 Offset: 0x2274D24 VA: 0x2278D24 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2278D2C Offset: 0x2274D2C VA: 0x2278D2C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2278D34 Offset: 0x2274D34 VA: 0x2278D34 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2278D3C Offset: 0x2274D3C VA: 0x2278D3C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2278D44 Offset: 0x2274D44 VA: 0x2278D44 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2278D4C Offset: 0x2274D4C VA: 0x2278D4C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2278D54 Offset: 0x2274D54 VA: 0x2278D54 Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x2278D5C Offset: 0x2274D5C VA: 0x2278D5C Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x2278D64 Offset: 0x2274D64 VA: 0x2278D64
	private void set_IsInheritance(bool value) { }

	// RVA: 0x2278D70 Offset: 0x2274D70 VA: 0x2278D70 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2279164 Offset: 0x2275164 VA: 0x2279164 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2279228 Offset: 0x2275228 VA: 0x2279228 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22794E8 Offset: 0x22754E8 VA: 0x22794E8 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x227954C Offset: 0x227554C VA: 0x227954C Slot: 92
	public void OnInheritance() { }

	// RVA: 0x2279558 Offset: 0x2275558 VA: 0x2279558
	public void .ctor() { }
}
