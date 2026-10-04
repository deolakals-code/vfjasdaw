// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Fishing
[CLSCompliant(False)]
public abstract class StartFishingExplain : OperationRelatedExplainBase // TypeDefIndex: 15102
{
	// Fields
	private int fieldId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357F6B0 Offset: 0x357B6B0 VA: 0x357F6B0
	public void .ctor(int fieldId) { }

	// RVA: 0x357F6D8 Offset: 0x357B6D8 VA: 0x357F6D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357F6E0 Offset: 0x357B6E0 VA: 0x357F6E0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357F6E8 Offset: 0x357B6E8 VA: 0x357F6E8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357F750 Offset: 0x357B750 VA: 0x357F750 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357F768 Offset: 0x357B768 VA: 0x357F768
	private GameReturnCode ReceiveResponse(Game engine, short returnCode) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnAlreadyFishing();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnBagIsFull();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnRodNotFound();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnFishingRodCanNotUse();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnNotGetTarget();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnBagNotFreeLocation();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnFailure(short returnCode);
}
