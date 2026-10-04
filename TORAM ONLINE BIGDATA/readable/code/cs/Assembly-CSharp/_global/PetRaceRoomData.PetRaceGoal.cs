// Assembly: Assembly-CSharp.dll
// Namespace: 
private class PetRaceRoomData.PetRaceGoal : PetRaceGoalExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2438
{
	// Fields
	private PetRaceRoomData roomData; // 0x18

	// Methods

	// RVA: 0x21B30F8 Offset: 0x21AF0F8 VA: 0x21B30F8
	public void .ctor(string petName, PetRaceRoomData roomData) { }

	// RVA: 0x21B56AC Offset: 0x21B16AC VA: 0x21B56AC Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21B5778 Offset: 0x21B1778 VA: 0x21B5778 Slot: 14
	protected override void OnNotJoinedInTheCourse() { }

	// RVA: 0x21B577C Offset: 0x21B177C VA: 0x21B577C Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x21B58BC Offset: 0x21B18BC VA: 0x21B58BC Slot: 13
	protected override void OnUnableJoin(short returnCode) { }

	// RVA: 0x21B58C0 Offset: 0x21B18C0 VA: 0x21B58C0 Slot: 15
	protected override void OnWrongStateOrPhase(short returnCode) { }

	// RVA: 0x21B598C Offset: 0x21B198C VA: 0x21B598C Slot: 10
	protected override void OnSuccess(PetRaceGoalResponse response) { }
}
