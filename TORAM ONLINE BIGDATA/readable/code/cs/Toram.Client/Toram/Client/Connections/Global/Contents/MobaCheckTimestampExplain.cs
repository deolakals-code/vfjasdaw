// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaCheckTimestampExplain : OperationRelatedExplainBase // TypeDefIndex: 15066
{
	// Fields
	private readonly bool isUpdateTimestamp; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357B810 Offset: 0x3577810 VA: 0x357B810
	public void .ctor(bool isUpdateTimestamp) { }

	// RVA: 0x357B838 Offset: 0x3577838 VA: 0x357B838 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357B840 Offset: 0x3577840 VA: 0x357B840 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357B848 Offset: 0x3577848 VA: 0x357B848 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357B89C Offset: 0x357789C VA: 0x357B89C Slot: 7
	public override void SendOperation(Game engine) { }

	// RVA: 0x357B944 Offset: 0x3577944 VA: 0x357B944 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnTimeIsNotOver();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnTimeOver();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
