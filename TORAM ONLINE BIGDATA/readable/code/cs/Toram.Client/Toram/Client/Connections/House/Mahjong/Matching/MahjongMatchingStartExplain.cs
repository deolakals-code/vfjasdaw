// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Matching
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongMatchingStartExplain : OperationRelatedExplainBase // TypeDefIndex: 15012
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357272C Offset: 0x356E72C VA: 0x357272C
	public void .ctor() { }

	// RVA: 0x3572734 Offset: 0x356E734 VA: 0x3572734 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357273C Offset: 0x356E73C VA: 0x357273C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3572744 Offset: 0x356E744 VA: 0x3572744 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357274C Offset: 0x356E74C VA: 0x357274C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3572764 Offset: 0x356E764 VA: 0x3572764
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
	protected abstract void OnWrongTarget();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnWrongState();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnDoNotNeed();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnAlreadyExists();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnFailure(short returnCode);
}
