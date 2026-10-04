// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Parties
[CLSCompliant(False)]
public abstract class PartyRecruitmentApproveExplain : OperationRelatedExplainBase // TypeDefIndex: 14938
{
	// Fields
	private readonly byte frameNo; // 0x10
	private readonly int targetAvatarUuid; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3564818 Offset: 0x3560818 VA: 0x3564818
	public void .ctor(byte frameNo, int targetAvatarUuid) { }

	// RVA: 0x3564848 Offset: 0x3560848 VA: 0x3564848 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3564850 Offset: 0x3560850 VA: 0x3564850 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3564858 Offset: 0x3560858 VA: 0x3564858 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35648C8 Offset: 0x35608C8 VA: 0x35648C8 Slot: 9
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
	protected abstract void OnNotLogged();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnFailure(short returnCode);
}
