// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIHouseAddressManager.AddressSearchConnection : AddressSearchExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7192
{
	// Fields
	private UIHouseAddressManager manager; // 0x18

	// Methods

	// RVA: 0x1AD26E0 Offset: 0x1ACE6E0 VA: 0x1AD26E0
	public void .ctor(UIHouseAddressManager manager) { }

	// RVA: 0x1AD44F4 Offset: 0x1AD04F4 VA: 0x1AD44F4 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1AD4548 Offset: 0x1AD0548 VA: 0x1AD4548 Slot: 15
	protected override void OnNotFound() { }

	// RVA: 0x1AD459C Offset: 0x1AD059C VA: 0x1AD459C Slot: 13
	protected override void OnNumberWrong() { }

	// RVA: 0x1AD45F0 Offset: 0x1AD05F0 VA: 0x1AD45F0 Slot: 14
	protected override void OnSqlError() { }

	// RVA: 0x1AD4644 Offset: 0x1AD0644 VA: 0x1AD4644 Slot: 10
	protected override void OnSuccess(AddressSearchResponse response) { }

	// RVA: 0x1AD4664 Offset: 0x1AD0664 VA: 0x1AD4664 Slot: 12
	protected override void OnSystemLock() { }
}
