// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WideSpreadAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 3017
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private AbnormalType mainAbnormalType; // 0x128
	private AbnormalType subAbnormalType; // 0x12C
	private int abnormalPercent; // 0x130
	private Dictionary<MobActionManagerBase, WideSpreadAction.HitData> targetExpList; // 0x138
	private WideSpreadAction.AttackMode attackMode; // 0x140
	private int attackArrowNumber; // 0x144
	private GameObject mainTarget; // 0x148
	private Vector3 mainTargetPos; // 0x150
	private Vector3 attackDir; // 0x15C
	private bool isMoveStop; // 0x168
	private float skillStartTime; // 0x16C
	private float prevElapsedTime; // 0x170
	private WideSpreadAction.CurveMove curveMove; // 0x178
	private byte pursuitJumpbackShotCount; // 0x180

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

	// Methods

	// RVA: 0x23011A8 Offset: 0x22FD1A8 VA: 0x23011A8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23011B0 Offset: 0x22FD1B0 VA: 0x23011B0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23011B8 Offset: 0x22FD1B8 VA: 0x23011B8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23011C0 Offset: 0x22FD1C0 VA: 0x23011C0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23011C8 Offset: 0x22FD1C8 VA: 0x23011C8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23011D0 Offset: 0x22FD1D0 VA: 0x23011D0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23011D8 Offset: 0x22FD1D8 VA: 0x23011D8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23011E0 Offset: 0x22FD1E0 VA: 0x23011E0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23011E8 Offset: 0x22FD1E8 VA: 0x23011E8 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x23011F0 Offset: 0x22FD1F0 VA: 0x23011F0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x230149C Offset: 0x22FD49C VA: 0x230149C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2302638 Offset: 0x22FE638 VA: 0x2302638 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x230340C Offset: 0x22FF40C VA: 0x230340C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2303AB0 Offset: 0x22FFAB0 VA: 0x2303AB0 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2303B2C Offset: 0x22FFB2C VA: 0x2303B2C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2304070 Offset: 0x2300070 VA: 0x2304070
	private void CalcAbnormal(WideSpreadAction.HitData data, SkillDamageData damageData, PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x23041E8 Offset: 0x23001E8 VA: 0x23041E8 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2301478 Offset: 0x22FD478 VA: 0x2301478
	private AbnormalType GetAbnormalType(ElementType element) { }

	// RVA: 0x2302200 Offset: 0x22FE200 VA: 0x2302200
	private SkillLinkedTake CreateTake(ItemDBData.ItemType weaponType, ElementType element, WideSpreadAction.AttackMode mode) { }

	// RVA: 0x2304260 Offset: 0x2300260 VA: 0x2304260
	public bool CheckPursuitJumpbackShot() { }

	// RVA: 0x2304280 Offset: 0x2300280 VA: 0x2304280 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2304348 Offset: 0x2300348 VA: 0x2304348 Slot: 42
	public override void SetTargetMobOthers(GameObject target) { }

	// RVA: 0x2304378 Offset: 0x2300378 VA: 0x2304378 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2304AA0 Offset: 0x2300AA0 VA: 0x2304AA0
	public static bool CheckAvoid(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2304B68 Offset: 0x2300B68 VA: 0x2304B68
	public static bool CheckAvoid(PlayerActionManagerBase playerAction, MobAttackBase mobAttack) { }

	// RVA: 0x2302630 Offset: 0x22FE630 VA: 0x2302630
	public static int Encryption(int attackMode, int param) { }

	// RVA: 0x2304A8C Offset: 0x2300A8C VA: 0x2304A8C
	public static void Decryption(int flag, out int attackMode, out int param) { }

	// RVA: 0x2304C50 Offset: 0x2300C50 VA: 0x2304C50
	public void .ctor() { }
}
