// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicBalkanAction : PlayerAttackBase // TypeDefIndex: 3039
{
	// Fields
	private int skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private SkillLinkedTake current; // 0x128
	private PlayerActionManagerBase playerAction; // 0x130
	private int damageCount; // 0x138
	private bool isHit; // 0x13C
	private int targetSize; // 0x140
	private bool isComboEffect; // 0x144
	private bool otherNextAction; // 0x145
	private bool isEnd; // 0x146
	private bool interruptable; // 0x147
	private bool isFirstMagicBalkanCharge; // 0x148

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

	// Methods

	// RVA: 0x230F6A0 Offset: 0x230B6A0 VA: 0x230F6A0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x230F6A8 Offset: 0x230B6A8 VA: 0x230F6A8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x230F6B0 Offset: 0x230B6B0 VA: 0x230F6B0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x230F6B8 Offset: 0x230B6B8 VA: 0x230F6B8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x230F6C0 Offset: 0x230B6C0 VA: 0x230F6C0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x230F6C8 Offset: 0x230B6C8 VA: 0x230F6C8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x230F6D0 Offset: 0x230B6D0 VA: 0x230F6D0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x230F6D8 Offset: 0x230B6D8 VA: 0x230F6D8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x230F6E0 Offset: 0x230B6E0 VA: 0x230F6E0 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x230F6E8 Offset: 0x230B6E8 VA: 0x230F6E8 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x230F6F0 Offset: 0x230B6F0 VA: 0x230F6F0 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x230F6F8 Offset: 0x230B6F8 VA: 0x230F6F8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x230F7DC Offset: 0x230B7DC VA: 0x230F7DC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x230F98C Offset: 0x230B98C VA: 0x230F98C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x230FCAC Offset: 0x230BCAC VA: 0x230FCAC Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23104D0 Offset: 0x230C4D0 VA: 0x23104D0 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2310684 Offset: 0x230C684 VA: 0x2310684 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2310784 Offset: 0x230C784 VA: 0x2310784 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2310A10 Offset: 0x230CA10 VA: 0x2310A10 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2310CA0 Offset: 0x230CCA0 VA: 0x2310CA0
	public bool CheckComboEffect() { }

	// RVA: 0x230F818 Offset: 0x230B818 VA: 0x230F818
	private void CreateTake() { }

	// RVA: 0x2310CA8 Offset: 0x230CCA8 VA: 0x2310CA8 Slot: 54
	protected override void OnMotionEnd() { }

	// RVA: 0x2310D9C Offset: 0x230CD9C VA: 0x2310D9C Slot: 53
	protected override void OnEnd(bool cancel) { }

	// RVA: 0x2310E88 Offset: 0x230CE88 VA: 0x2310E88
	public void .ctor() { }
}
