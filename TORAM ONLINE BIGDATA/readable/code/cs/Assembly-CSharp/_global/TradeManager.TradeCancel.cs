// Assembly: Assembly-CSharp.dll
// Namespace: 
private class TradeManager.TradeCancel : TradeCancelExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 3795
{
	// Fields
	private TradeManager manager; // 0x10

	// Methods

	// RVA: 0x23E8B98 Offset: 0x23E4B98 VA: 0x23E8B98
	public void .ctor(TradeManager manager) { }

	// RVA: 0x23E8BC8 Offset: 0x23E4BC8 VA: 0x23E8BC8 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x23E8BCC Offset: 0x23E4BCC VA: 0x23E8BCC Slot: 13
	protected override void OnNotCancel() { }

	// RVA: 0x23E8BD0 Offset: 0x23E4BD0 VA: 0x23E8BD0 Slot: 12
	protected override void OnNotTrade(short returnCode) { }

	// RVA: 0x23E8BEC Offset: 0x23E4BEC VA: 0x23E8BEC Slot: 10
	protected override void OnSuccess() { }
}
