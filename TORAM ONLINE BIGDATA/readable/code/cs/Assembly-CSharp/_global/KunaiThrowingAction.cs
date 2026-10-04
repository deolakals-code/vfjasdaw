// Assembly: Assembly-CSharp.dll
// Namespace: 
public class KunaiThrowingAction : NinjaSkillBase // TypeDefIndex: 2915
{
	// Fields
	private bool interruptable; // 0x121
	private PlayerActionManagerBase playerAction; // 0x128
	private int baseMp; // 0x130
	private float skillRate; // 0x134
	private Dictionary<int, byte> targetExpLit; // 0x138
	private bool isHit; // 0x140
	private bool isExpDefFluctuate; // 0x141
	private SkillLinkedTake current; // 0x148
	private int damageCount; // 0x150
	private int targetSize; // 0x154
	private bool isComboEffect; // 0x158
	private bool otherNextAction; // 0x159
	private float attackStartTime; // 0x15C
	private Vector3 startPos; // 0x160
	private Transform actorTransform; // 0x170
	private Transform skinRootBone; // 0x178

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override SkillChargingType ChargingType { get; }
	public override bool IsHideAttackApplied { get; }
	public override bool IsExpDefFluctuate { get; }
	public override bool NoCost { get; }

	// Methods

	// RVA: 0x22CE66C Offset: 0x22CA66C VA: 0x22CE66C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22CE674 Offset: 0x22CA674 VA: 0x22CE674 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22CE67C Offset: 0x22CA67C VA: 0x22CE67C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22CE684 Offset: 0x22CA684 VA: 0x22CE684 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22CE68C Offset: 0x22CA68C VA: 0x22CE68C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22CE694 Offset: 0x22CA694 VA: 0x22CE694 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22CE69C Offset: 0x22CA69C VA: 0x22CE69C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22CE6A4 Offset: 0x22CA6A4 VA: 0x22CE6A4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22CE6AC Offset: 0x22CA6AC VA: 0x22CE6AC Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x22CE6B4 Offset: 0x22CA6B4 VA: 0x22CE6B4 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x22CE6BC Offset: 0x22CA6BC VA: 0x22CE6BC Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x22CE6C4 Offset: 0x22CA6C4 VA: 0x22CE6C4 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22CE6CC Offset: 0x22CA6CC VA: 0x22CE6CC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22CE82C Offset: 0x22CA82C VA: 0x22CE82C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22CEC18 Offset: 0x22CAC18 VA: 0x22CEC18 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22CEE34 Offset: 0x22CAE34 VA: 0x22CEE34 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22CF53C Offset: 0x22CB53C VA: 0x22CF53C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22CF6F0 Offset: 0x22CB6F0 VA: 0x22CF6F0 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22CF778 Offset: 0x22CB778 VA: 0x22CF778 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22CFE20 Offset: 0x22CBE20 VA: 0x22CFE20 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22D0088 Offset: 0x22CC088 VA: 0x22D0088
	public bool CheckComboEffect() { }

	// RVA: 0x22CEA10 Offset: 0x22CAA10 VA: 0x22CEA10
	private void CreateTake() { }

	// RVA: 0x22CF178 Offset: 0x22CB178 VA: 0x22CF178
	private void SetEffectPos(SkillLinkedTake take) { }

	// RVA: 0x22D0090 Offset: 0x22CC090 VA: 0x22D0090
	public void .ctor() { }
}
