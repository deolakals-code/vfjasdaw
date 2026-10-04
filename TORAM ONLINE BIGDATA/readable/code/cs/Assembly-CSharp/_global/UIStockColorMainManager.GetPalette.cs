// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIStockColorMainManager.GetPalette : GetPaletteExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6762
{
	// Fields
	private UIStockColorMainManager manager; // 0x10

	// Methods

	// RVA: 0x19F4570 Offset: 0x19F0570 VA: 0x19F4570
	public void .ctor(UIStockColorMainManager manager) { }

	// RVA: 0x19F4C5C Offset: 0x19F0C5C VA: 0x19F4C5C Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x19F4D4C Offset: 0x19F0D4C VA: 0x19F4D4C Slot: 11
	protected override void OnItemTypeNotAllowed() { }

	// RVA: 0x19F4E34 Offset: 0x19F0E34 VA: 0x19F4E34 Slot: 12
	protected override void OnPaletteDataNull() { }

	// RVA: 0x19F4F1C Offset: 0x19F0F1C VA: 0x19F4F1C Slot: 10
	protected override void OnSuccess(GetPaletteResponse response) { }
}
