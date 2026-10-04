// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.CraneGame
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class CraneGamePlayExplain : OperationRelatedExplainBase // TypeDefIndex: 15026
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3574960 Offset: 0x3570960 VA: 0x3574960
	public void .ctor() { }

	// RVA: 0x3574968 Offset: 0x3570968 VA: 0x3574968 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3574970 Offset: 0x3570970 VA: 0x3574970 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3574978 Offset: 0x3570978 VA: 0x3574978 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35749CC Offset: 0x35709CC VA: 0x35749CC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35749F0 Offset: 0x35709F0 VA: 0x35749F0
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OperationResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnAlreadyPlaying();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnPlayCountNotEnough();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
