// Assembly: Assembly-CSharp.dll
// Namespace: SummonDemonic
public class DemonActionRoutineStoker : DemonActionRoutineBase // TypeDefIndex: 9283
{
	// Fields
	private Vector3 movePos; // 0x58
	private Vector3 moveDir; // 0x64
	private bool isNaviMode; // 0x70
	private Vector3 prevPos; // 0x74
	private bool isFirstMove; // 0x80

	// Properties
	public override DemonActionRoutineBase.ActionRoutine Routine { get; }

	// Methods

	// RVA: 0x1EB8040 Offset: 0x1EB4040 VA: 0x1EB8040 Slot: 4
	public override DemonActionRoutineBase.ActionRoutine get_Routine() { }

	// RVA: 0x1EB8048 Offset: 0x1EB4048 VA: 0x1EB8048
	public void .ctor(SummonDemonicAI ai, GameObject actor, SummonDemonicActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: 0x1EB80FC Offset: 0x1EB40FC VA: 0x1EB80FC Slot: 5
	public override void Update(float playerSqrDistance) { }

	// RVA: 0x1EB8510 Offset: 0x1EB4510 VA: 0x1EB8510 Slot: 6
	public override void ChangeRoutine(DemonActionRoutineBase.ActionRoutine prevRoutine) { }
}
