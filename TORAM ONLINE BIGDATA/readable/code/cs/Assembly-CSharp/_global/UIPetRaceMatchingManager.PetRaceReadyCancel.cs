// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPetRaceMatchingManager.PetRaceReadyCancel : PetRaceReadyCancelExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 5985
{
	// Fields
	private UIPetRaceMatchingManager manager; // 0x10

	// Methods

	// RVA: 0x185DE44 Offset: 0x1859E44 VA: 0x185DE44
	public void .ctor(UIPetRaceMatchingManager manager) { }

	// RVA: 0x185F19C Offset: 0x185B19C VA: 0x185F19C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x185F1A0 Offset: 0x185B1A0 VA: 0x185F1A0 Slot: 10
	protected override void OnSuccess(OperationResponse response) { }

	// RVA: 0x185F1B4 Offset: 0x185B1B4 VA: 0x185F1B4 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x185F2F4 Offset: 0x185B2F4 VA: 0x185F2F4 Slot: 13
	protected override void OnUnableJoin(short returnCode) { }

	// RVA: 0x185F2FC Offset: 0x185B2FC VA: 0x185F2FC Slot: 14
	protected override void OnWrongStateOrPhase(short returnCode) { }
}
