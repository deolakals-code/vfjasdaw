// Assembly: Assembly-CSharp.dll
// Namespace: 
private class BCollaborationRoomData.BCollaborationCheckRoom : BCollaborationCheckRoomExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2298
{
	// Fields
	private BCollaborationRoomData roomData; // 0x10

	// Methods

	// RVA: 0x217E16C Offset: 0x217A16C VA: 0x217E16C
	public void .ctor(BCollaborationRoomData roomData) { }

	// RVA: 0x217E898 Offset: 0x217A898 VA: 0x217E898 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x217E8B8 Offset: 0x217A8B8 VA: 0x217E8B8 Slot: 10
	protected override void OnSuccess(BCollaborationCheckRoomResponse response) { }
}
