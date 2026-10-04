// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class PetRaceMovieEndExplain : OperationRelatedExplainBase // TypeDefIndex: 14999
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3570570 Offset: 0x356C570 VA: 0x3570570
	public void .ctor() { }

	// RVA: 0x3570578 Offset: 0x356C578 VA: 0x3570578 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3570580 Offset: 0x356C580 VA: 0x3570580 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3570588 Offset: 0x356C588 VA: 0x3570588 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3570590 Offset: 0x356C590 VA: 0x3570590 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35705B4 Offset: 0x356C5B4 VA: 0x35705B4
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
	protected abstract void OnNotJoinedInTheCourse();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnWrongStateOrPhase(short returnCode);
}
