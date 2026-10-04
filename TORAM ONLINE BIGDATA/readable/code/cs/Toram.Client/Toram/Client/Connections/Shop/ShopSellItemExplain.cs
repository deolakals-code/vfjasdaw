// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop
[CLSCompliant(False)]
public abstract class ShopSellItemExplain : OperationRelatedExplainBase // TypeDefIndex: 14955
{
	// Fields
	private int shopId; // 0x10
	private short[] position; // 0x18
	private ItemSelectData[] selectItem; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35674BC Offset: 0x35634BC VA: 0x35674BC
	public void .ctor(int shopId, short[] position, ItemSelectData[] selectItem) { }

	// RVA: 0x3567510 Offset: 0x3563510 VA: 0x3567510 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3567518 Offset: 0x3563518 VA: 0x3567518 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3567520 Offset: 0x3563520 VA: 0x3567520 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35675A8 Offset: 0x35635A8 VA: 0x35675A8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3567704 Offset: 0x3563704 VA: 0x3567704
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ShopSellItemResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ShopSellItemResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
