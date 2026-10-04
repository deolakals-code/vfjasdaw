// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SongOfLifeAction : SongActionBase, IMotionSwitchSkill // TypeDefIndex: 3753
{
	// Properties
	protected override int BaseCostMp { get; }
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x23DD034 Offset: 0x23D9034 VA: 0x23DD034 Slot: 91
	protected override int get_BaseCostMp() { }

	// RVA: 0x23DD03C Offset: 0x23D903C VA: 0x23DD03C Slot: 93
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x23DD044 Offset: 0x23D9044 VA: 0x23DD044 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23DD2B4 Offset: 0x23D92B4 VA: 0x23DD2B4 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23DD328 Offset: 0x23D9328 VA: 0x23DD328 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23DD420 Offset: 0x23D9420 VA: 0x23DD420 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23DD604 Offset: 0x23D9604 VA: 0x23DD604 Slot: 92
	public override void EffectiveSongBuffer(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23DCCBC Offset: 0x23D8CBC VA: 0x23DCCBC
	public static void ChangeHate(PlayerActionManagerBase actorAction) { }

	// RVA: 0x23DD8DC Offset: 0x23D98DC VA: 0x23DD8DC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23DD8E8 Offset: 0x23D98E8 VA: 0x23DD8E8
	public void .ctor() { }
}
