// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Fishing
[CLSCompliant(False)]
public abstract class CancelFishingExplain : OperationRelatedExplainBase // TypeDefIndex: 15098
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357EC28 Offset: 0x357AC28 VA: 0x357EC28
	public void .ctor() { }

	// RVA: 0x357EC30 Offset: 0x357AC30 VA: 0x357EC30 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357EC38 Offset: 0x357AC38 VA: 0x357EC38 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357EC40 Offset: 0x357AC40 VA: 0x357EC40 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357EC58 Offset: 0x357AC58 VA: 0x357EC58
	private GameReturnCode ReceiveResponse(Game engine, short returnCode) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnDoNotFishing();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
