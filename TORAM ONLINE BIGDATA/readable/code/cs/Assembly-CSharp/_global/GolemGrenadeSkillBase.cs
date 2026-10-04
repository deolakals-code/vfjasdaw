// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class GolemGrenadeSkillBase : PlayerAttackBase // TypeDefIndex: 3364
{
	// Fields
	protected float skillRate; // 0x120
	protected int constantDamage; // 0x124
	protected float maxThrowingDistance; // 0x128
	protected float attackRange; // 0x12C

	// Properties
	protected abstract int GrenadeEffectColor { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 91
	protected abstract int get_GrenadeEffectColor();

	// RVA: 0x234F728 Offset: 0x234B728 VA: 0x234F728
	protected void GetMagicGrenadeParameter(PlayerStatusBase status, out float skillRate, out int constantDamage, out float maxThrowDistance, out float explosionRange) { }

	// RVA: 0x23517B0 Offset: 0x234D7B0 VA: 0x23517B0
	protected float CalcSkillRate(byte lv, PlayerStatusBase status) { }

	// RVA: 0x2351824 Offset: 0x234D824 VA: 0x2351824
	protected int CalcConstantDamage(byte lv) { }

	// RVA: 0x235182C Offset: 0x234D82C VA: 0x235182C
	protected float CalcMaxThrowingDistance(byte lv) { }

	// RVA: 0x235184C Offset: 0x234D84C VA: 0x235184C
	protected float CalcExplosionRange(byte lv) { }

	// RVA: 0x234FC18 Offset: 0x234BC18 VA: 0x234FC18
	protected SkillLinkedTake CreateTake(Vector3 placePos, float dist) { }

	// RVA: 0x23507FC Offset: 0x234C7FC VA: 0x23507FC
	protected void .ctor() { }
}
