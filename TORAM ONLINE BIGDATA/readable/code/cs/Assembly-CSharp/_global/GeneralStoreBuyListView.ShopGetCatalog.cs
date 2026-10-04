// Assembly: Assembly-CSharp.dll
// Namespace: 
private class GeneralStoreBuyListView.ShopGetCatalog : ShopGetCatalogExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8322
{
	// Fields
	private GeneralStoreBuyListView manager; // 0x20

	// Methods

	// RVA: 0x1D20950 Offset: 0x1D1C950 VA: 0x1D20950
	public void .ctor(GeneralStoreBuyListView manager, int shopId, short[] position) { }

	// RVA: 0x1D209A0 Offset: 0x1D1C9A0 VA: 0x1D209A0 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1D209A4 Offset: 0x1D1C9A4 VA: 0x1D209A4 Slot: 10
	protected override void OnSuccess(ShopGetCatalogResponse response) { }
}
