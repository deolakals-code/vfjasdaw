// Assembly: Assembly-CSharp.dll
// Namespace: CallGolem
public abstract class GolemThinkingRoutineBase : GolemRoutineBase // TypeDefIndex: 9340
{
	// Fields
	private CallGolemAI ai; // 0x50

	// Properties
	public abstract GolemThinkingRoutineBase.ThinkingRoutine Routine { get; }

	// Methods

	// RVA: 0x1EBEFE4 Offset: 0x1EBAFE4 VA: 0x1EBEFE4
	public void .ctor(CallGolemAI ai, GameObject actor, CallGolemActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract GolemThinkingRoutineBase.ThinkingRoutine get_Routine();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Update(float playerSqrDistance);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ChangeRoutine(GolemThinkingRoutineBase.ThinkingRoutine prevRoutine);

	// RVA: 0x1EBF018 Offset: 0x1EBB018 VA: 0x1EBF018
	protected void ChangeActionRoutine(GolemActionRoutineBase.ActionRoutine routine) { }

	// RVA: 0x1EBF034 Offset: 0x1EBB034 VA: 0x1EBF034
	protected bool CheckActionRoutine(GolemActionRoutineBase.ActionRoutine routine) { }

	// RVA: 0x1EBF050 Offset: 0x1EBB050 VA: 0x1EBF050
	protected bool CheckActionRoutineEnd() { }

	// RVA: 0x1EBF06C Offset: 0x1EBB06C VA: 0x1EBF06C
	protected void ChangeThinkingRoutine(GolemThinkingRoutineBase.ThinkingRoutine routine) { }

	// RVA: 0x1EBF088 Offset: 0x1EBB088 VA: 0x1EBF088
	protected bool CheckThinkingRoutine(GolemThinkingRoutineBase.ThinkingRoutine routine) { }

	// RVA: 0x1EBF0A4 Offset: 0x1EBB0A4 VA: 0x1EBF0A4
	public bool CheckJointStruggle() { }
}
