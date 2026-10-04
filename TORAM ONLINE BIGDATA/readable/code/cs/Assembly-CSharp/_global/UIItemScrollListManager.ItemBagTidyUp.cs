// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIItemScrollListManager.ItemBagTidyUp : ItemBagTidyUpExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8963
{
	// Fields
	private Action endAction; // 0x10

	// Methods

	// RVA: 0x1E75A7C Offset: 0x1E71A7C VA: 0x1E75A7C
	public void .ctor(Action endAction) { }

	// RVA: 0x1E75AAC Offset: 0x1E71AAC VA: 0x1E75AAC Slot: 12
	protected override void OnDoNotNeed() { }

	// RVA: 0x1E75AB0 Offset: 0x1E71AB0 VA: 0x1E75AB0 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1E75AB4 Offset: 0x1E71AB4 VA: 0x1E75AB4 Slot: 10
	protected override void OnSuccess(ItemBagTidyUpResponse response) { }
}
