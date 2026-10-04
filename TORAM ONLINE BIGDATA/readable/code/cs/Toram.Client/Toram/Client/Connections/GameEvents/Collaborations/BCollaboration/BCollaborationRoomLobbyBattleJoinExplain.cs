// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.GameEvents.Collaborations.BCollaboration
[CLSCompliant(False)]
public abstract class BCollaborationRoomLobbyBattleJoinExplain : OperationRelatedExplainBase // TypeDefIndex: 15119
{
	// Fields
	private readonly short[] position; // 0x10
	private readonly short rotation; // 0x18
	private readonly EmergencyPositionData emergencyPositionData; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3582344 Offset: 0x357E344 VA: 0x3582344
	public void .ctor(short[] position, short rotation, EmergencyPositionData emergencyPositionData) { }

	// RVA: 0x3582398 Offset: 0x357E398 VA: 0x3582398 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35823A0 Offset: 0x357E3A0 VA: 0x35823A0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35823A8 Offset: 0x357E3A8 VA: 0x35823A8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3582430 Offset: 0x357E430 VA: 0x3582430 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3582454 Offset: 0x357E454 VA: 0x3582454
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OperationResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
