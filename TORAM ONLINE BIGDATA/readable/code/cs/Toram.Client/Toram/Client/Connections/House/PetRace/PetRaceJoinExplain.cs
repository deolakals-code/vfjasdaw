// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[Obsolete("rm24855適応後削除予定")]
[CLSCompliant(False)]
public abstract class PetRaceJoinExplain : OperationRelatedExplainBase // TypeDefIndex: 15001
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35709A8 Offset: 0x356C9A8 VA: 0x35709A8
	public void .ctor() { }

	// RVA: 0x35709B0 Offset: 0x356C9B0 VA: 0x35709B0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35709B8 Offset: 0x356C9B8 VA: 0x35709B8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35709C0 Offset: 0x356C9C0 VA: 0x35709C0 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35709C8 Offset: 0x356C9C8 VA: 0x35709C8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3570A80 Offset: 0x356CA80 VA: 0x3570A80
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, byte phase, Dictionary<byte, object> parameters) { }

	// RVA: 0x3570C5C Offset: 0x356CC5C VA: 0x3570C5C
	private GameReturnCode OnSuccess(Game engine, byte phase, Dictionary<byte, object> parameters) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccessPreparation(PetRaceJoinSettingPhaseResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSuccessPlay(PetRaceJoinPlayPhaseResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSuccessResult(PetRaceJoinResultPhaseResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnSqlError();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnUnableJoin(short returnCode);
}
