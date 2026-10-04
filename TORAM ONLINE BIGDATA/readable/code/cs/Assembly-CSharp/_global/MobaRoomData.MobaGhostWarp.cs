// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaRoomData.MobaGhostWarp : MobaGhostWarpExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2405
{
	// Fields
	private MobaRoomData roomData; // 0x10

	// Methods

	// RVA: 0x21A9F24 Offset: 0x21A5F24 VA: 0x21A9F24
	public void .ctor(MobaRoomData roomData) { }

	// RVA: 0x21A9F54 Offset: 0x21A5F54 VA: 0x21A9F54 Slot: 11
	protected override void OnFailure(short returnCode, MobaGhostWarpResponse response) { }

	// RVA: 0x21A9F58 Offset: 0x21A5F58 VA: 0x21A9F58 Slot: 10
	protected override void OnSuccess(MobaGhostWarpResponse response) { }

	// RVA: 0x21AA050 Offset: 0x21A6050 VA: 0x21AA050 Slot: 12
	protected override void OnTimeIsNotOver(MobaGhostWarpResponse response) { }

	// RVA: 0x21AA054 Offset: 0x21A6054 VA: 0x21AA054 Slot: 13
	protected override void OnWrongState(MobaGhostWarpResponse response) { }
}
