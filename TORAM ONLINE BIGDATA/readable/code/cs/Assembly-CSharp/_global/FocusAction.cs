// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FocusAction : PlayerAttackBase // TypeDefIndex: 2702
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

	// Methods

	// RVA: 0x223CCF4 Offset: 0x2238CF4 VA: 0x223CCF4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x223CCFC Offset: 0x2238CFC VA: 0x223CCFC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x223CD04 Offset: 0x2238D04 VA: 0x223CD04 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x223CD0C Offset: 0x2238D0C VA: 0x223CD0C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x223CD14 Offset: 0x2238D14 VA: 0x223CD14 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x223CD1C Offset: 0x2238D1C VA: 0x223CD1C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x223CD24 Offset: 0x2238D24 VA: 0x223CD24 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x223CD2C Offset: 0x2238D2C VA: 0x223CD2C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x223CD34 Offset: 0x2238D34 VA: 0x223CD34 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x223CE5C Offset: 0x2238E5C VA: 0x223CE5C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x223CF5C Offset: 0x2238F5C VA: 0x223CF5C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x223D138 Offset: 0x2239138 VA: 0x223D138
	public static void ValidDebuff(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x223D2DC Offset: 0x22392DC VA: 0x223D2DC
	public static void InvalidDebuff(PlayerActionManagerBase playerAction) { }

	// RVA: 0x223D31C Offset: 0x223931C VA: 0x223D31C
	public static void ReceiveAttackResult(MobResponseData responseData) { }

	// RVA: 0x223D500 Offset: 0x2239500 VA: 0x223D500
	public void .ctor() { }
}
