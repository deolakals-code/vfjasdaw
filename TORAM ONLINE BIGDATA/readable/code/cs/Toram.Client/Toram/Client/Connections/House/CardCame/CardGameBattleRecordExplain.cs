// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.CardCame
[Obsolete("rm24855適応後削除予定")]
[CLSCompliant(False)]
public abstract class CardGameBattleRecordExplain : OperationRelatedExplainBase // TypeDefIndex: 14977
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356C390 Offset: 0x3568390 VA: 0x356C390
	public void .ctor() { }

	// RVA: 0x356C398 Offset: 0x3568398 VA: 0x356C398 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356C3A0 Offset: 0x35683A0 VA: 0x356C3A0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356C3A8 Offset: 0x35683A8 VA: 0x356C3A8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356C3FC Offset: 0x35683FC VA: 0x356C3FC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356C558 Offset: 0x3568558 VA: 0x356C558
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, CardGameBattleRecordResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(CardGameBattleRecordResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnMemberNotFound();
}
