// Assembly: AppsFlyer.dll
// Namespace: AppsFlyerSDK
public class AppsFlyerPurchaseRevenueBridge : MonoBehaviour // TypeDefIndex: 17295
{
	// Fields
	private static IAppsFlyerPurchaseRevenueDataSource _dataSource; // 0x0
	private static IAppsFlyerPurchaseRevenueDataSourceStoreKit2 _dataSourceSK2; // 0x8

	// Methods

	// RVA: 0x16FA950 Offset: 0x16F6950 VA: 0x16FA950
	public static void RegisterDataSource(IAppsFlyerPurchaseRevenueDataSource dataSource) { }

	// RVA: 0x16FAC50 Offset: 0x16F6C50 VA: 0x16FAC50
	public static void RegisterDataSourceStoreKit2(IAppsFlyerPurchaseRevenueDataSourceStoreKit2 dataSource) { }

	// RVA: 0x16FAC54 Offset: 0x16F6C54 VA: 0x16FAC54
	public static Dictionary<string, object> GetAdditionalParametersForAndroid(HashSet<object> products, HashSet<object> transactions) { }

	// RVA: 0x16FAD6C Offset: 0x16F6D6C VA: 0x16FAD6C
	public void .ctor() { }
}
