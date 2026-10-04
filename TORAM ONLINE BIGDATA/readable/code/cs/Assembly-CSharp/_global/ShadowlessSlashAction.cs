// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShadowlessSlashAction : PlayerAttackBase, ISwordMove // TypeDefIndex: 2858
{
	// Fields
	[CompilerGenerated]
	private bool <IsSwordMoveStart>k__BackingField; // 0x120
	private const int MaxAttackCount = 5;
	private float skillRate; // 0x124
	private int constantDamage; // 0x128
	private Dictionary<MobActionManagerBase, byte> targetExpList; // 0x130
	private bool shadowless; // 0x138
	private float moveAngle; // 0x13C
	private bool inputValie; // 0x140

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsEventIgnoreOther { get; }
	public bool IsSwordMoveStart { get; set; }
	public override bool IsMoveAssistContinue { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }

	// Methods

	// RVA: 0x229DBA8 Offset: 0x2299BA8 VA: 0x229DBA8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x229DBB0 Offset: 0x2299BB0 VA: 0x229DBB0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x229DBB8 Offset: 0x2299BB8 VA: 0x229DBB8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x229DBC0 Offset: 0x2299BC0 VA: 0x229DBC0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x229DBC8 Offset: 0x2299BC8 VA: 0x229DBC8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x229DBD0 Offset: 0x2299BD0 VA: 0x229DBD0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x229DBD8 Offset: 0x2299BD8 VA: 0x229DBD8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x229DBE0 Offset: 0x2299BE0 VA: 0x229DBE0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x229DBE8 Offset: 0x2299BE8 VA: 0x229DBE8 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	[CompilerGenerated]
	// RVA: 0x229DBF0 Offset: 0x2299BF0 VA: 0x229DBF0 Slot: 91
	public bool get_IsSwordMoveStart() { }

	[CompilerGenerated]
	// RVA: 0x229DBF8 Offset: 0x2299BF8 VA: 0x229DBF8
	private void set_IsSwordMoveStart(bool value) { }

	// RVA: 0x229DC04 Offset: 0x2299C04 VA: 0x229DC04 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x229DC1C Offset: 0x2299C1C VA: 0x229DC1C Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x229DC24 Offset: 0x2299C24 VA: 0x229DC24 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x229DC2C Offset: 0x2299C2C VA: 0x229DC2C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x229DEA0 Offset: 0x2299EA0 VA: 0x229DEA0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x229E0B8 Offset: 0x229A0B8 VA: 0x229E0B8 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x229EBF0 Offset: 0x229ABF0 VA: 0x229EBF0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x229EF60 Offset: 0x229AF60 VA: 0x229EF60 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x229F080 Offset: 0x229B080 VA: 0x229F080 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x229F16C Offset: 0x229B16C VA: 0x229F16C
	public void .ctor() { }
}
