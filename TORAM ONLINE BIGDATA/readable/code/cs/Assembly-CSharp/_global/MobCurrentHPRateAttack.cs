// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobCurrentHPRateAttack : MobAttackBase // TypeDefIndex: 1137
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x1F5A5C8 Offset: 0x1F565C8 VA: 0x1F5A5C8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x1F5A5D0 Offset: 0x1F565D0 VA: 0x1F5A5D0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x1F5A5E0 Offset: 0x1F565E0 VA: 0x1F5A5E0 Slot: 56
	protected override void calcMobToPlayerDamage(MobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F5B28C Offset: 0x1F5728C VA: 0x1F5B28C Slot: 58
	protected override void calcMobToMobDamage(MobActionManagerBase mobAction, MobActionManagerBase targetAction) { }

	// RVA: 0x1F5BC34 Offset: 0x1F57C34 VA: 0x1F5BC34 Slot: 69
	public override int CalcTemporaryDamage(EnemyMobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F5BFBC Offset: 0x1F57FBC VA: 0x1F5BFBC
	public void .ctor() { }
}
