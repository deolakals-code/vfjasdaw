// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPartyRecruitmentRegistrationManager.PartyRecruitmentUpdate : PartyRecruitmentUpdateExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7712
{
	// Fields
	private UIPartyRecruitmentRegistrationManager uiManager; // 0x38
	private string partyName; // 0x40
	private string partyComment; // 0x48
	private PartyMemberFrameData[] memberFrames; // 0x50
	private byte selectRecruitmentType; // 0x58

	// Methods

	// RVA: 0x1BEF050 Offset: 0x1BEB050 VA: 0x1BEF050
	public void .ctor(int recruitmentId, string partyName, byte recruitmentType, string partyComments, PartyMemberFrameData[] memberFrames, UIPartyRecruitmentRegistrationManager uiManager) { }

	// RVA: 0x1BEFBF8 Offset: 0x1BEBBF8 VA: 0x1BEFBF8 Slot: 12
	protected override void OnContentProblem(short returnCode) { }

	// RVA: 0x1BEFC48 Offset: 0x1BEBC48 VA: 0x1BEFC48 Slot: 16
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1BEFC98 Offset: 0x1BEBC98 VA: 0x1BEFC98 Slot: 13
	protected override void OnMemberRecruitingProblem(short returnCode) { }

	// RVA: 0x1BEFCE8 Offset: 0x1BEBCE8 VA: 0x1BEFCE8 Slot: 14
	protected override void OnNotRecruiting(short returnCode) { }

	// RVA: 0x1BEFD38 Offset: 0x1BEBD38 VA: 0x1BEFD38 Slot: 11
	protected override void OnStringProblem(short returnCode) { }

	// RVA: 0x1BEFD88 Offset: 0x1BEBD88 VA: 0x1BEFD88 Slot: 10
	protected override void OnSuccess(PartyRecruitmentUpdateResponse response) { }

	// RVA: 0x1BEFEE8 Offset: 0x1BEBEE8 VA: 0x1BEFEE8 Slot: 15
	protected override void OnSystemLock() { }
}
