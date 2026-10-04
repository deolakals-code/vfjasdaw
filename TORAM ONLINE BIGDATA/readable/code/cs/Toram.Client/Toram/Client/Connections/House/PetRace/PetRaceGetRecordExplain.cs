// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class PetRaceGetRecordExplain : OperationRelatedExplainBase // TypeDefIndex: 14991
{
	// Fields
	private readonly int courseId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356EFC8 Offset: 0x356AFC8 VA: 0x356EFC8
	public void .ctor(int courseId) { }

	// RVA: 0x356EFF0 Offset: 0x356AFF0 VA: 0x356EFF0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356EFF8 Offset: 0x356AFF8 VA: 0x356EFF8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356F000 Offset: 0x356B000 VA: 0x356F000 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356F068 Offset: 0x356B068 VA: 0x356F068 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356F118 Offset: 0x356B118 VA: 0x356F118
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, PetRaceGetRecordResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(PetRaceGetRecordResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnUnableJoin(short returnCode);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnWrongStateOrPhase(short returnCode);
}
