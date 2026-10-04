// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPartyRecruitmentApplicationManager.PartyRecruitmentCheck : PartyRecruitmentCheckExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7701
{
	// Fields
	private UIPartyRecruitmentApplicationManager uiManager; // 0x18

	// Methods

	// RVA: 0x1BEB1C8 Offset: 0x1BE71C8 VA: 0x1BEB1C8
	public void .ctor(int recruitmentId, UIPartyRecruitmentApplicationManager uiManager) { }

	// RVA: 0x1BEB9DC Offset: 0x1BE79DC VA: 0x1BEB9DC Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1BEBA2C Offset: 0x1BE7A2C VA: 0x1BEBA2C Slot: 11
	protected override void OnNotRecruited(short returnCode) { }

	// RVA: 0x1BEBA7C Offset: 0x1BE7A7C VA: 0x1BEBA7C Slot: 10
	protected override void OnSuccess(PartyRecruitmentCheckResponse response) { }

	// RVA: 0x1BEBA9C Offset: 0x1BE7A9C VA: 0x1BEBA9C Slot: 12
	protected override void OnSystemLock() { }
}
