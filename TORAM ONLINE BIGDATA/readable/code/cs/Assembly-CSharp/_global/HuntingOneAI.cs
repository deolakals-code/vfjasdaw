// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HuntingOneAI // TypeDefIndex: 588
{
	// Fields
	[CompilerGenerated]
	private ArchetypeUid <ArchetypeUid>k__BackingField; // 0x10
	private readonly GameObject actor; // 0x18
	private readonly HuntingOneActionManager actorActionManager; // 0x20
	private readonly GameObject owner; // 0x28
	private readonly PlayerActionManagerBase ownerActionManager; // 0x30
	private readonly CharacterMove charaMove; // 0x38
	private readonly AnimationBase animation; // 0x40
	private HuntingOneAnimationNo animationNo; // 0x48
	private float playerSqrDistance; // 0x4C
	private Vector3 playerDirection; // 0x50
	private Vector3 ownerLastMovePos; // 0x5C
	private List<HuntingOneAI.MapPointData> ownerMovePoint; // 0x68
	private ActionRoutineBase[] actionRoutines; // 0x70
	private ActionRoutineBase.ActionRoutine actionRoutine; // 0x78
	private ThinkingRoutineBase[] thinkingRoutines; // 0x80
	private ThinkingRoutineBase.ThinkingRoutine thinkingRoutine; // 0x88
	private MobActionManagerBase attackTargetActionManager; // 0x90
	private bool isAssistMove; // 0x98
	private int id; // 0x9C
	private float assistMoveTargetDistance; // 0xA0

	// Properties
	public ArchetypeUid ArchetypeUid { get; set; }

	// Methods

	// RVA: 0x1907B0C Offset: 0x1903B0C VA: 0x1907B0C
	public void .ctor(GameObject actor, HuntingOneActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	[CompilerGenerated]
	// RVA: 0x190977C Offset: 0x190577C VA: 0x190977C
	public ArchetypeUid get_ArchetypeUid() { }

	[CompilerGenerated]
	// RVA: 0x1909784 Offset: 0x1905784 VA: 0x1909784
	private void set_ArchetypeUid(ArchetypeUid value) { }

	// RVA: 0x1907558 Offset: 0x1903558 VA: 0x1907558
	public void Update() { }

	// RVA: 0x1908EDC Offset: 0x1904EDC VA: 0x1908EDC
	public void CurrentSkillEnd(SkillActionBase action) { }

	// RVA: 0x190882C Offset: 0x190482C VA: 0x190882C
	public void EventReserve() { }

	// RVA: 0x1908A38 Offset: 0x1904A38 VA: 0x1908A38
	public void VanishingObject(GameObject target) { }

	// RVA: 0x1909300 Offset: 0x1905300 VA: 0x1909300
	public void OwnerDead(int value) { }

	// RVA: 0x19093C0 Offset: 0x19053C0 VA: 0x19093C0
	public bool CheckOwnerResurrect() { }

	// RVA: 0x190978C Offset: 0x190578C VA: 0x190978C
	private void CalcDistance(bool igoneHeight, out float sqrDistance) { }

	// RVA: 0x1909D08 Offset: 0x1905D08 VA: 0x1909D08
	public Vector3 NextOwnerPosition() { }

	// RVA: 0x1909E04 Offset: 0x1905E04 VA: 0x1909E04
	public bool ExistOwnerPosition() { }

	// RVA: 0x1909E58 Offset: 0x1905E58 VA: 0x1909E58
	public Vector3 NextNearOwnerPosition() { }

	// RVA: 0x1909C34 Offset: 0x1905C34 VA: 0x1909C34
	public void ChangeActionRoutine(ActionRoutineBase.ActionRoutine routine) { }

	// RVA: 0x190A094 Offset: 0x1906094 VA: 0x190A094
	public bool CheckActionRoutine(ActionRoutineBase.ActionRoutine routine) { }

	// RVA: 0x190A0A4 Offset: 0x19060A4 VA: 0x190A0A4
	public bool CheckActionRoutineEnd() { }

	// RVA: 0x1909B60 Offset: 0x1905B60 VA: 0x1909B60
	public void ChangeThinkingRoutine(ThinkingRoutineBase.ThinkingRoutine routine) { }

	// RVA: 0x190A15C Offset: 0x190615C VA: 0x190A15C
	public bool CheckThinkingRoutine(ThinkingRoutineBase.ThinkingRoutine routine) { }

	// RVA: 0x190A16C Offset: 0x190616C VA: 0x190A16C
	public void PlayAnimation(HuntingOneAnimationNo no, WrapMode mode = 0) { }

	// RVA: 0x190A194 Offset: 0x1906194 VA: 0x190A194
	public bool IsPlayAnimation(HuntingOneAnimationNo no) { }

	// RVA: 0x1909A1C Offset: 0x1905A1C VA: 0x1909A1C
	public void ClearAttackTarget() { }

	// RVA: 0x190A1B4 Offset: 0x19061B4 VA: 0x190A1B4
	public MobActionManagerBase GetAttackTarget() { }

	// RVA: 0x190A1BC Offset: 0x19061BC VA: 0x190A1BC
	public bool CheckJointStruggle() { }

	// RVA: 0x1909B44 Offset: 0x1905B44 VA: 0x1909B44
	public void UpdateAssistMove(bool flag, float targetDistance) { }

	// RVA: 0x190A2CC Offset: 0x19062CC VA: 0x190A2CC
	public bool CheckAssistMove() { }

	// RVA: 0x190A2D4 Offset: 0x19062D4 VA: 0x190A2D4
	public float GetAssistMoveTargetDistance() { }
}
