// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Trade
[CLSCompliant(False)]
public abstract class TradeRequestExplain : OperationRelatedExplainBase // TypeDefIndex: 14911
{
	// Fields
	private readonly int targetId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3560648 Offset: 0x355C648 VA: 0x3560648
	protected void .ctor(int targetId) { }

	// RVA: 0x3560670 Offset: 0x355C670 VA: 0x3560670 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3560678 Offset: 0x355C678 VA: 0x3560678 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3560680 Offset: 0x355C680 VA: 0x3560680 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35606E8 Offset: 0x355C6E8 VA: 0x35606E8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(TradeRequestResponse_ response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnBanLogistics();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnWarrantyExists();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnTradeFatalState();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnAlreadyExists();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnArchetypeNotFound();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnNotStateReceive();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnAlreadyOtherTrade();
}
