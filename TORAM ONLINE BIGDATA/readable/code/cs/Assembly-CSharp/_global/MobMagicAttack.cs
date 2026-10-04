// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobMagicAttack : MobAttackBase // TypeDefIndex: 1143
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x1F5F0C0 Offset: 0x1F5B0C0 VA: 0x1F5F0C0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x1F5F0C8 Offset: 0x1F5B0C8 VA: 0x1F5F0C8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x1F5F0D8 Offset: 0x1F5B0D8 VA: 0x1F5F0D8 Slot: 56
	protected override void calcMobToPlayerDamage(MobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F60068 Offset: 0x1F5C068 VA: 0x1F60068 Slot: 58
	protected override void calcMobToMobDamage(MobActionManagerBase mobAction, MobActionManagerBase targetAction) { }

	// RVA: 0x1F60F48 Offset: 0x1F5CF48 VA: 0x1F60F48 Slot: 69
	public override int CalcTemporaryDamage(EnemyMobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F616DC Offset: 0x1F5D6DC VA: 0x1F616DC
	public void .ctor() { }
}
