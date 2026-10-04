// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RedTearAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 2609
{
	// Fields
	private float skillRate; // 0x120
	private int resist; // 0x124
	private Vector3 attackPos; // 0x128
	private float rad; // 0x134
	private int damageCount; // 0x138
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x140

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool NonElementEffect { get; }
	public override SkillChargingType ChargingType { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x220E264 Offset: 0x220A264 VA: 0x220E264 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x220E26C Offset: 0x220A26C VA: 0x220E26C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x220E274 Offset: 0x220A274 VA: 0x220E274 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x220E27C Offset: 0x220A27C VA: 0x220E27C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x220E284 Offset: 0x220A284 VA: 0x220E284 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x220E28C Offset: 0x220A28C VA: 0x220E28C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x220E294 Offset: 0x220A294 VA: 0x220E294 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x220E29C Offset: 0x220A29C VA: 0x220E29C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x220E2A4 Offset: 0x220A2A4 VA: 0x220E2A4 Slot: 35
	public override bool get_NonElementEffect() { }

	// RVA: 0x220E2AC Offset: 0x220A2AC VA: 0x220E2AC Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x220E2B4 Offset: 0x220A2B4 VA: 0x220E2B4 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x220E2BC Offset: 0x220A2BC VA: 0x220E2BC Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x220E2C4 Offset: 0x220A2C4 VA: 0x220E2C4 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x220E2CC Offset: 0x220A2CC VA: 0x220E2CC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x220E700 Offset: 0x220A700 VA: 0x220E700 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x220E720 Offset: 0x220A720 VA: 0x220E720 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x220E8A4 Offset: 0x220A8A4 VA: 0x220E8A4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x220ED58 Offset: 0x220AD58 VA: 0x220ED58 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x220EE48 Offset: 0x220AE48 VA: 0x220EE48 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x220EEB8 Offset: 0x220AEB8 VA: 0x220EEB8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x220F358 Offset: 0x220B358 VA: 0x220F358 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x220F42C Offset: 0x220B42C VA: 0x220F42C Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x220F500 Offset: 0x220B500 VA: 0x220F500
	public void .ctor() { }
}
