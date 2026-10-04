// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Trade
[CLSCompliant(False)]
public abstract class TradeConfirmExplain : OperationRelatedExplainBase // TypeDefIndex: 14907
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35600F4 Offset: 0x355C0F4 VA: 0x35600F4
	protected void .ctor() { }

	// RVA: 0x35600FC Offset: 0x355C0FC VA: 0x35600FC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3560104 Offset: 0x355C104 VA: 0x3560104 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356010C Offset: 0x355C10C VA: 0x356010C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3560114 Offset: 0x355C114 VA: 0x3560114 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnBanLogistics();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNotTrade(short returnCode);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnTradeProgressErr();
}
