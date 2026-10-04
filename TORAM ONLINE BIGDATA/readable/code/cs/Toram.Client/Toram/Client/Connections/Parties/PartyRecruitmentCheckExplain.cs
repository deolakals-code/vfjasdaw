// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Parties
[CLSCompliant(False)]
public abstract class PartyRecruitmentCheckExplain : OperationRelatedExplainBase // TypeDefIndex: 14941
{
	// Fields
	private readonly int recruitmentId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3564C78 Offset: 0x3560C78 VA: 0x3564C78
	public void .ctor(int recruitmentId) { }

	// RVA: 0x3564CA0 Offset: 0x3560CA0 VA: 0x3564CA0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3564CA8 Offset: 0x3560CA8 VA: 0x3564CA8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3564CB0 Offset: 0x3560CB0 VA: 0x3564CB0 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3564D18 Offset: 0x3560D18 VA: 0x3564D18 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3564DA8 Offset: 0x3560DA8 VA: 0x3564DA8
	private GameReturnCode ReceiveResponse(short returnCode, PartyRecruitmentCheckResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(PartyRecruitmentCheckResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotRecruited(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
