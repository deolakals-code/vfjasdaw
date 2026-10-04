// Assembly: Assembly-CSharp.dll
// Namespace: 
private class NCollaborationRoomData.CheckNCollaborationRoom : CheckNCollaborationRoomExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2422
{
	// Fields
	private NCollaborationRoomData roomData; // 0x18

	// Methods

	// RVA: 0x21AC694 Offset: 0x21A8694 VA: 0x21AC694
	public void .ctor(NCollaborationRoomData roomData, int fieldId, byte roomId, byte flag) { }

	// RVA: 0x21ACAF4 Offset: 0x21A8AF4 VA: 0x21ACAF4 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21ACB14 Offset: 0x21A8B14 VA: 0x21ACB14 Slot: 10
	protected override void OnSuccess(CheckNCollaborationRoomResponse response) { }
}
