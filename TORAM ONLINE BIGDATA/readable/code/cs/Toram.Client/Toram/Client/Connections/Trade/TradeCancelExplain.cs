// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Trade
[CLSCompliant(False)]
public abstract class TradeCancelExplain : OperationRelatedExplainBase // TypeDefIndex: 14906
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3560060 Offset: 0x355C060 VA: 0x3560060
	protected void .ctor() { }

	// RVA: 0x3560068 Offset: 0x355C068 VA: 0x3560068 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3560070 Offset: 0x355C070 VA: 0x3560070 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3560078 Offset: 0x355C078 VA: 0x3560078 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3560080 Offset: 0x355C080 VA: 0x3560080 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotTrade(short returnCode);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNotCancel();
}
