// Assembly: Assembly-CSharp.dll
// Namespace: CallGolem
public abstract class GolemActionRoutineBase : GolemRoutineBase // TypeDefIndex: 9329
{
	// Fields
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x50
	private readonly CallGolemAI ai; // 0x58

	// Properties
	public abstract GolemActionRoutineBase.ActionRoutine Routine { get; }
	public bool IsEnd { get; set; }
	protected float MoveSpeed { get; }

	// Methods

	// RVA: 0x1EBD81C Offset: 0x1EB981C VA: 0x1EBD81C
	public void .ctor(CallGolemAI ai, GameObject actor, CallGolemActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract GolemActionRoutineBase.ActionRoutine get_Routine();

	[CompilerGenerated]
	// RVA: 0x1EBD924 Offset: 0x1EB9924 VA: 0x1EBD924
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x1EBD92C Offset: 0x1EB992C VA: 0x1EBD92C
	protected void set_IsEnd(bool value) { }

	// RVA: 0x1EBD938 Offset: 0x1EB9938 VA: 0x1EBD938
	protected float get_MoveSpeed() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Update(float playerSqrDistance);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ChangeRoutine(GolemActionRoutineBase.ActionRoutine prevRoutine);

	// RVA: 0x1EBD9C4 Offset: 0x1EB99C4 VA: 0x1EBD9C4
	public Vector3 NextOwnerPosition() { }

	// RVA: 0x1EBD9E0 Offset: 0x1EB99E0 VA: 0x1EBD9E0
	public bool ExistOwnerPosition() { }

	// RVA: 0x1EBD9FC Offset: 0x1EB99FC VA: 0x1EBD9FC
	public Vector3 NextNearOwnerPosition() { }

	// RVA: 0x1EBDA18 Offset: 0x1EB9A18 VA: 0x1EBDA18
	protected void PlayAnimation(CallGolemAnimationNo no, WrapMode mode = 0, bool sendEmotion = False) { }
}
