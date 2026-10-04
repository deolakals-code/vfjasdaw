// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.GameEvents.Collaborations.BCollaboration
[CLSCompliant(False)]
public abstract class BCollaborationRoomLobbyLeaveExplain : OperationRelatedExplainBase // TypeDefIndex: 15114
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3581950 Offset: 0x357D950 VA: 0x3581950
	public void .ctor() { }

	// RVA: 0x3581958 Offset: 0x357D958 VA: 0x3581958 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3581960 Offset: 0x357D960 VA: 0x3581960 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3581968 Offset: 0x357D968 VA: 0x3581968 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3581970 Offset: 0x357D970 VA: 0x3581970 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3581994 Offset: 0x357D994 VA: 0x3581994
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OperationResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
