// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPartyRecruitmentRegistrationManager.PartyRecruiting : PartyRecruitingExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7711
{
	// Fields
	private UIPartyRecruitmentRegistrationManager uiManager; // 0x30
	private string partyName; // 0x38
	private string partyComment; // 0x40
	private PartyMemberFrameData[] memberFrames; // 0x48
	private byte selectRecruitmentType; // 0x50

	// Methods

	// RVA: 0x1BEF15C Offset: 0x1BEB15C VA: 0x1BEF15C
	public void .ctor(string partyName, byte recruitmentType, string partyComments, PartyMemberFrameData[] memberFrames, UIPartyRecruitmentRegistrationManager uiManager) { }

	// RVA: 0x1BEF918 Offset: 0x1BEB918 VA: 0x1BEF918 Slot: 12
	protected override void OnContentProblem(short returnCode) { }

	// RVA: 0x1BEF968 Offset: 0x1BEB968 VA: 0x1BEF968 Slot: 15
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1BEF9B8 Offset: 0x1BEB9B8 VA: 0x1BEF9B8 Slot: 13
	protected override void OnMemberRecruitingProblem(short returnCode) { }

	// RVA: 0x1BEFA08 Offset: 0x1BEBA08 VA: 0x1BEFA08 Slot: 11
	protected override void OnStringProblem(short returnCode) { }

	// RVA: 0x1BEFA58 Offset: 0x1BEBA58 VA: 0x1BEFA58 Slot: 10
	protected override void OnSuccess(PartyRecruitingResponse response) { }

	// RVA: 0x1BEFBA8 Offset: 0x1BEBBA8 VA: 0x1BEFBA8 Slot: 14
	protected override void OnSystemLock() { }
}
