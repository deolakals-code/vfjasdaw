// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIBazaarSettingPanel.CancelExhibitBazaar : CancelExhibitBazaarExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8296
{
	// Fields
	private UIBazaarSettingPanel parent; // 0x18
	private Action callback; // 0x20

	// Methods

	// RVA: 0x1D19074 Offset: 0x1D15074 VA: 0x1D19074
	public void .ctor(UIBazaarSettingPanel panel, byte slotIndex, Action callback) { }

	// RVA: 0x1D1C0C4 Offset: 0x1D180C4 VA: 0x1D1C0C4 Slot: 13
	protected override void OnBagItemIsFull() { }

	// RVA: 0x1D1C16C Offset: 0x1D1816C VA: 0x1D1C16C Slot: 15
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1D1C228 Offset: 0x1D18228 VA: 0x1D1C228 Slot: 11
	protected override void OnNotAllowed() { }

	// RVA: 0x1D1C280 Offset: 0x1D18280 VA: 0x1D1C280 Slot: 12
	protected override void OnNotFound() { }

	// RVA: 0x1D1C2D8 Offset: 0x1D182D8 VA: 0x1D1C2D8 Slot: 14
	protected override void OnPutupSignboard() { }

	// RVA: 0x1D1C330 Offset: 0x1D18330 VA: 0x1D1C330 Slot: 10
	protected override void OnSuccess(CancelExhibitBazaarResponse response) { }
}
