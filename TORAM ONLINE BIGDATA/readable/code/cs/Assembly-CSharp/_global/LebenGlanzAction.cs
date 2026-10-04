// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LebenGlanzAction : PlayerAttackBase // TypeDefIndex: 3036
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
	public override bool IsExpDefFluctuate { get; }
	public static float HealRange { get; }

	// Methods

	// RVA: 0x230E1E0 Offset: 0x230A1E0 VA: 0x230E1E0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x230E1E8 Offset: 0x230A1E8 VA: 0x230E1E8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x230E1F0 Offset: 0x230A1F0 VA: 0x230E1F0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x230E1F8 Offset: 0x230A1F8 VA: 0x230E1F8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x230E200 Offset: 0x230A200 VA: 0x230E200 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x230E208 Offset: 0x230A208 VA: 0x230E208 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x230E210 Offset: 0x230A210 VA: 0x230E210 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x230E218 Offset: 0x230A218 VA: 0x230E218 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x230E220 Offset: 0x230A220 VA: 0x230E220 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x230E228 Offset: 0x230A228 VA: 0x230E228
	public static float get_HealRange() { }

	// RVA: 0x230E234 Offset: 0x230A234 VA: 0x230E234 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x230E368 Offset: 0x230A368 VA: 0x230E368 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x230E420 Offset: 0x230A420 VA: 0x230E420 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x230E538 Offset: 0x230A538 VA: 0x230E538
	public static void ReceiveAttackResult(MobResponseData responseData) { }

	// RVA: 0x230E7C4 Offset: 0x230A7C4 VA: 0x230E7C4
	public static void EndDebuffHpHeal(EnemyMobActionManagerBase enemy, byte lv) { }

	// RVA: 0x230EC5C Offset: 0x230AC5C VA: 0x230EC5C
	public static void ValidDebuff(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x230EDF0 Offset: 0x230ADF0 VA: 0x230EDF0
	public static void InvalidDebuff(PlayerActionManagerBase playerAction) { }

	// RVA: 0x230EE30 Offset: 0x230AE30 VA: 0x230EE30
	public void .ctor() { }
}
