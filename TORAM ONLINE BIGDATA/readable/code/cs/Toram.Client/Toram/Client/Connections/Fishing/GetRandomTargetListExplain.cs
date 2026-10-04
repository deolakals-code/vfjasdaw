// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Fishing
[CLSCompliant(False)]
public abstract class GetRandomTargetListExplain : OperationRelatedExplainBase // TypeDefIndex: 15100
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357F138 Offset: 0x357B138 VA: 0x357F138
	public void .ctor() { }

	// RVA: 0x357F140 Offset: 0x357B140 VA: 0x357F140 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357F148 Offset: 0x357B148 VA: 0x357F148 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357F150 Offset: 0x357B150 VA: 0x357F150 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357F158 Offset: 0x357B158 VA: 0x357F158 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357F2B4 Offset: 0x357B2B4 VA: 0x357F2B4
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GetRandomTargetListResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GetRandomTargetListResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
