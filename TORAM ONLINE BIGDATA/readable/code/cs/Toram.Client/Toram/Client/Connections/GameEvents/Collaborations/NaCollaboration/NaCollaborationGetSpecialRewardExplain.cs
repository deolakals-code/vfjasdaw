// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.GameEvents.Collaborations.NaCollaboration
[CLSCompliant(False)]
public abstract class NaCollaborationGetSpecialRewardExplain : OperationRelatedExplainBase // TypeDefIndex: 15111
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35811EC Offset: 0x357D1EC VA: 0x35811EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35811F4 Offset: 0x357D1F4 VA: 0x35811F4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35811FC Offset: 0x357D1FC VA: 0x35811FC Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3581250 Offset: 0x357D250 VA: 0x3581250 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3581300 Offset: 0x357D300 VA: 0x3581300
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, NaCollaborationGetSpecialRewardResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(RewardResponseDatav2 reward);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: 0x358142C Offset: 0x357D42C VA: 0x358142C
	protected void .ctor() { }
}
