// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIBazaarSettingPanel.ExpansionBazaarSlot : ExpansionBazaarSlotExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8298
{
	// Fields
	private UIBazaarSettingPanel parent; // 0x10

	// Methods

	// RVA: 0x1D1C6B4 Offset: 0x1D186B4 VA: 0x1D1C6B4
	public void .ctor(UIBazaarSettingPanel panel) { }

	// RVA: 0x1D1C6E4 Offset: 0x1D186E4 VA: 0x1D1C6E4 Slot: 12
	protected override void OnBazaarSlotLimit() { }

	// RVA: 0x1D1C740 Offset: 0x1D18740 VA: 0x1D1C740 Slot: 15
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1D1C800 Offset: 0x1D18800 VA: 0x1D1C800 Slot: 11
	protected override void OnNotAllowed() { }

	// RVA: 0x1D1C85C Offset: 0x1D1885C VA: 0x1D1C85C Slot: 13
	protected override void OnMoneyNotEnough() { }

	// RVA: 0x1D1C8B8 Offset: 0x1D188B8 VA: 0x1D1C8B8 Slot: 14
	protected override void OnPutupSignboard() { }

	// RVA: 0x1D1C914 Offset: 0x1D18914 VA: 0x1D1C914 Slot: 10
	protected override void OnSuccess(ExpansionBazaarSlotResponse response) { }
}
