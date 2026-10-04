// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PhantomRaveAction : PlayerAttackBase, ILunaDitherStartInterruptableSkill, IAbnormalStateSkill, IDualElementSkill // TypeDefIndex: 2641
{
	// Fields
	public const int DeathDamage = 999999999;
	private readonly int StandardHitCount; // 0x120
	private int InstantKillHitCount; // 0x124
	private float skillRate; // 0x128
	private int fixAddDamage; // 0x12C
	private int cost; // 0x130
	private int freezeRate; // 0x134
	private int hitCount; // 0x138
	private int otherArchetypeId; // 0x13C
	private PhantomRaveMove phantomMove; // 0x140
	private SkillLinkedTake InstantKillTake; // 0x148
	private SkillActionBase.DamageData placeDamageData; // 0x150
	private bool isPlaceBonus; // 0x158
	private bool isPlaceAttack; // 0x159
	private byte invincibilityLocalId; // 0x15A
	private bool change; // 0x15B

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsMove { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }
	public override string LocalizeKey { get; }
	protected override bool CheckBlank { get; }
	public bool IsValidDualElement { get; }

	// Methods

	// RVA: 0x221D274 Offset: 0x2219274 VA: 0x221D274 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x221D27C Offset: 0x221927C VA: 0x221D27C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x221D284 Offset: 0x2219284 VA: 0x221D284 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x221D28C Offset: 0x221928C VA: 0x221D28C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x221D294 Offset: 0x2219294 VA: 0x221D294 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x221D29C Offset: 0x221929C VA: 0x221D29C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x221D2A4 Offset: 0x22192A4 VA: 0x221D2A4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x221D2AC Offset: 0x22192AC VA: 0x221D2AC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x221D2B4 Offset: 0x22192B4 VA: 0x221D2B4 Slot: 28
	public override bool get_IsMove() { }

	// RVA: 0x221D2BC Offset: 0x22192BC VA: 0x221D2BC Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x221D2C4 Offset: 0x22192C4 VA: 0x221D2C4 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x221D2CC Offset: 0x22192CC VA: 0x221D2CC Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x221D338 Offset: 0x2219338 VA: 0x221D338 Slot: 73
	protected override bool get_CheckBlank() { }

	// RVA: 0x221D348 Offset: 0x2219348 VA: 0x221D348 Slot: 93
	public bool get_IsValidDualElement() { }

	// RVA: 0x221D350 Offset: 0x2219350 VA: 0x221D350 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x221D5A8 Offset: 0x22195A8 VA: 0x221D5A8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x221D6EC Offset: 0x22196EC VA: 0x221D6EC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x221D7D4 Offset: 0x22197D4 VA: 0x221D7D4 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x221DA30 Offset: 0x2219A30 VA: 0x221DA30 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x221DAD8 Offset: 0x2219AD8 VA: 0x221DAD8 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x221DE9C Offset: 0x2219E9C VA: 0x221DE9C Slot: 80
	public override void AttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x221DF58 Offset: 0x2219F58 VA: 0x221DF58 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x221E7FC Offset: 0x221A7FC VA: 0x221E7FC
	private void createExDamage(SkillDamageData DamageData) { }

	// RVA: 0x221E898 Offset: 0x221A898 VA: 0x221E898 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x221E690 Offset: 0x221A690 VA: 0x221E690
	private void CreateMultiDamage(SkillActionBase.DamageData damageData, AbnormalType type, float addResistTime) { }

	// RVA: 0x221E388 Offset: 0x221A388 VA: 0x221E388
	private void CalcPhantomRaveLastDamageRate(PlayerStatusBase status, out float bonusLastRate, out float noBonusLastRate) { }

	// RVA: 0x221E8FC Offset: 0x221A8FC VA: 0x221E8FC Slot: 91
	public void LunaDitherStartInterruptableInitialize(CharacterActionManagerBase actorAction) { }

	// RVA: 0x221E934 Offset: 0x221A934 VA: 0x221E934 Slot: 90
	public override string GetLocalizeKey(byte element, int skillIndividualFlag) { }

	// RVA: 0x221E96C Offset: 0x221A96C VA: 0x221E96C
	public void .ctor() { }
}
