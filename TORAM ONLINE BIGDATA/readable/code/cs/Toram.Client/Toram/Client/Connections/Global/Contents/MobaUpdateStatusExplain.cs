// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaUpdateStatusExplain : OperationRelatedExplainBase // TypeDefIndex: 15094
{
	// Fields
	private readonly PrimaryStatusData statusData; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357DFF0 Offset: 0x3579FF0 VA: 0x357DFF0
	public void .ctor(PrimaryStatusData statusData) { }

	// RVA: 0x357E020 Offset: 0x357A020 VA: 0x357E020 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357E028 Offset: 0x357A028 VA: 0x357E028 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357E030 Offset: 0x357A030 VA: 0x357E030 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357E0A0 Offset: 0x357A0A0 VA: 0x357E0A0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357E12C Offset: 0x357A12C VA: 0x357E12C
	private GameReturnCode ReceiveResponse(short returnCode, MobaUpdateStatusResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaUpdateStatusResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotStart(MobaUpdateStatusResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnProblemTime(MobaUpdateStatusResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnStatusValueWrong(short returnCode);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnFailure(short returnCode, MobaUpdateStatusResponse response);
}
