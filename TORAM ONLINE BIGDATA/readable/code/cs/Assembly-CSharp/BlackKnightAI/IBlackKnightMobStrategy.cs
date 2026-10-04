// Assembly: Assembly-CSharp.dll
// Namespace: BlackKnightAI
public interface IBlackKnightMobStrategy // TypeDefIndex: 9123
{
	// Properties
	public abstract int SkillNum { get; }
	public abstract bool IsAction { get; }
	public abstract MobActionPattern SelectSkill { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_SkillNum();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsAction();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract MobActionPattern get_SelectSkill();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ThinkStrategy();
}
