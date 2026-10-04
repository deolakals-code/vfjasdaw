// Assembly: Assembly-CSharp.dll
// Namespace: SummonDemonic
public abstract class DemonRoutineBase // TypeDefIndex: 9287
{
	// Fields
	[CompilerGenerated]
	private ArchetypeUid <ArchetypeUid>k__BackingField; // 0x10
	protected const float WarpDistance = 48;
	protected const float StokerRecognitionDistance = 6;
	protected const float StokerStartDistance = 12;
	protected static readonly float ActionRange; // 0x0
	private readonly SummonDemonicAI ai; // 0x18
	protected readonly GameObject actor; // 0x20
	protected readonly SummonDemonicActionManager actorActionManager; // 0x28
	protected readonly GameObject owner; // 0x30
	protected readonly PlayerActionManagerBase ownerActionManager; // 0x38
	protected readonly CharacterMove charaMove; // 0x40

	// Properties
	protected ArchetypeUid ArchetypeUid { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1EB8810 Offset: 0x1EB4810 VA: 0x1EB8810
	protected ArchetypeUid get_ArchetypeUid() { }

	[CompilerGenerated]
	// RVA: 0x1EB8818 Offset: 0x1EB4818 VA: 0x1EB8818
	private void set_ArchetypeUid(ArchetypeUid value) { }

	// RVA: 0x1EB74B0 Offset: 0x1EB34B0 VA: 0x1EB74B0
	public void .ctor(SummonDemonicAI ai, GameObject actor, SummonDemonicActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: 0x1EB7DC8 Offset: 0x1EB3DC8 VA: 0x1EB7DC8
	protected bool IsPlayAnimation(SummonDemonicAnimationNo no) { }

	// RVA: 0x1EB8820 Offset: 0x1EB4820 VA: 0x1EB8820
	public void ClearAttackTarget() { }

	// RVA: 0x1EB7A3C Offset: 0x1EB3A3C VA: 0x1EB7A3C
	public MobActionManagerBase GetAttackTarget() { }

	// RVA: 0x1EB883C Offset: 0x1EB483C VA: 0x1EB883C
	public bool ExistAttackTarget() { }

	// RVA: 0x1EB8860 Offset: 0x1EB4860 VA: 0x1EB8860
	public bool CheckSpecialAttack() { }

	// RVA: 0x1EB7B34 Offset: 0x1EB3B34 VA: 0x1EB7B34
	public void UpdateAssistMove(bool flag, float assistMoveTargetDistance) { }

	// RVA: 0x1EB7A20 Offset: 0x1EB3A20 VA: 0x1EB7A20
	public bool CheckAssistMove() { }

	// RVA: 0x1EB887C Offset: 0x1EB487C VA: 0x1EB887C
	public float GetAssistMoveTargetDistance() { }

	// RVA: 0x1EB7A58 Offset: 0x1EB3A58 VA: 0x1EB7A58
	public float GetActionRange() { }

	// RVA: 0x1EB8898 Offset: 0x1EB4898 VA: 0x1EB8898
	private static void .cctor() { }
}
