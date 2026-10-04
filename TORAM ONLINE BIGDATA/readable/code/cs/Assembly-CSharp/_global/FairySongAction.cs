// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FairySongAction : SongActionBase, IMotionSwitchSkill // TypeDefIndex: 3652
{
	// Properties
	protected override int BaseCostMp { get; }
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x23B9E50 Offset: 0x23B5E50 VA: 0x23B9E50 Slot: 91
	protected override int get_BaseCostMp() { }

	// RVA: 0x23B9E58 Offset: 0x23B5E58 VA: 0x23B9E58 Slot: 93
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x23B9E60 Offset: 0x23B5E60 VA: 0x23B9E60 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23BA0D4 Offset: 0x23B60D4 VA: 0x23BA0D4 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23BA14C Offset: 0x23B614C VA: 0x23BA14C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BA244 Offset: 0x23B6244 VA: 0x23BA244 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23BA428 Offset: 0x23B6428 VA: 0x23BA428 Slot: 92
	public override void EffectiveSongBuffer(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23BA704 Offset: 0x23B6704 VA: 0x23BA704 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23BA708 Offset: 0x23B6708 VA: 0x23BA708
	public void .ctor() { }
}
