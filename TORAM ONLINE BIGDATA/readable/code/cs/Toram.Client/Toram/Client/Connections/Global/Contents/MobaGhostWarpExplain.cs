// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaGhostWarpExplain : OperationRelatedExplainBase // TypeDefIndex: 15074
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357C370 Offset: 0x3578370 VA: 0x357C370
	public void .ctor() { }

	// RVA: 0x357C378 Offset: 0x3578378 VA: 0x357C378 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357C380 Offset: 0x3578380 VA: 0x357C380 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357C388 Offset: 0x3578388 VA: 0x357C388 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357C390 Offset: 0x3578390 VA: 0x357C390 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357C41C Offset: 0x357841C VA: 0x357C41C
	private GameReturnCode ReceiveResponse(short returnCode, MobaGhostWarpResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaGhostWarpResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode, MobaGhostWarpResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnTimeIsNotOver(MobaGhostWarpResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnWrongState(MobaGhostWarpResponse response);
}
