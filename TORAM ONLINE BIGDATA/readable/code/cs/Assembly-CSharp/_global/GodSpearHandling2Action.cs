// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GodSpearHandling2Action : HandlingerOfGodspeedAction // TypeDefIndex: 3664
{
	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override bool IsMoveAssistContinue { get; }

	// Methods

	// RVA: 0x23BDEA4 Offset: 0x23B9EA4 VA: 0x23BDEA4 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x23BDEAC Offset: 0x23B9EAC VA: 0x23BDEAC Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x23BDEB4 Offset: 0x23B9EB4 VA: 0x23BDEB4 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x23BDEBC Offset: 0x23B9EBC VA: 0x23BDEBC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BDFD0 Offset: 0x23B9FD0 VA: 0x23BDFD0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BE20C Offset: 0x23BA20C VA: 0x23BE20C Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23BE45C Offset: 0x23BA45C VA: 0x23BE45C
	public void .ctor() { }
}
