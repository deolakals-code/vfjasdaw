// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPartyRecruitmentApplicationManager.PartyRecruitmentApply : PartyRecruitmentApplyExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7702
{
	// Fields
	private UIPartyRecruitmentApplicationManager uiManager; // 0x18
	private int recruitmentId; // 0x20

	// Methods

	// RVA: 0x1BEB3FC Offset: 0x1BE73FC VA: 0x1BEB3FC
	public void .ctor(int recruitmentId, byte frameNo, bool isRecruitmentList, UIPartyRecruitmentApplicationManager uiManager) { }

	// RVA: 0x1BEBAEC Offset: 0x1BE7AEC VA: 0x1BEBAEC Slot: 15
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1BEBB60 Offset: 0x1BE7B60 VA: 0x1BEBB60 Slot: 11
	protected override void OnNotRecruited(short returnCode) { }

	// RVA: 0x1BEBBB0 Offset: 0x1BE7BB0 VA: 0x1BEBBB0 Slot: 13
	protected override void OnNoVacancies(short returnCode) { }

	// RVA: 0x1BEBC00 Offset: 0x1BE7C00 VA: 0x1BEBC00 Slot: 12
	protected override void OnSlotNotAvailable(short returnCode) { }

	// RVA: 0x1BEBC50 Offset: 0x1BE7C50 VA: 0x1BEBC50 Slot: 10
	protected override void OnSuccess() { }

	// RVA: 0x1BEBC70 Offset: 0x1BE7C70 VA: 0x1BEBC70 Slot: 14
	protected override void OnSystemLock() { }
}
