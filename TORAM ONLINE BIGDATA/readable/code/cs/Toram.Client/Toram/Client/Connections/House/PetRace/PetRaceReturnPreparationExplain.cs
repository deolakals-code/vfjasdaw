// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class PetRaceReturnPreparationExplain : OperationRelatedExplainBase // TypeDefIndex: 14996
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356FE08 Offset: 0x356BE08 VA: 0x356FE08
	public void .ctor() { }

	// RVA: 0x356FE10 Offset: 0x356BE10 VA: 0x356FE10 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356FE18 Offset: 0x356BE18 VA: 0x356FE18 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356FE20 Offset: 0x356BE20 VA: 0x356FE20 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356FE28 Offset: 0x356BE28 VA: 0x356FE28 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356FE4C Offset: 0x356BE4C VA: 0x356FE4C
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
