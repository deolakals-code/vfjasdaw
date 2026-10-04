// Assembly: Assembly-CSharp.dll
// Namespace: 
private class GeneralStoreItemListManager.ShopSellItem : ShopSellItemExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8332
{
	// Fields
	private GeneralStoreItemListManager manager; // 0x28

	// Methods

	// RVA: 0x1D27744 Offset: 0x1D23744 VA: 0x1D27744
	public void .ctor(GeneralStoreItemListManager manager, int shopId, short[] position, ItemSelectData[] selectItem) { }

	// RVA: 0x1D27780 Offset: 0x1D23780 VA: 0x1D27780 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1D27784 Offset: 0x1D23784 VA: 0x1D27784 Slot: 10
	protected override void OnSuccess(ShopSellItemResponse response) { }
}
