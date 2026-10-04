// Assembly: Assembly-CSharp.dll
// Namespace: BlackKnightAI
public interface IBlackBoardMemory // TypeDefIndex: 9111
{
	// Properties
	public abstract float SearchStartDistance { get; }
	public abstract bool IsExistTask { get; }
	public abstract Stack<IMobBlackKnightTask> StackTask { get; }
	public abstract GuideRail Rail { get; }
	public abstract MobStatusMaster Master { get; }
	public abstract float Position { get; }
	public abstract float PlayerPosition { get; }
	public abstract Vector2 MoveRange { get; }
	public abstract bool Is3DSetPositon { get; }
	public abstract bool IsInjured { get; }
	public abstract AIIndicationMaterial Material { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_SearchStartDistance();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsExistTask();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Stack<IMobBlackKnightTask> get_StackTask();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract GuideRail get_Rail();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract MobStatusMaster get_Master();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_Position();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_PlayerPosition();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Vector2 get_MoveRange();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_Is3DSetPositon();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsInjured();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract AIIndicationMaterial get_Material();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void SettingTask(IMobBlackKnightTask[] tasks);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void CallBackActionMove(MobBlackKnightAIActionType type, float[] param);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void CallBackActionSkill(int skillId);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void SetChangeState(int nextId);
}
