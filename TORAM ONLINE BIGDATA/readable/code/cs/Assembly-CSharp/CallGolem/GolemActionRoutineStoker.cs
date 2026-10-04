// Assembly: Assembly-CSharp.dll
// Namespace: CallGolem
public class GolemActionRoutineStoker : GolemActionRoutineBase // TypeDefIndex: 9334
{
	// Fields
	private Vector3 movePos; // 0x60
	private Vector3 moveDir; // 0x6C
	private bool isNaviMode; // 0x78
	private Vector3 prevPos; // 0x7C
	private bool isFirstMove; // 0x88

	// Properties
	public override GolemActionRoutineBase.ActionRoutine Routine { get; }

	// Methods

	// RVA: 0x1EBE748 Offset: 0x1EBA748 VA: 0x1EBE748
	public void .ctor(CallGolemAI ai, GameObject actor, CallGolemActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: 0x1EBE814 Offset: 0x1EBA814 VA: 0x1EBE814 Slot: 4
	public override GolemActionRoutineBase.ActionRoutine get_Routine() { }

	// RVA: 0x1EBE81C Offset: 0x1EBA81C VA: 0x1EBE81C Slot: 5
	public override void Update(float playerDistance) { }

	// RVA: 0x1EBEB7C Offset: 0x1EBAB7C VA: 0x1EBEB7C Slot: 6
	public override void ChangeRoutine(GolemActionRoutineBase.ActionRoutine prevRoutine) { }
}
