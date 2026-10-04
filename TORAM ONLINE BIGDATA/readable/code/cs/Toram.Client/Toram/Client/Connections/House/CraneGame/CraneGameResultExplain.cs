// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.CraneGame
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class CraneGameResultExplain : OperationRelatedExplainBase // TypeDefIndex: 15025
{
	// Fields
	private bool isGet; // 0x10
	private int score; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357474C Offset: 0x357074C VA: 0x357474C
	public void .ctor(bool isGet, int score) { }

	// RVA: 0x357477C Offset: 0x357077C VA: 0x357477C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3574784 Offset: 0x3570784 VA: 0x3574784 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357478C Offset: 0x357078C VA: 0x357478C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35747FC Offset: 0x35707FC VA: 0x35747FC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3574820 Offset: 0x3570820 VA: 0x3574820
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OperationResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotPlay();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
