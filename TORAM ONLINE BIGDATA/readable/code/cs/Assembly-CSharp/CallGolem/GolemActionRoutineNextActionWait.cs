// Assembly: Assembly-CSharp.dll
// Namespace: CallGolem
public class GolemActionRoutineNextActionWait : GolemActionRoutineBase // TypeDefIndex: 9333
{
	// Fields
	private float nextBattleWaitTimer; // 0x60

	// Properties
	public override GolemActionRoutineBase.ActionRoutine Routine { get; }

	// Methods

	// RVA: 0x1EBE408 Offset: 0x1EBA408 VA: 0x1EBE408
	public void .ctor(CallGolemAI ai, GameObject actor, CallGolemActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: 0x1EBE43C Offset: 0x1EBA43C VA: 0x1EBE43C Slot: 4
	public override GolemActionRoutineBase.ActionRoutine get_Routine() { }

	// RVA: 0x1EBE444 Offset: 0x1EBA444 VA: 0x1EBE444 Slot: 5
	public override void Update(float playerDistance) { }

	// RVA: 0x1EBE55C Offset: 0x1EBA55C VA: 0x1EBE55C Slot: 6
	public override void ChangeRoutine(GolemActionRoutineBase.ActionRoutine prevRoutine) { }
}
