// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Matching
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongStartGameExplain : OperationRelatedExplainBase // TypeDefIndex: 15013
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357293C Offset: 0x356E93C VA: 0x357293C
	public void .ctor() { }

	// RVA: 0x3572944 Offset: 0x356E944 VA: 0x3572944 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357294C Offset: 0x356E94C VA: 0x357294C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3572954 Offset: 0x356E954 VA: 0x3572954 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357295C Offset: 0x356E95C VA: 0x357295C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3572974 Offset: 0x356E974 VA: 0x3572974
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
	protected abstract void OnMemberNotFound();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNotReady();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnFailure(short returnCode);
}
