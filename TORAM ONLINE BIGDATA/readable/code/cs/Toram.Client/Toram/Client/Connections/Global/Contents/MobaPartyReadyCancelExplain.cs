// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaPartyReadyCancelExplain : OperationRelatedExplainBase // TypeDefIndex: 15081
{
	// Fields
	private readonly byte partyGameId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357CBD4 Offset: 0x3578BD4 VA: 0x357CBD4
	public void .ctor(byte partyGameId) { }

	// RVA: 0x357CBFC Offset: 0x3578BFC VA: 0x357CBFC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357CC04 Offset: 0x3578C04 VA: 0x357CC04 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357CC0C Offset: 0x3578C0C VA: 0x357CC0C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357CC74 Offset: 0x3578C74 VA: 0x357CC74 Slot: 9
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
}
