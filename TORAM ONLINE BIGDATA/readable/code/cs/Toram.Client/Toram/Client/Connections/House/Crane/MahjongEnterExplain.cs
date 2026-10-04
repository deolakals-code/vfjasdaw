// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Crane
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongEnterExplain : OperationRelatedExplainBase // TypeDefIndex: 15005
{
	// Fields
	private int objId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35714CC Offset: 0x356D4CC VA: 0x35714CC
	public void .ctor(int objId) { }

	// RVA: 0x35714F4 Offset: 0x356D4F4 VA: 0x35714F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35714FC Offset: 0x356D4FC VA: 0x35714FC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3571504 Offset: 0x356D504 VA: 0x3571504 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357156C Offset: 0x356D56C VA: 0x357156C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3571590 Offset: 0x356D590 VA: 0x3571590
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OperationResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
