// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Parties
[CLSCompliant(False)]
public abstract class PartyRecruitmentApplyExplain : OperationRelatedExplainBase // TypeDefIndex: 14942
{
	// Fields
	private readonly int recruitmentId; // 0x10
	private readonly byte frameNo; // 0x14
	private readonly bool isRecruitmentList; // 0x15

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3564E2C Offset: 0x3560E2C VA: 0x3564E2C
	public void .ctor(int recruitmentId, byte frameNo, bool isRecruitmentList) { }

	// RVA: 0x3564E6C Offset: 0x3560E6C VA: 0x3564E6C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3564E74 Offset: 0x3560E74 VA: 0x3564E74 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3564E7C Offset: 0x3560E7C VA: 0x3564E7C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3564EF4 Offset: 0x3560EF4 VA: 0x3564EF4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotRecruited(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSlotNotAvailable(short returnCode);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNoVacancies(short returnCode);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode);
}
