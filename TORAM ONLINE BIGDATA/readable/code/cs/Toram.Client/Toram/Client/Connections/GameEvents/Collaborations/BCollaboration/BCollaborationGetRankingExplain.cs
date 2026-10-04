// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.GameEvents.Collaborations.BCollaboration
[CLSCompliant(False)]
public abstract class BCollaborationGetRankingExplain : OperationRelatedExplainBase // TypeDefIndex: 15113
{
	// Fields
	private readonly BCRankingItemType mainWeapon; // 0x10
	private readonly BCRankingItemType subWeapon; // 0x12

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35816A8 Offset: 0x357D6A8 VA: 0x35816A8
	public void .ctor(BCRankingItemType mainWeapon, BCRankingItemType subWeapon) { }

	// RVA: 0x35816D8 Offset: 0x357D6D8 VA: 0x35816D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35816E0 Offset: 0x357D6E0 VA: 0x35816E0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35816E8 Offset: 0x357D6E8 VA: 0x35816E8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3581758 Offset: 0x357D758 VA: 0x3581758 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3581808 Offset: 0x357D808 VA: 0x3581808
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, BCollaborationGetRankingResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(BCollaborationGetRankingResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();
}
