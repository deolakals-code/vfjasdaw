// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.GameEvents.Collaborations.BCollaboration
[CLSCompliant(False)]
public abstract class BCollaborationRoomLobbyJoinCancelExplain : OperationRelatedExplainBase // TypeDefIndex: 15117
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3581F10 Offset: 0x357DF10 VA: 0x3581F10
	public void .ctor() { }

	// RVA: 0x3581F18 Offset: 0x357DF18 VA: 0x3581F18 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3581F20 Offset: 0x357DF20 VA: 0x3581F20 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3581F28 Offset: 0x357DF28 VA: 0x3581F28 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3581F30 Offset: 0x357DF30 VA: 0x3581F30 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3581FE0 Offset: 0x357DFE0 VA: 0x3581FE0
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, BCollaborationRoomLobbyJoinCancelResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(BCollaborationRoomLobbyJoinCancelResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
