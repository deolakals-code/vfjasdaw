// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[Obsolete("rm24855適応後削除予定")]
[CLSCompliant(False)]
public abstract class PetRacePetSelectExplain : OperationRelatedExplainBase // TypeDefIndex: 15003
{
	// Fields
	private readonly long petUuid; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3570F70 Offset: 0x356CF70 VA: 0x3570F70
	public void .ctor(long petUuid) { }

	// RVA: 0x3570F98 Offset: 0x356CF98 VA: 0x3570F98 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3570FA0 Offset: 0x356CFA0 VA: 0x3570FA0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3570FA8 Offset: 0x356CFA8 VA: 0x3570FA8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3571010 Offset: 0x356D010 VA: 0x3571010 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3571034 Offset: 0x356D034 VA: 0x3571034
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

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnSelectFailed(short returnCode);
}
