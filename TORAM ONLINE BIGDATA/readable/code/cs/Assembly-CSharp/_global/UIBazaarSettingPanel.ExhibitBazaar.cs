// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIBazaarSettingPanel.ExhibitBazaar : ExhibitBazaarExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8295
{
	// Fields
	private UIBazaarSettingPanel parent; // 0x28

	// Methods

	// RVA: 0x1D19038 Offset: 0x1D15038 VA: 0x1D19038
	public void .ctor(UIBazaarSettingPanel panel, byte slotIndex, ItemSelectData selectItem, int price) { }

	// RVA: 0x1D1BD04 Offset: 0x1D17D04 VA: 0x1D1BD04 Slot: 14
	protected override void OnAlreadyExists() { }

	// RVA: 0x1D1BD5C Offset: 0x1D17D5C VA: 0x1D1BD5C Slot: 18
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1D1BE18 Offset: 0x1D17E18 VA: 0x1D1BE18 Slot: 11
	protected override void OnNotAllowed() { }

	// RVA: 0x1D1BE70 Offset: 0x1D17E70 VA: 0x1D1BE70 Slot: 15
	protected override void OnItemNotFound() { }

	// RVA: 0x1D1BEC8 Offset: 0x1D17EC8 VA: 0x1D1BEC8 Slot: 13
	protected override void OnPriceOutOfRange() { }

	// RVA: 0x1D1BF20 Offset: 0x1D17F20 VA: 0x1D1BF20 Slot: 12
	protected override void OnSlotIndexOutOfRange() { }

	// RVA: 0x1D1BF78 Offset: 0x1D17F78 VA: 0x1D1BF78 Slot: 10
	protected override void OnSuccess(ExhibitBazaarResponse response) { }

	// RVA: 0x1D1C068 Offset: 0x1D18068 VA: 0x1D1C068 Slot: 16
	protected override void OnBazaarItemNotFound() { }

	// RVA: 0x1D1C0C0 Offset: 0x1D180C0 VA: 0x1D1C0C0 Slot: 17
	protected override void OnNoChangePrice() { }
}
