// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class PetRaceRecruitEndExplain : OperationRelatedExplainBase // TypeDefIndex: 15000
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3570794 Offset: 0x356C794 VA: 0x3570794
	public void .ctor() { }

	// RVA: 0x357079C Offset: 0x356C79C VA: 0x357079C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35707A4 Offset: 0x356C7A4 VA: 0x35707A4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35707AC Offset: 0x356C7AC VA: 0x35707AC Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35707B4 Offset: 0x356C7B4 VA: 0x35707B4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35707D8 Offset: 0x356C7D8 VA: 0x35707D8
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OperationResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnUnableJoin(short returnCode);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnWrongStateOrPhase(short returnCode);
}
