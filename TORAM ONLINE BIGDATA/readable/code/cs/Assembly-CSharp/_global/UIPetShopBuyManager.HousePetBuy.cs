// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPetShopBuyManager.HousePetBuy : HousePetBuyExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7722
{
	// Fields
	private UIPetShopBuyManager manager; // 0x18

	// Methods

	// RVA: 0x1BF19C0 Offset: 0x1BED9C0 VA: 0x1BF19C0
	public void .ctor(UIPetShopBuyManager manager, byte no, int password) { }

	// RVA: 0x1BF37B8 Offset: 0x1BEF7B8 VA: 0x1BF37B8 Slot: 17
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1BF3878 Offset: 0x1BEF878 VA: 0x1BF3878 Slot: 16
	protected override void OnNotAllowed() { }

	// RVA: 0x1BF3934 Offset: 0x1BEF934 VA: 0x1BF3934 Slot: 14
	protected override void OnNotMatch() { }

	// RVA: 0x1BF3A98 Offset: 0x1BEFA98 VA: 0x1BF3A98 Slot: 11
	protected override void OnNotSale() { }

	// RVA: 0x1BF3B54 Offset: 0x1BEFB54 VA: 0x1BF3B54 Slot: 15
	protected override void OnPasswordWrong() { }

	// RVA: 0x1BF3B58 Offset: 0x1BEFB58 VA: 0x1BF3B58 Slot: 12
	protected override void OnPetNotFound() { }

	// RVA: 0x1BF3C14 Offset: 0x1BEFC14 VA: 0x1BF3C14 Slot: 13
	protected override void OnPetStorageNoVacancies() { }

	// RVA: 0x1BF3D78 Offset: 0x1BEFD78 VA: 0x1BF3D78 Slot: 10
	protected override void OnSuccess(HousePetBuyResponse response) { }
}
