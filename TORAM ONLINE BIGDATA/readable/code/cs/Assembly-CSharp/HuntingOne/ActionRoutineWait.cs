// Assembly: Assembly-CSharp.dll
// Namespace: HuntingOne
public class ActionRoutineWait : ActionRoutineBase // TypeDefIndex: 9317
{
	// Fields
	private const float WaitTime = 3;
	private float waitTimer; // 0x60
	private bool isSit; // 0x64

	// Properties
	public override ActionRoutineBase.ActionRoutine Routine { get; }

	// Methods

	// RVA: 0x1EBC528 Offset: 0x1EB8528 VA: 0x1EBC528
	public void .ctor(HuntingOneAI ai, GameObject actor, HuntingOneActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: 0x1EBC55C Offset: 0x1EB855C VA: 0x1EBC55C Slot: 4
	public override ActionRoutineBase.ActionRoutine get_Routine() { }

	// RVA: 0x1EBC564 Offset: 0x1EB8564 VA: 0x1EBC564 Slot: 5
	public override void Update(float playerDistance) { }

	// RVA: 0x1EBC6D0 Offset: 0x1EB86D0 VA: 0x1EBC6D0 Slot: 6
	public override void ChangeRoutine(ActionRoutineBase.ActionRoutine prevRoutine) { }
}
