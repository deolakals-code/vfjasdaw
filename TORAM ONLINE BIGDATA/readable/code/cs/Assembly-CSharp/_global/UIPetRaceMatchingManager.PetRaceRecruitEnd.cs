// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPetRaceMatchingManager.PetRaceRecruitEnd : PetRaceRecruitEndExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 5979
{
	// Fields
	private UIPetRaceMatchingManager manager; // 0x10

	// Methods

	// RVA: 0x185E214 Offset: 0x185A214 VA: 0x185E214
	public void .ctor(UIPetRaceMatchingManager manager) { }

	// RVA: 0x185EAB4 Offset: 0x185AAB4 VA: 0x185EAB4 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x185EAB8 Offset: 0x185AAB8 VA: 0x185EAB8 Slot: 10
	protected override void OnSuccess(OperationResponse response) { }

	// RVA: 0x185EAEC Offset: 0x185AAEC VA: 0x185EAEC Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x185EC2C Offset: 0x185AC2C VA: 0x185EC2C Slot: 13
	protected override void OnUnableJoin(short returnCode) { }

	// RVA: 0x185EC34 Offset: 0x185AC34 VA: 0x185EC34 Slot: 14
	protected override void OnWrongStateOrPhase(short returnCode) { }
}
