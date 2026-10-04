// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIHouseAddressManager.AddressGetMyAddressConnection : AddressGetMyAddressExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7188
{
	// Fields
	private UIHouseAddressManager manager; // 0x10

	// Methods

	// RVA: 0x1AD1668 Offset: 0x1ACD668 VA: 0x1AD1668
	public void .ctor(UIHouseAddressManager manager) { }

	// RVA: 0x1AD3630 Offset: 0x1ACF630 VA: 0x1AD3630 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1AD36F8 Offset: 0x1ACF6F8 VA: 0x1AD36F8 Slot: 13
	protected override void OnSqlError() { }

	// RVA: 0x1AD3760 Offset: 0x1ACF760 VA: 0x1AD3760 Slot: 10
	protected override void OnSuccess(AddressGetMyAddressResponse response) { }

	// RVA: 0x1AD37CC Offset: 0x1ACF7CC VA: 0x1AD37CC Slot: 12
	protected override void OnSystemLock() { }
}
