// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Parties
[CLSCompliant(False)]
public abstract class PartyRecruitmentCandidateCancelExplain : OperationRelatedExplainBase // TypeDefIndex: 14940
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3564B8C Offset: 0x3560B8C VA: 0x3564B8C
	public void .ctor() { }

	// RVA: 0x3564B94 Offset: 0x3560B94 VA: 0x3564B94 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3564B9C Offset: 0x3560B9C VA: 0x3564B9C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3564BA4 Offset: 0x3560BA4 VA: 0x3564BA4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3564BAC Offset: 0x3560BAC VA: 0x3564BAC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3564C28 Offset: 0x3560C28 VA: 0x3564C28
	private GameReturnCode ReceiveResponse(short returnCode, PartyRecruitmentCandidateCancelResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnReserveNotFound();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
