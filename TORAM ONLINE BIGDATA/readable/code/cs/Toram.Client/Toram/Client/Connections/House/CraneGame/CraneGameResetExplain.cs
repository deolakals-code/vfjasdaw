// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.CraneGame
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class CraneGameResetExplain : OperationRelatedExplainBase // TypeDefIndex: 15024
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35745D0 Offset: 0x35705D0 VA: 0x35745D0
	public void .ctor() { }

	// RVA: 0x35745D8 Offset: 0x35705D8 VA: 0x35745D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35745E0 Offset: 0x35705E0 VA: 0x35745E0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35745E8 Offset: 0x35705E8 VA: 0x35745E8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357460C Offset: 0x357060C VA: 0x357460C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OperationResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnAlreadyPlaying();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
