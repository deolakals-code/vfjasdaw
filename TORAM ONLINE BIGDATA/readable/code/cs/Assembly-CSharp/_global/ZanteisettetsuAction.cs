// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ZanteisettetsuAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2875
{
	// Fields
	private float skillRate; // 0x120
	private float fixAddDamage; // 0x124
	private float pursuitSkillRate; // 0x128
	private int pursuitFixAddDamage; // 0x12C
	private float heavenlyStarSkillRate; // 0x130
	private int heavenlyStarFixAddDamage; // 0x134
	private int abnormalPercent; // 0x138
	private int damageCount; // 0x13C
	private SkillActionBase.DamageData pursuitDamageData; // 0x140
	private SkillActionBase.DamageData heavenlyStarDamageData; // 0x148
	private bool isLocalizeHeavenlyStar; // 0x150

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

	// RVA: 0x22B79A0 Offset: 0x22B39A0 VA: 0x22B79A0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22B79A8 Offset: 0x22B39A8 VA: 0x22B79A8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22B79B0 Offset: 0x22B39B0 VA: 0x22B79B0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22B79B8 Offset: 0x22B39B8 VA: 0x22B79B8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22B79C0 Offset: 0x22B39C0 VA: 0x22B79C0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22B79C8 Offset: 0x22B39C8 VA: 0x22B79C8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22B79D0 Offset: 0x22B39D0 VA: 0x22B79D0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22B79D8 Offset: 0x22B39D8 VA: 0x22B79D8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22B79E0 Offset: 0x22B39E0 VA: 0x22B79E0 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x22B7A4C Offset: 0x22B3A4C VA: 0x22B7A4C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22B7CF8 Offset: 0x22B3CF8 VA: 0x22B7CF8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22B7DBC Offset: 0x22B3DBC VA: 0x22B7DBC Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22B8568 Offset: 0x22B4568 VA: 0x22B8568 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22B87B0 Offset: 0x22B47B0 VA: 0x22B87B0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22B8D54 Offset: 0x22B4D54 VA: 0x22B8D54 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22B8DB8 Offset: 0x22B4DB8 VA: 0x22B8DB8
	public static bool CheckDamageInvalid(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x22B8E80 Offset: 0x22B4E80 VA: 0x22B8E80
	public void .ctor() { }
}
