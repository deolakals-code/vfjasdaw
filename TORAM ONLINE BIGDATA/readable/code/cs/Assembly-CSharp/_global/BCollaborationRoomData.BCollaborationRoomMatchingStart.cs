// Assembly: Assembly-CSharp.dll
// Namespace: 
private class BCollaborationRoomData.BCollaborationRoomMatchingStart : BCollaborationRoomMatchingStartExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2304
{
	// Fields
	private BCollaborationRoomData roomData; // 0x10

	// Methods

	// RVA: 0x217E240 Offset: 0x217A240 VA: 0x217E240
	public void .ctor(BCollaborationRoomData roomData) { }

	// RVA: 0x217EC84 Offset: 0x217AC84 VA: 0x217EC84 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x217EC88 Offset: 0x217AC88 VA: 0x217EC88 Slot: 12
	protected override void OnRoomDisposed() { }

	// RVA: 0x217ED6C Offset: 0x217AD6C VA: 0x217ED6C Slot: 10
	protected override void OnSuccess(BCollaborationRoomMatchingStartResponse response) { }
}
