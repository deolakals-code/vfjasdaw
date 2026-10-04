// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Trade
[CLSCompliant(False)]
public abstract class TradeReadyOkExplain : OperationRelatedExplainBase // TypeDefIndex: 14908
{
	// Fields
	private readonly ItemSelectData[] selectItems; // 0x10
	private readonly long[] selectStarGemIds; // 0x18
	private readonly int gold; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3560180 Offset: 0x355C180 VA: 0x3560180
	protected void .ctor(ItemSelectData[] selectItems, long[] selectStarGemIds, int gold) { }

	// RVA: 0x35601D8 Offset: 0x355C1D8 VA: 0x35601D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35601E0 Offset: 0x355C1E0 VA: 0x35601E0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35601E8 Offset: 0x355C1E8 VA: 0x35601E8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3560270 Offset: 0x355C270 VA: 0x3560270 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnBanLogistics();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnSelectErr(short returnCode);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnTradeProblemNumber();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnMoneyNotEnough();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnNotTrade(short returnCode);

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnTradeProgressErr();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnBagCapacityOver();
}
