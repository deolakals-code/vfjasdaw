// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Matching
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongMatchingCancelExplain : OperationRelatedExplainBase // TypeDefIndex: 15011
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3572578 Offset: 0x356E578 VA: 0x3572578
	public void .ctor() { }

	// RVA: 0x3572580 Offset: 0x356E580 VA: 0x3572580 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3572588 Offset: 0x356E588 VA: 0x3572588 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3572590 Offset: 0x356E590 VA: 0x3572590 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3572598 Offset: 0x356E598 VA: 0x3572598 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35725B0 Offset: 0x356E5B0 VA: 0x35725B0
	private GameReturnCode ReceiveResponse(Game engine, short returnCode) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotJoined();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnWrongState();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnNotFound();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode);
}
