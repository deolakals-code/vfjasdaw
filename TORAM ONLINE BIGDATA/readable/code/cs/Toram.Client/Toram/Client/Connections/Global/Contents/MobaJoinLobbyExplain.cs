// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaJoinLobbyExplain : OperationRelatedExplainBase // TypeDefIndex: 15077
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357C824 Offset: 0x3578824 VA: 0x357C824
	public void .ctor() { }

	// RVA: 0x357C82C Offset: 0x357882C VA: 0x357C82C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357C834 Offset: 0x3578834 VA: 0x357C834 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357C83C Offset: 0x357883C VA: 0x357C83C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357C844 Offset: 0x3578844 VA: 0x357C844 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccessChangeField();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnJoinError(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
