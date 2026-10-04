// Assembly: Assembly-CSharp.dll
// Namespace: SummonDemonic
public abstract class DemonActionRoutineBase : DemonRoutineBase // TypeDefIndex: 9278
{
	// Fields
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x48
	private readonly SummonDemonicAI ai; // 0x50

	// Properties
	public abstract DemonActionRoutineBase.ActionRoutine Routine { get; }
	public bool IsEnd { get; set; }
	protected float MoveSpeed { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract DemonActionRoutineBase.ActionRoutine get_Routine();

	[CompilerGenerated]
	// RVA: 0x1EB735C Offset: 0x1EB335C VA: 0x1EB735C
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x1EB7364 Offset: 0x1EB3364 VA: 0x1EB7364
	protected void set_IsEnd(bool value) { }

	// RVA: 0x1EB7370 Offset: 0x1EB3370 VA: 0x1EB7370
	protected float get_MoveSpeed() { }

	// RVA: 0x1EB73FC Offset: 0x1EB33FC VA: 0x1EB73FC
	public void .ctor(SummonDemonicAI ai, GameObject actor, SummonDemonicActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Update(float playerSqrDistance);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ChangeRoutine(DemonActionRoutineBase.ActionRoutine prevRoutine);

	// RVA: 0x1EB7568 Offset: 0x1EB3568 VA: 0x1EB7568
	public Vector3 NextOwnerPosition() { }

	// RVA: 0x1EB7584 Offset: 0x1EB3584 VA: 0x1EB7584
	public bool ExistOwnerPosition() { }

	// RVA: 0x1EB75A0 Offset: 0x1EB35A0 VA: 0x1EB75A0
	public Vector3 NextNearOwnerPosition() { }

	// RVA: 0x1EB75BC Offset: 0x1EB35BC VA: 0x1EB75BC
	protected void PlayAnimation(SummonDemonicAnimationNo no, WrapMode mode = 0, bool sendEmotion = False) { }
}
