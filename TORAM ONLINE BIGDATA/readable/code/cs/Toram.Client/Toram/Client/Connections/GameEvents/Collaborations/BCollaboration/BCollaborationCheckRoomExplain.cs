// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.GameEvents.Collaborations.BCollaboration
[CLSCompliant(False)]
public abstract class BCollaborationCheckRoomExplain : OperationRelatedExplainBase // TypeDefIndex: 15120
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3582578 Offset: 0x357E578 VA: 0x3582578
	public void .ctor() { }

	// RVA: 0x3582580 Offset: 0x357E580 VA: 0x3582580 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3582588 Offset: 0x357E588 VA: 0x3582588 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3582590 Offset: 0x357E590 VA: 0x3582590 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35825E4 Offset: 0x357E5E4 VA: 0x35825E4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3582694 Offset: 0x357E694 VA: 0x3582694
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, BCollaborationCheckRoomResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(BCollaborationCheckRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
