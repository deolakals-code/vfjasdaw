// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.CraneGame
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class CraneGameEnterExplain : OperationRelatedExplainBase // TypeDefIndex: 15028
{
	// Fields
	private int objId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3574D00 Offset: 0x3570D00 VA: 0x3574D00
	public void .ctor(int objId) { }

	// RVA: 0x3574D28 Offset: 0x3570D28 VA: 0x3574D28 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3574D30 Offset: 0x3570D30 VA: 0x3574D30 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3574D38 Offset: 0x3570D38 VA: 0x3574D38 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3574DA0 Offset: 0x3570DA0 VA: 0x3574DA0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3574DC4 Offset: 0x3570DC4 VA: 0x3574DC4
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OperationResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
