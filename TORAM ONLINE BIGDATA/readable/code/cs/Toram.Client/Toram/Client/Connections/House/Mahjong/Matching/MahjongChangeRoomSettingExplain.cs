// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Matching
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongChangeRoomSettingExplain : OperationRelatedExplainBase // TypeDefIndex: 15009
{
	// Fields
	private MahjongRoomSettingData setting; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3571FFC Offset: 0x356DFFC VA: 0x3571FFC
	public void .ctor(MahjongRoomSettingData setting) { }

	// RVA: 0x357202C Offset: 0x356E02C VA: 0x357202C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3572034 Offset: 0x356E034 VA: 0x3572034 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357203C Offset: 0x356E03C VA: 0x357203C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35720AC Offset: 0x356E0AC VA: 0x35720AC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3572208 Offset: 0x356E208 VA: 0x3572208
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, MahjongChangeRoomSettingResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MahjongChangeRoomSettingResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotJoined();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNoAuthority();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnMemberOver();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnMemberNotFound();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnFailure(short returnCode);
}
