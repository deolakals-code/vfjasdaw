// Assembly: Assembly-CSharp.dll
// Namespace: HuntingOne
public class ActionRoutineNextActionWait : ActionRoutineBase // TypeDefIndex: 9314
{
	// Fields
	private float nextBattleWaitTimer; // 0x60
	private float angle; // 0x64
	private float dist; // 0x68
	private bool wait; // 0x6C
	private float intervalTimer; // 0x70
	private Vector3 moveDir; // 0x74

	// Properties
	public override ActionRoutineBase.ActionRoutine Routine { get; }

	// Methods

	// RVA: 0x1EBB650 Offset: 0x1EB7650 VA: 0x1EBB650
	public void .ctor(HuntingOneAI ai, GameObject actor, HuntingOneActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: 0x1EBB714 Offset: 0x1EB7714 VA: 0x1EBB714 Slot: 4
	public override ActionRoutineBase.ActionRoutine get_Routine() { }

	// RVA: 0x1EBB71C Offset: 0x1EB771C VA: 0x1EBB71C Slot: 5
	public override void Update(float playerDistance) { }

	// RVA: 0x1EBBE48 Offset: 0x1EB7E48 VA: 0x1EBBE48 Slot: 6
	public override void ChangeRoutine(ActionRoutineBase.ActionRoutine prevRoutine) { }
}
