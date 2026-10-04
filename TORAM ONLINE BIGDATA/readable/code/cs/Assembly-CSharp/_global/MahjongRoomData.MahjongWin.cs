// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MahjongRoomData.MahjongWin : MahjongWinExplain, IReconnectionReceiveResponse, IReconnectionSubData // TypeDefIndex: 2371
{
	// Fields
	private MahjongRoomData roomData; // 0x18

	// Methods

	// RVA: 0x219CD5C Offset: 0x2198D5C VA: 0x219CD5C
	public void .ctor(MahjongRoomData roomData, bool tsumo) { }

	// RVA: 0x219EA74 Offset: 0x219AA74 VA: 0x219EA74 Slot: 16
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x219EAB4 Offset: 0x219AAB4 VA: 0x219EAB4 Slot: 12
	protected override void OnNotJoined() { }

	// RVA: 0x219EAE4 Offset: 0x219AAE4 VA: 0x219EAE4 Slot: 15
	protected override void OnNotMatch() { }

	// RVA: 0x219EB14 Offset: 0x219AB14 VA: 0x219EB14 Slot: 14
	protected override void OnNotMyTurn() { }

	// RVA: 0x219EB44 Offset: 0x219AB44 VA: 0x219EB44 Slot: 13
	protected override void OnNotStart() { }

	// RVA: 0x219EB74 Offset: 0x219AB74 VA: 0x219EB74 Slot: 10
	protected override void OnSuccess() { }

	// RVA: 0x219EBAC Offset: 0x219ABAC VA: 0x219EBAC Slot: 11
	protected override void OnSystemLock() { }
}
