// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MoonSlashAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2564
{
	// Fields
	private float firstSkillRate; // 0x120
	private int firstFixAddDamage; // 0x124
	private float secondSkillRate; // 0x128
	private int secondFixAddDamage; // 0x12C
	private int percent; // 0x130
	private int conboIndex; // 0x134
	private bool addBuf; // 0x138

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

	// RVA: 0x21F5E10 Offset: 0x21F1E10 VA: 0x21F5E10 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21F5E18 Offset: 0x21F1E18 VA: 0x21F5E18 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21F5E20 Offset: 0x21F1E20 VA: 0x21F5E20 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21F5E28 Offset: 0x21F1E28 VA: 0x21F5E28 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21F5E30 Offset: 0x21F1E30 VA: 0x21F5E30 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21F5E38 Offset: 0x21F1E38 VA: 0x21F5E38 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21F5E40 Offset: 0x21F1E40 VA: 0x21F5E40 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21F5E48 Offset: 0x21F1E48 VA: 0x21F5E48 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21F5E50 Offset: 0x21F1E50 VA: 0x21F5E50 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21F60CC Offset: 0x21F20CC VA: 0x21F60CC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21F6300 Offset: 0x21F2300 VA: 0x21F6300 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21F66E8 Offset: 0x21F26E8 VA: 0x21F66E8 Slot: 77
	public override void SetCurrentSkillCombo(SkillComboState combo) { }

	// RVA: 0x21F671C Offset: 0x21F271C VA: 0x21F671C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21F699C Offset: 0x21F299C VA: 0x21F699C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21F6C10 Offset: 0x21F2C10 VA: 0x21F6C10
	private SkillCalcTemplate CalcFirstDamageData(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21F6DB8 Offset: 0x21F2DB8 VA: 0x21F6DB8
	private SkillCalcTemplate CalcSecondDamageData(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21F6F60 Offset: 0x21F2F60 VA: 0x21F6F60 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x21F6FC4 Offset: 0x21F2FC4 VA: 0x21F6FC4
	public static bool CheckPursuit(SkillActionBase action, PlayerActionManagerBase playerAction) { }

	// RVA: 0x21F717C Offset: 0x21F317C VA: 0x21F717C
	public static void ReceiveMobaAttack(MobaMobResponseData response, MobaPlayerActionManager playerAction) { }

	// RVA: 0x21F73A8 Offset: 0x21F33A8 VA: 0x21F73A8
	public void .ctor() { }
}
