// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.PaletteStorage
[CLSCompliant(False)]
public abstract class StockColorExplain : OperationRelatedExplainBase // TypeDefIndex: 14966
{
	// Fields
	private int[] itemUuids; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3569CE8 Offset: 0x3565CE8 VA: 0x3569CE8
	public void .ctor(int[] itemUuids) { }

	// RVA: 0x3569D18 Offset: 0x3565D18 VA: 0x3569D18 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3569D20 Offset: 0x3565D20 VA: 0x3569D20 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3569D28 Offset: 0x3565D28 VA: 0x3569D28 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3569D98 Offset: 0x3565D98 VA: 0x3569D98 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3569EF4 Offset: 0x3565EF4 VA: 0x3569EF4
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, StockColorResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(StockColorResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnItemNotFound();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnItemTypeNotAllowed();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnItemHasNoColor();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnPaletteDataNull();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnMaxColorStock();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnFailure(short returnCode);
}
