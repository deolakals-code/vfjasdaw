// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaDetailHistoryExplain : OperationRelatedExplainBase // TypeDefIndex: 15070
{
	// Fields
	private readonly int gameUniqueId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357BF14 Offset: 0x3577F14 VA: 0x357BF14
	public void .ctor(int gameUniqueId) { }

	// RVA: 0x357BF3C Offset: 0x3577F3C VA: 0x357BF3C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357BF44 Offset: 0x3577F44 VA: 0x357BF44 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357BF4C Offset: 0x3577F4C VA: 0x357BF4C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357BFB4 Offset: 0x3577FB4 VA: 0x357BFB4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaDetailHistoryResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
