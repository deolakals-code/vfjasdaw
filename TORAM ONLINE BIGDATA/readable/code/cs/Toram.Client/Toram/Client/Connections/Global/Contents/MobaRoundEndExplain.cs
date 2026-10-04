// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaRoundEndExplain : OperationRelatedExplainBase // TypeDefIndex: 15088
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357D734 Offset: 0x3579734 VA: 0x357D734
	public void .ctor() { }

	// RVA: 0x357D73C Offset: 0x357973C VA: 0x357D73C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357D744 Offset: 0x3579744 VA: 0x357D744 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357D74C Offset: 0x357974C VA: 0x357D74C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357D754 Offset: 0x3579754 VA: 0x357D754 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotValidPhase();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
