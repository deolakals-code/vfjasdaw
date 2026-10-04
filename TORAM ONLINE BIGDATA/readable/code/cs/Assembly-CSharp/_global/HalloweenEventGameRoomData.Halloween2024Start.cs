// Assembly: Assembly-CSharp.dll
// Namespace: 
private class HalloweenEventGameRoomData.Halloween2024Start : HalloweenStartExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2344
{
	// Fields
	private HalloweenEventGameRoomData roomData; // 0x10

	// Methods

	// RVA: 0x21936A8 Offset: 0x218F6A8 VA: 0x21936A8
	public void .ctor(HalloweenEventGameRoomData roomData) { }

	// RVA: 0x21936D8 Offset: 0x218F6D8 VA: 0x21936D8 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21936DC Offset: 0x218F6DC VA: 0x21936DC Slot: 10
	protected override void OnSuccess(HalloweenStartResponse response) { }

	// RVA: 0x2193738 Offset: 0x218F738 VA: 0x2193738 Slot: 13
	protected override void OnGameEventNotHeld() { }

	// RVA: 0x219378C Offset: 0x218F78C VA: 0x219378C Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x219373C Offset: 0x218F73C VA: 0x219373C
	private void LeaveField() { }
}
