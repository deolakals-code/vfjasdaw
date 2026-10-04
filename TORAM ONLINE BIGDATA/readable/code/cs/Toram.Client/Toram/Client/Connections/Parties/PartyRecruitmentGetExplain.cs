// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Parties
[CLSCompliant(False)]
public abstract class PartyRecruitmentGetExplain : OperationRelatedExplainBase // TypeDefIndex: 14935
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35641EC Offset: 0x35601EC VA: 0x35641EC
	public void .ctor() { }

	// RVA: 0x35641F4 Offset: 0x35601F4 VA: 0x35641F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35641FC Offset: 0x35601FC VA: 0x35641FC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3564204 Offset: 0x3560204 VA: 0x3564204 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356420C Offset: 0x356020C VA: 0x356420C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(PartyRecruitmentGetResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
