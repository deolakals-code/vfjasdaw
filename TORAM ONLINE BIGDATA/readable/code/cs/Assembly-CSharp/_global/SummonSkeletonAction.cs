// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummonSkeletonAction : PlayerAttackBase, IPlaceSkill // TypeDefIndex: 2899
{
	// Fields
	public static int MaxSkeletonNum; // 0x0
	[CompilerGenerated]
	private Vector3 <PlacePos>k__BackingField; // 0x120
	[CompilerGenerated]
	private bool <UpperLimit>k__BackingField; // 0x12C
	[CompilerGenerated]
	private bool <Duplicate>k__BackingField; // 0x12D
	private readonly int useStack; // 0x130
	private readonly float AttackRange; // 0x134
	private readonly float AttackPermissionRange; // 0x138
	private readonly float WarpRange; // 0x13C
	private readonly float moveSpeed; // 0x140
	private CharacterActionManagerBase actionManager; // 0x148
	private int skillRate; // 0x150
	private float delayTime; // 0x154
	private float attackCoolTimer; // 0x158
	private SummonSkeletonAction.ModeChangeCheck changeCheck; // 0x15C
	private bool isHarvest; // 0x160
	private SkillLinkedTake eventTake; // 0x168
	private Vector3 movePos; // 0x170
	private List<Vector3> routePositionList; // 0x180
	private int routeIndex; // 0x188
	private bool isMoveEnd; // 0x18C
	private bool isCollisionWall; // 0x18D
	private EffectMove effectMove; // 0x190
	private bool isFollowPlayer; // 0x198
	private float followRange; // 0x19C
	private float followStartRange; // 0x1A0
	private float failureTimer; // 0x1A4

	// Properties
	public override SkillAttackType AttackType { get; }
	public override SkillAttackType ExpType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public Vector3 PlacePos { get; set; }
	public override SkillChargingType ChargingType { get; }
	public override bool IsNoMotionTake { get; }
	public override bool NoCost { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsExpDefFluctuate { get; }
	protected override bool IsRangeEquipBonus { get; }
	public bool UpperLimit { get; set; }
	public bool Duplicate { get; set; }

	// Methods

	// RVA: 0x22C1740 Offset: 0x22BD740 VA: 0x22C1740 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22C1748 Offset: 0x22BD748 VA: 0x22C1748 Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x22C1750 Offset: 0x22BD750 VA: 0x22C1750 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22C1758 Offset: 0x22BD758 VA: 0x22C1758 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22C1760 Offset: 0x22BD760 VA: 0x22C1760 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22C1770 Offset: 0x22BD770 VA: 0x22C1770 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22C1778 Offset: 0x22BD778 VA: 0x22C1778 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22C1780 Offset: 0x22BD780 VA: 0x22C1780 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22C1788 Offset: 0x22BD788 VA: 0x22C1788 Slot: 23
	public override int get_BaseMp() { }

	[CompilerGenerated]
	// RVA: 0x22C1790 Offset: 0x22BD790 VA: 0x22C1790
	public Vector3 get_PlacePos() { }

	[CompilerGenerated]
	// RVA: 0x22C17A0 Offset: 0x22BD7A0 VA: 0x22C17A0
	private void set_PlacePos(Vector3 value) { }

	// RVA: 0x22C17B0 Offset: 0x22BD7B0 VA: 0x22C17B0 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x22C17B8 Offset: 0x22BD7B8 VA: 0x22C17B8 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x22C17C0 Offset: 0x22BD7C0 VA: 0x22C17C0 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22C17C8 Offset: 0x22BD7C8 VA: 0x22C17C8 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x22C17E0 Offset: 0x22BD7E0 VA: 0x22C17E0 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x22C17E8 Offset: 0x22BD7E8 VA: 0x22C17E8 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	[CompilerGenerated]
	// RVA: 0x22C17F0 Offset: 0x22BD7F0 VA: 0x22C17F0 Slot: 91
	public bool get_UpperLimit() { }

	[CompilerGenerated]
	// RVA: 0x22C17F8 Offset: 0x22BD7F8 VA: 0x22C17F8 Slot: 92
	public void set_UpperLimit(bool value) { }

	[CompilerGenerated]
	// RVA: 0x22C1804 Offset: 0x22BD804 VA: 0x22C1804 Slot: 93
	public bool get_Duplicate() { }

	[CompilerGenerated]
	// RVA: 0x22C180C Offset: 0x22BD80C VA: 0x22C180C Slot: 94
	public void set_Duplicate(bool value) { }

	// RVA: 0x22C1818 Offset: 0x22BD818 VA: 0x22C1818 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22C1918 Offset: 0x22BD918 VA: 0x22C1918
	public void SetHarvest() { }

	// RVA: 0x22C1924 Offset: 0x22BD924 VA: 0x22C1924 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22C1E58 Offset: 0x22BDE58 VA: 0x22C1E58 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x22C1EFC Offset: 0x22BDEFC VA: 0x22C1EFC Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22C20AC Offset: 0x22BE0AC VA: 0x22C20AC Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22C219C Offset: 0x22BE19C VA: 0x22C219C Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x22C22F0 Offset: 0x22BE2F0 VA: 0x22C22F0
	public Vector3 GetSkeletonMovePos() { }

	// RVA: 0x22C2300 Offset: 0x22BE300 VA: 0x22C2300 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22C2784 Offset: 0x22BE784 VA: 0x22C2784 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22C5048 Offset: 0x22C1048 VA: 0x22C5048 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22C50C4 Offset: 0x22C10C4 VA: 0x22C50C4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22C5494 Offset: 0x22C1494 VA: 0x22C5494 Slot: 86
	protected override int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x22C5830 Offset: 0x22C1830 VA: 0x22C5830 Slot: 50
	public override bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22C1CB0 Offset: 0x22BDCB0 VA: 0x22C1CB0
	private void CreateTake() { }

	// RVA: 0x22C1A20 Offset: 0x22BDA20 VA: 0x22C1A20
	private void SetPlacePos() { }

	// RVA: 0x22C4C8C Offset: 0x22C0C8C VA: 0x22C4C8C
	private Vector3 GetNearPlayerPosition() { }

	// RVA: 0x22C4A84 Offset: 0x22C0A84 VA: 0x22C4A84
	private void SkeletonLookTarget() { }

	// RVA: 0x22C3E0C Offset: 0x22BFE0C VA: 0x22C3E0C
	private Vector3 GetTargetMovePos(Vector3 startPos, Vector3 targetPos, float targetSize) { }

	// RVA: 0x22C2690 Offset: 0x22BE690 VA: 0x22C2690
	private bool CheckMainTargetInRange(Vector3 pos, float range) { }

	// RVA: 0x22C5940 Offset: 0x22C1940 VA: 0x22C5940
	private void OnEndMoveAction() { }

	// RVA: 0x22C5B04 Offset: 0x22C1B04 VA: 0x22C5B04
	private void OnEndMoveFollow() { }

	// RVA: 0x22C63A0 Offset: 0x22C23A0 VA: 0x22C63A0
	public void .ctor() { }

	// RVA: 0x22C6488 Offset: 0x22C2488 VA: 0x22C6488
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x22C64D4 Offset: 0x22C24D4 VA: 0x22C64D4
	private void <ActionSkillEvent>b__76_0() { }

	[CompilerGenerated]
	// RVA: 0x22C64DC Offset: 0x22C24DC VA: 0x22C64DC
	private void <ActionSkillEvent>b__76_1() { }

	[CompilerGenerated]
	// RVA: 0x22C64E4 Offset: 0x22C24E4 VA: 0x22C64E4
	private bool <GetTargetMovePos>b__85_0(SkillActionBase s) { }

	[CompilerGenerated]
	// RVA: 0x22C6538 Offset: 0x22C2538 VA: 0x22C6538
	private void <OnEndMoveFollow>b__88_0() { }

	[CompilerGenerated]
	// RVA: 0x22C6540 Offset: 0x22C2540 VA: 0x22C6540
	private void <OnEndMoveFollow>b__88_1() { }

	[CompilerGenerated]
	// RVA: 0x22C6548 Offset: 0x22C2548 VA: 0x22C6548
	private void <OnEndMoveFollow>b__88_2() { }
}
