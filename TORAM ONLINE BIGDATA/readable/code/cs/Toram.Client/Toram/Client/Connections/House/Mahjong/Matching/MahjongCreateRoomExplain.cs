// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Matching
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongCreateRoomExplain : OperationRelatedExplainBase // TypeDefIndex: 15008
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3571D0C Offset: 0x356DD0C VA: 0x3571D0C
	public void .ctor() { }

	// RVA: 0x3571D14 Offset: 0x356DD14 VA: 0x3571D14 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3571D1C Offset: 0x356DD1C VA: 0x3571D1C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3571D24 Offset: 0x356DD24 VA: 0x3571D24 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3571D2C Offset: 0x356DD2C VA: 0x3571D2C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3571E88 Offset: 0x356DE88 VA: 0x3571E88
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, MahjongCreateRoomResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MahjongCreateRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnAlreadyJoin();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailedToRoomCreate();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnFailure(short returnCode);
}
