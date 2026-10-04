// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Parties
[CLSCompliant(False)]
public abstract class PartyRecruitingExplain : OperationRelatedExplainBase // TypeDefIndex: 14937
{
	// Fields
	private readonly string partyName; // 0x10
	private readonly byte recruitmentType; // 0x18
	private readonly string partyComments; // 0x20
	private readonly PartyMemberFrameData[] memberFrames; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3564584 Offset: 0x3560584 VA: 0x3564584
	public void .ctor(string partyName, byte recruitmentType, string partyComments, PartyMemberFrameData[] memberFrames) { }

	// RVA: 0x35645EC Offset: 0x35605EC VA: 0x35645EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35645F4 Offset: 0x35605F4 VA: 0x35645F4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35645FC Offset: 0x35605FC VA: 0x35645FC Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3564694 Offset: 0x3560694 VA: 0x3564694 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3564724 Offset: 0x3560724 VA: 0x3564724
	private GameReturnCode ReceiveResponse(short returnCode, PartyRecruitingResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(PartyRecruitingResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnStringProblem(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnContentProblem(short returnCode);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnMemberRecruitingProblem(short returnCode);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode);
}
