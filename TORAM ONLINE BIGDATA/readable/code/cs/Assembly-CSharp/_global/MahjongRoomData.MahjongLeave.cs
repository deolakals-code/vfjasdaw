// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MahjongRoomData.MahjongLeave : MahjongLeaveExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2354
{
	// Fields
	private MahjongRoomData roomData; // 0x10

	// Methods

	// RVA: 0x219BA30 Offset: 0x2197A30 VA: 0x219BA30
	public void .ctor(MahjongRoomData roomData) { }

	// RVA: 0x219D0CC Offset: 0x21990CC VA: 0x219D0CC Slot: 12
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x219D10C Offset: 0x219910C VA: 0x219D10C Slot: 11
	protected override void OnRoomJoined() { }

	// RVA: 0x219D13C Offset: 0x219913C VA: 0x219D13C Slot: 10
	protected override void OnSuccess(OperationResponse response) { }
}
