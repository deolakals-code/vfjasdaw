// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Matching
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongKickoutMemberExplain : OperationRelatedExplainBase // TypeDefIndex: 15015
{
	// Fields
	private int archetypeId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3572EA8 Offset: 0x356EEA8 VA: 0x3572EA8
	public void .ctor(int archetypeId) { }

	// RVA: 0x3572ED0 Offset: 0x356EED0 VA: 0x3572ED0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3572ED8 Offset: 0x356EED8 VA: 0x3572ED8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3572EE0 Offset: 0x356EEE0 VA: 0x3572EE0 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3572F48 Offset: 0x356EF48 VA: 0x3572F48 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35730A4 Offset: 0x356F0A4 VA: 0x35730A4
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, MahjongKickoutMemberResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MahjongKickoutMemberResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotJoined();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnAlreadyStart();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnValueWrong();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNoAuthority();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnMemberNotFound();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnFailure(short returnCode);
}
