// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Parties
[CLSCompliant(False)]
public abstract class PartyRecruitmentUpdateExplain : OperationRelatedExplainBase // TypeDefIndex: 14936
{
	// Fields
	private readonly int recruitmentId; // 0x10
	private readonly string partyName; // 0x18
	private readonly byte recruitmentType; // 0x20
	private readonly string partyComments; // 0x28
	private readonly PartyMemberFrameData[] memberFrames; // 0x30

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35642B0 Offset: 0x35602B0 VA: 0x35642B0
	public void .ctor(int recruitmentId, string partyName, byte recruitmentType, string partyComments, PartyMemberFrameData[] memberFrames) { }

	// RVA: 0x3564328 Offset: 0x3560328 VA: 0x3564328 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3564330 Offset: 0x3560330 VA: 0x3564330 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3564338 Offset: 0x3560338 VA: 0x3564338 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35643D8 Offset: 0x35603D8 VA: 0x35643D8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3564468 Offset: 0x3560468 VA: 0x3564468
	private GameReturnCode ReceiveResponse(short returnCode, PartyRecruitmentUpdateResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(PartyRecruitmentUpdateResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnStringProblem(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnContentProblem(short returnCode);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnMemberRecruitingProblem(short returnCode);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnNotRecruiting(short returnCode);

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnFailure(short returnCode);
}
