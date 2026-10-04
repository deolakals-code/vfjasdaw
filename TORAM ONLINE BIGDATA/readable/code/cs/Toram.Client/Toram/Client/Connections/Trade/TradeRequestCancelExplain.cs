// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Trade
[CLSCompliant(False)]
public abstract class TradeRequestCancelExplain : OperationRelatedExplainBase // TypeDefIndex: 14909
{
	// Fields
	private readonly int senderId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35603C0 Offset: 0x355C3C0 VA: 0x35603C0
	protected void .ctor(int senderId) { }

	// RVA: 0x35603E8 Offset: 0x355C3E8 VA: 0x35603E8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35603F0 Offset: 0x355C3F0 VA: 0x35603F0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35603F8 Offset: 0x355C3F8 VA: 0x35603F8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3560460 Offset: 0x355C460 VA: 0x3560460 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnTradeReserveNotFound();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnTradeNotFound(short returnCode);
}
