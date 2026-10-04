// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Storage
[CLSCompliant(False)]
public abstract class StorageSearchPickupExplain : OperationRelatedExplainBase // TypeDefIndex: 14914
{
	// Fields
	private readonly byte useType; // 0x10
	private readonly int location; // 0x14
	private readonly int itemId; // 0x18
	private readonly short num; // 0x1C

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3560C94 Offset: 0x355CC94 VA: 0x3560C94
	public void .ctor(byte useType, int location, int itemId) { }

	// RVA: 0x3560CD0 Offset: 0x355CCD0 VA: 0x3560CD0
	public void .ctor(byte useType, int location, int itemId, short num) { }

	// RVA: 0x3560D14 Offset: 0x355CD14 VA: 0x3560D14 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3560D1C Offset: 0x355CD1C VA: 0x3560D1C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3560D24 Offset: 0x355CD24 VA: 0x3560D24 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3560D9C Offset: 0x355CD9C VA: 0x3560D9C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(StorageSearchPickupResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnItemNotFound(short returnCode);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnBagItemFull(short returnCode);
}
