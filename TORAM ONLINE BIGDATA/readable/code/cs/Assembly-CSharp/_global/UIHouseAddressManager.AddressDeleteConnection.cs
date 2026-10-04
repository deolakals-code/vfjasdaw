// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIHouseAddressManager.AddressDeleteConnection : AddressDeleteExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7191
{
	// Fields
	private UIHouseAddressManager manager; // 0x10

	// Methods

	// RVA: 0x1AD42B4 Offset: 0x1AD02B4 VA: 0x1AD42B4
	public void .ctor(UIHouseAddressManager manager) { }

	// RVA: 0x1AD42E4 Offset: 0x1AD02E4 VA: 0x1AD42E4 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1AD439C Offset: 0x1AD039C VA: 0x1AD439C Slot: 14
	protected override void OnNoSetup() { }

	// RVA: 0x1AD43F0 Offset: 0x1AD03F0 VA: 0x1AD43F0 Slot: 13
	protected override void OnSqlError() { }

	// RVA: 0x1AD4444 Offset: 0x1AD0444 VA: 0x1AD4444 Slot: 10
	protected override void OnSuccess(AddressDeleteResponse response) { }

	// RVA: 0x1AD4498 Offset: 0x1AD0498 VA: 0x1AD4498 Slot: 12
	protected override void OnSystemLock() { }
}
