// Assembly: Assembly-CSharp.dll
// Namespace: SummonDemonic
public class DemonActionRoutineNextActionWait : DemonActionRoutineBase // TypeDefIndex: 9282
{
	// Fields
	private float nextBattleWaitTimer; // 0x58

	// Properties
	public override DemonActionRoutineBase.ActionRoutine Routine { get; }

	// Methods

	// RVA: 0x1EB7DF0 Offset: 0x1EB3DF0 VA: 0x1EB7DF0 Slot: 4
	public override DemonActionRoutineBase.ActionRoutine get_Routine() { }

	// RVA: 0x1EB7DF8 Offset: 0x1EB3DF8 VA: 0x1EB7DF8
	public void .ctor(SummonDemonicAI ai, GameObject actor, SummonDemonicActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: 0x1EB7DFC Offset: 0x1EB3DFC VA: 0x1EB7DFC Slot: 5
	public override void Update(float playerSqrDistance) { }

	// RVA: 0x1EB7E60 Offset: 0x1EB3E60 VA: 0x1EB7E60 Slot: 6
	public override void ChangeRoutine(DemonActionRoutineBase.ActionRoutine prevRoutine) { }
}
