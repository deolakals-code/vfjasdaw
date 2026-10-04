// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.TermEvents
[CLSCompliant(False)]
public abstract class GetActiveTermEventsExplain : OperationRelatedExplainBase // TypeDefIndex: 14923
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356235C Offset: 0x355E35C VA: 0x356235C
	public void .ctor() { }

	// RVA: 0x3562364 Offset: 0x355E364 VA: 0x3562364 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356236C Offset: 0x355E36C VA: 0x356236C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3562374 Offset: 0x355E374 VA: 0x3562374 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356237C Offset: 0x355E37C VA: 0x356237C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35624D8 Offset: 0x355E4D8 VA: 0x35624D8
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GetActiveTermEventsResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GetActiveTermEventsResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
