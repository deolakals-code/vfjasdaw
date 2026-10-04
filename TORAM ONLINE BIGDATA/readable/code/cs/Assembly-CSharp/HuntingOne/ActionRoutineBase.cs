// Assembly: Assembly-CSharp.dll
// Namespace: HuntingOne
public abstract class ActionRoutineBase : RoutineBase // TypeDefIndex: 9310
{
	// Fields
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x50
	private readonly HuntingOneAI ai; // 0x58

	// Properties
	public abstract ActionRoutineBase.ActionRoutine Routine { get; }
	public bool IsEnd { get; set; }
	protected float MoveSpeed { get; }

	// Methods

	// RVA: 0x1EBACB0 Offset: 0x1EB6CB0 VA: 0x1EBACB0
	public void .ctor(HuntingOneAI ai, GameObject actor, HuntingOneActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ActionRoutineBase.ActionRoutine get_Routine();

	[CompilerGenerated]
	// RVA: 0x1EBADB8 Offset: 0x1EB6DB8 VA: 0x1EBADB8
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x1EBADC0 Offset: 0x1EB6DC0 VA: 0x1EBADC0
	protected void set_IsEnd(bool value) { }

	// RVA: 0x1EBADCC Offset: 0x1EB6DCC VA: 0x1EBADCC
	protected float get_MoveSpeed() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Update(float playerSqrDistance);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ChangeRoutine(ActionRoutineBase.ActionRoutine prevRoutine);

	// RVA: 0x1EBAE58 Offset: 0x1EB6E58 VA: 0x1EBAE58
	public Vector3 NextOwnerPosition() { }

	// RVA: 0x1EBAE74 Offset: 0x1EB6E74 VA: 0x1EBAE74
	public bool ExistOwnerPosition() { }

	// RVA: 0x1EBAE90 Offset: 0x1EB6E90 VA: 0x1EBAE90
	public Vector3 NextNearOwnerPosition() { }

	// RVA: 0x1EBAEAC Offset: 0x1EB6EAC VA: 0x1EBAEAC
	protected void PlayAnimation(HuntingOneAnimationNo no, WrapMode mode = 0, bool sendEmotion = False) { }
}
