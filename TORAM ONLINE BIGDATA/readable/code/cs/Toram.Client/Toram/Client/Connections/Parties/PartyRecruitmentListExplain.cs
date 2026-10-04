// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Parties
[CLSCompliant(False)]
public abstract class PartyRecruitmentListExplain : OperationRelatedExplainBase // TypeDefIndex: 14944
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3565168 Offset: 0x3561168 VA: 0x3565168
	public void .ctor() { }

	// RVA: 0x3565170 Offset: 0x3561170 VA: 0x3565170 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3565178 Offset: 0x3561178 VA: 0x3565178 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3565180 Offset: 0x3561180 VA: 0x3565180 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35651D4 Offset: 0x35611D4 VA: 0x35651D4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3565264 Offset: 0x3561264 VA: 0x3565264
	private GameReturnCode ReceiveResponse(short returnCode, PartyRecruitmentListResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(PartyRecruitmentListResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
