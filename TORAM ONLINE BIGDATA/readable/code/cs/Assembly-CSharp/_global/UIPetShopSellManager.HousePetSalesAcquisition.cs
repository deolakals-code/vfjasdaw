// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPetShopSellManager.HousePetSalesAcquisition : HousePetSalesAcquisitionExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7733
{
	// Fields
	private UIPetShopSellManager manager; // 0x18

	// Methods

	// RVA: 0x1BF939C Offset: 0x1BF539C VA: 0x1BF939C
	public void .ctor(UIPetShopSellManager manager, int sales) { }

	// RVA: 0x1BFAA14 Offset: 0x1BF6A14 VA: 0x1BFAA14 Slot: 15
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1BFAA18 Offset: 0x1BF6A18 VA: 0x1BFAA18 Slot: 13
	protected override void OnMoneyLimit() { }

	// RVA: 0x1BFAA1C Offset: 0x1BF6A1C VA: 0x1BFAA1C Slot: 11
	protected override void OnNotLoaded() { }

	// RVA: 0x1BFAA20 Offset: 0x1BF6A20 VA: 0x1BFAA20 Slot: 12
	protected override void OnNotStopSale() { }

	// RVA: 0x1BFAA38 Offset: 0x1BF6A38 VA: 0x1BFAA38 Slot: 14
	protected override void OnSalesNotEnough() { }

	// RVA: 0x1BFAA3C Offset: 0x1BF6A3C VA: 0x1BFAA3C Slot: 10
	protected override void OnSuccess(HousePetSalesAcquisitionResponse response) { }
}
