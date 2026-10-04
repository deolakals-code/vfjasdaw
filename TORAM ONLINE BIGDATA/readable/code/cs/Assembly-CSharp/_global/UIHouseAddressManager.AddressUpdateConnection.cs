// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIHouseAddressManager.AddressUpdateConnection : AddressUpdateExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7190
{
	// Fields
	private UIHouseAddressManager manager; // 0x18

	// Methods

	// RVA: 0x1AD2640 Offset: 0x1ACE640 VA: 0x1AD2640
	public void .ctor(UIHouseAddressManager manager) { }

	// RVA: 0x1AD3E20 Offset: 0x1ACFE20 VA: 0x1AD3E20 Slot: 20
	protected override void OnAlreadyExists() { }

	// RVA: 0x1AD3ED8 Offset: 0x1ACFED8 VA: 0x1AD3ED8 Slot: 16
	protected override void OnConditionsAreNotMet() { }

	// RVA: 0x1AD3F2C Offset: 0x1ACFF2C VA: 0x1AD3F2C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1AD3FE4 Offset: 0x1ACFFE4 VA: 0x1AD3FE4 Slot: 19
	protected override void OnDoNotNeed() { }

	// RVA: 0x1AD404C Offset: 0x1AD004C VA: 0x1AD404C Slot: 18
	protected override void OnNotReadyToRun() { }

	// RVA: 0x1AD40A0 Offset: 0x1AD00A0 VA: 0x1AD40A0 Slot: 13
	protected override void OnNumberWrong() { }

	// RVA: 0x1AD40F4 Offset: 0x1AD00F4 VA: 0x1AD40F4 Slot: 17
	protected override void OnSqlError() { }

	// RVA: 0x1AD4148 Offset: 0x1AD0148 VA: 0x1AD4148 Slot: 10
	protected override void OnSuccess(AddressUpdateResponse response) { }

	// RVA: 0x1AD41B0 Offset: 0x1AD01B0 VA: 0x1AD41B0 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x1AD420C Offset: 0x1AD020C VA: 0x1AD420C Slot: 14
	protected override void OnNotFound() { }

	// RVA: 0x1AD4260 Offset: 0x1AD0260 VA: 0x1AD4260 Slot: 15
	protected override void OnNotAllowed() { }
}
