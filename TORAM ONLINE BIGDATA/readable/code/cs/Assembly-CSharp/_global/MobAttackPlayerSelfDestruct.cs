// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobAttackPlayerSelfDestruct : MobAttackBase // TypeDefIndex: 1136
{
	// Fields
	private SkillAttackType attackType; // 0xE0
	private int baseDamage; // 0xE4

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x1F59740 Offset: 0x1F55740 VA: 0x1F59740 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x1F59748 Offset: 0x1F55748 VA: 0x1F59748 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x1F59758 Offset: 0x1F55758 VA: 0x1F59758
	public void SetParametar(SkillAttackType type, int damage) { }

	// RVA: 0x1F59760 Offset: 0x1F55760 VA: 0x1F59760 Slot: 56
	protected override void calcMobToPlayerDamage(MobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F5A568 Offset: 0x1F56568 VA: 0x1F5A568 Slot: 69
	public override int CalcTemporaryDamage(EnemyMobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F5A570 Offset: 0x1F56570 VA: 0x1F5A570
	public void .ctor() { }
}
