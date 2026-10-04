// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaReadyOkExplain : OperationRelatedExplainBase // TypeDefIndex: 15084
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357D178 Offset: 0x3579178 VA: 0x357D178
	public void .ctor() { }

	// RVA: 0x357D180 Offset: 0x3579180 VA: 0x357D180 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357D188 Offset: 0x3579188 VA: 0x357D188 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357D190 Offset: 0x3579190 VA: 0x357D190 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357D198 Offset: 0x3579198 VA: 0x357D198 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357D224 Offset: 0x3579224 VA: 0x357D224
	private GameReturnCode ReceiveResponse(short returnCode, MobaReadyOkResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaReadyOkResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNeedToLeave(short returnCode, MobaReadyOkResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnUnsuccessfulNeedToLeave(short returnCode, MobaReadyOkResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode, MobaReadyOkResponse response);
}
