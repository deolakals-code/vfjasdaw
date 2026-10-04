// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaPartyCancelExplain : OperationRelatedExplainBase // TypeDefIndex: 15080
{
	// Fields
	private readonly byte partyGameId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357CA50 Offset: 0x3578A50 VA: 0x357CA50
	public void .ctor(byte partyGameId) { }

	// RVA: 0x357CA78 Offset: 0x3578A78 VA: 0x357CA78 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357CA80 Offset: 0x3578A80 VA: 0x357CA80 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357CA88 Offset: 0x3578A88 VA: 0x357CA88 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357CAF0 Offset: 0x3578AF0 VA: 0x357CAF0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnConditionsAreNotMet();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnProfileNotRegistered();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnNoSetup();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNotBeHeld();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnMemberNotFound();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnAlreadyRunning();
}
