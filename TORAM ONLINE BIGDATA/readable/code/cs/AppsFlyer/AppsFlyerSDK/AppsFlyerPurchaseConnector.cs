// Assembly: AppsFlyer.dll
// Namespace: AppsFlyerSDK
public class AppsFlyerPurchaseConnector : MonoBehaviour // TypeDefIndex: 17297
{
	// Fields
	private static AppsFlyerPurchaseConnector instance; // 0x0
	private Dictionary<string, object> pendingParameters; // 0x20
	private Action<Dictionary<string, object>> pendingCallback; // 0x28
	private static AndroidJavaClass appsFlyerAndroidConnector; // 0x8

	// Properties
	public static AppsFlyerPurchaseConnector Instance { get; }

	// Methods

	// RVA: 0x16FB58C Offset: 0x16F758C VA: 0x16FB58C
	public static AppsFlyerPurchaseConnector get_Instance() { }

	// RVA: 0x16FB6FC Offset: 0x16F76FC VA: 0x16FB6FC
	private void Awake() { }

	// RVA: 0x16FB830 Offset: 0x16F7830 VA: 0x16FB830
	public static void init(MonoBehaviour unityObject, Store s) { }

	// RVA: 0x16FBA04 Offset: 0x16F7A04 VA: 0x16FBA04
	public static void build() { }

	// RVA: 0x16FBAE8 Offset: 0x16F7AE8 VA: 0x16FBAE8
	public static void startObservingTransactions() { }

	// RVA: 0x16FBBCC Offset: 0x16F7BCC VA: 0x16FBBCC
	public static void stopObservingTransactions() { }

	// RVA: 0x16FBCB0 Offset: 0x16F7CB0 VA: 0x16FBCB0
	public static void setIsSandbox(bool isSandbox) { }

	// RVA: 0x16FBDE0 Offset: 0x16F7DE0 VA: 0x16FBDE0
	public static void setPurchaseRevenueValidationListeners(bool enableCallbacks) { }

	// RVA: 0x16FBF10 Offset: 0x16F7F10 VA: 0x16FBF10
	public static void setAutoLogPurchaseRevenue(AppsFlyerAutoLogPurchaseRevenueOptions[] autoLogPurchaseRevenueOptions) { }

	// RVA: 0x16FC134 Offset: 0x16F8134 VA: 0x16FC134
	public static void setPurchaseRevenueDataSource(IAppsFlyerPurchaseRevenueDataSource dataSource) { }

	// RVA: 0x16FC140 Offset: 0x16F8140 VA: 0x16FC140
	public static void setPurchaseRevenueDataSourceStoreKit2(IAppsFlyerPurchaseRevenueDataSourceStoreKit2 dataSourceSK2) { }

	// RVA: 0x16FB9F8 Offset: 0x16F79F8 VA: 0x16FB9F8
	private static int mapStoreToInt(Store s) { }

	// RVA: 0x16FC144 Offset: 0x16F8144 VA: 0x16FC144
	public static void setStoreKitVersion(StoreKitVersion storeKitVersion) { }

	// RVA: 0x16FC148 Offset: 0x16F8148 VA: 0x16FC148
	public static void logConsumableTransaction(string transactionJson) { }

	// RVA: 0x16FC14C Offset: 0x16F814C VA: 0x16FC14C
	public void .ctor() { }

	// RVA: 0x16FC154 Offset: 0x16F8154 VA: 0x16FC154
	private static void .cctor() { }
}
