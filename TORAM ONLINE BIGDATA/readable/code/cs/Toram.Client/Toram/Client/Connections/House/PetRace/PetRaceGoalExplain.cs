// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class PetRaceGoalExplain : OperationRelatedExplainBase // TypeDefIndex: 14998
{
	// Fields
	private readonly string petName; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3570230 Offset: 0x356C230 VA: 0x3570230
	public void .ctor(string petName) { }

	// RVA: 0x3570260 Offset: 0x356C260 VA: 0x3570260 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3570268 Offset: 0x356C268 VA: 0x3570268 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3570270 Offset: 0x356C270 VA: 0x3570270 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35702E0 Offset: 0x356C2E0 VA: 0x35702E0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3570390 Offset: 0x356C390 VA: 0x3570390
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, PetRaceGoalResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(PetRaceGoalResponse response);

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
