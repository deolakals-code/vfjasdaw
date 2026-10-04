// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIStockColorMainManager.StockColor : StockColorExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6763
{
	// Fields
	private UIStockColorMainManager manager; // 0x18

	// Methods

	// RVA: 0x19F4718 Offset: 0x19F0718 VA: 0x19F4718
	public void .ctor(UIStockColorMainManager manager, int[] itemUuids) { }

	// RVA: 0x19F5048 Offset: 0x19F1048 VA: 0x19F5048 Slot: 16
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x19F5138 Offset: 0x19F1138 VA: 0x19F5138 Slot: 13
	protected override void OnItemHasNoColor() { }

	// RVA: 0x19F5220 Offset: 0x19F1220 VA: 0x19F5220 Slot: 11
	protected override void OnItemNotFound() { }

	// RVA: 0x19F5308 Offset: 0x19F1308 VA: 0x19F5308 Slot: 12
	protected override void OnItemTypeNotAllowed() { }

	// RVA: 0x19F53F0 Offset: 0x19F13F0 VA: 0x19F53F0 Slot: 15
	protected override void OnMaxColorStock() { }

	// RVA: 0x19F5490 Offset: 0x19F1490 VA: 0x19F5490 Slot: 14
	protected override void OnPaletteDataNull() { }

	// RVA: 0x19F5578 Offset: 0x19F1578 VA: 0x19F5578 Slot: 10
	protected override void OnSuccess(StockColorResponse response) { }
}
