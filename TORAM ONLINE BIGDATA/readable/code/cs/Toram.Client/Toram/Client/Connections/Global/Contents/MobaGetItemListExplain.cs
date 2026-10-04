// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaGetItemListExplain : OperationRelatedExplainBase // TypeDefIndex: 15072
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357C0D4 Offset: 0x35780D4 VA: 0x357C0D4
	public void .ctor() { }

	// RVA: 0x357C0DC Offset: 0x35780DC VA: 0x357C0DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357C0E4 Offset: 0x35780E4 VA: 0x357C0E4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357C0EC Offset: 0x35780EC VA: 0x357C0EC Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357C0F4 Offset: 0x35780F4 VA: 0x357C0F4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357C180 Offset: 0x3578180 VA: 0x357C180
	private GameReturnCode ReceiveResponse(short returnCode, MobaGetItemListResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaGetItemListResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotStart(MobaGetItemListResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode, MobaGetItemListResponse response);
}
