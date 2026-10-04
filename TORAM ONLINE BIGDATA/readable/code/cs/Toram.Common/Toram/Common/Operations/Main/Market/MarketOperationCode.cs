// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Market
public enum MarketOperationCode // TypeDefIndex: 11916
{
	// Fields
	public int value__; // 0x0
	public const MarketOperationCode Nil = 0;
	public const MarketOperationCode MarketSetUp = 1;
	public const MarketOperationCode XXXXXX = 2;
	public const MarketOperationCode UserSalesList = 3;
	public const MarketOperationCode Exhibit = 4;
	public const MarketOperationCode ExhibitCancel = 5;
	public const MarketOperationCode SalesAcquisition = 6;
	public const MarketOperationCode SalesResult = 7;
	public const MarketOperationCode ProductList = 8;
	public const MarketOperationCode PurchaseCheck = 9;
	public const MarketOperationCode Purchase = 10;
	public const MarketOperationCode PurchaseResult = 11;
	public const MarketOperationCode Logout = 12;
	public const MarketOperationCode Recovery = 200;
	public const MarketOperationCode RecoverySend = 201;
	public const MarketOperationCode RecoveryReceive = 202;
	public const MarketOperationCode RecoveryPurchase = 203;
	public const MarketOperationCode RecoveryPurchaseResult = 204;
}
