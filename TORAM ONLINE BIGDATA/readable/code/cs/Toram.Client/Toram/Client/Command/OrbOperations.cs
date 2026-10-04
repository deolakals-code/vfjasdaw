// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Command
[CLSCompliant(False)]
public static class OrbOperations // TypeDefIndex: 15140
{
	// Methods

	// RVA: 0x35A238C Offset: 0x359E38C VA: 0x35A238C
	public static void CourseUpdate(Game game, int orb) { }

	// RVA: 0x35A24A0 Offset: 0x359E4A0 VA: 0x35A24A0
	public static void StoreUpdate(Game game, int orb) { }

	// RVA: 0x35A25B4 Offset: 0x359E5B4 VA: 0x35A25B4
	public static void OrbUpdate(Game game) { }

	// RVA: 0x35A26C0 Offset: 0x359E6C0 VA: 0x35A26C0
	public static void OrbBarter(Game game, int num) { }

	// RVA: 0x35A27D4 Offset: 0x359E7D4 VA: 0x35A27D4
	public static void TicketExchange(Game game, int num) { }

	// RVA: 0x35A28E8 Offset: 0x359E8E8 VA: 0x35A28E8
	public static void ItemCheck(Game game, int useItemId) { }

	// RVA: 0x35A29FC Offset: 0x359E9FC VA: 0x35A29FC
	public static void ItemUse(Game game, int useItemId) { }

	// RVA: 0x35A2B10 Offset: 0x359EB10 VA: 0x35A2B10
	public static void ItemUse(Game game, int useItemId, int targetItemId) { }

	// RVA: 0x35A2C28 Offset: 0x359EC28 VA: 0x35A2C28
	public static void ItemRespawn(Game game) { }

	// RVA: 0x35A2D34 Offset: 0x359ED34 VA: 0x35A2D34
	public static void ItemMagicCharge(Game game) { }

	// RVA: 0x35A2E40 Offset: 0x359EE40 VA: 0x35A2E40
	public static void Recycling(Game game, OrbRecycleType recycleType, int orbItemid, int orbItemUuid) { }

	// RVA: 0x35A2F68 Offset: 0x359EF68 VA: 0x35A2F68
	public static void EquipNewFlagRelease(Game game, int itemId, int itemUuid) { }

	// RVA: 0x35A3088 Offset: 0x359F088 VA: 0x35A3088
	public static void EquipFavoriteFlagChange(Game game, int itemId, int itemUuid, bool enable) { }

	// RVA: 0x35A31BC Offset: 0x359F1BC VA: 0x35A31BC
	public static void ItemUseExtractionChrista(Game game, int useItemId, int targetItemId, byte slotNo) { }

	// RVA: 0x35A32E8 Offset: 0x359F2E8 VA: 0x35A32E8
	public static void ItemUseEnchantScrollAvatarTop(Game game, int useItemId, int targetItemId) { }

	// RVA: 0x35A3418 Offset: 0x359F418 VA: 0x35A3418
	public static void ItemUseEnchantScrollAvatarBottom(Game game, int useItemId, int targetItemId) { }

	// RVA: 0x35A3420 Offset: 0x359F420 VA: 0x35A3420
	public static void ItemUseEnchantScrollAvatarOption(Game game, int useItemId, int targetItemId) { }

	// RVA: 0x35A32F0 Offset: 0x359F2F0 VA: 0x35A32F0
	public static void ItemUseEnchant(Game game, int useItemId, int targetItemId, EquipType targetEquipType) { }

	// RVA: 0x35A3428 Offset: 0x359F428 VA: 0x35A3428
	public static void ItemUseEnchantExtraction(Game game, int useItemId, int targetItemId, EquipType targetEquipType, byte index) { }

	// RVA: 0x35A3558 Offset: 0x359F558 VA: 0x35A3558
	public static void ItemUsePocketbookOfForgetting(Game game, int useItemId, int skillTreeType) { }

