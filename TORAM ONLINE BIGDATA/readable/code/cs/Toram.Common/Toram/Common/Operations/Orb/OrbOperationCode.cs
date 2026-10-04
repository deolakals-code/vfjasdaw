// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public enum OrbOperationCode // TypeDefIndex: 11813
{
	// Fields
	public int value__; // 0x0
	public const OrbOperationCode Nil = 0;
	public const OrbOperationCode OrbCourseUpdate = 1;
	public const OrbOperationCode OrbStoreUpdate = 2;
	public const OrbOperationCode OrbServicePrice = 3;
	public const OrbOperationCode OrbServiceBuy = 4;
	public const OrbOperationCode OrbUpdate = 5;
	public const OrbOperationCode OrbBarter = 6;
	public const OrbOperationCode OrbItemCheck = 7;
	public const OrbOperationCode OrbItemUse = 8;
	public const OrbOperationCode OrbItemRespawn = 9;
	public const OrbOperationCode OrbItemMagicCharge = 10;
	public const OrbOperationCode OrbRecycling = 11;
	public const OrbOperationCode OrbEquipFlagChange = 12;
	public const OrbOperationCode OrbTicketExchange = 13;
	public const OrbOperationCode OrbRenameServicePrice = 14;
	public const OrbOperationCode OrbStarGemExchange = 15;
	public const OrbOperationCode OrbStarGemBag = 16;
	public const OrbOperationCode OrbStarGemEquip = 17;
	public const OrbOperationCode OrbStarGemBreak = 18;
	public const OrbOperationCode OrbStarGemReinforce = 19;
	public const OrbOperationCode OrbStarGemEvolution = 20;
	public const OrbOperationCode OrbStarGemPurchaseCheck = 21;
	[Obsolete("rm26322でItemOperationCode.OrbReEnchantへ移行。後方互換のため残置")]
	public const OrbOperationCode OrbReEnchantment = 22;
	[Obsolete("rm26322でItemOperationCode.OrbEnchantGetListへ移行。後方互換のため残置")]
	public const OrbOperationCode OrbEnchantGetList = 23;
}
