// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class PetRacePassingCheckPointExplain : OperationRelatedExplainBase // TypeDefIndex: 14993
{
	// Fields
	private readonly int checkPointNo; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356F624 Offset: 0x356B624 VA: 0x356F624
	public void .ctor(int checkPointNo) { }

	// RVA: 0x356F64C Offset: 0x356B64C VA: 0x356F64C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356F654 Offset: 0x356B654 VA: 0x356F654 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356F65C Offset: 0x356B65C VA: 0x356F65C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356F6C4 Offset: 0x356B6C4 VA: 0x356F6C4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356F788 Offset: 0x356B788 VA: 0x356F788
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, PetRacePassingCheckPointResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(PetRacePassingCheckPointResponse response);

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

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnWrongCheckPointData(short returnCode, byte nextCheckPoint);

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnPetInstanceNotExist(short returnCode);

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnFarFromCheckPoint(short returnCode);
}
