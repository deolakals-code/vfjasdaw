// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MahjongRoomData.MahjongChangeMemberSetting : MahjongChangeMemberSettingExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2364
{
	// Fields
	private MahjongRoomData roomData; // 0x18

	// Methods

	// RVA: 0x219C0C8 Offset: 0x21980C8 VA: 0x219C0C8
	public void .ctor(byte psi, byte voiceId, MahjongRoomData roomData) { }

	// RVA: 0x219DF70 Offset: 0x2199F70 VA: 0x219DF70 Slot: 14
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x219DFB0 Offset: 0x2199FB0 VA: 0x219DFB0 Slot: 13
	protected override void OnMemberNotFound() { }

	// RVA: 0x219DFE0 Offset: 0x2199FE0 VA: 0x219DFE0 Slot: 12
	protected override void OnNotJoined() { }

	// RVA: 0x219E010 Offset: 0x219A010 VA: 0x219E010 Slot: 10
	protected override void OnSuccess(MahjongChangeMemberSettingResponse response) { }

	// RVA: 0x219E068 Offset: 0x219A068 VA: 0x219E068 Slot: 11
	protected override void OnSystemLock() { }
}
