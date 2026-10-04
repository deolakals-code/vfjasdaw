// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MahjongRoomData.MahjongCheckJoinRoom : MahjongCheckJoinRoomExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2362
{
	// Fields
	private MahjongRoomData roomData; // 0x10

	// Methods

	// RVA: 0x2196568 Offset: 0x2192568 VA: 0x2196568
	public void .ctor(MahjongRoomData roomData) { }

	// RVA: 0x219DBC8 Offset: 0x2199BC8 VA: 0x219DBC8 Slot: 12
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x219DC08 Offset: 0x2199C08 VA: 0x219DC08 Slot: 10
	protected override void OnSuccess(MahjongCheckJoinRoomResponse response) { }

	// RVA: 0x219DD70 Offset: 0x2199D70 VA: 0x219DD70 Slot: 11
	protected override void OnSystemLock() { }
}
