// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop
[CLSCompliant(False)]
public abstract class ShopBuyItemExplain : OperationRelatedExplainBase // TypeDefIndex: 14953
{
	// Fields
	private int shopId; // 0x10
	private short[] position; // 0x18
	private int itemId; // 0x20
	private short itemNum; // 0x24
	private int gold; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3566E10 Offset: 0x3562E10 VA: 0x3566E10
	public void .ctor(int shopId, short[] position, int itemId, short itemNum, int gold) { }

	// RVA: 0x3566E74 Offset: 0x3562E74 VA: 0x3566E74 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3566E7C Offset: 0x3562E7C VA: 0x3566E7C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3566E84 Offset: 0x3562E84 VA: 0x3566E84 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3566F14 Offset: 0x3562F14 VA: 0x3566F14 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3567070 Offset: 0x3563070 VA: 0x3567070
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ShopBuyItemResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ShopBuyItemResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
