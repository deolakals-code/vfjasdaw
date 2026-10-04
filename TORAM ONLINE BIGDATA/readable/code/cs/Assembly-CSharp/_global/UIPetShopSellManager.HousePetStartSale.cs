// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPetShopSellManager.HousePetStartSale : HousePetStartSaleExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7730
{
	// Fields
	private UIPetShopSellManager manager; // 0x10

	// Methods

	// RVA: 0x1BF948C Offset: 0x1BF548C VA: 0x1BF948C
	public void .ctor(UIPetShopSellManager manager) { }

	// RVA: 0x1BFA7B0 Offset: 0x1BF67B0 VA: 0x1BFA7B0 Slot: 12
	protected override void OnAlreadySale() { }

	// RVA: 0x1BFA7B4 Offset: 0x1BF67B4 VA: 0x1BFA7B4 Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1BFA7B8 Offset: 0x1BF67B8 VA: 0x1BFA7B8 Slot: 11
	protected override void OnNotLoaded() { }

	// RVA: 0x1BFA7BC Offset: 0x1BF67BC VA: 0x1BFA7BC Slot: 10
	protected override void OnSuccess(HousePetStartSaleResponse response) { }
}
