// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIStoragePanelManager.StorageSearchPickup : StorageSearchPickupExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8606
{
	// Fields
	private UIStoragePanelManager manager; // 0x20

	// Methods

	// RVA: 0x1DBE434 Offset: 0x1DBA434 VA: 0x1DBE434
	public void .ctor(UIStoragePanelManager manager, byte useType, int location, int itemId) { }

	// RVA: 0x1DBE470 Offset: 0x1DBA470 VA: 0x1DBE470
	public void .ctor(UIStoragePanelManager manager, byte useType, int location, int itemId, short num) { }

	// RVA: 0x1DBE4B0 Offset: 0x1DBA4B0 VA: 0x1DBE4B0 Slot: 13
	protected override void OnBagItemFull(short returnCode) { }

	// RVA: 0x1DBE510 Offset: 0x1DBA510 VA: 0x1DBE510 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1DBE570 Offset: 0x1DBA570 VA: 0x1DBE570 Slot: 12
	protected override void OnItemNotFound(short returnCode) { }

	// RVA: 0x1DBE5D0 Offset: 0x1DBA5D0 VA: 0x1DBE5D0 Slot: 10
	protected override void OnSuccess(StorageSearchPickupResponse response) { }
}
