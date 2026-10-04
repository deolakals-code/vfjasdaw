// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaPartySelectExplain : OperationRelatedExplainBase // TypeDefIndex: 15083
{
	// Fields
	private readonly byte gameId; // 0x10
	private readonly int appliId; // 0x14
	private readonly string appNumber; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357CF84 Offset: 0x3578F84 VA: 0x357CF84
	public void .ctor(byte gameId, int appliId, string appNumber) { }

	// RVA: 0x357CFCC Offset: 0x3578FCC VA: 0x357CFCC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357CFD4 Offset: 0x3578FD4 VA: 0x357CFD4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357CFDC Offset: 0x3578FDC VA: 0x357CFDC Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357D05C Offset: 0x357905C VA: 0x357D05C Slot: 9
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
	protected abstract void OnGameAlready();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnPartyMemberOver();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnVersionDifference();
}
