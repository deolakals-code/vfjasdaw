// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ChariotAction : PlayerAttackBase, IInheritMindimageSenju, IAbnormalStateSkill // TypeDefIndex: 2797
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	[CompilerGenerated]
	private bool <Attacked>k__BackingField; // 0x121
	private float skillRate; // 0x124
	private float fixAddDamage; // 0x128
	private readonly int maxDamageCount; // 0x12C
	private int abnormalPercent; // 0x130
	private bool isRange; // 0x134
	private Vector3 attackDirection; // 0x138
	private readonly float range; // 0x144

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
	public bool Attacked { get; set; }

	// Methods

	// RVA: 0x2279570 Offset: 0x2275570 VA: 0x2279570 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2279578 Offset: 0x2275578 VA: 0x2279578 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2279580 Offset: 0x2275580 VA: 0x2279580 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2279588 Offset: 0x2275588 VA: 0x2279588 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2279590 Offset: 0x2275590 VA: 0x2279590 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2279598 Offset: 0x2275598 VA: 0x2279598 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22795A0 Offset: 0x22755A0 VA: 0x22795A0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22795A8 Offset: 0x22755A8 VA: 0x22795A8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	[CompilerGenerated]
	// RVA: 0x22795B0 Offset: 0x22755B0 VA: 0x22795B0 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x22795B8 Offset: 0x22755B8 VA: 0x22795B8
	private void set_IsInheritance(bool value) { }

	[CompilerGenerated]
	// RVA: 0x22795C4 Offset: 0x22755C4 VA: 0x22795C4
	public bool get_Attacked() { }

	[CompilerGenerated]
	// RVA: 0x22795CC Offset: 0x22755CC VA: 0x22795CC
	private void set_Attacked(bool value) { }

	// RVA: 0x22795D8 Offset: 0x22755D8 VA: 0x22795D8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2279AC0 Offset: 0x2275AC0 VA: 0x2279AC0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2279AD8 Offset: 0x2275AD8 VA: 0x2279AD8 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x2279C44 Offset: 0x2275C44 VA: 0x2279C44 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2279D1C Offset: 0x2275D1C VA: 0x2279D1C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2279DF4 Offset: 0x2275DF4 VA: 0x2279DF4 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2279E70 Offset: 0x2275E70 VA: 0x2279E70 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x227A1EC Offset: 0x22761EC VA: 0x227A1EC Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22799DC Offset: 0x22759DC VA: 0x22799DC
	public static int[] GetElementToColor(ElementType element) { }

	// RVA: 0x227A250 Offset: 0x2276250 VA: 0x227A250 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x227A25C Offset: 0x227625C VA: 0x227A25C
	public void .ctor() { }
}
