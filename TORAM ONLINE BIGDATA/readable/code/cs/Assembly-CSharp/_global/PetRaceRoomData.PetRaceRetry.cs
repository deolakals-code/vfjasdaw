// Assembly: Assembly-CSharp.dll
// Namespace: 
private class PetRaceRoomData.PetRaceRetry : PetRaceRetryExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2444
{
	// Fields
	private PetRaceRoomData roomData; // 0x10

	// Methods

	// RVA: 0x21B4408 Offset: 0x21B0408 VA: 0x21B4408
	public void .ctor(PetRaceRoomData roomData) { }

	// RVA: 0x21B6248 Offset: 0x21B2248 VA: 0x21B6248 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21B624C Offset: 0x21B224C VA: 0x21B624C Slot: 15
	protected override void OnNotJoinedInTheCourse() { }

	// RVA: 0x21B6250 Offset: 0x21B2250 VA: 0x21B6250 Slot: 10
	protected override void OnSuccess(PetRaceRetryResponse response) { }

	// RVA: 0x21B631C Offset: 0x21B231C VA: 0x21B631C Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x21B645C Offset: 0x21B245C VA: 0x21B645C Slot: 13
	protected override void OnUnableJoin(short returnCode) { }

	// RVA: 0x21B6460 Offset: 0x21B2460 VA: 0x21B6460 Slot: 14
	protected override void OnWrongStateOrPhase(short returnCode) { }

	[CompilerGenerated]
	// RVA: 0x21B6464 Offset: 0x21B2464 VA: 0x21B6464
	private void <OnSuccess>b__4_0() { }
}
