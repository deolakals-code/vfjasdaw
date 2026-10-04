// Assembly: Assembly-CSharp.dll
// Namespace: 
private class PetRaceRoomData.PetRaceCourseFieldChange : PetRaceCourseFieldChangeExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2434
{
	// Fields
	private PetRaceRoomData roomData; // 0x10

	// Methods

	// RVA: 0x21B42E0 Offset: 0x21B02E0 VA: 0x21B42E0
	public void .ctor(PetRaceRoomData roomData) { }

	// RVA: 0x21B5148 Offset: 0x21B1148 VA: 0x21B5148 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21B514C Offset: 0x21B114C VA: 0x21B514C Slot: 10
	protected override void OnSuccess(OperationResponse response) { }

	// RVA: 0x21B51B4 Offset: 0x21B11B4 VA: 0x21B51B4 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x21B52F4 Offset: 0x21B12F4 VA: 0x21B52F4 Slot: 13
	protected override void OnUnableJoin(short returnCode) { }

	// RVA: 0x21B52F8 Offset: 0x21B12F8 VA: 0x21B52F8 Slot: 14
	protected override void OnWrongStateOrPhase(short returnCode) { }
}
