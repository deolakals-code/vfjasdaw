// Assembly: Assembly-CSharp.dll
// Namespace: 
private class PartyManager.PartyRecruitmentJoin : PartyRecruitmentJoinExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2193
{
	// Methods

	// RVA: 0x216A4CC Offset: 0x21664CC VA: 0x216A4CC
	public void .ctor(int partyId, int recruitmentId) { }

	// RVA: 0x216A4D4 Offset: 0x21664D4 VA: 0x216A4D4 Slot: 14
	protected override void OnCandidateProblem(short returnCode) { }

	// RVA: 0x216A4D8 Offset: 0x21664D8 VA: 0x216A4D8 Slot: 15
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x216A4DC Offset: 0x21664DC VA: 0x216A4DC Slot: 12
	protected override void OnNotRecruited(short returnCode) { }

	// RVA: 0x216A4E0 Offset: 0x21664E0 VA: 0x216A4E0 Slot: 11
	protected override void OnNoVacancies() { }

	// RVA: 0x216A4E4 Offset: 0x21664E4 VA: 0x216A4E4 Slot: 13
	protected override void OnSlotNotAvailable(short returnCode) { }

	// RVA: 0x216A4E8 Offset: 0x21664E8 VA: 0x216A4E8 Slot: 10
	protected override void OnSuccess() { }
}
