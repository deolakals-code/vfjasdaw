// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HassohappaAction : PlayerAttackBase, ISwordMove // TypeDefIndex: 2831
{
	// Fields
	[CompilerGenerated]
	private bool <IsSwordMoveStart>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private float fixAddDamage; // 0x128
	private int damageCount; // 0x12C
	private bool isFirstAttck; // 0x130
	private float firstRadius; // 0x134
	private float secondRadius; // 0x138
	private Vector3 placePosition; // 0x13C
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x148
	private bool change; // 0x150

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsMove { get; }
	public bool IsSwordMoveStart { get; set; }
	public override bool IsMoveAssistContinue { get; }
	public override string LocalizeKey { get; }
	protected override bool IsRangeSkillBonus { get; }
	protected override bool IsRangeEquipBonus { get; }

	// Methods

	// RVA: 0x228F904 Offset: 0x228B904 VA: 0x228F904 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x228F90C Offset: 0x228B90C VA: 0x228F90C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x228F914 Offset: 0x228B914 VA: 0x228F914 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x228F91C Offset: 0x228B91C VA: 0x228F91C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x228F924 Offset: 0x228B924 VA: 0x228F924 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x228F92C Offset: 0x228B92C VA: 0x228F92C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x228F934 Offset: 0x228B934 VA: 0x228F934 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x228F93C Offset: 0x228B93C VA: 0x228F93C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x228F944 Offset: 0x228B944 VA: 0x228F944 Slot: 28
	public override bool get_IsMove() { }

	[CompilerGenerated]
	// RVA: 0x228F94C Offset: 0x228B94C VA: 0x228F94C Slot: 91
	public bool get_IsSwordMoveStart() { }

	[CompilerGenerated]
	// RVA: 0x228F954 Offset: 0x228B954 VA: 0x228F954
	private void set_IsSwordMoveStart(bool value) { }

	// RVA: 0x228F960 Offset: 0x228B960 VA: 0x228F960 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x228F978 Offset: 0x228B978 VA: 0x228F978 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x228F9E4 Offset: 0x228B9E4 VA: 0x228F9E4 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x228F9EC Offset: 0x228B9EC VA: 0x228F9EC Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x228F9F4 Offset: 0x228B9F4 VA: 0x228F9F4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x228FD40 Offset: 0x228BD40 VA: 0x228FD40 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x228FF38 Offset: 0x228BF38 VA: 0x228FF38 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2290108 Offset: 0x228C108 VA: 0x2290108 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x229017C Offset: 0x228C17C VA: 0x229017C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22907C4 Offset: 0x228C7C4 VA: 0x22907C4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2290D8C Offset: 0x228CD8C VA: 0x2290D8C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2290E90 Offset: 0x228CE90 VA: 0x2290E90
	public void .ctor() { }
}
