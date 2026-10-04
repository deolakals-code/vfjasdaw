// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIFishingInventoryManager.ExpansionFishingFishBagSlot : ExpansionFishingFishBagSlotExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7046
{
	// Fields
	private Action callBack; // 0x10

	// Methods

	// RVA: 0x1A814E0 Offset: 0x1A7D4E0 VA: 0x1A814E0
	public void .ctor(Action callBack) { }

	// RVA: 0x1A81D6C Offset: 0x1A7DD6C VA: 0x1A81D6C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x1A81D74 Offset: 0x1A7DD74 VA: 0x1A81D74 Slot: 11
	protected override void OnBagCapacityOver() { }

	// RVA: 0x1A81DB8 Offset: 0x1A7DDB8 VA: 0x1A81DB8 Slot: 14
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1A81DFC Offset: 0x1A7DDFC VA: 0x1A81DFC Slot: 13
	protected override void OnItemDoNotHave() { }

	// RVA: 0x1A81E40 Offset: 0x1A7DE40 VA: 0x1A81E40 Slot: 12
	protected override void OnMoneyNotEnough() { }

	// RVA: 0x1A81E84 Offset: 0x1A7DE84 VA: 0x1A81E84 Slot: 10
	protected override void OnSuccess(ExpansionFishingFishBagSlotResponse response) { }
}
