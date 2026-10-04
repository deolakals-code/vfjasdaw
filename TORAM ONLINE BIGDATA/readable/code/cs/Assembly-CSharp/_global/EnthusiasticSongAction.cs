// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EnthusiasticSongAction : SongActionBase, IMotionSwitchSkill // TypeDefIndex: 3646
{
	// Properties
	protected override int BaseCostMp { get; }
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x23B83EC Offset: 0x23B43EC VA: 0x23B83EC Slot: 91
	protected override int get_BaseCostMp() { }

	// RVA: 0x23B83F4 Offset: 0x23B43F4 VA: 0x23B83F4 Slot: 93
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x23B83FC Offset: 0x23B43FC VA: 0x23B83FC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B8670 Offset: 0x23B4670 VA: 0x23B8670 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23B86E8 Offset: 0x23B46E8 VA: 0x23B86E8 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B87E0 Offset: 0x23B47E0 VA: 0x23B87E0 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23B89C4 Offset: 0x23B49C4 VA: 0x23B89C4 Slot: 92
	public override void EffectiveSongBuffer(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23B8CA0 Offset: 0x23B4CA0 VA: 0x23B8CA0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B8CAC Offset: 0x23B4CAC VA: 0x23B8CAC
	public void .ctor() { }
}
