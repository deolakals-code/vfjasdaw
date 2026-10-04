// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AssaultChaseAction : PlayerAttackBase // TypeDefIndex: 3612
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23ACC0C Offset: 0x23A8C0C VA: 0x23ACC0C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23ACC14 Offset: 0x23A8C14 VA: 0x23ACC14 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23ACC1C Offset: 0x23A8C1C VA: 0x23ACC1C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23ACC24 Offset: 0x23A8C24 VA: 0x23ACC24 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23ACC2C Offset: 0x23A8C2C VA: 0x23ACC2C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23ACC34 Offset: 0x23A8C34 VA: 0x23ACC34 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23ACC3C Offset: 0x23A8C3C VA: 0x23ACC3C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23ACC44 Offset: 0x23A8C44 VA: 0x23ACC44 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23ACC4C Offset: 0x23A8C4C VA: 0x23ACC4C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23ACC54 Offset: 0x23A8C54 VA: 0x23ACC54 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23ACD38 Offset: 0x23A8D38 VA: 0x23ACD38 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23ACEA8 Offset: 0x23A8EA8 VA: 0x23ACEA8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23ACF28 Offset: 0x23A8F28 VA: 0x23ACF28
	public static bool CheckAssaultChase(PlayerActionManagerBase playerAction, float moveAngle) { }

	// RVA: 0x23AD43C Offset: 0x23A943C VA: 0x23AD43C
	public static int CalcAvoidConsumptionReduction(PlayerActionManagerBase playerAction, int useAvoid) { }

	// RVA: 0x23AD53C Offset: 0x23A953C VA: 0x23AD53C
	public static bool CheckAvoid(PlayerActionManagerBase actionManager) { }

	// RVA: 0x23AD610 Offset: 0x23A9610 VA: 0x23AD610
	public static bool CheckAvoid(PlayerActionManagerBase actionManager, MobAttackBase mobAttack) { }

	// RVA: 0x23AD6F8 Offset: 0x23A96F8 VA: 0x23AD6F8
	public void .ctor() { }
}
