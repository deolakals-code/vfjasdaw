// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Parties
[CLSCompliant(False)]
public abstract class PartyRecruitmentQuitExplain : OperationRelatedExplainBase // TypeDefIndex: 14945
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35652C0 Offset: 0x35612C0 VA: 0x35652C0
	public void .ctor() { }

	// RVA: 0x35652C8 Offset: 0x35612C8 VA: 0x35652C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35652D0 Offset: 0x35612D0 VA: 0x35652D0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35652D8 Offset: 0x35612D8 VA: 0x35652D8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35652E0 Offset: 0x35612E0 VA: 0x35652E0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(PartyRecruitmentQuitResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotRecruiting(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
