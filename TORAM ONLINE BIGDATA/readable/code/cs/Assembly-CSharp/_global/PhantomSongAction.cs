// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PhantomSongAction : SongActionBase, IMotionSwitchSkill // TypeDefIndex: 3723
{
	// Properties
	protected override int BaseCostMp { get; }
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x23D3DE8 Offset: 0x23CFDE8 VA: 0x23D3DE8 Slot: 91
	protected override int get_BaseCostMp() { }

	// RVA: 0x23D3DF0 Offset: 0x23CFDF0 VA: 0x23D3DF0 Slot: 93
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x23D3DF8 Offset: 0x23CFDF8 VA: 0x23D3DF8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D4120 Offset: 0x23D0120 VA: 0x23D4120 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23D4218 Offset: 0x23D0218 VA: 0x23D4218 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D4310 Offset: 0x23D0310 VA: 0x23D4310 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23D44F4 Offset: 0x23D04F4 VA: 0x23D44F4 Slot: 92
	public override void EffectiveSongBuffer(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23D47D0 Offset: 0x23D07D0 VA: 0x23D47D0
	public static void ReceiveActionEnd(PlayerActionManagerBase playerAction, PlayerStatusData statusData, int skillParamFlag) { }

	// RVA: 0x23D48D8 Offset: 0x23D08D8 VA: 0x23D48D8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D48E4 Offset: 0x23D08E4 VA: 0x23D48E4
	public void .ctor() { }
}
