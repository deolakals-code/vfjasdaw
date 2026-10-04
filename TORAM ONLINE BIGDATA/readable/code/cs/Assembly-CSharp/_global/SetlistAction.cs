// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SetlistAction : SongActionBase // TypeDefIndex: 2820
{
	// Fields
	private SongActionBase useSongSkill; // 0x128

	// Properties
	public override int ActionID { get; }
	public override bool IsMoveAssistContinue { get; }
	protected override int BaseCostMp { get; }

	// Methods

	// RVA: 0x228C3E0 Offset: 0x22883E0 VA: 0x228C3E0 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x228C3E8 Offset: 0x22883E8 VA: 0x228C3E8 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x228C3F0 Offset: 0x22883F0 VA: 0x228C3F0 Slot: 91
	protected override int get_BaseCostMp() { }

	// RVA: 0x228C3F8 Offset: 0x22883F8 VA: 0x228C3F8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x228C7C0 Offset: 0x22887C0 VA: 0x228C7C0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x228C8D4 Offset: 0x22888D4 VA: 0x228C8D4 Slot: 65
	public override void PopSkillNameLabel() { }

	// RVA: 0x228C990 Offset: 0x2288990 VA: 0x228C990 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x228C9FC Offset: 0x22889FC VA: 0x228C9FC
	public void ResetCombo() { }

	// RVA: 0x228CA48 Offset: 0x2288A48 VA: 0x228CA48 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x228C5D0 Offset: 0x22885D0 VA: 0x228C5D0
	public static int GetSkillId() { }

	// RVA: 0x228CA4C Offset: 0x2288A4C VA: 0x228CA4C
	public void .ctor() { }
}
