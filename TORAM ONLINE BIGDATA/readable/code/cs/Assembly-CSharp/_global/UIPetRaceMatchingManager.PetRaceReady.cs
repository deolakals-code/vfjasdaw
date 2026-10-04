// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPetRaceMatchingManager.PetRaceReady : PetRaceReadyExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 5983
{
	// Fields
	private UIPetRaceMatchingManager manager; // 0x10

	// Methods

	// RVA: 0x185DE14 Offset: 0x1859E14 VA: 0x185DE14
	public void .ctor(UIPetRaceMatchingManager manager) { }

	// RVA: 0x185EF3C Offset: 0x185AF3C VA: 0x185EF3C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x185EF74 Offset: 0x185AF74 VA: 0x185EF74 Slot: 10
	protected override void OnSuccess(OperationResponse response) { }

	// RVA: 0x185EF8C Offset: 0x185AF8C VA: 0x185EF8C Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x185F0CC Offset: 0x185B0CC VA: 0x185F0CC Slot: 13
	protected override void OnUnableJoin(short returnCode) { }

	// RVA: 0x185F0D4 Offset: 0x185B0D4 VA: 0x185F0D4 Slot: 14
	protected override void OnWrongStateOrPhase(short returnCode) { }
}
