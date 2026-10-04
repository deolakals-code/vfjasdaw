// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPetShopSellManager.HousePetCancelExhabitSale : HousePetCancelExhabitSaleExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7732
{
	// Fields
	private UIPetShopSellManager manager; // 0x18

	// Methods

	// RVA: 0x1BFA8B8 Offset: 0x1BF68B8 VA: 0x1BFA8B8
	public void .ctor(UIPetShopSellManager manager, byte no) { }

	// RVA: 0x1BFA8EC Offset: 0x1BF68EC VA: 0x1BFA8EC Slot: 15
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1BFA8F0 Offset: 0x1BF68F0 VA: 0x1BFA8F0 Slot: 13
	protected override void OnNotFound() { }

	// RVA: 0x1BFA8F4 Offset: 0x1BF68F4 VA: 0x1BFA8F4 Slot: 11
	protected override void OnNotLoaded() { }

	// RVA: 0x1BFA8F8 Offset: 0x1BF68F8 VA: 0x1BFA8F8 Slot: 12
	protected override void OnNotStopSale() { }

	// RVA: 0x1BFA910 Offset: 0x1BF6910 VA: 0x1BFA910 Slot: 14
	protected override void OnPetStorageNoVacancies() { }

	// RVA: 0x1BFA914 Offset: 0x1BF6914 VA: 0x1BFA914 Slot: 10
	protected override void OnSuccess(HousePetCancelExhabitSaleResponse response) { }
}
