// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaRoomData.MobaCheckResult : MobaCheckResultExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2400
{
	// Fields
	private MobaRoomData mobaRoomData; // 0x10

	// Methods

	// RVA: 0x21A98A0 Offset: 0x21A58A0 VA: 0x21A98A0
	public void .ctor(MobaRoomData mobaRoomData) { }

	// RVA: 0x21A98D0 Offset: 0x21A58D0 VA: 0x21A98D0 Slot: 14
	protected override void OnFailure(short returnCode, MobaCheckResultResponse response) { }

	// RVA: 0x21A99DC Offset: 0x21A59DC VA: 0x21A99DC Slot: 13
	protected override void OnGameNotOver(MobaCheckResultResponse response) { }

	// RVA: 0x21A9A2C Offset: 0x21A5A2C VA: 0x21A9A2C Slot: 11
	protected override void OnNeedToLeave(MobaCheckResultResponse response) { }

	// RVA: 0x21A9A7C Offset: 0x21A5A7C VA: 0x21A9A7C Slot: 10
	protected override void OnSuccess(MobaCheckResultResponse response) { }

	// RVA: 0x21A9B70 Offset: 0x21A5B70 VA: 0x21A9B70 Slot: 12
	protected override void OnUnsuccessfulNeedToLeave(short returnCode, MobaCheckResultResponse response) { }

	// RVA: 0x21A996C Offset: 0x21A596C VA: 0x21A996C
	private void Leave() { }
}
