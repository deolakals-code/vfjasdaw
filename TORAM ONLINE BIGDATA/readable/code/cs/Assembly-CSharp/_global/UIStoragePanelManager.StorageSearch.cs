// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIStoragePanelManager.StorageSearch : StorageSearchExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8604
{
	// Fields
	private UIStoragePanelManager manager; // 0x28

	// Methods

	// RVA: 0x1DBE270 Offset: 0x1DBA270 VA: 0x1DBE270
	public void .ctor(UIStoragePanelManager manager, byte type, byte slot, byte parts, byte color, int modelId, byte useType) { }

	// RVA: 0x1DBE2B8 Offset: 0x1DBA2B8 VA: 0x1DBE2B8
	public void .ctor(UIStoragePanelManager manager, int id, byte slot, byte parts, byte color, int modelId, byte useType) { }

	// RVA: 0x1DBE300 Offset: 0x1DBA300 VA: 0x1DBE300 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1DBE360 Offset: 0x1DBA360 VA: 0x1DBE360 Slot: 12
	protected override void OnWrong(short returnCode) { }

	// RVA: 0x1DBE3C0 Offset: 0x1DBA3C0 VA: 0x1DBE3C0 Slot: 10
	protected override void OnSuccess(StorageSearchResponse response) { }
}
