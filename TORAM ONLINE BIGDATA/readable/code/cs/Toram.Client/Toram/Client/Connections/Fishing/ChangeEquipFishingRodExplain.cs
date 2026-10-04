// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Fishing
[CLSCompliant(False)]
public abstract class ChangeEquipFishingRodExplain : OperationRelatedExplainBase // TypeDefIndex: 15096
{
	// Fields
	private byte index; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357E52C Offset: 0x357A52C VA: 0x357E52C
	public void .ctor(byte index) { }

	// RVA: 0x357E554 Offset: 0x357A554 VA: 0x357E554 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357E55C Offset: 0x357A55C VA: 0x357E55C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357E564 Offset: 0x357A564 VA: 0x357E564 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357E5CC Offset: 0x357A5CC VA: 0x357E5CC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357E728 Offset: 0x357A728 VA: 0x357E728
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ChangeEquipFishingRodResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ChangeEquipFishingRodResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnIndexOutOfRange();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNoChange();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnRodNotFound();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnFishingRodCanNotUse();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode);
}
