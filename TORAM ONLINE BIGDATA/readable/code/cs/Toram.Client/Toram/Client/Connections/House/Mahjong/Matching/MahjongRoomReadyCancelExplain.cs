// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Matching
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongRoomReadyCancelExplain : OperationRelatedExplainBase // TypeDefIndex: 15016
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3573268 Offset: 0x356F268 VA: 0x3573268
	public void .ctor() { }

	// RVA: 0x3573270 Offset: 0x356F270 VA: 0x3573270 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3573278 Offset: 0x356F278 VA: 0x3573278 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3573280 Offset: 0x356F280 VA: 0x3573280 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3573288 Offset: 0x356F288 VA: 0x3573288 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35732A0 Offset: 0x356F2A0 VA: 0x35732A0
	private GameReturnCode ReceiveResponse(Game engine, short returnCode) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotJoined();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNoChange();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnMemberNotFound();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnAlreadyStart();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnFailure(short returnCode);
}
