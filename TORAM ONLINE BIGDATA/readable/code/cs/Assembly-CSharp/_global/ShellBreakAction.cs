// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShellBreakAction : PlayerAttackBase, IInheritMindimageSenju, IAbnormalStateSkill // TypeDefIndex: 2810
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int breakPercent; // 0x12C
	private int disDefParcent; // 0x130

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

	// RVA: 0x2284604 Offset: 0x2280604 VA: 0x2284604 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x228460C Offset: 0x228060C VA: 0x228460C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2284614 Offset: 0x2280614 VA: 0x2284614 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x228461C Offset: 0x228061C VA: 0x228461C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2284624 Offset: 0x2280624 VA: 0x2284624 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x228462C Offset: 0x228062C VA: 0x228462C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2284634 Offset: 0x2280634 VA: 0x2284634 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x228463C Offset: 0x228063C VA: 0x228463C Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x2284644 Offset: 0x2280644 VA: 0x2284644 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x228464C Offset: 0x228064C VA: 0x228464C
	private void set_IsInheritance(bool value) { }

	// RVA: 0x2284658 Offset: 0x2280658 VA: 0x2284658 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22849A4 Offset: 0x22809A4 VA: 0x22849A4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2284A6C Offset: 0x2280A6C VA: 0x2284A6C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2284F34 Offset: 0x2280F34 VA: 0x2284F34 Slot: 89
	public override void CheckAbnormalSubEffect(AbnormalType abnormalType, GameObject actor) { }

	// RVA: 0x2285014 Offset: 0x2281014 VA: 0x2285014 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2285078 Offset: 0x2281078 VA: 0x2285078 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x2285084 Offset: 0x2281084 VA: 0x2285084
	public void .ctor() { }
}
