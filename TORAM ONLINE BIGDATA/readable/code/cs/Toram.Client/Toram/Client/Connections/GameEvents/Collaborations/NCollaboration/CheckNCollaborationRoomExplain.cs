// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.GameEvents.Collaborations.NCollaboration
[CLSCompliant(False)]
public abstract class CheckNCollaborationRoomExplain : OperationRelatedExplainBase // TypeDefIndex: 15109
{
	// Fields
	private readonly int fieldId; // 0x10
	private readonly byte roomId; // 0x14
	private readonly byte flag; // 0x15

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3580CB4 Offset: 0x357CCB4 VA: 0x3580CB4
	public void .ctor(int fieldId, byte roomId, byte flag) { }

	// RVA: 0x3580CF4 Offset: 0x357CCF4 VA: 0x3580CF4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3580CFC Offset: 0x357CCFC VA: 0x3580CFC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3580D04 Offset: 0x357CD04 VA: 0x3580D04 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3580D7C Offset: 0x357CD7C VA: 0x3580D7C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3580E2C Offset: 0x357CE2C VA: 0x3580E2C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, CheckNCollaborationRoomResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(CheckNCollaborationRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
