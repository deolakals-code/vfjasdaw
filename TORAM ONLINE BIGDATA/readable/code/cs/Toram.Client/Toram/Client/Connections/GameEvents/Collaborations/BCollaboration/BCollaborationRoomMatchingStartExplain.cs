// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.GameEvents.Collaborations.BCollaboration
[CLSCompliant(False)]
public abstract class BCollaborationRoomMatchingStartExplain : OperationRelatedExplainBase // TypeDefIndex: 15115
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3581AB8 Offset: 0x357DAB8 VA: 0x3581AB8
	public void .ctor() { }

	// RVA: 0x3581AC0 Offset: 0x357DAC0 VA: 0x3581AC0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3581AC8 Offset: 0x357DAC8 VA: 0x3581AC8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3581AD0 Offset: 0x357DAD0 VA: 0x3581AD0 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3581B24 Offset: 0x357DB24 VA: 0x3581B24 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3581BD4 Offset: 0x357DBD4 VA: 0x3581BD4
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, BCollaborationRoomMatchingStartResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(BCollaborationRoomMatchingStartResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnRoomDisposed();
}
