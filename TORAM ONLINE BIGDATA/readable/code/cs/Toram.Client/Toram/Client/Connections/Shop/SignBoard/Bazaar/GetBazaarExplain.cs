// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop.SignBoard.Bazaar
[CLSCompliant(False)]
public abstract class GetBazaarExplain : OperationRelatedExplainBase // TypeDefIndex: 14964
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3569600 Offset: 0x3565600 VA: 0x3569600
	public void .ctor() { }

	// RVA: 0x3569608 Offset: 0x3565608 VA: 0x3569608 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3569610 Offset: 0x3565610 VA: 0x3569610 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3569618 Offset: 0x3565618 VA: 0x3569618 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3569620 Offset: 0x3565620 VA: 0x3569620 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356977C Offset: 0x356577C VA: 0x356977C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GetBazaarResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GetBazaarResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnPutupSignboard();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
