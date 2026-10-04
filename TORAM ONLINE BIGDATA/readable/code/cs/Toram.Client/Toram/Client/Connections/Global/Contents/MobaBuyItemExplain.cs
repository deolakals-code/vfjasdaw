// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaBuyItemExplain : OperationRelatedExplainBase // TypeDefIndex: 15062
{
	// Fields
	private readonly int shopItemId; // 0x10
	private readonly int buyPrice; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357B2F0 Offset: 0x35772F0 VA: 0x357B2F0
	public void .ctor(int shopItemId, int buyPrice) { }

	// RVA: 0x357B31C Offset: 0x357731C VA: 0x357B31C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357B324 Offset: 0x3577324 VA: 0x357B324 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357B32C Offset: 0x357732C VA: 0x357B32C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357B394 Offset: 0x3577394 VA: 0x357B394 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357B420 Offset: 0x3577420 VA: 0x357B420
	private GameReturnCode ReceiveResponse(short returnCode, MobaBuyItemResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaBuyItemResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotStart(MobaBuyItemResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotMatch(MobaBuyItemResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode, MobaBuyItemResponse response);
}
