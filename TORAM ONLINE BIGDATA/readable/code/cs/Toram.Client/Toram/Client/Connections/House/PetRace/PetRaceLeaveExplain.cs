// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class PetRaceLeaveExplain : OperationRelatedExplainBase // TypeDefIndex: 15002
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3570DC8 Offset: 0x356CDC8 VA: 0x3570DC8
	public void .ctor() { }

	// RVA: 0x3570DD0 Offset: 0x356CDD0 VA: 0x3570DD0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3570DD8 Offset: 0x356CDD8 VA: 0x3570DD8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3570DE0 Offset: 0x356CDE0 VA: 0x3570DE0 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3570DE8 Offset: 0x356CDE8 VA: 0x3570DE8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3570E0C Offset: 0x356CE0C VA: 0x3570E0C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OperationResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnWrongState(short returnCode);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnGroupMemberStateWrong(short returnCode);
}
