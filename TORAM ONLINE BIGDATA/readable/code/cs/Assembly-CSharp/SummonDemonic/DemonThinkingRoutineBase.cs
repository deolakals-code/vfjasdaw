// Assembly: Assembly-CSharp.dll
// Namespace: SummonDemonic
public abstract class DemonThinkingRoutineBase : DemonRoutineBase // TypeDefIndex: 9289
{
	// Fields
	private readonly SummonDemonicAI ai; // 0x48

	// Properties
	public abstract DemonThinkingRoutineBase.ThinkingRoutine Routine { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract DemonThinkingRoutineBase.ThinkingRoutine get_Routine();

	// RVA: 0x1EB88EC Offset: 0x1EB48EC VA: 0x1EB88EC
	public void .ctor(SummonDemonicAI ai, GameObject actor, SummonDemonicActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Update(float playerSqrDistance);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ChangeRoutine(DemonThinkingRoutineBase.ThinkingRoutine prevRoutine);

	// RVA: 0x1EB89A0 Offset: 0x1EB49A0 VA: 0x1EB89A0
	protected void ChangeActionRoutine(DemonActionRoutineBase.ActionRoutine routine) { }

	// RVA: 0x1EB89BC Offset: 0x1EB49BC VA: 0x1EB89BC
	protected bool CheckActionRoutine(DemonActionRoutineBase.ActionRoutine routine) { }

	// RVA: 0x1EB89D8 Offset: 0x1EB49D8 VA: 0x1EB89D8
	protected bool CheckActionRoutineEnd() { }

	// RVA: 0x1EB89F4 Offset: 0x1EB49F4 VA: 0x1EB89F4
	protected void ChangeThinkingRoutine(DemonThinkingRoutineBase.ThinkingRoutine routine) { }

	// RVA: 0x1EB8A10 Offset: 0x1EB4A10 VA: 0x1EB8A10
	public bool CheckThinkingRoutine(DemonThinkingRoutineBase.ThinkingRoutine routine) { }

	// RVA: 0x1EB8A2C Offset: 0x1EB4A2C VA: 0x1EB8A2C
	public bool CheckJointStruggle() { }
}
