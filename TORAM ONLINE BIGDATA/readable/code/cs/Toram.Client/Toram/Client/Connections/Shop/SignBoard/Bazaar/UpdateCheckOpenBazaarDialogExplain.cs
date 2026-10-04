// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop.SignBoard.Bazaar
[CLSCompliant(False)]
public abstract class UpdateCheckOpenBazaarDialogExplain : OperationRelatedExplainBase // TypeDefIndex: 14963
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3569344 Offset: 0x3565344 VA: 0x3569344
	public void .ctor() { }

	// RVA: 0x356934C Offset: 0x356534C VA: 0x356934C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3569354 Offset: 0x3565354 VA: 0x3569354 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356935C Offset: 0x356535C VA: 0x356935C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3569364 Offset: 0x3565364 VA: 0x3569364 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35694C0 Offset: 0x35654C0 VA: 0x35694C0
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, UpdateCheckOpenBazaarDialogResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(UpdateCheckOpenBazaarDialogResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnAlreadUpdate();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
