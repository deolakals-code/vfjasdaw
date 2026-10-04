// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class PetRaceGetItemExplain : OperationRelatedExplainBase // TypeDefIndex: 14989
{
	// Fields
	private readonly byte getItemNo; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356E958 Offset: 0x356A958 VA: 0x356E958
	public void .ctor(byte getItemNo) { }

	// RVA: 0x356E980 Offset: 0x356A980 VA: 0x356E980 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356E988 Offset: 0x356A988 VA: 0x356E988 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356E990 Offset: 0x356A990 VA: 0x356E990 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356E9F8 Offset: 0x356A9F8 VA: 0x356E9F8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356EABC Offset: 0x356AABC VA: 0x356EABC
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, PetRaceGetItemResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(PetRaceGetItemResponse response);

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

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnAlreadyGetItem(PetRaceGetItemResponse response);
}
