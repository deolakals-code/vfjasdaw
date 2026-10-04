// Assembly: Assembly-CSharp.dll
// Namespace: BlackKnightAI
public interface ISkillParameter // TypeDefIndex: 9115
{
	// Properties
	public abstract MobSkillId SkillId { get; }
	public abstract MobSkillType SkillType { get; }
	public abstract int EffectiveValue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MobSkillId get_SkillId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract MobSkillType get_SkillType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_EffectiveValue();
}
