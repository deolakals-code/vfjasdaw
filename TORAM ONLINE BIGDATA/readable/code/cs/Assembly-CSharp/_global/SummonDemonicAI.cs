// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummonDemonicAI // TypeDefIndex: 1631
{
	// Fields
	[CompilerGenerated]
	private ArchetypeUid <ArchetypeUid>k__BackingField; // 0x10
	private GameObject actor; // 0x18
	private SummonDemonicActionManager actorActionManager; // 0x20
	private GameObject owner; // 0x28
	private PlayerActionManagerBase ownerActionManager; // 0x30
	private CharacterMove charaMove; // 0x38
	private AnimationBase animation; // 0x40
	private SummonDemonicAnimationNo animationNo; // 0x48
	private float playerSqrDistance; // 0x4C
	private Vector3 ownerLastMovePos; // 0x50
	private List<SummonDemonicAI.MapPointData> ownerMovePoint; // 0x60
	private int movePointId; // 0x68
	private DemonActionRoutineBase[] actionRoutines; // 0x70
	private DemonActionRoutineBase.ActionRoutine actionRoutine; // 0x78
	private DemonThinkingRoutineBase[] thinkingRoutines; // 0x80
	private DemonThinkingRoutineBase.ThinkingRoutine thinkingRoutine; // 0x88
	private MobActionManagerBase attackTargetActionManager; // 0x90
	private bool isAssistMove; // 0x98
	private float assistMoveTargetDistance; // 0x9C
	private int specialAttackPercent; // 0xA0
	private PlayerDataManager player; // 0xA8

	// Properties
	public ArchetypeUid ArchetypeUid { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x209B908 Offset: 0x2097908 VA: 0x209B908
	public ArchetypeUid get_ArchetypeUid() { }

	[CompilerGenerated]
	// RVA: 0x209B910 Offset: 0x2097910 VA: 0x209B910
	private void set_ArchetypeUid(ArchetypeUid value) { }

	// RVA: 0x2099FC8 Offset: 0x2095FC8 VA: 0x2099FC8
	public void .ctor(GameObject actor, SummonDemonicActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: 0x2099A40 Offset: 0x2095A40 VA: 0x2099A40
	public void Update() { }

	// RVA: 0x2099C6C Offset: 0x2095C6C VA: 0x2099C6C
	public void UpdateTimer() { }

	// RVA: 0x209B350 Offset: 0x2097350 VA: 0x209B350
	public void CurrentSkillEnd(SkillActionBase action) { }

	// RVA: 0x209BBA8 Offset: 0x2097BA8 VA: 0x209BBA8
	public bool CheckSpecialAttack() { }

	// RVA: 0x209B51C Offset: 0x209751C VA: 0x209B51C
	public void ReserveDarkAttack() { }

	// RVA: 0x209AC8C Offset: 0x2096C8C VA: 0x209AC8C
	public void EventReserve() { }

	// RVA: 0x209AE98 Offset: 0x2096E98 VA: 0x209AE98
	public void VanishingObject(GameObject target) { }

	// RVA: 0x209B918 Offset: 0x2097918 VA: 0x209B918
	private void CalcDistance(bool ignoreHeight, out float sqrDistance) { }

	// RVA: 0x209BE2C Offset: 0x2097E2C VA: 0x209BE2C
	public Vector3 NextOwnerPosition() { }

	// RVA: 0x209BF28 Offset: 0x2097F28 VA: 0x209BF28
	public bool ExistOwnerPosition() { }

	// RVA: 0x209BF7C Offset: 0x2097F7C VA: 0x209BF7C
	public Vector3 NextNearOwnerPosition() { }

	// RVA: 0x209BDDC Offset: 0x2097DDC VA: 0x209BDDC
	public void ChangeActionRoutine(DemonActionRoutineBase.ActionRoutine routine) { }

	// RVA: 0x209C1B8 Offset: 0x20981B8 VA: 0x209C1B8
	public bool CheckActionRoutine(DemonActionRoutineBase.ActionRoutine routine) { }

	// RVA: 0x209C1C8 Offset: 0x20981C8 VA: 0x209C1C8
	public bool CheckActionRoutineEnd() { }

	// RVA: 0x209BD8C Offset: 0x2097D8C VA: 0x209BD8C
	public void ChangeThinkingRoutine(DemonThinkingRoutineBase.ThinkingRoutine routine) { }

	// RVA: 0x209C280 Offset: 0x2098280 VA: 0x209C280
	public bool CheckThinkingRoutine(DemonThinkingRoutineBase.ThinkingRoutine routine) { }

	// RVA: 0x209C290 Offset: 0x2098290 VA: 0x209C290
	public void PlayAnimation(SummonDemonicAnimationNo no, WrapMode mode = 0) { }

	// RVA: 0x209C2B8 Offset: 0x20982B8 VA: 0x209C2B8
	public bool IsPlayAnimation(SummonDemonicAnimationNo no) { }

	// RVA: 0x209BC48 Offset: 0x2097C48 VA: 0x209BC48
	public void ClearAttackTarget() { }

	// RVA: 0x209C2D8 Offset: 0x20982D8 VA: 0x209C2D8
	public MobActionManagerBase GetAttackTarget() { }

	// RVA: 0x209C2E0 Offset: 0x20982E0 VA: 0x209C2E0
	public bool CheckJointStruggle() { }

	// RVA: 0x209BD70 Offset: 0x2097D70 VA: 0x209BD70
	public void UpdateAssistMove(bool flag, float targetDistance) { }

	// RVA: 0x209C3F0 Offset: 0x20983F0 VA: 0x209C3F0
	public bool CheckAssistMove() { }

	// RVA: 0x209C3F8 Offset: 0x20983F8 VA: 0x209C3F8
	public float GetAssistMoveTargetDistance() { }
}
