// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Matching
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongLeaveRoomExplain : OperationRelatedExplainBase // TypeDefIndex: 15018
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3573640 Offset: 0x356F640 VA: 0x3573640
	public void .ctor() { }

	// RVA: 0x3573648 Offset: 0x356F648 VA: 0x3573648 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3573650 Offset: 0x356F650 VA: 0x3573650 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3573658 Offset: 0x356F658 VA: 0x3573658 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3573660 Offset: 0x356F660 VA: 0x3573660 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35737BC Offset: 0x356F7BC VA: 0x35737BC
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, MahjongLeaveRoomResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MahjongLeaveRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotJoined();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
