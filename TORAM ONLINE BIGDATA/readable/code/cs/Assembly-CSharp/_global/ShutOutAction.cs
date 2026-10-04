// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShutOutAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2569
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private float bonusSkillRate; // 0x128
	private bool bleed; // 0x12C
	private int physicsResistBreakerBonus; // 0x130

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

	// RVA: 0x21F9C2C Offset: 0x21F5C2C VA: 0x21F9C2C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21F9C34 Offset: 0x21F5C34 VA: 0x21F9C34 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21F9C3C Offset: 0x21F5C3C VA: 0x21F9C3C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21F9C44 Offset: 0x21F5C44 VA: 0x21F9C44 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21F9C4C Offset: 0x21F5C4C VA: 0x21F9C4C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21F9C54 Offset: 0x21F5C54 VA: 0x21F9C54 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21F9C5C Offset: 0x21F5C5C VA: 0x21F9C5C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21F9C64 Offset: 0x21F5C64 VA: 0x21F9C64 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21F9C6C Offset: 0x21F5C6C VA: 0x21F9C6C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21F9F24 Offset: 0x21F5F24 VA: 0x21F9F24 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21FA080 Offset: 0x21F6080 VA: 0x21FA080 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21FA1A8 Offset: 0x21F61A8 VA: 0x21FA1A8 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x21FA2B0 Offset: 0x21F62B0 VA: 0x21FA2B0 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x21FA314 Offset: 0x21F6314 VA: 0x21FA314 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21FA7D8 Offset: 0x21F67D8 VA: 0x21FA7D8
	private int CalcBonusResistDamage(PlayerStatusBase playerStatus, IMobStatusCalculator mobStatus) { }

	// RVA: 0x21FA04C Offset: 0x21F604C VA: 0x21FA04C
	private static int CreateTakeId(int mainWeaponType, int subWeaponType, bool bonus) { }

	// RVA: 0x21FAA34 Offset: 0x21F6A34 VA: 0x21FAA34
	public void .ctor() { }
}
