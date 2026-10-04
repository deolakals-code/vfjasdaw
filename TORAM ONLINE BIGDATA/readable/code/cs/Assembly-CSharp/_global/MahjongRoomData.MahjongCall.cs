// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MahjongRoomData.MahjongCall : MahjongCallExplain, IReconnectionReceiveResponse, IReconnectionSubData // TypeDefIndex: 2368
{
	// Fields
	private MahjongRoomData roomData; // 0x20
	private byte callType; // 0x28

	// Methods

	// RVA: 0x219C534 Offset: 0x2198534 VA: 0x219C534
	public void .ctor(byte callType, int[] myTileUidList, MahjongRoomData roomData) { }

	// RVA: 0x219E51C Offset: 0x219A51C VA: 0x219E51C Slot: 19
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x219E55C Offset: 0x219A55C VA: 0x219E55C Slot: 18
	protected override void OnMaxKan() { }

	// RVA: 0x219E58C Offset: 0x219A58C VA: 0x219E58C Slot: 12
	protected override void OnNotJoined() { }

	// RVA: 0x219E5BC Offset: 0x219A5BC VA: 0x219E5BC Slot: 17
	protected override void OnNotMatch() { }

	// RVA: 0x219E5EC Offset: 0x219A5EC VA: 0x219E5EC Slot: 15
	protected override void OnNotMyTurn() { }

	// RVA: 0x219E61C Offset: 0x219A61C VA: 0x219E61C Slot: 13
	protected override void OnNotStart() { }

	// RVA: 0x219E64C Offset: 0x219A64C VA: 0x219E64C Slot: 10
	protected override void OnSuccess() { }

	// RVA: 0x219E778 Offset: 0x219A778 VA: 0x219E778 Slot: 11
	protected override void OnSystemLock() { }

	// RVA: 0x219E7A8 Offset: 0x219A7A8 VA: 0x219E7A8 Slot: 14
	protected override void OnTypeWrong() { }

	// RVA: 0x219E7D8 Offset: 0x219A7D8 VA: 0x219E7D8 Slot: 16
	protected override void OnValueWrong() { }
}
