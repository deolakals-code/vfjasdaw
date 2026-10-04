// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[Obsolete("rm24855適応後削除予定")]
[CLSCompliant(False)]
public abstract class PetRaceReadyExplain : OperationRelatedExplainBase // TypeDefIndex: 14995
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356FBF4 Offset: 0x356BBF4 VA: 0x356FBF4
	public void .ctor() { }

	// RVA: 0x356FBFC Offset: 0x356BBFC VA: 0x356FBFC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356FC04 Offset: 0x356BC04 VA: 0x356FC04 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356FC0C Offset: 0x356BC0C VA: 0x356FC0C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356FC14 Offset: 0x356BC14 VA: 0x356FC14 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356FC38 Offset: 0x356BC38 VA: 0x356FC38
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
