// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CatarabomosAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 3027
{
	// Fields
	private float abnormalTime; // 0x120

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
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x23096C4 Offset: 0x23056C4 VA: 0x23096C4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23096CC Offset: 0x23056CC VA: 0x23096CC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23096D4 Offset: 0x23056D4 VA: 0x23096D4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23096DC Offset: 0x23056DC VA: 0x23096DC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23096E4 Offset: 0x23056E4 VA: 0x23096E4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23096EC Offset: 0x23056EC VA: 0x23096EC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23096F4 Offset: 0x23056F4 VA: 0x23096F4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23096FC Offset: 0x23056FC VA: 0x23096FC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2309704 Offset: 0x2305704 VA: 0x2309704 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x230970C Offset: 0x230570C VA: 0x230970C Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x2309714 Offset: 0x2305714 VA: 0x2309714 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x230971C Offset: 0x230571C VA: 0x230971C Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x2309724 Offset: 0x2305724 VA: 0x2309724 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2309894 Offset: 0x2305894 VA: 0x2309894 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x230994C Offset: 0x230594C VA: 0x230994C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2309AAC Offset: 0x2305AAC VA: 0x2309AAC
	public static void AddAbnormalEffect(SkillActionBase skill, AbnormalType abnormalType, GameObject actor, SkillDamageData damageData) { }

	// RVA: 0x2309CA4 Offset: 0x2305CA4 VA: 0x2309CA4
	public static void ReceiveAttackResult(MobResponseData data) { }

	// RVA: 0x2309F30 Offset: 0x2305F30 VA: 0x2309F30 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x230A004 Offset: 0x2306004 VA: 0x230A004 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x230A0D8 Offset: 0x23060D8 VA: 0x230A0D8
	public void .ctor() { }
}
