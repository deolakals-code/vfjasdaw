// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIStoragePanelManager.StorageSearchItemMove : StorageSearchItemMoveExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8608
{
	// Fields
	private UIStoragePanelManager manager; // 0x20

	// Methods

	// RVA: 0x1DBE854 Offset: 0x1DBA854 VA: 0x1DBE854
	public void .ctor(UIStoragePanelManager manager, byte useType, short location, int itemId, byte beforeStorageNo, byte afterStorageNo) { }

	// RVA: 0x1DBE89C Offset: 0x1DBA89C VA: 0x1DBE89C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1DBE8A0 Offset: 0x1DBA8A0 VA: 0x1DBE8A0 Slot: 12
	protected override void OnStorageItemFull(short returnCode) { }

	// RVA: 0x1DBE8A4 Offset: 0x1DBA8A4 VA: 0x1DBE8A4 Slot: 10
	protected override void OnSuccess(StorageSearchItemMoveResponse response) { }
}
