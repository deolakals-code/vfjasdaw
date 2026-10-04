// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPetShopSellManager.HousePetExhabitSale : HousePetExhabitSaleExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7731
{
	// Fields
	private UIPetShopSellManager manager; // 0x28

	// Methods

	// RVA: 0x1BF7778 Offset: 0x1BF3778 VA: 0x1BF7778
	public void .ctor(UIPetShopSellManager manager, byte no, int price, long petUuid, byte exhabitType, int password) { }

	// RVA: 0x1BFA7C0 Offset: 0x1BF67C0 VA: 0x1BFA7C0 Slot: 15
	protected override void OnExhabitTypeWrong() { }

	// RVA: 0x1BFA7C4 Offset: 0x1BF67C4 VA: 0x1BFA7C4 Slot: 17
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1BFA7C8 Offset: 0x1BF67C8 VA: 0x1BFA7C8 Slot: 13
	protected override void OnNoChangePrice() { }

	// RVA: 0x1BFA7CC Offset: 0x1BF67CC VA: 0x1BFA7CC Slot: 14
	protected override void OnNotFound() { }

	// RVA: 0x1BFA7D0 Offset: 0x1BF67D0 VA: 0x1BFA7D0 Slot: 11
	protected override void OnNotLoaded() { }

	// RVA: 0x1BFA7D4 Offset: 0x1BF67D4 VA: 0x1BFA7D4 Slot: 12
	protected override void OnNotStopSale() { }

	// RVA: 0x1BFA7EC Offset: 0x1BF67EC VA: 0x1BFA7EC Slot: 16
	protected override void OnPasswordWrong() { }

	// RVA: 0x1BFA7F0 Offset: 0x1BF67F0 VA: 0x1BFA7F0 Slot: 10
	protected override void OnSuccess(HousePetExhabitSaleResponse response) { }
}
