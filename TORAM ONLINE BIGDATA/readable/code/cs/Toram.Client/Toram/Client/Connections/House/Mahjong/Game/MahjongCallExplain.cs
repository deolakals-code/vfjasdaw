// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Game
[Obsolete("rm24855適応後削除予定")]
[CLSCompliant(False)]
public abstract class MahjongCallExplain : OperationRelatedExplainBase // TypeDefIndex: 15019
{
	// Fields
	private byte callType; // 0x10
	private int[] myTileUidList; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3573924 Offset: 0x356F924 VA: 0x3573924
	public void .ctor(byte callType, int[] myTileUidList) { }

	// RVA: 0x357395C Offset: 0x356F95C VA: 0x357395C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3573964 Offset: 0x356F964 VA: 0x3573964 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357396C Offset: 0x356F96C VA: 0x357396C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35739E4 Offset: 0x356F9E4 VA: 0x35739E4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35739FC Offset: 0x356F9FC VA: 0x35739FC
	private GameReturnCode ReceiveResponse(Game engine, short returnCode) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotJoined();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNotStart();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnTypeWrong();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNotMyTurn();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnValueWrong();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnNotMatch();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnMaxKan();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnFailure(short returnCode);
}
