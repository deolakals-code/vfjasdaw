// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Command
[CLSCompliant(False)]
public static class BankOperations // TypeDefIndex: 15125
{
	// Methods

	// RVA: 0x3587F1C Offset: 0x3583F1C VA: 0x3587F1C
	public static void BankSetup(Game game) { }

	// RVA: 0x3588014 Offset: 0x3584014 VA: 0x3588014
	public static void DepositGold(Game game, int goldNum, long bankPoint) { }

	// RVA: 0x358811C Offset: 0x358411C VA: 0x358811C
	public static void WithdrawGold(Game game, int goldNum, int clientFee, long bankPoint) { }

	// RVA: 0x3588230 Offset: 0x3584230 VA: 0x3588230
	public static void DepositMaterial(Game game, byte materialId, byte materialLv, int materialNum, long bankPoint) { }

	// RVA: 0x3588350 Offset: 0x3584350 VA: 0x3588350
	public static void WithdrawMaterial(Game game, byte materialId, byte materialLv, int materialNum, int clientFee, long bankPoint) { }

	// RVA: 0x358847C Offset: 0x358447C VA: 0x358847C
	public static void ExpPotionPurchase(Game game, int haveOrb) { }

	// RVA: 0x358857C Offset: 0x358457C VA: 0x358857C
	public static void ExpPotionDeposit(Game game) { }

	// RVA: 0x3588674 Offset: 0x3584674 VA: 0x3588674
	public static void ExpPotionUse(Game game, byte potionNo) { }

	// RVA: 0x3588774 Offset: 0x3584774 VA: 0x3588774
	public static void MarketDepositGold(Game game, int depositGold, long bankPoint) { }

	// RVA: 0x358887C Offset: 0x358487C VA: 0x358887C
	public static void MarketDepositMaterial(Game game, byte materialId, byte materialLv, int depositPoint, long bankPoint) { }

	// RVA: 0x358899C Offset: 0x358499C VA: 0x358899C
	public static void MarketDepositExpPotion(Game game, byte potionNo) { }
}
