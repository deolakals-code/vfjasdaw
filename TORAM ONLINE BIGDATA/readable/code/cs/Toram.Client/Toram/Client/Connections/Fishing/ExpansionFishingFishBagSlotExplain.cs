// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Fishing
[CLSCompliant(False)]
public abstract class ExpansionFishingFishBagSlotExplain : OperationRelatedExplainBase // TypeDefIndex: 15103
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357F940 Offset: 0x357B940 VA: 0x357F940
	public void .ctor() { }

	// RVA: 0x357F948 Offset: 0x357B948 VA: 0x357F948 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357F950 Offset: 0x357B950 VA: 0x357F950 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357F958 Offset: 0x357B958 VA: 0x357F958 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357FAB4 Offset: 0x357BAB4 VA: 0x357FAB4
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ExpansionFishingFishBagSlotResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ExpansionFishingFishBagSlotResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnBagCapacityOver();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnMoneyNotEnough();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnItemDoNotHave();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnFailure(short returnCode);
}
