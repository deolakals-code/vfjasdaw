// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Matching
[Obsolete("rm24855適応後削除予定")]
[CLSCompliant(False)]
public abstract class MahjongJoinRoomExplain : OperationRelatedExplainBase // TypeDefIndex: 15014
{
	// Fields
	private int roomId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3572B08 Offset: 0x356EB08 VA: 0x3572B08
	public void .ctor(int roomId) { }

	// RVA: 0x3572B30 Offset: 0x356EB30 VA: 0x3572B30 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3572B38 Offset: 0x356EB38 VA: 0x3572B38 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3572B40 Offset: 0x356EB40 VA: 0x3572B40 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3572BA8 Offset: 0x356EBA8 VA: 0x3572BA8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3572D04 Offset: 0x356ED04 VA: 0x3572D04
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, MahjongJoinRoomResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MahjongJoinRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnAlreadyJoin();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNotFound();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnAlreadyStart();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNoVacancies();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnFailure(short returnCode);
}
