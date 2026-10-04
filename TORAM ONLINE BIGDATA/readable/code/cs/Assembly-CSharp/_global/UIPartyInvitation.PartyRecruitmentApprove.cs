// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPartyInvitation.PartyRecruitmentApprove : PartyRecruitmentApproveExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7676
{
	// Fields
	private Action<bool> initializeMethod; // 0x18
	private Action callBack; // 0x20

	// Methods

	// RVA: 0x1BE3864 Offset: 0x1BDF864 VA: 0x1BE3864
	public void .ctor(byte frameNo, int targetAvatarUuid, Action<bool> initialize, Action callBack) { }

	// RVA: 0x1BE4048 Offset: 0x1BE0048 VA: 0x1BE4048 Slot: 14
	protected override void OnCandidateProblem(short returnCode) { }

	// RVA: 0x1BE4070 Offset: 0x1BE0070 VA: 0x1BE4070 Slot: 16
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1BE4098 Offset: 0x1BE0098 VA: 0x1BE4098 Slot: 15
	protected override void OnNotLogged() { }

	// RVA: 0x1BE40C0 Offset: 0x1BE00C0 VA: 0x1BE40C0 Slot: 12
	protected override void OnNotRecruited(short returnCode) { }

	// RVA: 0x1BE40E8 Offset: 0x1BE00E8 VA: 0x1BE40E8 Slot: 11
	protected override void OnNoVacancies() { }

	// RVA: 0x1BE4110 Offset: 0x1BE0110 VA: 0x1BE4110 Slot: 13
	protected override void OnSlotNotAvailable(short returnCode) { }

	// RVA: 0x1BE4138 Offset: 0x1BE0138 VA: 0x1BE4138 Slot: 10
	protected override void OnSuccess() { }
}
