// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Trade
[CLSCompliant(False)]
public abstract class TradeAcceptanceExplain : OperationRelatedExplainBase // TypeDefIndex: 14910
{
	// Fields
	private readonly int senderId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35604D4 Offset: 0x355C4D4 VA: 0x35604D4
	protected void .ctor(int senderId) { }

	// RVA: 0x35604FC Offset: 0x355C4FC VA: 0x35604FC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3560504 Offset: 0x355C504 VA: 0x3560504 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356050C Offset: 0x355C50C VA: 0x356050C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3560574 Offset: 0x355C574 VA: 0x3560574 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnBanLogistics();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnWarrantyExists();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnTradeReserveNotFound();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnTradeNotFound(short returnCode);

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnTradeProgressErr();
}
