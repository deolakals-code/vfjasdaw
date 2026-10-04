// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MahjongRoomData.MahjongMatchingCancel : MahjongMatchingCancelExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2366
{
	// Fields
	private MahjongRoomData roomData; // 0x10

	// Methods

	// RVA: 0x219C32C Offset: 0x219832C VA: 0x219C32C
	public void .ctor(MahjongRoomData roomData) { }

	// RVA: 0x219E25C Offset: 0x219A25C VA: 0x219E25C Slot: 15
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x219E29C Offset: 0x219A29C VA: 0x219E29C Slot: 14
	protected override void OnNotFound() { }

	// RVA: 0x219E2CC Offset: 0x219A2CC VA: 0x219E2CC Slot: 12
	protected override void OnNotJoined() { }

	// RVA: 0x219E2FC Offset: 0x219A2FC VA: 0x219E2FC Slot: 10
	protected override void OnSuccess() { }

	// RVA: 0x219E358 Offset: 0x219A358 VA: 0x219E358 Slot: 11
	protected override void OnSystemLock() { }

	// RVA: 0x219E388 Offset: 0x219A388 VA: 0x219E388 Slot: 13
	protected override void OnWrongState() { }
}
