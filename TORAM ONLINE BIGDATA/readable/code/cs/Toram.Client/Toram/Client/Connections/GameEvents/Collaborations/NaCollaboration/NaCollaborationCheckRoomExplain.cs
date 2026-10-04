// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.GameEvents.Collaborations.NaCollaboration
[CLSCompliant(False)]
public abstract class NaCollaborationCheckRoomExplain : OperationRelatedExplainBase // TypeDefIndex: 15110
{
	// Fields
	private readonly int fieldId; // 0x10
	private readonly byte roomId; // 0x14
	private readonly byte flag; // 0x15

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3580F50 Offset: 0x357CF50 VA: 0x3580F50
	public void .ctor(int fieldId, byte roomId, byte flag) { }

	// RVA: 0x3580F90 Offset: 0x357CF90 VA: 0x3580F90 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3580F98 Offset: 0x357CF98 VA: 0x3580F98 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3580FA0 Offset: 0x357CFA0 VA: 0x3580FA0 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3581018 Offset: 0x357D018 VA: 0x3581018 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35810C8 Offset: 0x357D0C8 VA: 0x35810C8
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, NaCollaborationCheckRoomResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(NaCollaborationCheckRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
