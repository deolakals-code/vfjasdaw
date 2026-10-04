// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.CraneGame
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongLeaveExplain : OperationRelatedExplainBase // TypeDefIndex: 15029
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3574EDC Offset: 0x3570EDC VA: 0x3574EDC
	public void .ctor() { }

	// RVA: 0x3574EE4 Offset: 0x3570EE4 VA: 0x3574EE4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3574EEC Offset: 0x3570EEC VA: 0x3574EEC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3574EF4 Offset: 0x3570EF4 VA: 0x3574EF4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3574EFC Offset: 0x3570EFC VA: 0x3574EFC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3574F20 Offset: 0x3570F20 VA: 0x3574F20
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OperationResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnRoomJoined();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
