// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.EventField.Halloween
[CLSCompliant(False)]
public abstract class HalloweenStartExplain : OperationRelatedExplainBase // TypeDefIndex: 15108
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3580A34 Offset: 0x357CA34 VA: 0x3580A34
	public void .ctor() { }

	// RVA: 0x3580A3C Offset: 0x357CA3C VA: 0x3580A3C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3580A44 Offset: 0x357CA44 VA: 0x3580A44 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3580A4C Offset: 0x357CA4C VA: 0x3580A4C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3580AA0 Offset: 0x357CAA0 VA: 0x3580AA0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3580B50 Offset: 0x357CB50 VA: 0x3580B50
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, HalloweenStartResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(HalloweenStartResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnGameEventNotHeld();
}
