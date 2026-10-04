// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaCancelMatchingExplain : OperationRelatedExplainBase // TypeDefIndex: 15063
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357B4A0 Offset: 0x35774A0 VA: 0x357B4A0
	public void .ctor() { }

	// RVA: 0x357B4A8 Offset: 0x35774A8 VA: 0x357B4A8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357B4B0 Offset: 0x35774B0 VA: 0x357B4B0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357B4B8 Offset: 0x35774B8 VA: 0x357B4B8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357B4C0 Offset: 0x35774C0 VA: 0x357B4C0 Slot: 9
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
	protected abstract void OnReserveNotFound();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnNotFound();
}
