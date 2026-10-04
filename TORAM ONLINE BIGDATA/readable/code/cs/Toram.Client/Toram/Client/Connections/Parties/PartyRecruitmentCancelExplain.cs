// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Parties
[CLSCompliant(False)]
public abstract class PartyRecruitmentCancelExplain : OperationRelatedExplainBase // TypeDefIndex: 14939
{
	// Fields
	private readonly byte frameNo; // 0x10
	private readonly int targetAvatarUuid; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35649C0 Offset: 0x35609C0 VA: 0x35649C0
	public void .ctor(byte frameNo, int targetAvatarUuid) { }

	// RVA: 0x35649F0 Offset: 0x35609F0 VA: 0x35649F0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35649F8 Offset: 0x35609F8 VA: 0x35649F8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3564A00 Offset: 0x3560A00 VA: 0x3564A00 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3564A70 Offset: 0x3560A70 VA: 0x3564A70 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(PartyRecruitmentCancelResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotRecruited(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSlotNotAvailable(short returnCode);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnCandidateProblem(short returnCode);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnFailure(short returnCode);
}
