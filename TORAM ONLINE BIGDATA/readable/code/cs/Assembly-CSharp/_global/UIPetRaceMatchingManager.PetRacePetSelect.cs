// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPetRaceMatchingManager.PetRacePetSelect : PetRacePetSelectExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 5981
{
	// Fields
	private UIPetRaceMatchingManager manager; // 0x18
	private readonly byte selectPetIndex; // 0x20

	// Methods

	// RVA: 0x185DDD4 Offset: 0x1859DD4 VA: 0x185DDD4
	public void .ctor(UIPetRaceMatchingManager manager, byte selectPetIndex, long uid) { }

	// RVA: 0x185ECFC Offset: 0x185ACFC VA: 0x185ECFC Slot: 10
	protected override void OnSuccess(OperationResponse response) { }

	// RVA: 0x185ED24 Offset: 0x185AD24 VA: 0x185ED24 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x185ED28 Offset: 0x185AD28 VA: 0x185ED28 Slot: 15
	protected override void OnSelectFailed(short returnCode) { }

	// RVA: 0x185ED2C Offset: 0x185AD2C VA: 0x185ED2C Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x185EE6C Offset: 0x185AE6C VA: 0x185EE6C Slot: 13
	protected override void OnUnableJoin(short returnCode) { }

	// RVA: 0x185EE74 Offset: 0x185AE74 VA: 0x185EE74 Slot: 14
	protected override void OnWrongStateOrPhase(short returnCode) { }
}
