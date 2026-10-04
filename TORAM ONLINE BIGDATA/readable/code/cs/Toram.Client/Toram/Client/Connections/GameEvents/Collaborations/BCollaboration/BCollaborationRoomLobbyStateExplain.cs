// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.GameEvents.Collaborations.BCollaboration
[CLSCompliant(False)]
public abstract class BCollaborationRoomLobbyStateExplain : OperationRelatedExplainBase // TypeDefIndex: 15116
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3581D1C Offset: 0x357DD1C VA: 0x3581D1C
	public void .ctor() { }

	// RVA: 0x3581D24 Offset: 0x357DD24 VA: 0x3581D24 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3581D2C Offset: 0x357DD2C VA: 0x3581D2C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3581D34 Offset: 0x357DD34 VA: 0x3581D34 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3581D3C Offset: 0x357DD3C VA: 0x3581D3C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3581DEC Offset: 0x357DDEC VA: 0x3581DEC
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, BCollaborationRoomLobbyStateResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(BCollaborationRoomLobbyStateResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