	// RVA: 0x35A3674 Offset: 0x359F674 VA: 0x35A3674
	public static void ItemUseWarpTicket(Game game, int useItemId, int fieldId) { }

	// RVA: 0x35A3790 Offset: 0x359F790 VA: 0x35A3790
	public static void ItemUseScenarioReorder(Game game, int useItemId, int scenarioProgress) { }

	// RVA: 0x35A38AC Offset: 0x359F8AC VA: 0x35A38AC
	public static void ItemUseChallengeRecovery(Game game, int useItemId, int type) { }

	// RVA: 0x35A39C8 Offset: 0x359F9C8 VA: 0x35A39C8
	public static void ItemUsePhantomHeavyPotion(Game game, int useItemId, int targetItemId, ItemCustomTypes changeType, byte ability) { }

	// RVA: 0x35A3AF8 Offset: 0x359FAF8 VA: 0x35A3AF8
	public static void ServicePrice(Game game, OrbServiceType serviceType) { }

	// RVA: 0x35A3C0C Offset: 0x359FC0C VA: 0x35A3C0C
	public static void ServiceInventorySlotPrice(Game game, byte dataType) { }

	// RVA: 0x35A3D2C Offset: 0x359FD2C VA: 0x35A3D2C
	public static void ServiceRenamePrice(Game game) { }

	// RVA: 0x35A3E38 Offset: 0x359FE38 VA: 0x35A3E38
	public static void ServiceBuyResurrection(Game game, int orbNum) { }

	// RVA: 0x35A3F80 Offset: 0x359FF80 VA: 0x35A3F80
	public static void ServiceBuyWorldWarp(Game game, int orbNum, int fieldId, byte locationId) { }

	// RVA: 0x35A4020 Offset: 0x35A0020 VA: 0x35A4020
	public static void ServiceBuyParameterSlot(Game game, int orbNum, int useOrb) { }

	// RVA: 0x35A40B0 Offset: 0x35A00B0 VA: 0x35A40B0
	public static void ServiceBuyStorageExpansion(Game game, int orbNum, byte storageNo) { }

	// RVA: 0x35A4140 Offset: 0x35A0140 VA: 0x35A4140
	public static void ServiceBuyStorageRent(Game game, int orbNum, byte storageNo) { }

	// RVA: 0x35A41D0 Offset: 0x35A01D0 VA: 0x35A41D0
	public static void ServiceBuySkillTreeReset(Game game, int orbNum, int skillTreeType) { }

	// RVA: 0x35A4260 Offset: 0x35A0260 VA: 0x35A4260
	public static void ServiceBuyAllSkillTreeReset(Game game, int orbNum) { }

	// RVA: 0x35A4270 Offset: 0x35A0270 VA: 0x35A4270
	public static void ServiceBuyCristaRemove(Game game, int orbNum, int targetItemUuid, byte slotNo) { }

	// RVA: 0x35A4310 Offset: 0x35A0310 VA: 0x35A4310
	public static void ServiceBuyStatusReset(Game game, int orbNum) { }

	// RVA: 0x35A4320 Offset: 0x35A0320 VA: 0x35A4320
	public static void ServiceBuyChangePersonality(Game game, int orbNum) { }

	// RVA: 0x35A4330 Offset: 0x35A0330 VA: 0x35A4330
	public static void ServiceMazeChallengeRecovery(Game game, int orbNum) { }

	// RVA: 0x35A4340 Offset: 0x35A0340 VA: 0x35A4340
	public static void ServiceBuyItemBagSlot(Game game, byte dataType, int orbNum, int useOrb) { }

	// RVA: 0x35A43E0 Offset: 0x35A03E0 VA: 0x35A43E0
	public static void ServiceBuyFairySewingTools(Game game, int orbNum) { }

	// RVA: 0x35A43F0 Offset: 0x35A03F0 VA: 0x35A43F0
	public static void ServiceServiceTreasureKeyRecovery(Game game, int orbNum) { }

	// RVA: 0x35A4400 Offset: 0x35A0400 VA: 0x35A4400
	public static void ServiceBuySummerStaminaRecovery(Game game, int orbNum) { }

