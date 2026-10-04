// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CallGolemAI // TypeDefIndex: 532
{
	// Fields
	[CompilerGenerated]
	private ArchetypeUid <ArchetypeUid>k__BackingField; // 0x10
	private readonly GameObject actor; // 0x18
	private readonly CallGolemActionManager actorActionManager; // 0x20
	private readonly GameObject owner; // 0x28
	private readonly PlayerActionManagerBase ownerActionManager; // 0x30
	private readonly CharacterMove charaMove; // 0x38
	private readonly AnimationBase animation; // 0x40
	private CallGolemAnimationNo animationNo; // 0x48
	private GolemActionRoutineBase[] actionRoutines; // 0x50
	private GolemActionRoutineBase.ActionRoutine actionRoutine; // 0x58
	private GolemThinkingRoutineBase[] thinkingRoutines; // 0x60
	private GolemThinkingRoutineBase.ThinkingRoutine thinkingRoutine; // 0x68
	private float playerSqrDistance; // 0x6C
	private Vector3 ownerLastMovePos; // 0x70
	private List<CallGolemAI.MapPointData> ownerMovePoint; // 0x80
	private bool isAssistMove; // 0x88
	private float assistMoveTargetDistance; // 0x8C
	private int id; // 0x90
	private MobActionManagerBase attackTargetActionManager; // 0x98

	// Properties
	public ArchetypeUid ArchetypeUid { get; set; }

	// Methods

	// RVA: 0x1830AE0 Offset: 0x182CAE0 VA: 0x1830AE0
	public void .ctor(GameObject actor, CallGolemActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	[CompilerGenerated]
	// RVA: 0x183225C Offset: 0x182E25C VA: 0x183225C
	public ArchetypeUid get_ArchetypeUid() { }

	[CompilerGenerated]
	// RVA: 0x1832264 Offset: 0x182E264 VA: 0x1832264
	private void set_ArchetypeUid(ArchetypeUid value) { }

	// RVA: 0x1830540 Offset: 0x182C540 VA: 0x1830540
	public void Update() { }

	// RVA: 0x1831D68 Offset: 0x182DD68 VA: 0x1831D68
	public void CurrentSkillEnd(SkillActionBase action) { }

	// RVA: 0x18315AC Offset: 0x182D5AC VA: 0x18315AC
	public void EventReserve() { }

	// RVA: 0x18317B8 Offset: 0x182D7B8 VA: 0x18317B8
	public void VanishingObject(GameObject target) { }

	// RVA: 0x183226C Offset: 0x182E26C VA: 0x183226C
	private void CalcDistance(bool igoneHeight, out float sqrDistance) { }

	// RVA: 0x1832660 Offset: 0x182E660 VA: 0x1832660
	public CallGolemType GetGolemType() { }

	// RVA: 0x183267C Offset: 0x182E67C VA: 0x183267C
	public float AttackRange() { }

	// RVA: 0x18326B8 Offset: 0x182E6B8 VA: 0x18326B8
	public void PlayAnimation(CallGolemAnimationNo no, WrapMode mode = 0) { }

	// RVA: 0x18326E0 Offset: 0x182E6E0 VA: 0x18326E0
	public bool IsPlayAnimation(CallGolemAnimationNo no) { }

	// RVA: 0x1832700 Offset: 0x182E700 VA: 0x1832700
	public Vector3 NextOwnerPosition() { }

	// RVA: 0x18327FC Offset: 0x182E7FC VA: 0x18327FC
	public bool ExistOwnerPosition() { }

	// RVA: 0x1832850 Offset: 0x182E850 VA: 0x1832850
	public Vector3 NextNearOwnerPosition() { }

	// RVA: 0x183258C Offset: 0x182E58C VA: 0x183258C
	public void ChangeActionRoutine(GolemActionRoutineBase.ActionRoutine routine) { }

	// RVA: 0x1832A8C Offset: 0x182EA8C VA: 0x1832A8C
	public bool CheckActionRoutine(GolemActionRoutineBase.ActionRoutine routine) { }

	// RVA: 0x1832A9C Offset: 0x182EA9C VA: 0x1832A9C
	public bool CheckActionRoutineEnd() { }

	// RVA: 0x18324B8 Offset: 0x182E4B8 VA: 0x18324B8
	public void ChangeThinkingRoutine(GolemThinkingRoutineBase.ThinkingRoutine routine) { }

	// RVA: 0x1832B54 Offset: 0x182EB54 VA: 0x1832B54
	public bool CheckThinkingRoutine(GolemThinkingRoutineBase.ThinkingRoutine routine) { }

	// RVA: 0x1832360 Offset: 0x182E360 VA: 0x1832360
	public void ClearAttackTarget() { }

	// RVA: 0x1832B90 Offset: 0x182EB90 VA: 0x1832B90
	public MobActionManagerBase GetAttackTarget() { }

	// RVA: 0x1832B98 Offset: 0x182EB98 VA: 0x1832B98
	public bool CheckJointStruggle() { }

	// RVA: 0x183249C Offset: 0x182E49C VA: 0x183249C
	public void UpdateAssistMove(bool flag, float targetDistance) { }

	// RVA: 0x1832CA8 Offset: 0x182ECA8 VA: 0x1832CA8
	public bool CheckAssistMove() { }

	// RVA: 0x1832CB0 Offset: 0x182ECB0 VA: 0x1832CB0
	public float GetAssistMoveTargetDistance() { }
}
