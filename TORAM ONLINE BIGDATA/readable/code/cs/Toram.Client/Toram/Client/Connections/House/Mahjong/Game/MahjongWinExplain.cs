// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Game
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongWinExplain : OperationRelatedExplainBase // TypeDefIndex: 15022
{
	// Fields
	private bool isTsumo; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3574014 Offset: 0x3570014 VA: 0x3574014
	public void .ctor(bool isTsumo) { }

	// RVA: 0x357403C Offset: 0x357003C VA: 0x357403C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3574044 Offset: 0x3570044 VA: 0x3574044 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357404C Offset: 0x357004C VA: 0x357404C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35740B4 Offset: 0x35700B4 VA: 0x35740B4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35740CC Offset: 0x35700CC VA: 0x35740CC
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
	protected abstract void OnNotMyTurn();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNotMatch();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnFailure(short returnCode);
}
