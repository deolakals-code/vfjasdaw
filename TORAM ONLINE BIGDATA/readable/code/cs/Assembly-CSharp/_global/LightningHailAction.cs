// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LightningHailAction : PlayerAttackBase // TypeDefIndex: 2685
{
	// Fields
	private const int maxAttackNum = 8;
	private float alphaRange; // 0x120
	private float betaRange; // 0x124
	private int skillRate; // 0x128
	private int fixAddDamage; // 0x12C
	private int attackNum; // 0x130
	private Vector3[] attackPosList; // 0x138
	private int nowAttackCount; // 0x140
	private int startNum; // 0x144
	private int endNum; // 0x148
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x150
	private LightningHailBuf lightningHailBuf; // 0x158
	private bool isThorHammer; // 0x160
	private Random random; // 0x168
	private Vector3 targetPos; // 0x170
	private byte invincibilityLocalId; // 0x17C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }

	// Methods

	// RVA: 0x2232E90 Offset: 0x222EE90 VA: 0x2232E90 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2232E98 Offset: 0x222EE98 VA: 0x2232E98 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2232EA0 Offset: 0x222EEA0 VA: 0x2232EA0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2232EA8 Offset: 0x222EEA8 VA: 0x2232EA8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2232EB0 Offset: 0x222EEB0 VA: 0x2232EB0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2232EB8 Offset: 0x222EEB8 VA: 0x2232EB8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2232EC0 Offset: 0x222EEC0 VA: 0x2232EC0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2232EC8 Offset: 0x222EEC8 VA: 0x2232EC8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2232ED0 Offset: 0x222EED0 VA: 0x2232ED0 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x2232ED8 Offset: 0x222EED8 VA: 0x2232ED8 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x2232EE0 Offset: 0x222EEE0 VA: 0x2232EE0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x223312C Offset: 0x222F12C VA: 0x223312C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2233150 Offset: 0x222F150 VA: 0x2233150 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2233928 Offset: 0x222F928 VA: 0x2233928 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x2233E04 Offset: 0x222FE04 VA: 0x2233E04 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2233F14 Offset: 0x222FF14 VA: 0x2233F14 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22343F4 Offset: 0x22303F4 VA: 0x22343F4 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2234474 Offset: 0x2230474 VA: 0x2234474 Slot: 46
	public override void ActionSkillEventPreparation(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2234600 Offset: 0x2230600 VA: 0x2234600 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22347B8 Offset: 0x22307B8 VA: 0x22347B8
	public void .ctor() { }
}
