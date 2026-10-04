// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop.SignBoard.Bazaar
[CLSCompliant(False)]
public abstract class BazzarSalesAcquisitionExplain : OperationRelatedExplainBase // TypeDefIndex: 14958
{
	// Fields
	private int gold; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3568188 Offset: 0x3564188 VA: 0x3568188
	public void .ctor(int gold) { }

	// RVA: 0x35681B0 Offset: 0x35641B0 VA: 0x35681B0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35681B8 Offset: 0x35641B8 VA: 0x35681B8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35681C0 Offset: 0x35641C0 VA: 0x35681C0 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3568228 Offset: 0x3564228 VA: 0x3568228 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3568384 Offset: 0x3564384 VA: 0x3568384
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, BazaarSalesAcquisitionResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(BazaarSalesAcquisitionResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnMoneyLimit();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnSalesNotEnough();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnPutupSignboard();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode);
}
