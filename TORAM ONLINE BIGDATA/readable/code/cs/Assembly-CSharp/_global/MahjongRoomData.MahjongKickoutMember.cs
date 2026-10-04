// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MahjongRoomData.MahjongKickoutMember : MahjongKickoutMemberExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2360
{
	// Fields
	private MahjongRoomData roomData; // 0x18
	private Action callBack; // 0x20

	// Methods

	// RVA: 0x219BEC4 Offset: 0x2197EC4 VA: 0x219BEC4
	public void .ctor(int archetypeId, MahjongRoomData roomData, Action callBack) { }

	// RVA: 0x219D8C0 Offset: 0x21998C0 VA: 0x219D8C0 Slot: 13
	protected override void OnAlreadyStart() { }

	// RVA: 0x219D8F0 Offset: 0x21998F0 VA: 0x219D8F0 Slot: 17
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x219D930 Offset: 0x2199930 VA: 0x219D930 Slot: 16
	protected override void OnMemberNotFound() { }

	// RVA: 0x219D960 Offset: 0x2199960 VA: 0x219D960 Slot: 15
	protected override void OnNoAuthority() { }

	// RVA: 0x219D990 Offset: 0x2199990 VA: 0x219D990 Slot: 12
	protected override void OnNotJoined() { }

	// RVA: 0x219D9C0 Offset: 0x21999C0 VA: 0x219D9C0 Slot: 10
	protected override void OnSuccess(MahjongKickoutMemberResponse response) { }

	// RVA: 0x219DA1C Offset: 0x2199A1C VA: 0x219DA1C Slot: 11
	protected override void OnSystemLock() { }

	// RVA: 0x219DA4C Offset: 0x2199A4C VA: 0x219DA4C Slot: 14
	protected override void OnValueWrong() { }
}
