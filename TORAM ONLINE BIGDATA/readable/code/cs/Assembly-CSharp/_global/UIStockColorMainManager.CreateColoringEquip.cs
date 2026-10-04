// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIStockColorMainManager.CreateColoringEquip : CreateColoringEquipExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6764
{
	// Fields
	private UIStockColorMainManager manager; // 0x20

	// Methods

	// RVA: 0x19F474C Offset: 0x19F074C VA: 0x19F474C
	public void .ctor(UIStockColorMainManager manager, short itemType, byte[] color) { }

	// RVA: 0x19F6768 Offset: 0x19F2768 VA: 0x19F6768 Slot: 11
	protected override void OnBagItemIsFull() { }

	// RVA: 0x19F6850 Offset: 0x19F2850 VA: 0x19F6850 Slot: 17
	protected override void OnColorNotEnough() { }

	// RVA: 0x19F6938 Offset: 0x19F2938 VA: 0x19F6938 Slot: 18
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x19F6A28 Offset: 0x19F2A28 VA: 0x19F6A28 Slot: 16
	protected override void OnItemDbNotFound() { }

	// RVA: 0x19F6B10 Offset: 0x19F2B10 VA: 0x19F6B10 Slot: 12
	protected override void OnItemTypeNotAllowed() { }

	// RVA: 0x19F6BF8 Offset: 0x19F2BF8 VA: 0x19F6BF8 Slot: 14
	protected override void OnNoColor() { }

	// RVA: 0x19F6CE0 Offset: 0x19F2CE0 VA: 0x19F6CE0 Slot: 13
	protected override void OnPaletteDataNull() { }

	// RVA: 0x19F6DC8 Offset: 0x19F2DC8 VA: 0x19F6DC8 Slot: 15
	protected override void OnSynthesizeEquipOver() { }

	// RVA: 0x19F6EB0 Offset: 0x19F2EB0 VA: 0x19F6EB0 Slot: 10
	protected override void OnSuccess(CreateColoringEquipResponse response) { }
}
