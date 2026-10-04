// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop
[CLSCompliant(False)]
public abstract class MaterialProcessingExplain : OperationRelatedExplainBase // TypeDefIndex: 14951
{
	// Fields
	private int shopId; // 0x10
	private byte shopType; // 0x14
	private short[] position; // 0x18
	private short skillId; // 0x20
	private ItemSelectData[] itemList; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3566658 Offset: 0x3562658 VA: 0x3566658
	public void .ctor(int shopId, byte shopType, short[] position, short skillId, ItemSelectData[] itemList) { }

	// RVA: 0x35666C4 Offset: 0x35626C4 VA: 0x35666C4
	public void .ctor(ItemSelectData[] itemList) { }

	// RVA: 0x35666FC Offset: 0x35626FC VA: 0x35666FC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3566704 Offset: 0x3562704 VA: 0x3566704 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356670C Offset: 0x356270C VA: 0x356670C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35667A4 Offset: 0x35627A4 VA: 0x35667A4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3566900 Offset: 0x3562900 VA: 0x3566900
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, MaterialProcessingResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MaterialProcessingResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
