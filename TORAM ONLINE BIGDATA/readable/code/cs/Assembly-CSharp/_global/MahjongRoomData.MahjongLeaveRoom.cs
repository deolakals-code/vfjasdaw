// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MahjongRoomData.MahjongLeaveRoom : MahjongLeaveRoomExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2357
{
	// Fields
	private MahjongRoomData roomData; // 0x10
	private bool isAfterJoinRoom; // 0x18
	private int roomId; // 0x1C

	// Methods

	// RVA: 0x219BC0C Offset: 0x2197C0C VA: 0x219BC0C
	public void .ctor(MahjongRoomData roomData, bool isAfterJoinRoom, int roomId) { }

	// RVA: 0x219D450 Offset: 0x2199450 VA: 0x219D450 Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x219D490 Offset: 0x2199490 VA: 0x219D490 Slot: 12
	protected override void OnNotJoined() { }

	// RVA: 0x219D4C0 Offset: 0x21994C0 VA: 0x219D4C0 Slot: 10
	protected override void OnSuccess(MahjongLeaveRoomResponse response) { }

	// RVA: 0x219D598 Offset: 0x2199598 VA: 0x219D598 Slot: 11
	protected override void OnSystemLock() { }
}
