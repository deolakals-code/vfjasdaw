// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class PetRaceReadyCancelExplain : OperationRelatedExplainBase // TypeDefIndex: 14994
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356F9E0 Offset: 0x356B9E0 VA: 0x356F9E0
	public void .ctor() { }

	// RVA: 0x356F9E8 Offset: 0x356B9E8 VA: 0x356F9E8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356F9F0 Offset: 0x356B9F0 VA: 0x356F9F0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356F9F8 Offset: 0x356B9F8 VA: 0x356F9F8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356FA00 Offset: 0x356BA00 VA: 0x356FA00 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356FA24 Offset: 0x356BA24 VA: 0x356FA24
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