	// RVA: 0x35A3E48 Offset: 0x359FE48 VA: 0x35A3E48
	private static void ServiceBuy(Game game, byte serviceType, Dictionary<object, object> serviceParam, int orbNum) { }

	// RVA: 0x35A4410 Offset: 0x35A0410 VA: 0x35A4410
	public static void ServiceTreasureHuntRecovery(Game game, int orbNum) { }

	// RVA: 0x35A4420 Offset: 0x35A0420 VA: 0x35A4420
	public static void ServiceBuyComboLine(Game game, int orbNum) { }

	// RVA: 0x35A4430 Offset: 0x35A0430 VA: 0x35A4430
	public static void ServiceBuyHireGuildStaff(Game game, int orbNum) { }

	// RVA: 0x35A4440 Offset: 0x35A0440 VA: 0x35A4440
	public static void ServiceBuyGuildRaidInvalidRandomProperty(Game game, int orbNum, byte index, int useOrb) { }

	// RVA: 0x35A44E0 Offset: 0x35A04E0 VA: 0x35A44E0
	public static void ServiceBuyGuildRaidStaminRecovery(Game game, int orbNum) { }

	// RVA: 0x35A44F0 Offset: 0x35A04F0 VA: 0x35A44F0
	public static void ServiceBuyCuisineCleanUp(Game game, int orbNum) { }

	// RVA: 0x35A4500 Offset: 0x35A0500 VA: 0x35A4500
	public static void ServiceBuyExpansionFishingFishSlot(Game game, int orbNum) { }

	// RVA: 0x35A4510 Offset: 0x35A0510 VA: 0x35A4510
	public static void ServiceBuyExpansionBazaarSlot(Game game, int orbNum) { }

	// RVA: 0x35A4520 Offset: 0x35A0520 VA: 0x35A4520
	public static void ServiceBuyExpansionFriendSlot(Game game, int orbNum) { }

	// RVA: 0x35A4530 Offset: 0x35A0530 VA: 0x35A4530
	public static void ServiceBuyExpansionPetSaleSlot(Game game, int orbNum) { }

	// RVA: 0x35A4540 Offset: 0x35A0540 VA: 0x35A4540
	public static void ServiceBuyExpansionEnchantSlot(Game game, int orbNum, byte targetEquipType) { }

	// RVA: 0x35A45D0 Offset: 0x35A05D0 VA: 0x35A45D0
	public static void StarGemPurchaseCheck(Game game) { }

	// RVA: 0x35A46DC Offset: 0x35A06DC VA: 0x35A46DC
	public static void StarGemExchangeRandom(Game game, int useShard) { }

	// RVA: 0x35A47F0 Offset: 0x35A07F0 VA: 0x35A47F0
	public static void StarGemExchangeRandomDirect(Game game, int orbNum) { }

	// RVA: 0x35A490C Offset: 0x35A090C VA: 0x35A490C
	public static void StarGemExchange(Game game, int useShard, short skillId) { }

	// RVA: 0x35A4A28 Offset: 0x35A0A28 VA: 0x35A4A28
	public static void StarGemBag(Game game) { }

	// RVA: 0x35A4B34 Offset: 0x35A0B34 VA: 0x35A4B34
	public static void StarGemEquips(Game game, Dictionary<byte, long> updateEquips, int cost) { }

	// RVA: 0x35A4C5C Offset: 0x35A0C5C VA: 0x35A4C5C
	public static void StarGemBreak(Game game, long gemUuid, byte flag) { }

	// RVA: 0x35A4D78 Offset: 0x35A0D78 VA: 0x35A4D78
	public static void StarGemReinforce(Game game, long reinforceGemUid, short reinforceGemNo, long materialGemUid, short materialGemNo) { }

	// RVA: 0x35A4EAC Offset: 0x35A0EAC VA: 0x35A4EAC
	public static void StarGemEvolution(Game game, long evolutionGemUid, short evolutionGemNo, short evolutionSkill) { }
}
