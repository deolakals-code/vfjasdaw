// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ThorHammerAction : PlayerAttackBase // TypeDefIndex: 2694
{
	// Fields
	private int skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private float range; // 0x128
	private int pursuitSkillRate; // 0x12C
	private int pursuitFixDamage; // 0x130
	private float pursuitRange; // 0x134
	private int nowAttackCount; // 0x138
	private int damageCount; // 0x13C
	private int split; // 0x140
	private Dictionary<int, Vector3> placePosList; // 0x148
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x150
	private LightningHailBuf lightningHailBuf; // 0x158
	private int pursuitUid; // 0x160
	private byte pursuitHitCount; // 0x164
	private bool pursuitEnd; // 0x165

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public bool IsFirst { get; }

	// Methods

	// RVA: 0x2236654 Offset: 0x2232654 VA: 0x2236654 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x223665C Offset: 0x223265C VA: 0x223665C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2236664 Offset: 0x2232664 VA: 0x2236664 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x223666C Offset: 0x223266C VA: 0x223666C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2236674 Offset: 0x2232674 VA: 0x2236674 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x223667C Offset: 0x223267C VA: 0x223667C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2236684 Offset: 0x2232684 VA: 0x2236684 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x223668C Offset: 0x223268C VA: 0x223668C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2236694 Offset: 0x2232694 VA: 0x2236694
	public bool get_IsFirst() { }

	// RVA: 0x22366A4 Offset: 0x22326A4 VA: 0x22366A4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22367B0 Offset: 0x22327B0 VA: 0x22367B0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2236CE8 Offset: 0x2232CE8 VA: 0x2236CE8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2236EC8 Offset: 0x2232EC8 VA: 0x2236EC8 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2237060 Offset: 0x2233060 VA: 0x2237060 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x223754C Offset: 0x223354C VA: 0x223754C Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22376CC Offset: 0x22336CC VA: 0x22376CC Slot: 46
	public override void ActionSkillEventPreparation(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2237A3C Offset: 0x2233A3C VA: 0x2237A3C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2237E40 Offset: 0x2233E40 VA: 0x2237E40 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x223802C Offset: 0x223402C VA: 0x223802C
	public static void ReceivedAbnormal(PlayerActionManagerBase playerAction, AbnormalType abnormalType) { }

	// RVA: 0x22380CC Offset: 0x22340CC VA: 0x22380CC
	public static void Damaged(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x2238168 Offset: 0x2234168 VA: 0x2238168
	public void .ctor() { }
}
