// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MahjongRoomData.MahjongMatchingStart : MahjongMatchingStartExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2365
{
	// Fields
	private MahjongRoomData roomData; // 0x10

	// Methods

	// RVA: 0x219C250 Offset: 0x2198250 VA: 0x219C250
	public void .ctor(MahjongRoomData roomData) { }

	// RVA: 0x219E098 Offset: 0x219A098 VA: 0x219E098 Slot: 17
	protected override void OnAlreadyExists() { }

	// RVA: 0x219E0C8 Offset: 0x219A0C8 VA: 0x219E0C8 Slot: 16
	protected override void OnDoNotNeed() { }

	// RVA: 0x219E0F8 Offset: 0x219A0F8 VA: 0x219E0F8 Slot: 18
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x219E138 Offset: 0x219A138 VA: 0x219E138 Slot: 13
	protected override void OnNoAuthority() { }

	// RVA: 0x219E168 Offset: 0x219A168 VA: 0x219E168 Slot: 12
	protected override void OnNotJoined() { }

	// RVA: 0x219E198 Offset: 0x219A198 VA: 0x219E198 Slot: 10
	protected override void OnSuccess() { }

	// RVA: 0x219E1CC Offset: 0x219A1CC VA: 0x219E1CC Slot: 11
	protected override void OnSystemLock() { }

	// RVA: 0x219E1FC Offset: 0x219A1FC VA: 0x219E1FC Slot: 15
	protected override void OnWrongState() { }

	// RVA: 0x219E22C Offset: 0x219A22C VA: 0x219E22C Slot: 14
	protected override void OnWrongTarget() { }
}
