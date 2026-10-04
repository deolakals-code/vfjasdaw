// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MahjongRoomData.MahjongCreateRoom : MahjongCreateRoomExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2355
{
	// Fields
	private MahjongRoomData roomData; // 0x10

	// Methods

	// RVA: 0x219B954 Offset: 0x2197954 VA: 0x219B954
	public void .ctor(MahjongRoomData roomData) { }

	// RVA: 0x219D1D0 Offset: 0x21991D0 VA: 0x219D1D0 Slot: 12
	protected override void OnAlreadyJoin() { }

	// RVA: 0x219D200 Offset: 0x2199200 VA: 0x219D200 Slot: 13
	protected override void OnFailedToRoomCreate() { }

	// RVA: 0x219D230 Offset: 0x2199230 VA: 0x219D230 Slot: 14
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x219D270 Offset: 0x2199270 VA: 0x219D270 Slot: 10
	protected override void OnSuccess(MahjongCreateRoomResponse response) { }

	// RVA: 0x219D2B0 Offset: 0x21992B0 VA: 0x219D2B0 Slot: 11
	protected override void OnSystemLock() { }
}
