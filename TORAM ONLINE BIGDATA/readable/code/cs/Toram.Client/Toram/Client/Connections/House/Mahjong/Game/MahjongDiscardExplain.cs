// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Game
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongDiscardExplain : OperationRelatedExplainBase // TypeDefIndex: 15020
{
	// Fields
	private int uid; // 0x10
	private bool isRiichi; // 0x14
	private bool isKyushukyuhai; // 0x15
	private int destinyDrawId; // 0x18
	private bool isWhiteMagic; // 0x1C
	private bool isKakukan; // 0x1D
	private int sfPickUpUid; // 0x20
	private int sfDiscardUid; // 0x24
	private int graffitiId; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3573BEC Offset: 0x356FBEC VA: 0x3573BEC
	public void .ctor(int uid, bool isRiichi, bool isKyushukyuhai, int destinyDrawId = 34, bool isWhiteMagic = False, bool isKakukan = False, int sfPickUpUid = 0, int sfDiscardUid = 0, int graffitiId = 34) { }

	// RVA: 0x3573C70 Offset: 0x356FC70 VA: 0x3573C70 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3573C78 Offset: 0x356FC78 VA: 0x3573C78 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3573C80 Offset: 0x356FC80 VA: 0x3573C80 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3573D20 Offset: 0x356FD20 VA: 0x3573D20 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3573D38 Offset: 0x356FD38 VA: 0x3573D38
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
