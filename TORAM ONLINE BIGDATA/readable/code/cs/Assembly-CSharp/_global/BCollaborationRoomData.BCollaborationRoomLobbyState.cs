// Assembly: Assembly-CSharp.dll
// Namespace: 
private class BCollaborationRoomData.BCollaborationRoomLobbyState : BCollaborationRoomLobbyStateExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2303
{
	// Fields
	private BCollaborationRoomData roomData; // 0x10

	// Methods

	// RVA: 0x217E5A4 Offset: 0x217A5A4 VA: 0x217E5A4
	public void .ctor(BCollaborationRoomData roomData) { }

	// RVA: 0x217EB24 Offset: 0x217AB24 VA: 0x217EB24 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x217EB28 Offset: 0x217AB28 VA: 0x217EB28 Slot: 10
	protected override void OnSuccess(BCollaborationRoomLobbyStateResponse response) { }
}
