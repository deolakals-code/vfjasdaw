// Assembly: Assembly-CSharp.dll
// Namespace: CallGolem
public abstract class GolemRoutineBase // TypeDefIndex: 9338
{
	// Fields
	[CompilerGenerated]
	private ArchetypeUid <ArchetypeUid>k__BackingField; // 0x10
	protected const float WarpDistance = 40;
	protected const float StokerRecognitionDistance = 6;
	protected const float StokerStartDistance = 8;
	protected const float ShieldDistance = 8;
	private readonly CallGolemAI ai; // 0x18
	protected readonly GameObject actor; // 0x20
	protected readonly CallGolemActionManager actorActionManager; // 0x28
	protected readonly GameObject owner; // 0x30
	protected readonly PlayerActionManagerBase ownerActionManager; // 0x38
	private readonly AnimationBase animation; // 0x40
	protected readonly CharacterMove charaMove; // 0x48

	// Properties
	protected ArchetypeUid ArchetypeUid { get; set; }
	protected CallGolemType GolemType { get; }

	// Methods

	// RVA: 0x1EBD850 Offset: 0x1EB9850 VA: 0x1EBD850
	public void .ctor(CallGolemAI ai, GameObject actor, CallGolemActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	[CompilerGenerated]
	// RVA: 0x1EBEEDC Offset: 0x1EBAEDC VA: 0x1EBEEDC
	protected ArchetypeUid get_ArchetypeUid() { }

	[CompilerGenerated]
	// RVA: 0x1EBEEE4 Offset: 0x1EBAEE4 VA: 0x1EBEEE4
	private void set_ArchetypeUid(ArchetypeUid value) { }

	// RVA: 0x1EBE100 Offset: 0x1EBA100 VA: 0x1EBE100
	protected CallGolemType get_GolemType() { }

	// RVA: 0x1EBE3E0 Offset: 0x1EBA3E0 VA: 0x1EBE3E0
	protected bool IsPlayAnimation(CallGolemAnimationNo no) { }

	// RVA: 0x1EBEEEC Offset: 0x1EBAEEC VA: 0x1EBEEEC
	public void ClearAttackTarget() { }

	// RVA: 0x1EBE0E4 Offset: 0x1EBA0E4 VA: 0x1EBE0E4
	public MobActionManagerBase GetAttackTarget() { }

	// RVA: 0x1EBEF08 Offset: 0x1EBAF08 VA: 0x1EBEF08
	public bool ExistAttackTarget() { }

	// RVA: 0x1EBE11C Offset: 0x1EBA11C VA: 0x1EBE11C
	public void UpdateAssistMove(bool flag, float assistMoveTargetDistance) { }

	// RVA: 0x1EBE0C8 Offset: 0x1EBA0C8 VA: 0x1EBE0C8
	public bool CheckAssistMove() { }

	// RVA: 0x1EBEFC8 Offset: 0x1EBAFC8 VA: 0x1EBEFC8
	public float GetAssistMoveTargetDistance() { }
}
