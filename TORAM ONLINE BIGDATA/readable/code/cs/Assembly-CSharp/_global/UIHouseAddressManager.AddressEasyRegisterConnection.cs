// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIHouseAddressManager.AddressEasyRegisterConnection : AddressEasyRegisterExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7189
{
	// Fields
	private UIHouseAddressManager manager; // 0x18
	private byte townCode; // 0x20

	// Methods

	// RVA: 0x1AD26A0 Offset: 0x1ACE6A0 VA: 0x1AD26A0
	public void .ctor(UIHouseAddressManager manager, byte code) { }

	// RVA: 0x1AD3828 Offset: 0x1ACF828 VA: 0x1AD3828 Slot: 24
	protected override void OnAlreadyExists() { }

	// RVA: 0x1AD387C Offset: 0x1ACF87C VA: 0x1AD387C Slot: 16
	protected override void OnConditionsAreNotMet() { }

	// RVA: 0x1AD38D0 Offset: 0x1ACF8D0 VA: 0x1AD38D0 Slot: 22
	protected override void OnDataNull() { }

	// RVA: 0x1AD3924 Offset: 0x1ACF924 VA: 0x1AD3924 Slot: 19
	protected override void OnDoNotNeed() { }

	// RVA: 0x1AD3978 Offset: 0x1ACF978 VA: 0x1AD3978 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1AD3A30 Offset: 0x1ACFA30 VA: 0x1AD3A30 Slot: 23
	protected override void OnFloorNotFound() { }

	// RVA: 0x1AD3ACC Offset: 0x1ACFACC VA: 0x1AD3ACC Slot: 15
	protected override void OnNotAllowed() { }

	// RVA: 0x1AD3B20 Offset: 0x1ACFB20 VA: 0x1AD3B20 Slot: 14
	protected override void OnNotFound() { }

	// RVA: 0x1AD3B74 Offset: 0x1ACFB74 VA: 0x1AD3B74 Slot: 20
	protected override void OnNotReadyToRun() { }

	// RVA: 0x1AD3BC8 Offset: 0x1ACFBC8 VA: 0x1AD3BC8 Slot: 17
	protected override void OnNumberWrong() { }

	// RVA: 0x1AD3C64 Offset: 0x1ACFC64 VA: 0x1AD3C64 Slot: 13
	protected override void OnServerDisconnect() { }

	// RVA: 0x1AD3CB8 Offset: 0x1ACFCB8 VA: 0x1AD3CB8 Slot: 18
	protected override void OnSqlError() { }

	// RVA: 0x1AD3D0C Offset: 0x1ACFD0C VA: 0x1AD3D0C Slot: 10
	protected override void OnSuccess(AddressEasyRegisterResponse response) { }

	// RVA: 0x1AD3D70 Offset: 0x1ACFD70 VA: 0x1AD3D70 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x1AD3DCC Offset: 0x1ACFDCC VA: 0x1AD3DCC Slot: 21
	protected override void OnUserNotFound() { }
}
