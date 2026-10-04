// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaRoomData.MobaReadyOk : MobaReadyOkExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2399
{
	// Fields
	private MobaRoomData mobaRoomData; // 0x10

	// Methods

	// RVA: 0x21A9814 Offset: 0x21A5814 VA: 0x21A9814
	public void .ctor(MobaRoomData mobaRoomData) { }

	// RVA: 0x21A9844 Offset: 0x21A5844 VA: 0x21A9844 Slot: 13
	protected override void OnFailure(short returnCode, MobaReadyOkResponse response) { }

	// RVA: 0x21A9848 Offset: 0x21A5848 VA: 0x21A9848 Slot: 11
	protected override void OnNeedToLeave(short returnCode, MobaReadyOkResponse response) { }

	// RVA: 0x21A9864 Offset: 0x21A5864 VA: 0x21A9864 Slot: 10
	protected override void OnSuccess(MobaReadyOkResponse response) { }

	// RVA: 0x21A9884 Offset: 0x21A5884 VA: 0x21A9884 Slot: 12
	protected override void OnUnsuccessfulNeedToLeave(short returnCode, MobaReadyOkResponse response) { }
}
