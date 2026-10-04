// Assembly: Assembly-CSharp.dll
// Namespace: 
private class TradeManager.TradeRequestSenderCancel : TradeCancelExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 3793
{
	// Methods

	// RVA: 0x23E898C Offset: 0x23E498C VA: 0x23E898C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x23E89E0 Offset: 0x23E49E0 VA: 0x23E89E0 Slot: 13
	protected override void OnNotCancel() { }

	// RVA: 0x23E89E4 Offset: 0x23E49E4 VA: 0x23E89E4 Slot: 12
	protected override void OnNotTrade(short returnCode) { }

	// RVA: 0x23E8A38 Offset: 0x23E4A38 VA: 0x23E8A38 Slot: 10
	protected override void OnSuccess() { }

	// RVA: 0x23E8B1C Offset: 0x23E4B1C VA: 0x23E8B1C
	public void .ctor() { }
}
