// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Command
[CLSCompliant(False)]
public static class MarketOperations // TypeDefIndex: 15130
{
	// Methods

	// RVA: 0x359027C Offset: 0x358C27C VA: 0x359027C
	public static void MarketSetUp(Game game, int shopId, int autoLockFlag) { }

	// RVA: 0x3590394 Offset: 0x358C394 VA: 0x3590394
	public static void UserSalesList(Game game) { }

	// RVA: 0x35904A0 Offset: 0x358C4A0 VA: 0x35904A0
	public static void Exhibit(Game game, byte saleId, MarketType marketType, ItemSelectData select, int price, int fee) { }

	// RVA: 0x35905EC Offset: 0x358C5EC VA: 0x35905EC
	public static void ExhibitStarGem(Game game, byte saleId, MarketType marketType, long starGemUuid, int price, int fee) { }

	// RVA: 0x359072C Offset: 0x358C72C VA: 0x359072C
	public static void ExhibitCancel(Game game, byte saleId, long marketId) { }

	// RVA: 0x3590848 Offset: 0x358C848 VA: 0x3590848
	public static void SalesAcquisition(Game game, byte saleId, long marketId) { }

	// RVA: 0x3590964 Offset: 0x358C964 VA: 0x3590964
	public static void ProductList(Game game, MarketType marketType, int id, ItemType type, MarketOrderType viewType, byte page = 1) { }

	// RVA: 0x3590AA8 Offset: 0x358CAA8 VA: 0x3590AA8
	public static void ProductListEquipOption(Game game, MarketType marketType, int id, ItemType type, MarketOrderType viewType, MarketProductList.EnumOptionsSlot slot, byte color, MarketProductList.EnumOptionsParts parts, int modelid, short capId, short rProperty, byte page = 1) { }

	// RVA: 0x3590C44 Offset: 0x358CC44 VA: 0x3590C44
	public static void ProductListPetOption(Game game, MarketType marketType, int id, ItemType type, MarketOrderType viewType, int petId, byte page = 1) { }

	// RVA: 0x3590D98 Offset: 0x358CD98 VA: 0x3590D98
	public static void Purchase(Game game, MarketType marketType, long marketId, int id, ItemType type, MarketOrderType viewType, byte tariffRate, int autoLockFlag) { }
}
