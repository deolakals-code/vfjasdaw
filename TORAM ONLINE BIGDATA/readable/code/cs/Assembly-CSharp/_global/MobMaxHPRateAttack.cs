// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobMaxHPRateAttack : MobAttackBase // TypeDefIndex: 1144
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x1F61734 Offset: 0x1F5D734 VA: 0x1F61734 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x1F6173C Offset: 0x1F5D73C VA: 0x1F6173C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x1F6174C Offset: 0x1F5D74C VA: 0x1F6174C Slot: 56
	protected override void calcMobToPlayerDamage(MobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F6235C Offset: 0x1F5E35C VA: 0x1F6235C Slot: 58
	protected override void calcMobToMobDamage(MobActionManagerBase mobAction, MobActionManagerBase targetAction) { }

	// RVA: 0x1F62C7C Offset: 0x1F5EC7C VA: 0x1F62C7C Slot: 69
	public override int CalcTemporaryDamage(EnemyMobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F62FF0 Offset: 0x1F5EFF0 VA: 0x1F62FF0
	public void .ctor() { }
}
