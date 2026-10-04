// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MahjongRoomData.MahjongStartGame : MahjongStartGameExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2361
{
	// Fields
	private MahjongRoomData roomData; // 0x10

	// Methods

	// RVA: 0x219BFB4 Offset: 0x2197FB4 VA: 0x219BFB4
	public void .ctor(MahjongRoomData roomData) { }

	// RVA: 0x219DA7C Offset: 0x2199A7C VA: 0x219DA7C Slot: 16
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x219DABC Offset: 0x2199ABC VA: 0x219DABC Slot: 14
	protected override void OnMemberNotFound() { }

	// RVA: 0x219DAEC Offset: 0x2199AEC VA: 0x219DAEC Slot: 13
	protected override void OnNoAuthority() { }

	// RVA: 0x219DB1C Offset: 0x2199B1C VA: 0x219DB1C Slot: 12
	protected override void OnNotJoined() { }

	// RVA: 0x219DB4C Offset: 0x2199B4C VA: 0x219DB4C Slot: 15
	protected override void OnNotReady() { }

	// RVA: 0x219DB7C Offset: 0x2199B7C VA: 0x219DB7C Slot: 10
	protected override void OnSuccess() { }

	// RVA: 0x219DB98 Offset: 0x2199B98 VA: 0x219DB98 Slot: 11
	protected override void OnSystemLock() { }
}
