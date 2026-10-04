// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Matching
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongCheckJoinRoomExplain : OperationRelatedExplainBase // TypeDefIndex: 15007
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3571A50 Offset: 0x356DA50 VA: 0x3571A50
	public void .ctor() { }

	// RVA: 0x3571A58 Offset: 0x356DA58 VA: 0x3571A58 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3571A60 Offset: 0x356DA60 VA: 0x3571A60 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3571A68 Offset: 0x356DA68 VA: 0x3571A68 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3571A70 Offset: 0x356DA70 VA: 0x3571A70 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3571BCC Offset: 0x356DBCC VA: 0x3571BCC
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, MahjongCheckJoinRoomResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MahjongCheckJoinRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
