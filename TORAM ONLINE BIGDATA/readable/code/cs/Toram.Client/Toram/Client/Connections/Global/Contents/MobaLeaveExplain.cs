// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaLeaveExplain : OperationRelatedExplainBase // TypeDefIndex: 15078
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357C8F0 Offset: 0x35788F0 VA: 0x357C8F0
	public void .ctor() { }

	// RVA: 0x357C8F8 Offset: 0x35788F8 VA: 0x357C8F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357C900 Offset: 0x3578900 VA: 0x357C900 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357C908 Offset: 0x3578908 VA: 0x357C908 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357C910 Offset: 0x3578910 VA: 0x357C910 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccessChangeField();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
