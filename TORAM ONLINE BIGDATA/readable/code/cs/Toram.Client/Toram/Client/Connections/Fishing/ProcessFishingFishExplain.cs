// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Fishing
[CLSCompliant(False)]
public abstract class ProcessFishingFishExplain : OperationRelatedExplainBase // TypeDefIndex: 15104
{
	// Fields
	private short[] indexList; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357FC28 Offset: 0x357BC28 VA: 0x357FC28
	public void .ctor(short[] indexList) { }

	// RVA: 0x357FC58 Offset: 0x357BC58 VA: 0x357FC58 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357FC60 Offset: 0x357BC60 VA: 0x357FC60 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357FC68 Offset: 0x357BC68 VA: 0x357FC68 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357FCD8 Offset: 0x357BCD8 VA: 0x357FCD8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357FE34 Offset: 0x357BE34 VA: 0x357FE34
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ProcessFishingFishResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ProcessFishingFishResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFoodPointUpperLimit();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFishNotFound();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
