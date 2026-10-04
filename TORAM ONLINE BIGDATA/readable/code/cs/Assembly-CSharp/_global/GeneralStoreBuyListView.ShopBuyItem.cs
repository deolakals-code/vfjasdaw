// Assembly: Assembly-CSharp.dll
// Namespace: 
private class GeneralStoreBuyListView.ShopBuyItem : ShopBuyItemExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8323
{
	// Fields
	private GeneralStoreBuyListView manager; // 0x30

	// Methods

	// RVA: 0x1D209C0 Offset: 0x1D1C9C0 VA: 0x1D209C0
	public void .ctor(GeneralStoreBuyListView manager, int shopId, short[] position, int itemId, short itemNum, int gold) { }

	// RVA: 0x1D20A1C Offset: 0x1D1CA1C VA: 0x1D20A1C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1D20A20 Offset: 0x1D1CA20 VA: 0x1D20A20 Slot: 10
	protected override void OnSuccess(ShopBuyItemResponse response) { }
}
