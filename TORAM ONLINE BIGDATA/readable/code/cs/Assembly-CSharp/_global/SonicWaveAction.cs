// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SonicWaveAction : PlayerAttackBase, IInheritMindimageSenju, IAbnormalStateSkill // TypeDefIndex: 2815
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int tumblePercent; // 0x12C

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

	// RVA: 0x2287938 Offset: 0x2283938 VA: 0x2287938 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2287940 Offset: 0x2283940 VA: 0x2287940 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2287948 Offset: 0x2283948 VA: 0x2287948 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2287950 Offset: 0x2283950 VA: 0x2287950 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2287958 Offset: 0x2283958 VA: 0x2287958 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2287960 Offset: 0x2283960 VA: 0x2287960 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2287968 Offset: 0x2283968 VA: 0x2287968 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2287970 Offset: 0x2283970 VA: 0x2287970 Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x2287978 Offset: 0x2283978 VA: 0x2287978 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x2287980 Offset: 0x2283980 VA: 0x2287980
	private void set_IsInheritance(bool value) { }

	// RVA: 0x228798C Offset: 0x228398C VA: 0x228798C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2287CD0 Offset: 0x2283CD0 VA: 0x2287CD0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2287E04 Offset: 0x2283E04 VA: 0x2287E04 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2287F50 Offset: 0x2283F50 VA: 0x2287F50 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2288254 Offset: 0x2284254 VA: 0x2288254 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x227F28C Offset: 0x227B28C VA: 0x227F28C
	public static int CreateEventTakeId(ElementType element) { }

	// RVA: 0x22882B8 Offset: 0x22842B8 VA: 0x22882B8 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x22882C4 Offset: 0x22842C4 VA: 0x22882C4
	public void .ctor() { }
}
