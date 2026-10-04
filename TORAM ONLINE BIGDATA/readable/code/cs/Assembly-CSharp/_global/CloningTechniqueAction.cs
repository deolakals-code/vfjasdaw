// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CloningTechniqueAction : NinjaSkillBase // TypeDefIndex: 2905
{
	// Fields
	[CompilerGenerated]
	private Vector3 <PlacePos>k__BackingField; // 0x124
	private const int MaxStopTime = 3;
	private readonly float AttackPermissionRange; // 0x130
	private readonly float SkillStopRange; // 0x134
	private int baseMp; // 0x138
	private float skillRate; // 0x13C
	private float delayTime; // 0x140
	private CharacterActionManagerBase actionManager; // 0x148
	private Dictionary<int, byte> targetExpList; // 0x150
	private int takeEventId; // 0x158
	private int stopTime; // 0x15C
	private bool moveCheck; // 0x160
	private ItemDBData.ItemType subWeaponType; // 0x164
	private bool wallMove; // 0x168
	private bool wallWait; // 0x169
	private bool checkMobDist; // 0x16A
	private bool wallOverAttackRange; // 0x16B
	private bool checkShukuchiSkip; // 0x16C
	private bool checkWallMoved; // 0x16D
	private bool shukuchi; // 0x16E

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsExpDefFluctuate { get; }
	public Vector3 PlacePos { get; set; }
	public override SkillChargingType ChargingType { get; }
	public override bool IsHideAttackApplied { get; }
	public override bool NoCost { get; }

	// Methods

	// RVA: 0x22C860C Offset: 0x22C460C VA: 0x22C860C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22C8614 Offset: 0x22C4614 VA: 0x22C8614 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22C861C Offset: 0x22C461C VA: 0x22C861C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22C8624 Offset: 0x22C4624 VA: 0x22C8624 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22C862C Offset: 0x22C462C VA: 0x22C862C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22C8634 Offset: 0x22C4634 VA: 0x22C8634 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22C863C Offset: 0x22C463C VA: 0x22C863C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22C8644 Offset: 0x22C4644 VA: 0x22C8644 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22C864C Offset: 0x22C464C VA: 0x22C864C Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	[CompilerGenerated]
	// RVA: 0x22C8654 Offset: 0x22C4654 VA: 0x22C8654
	public Vector3 get_PlacePos() { }

	[CompilerGenerated]
	// RVA: 0x22C8664 Offset: 0x22C4664 VA: 0x22C8664
	private void set_PlacePos(Vector3 value) { }

	// RVA: 0x22C8674 Offset: 0x22C4674 VA: 0x22C8674 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x22C867C Offset: 0x22C467C VA: 0x22C867C Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x22C8684 Offset: 0x22C4684 VA: 0x22C8684 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22C868C Offset: 0x22C468C VA: 0x22C868C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22C894C Offset: 0x22C494C VA: 0x22C894C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22C8EC4 Offset: 0x22C4EC4 VA: 0x22C8EC4 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22C8EF8 Offset: 0x22C4EF8 VA: 0x22C8EF8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22C930C Offset: 0x22C530C VA: 0x22C930C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22C94AC Offset: 0x22C54AC VA: 0x22C94AC Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x22C9594 Offset: 0x22C5594 VA: 0x22C9594
	public Vector3 GetCloningEffectPos() { }

	// RVA: 0x22C9654 Offset: 0x22C5654 VA: 0x22C9654 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22C997C Offset: 0x22C597C VA: 0x22C997C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22CACE4 Offset: 0x22C6CE4 VA: 0x22CACE4 Slot: 50
	public override bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22CAE24 Offset: 0x22C6E24 VA: 0x22CAE24 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22CAEA0 Offset: 0x22C6EA0 VA: 0x22CAEA0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22CB124 Offset: 0x22C7124 VA: 0x22CB124 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x22C8BE8 Offset: 0x22C4BE8 VA: 0x22C8BE8
	private void CreateTake() { }

	// RVA: 0x22CB2E8 Offset: 0x22C72E8 VA: 0x22CB2E8
	private int CreateEffectTakeId() { }

	// RVA: 0x22CB3A0 Offset: 0x22C73A0 VA: 0x22CB3A0
	public void .ctor() { }
}
