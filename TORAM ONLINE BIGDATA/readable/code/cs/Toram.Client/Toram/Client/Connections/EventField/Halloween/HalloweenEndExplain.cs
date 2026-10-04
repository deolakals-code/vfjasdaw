// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.EventField.Halloween
[CLSCompliant(False)]
public abstract class HalloweenEndExplain : OperationRelatedExplainBase // TypeDefIndex: 15107
{
	// Fields
	private readonly bool redKeyUsed; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35806CC Offset: 0x357C6CC VA: 0x35806CC
	public void .ctor(bool redKeyUsed) { }

	// RVA: 0x35806F4 Offset: 0x357C6F4 VA: 0x35806F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35806FC Offset: 0x357C6FC VA: 0x35806FC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3580704 Offset: 0x357C704 VA: 0x3580704 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x358076C Offset: 0x357C76C VA: 0x358076C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3580838 Offset: 0x357C838 VA: 0x3580838
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, HalloweenEndResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(HalloweenEndResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnGameEventNotHeld();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnNotStart();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnAlreadyReceived(HalloweenEndResponse response);

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnDistanceError();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnKeyNothing(HalloweenEndResponse response);
}
