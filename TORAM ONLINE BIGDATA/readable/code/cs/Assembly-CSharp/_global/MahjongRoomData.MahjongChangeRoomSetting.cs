// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MahjongRoomData.MahjongChangeRoomSetting : MahjongChangeRoomSettingExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2363
{
	// Fields
	private MahjongRoomData roomData; // 0x18

	// Methods

	// RVA: 0x219C098 Offset: 0x2198098 VA: 0x219C098
	public void .ctor(MahjongRoomSettingData setting, MahjongRoomData roomData) { }

	// RVA: 0x219DDA0 Offset: 0x2199DA0 VA: 0x219DDA0 Slot: 16
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x219DDE0 Offset: 0x2199DE0 VA: 0x219DDE0 Slot: 15
	protected override void OnMemberNotFound() { }

	// RVA: 0x219DE10 Offset: 0x2199E10 VA: 0x219DE10 Slot: 14
	protected override void OnMemberOver() { }

	// RVA: 0x219DE40 Offset: 0x2199E40 VA: 0x219DE40 Slot: 13
	protected override void OnNoAuthority() { }

	// RVA: 0x219DE70 Offset: 0x2199E70 VA: 0x219DE70 Slot: 12
	protected override void OnNotJoined() { }

	// RVA: 0x219DEA0 Offset: 0x2199EA0 VA: 0x219DEA0 Slot: 10
	protected override void OnSuccess(MahjongChangeRoomSettingResponse response) { }

	// RVA: 0x219DF40 Offset: 0x2199F40 VA: 0x219DF40 Slot: 11
	protected override void OnSystemLock() { }
}
