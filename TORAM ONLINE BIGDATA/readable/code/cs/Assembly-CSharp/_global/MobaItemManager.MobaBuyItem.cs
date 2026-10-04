// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaItemManager.MobaBuyItem : MobaBuyItemExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2046
{
	// Fields
	private MobaItemManager manager; // 0x18

	// Methods

	// RVA: 0x213E790 Offset: 0x213A790 VA: 0x213E790
	public void .ctor(MobaItemManager manager, int shopItemId, int buyPrice) { }

	// RVA: 0x213EA5C Offset: 0x213AA5C VA: 0x213EA5C Slot: 13
	protected override void OnFailure(short returnCode, MobaBuyItemResponse response) { }

	// RVA: 0x213EA60 Offset: 0x213AA60 VA: 0x213EA60 Slot: 12
	protected override void OnNotMatch(MobaBuyItemResponse response) { }

	// RVA: 0x213EA64 Offset: 0x213AA64 VA: 0x213EA64 Slot: 11
	protected override void OnNotStart(MobaBuyItemResponse response) { }

	// RVA: 0x213EA68 Offset: 0x213AA68 VA: 0x213EA68 Slot: 10
	protected override void OnSuccess(MobaBuyItemResponse response) { }
}
