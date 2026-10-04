// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobEventScriptAttack : MobAttackBase // TypeDefIndex: 1141
{
	// Fields
	private MobEventScriptAttack.MobAttackType attackType; // 0xE0
	private int baseAtk; // 0xE4
	private int stable; // 0xE8
	private int criticalRate; // 0xEC
	private int criticalDamage; // 0xF0
	private int flee; // 0xF4
	private AbnormalType abnormalType; // 0xF8
	private int abnormalPercent; // 0xFC
	private int abnormalEffectTime; // 0x100
	private MobEventScriptAttack.GuardType guardType; // 0x104
	private MobEventScriptAttack.AvoidType avoidType; // 0x108
	[CompilerGenerated]
	private int <HitSE>k__BackingField; // 0x10C
	[CompilerGenerated]
	private int <HitEffectId>k__BackingField; // 0x110
	[CompilerGenerated]
	private int <HitEffectMotionId>k__BackingField; // 0x114

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public int HitSE { get; set; }
	public int HitEffectId { get; set; }
	public int HitEffectMotionId { get; set; }
	public int Flee { get; }

	// Methods

	// RVA: 0x1F5C014 Offset: 0x1F58014 VA: 0x1F5C014 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x1F5C028 Offset: 0x1F58028 VA: 0x1F5C028 Slot: 23
	public override int get_BaseMp() { }

	[CompilerGenerated]
	// RVA: 0x1F5C030 Offset: 0x1F58030 VA: 0x1F5C030
	public int get_HitSE() { }

	[CompilerGenerated]
	// RVA: 0x1F5C038 Offset: 0x1F58038 VA: 0x1F5C038
	private void set_HitSE(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F5C040 Offset: 0x1F58040 VA: 0x1F5C040
	public int get_HitEffectId() { }

	[CompilerGenerated]
	// RVA: 0x1F5C048 Offset: 0x1F58048 VA: 0x1F5C048
	private void set_HitEffectId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F5C050 Offset: 0x1F58050 VA: 0x1F5C050
	public int get_HitEffectMotionId() { }

	[CompilerGenerated]
	// RVA: 0x1F5C058 Offset: 0x1F58058 VA: 0x1F5C058
	private void set_HitEffectMotionId(int value) { }

	// RVA: 0x1F5C060 Offset: 0x1F58060 VA: 0x1F5C060
	public int get_Flee() { }

	// RVA: 0x1F5C068 Offset: 0x1F58068 VA: 0x1F5C068
	public void Initialize(byte attackType, int damage, int stable, ElementType element, int criticalPercent, int criticalDamage, int flee, AbnormalType abnormalType, int abnormalPercent, short abnormalTime, int guardType, int avoidType, int hitSE, int hitEffect, int hitEffectMotion) { }

	// RVA: 0x1F5C0B4 Offset: 0x1F580B4 VA: 0x1F5C0B4
	public void Calc(PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F5D944 Offset: 0x1F59944 VA: 0x1F5D944 Slot: 56
	protected override void calcMobToPlayerDamage(MobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F5C9B8 Offset: 0x1F589B8 VA: 0x1F5C9B8
	private int CalcPhysicsDamage(SkillActionBase.DamageData damageData, PlayerActionManagerBase playerAction, out int guardPower, out bool justGuard) { }

	// RVA: 0x1F5CDCC Offset: 0x1F58DCC VA: 0x1F5CDCC
	private int CalcMagicDamage(SkillActionBase.DamageData damageData, PlayerActionManagerBase playerAction, out int guardPower, out bool justGuard) { }

	// RVA: 0x1F5D1E0 Offset: 0x1F591E0 VA: 0x1F5D1E0
	private int CalcCurrentHpDamage(SkillActionBase.DamageData damageData, PlayerActionManagerBase playerAction, out int guardPower, out bool justGuard) { }

	// RVA: 0x1F5D5CC Offset: 0x1F595CC VA: 0x1F5D5CC
	private int CalcMaxHpDamage(SkillActionBase.DamageData damageData, PlayerActionManagerBase playerAction, out int guardPower, out bool justGuard) { }

	// RVA: 0x1F5D948 Offset: 0x1F59948 VA: 0x1F5D948
	private int CalcBaseAttack(int baseAtk, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F5C414 Offset: 0x1F58414 VA: 0x1F5C414
	private void CalcHit(SkillActionBase.DamageData damageData, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F5DD9C Offset: 0x1F59D9C VA: 0x1F5DD9C
	private int CalcResist(int damage, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F5E03C Offset: 0x1F5A03C VA: 0x1F5E03C
	private int CalcLastLineDamage(int damage, SkillActionBase.DamageData damageData, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F5E160 Offset: 0x1F5A160 VA: 0x1F5E160 Slot: 70
	protected override bool CheckGuard(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, int damage, out SkillHitReactionType guardType, out bool justGuard) { }

	// RVA: 0x1F5E28C Offset: 0x1F5A28C VA: 0x1F5E28C
	public bool CheckGuard() { }

	// RVA: 0x1F5E29C Offset: 0x1F5A29C VA: 0x1F5E29C Slot: 71
	protected override bool CheckAvoid(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x1F5E39C Offset: 0x1F5A39C VA: 0x1F5E39C
	public bool CheckAvoid() { }

	// RVA: 0x1F5E3AC Offset: 0x1F5A3AC VA: 0x1F5E3AC
	public bool IsRateAttack() { }

	// RVA: 0x1F5E3CC Offset: 0x1F5A3CC VA: 0x1F5E3CC Slot: 67
	public override bool CheckPercentageDamage() { }

	// RVA: 0x1F5E3E0 Offset: 0x1F5A3E0 VA: 0x1F5E3E0 Slot: 68
	public override bool CheckActionType(MobActionType[] actionTypes) { }

	// RVA: 0x1F5E3E8 Offset: 0x1F5A3E8 VA: 0x1F5E3E8 Slot: 69
	public override int CalcTemporaryDamage(EnemyMobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F5E3F0 Offset: 0x1F5A3F0 VA: 0x1F5E3F0
	public void .ctor() { }
}
