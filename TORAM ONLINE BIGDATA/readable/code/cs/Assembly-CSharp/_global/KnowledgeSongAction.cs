// Assembly: Assembly-CSharp.dll
// Namespace: 
public class KnowledgeSongAction : SongActionBase, IMotionSwitchSkill // TypeDefIndex: 3702
{
	// Properties
	protected override int BaseCostMp { get; }
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x23CB060 Offset: 0x23C7060 VA: 0x23CB060 Slot: 91
	protected override int get_BaseCostMp() { }

	// RVA: 0x23CB068 Offset: 0x23C7068 VA: 0x23CB068 Slot: 93
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x23CB070 Offset: 0x23C7070 VA: 0x23CB070 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23CB2E4 Offset: 0x23C72E4 VA: 0x23CB2E4 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23CB35C Offset: 0x23C735C VA: 0x23CB35C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23CB454 Offset: 0x23C7454 VA: 0x23CB454 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23CB638 Offset: 0x23C7638 VA: 0x23CB638 Slot: 92
	public override void EffectiveSongBuffer(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23CB914 Offset: 0x23C7914 VA: 0x23CB914 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23CB920 Offset: 0x23C7920 VA: 0x23CB920
	public void .ctor() { }
}
