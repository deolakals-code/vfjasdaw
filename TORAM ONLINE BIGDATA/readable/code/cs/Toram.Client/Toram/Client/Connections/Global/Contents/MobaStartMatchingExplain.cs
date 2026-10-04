// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaStartMatchingExplain : OperationRelatedExplainBase // TypeDefIndex: 15092
{
	// Fields
	private readonly byte gameId; // 0x10
	private readonly int appliId; // 0x14
	private readonly string appNumber; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357DCEC Offset: 0x3579CEC VA: 0x357DCEC
	public void .ctor(byte gameId, int appliId, string appNumber) { }

	// RVA: 0x357DD34 Offset: 0x3579D34 VA: 0x357DD34 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357DD3C Offset: 0x3579D3C VA: 0x357DD3C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357DD44 Offset: 0x3579D44 VA: 0x357DD44 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357DDC4 Offset: 0x3579DC4 VA: 0x357DDC4 Slot: 9
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
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnVersionDifference();
}
