// Assembly: Assembly-CSharp.dll
// Namespace: HuntingOne
public abstract class ThinkingRoutineBase : RoutineBase // TypeDefIndex: 9322
{
	// Fields
	private readonly HuntingOneAI ai; // 0x50

	// Properties
	public abstract ThinkingRoutineBase.ThinkingRoutine Routine { get; }

	// Methods

	// RVA: 0x1EBC9E4 Offset: 0x1EB89E4 VA: 0x1EBC9E4
	public void .ctor(HuntingOneAI ai, GameObject actor, HuntingOneActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ThinkingRoutineBase.ThinkingRoutine get_Routine();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Update(float playerSqrDistance);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ChangeRoutine(ThinkingRoutineBase.ThinkingRoutine prevRoutine);

	// RVA: 0x1EBCA18 Offset: 0x1EB8A18 VA: 0x1EBCA18
	protected void ChangeActionRoutine(ActionRoutineBase.ActionRoutine routine) { }

	// RVA: 0x1EBCA34 Offset: 0x1EB8A34 VA: 0x1EBCA34
	protected bool CheckActionRoutine(ActionRoutineBase.ActionRoutine routine) { }

	// RVA: 0x1EBCA50 Offset: 0x1EB8A50 VA: 0x1EBCA50
	protected bool CheckActionRoutineEnd() { }

	// RVA: 0x1EBCA6C Offset: 0x1EB8A6C VA: 0x1EBCA6C
	protected void ChangeThinkingRoutine(ThinkingRoutineBase.ThinkingRoutine routine) { }

	// RVA: 0x1EBCA88 Offset: 0x1EB8A88 VA: 0x1EBCA88
	protected bool CheckThinkingRoutine(ThinkingRoutineBase.ThinkingRoutine routine) { }

	// RVA: 0x1EBCAA4 Offset: 0x1EB8AA4 VA: 0x1EBCAA4
	public bool CheckJointStruggle() { }
}
