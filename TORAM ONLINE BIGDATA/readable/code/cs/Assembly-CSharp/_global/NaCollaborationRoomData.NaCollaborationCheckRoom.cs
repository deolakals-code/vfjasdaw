// Assembly: Assembly-CSharp.dll
// Namespace: 
private class NaCollaborationRoomData.NaCollaborationCheckRoom : NaCollaborationCheckRoomExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2418
{
	// Fields
	private NaCollaborationRoomData roomData; // 0x18

	// Methods

	// RVA: 0x21AB1D0 Offset: 0x21A71D0 VA: 0x21AB1D0
	public void .ctor(int fieldId, byte roomId, byte flag, NaCollaborationRoomData roomData) { }

	// RVA: 0x21ABB94 Offset: 0x21A7B94 VA: 0x21ABB94 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21ABBB4 Offset: 0x21A7BB4 VA: 0x21ABBB4 Slot: 10
	protected override void OnSuccess(NaCollaborationCheckRoomResponse response) { }
}
