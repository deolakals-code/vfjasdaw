// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.CraneGame
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class CraneGameLeaveExplain : OperationRelatedExplainBase // TypeDefIndex: 15027
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3574B58 Offset: 0x3570B58 VA: 0x3574B58
	public void .ctor() { }

	// RVA: 0x3574B60 Offset: 0x3570B60 VA: 0x3574B60 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3574B68 Offset: 0x3570B68 VA: 0x3574B68 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3574B70 Offset: 0x3570B70 VA: 0x3574B70 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3574BC4 Offset: 0x3570BC4 VA: 0x3574BC4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3574BE8 Offset: 0x3570BE8 VA: 0x3574BE8
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OperationResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
