// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop.SignBoard.Bazaar
[CLSCompliant(False)]
public abstract class ExhibitBazaarExplain : OperationRelatedExplainBase // TypeDefIndex: 14961
{
	// Fields
	private byte slotIndex; // 0x10
	private ItemSelectData selectItem; // 0x18
	private int price; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3568C30 Offset: 0x3564C30 VA: 0x3568C30
	public void .ctor(byte slotIndex, ItemSelectData selectItem, int price) { }

	// RVA: 0x3568C7C Offset: 0x3564C7C VA: 0x3568C7C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3568C84 Offset: 0x3564C84 VA: 0x3568C84 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3568C8C Offset: 0x3564C8C VA: 0x3568C8C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3568D0C Offset: 0x3564D0C VA: 0x3568D0C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3568E68 Offset: 0x3564E68 VA: 0x3568E68
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ExhibitBazaarResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ExhibitBazaarResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSlotIndexOutOfRange();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnPriceOutOfRange();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnAlreadyExists();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnItemNotFound();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnBazaarItemNotFound();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnNoChangePrice();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnFailure(short returnCode);
}
