// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class PetRaceRetryExplain : OperationRelatedExplainBase // TypeDefIndex: 14990
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356ECCC Offset: 0x356ACCC VA: 0x356ECCC
	public void .ctor() { }

	// RVA: 0x356ECD4 Offset: 0x356ACD4 VA: 0x356ECD4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356ECDC Offset: 0x356ACDC VA: 0x356ECDC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356ECE4 Offset: 0x356ACE4 VA: 0x356ECE4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356ED38 Offset: 0x356AD38 VA: 0x356ED38 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356EDE8 Offset: 0x356ADE8 VA: 0x356EDE8
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, PetRaceRetryResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(PetRaceRetryResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnUnableJoin(short returnCode);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnWrongStateOrPhase(short returnCode);

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNotJoinedInTheCourse();
}
