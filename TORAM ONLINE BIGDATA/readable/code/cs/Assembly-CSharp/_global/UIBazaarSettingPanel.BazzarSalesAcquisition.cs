// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIBazaarSettingPanel.BazzarSalesAcquisition : BazzarSalesAcquisitionExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8297
{
	// Fields
	private UIBazaarSettingPanel parent; // 0x18

	// Methods

	// RVA: 0x1D1C3D4 Offset: 0x1D183D4 VA: 0x1D1C3D4
	public void .ctor(UIBazaarSettingPanel panel, int gold) { }

	// RVA: 0x1D1C408 Offset: 0x1D18408 VA: 0x1D1C408 Slot: 15
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1D1C4C8 Offset: 0x1D184C8 VA: 0x1D1C4C8 Slot: 11
	protected override void OnNotAllowed() { }

	// RVA: 0x1D1C524 Offset: 0x1D18524 VA: 0x1D1C524 Slot: 12
	protected override void OnMoneyLimit() { }

	// RVA: 0x1D1C580 Offset: 0x1D18580 VA: 0x1D1C580 Slot: 14
	protected override void OnPutupSignboard() { }

	// RVA: 0x1D1C5DC Offset: 0x1D185DC VA: 0x1D1C5DC Slot: 13
	protected override void OnSalesNotEnough() { }

	// RVA: 0x1D1C638 Offset: 0x1D18638 VA: 0x1D1C638 Slot: 10
	protected override void OnSuccess(BazaarSalesAcquisitionResponse response) { }
}
