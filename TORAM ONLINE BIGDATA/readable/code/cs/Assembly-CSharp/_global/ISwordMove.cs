// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface ISwordMove // TypeDefIndex: 3379
{
	// Properties
	public abstract bool IsSwordMoveStart { get; }
	public abstract bool IsMoveAssistContinue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsSwordMoveStart();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsMoveAssistContinue();

	// RVA: 0x2354584 Offset: 0x2350584 VA: 0x2354584
	public static bool CheckSwordMoveStart(PlayerActionManagerBase playerAction, SkillActionBase skill) { }
}
