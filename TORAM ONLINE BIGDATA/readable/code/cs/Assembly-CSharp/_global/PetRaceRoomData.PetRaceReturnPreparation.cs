// Assembly: Assembly-CSharp.dll
// Namespace: 
private class PetRaceRoomData.PetRaceReturnPreparation : PetRaceReturnPreparationExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2440
{
	// Fields
	private PetRaceRoomData roomData; // 0x10

	// Methods

	// RVA: 0x21B4520 Offset: 0x21B0520 VA: 0x21B4520
	public void .ctor(PetRaceRoomData roomData) { }

	// RVA: 0x21B5B98 Offset: 0x21B1B98 VA: 0x21B5B98 Slot: 10
	protected override void OnSuccess(OperationResponse response) { }

	// RVA: 0x21B5C58 Offset: 0x21B1C58 VA: 0x21B5C58 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21B5C5C Offset: 0x21B1C5C VA: 0x21B5C5C Slot: 14
	protected override void OnNotJoinedInTheCourse() { }

	// RVA: 0x21B5C60 Offset: 0x21B1C60 VA: 0x21B5C60 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x21B5DA0 Offset: 0x21B1DA0 VA: 0x21B5DA0 Slot: 13
	protected override void OnUnableJoin(short returnCode) { }

	// RVA: 0x21B5DA4 Offset: 0x21B1DA4 VA: 0x21B5DA4 Slot: 15
	protected override void OnWrongStateOrPhase(short returnCode) { }
}
