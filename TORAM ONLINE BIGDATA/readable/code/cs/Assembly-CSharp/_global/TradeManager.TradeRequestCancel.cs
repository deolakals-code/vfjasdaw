// Assembly: Assembly-CSharp.dll
// Namespace: 
private class TradeManager.TradeRequestCancel : TradeRequestCancelExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 3792
{
	// Methods

	// RVA: 0x23E8884 Offset: 0x23E4884 VA: 0x23E8884
	public void .ctor(int senderId) { }

	// RVA: 0x23E888C Offset: 0x23E488C VA: 0x23E888C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x23E8890 Offset: 0x23E4890 VA: 0x23E8890 Slot: 10
	protected override void OnSuccess() { }

	// RVA: 0x23E88E4 Offset: 0x23E48E4 VA: 0x23E88E4 Slot: 13
	protected override void OnTradeNotFound(short returnCode) { }

	// RVA: 0x23E8988 Offset: 0x23E4988 VA: 0x23E8988 Slot: 12
	protected override void OnTradeReserveNotFound() { }
}
