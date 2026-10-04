// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaBattleHistoryExplain : OperationRelatedExplainBase // TypeDefIndex: 15059
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357AE50 Offset: 0x3576E50 VA: 0x357AE50
	public void .ctor() { }

	// RVA: 0x357AE58 Offset: 0x3576E58 VA: 0x357AE58 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357AE60 Offset: 0x3576E60 VA: 0x357AE60 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357AE68 Offset: 0x3576E68 VA: 0x357AE68 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357AE70 Offset: 0x3576E70 VA: 0x357AE70 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaBattleHistoryResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
