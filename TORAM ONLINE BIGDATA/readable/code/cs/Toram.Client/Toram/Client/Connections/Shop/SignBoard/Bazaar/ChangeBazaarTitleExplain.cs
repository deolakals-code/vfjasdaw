// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop.SignBoard.Bazaar
[CLSCompliant(False)]
public abstract class ChangeBazaarTitleExplain : OperationRelatedExplainBase // TypeDefIndex: 14960
{
	// Fields
	private string title; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3568898 Offset: 0x3564898 VA: 0x3568898
	public void .ctor(string title) { }

	// RVA: 0x35688C8 Offset: 0x35648C8 VA: 0x35688C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35688D0 Offset: 0x35648D0 VA: 0x35688D0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35688D8 Offset: 0x35648D8 VA: 0x35688D8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3568948 Offset: 0x3564948 VA: 0x3568948 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3568AA4 Offset: 0x3564AA4 VA: 0x3568AA4
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ChangeBazaarTitleResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ChangeBazaarTitleResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnPutupSignboard();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNoChange();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnLengthOver();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode);
}
