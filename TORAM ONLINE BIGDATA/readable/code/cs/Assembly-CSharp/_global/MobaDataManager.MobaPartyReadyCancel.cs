// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaDataManager.MobaPartyReadyCancel : MobaPartyReadyCancelExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1402
{
	// Fields
	private MobaDataManager manager; // 0x18

	// Methods

	// RVA: 0x1FEAFC0 Offset: 0x1FE6FC0 VA: 0x1FEAFC0
	public void .ctor(MobaDataManager manager, byte partyGameId) { }

	// RVA: 0x1FEAFF4 Offset: 0x1FE6FF4 VA: 0x1FEAFF4 Slot: 17
	protected override void OnAlreadyReserved() { }

	// RVA: 0x1FEB010 Offset: 0x1FE7010 VA: 0x1FEB010 Slot: 18
	protected override void OnAlreadyRunning() { }

	// RVA: 0x1FEB02C Offset: 0x1FE702C VA: 0x1FEB02C Slot: 12
	protected override void OnConditionsAreNotMet() { }

	// RVA: 0x1FEB050 Offset: 0x1FE7050 VA: 0x1FEB050 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1FEB074 Offset: 0x1FE7074 VA: 0x1FEB074 Slot: 16
	protected override void OnMemberNotFound() { }

	// RVA: 0x1FEB098 Offset: 0x1FE7098 VA: 0x1FEB098 Slot: 14
	protected override void OnNoSetup() { }

	// RVA: 0x1FEB0BC Offset: 0x1FE70BC VA: 0x1FEB0BC Slot: 15
	protected override void OnNotBeHeld() { }

	// RVA: 0x1FEB0D8 Offset: 0x1FE70D8 VA: 0x1FEB0D8 Slot: 13
	protected override void OnProfileNotRegistered() { }

	// RVA: 0x1FEB0FC Offset: 0x1FE70FC VA: 0x1FEB0FC Slot: 10
	protected override void OnSuccess() { }
}
