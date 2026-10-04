// Assembly: Assembly-CSharp.dll
// Namespace: 
private class PetRaceRoomData.PetRaceMovieEnd : PetRaceMovieEndExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2436
{
	// Fields
	private PetRaceRoomData roomData; // 0x10

	// Methods

	// RVA: 0x21B30C8 Offset: 0x21AF0C8 VA: 0x21B30C8
	public void .ctor(PetRaceRoomData roomData) { }

	// RVA: 0x21B53D0 Offset: 0x21B13D0 VA: 0x21B53D0 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21B53D4 Offset: 0x21B13D4 VA: 0x21B53D4 Slot: 14
	protected override void OnNotJoinedInTheCourse() { }

	// RVA: 0x21B53D8 Offset: 0x21B13D8 VA: 0x21B53D8 Slot: 10
	protected override void OnSuccess(OperationResponse response) { }

	// RVA: 0x21B54A0 Offset: 0x21B14A0 VA: 0x21B54A0 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x21B55E0 Offset: 0x21B15E0 VA: 0x21B55E0 Slot: 13
	protected override void OnUnableJoin(short returnCode) { }

	// RVA: 0x21B55E4 Offset: 0x21B15E4 VA: 0x21B55E4 Slot: 15
	protected override void OnWrongStateOrPhase(short returnCode) { }
}
