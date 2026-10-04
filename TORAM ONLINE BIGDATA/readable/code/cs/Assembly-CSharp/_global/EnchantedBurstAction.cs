// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EnchantedBurstAction : PlayerAttackBase // TypeDefIndex: 2755
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private int stackCollapseTime; // 0x128
	private int bufStack; // 0x12C
	private bool conversion; // 0x130
	private EnchantedBurstAction.Flag flag; // 0x134

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override string LocalizeKey { get; }

	// Methods

	// RVA: 0x22580EC Offset: 0x22540EC VA: 0x22580EC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2258100 Offset: 0x2254100 VA: 0x2258100 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2258108 Offset: 0x2254108 VA: 0x2258108 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2258110 Offset: 0x2254110 VA: 0x2258110 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2258118 Offset: 0x2254118 VA: 0x2258118 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2258120 Offset: 0x2254120 VA: 0x2258120 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2258128 Offset: 0x2254128 VA: 0x2258128 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2258130 Offset: 0x2254130 VA: 0x2258130 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2258138 Offset: 0x2254138 VA: 0x2258138 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x22581B0 Offset: 0x22541B0 VA: 0x22581B0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2258330 Offset: 0x2254330 VA: 0x2258330 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2258404 Offset: 0x2254404 VA: 0x2258404 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22584EC Offset: 0x22544EC VA: 0x22584EC Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22589F0 Offset: 0x22549F0 VA: 0x22589F0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2258ADC Offset: 0x2254ADC VA: 0x2258ADC Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2258D14 Offset: 0x2254D14 VA: 0x2258D14 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2259188 Offset: 0x2255188 VA: 0x2259188 Slot: 86
	protected override int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x2259674 Offset: 0x2255674 VA: 0x2259674 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22596FC Offset: 0x22556FC VA: 0x22596FC
	public static void ReceiveAttackResult(PlayerStatusBase status, AttackResponseData attackResponseData, MobResponseData mobResponseData) { }

	// RVA: 0x2259898 Offset: 0x2255898 VA: 0x2259898
	public static void ReceiveMobaAttackResult(PlayerStatusBase status, CharacterActionManagerBase targetAction, AttackResponseData attackResponseData, MobaMobResponseData mobResponseData) { }

	// RVA: 0x2259A30 Offset: 0x2255A30 VA: 0x2259A30
	public static void AddLocalStack(PlayerStatusBase status, int skillId, byte skillLocalId) { }

	// RVA: 0x22584D4 Offset: 0x22544D4 VA: 0x22584D4
	public static void Decoding(int value, out byte sLv, out byte stack, out byte flag) { }

	// RVA: 0x22589D8 Offset: 0x22549D8 VA: 0x22589D8
	public static int Encryption(byte sLv, byte stack, byte flag) { }

	// RVA: 0x2259BA0 Offset: 0x2255BA0 VA: 0x2259BA0
	public static void AddDebuff(PlayerActionManagerBase action, SkillActionBase skill, SkillDamageData damageData) { }

	// RVA: 0x2259D64 Offset: 0x2255D64 VA: 0x2259D64
	public void .ctor() { }
}
