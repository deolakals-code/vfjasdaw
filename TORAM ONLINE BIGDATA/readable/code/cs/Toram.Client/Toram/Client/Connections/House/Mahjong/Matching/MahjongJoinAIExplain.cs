// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Matching
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongJoinAIExplain : OperationRelatedExplainBase // TypeDefIndex: 15010
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35723AC Offset: 0x356E3AC VA: 0x35723AC
	public void .ctor() { }

	// RVA: 0x35723B4 Offset: 0x356E3B4 VA: 0x35723B4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35723BC Offset: 0x356E3BC VA: 0x35723BC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35723C4 Offset: 0x356E3C4 VA: 0x35723C4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35723CC Offset: 0x356E3CC VA: 0x35723CC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35723E4 Offset: 0x356E3E4 VA: 0x35723E4
	private GameReturnCode ReceiveResponse(Game engine, short returnCode) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotJoined();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNoAuthority();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnAlreadyJoin();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNoVacancies();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnFailure(short returnCode);
}
