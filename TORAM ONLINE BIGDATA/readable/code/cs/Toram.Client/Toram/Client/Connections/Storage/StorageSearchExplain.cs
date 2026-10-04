// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Storage
[CLSCompliant(False)]
public abstract class StorageSearchExplain : OperationRelatedExplainBase // TypeDefIndex: 14913
{
	// Fields
	private readonly byte type; // 0x10
	private readonly int id; // 0x14
	private readonly byte slot; // 0x18
	private readonly byte parts; // 0x19
	private readonly byte color; // 0x1A
	private readonly int modelId; // 0x1C
	private readonly byte useType; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3560A0C Offset: 0x355CA0C VA: 0x3560A0C
	private void .ctor(byte slot, byte parts, byte color, int modelId, byte useType) { }

	// RVA: 0x3560A64 Offset: 0x355CA64 VA: 0x3560A64
	public void .ctor(byte type, byte slot, byte parts, byte color, int modelId, byte useType) { }

	// RVA: 0x3560AC8 Offset: 0x355CAC8 VA: 0x3560AC8
	public void .ctor(int id, byte slot, byte parts, byte color, int modelId, byte useType) { }

	// RVA: 0x3560B2C Offset: 0x355CB2C VA: 0x3560B2C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3560B34 Offset: 0x355CB34 VA: 0x3560B34 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3560B3C Offset: 0x355CB3C VA: 0x3560B3C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3560BD4 Offset: 0x355CBD4 VA: 0x3560BD4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(StorageSearchResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnWrong(short returnCode);
}
