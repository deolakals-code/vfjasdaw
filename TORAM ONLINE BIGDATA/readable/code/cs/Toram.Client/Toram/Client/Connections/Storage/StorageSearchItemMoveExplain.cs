// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Storage
[CLSCompliant(False)]
public abstract class StorageSearchItemMoveExplain : OperationRelatedExplainBase // TypeDefIndex: 14912
{
	// Fields
	private readonly byte useType; // 0x10
	private readonly int location; // 0x14
	private readonly int itemId; // 0x18
	private readonly byte beforeStorageNo; // 0x1C
	private readonly byte afterStorageNo; // 0x1D

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3560870 Offset: 0x355C870 VA: 0x3560870
	public void .ctor(byte useType, int location, int itemId, byte beforeStorageNo, byte afterStorageNo) { }

	// RVA: 0x35608C4 Offset: 0x355C8C4 VA: 0x35608C4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35608CC Offset: 0x355C8CC VA: 0x35608CC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35608D4 Offset: 0x355C8D4 VA: 0x35608D4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3560954 Offset: 0x355C954 VA: 0x3560954 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(StorageSearchItemMoveResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnStorageItemFull(short returnCode);
}
