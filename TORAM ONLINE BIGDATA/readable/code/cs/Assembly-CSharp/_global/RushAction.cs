// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RushAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 2807
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private bool isKnuckle; // 0x12C
	private readonly byte maxAttackCount; // 0x12D

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public bool IsInheritance { get; set; }

	// Methods

	// RVA: 0x2282CE4 Offset: 0x227ECE4 VA: 0x2282CE4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2282CEC Offset: 0x227ECEC VA: 0x2282CEC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2282CF4 Offset: 0x227ECF4 VA: 0x2282CF4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2282CFC Offset: 0x227ECFC VA: 0x2282CFC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2282D04 Offset: 0x227ED04 VA: 0x2282D04 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2282D0C Offset: 0x227ED0C VA: 0x2282D0C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2282D14 Offset: 0x227ED14 VA: 0x2282D14 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2282D1C Offset: 0x227ED1C VA: 0x2282D1C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	[CompilerGenerated]
	// RVA: 0x2282D24 Offset: 0x227ED24 VA: 0x2282D24 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x2282D2C Offset: 0x227ED2C VA: 0x2282D2C
	private void set_IsInheritance(bool value) { }

	// RVA: 0x2282D38 Offset: 0x227ED38 VA: 0x2282D38 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2282F48 Offset: 0x227EF48 VA: 0x2282F48 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x228300C Offset: 0x227F00C VA: 0x228300C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2283160 Offset: 0x227F160 VA: 0x2283160 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22833E4 Offset: 0x227F3E4 VA: 0x22833E4 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x22833F0 Offset: 0x227F3F0 VA: 0x22833F0
	public void .ctor() { }
}
