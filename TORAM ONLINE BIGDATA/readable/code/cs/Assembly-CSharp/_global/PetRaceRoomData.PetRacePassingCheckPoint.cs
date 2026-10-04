// Assembly: Assembly-CSharp.dll
// Namespace: 
private class PetRaceRoomData.PetRacePassingCheckPoint : PetRacePassingCheckPointExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2442
{
	// Fields
	private PetRaceRoomData roomData; // 0x18
	private int rootId; // 0x20

	// Methods

	// RVA: 0x21B3AD4 Offset: 0x21AFAD4 VA: 0x21B3AD4
	public void .ctor(PetRaceRoomData roomData, byte id) { }

	// RVA: 0x21B5E6C Offset: 0x21B1E6C VA: 0x21B5E6C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21B5E70 Offset: 0x21B1E70 VA: 0x21B5E70 Slot: 18
	protected override void OnFarFromCheckPoint(short returnCode) { }

	// RVA: 0x21B5E74 Offset: 0x21B1E74 VA: 0x21B5E74 Slot: 14
	protected override void OnNotJoinedInTheCourse() { }

	// RVA: 0x21B5E78 Offset: 0x21B1E78 VA: 0x21B5E78 Slot: 17
	protected override void OnPetInstanceNotExist(short returnCode) { }

	// RVA: 0x21B5F40 Offset: 0x21B1F40 VA: 0x21B5F40 Slot: 10
	protected override void OnSuccess(PetRacePassingCheckPointResponse response) { }

	// RVA: 0x21B5FC0 Offset: 0x21B1FC0 VA: 0x21B5FC0 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x21B6100 Offset: 0x21B2100 VA: 0x21B6100 Slot: 13
	protected override void OnUnableJoin(short returnCode) { }

	// RVA: 0x21B6104 Offset: 0x21B2104 VA: 0x21B6104 Slot: 16
	protected override void OnWrongCheckPointData(short returnCode, byte nextCheckPoint) { }

	// RVA: 0x21B6180 Offset: 0x21B2180 VA: 0x21B6180 Slot: 15
	protected override void OnWrongStateOrPhase(short returnCode) { }
}
