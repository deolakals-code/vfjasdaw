// Assembly: Assembly-CSharp.dll
// Namespace: 
private class PartyManager.PartyRecruitmentGet : PartyRecruitmentGetExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2192
{
	// Fields
	private Action<PartyCandidateData[], TimeSpan[]> callBack; // 0x10

	// Methods

	// RVA: 0x216A3C0 Offset: 0x21663C0 VA: 0x216A3C0
	public void .ctor(Action<PartyCandidateData[], TimeSpan[]> callBack) { }

	// RVA: 0x216A3F0 Offset: 0x21663F0 VA: 0x216A3F0 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x216A434 Offset: 0x2166434 VA: 0x216A434 Slot: 10
	protected override void OnSuccess(PartyRecruitmentGetResponse response) { }
}
