// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[Obsolete("rm24855適応後削除予定")]
[CLSCompliant(False)]
public abstract class PetRaceEnterExplain : OperationRelatedExplainBase // TypeDefIndex: 15004
{
	// Fields
	private readonly int objId; // 0x10
	private readonly byte petRaceType; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3571220 Offset: 0x356D220 VA: 0x3571220
	public void .ctor(int objId, byte petRaceType) { }

	// RVA: 0x3571250 Offset: 0x356D250 VA: 0x3571250 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3571258 Offset: 0x356D258 VA: 0x3571258 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3571260 Offset: 0x356D260 VA: 0x3571260 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35712D0 Offset: 0x356D2D0 VA: 0x35712D0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35712F4 Offset: 0x356D2F4 VA: 0x35712F4
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OperationResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNotReadyEnter();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnUnableJoin();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNotParty();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnAlreadyStart();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnRaceMemberOver();
}
