// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobNormalAttack : MobAttackBase // TypeDefIndex: 1146
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x1F630C0 Offset: 0x1F5F0C0 VA: 0x1F630C0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x1F630C8 Offset: 0x1F5F0C8 VA: 0x1F630C8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x1F630D8 Offset: 0x1F5F0D8 VA: 0x1F630D8 Slot: 56
	protected override void calcMobToPlayerDamage(MobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F63F6C Offset: 0x1F5FF6C VA: 0x1F63F6C Slot: 58
	protected override void calcMobToMobDamage(MobActionManagerBase mobAction, MobActionManagerBase targetAction) { }

	// RVA: 0x1F64E50 Offset: 0x1F60E50 VA: 0x1F64E50 Slot: 69
	public override int CalcTemporaryDamage(EnemyMobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F6557C Offset: 0x1F6157C VA: 0x1F6557C
	public void .ctor() { }
}
