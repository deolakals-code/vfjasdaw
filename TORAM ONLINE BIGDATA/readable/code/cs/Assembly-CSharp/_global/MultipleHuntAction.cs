// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MultipleHuntAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2707
{
	// Fields
	private SkillAttackType attackType; // 0x120
	private MultipleHuntAction.SkillMode mode; // 0x124
	private int abnormalPercent; // 0x128
	private int skillRate; // 0x12C
	private int secondSkillRate; // 0x130
	private int fixAddDamage; // 0x134
	private int hitCount; // 0x138
	private int critical; // 0x13C
	private GameObject target; // 0x140
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x148

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override string LocalizeKey { get; }

	// Methods

	// RVA: 0x223F2D8 Offset: 0x223B2D8 VA: 0x223F2D8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x223F2E0 Offset: 0x223B2E0 VA: 0x223F2E0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x223F2E8 Offset: 0x223B2E8 VA: 0x223F2E8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x223F2F0 Offset: 0x223B2F0 VA: 0x223F2F0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x223F2F8 Offset: 0x223B2F8 VA: 0x223F2F8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x223F300 Offset: 0x223B300 VA: 0x223F300 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x223F308 Offset: 0x223B308 VA: 0x223F308 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x223F310 Offset: 0x223B310 VA: 0x223F310 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x223F320 Offset: 0x223B320 VA: 0x223F320 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x223F3B0 Offset: 0x223B3B0 VA: 0x223F3B0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x223FDD4 Offset: 0x223BDD4 VA: 0x223FDD4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x223FDEC Offset: 0x223BDEC VA: 0x223FDEC Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x223F4E4 Offset: 0x223B4E4 VA: 0x223F4E4
	private void InitializeWolfAssault(PlayerActionManagerBase playerAction) { }

	// RVA: 0x223F6F8 Offset: 0x223B6F8 VA: 0x223F6F8
	private void InitializeHighRainSnipe(PlayerActionManagerBase playerAction) { }

	// RVA: 0x223F98C Offset: 0x223B98C VA: 0x223F98C
	private void InitializeChasseGarde(PlayerActionManagerBase playerAction) { }

	// RVA: 0x223FBA0 Offset: 0x223BBA0 VA: 0x223FBA0
	private void InitializeSharpSnipe(PlayerActionManagerBase playerAction) { }

	// RVA: 0x223FEB0 Offset: 0x223BEB0 VA: 0x223FEB0 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x223FFC8 Offset: 0x223BFC8 VA: 0x223FFC8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22402D0 Offset: 0x223C2D0 VA: 0x22402D0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2240308 Offset: 0x223C308 VA: 0x2240308
	private void calcDamageWolfAssault(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2240574 Offset: 0x223C574 VA: 0x2240574
	private void calcDamageHighRainSnipe(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2240C28 Offset: 0x223CC28 VA: 0x2240C28
	private void calcDamageChasseGarde(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2240E94 Offset: 0x223CE94 VA: 0x2240E94
	private void calcDamageSharpSnipe(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22411C4 Offset: 0x223D1C4 VA: 0x22411C4 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2241244 Offset: 0x223D244 VA: 0x2241244 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22413AC Offset: 0x223D3AC VA: 0x22413AC Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x224142C Offset: 0x223D42C VA: 0x224142C Slot: 90
	public override string GetLocalizeKey(byte element, int skillIndividualFlag) { }

	// RVA: 0x2241458 Offset: 0x223D458 VA: 0x2241458
	public void .ctor() { }
}
