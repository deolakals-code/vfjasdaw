// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaCheckResultExplain : OperationRelatedExplainBase // TypeDefIndex: 15065
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357B6C0 Offset: 0x35776C0 VA: 0x357B6C0
	public void .ctor() { }

	// RVA: 0x357B6C8 Offset: 0x35776C8 VA: 0x357B6C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357B6D0 Offset: 0x35776D0 VA: 0x357B6D0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357B6D8 Offset: 0x35776D8 VA: 0x357B6D8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357B6E0 Offset: 0x35776E0 VA: 0x357B6E0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357B76C Offset: 0x357776C VA: 0x357B76C
	private GameReturnCode ReceiveResponse(short returnCode, MobaCheckResultResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaCheckResultResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNeedToLeave(MobaCheckResultResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnUnsuccessfulNeedToLeave(short returnCode, MobaCheckResultResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnGameNotOver(MobaCheckResultResponse response);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnFailure(short returnCode, MobaCheckResultResponse response);
}
