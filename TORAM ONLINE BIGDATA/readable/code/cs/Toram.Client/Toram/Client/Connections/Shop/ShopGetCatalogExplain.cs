// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop
[CLSCompliant(False)]
public abstract class ShopGetCatalogExplain : OperationRelatedExplainBase // TypeDefIndex: 14954
{
	// Fields
	private int shopId; // 0x10
	private short[] position; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3567188 Offset: 0x3563188 VA: 0x3567188
	public void .ctor(int shopId, short[] position) { }

	// RVA: 0x35671C0 Offset: 0x35631C0 VA: 0x35671C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35671C8 Offset: 0x35631C8 VA: 0x35671C8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35671D0 Offset: 0x35631D0 VA: 0x35671D0 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3567248 Offset: 0x3563248 VA: 0x3567248 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35673A4 Offset: 0x35633A4 VA: 0x35673A4
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ShopGetCatalogResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ShopGetCatalogResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
