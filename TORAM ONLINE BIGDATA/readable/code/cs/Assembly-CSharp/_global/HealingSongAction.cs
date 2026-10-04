// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HealingSongAction : SongActionBase, IMotionSwitchSkill // TypeDefIndex: 3672
{
	// Properties
	protected override int BaseCostMp { get; }
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x23C0394 Offset: 0x23BC394 VA: 0x23C0394 Slot: 91
	protected override int get_BaseCostMp() { }

	// RVA: 0x23C039C Offset: 0x23BC39C VA: 0x23C039C Slot: 93
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x23C03A4 Offset: 0x23BC3A4 VA: 0x23C03A4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C0618 Offset: 0x23BC618 VA: 0x23C0618 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23C0690 Offset: 0x23BC690 VA: 0x23C0690 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C0788 Offset: 0x23BC788 VA: 0x23C0788 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23C096C Offset: 0x23BC96C VA: 0x23C096C Slot: 92
	public override void EffectiveSongBuffer(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23C0C48 Offset: 0x23BCC48 VA: 0x23C0C48 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C0C4C Offset: 0x23BCC4C VA: 0x23C0C4C
	public void .ctor() { }
}
