// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaItemManager.MobaGetItemList : MobaGetItemListExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2045
{
	// Fields
	private MobaItemManager manager; // 0x10

	// Methods

	// RVA: 0x213E6A4 Offset: 0x213A6A4 VA: 0x213E6A4
	public void .ctor(MobaItemManager manager) { }

	// RVA: 0x213EA0C Offset: 0x213AA0C VA: 0x213EA0C Slot: 12
	protected override void OnFailure(short returnCode, MobaGetItemListResponse response) { }

	// RVA: 0x213EA10 Offset: 0x213AA10 VA: 0x213EA10 Slot: 11
	protected override void OnNotStart(MobaGetItemListResponse response) { }

	// RVA: 0x213EA14 Offset: 0x213AA14 VA: 0x213EA14 Slot: 10
	protected override void OnSuccess(MobaGetItemListResponse response) { }
}
