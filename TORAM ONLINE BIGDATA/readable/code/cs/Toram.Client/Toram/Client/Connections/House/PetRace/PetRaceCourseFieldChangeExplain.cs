// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[Obsolete("rm24855適応後削除予定")]
[CLSCompliant(False)]
public abstract class PetRaceCourseFieldChangeExplain : OperationRelatedExplainBase // TypeDefIndex: 14988
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356E744 Offset: 0x356A744 VA: 0x356E744
	public void .ctor() { }

	// RVA: 0x356E74C Offset: 0x356A74C VA: 0x356E74C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356E754 Offset: 0x356A754 VA: 0x356E754 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356E75C Offset: 0x356A75C VA: 0x356E75C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356E764 Offset: 0x356A764 VA: 0x356E764 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356E788 Offset: 0x356A788 VA: 0x356E788
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
