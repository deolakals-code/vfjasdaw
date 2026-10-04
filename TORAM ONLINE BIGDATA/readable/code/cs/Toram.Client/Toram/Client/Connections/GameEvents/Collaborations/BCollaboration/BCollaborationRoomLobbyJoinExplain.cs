// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.GameEvents.Collaborations.BCollaboration
[CLSCompliant(False)]
public abstract class BCollaborationRoomLobbyJoinExplain : OperationRelatedExplainBase // TypeDefIndex: 15118
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3582104 Offset: 0x357E104 VA: 0x3582104
	public void .ctor() { }

	// RVA: 0x358210C Offset: 0x357E10C VA: 0x358210C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3582114 Offset: 0x357E114 VA: 0x3582114 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x358211C Offset: 0x357E11C VA: 0x358211C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3582170 Offset: 0x357E170 VA: 0x3582170 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3582220 Offset: 0x357E220 VA: 0x3582220
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, BCollaborationRoomLobbyJoinResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(BCollaborationRoomLobbyJoinResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
