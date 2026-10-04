// Assembly: Assembly-CSharp.dll
// Namespace: HuntingOne
public class ActionRoutineStoker : ActionRoutineBase // TypeDefIndex: 9316
{
	// Fields
	private Vector3 movePos; // 0x60
	private Vector3 moveDir; // 0x6C
	private bool isNaviMode; // 0x78
	private Vector3 prevPos; // 0x7C
	private bool isFirstMove; // 0x88

	// Properties
	public override ActionRoutineBase.ActionRoutine Routine { get; }

	// Methods

	// RVA: 0x1EBBFBC Offset: 0x1EB7FBC VA: 0x1EBBFBC
	public void .ctor(HuntingOneAI ai, GameObject actor, HuntingOneActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: 0x1EBC088 Offset: 0x1EB8088 VA: 0x1EBC088 Slot: 4
	public override ActionRoutineBase.ActionRoutine get_Routine() { }

	// RVA: 0x1EBC090 Offset: 0x1EB8090 VA: 0x1EBC090 Slot: 5
	public override void Update(float playerDistance) { }

	// RVA: 0x1EBC4BC Offset: 0x1EB84BC VA: 0x1EBC4BC Slot: 6
	public override void ChangeRoutine(ActionRoutineBase.ActionRoutine prevRoutine) { }
}
