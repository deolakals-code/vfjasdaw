// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Main.Item
[CLSCompliant(False)]
public abstract class ItemBagTidyUpExplain : OperationRelatedExplainBase // TypeDefIndex: 14972
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356AF84 Offset: 0x3566F84 VA: 0x356AF84
	public void .ctor() { }

	// RVA: 0x356AF8C Offset: 0x3566F8C VA: 0x356AF8C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356AF94 Offset: 0x3566F94 VA: 0x356AF94 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356AF9C Offset: 0x3566F9C VA: 0x356AF9C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356AFF0 Offset: 0x3566FF0 VA: 0x356AFF0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ItemBagTidyUpResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnDoNotNeed();
}
