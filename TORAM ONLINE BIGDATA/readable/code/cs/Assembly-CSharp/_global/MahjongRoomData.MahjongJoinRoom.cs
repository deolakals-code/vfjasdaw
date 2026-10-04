// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MahjongRoomData.MahjongJoinRoom : MahjongJoinRoomExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2356
{
	// Fields
	private MahjongRoomData roomData; // 0x18

	// Methods

	// RVA: 0x219BB14 Offset: 0x2197B14 VA: 0x219BB14
	public void .ctor(int roomId, MahjongRoomData roomData) { }

	// RVA: 0x219D2E0 Offset: 0x21992E0 VA: 0x219D2E0 Slot: 12
	protected override void OnAlreadyJoin() { }

	// RVA: 0x219D310 Offset: 0x2199310 VA: 0x219D310 Slot: 14
	protected override void OnAlreadyStart() { }

	// RVA: 0x219D340 Offset: 0x2199340 VA: 0x219D340 Slot: 16
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x219D380 Offset: 0x2199380 VA: 0x219D380 Slot: 13
	protected override void OnNotFound() { }

	// RVA: 0x219D3B0 Offset: 0x21993B0 VA: 0x219D3B0 Slot: 15
	protected override void OnNoVacancies() { }

	// RVA: 0x219D3E0 Offset: 0x21993E0 VA: 0x219D3E0 Slot: 10
	protected override void OnSuccess(MahjongJoinRoomResponse response) { }

	// RVA: 0x219D420 Offset: 0x2199420 VA: 0x219D420 Slot: 11
	protected override void OnSystemLock() { }
}
