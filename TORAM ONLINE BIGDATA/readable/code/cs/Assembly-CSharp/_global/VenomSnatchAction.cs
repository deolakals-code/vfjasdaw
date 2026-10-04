// Assembly: Assembly-CSharp.dll
// Namespace: 
public class VenomSnatchAction : PlayerAttackBase // TypeDefIndex: 2540
{
	// Fields
	private Transform mainTarget; // 0x120
	private MobActionManagerBase collectingPoisonTarget; // 0x128

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

	// Methods

	// RVA: 0x21E8CBC Offset: 0x21E4CBC VA: 0x21E8CBC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21E8CC4 Offset: 0x21E4CC4 VA: 0x21E8CC4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21E8CCC Offset: 0x21E4CCC VA: 0x21E8CCC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21E8CD4 Offset: 0x21E4CD4 VA: 0x21E8CD4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21E8CDC Offset: 0x21E4CDC VA: 0x21E8CDC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21E8CE4 Offset: 0x21E4CE4 VA: 0x21E8CE4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21E8CEC Offset: 0x21E4CEC VA: 0x21E8CEC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21E8CF4 Offset: 0x21E4CF4 VA: 0x21E8CF4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21E8CFC Offset: 0x21E4CFC VA: 0x21E8CFC Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x21E8D04 Offset: 0x21E4D04 VA: 0x21E8D04 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21E8E08 Offset: 0x21E4E08 VA: 0x21E8E08 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21E8E4C Offset: 0x21E4E4C VA: 0x21E8E4C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x21E8FF8 Offset: 0x21E4FF8 VA: 0x21E8FF8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21E91C4 Offset: 0x21E51C4 VA: 0x21E91C4
	public bool CheckCollectionAbnormalPoisonTarget(PlayerActionManagerBase actorAction) { }

	// RVA: 0x21E9870 Offset: 0x21E5870 VA: 0x21E9870
	public static void BattleResult(PlayerActionManagerBase playerAction, int flag) { }

	// RVA: 0x21E9BD8 Offset: 0x21E5BD8 VA: 0x21E9BD8
	public static int CalcHpHealValue(byte sLv, PlayerStatusBase status, int poisonLevel) { }

	// RVA: 0x21E9CF4 Offset: 0x21E5CF4 VA: 0x21E9CF4
	public static int CalcMpHealValue(byte sLv, PlayerStatusBase status, int poisonLevel) { }

	// RVA: 0x21E9E0C Offset: 0x21E5E0C VA: 0x21E9E0C
	private static void GiveVaccinations(PlayerStatusBase status, byte poisonLevel) { }

	// RVA: 0x21E9F0C Offset: 0x21E5F0C VA: 0x21E9F0C
	public static int Encryption(int correctionPoisonLevel, bool recoveryPoison) { }

	// RVA: 0x21E9BC0 Offset: 0x21E5BC0 VA: 0x21E9BC0
	public static void Decryption(int value, out int correctionPoisonLevel, out bool recoveryPoison) { }

	// RVA: 0x21E9F1C Offset: 0x21E5F1C VA: 0x21E9F1C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21E9F9C Offset: 0x21E5F9C VA: 0x21E9F9C
	public void .ctor() { }
}
