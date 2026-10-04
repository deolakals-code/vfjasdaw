// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop.SignBoard.Bazaar
[CLSCompliant(False)]
public abstract class CancelExhibitBazaarExplain : OperationRelatedExplainBase // TypeDefIndex: 14959
{
	// Fields
	private byte slotIndex; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3568510 Offset: 0x3564510 VA: 0x3568510
	public void .ctor(byte slotIndex) { }

	// RVA: 0x3568538 Offset: 0x3564538 VA: 0x3568538 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3568540 Offset: 0x3564540 VA: 0x3568540 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3568548 Offset: 0x3564548 VA: 0x3568548 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35685B0 Offset: 0x35645B0 VA: 0x35685B0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356870C Offset: 0x356470C VA: 0x356870C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, CancelExhibitBazaarResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(CancelExhibitBazaarResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotFound();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnBagItemIsFull();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnPutupSignboard();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode);
}
