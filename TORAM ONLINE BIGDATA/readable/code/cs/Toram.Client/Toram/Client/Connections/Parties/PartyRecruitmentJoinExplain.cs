// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Parties
[CLSCompliant(False)]
public abstract class PartyRecruitmentJoinExplain : OperationRelatedExplainBase // TypeDefIndex: 14943
{
	// Fields
	private readonly int partyId; // 0x10
	private readonly int recruitmentId; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3564FD8 Offset: 0x3560FD8 VA: 0x3564FD8
	public void .ctor(int partyId, int recruitmentId) { }

	// RVA: 0x3565004 Offset: 0x3561004 VA: 0x3565004 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356500C Offset: 0x356100C VA: 0x356500C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3565014 Offset: 0x3561014 VA: 0x3565014 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356507C Offset: 0x356107C VA: 0x356507C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNoVacancies();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotRecruited(short returnCode);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnSlotNotAvailable(short returnCode);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnCandidateProblem(short returnCode);

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode);
}
