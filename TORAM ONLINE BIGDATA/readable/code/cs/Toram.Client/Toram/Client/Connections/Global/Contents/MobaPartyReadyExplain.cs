// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaPartyReadyExplain : OperationRelatedExplainBase // TypeDefIndex: 15082
{
	// Fields
	private readonly byte partyGameId; // 0x10
	private readonly int appliId; // 0x14
	private readonly string appNumber; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357CD78 Offset: 0x3578D78 VA: 0x357CD78
	public void .ctor(byte partyGameId, int appliId, string appNumber) { }

	// RVA: 0x357CDC0 Offset: 0x3578DC0 VA: 0x357CDC0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357CDC8 Offset: 0x3578DC8 VA: 0x357CDC8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357CDD0 Offset: 0x3578DD0 VA: 0x357CDD0 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357CE50 Offset: 0x3578E50 VA: 0x357CE50 Slot: 9
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
	protected abstract void OnAlreadyReserved();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnAlreadyRunning();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void OnVersionDifference();
}
