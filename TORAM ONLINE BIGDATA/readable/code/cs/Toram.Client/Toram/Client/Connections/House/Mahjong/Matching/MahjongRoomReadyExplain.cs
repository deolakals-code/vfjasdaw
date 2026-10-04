// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Matching
[Obsolete("rm24855適応後削除予定")]
[CLSCompliant(False)]
public abstract class MahjongRoomReadyExplain : OperationRelatedExplainBase // TypeDefIndex: 15017
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3573454 Offset: 0x356F454 VA: 0x3573454
	public void .ctor() { }

	// RVA: 0x357345C Offset: 0x356F45C VA: 0x357345C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3573464 Offset: 0x356F464 VA: 0x3573464 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357346C Offset: 0x356F46C VA: 0x357346C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3573474 Offset: 0x356F474 VA: 0x3573474 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357348C Offset: 0x356F48C VA: 0x357348C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotJoined();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnAlreadyStart();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnNoChange();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnMemberNotFound();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnFailure(short returnCode);
}
