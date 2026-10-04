// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class PetRaceGiveupExplain : OperationRelatedExplainBase // TypeDefIndex: 14997
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3570030 Offset: 0x356C030 VA: 0x3570030
	public void .ctor() { }

	// RVA: 0x3570038 Offset: 0x356C038 VA: 0x3570038 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3570040 Offset: 0x356C040 VA: 0x3570040 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3570048 Offset: 0x356C048 VA: 0x3570048 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3570050 Offset: 0x356C050 VA: 0x3570050 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3570074 Offset: 0x356C074 VA: 0x3570074
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OperationResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnUnableJoin(short returnCode);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNotJoinedInTheCourse();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnWrongStateOrPhase(short returnCode);
}
