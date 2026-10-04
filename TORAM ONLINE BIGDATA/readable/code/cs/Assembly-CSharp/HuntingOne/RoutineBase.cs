// Assembly: Assembly-CSharp.dll
// Namespace: HuntingOne
public abstract class RoutineBase // TypeDefIndex: 9320
{
	// Fields
	[CompilerGenerated]
	private ArchetypeUid <ArchetypeUid>k__BackingField; // 0x10
	protected const float WarpDistance = 40;
	protected const float StokerRecognitionDistance = 6;
	protected const float StokerStartDistance = 12;
	private readonly HuntingOneAI ai; // 0x18
	protected readonly GameObject actor; // 0x20
	protected readonly HuntingOneActionManager actorActionManager; // 0x28
	protected readonly GameObject owner; // 0x30
	protected readonly PlayerActionManagerBase ownerActionManager; // 0x38
	private readonly AnimationBase animation; // 0x40
	protected readonly CharacterMove charaMove; // 0x48

	// Properties
	protected ArchetypeUid ArchetypeUid { get; set; }

	// Methods

	// RVA: 0x1EBACE4 Offset: 0x1EB6CE4 VA: 0x1EBACE4
	public void .ctor(HuntingOneAI ai, GameObject actor, HuntingOneActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	[CompilerGenerated]
	// RVA: 0x1EBC978 Offset: 0x1EB8978 VA: 0x1EBC978
	protected ArchetypeUid get_ArchetypeUid() { }

	[CompilerGenerated]
	// RVA: 0x1EBC980 Offset: 0x1EB8980 VA: 0x1EBC980
	private void set_ArchetypeUid(ArchetypeUid value) { }

	// RVA: 0x1EBB628 Offset: 0x1EB7628 VA: 0x1EBB628
	protected bool IsPlayAnimation(HuntingOneAnimationNo no) { }

	// RVA: 0x1EBC988 Offset: 0x1EB8988 VA: 0x1EBC988
	public void ClearAttackTarget() { }

	// RVA: 0x1EBB348 Offset: 0x1EB7348 VA: 0x1EBB348
	public MobActionManagerBase GetAttackTarget() { }

	// RVA: 0x1EBC9A4 Offset: 0x1EB89A4 VA: 0x1EBC9A4
	public bool ExistAttackTarget() { }

	// RVA: 0x1EBB364 Offset: 0x1EB7364 VA: 0x1EBB364
	public void UpdateAssistMove(bool flag, float assistMoveTargetDistance) { }

	// RVA: 0x1EBB32C Offset: 0x1EB732C VA: 0x1EBB32C
	public bool CheckAssistMove() { }

	// RVA: 0x1EBC9C8 Offset: 0x1EB89C8 VA: 0x1EBC9C8
	public float GetAssistMoveTargetDistance() { }
}
