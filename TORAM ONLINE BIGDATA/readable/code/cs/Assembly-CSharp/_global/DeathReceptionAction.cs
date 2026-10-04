// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DeathReceptionAction : PlayerAttackBase // TypeDefIndex: 2535
{
	// Fields
	private Transform mainTarget; // 0x120
	private Vector3 attackPos; // 0x128
	private float singleSkillRate; // 0x134
	private int singleConstantDamage; // 0x138
	private int singleResistBreaker; // 0x13C
	private float rangeSkillRate; // 0x140
	private int rangeConstantDamage; // 0x144
	private float attackRange; // 0x148
	private int poisonLevel; // 0x14C
	private PlayerActionManagerBase actorPlayerAction; // 0x150
	private Dictionary<MobActionManagerBase, DeathReceptionAction.PoisonTargetData> addPoisonEffectTargetList; // 0x158

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x21E4FE0 Offset: 0x21E0FE0 VA: 0x21E4FE0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21E4FE8 Offset: 0x21E0FE8 VA: 0x21E4FE8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21E4FF0 Offset: 0x21E0FF0 VA: 0x21E4FF0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21E4FF8 Offset: 0x21E0FF8 VA: 0x21E4FF8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21E5000 Offset: 0x21E1000 VA: 0x21E5000 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21E5008 Offset: 0x21E1008 VA: 0x21E5008 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21E5010 Offset: 0x21E1010 VA: 0x21E5010 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21E5018 Offset: 0x21E1018 VA: 0x21E5018 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21E5020 Offset: 0x21E1020 VA: 0x21E5020 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21E54AC Offset: 0x21E14AC VA: 0x21E54AC Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21E5748 Offset: 0x21E1748 VA: 0x21E5748 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x21E5CB0 Offset: 0x21E1CB0 VA: 0x21E5CB0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21E628C Offset: 0x21E228C VA: 0x21E628C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x21E6340 Offset: 0x21E2340 VA: 0x21E6340 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x21E63B4 Offset: 0x21E23B4 VA: 0x21E63B4
	public static void ReceiveAttackResult(MobResponseData responseData) { }

	// RVA: 0x21E65A0 Offset: 0x21E25A0 VA: 0x21E65A0
	public static void ReceiveAttackResult(MobaMobResponseData responseData) { }

	// RVA: 0x21E6710 Offset: 0x21E2710 VA: 0x21E6710 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21E67D4 Offset: 0x21E27D4 VA: 0x21E67D4
	public void .ctor() { }
}
