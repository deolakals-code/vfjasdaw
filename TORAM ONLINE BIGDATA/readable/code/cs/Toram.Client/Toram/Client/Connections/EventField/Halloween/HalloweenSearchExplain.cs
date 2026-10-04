// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.EventField.Halloween
[CLSCompliant(False)]
public abstract class HalloweenSearchExplain : OperationRelatedExplainBase // TypeDefIndex: 15106
{
	// Fields
	private readonly byte floorNo; // 0x10
	private readonly byte pointNo; // 0x11

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3580348 Offset: 0x357C348 VA: 0x3580348
	public void .ctor(byte floorNo, byte pointNo) { }

	// RVA: 0x3580378 Offset: 0x357C378 VA: 0x3580378 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3580380 Offset: 0x357C380 VA: 0x3580380 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3580388 Offset: 0x357C388 VA: 0x3580388 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35803F8 Offset: 0x357C3F8 VA: 0x35803F8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35804BC Offset: 0x357C4BC VA: 0x35804BC
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, HalloweenSearchResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(HalloweenSearchResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnGameEventNotHeld();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnNotStart();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnPointDataDiff();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnAlreadySearched(HalloweenSearchResponse response);

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnDistanceError();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnNoReward();
}
