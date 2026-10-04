// Assembly: AppsFlyer.dll
// Namespace: AppsFlyerSDK
public class AppsFlyer : MonoBehaviour // TypeDefIndex: 17285
{
	// Fields
	public static readonly string kAppsFlyerPluginVersion; // 0x0
	public static string CallBackObjectName; // 0x8
	private static EventHandler onRequestResponse; // 0x10
	private static EventHandler onInAppResponse; // 0x18
	private static EventHandler onDeepLinkReceived; // 0x20
	public static IAppsFlyerNativeBridge instance; // 0x28

	// Methods

	// RVA: 0x16EF200 Offset: 0x16EB200 VA: 0x16EF200
	public static void initSDK(string devKey, string appID) { }

	// RVA: 0x16EC8C0 Offset: 0x16E88C0 VA: 0x16EC8C0
	public static void initSDK(string devKey, string appID, MonoBehaviour gameObject) { }

	// RVA: 0x16ECB08 Offset: 0x16E8B08 VA: 0x16ECB08
	public static void startSDK() { }

	// RVA: 0x16EF3E8 Offset: 0x16EB3E8 VA: 0x16EF3E8
	public static void sendEvent(string eventName, Dictionary<string, string> eventValues) { }

	// RVA: 0x16EF50C Offset: 0x16EB50C VA: 0x16EF50C
	public static void stopSDK(bool isSDKStopped) { }

	// RVA: 0x16EF608 Offset: 0x16EB608 VA: 0x16EF608
	public static bool isSDKStopped() { }

	// RVA: 0x16EF700 Offset: 0x16EB700 VA: 0x16EF700
	public static string getSdkVersion() { }

	// RVA: 0x16EC738 Offset: 0x16E8738 VA: 0x16EC738
	public static void setIsDebug(bool shouldEnable) { }

	// RVA: 0x16EF80C Offset: 0x16EB80C VA: 0x16EF80C
	public static void setCustomerUserId(string id) { }

	// RVA: 0x16EF908 Offset: 0x16EB908 VA: 0x16EF908
	public static void setAppInviteOneLinkID(string oneLinkId) { }

	// RVA: 0x16EFA04 Offset: 0x16EBA04 VA: 0x16EFA04
	public static void setDeepLinkTimeout(long deepLinkTimeout) { }

	// RVA: 0x16EFB00 Offset: 0x16EBB00 VA: 0x16EFB00
	public static void setAdditionalData(Dictionary<string, string> customData) { }

	// RVA: 0x16EFBFC Offset: 0x16EBBFC VA: 0x16EFBFC
	public static void setResolveDeepLinkURLs(string[] urls) { }

	// RVA: 0x16EFCF8 Offset: 0x16EBCF8 VA: 0x16EFCF8
	public static void setOneLinkCustomDomain(string[] domains) { }

	// RVA: 0x16EFE3C Offset: 0x16EBE3C VA: 0x16EFE3C
	public static void setCurrencyCode(string currencyCode) { }

	// RVA: 0x16EFFC4 Offset: 0x16EBFC4 VA: 0x16EFFC4
	public static void setConsentData(AppsFlyerConsent appsFlyerConsent) { }

	// RVA: 0x16F00C0 Offset: 0x16EC0C0 VA: 0x16F00C0
	public static void logAdRevenue(AFAdRevenueData adRevenueData, Dictionary<string, string> additionalParameters) { }

	// RVA: 0x16F01D0 Offset: 0x16EC1D0 VA: 0x16F01D0
	public static void recordLocation(double latitude, double longitude) { }

	// RVA: 0x16F02E0 Offset: 0x16EC2E0 VA: 0x16F02E0
	public static void anonymizeUser(bool shouldAnonymizeUser) { }

	// RVA: 0x16F03DC Offset: 0x16EC3DC VA: 0x16F03DC
	public static void enableTCFDataCollection(bool shouldCollectTcfData) { }

	// RVA: 0x16F04D8 Offset: 0x16EC4D8 VA: 0x16F04D8
	public static string getAppsFlyerId() { }

	// RVA: 0x16F05EC Offset: 0x16EC5EC VA: 0x16F05EC
	public static void setMinTimeBetweenSessions(int seconds) { }

	// RVA: 0x16F06E8 Offset: 0x16EC6E8 VA: 0x16F06E8
	public static void setHost(string hostPrefixName, string hostName) { }

	// RVA: 0x16F0878 Offset: 0x16EC878 VA: 0x16F0878
	public static void setUserEmails(EmailCryptType cryptType, string[] userEmails) { }

	// RVA: 0x16F0988 Offset: 0x16EC988 VA: 0x16F0988
	public static void updateServerUninstallToken(string token) { }

	// RVA: 0x16F0AFC Offset: 0x16ECAFC VA: 0x16F0AFC
	public static void setPhoneNumber(string phoneNumber) { }

	// RVA: 0x16F0BF8 Offset: 0x16ECBF8 VA: 0x16F0BF8
	public static void setImeiData(string aImei) { }

	[Obsolete("Please use setSharingFilterForPartners api")]
	// RVA: 0x16F0D70 Offset: 0x16ECD70 VA: 0x16F0D70
	public static void setSharingFilterForAllPartners() { }

	// RVA: 0x16F0E64 Offset: 0x16ECE64 VA: 0x16F0E64
	public static void setAndroidIdData(string aAndroidId) { }

	// RVA: 0x16F0FDC Offset: 0x16ECFDC VA: 0x16F0FDC
	public static void waitForCustomerUserId(bool wait) { }

	[Obsolete("Please use setSharingFilterForPartners api")]
	// RVA: 0x16F1154 Offset: 0x16ED154 VA: 0x16F1154
	public static void setSharingFilter(string[] partners) { }

	// RVA: 0x16F1250 Offset: 0x16ED250 VA: 0x16F1250
	public static void setCustomerIdAndStartSDK(string id) { }

	// RVA: 0x16F13C8 Offset: 0x16ED3C8 VA: 0x16F13C8
	public static void setSharingFilterForPartners(string[] partners) { }

	// RVA: 0x16F150C Offset: 0x16ED50C VA: 0x16F150C
	public static string getOutOfStore() { }

	// RVA: 0x16F1690 Offset: 0x16ED690 VA: 0x16F1690
	public static void setOutOfStore(string sourceName) { }

	// RVA: 0x16F1808 Offset: 0x16ED808 VA: 0x16F1808
	public static void getConversionData(string objectName) { }

	// RVA: 0x16F1904 Offset: 0x16ED904 VA: 0x16F1904
	public static void setCollectAndroidID(bool isCollect) { }

	// RVA: 0x16F1A7C Offset: 0x16EDA7C VA: 0x16F1A7C
	public static void setIsUpdate(bool isUpdate) { }

	// RVA: 0x16F1BF4 Offset: 0x16EDBF4 VA: 0x16F1BF4
	public static void setCollectIMEI(bool isCollect) { }

	// RVA: 0x16F1D6C Offset: 0x16EDD6C VA: 0x16F1D6C
	public static void setDisableCollectAppleAdSupport(bool disable) { }

	// RVA: 0x16F1EE0 Offset: 0x16EDEE0 VA: 0x16F1EE0
	public static void setShouldCollectDeviceName(bool shouldCollectDeviceName) { }

	// RVA: 0x16F2058 Offset: 0x16EE058 VA: 0x16F2058
	public static void attributeAndOpenStore(string appID, string campaign, Dictionary<string, string> userParams, MonoBehaviour gameObject) { }

	// RVA: 0x16F2184 Offset: 0x16EE184 VA: 0x16F2184
	public static void setPreinstallAttribution(string mediaSource, string campaign, string siteId) { }

	// RVA: 0x16F2318 Offset: 0x16EE318 VA: 0x16F2318
	public static void setDisableCollectIAd(bool disableCollectIAd) { }

	// RVA: 0x16F2490 Offset: 0x16EE490 VA: 0x16F2490
	public static bool isPreInstalledApp() { }

	// RVA: 0x16F25F8 Offset: 0x16EE5F8 VA: 0x16F25F8
	public static void setUseReceiptValidationSandbox(bool useReceiptValidationSandbox) { }

	// RVA: 0x16F2770 Offset: 0x16EE770 VA: 0x16F2770
	public static void recordCrossPromoteImpression(string appID, string campaign, Dictionary<string, string> parameters) { }

	// RVA: 0x16F2888 Offset: 0x16EE888 VA: 0x16F2888
	public static void setUseUninstallSandbox(bool useUninstallSandbox) { }

	// RVA: 0x16F2A00 Offset: 0x16EEA00 VA: 0x16F2A00
	public static string getAttributionId() { }

	// RVA: 0x16F2B84 Offset: 0x16EEB84 VA: 0x16F2B84
	public static void handlePushNotifications() { }

	// RVA: 0x16F2CE8 Offset: 0x16EECE8 VA: 0x16F2CE8
	public static void validateAndSendInAppPurchase(string productIdentifier, string price, string currency, string transactionId, Dictionary<string, string> additionalParameters, MonoBehaviour gameObject) { }

	// RVA: 0x16F2EA0 Offset: 0x16EEEA0 VA: 0x16F2EA0
	public static void validateAndSendInAppPurchase(AFSDKPurchaseDetailsIOS details, Dictionary<string, string> purchaseAdditionalDetails, MonoBehaviour gameObject) { }

	// RVA: 0x16F3034 Offset: 0x16EF034 VA: 0x16F3034
	public static void validateAndSendInAppPurchase(string publicKey, string signature, string purchaseData, string price, string currency, Dictionary<string, string> additionalParameters, MonoBehaviour gameObject) { }

	// RVA: 0x16F31F4 Offset: 0x16EF1F4 VA: 0x16F31F4
	public static void validateAndSendInAppPurchase(AFPurchaseDetailsAndroid details, Dictionary<string, string> purchaseAdditionalDetails, MonoBehaviour gameObject) { }

	// RVA: 0x16F3388 Offset: 0x16EF388 VA: 0x16F3388
	public static void handleOpenUrl(string url, string sourceApplication, string annotation) { }

	// RVA: 0x16F351C Offset: 0x16EF51C VA: 0x16F351C
	public static void registerUninstall(byte[] deviceToken) { }

	// RVA: 0x16F3694 Offset: 0x16EF694 VA: 0x16F3694
	public static void waitForATTUserAuthorizationWithTimeoutInterval(int timeoutInterval) { }

	// RVA: 0x16F380C Offset: 0x16EF80C VA: 0x16F380C
	public static void setCurrentDeviceLanguage(string language) { }

	// RVA: 0x16F3984 Offset: 0x16EF984 VA: 0x16F3984
	public static void generateUserInviteLink(Dictionary<string, string> parameters, MonoBehaviour gameObject) { }

	// RVA: 0x16F3A94 Offset: 0x16EFA94 VA: 0x16F3A94
	public static void disableSKAdNetwork(bool isDisabled) { }

	// RVA: 0x16F3C0C Offset: 0x16EFC0C VA: 0x16F3C0C
	public static void setCollectOaid(bool isCollect) { }

	// RVA: 0x16F3D84 Offset: 0x16EFD84 VA: 0x16F3D84
	public static void addPushNotificationDeepLinkPath(string[] paths) { }

	// RVA: 0x16F3E80 Offset: 0x16EFE80 VA: 0x16F3E80
	public static void setDisableAdvertisingIdentifiers(bool disable) { }

	// RVA: 0x16F3FF8 Offset: 0x16EFFF8 VA: 0x16F3FF8
	public static void subscribeForDeepLink() { }

	// RVA: 0x16F40F4 Offset: 0x16F00F4 VA: 0x16F40F4
	public static void setPartnerData(string partnerId, Dictionary<string, string> partnerInfo) { }

	// RVA: 0x16F4204 Offset: 0x16F0204 VA: 0x16F4204
	public static void setDisableNetworkData(bool disable) { }

	// RVA: 0x16F437C Offset: 0x16F037C VA: 0x16F437C
	public static void disableIDFVCollection(bool isDisabled) { }

	// RVA: 0x16F4380 Offset: 0x16F0380 VA: 0x16F4380
	public static void add_OnRequestResponse(EventHandler value) { }

	// RVA: 0x16F4444 Offset: 0x16F0444 VA: 0x16F4444
	public static void remove_OnRequestResponse(EventHandler value) { }

	// RVA: 0x16F4508 Offset: 0x16F0508 VA: 0x16F4508
	public static void add_OnInAppResponse(EventHandler value) { }

	// RVA: 0x16F45CC Offset: 0x16F05CC VA: 0x16F45CC
	public static void remove_OnInAppResponse(EventHandler value) { }

	// RVA: 0x16F4690 Offset: 0x16F0690 VA: 0x16F4690
	public static void add_OnDeepLinkReceived(EventHandler value) { }

	// RVA: 0x16F4758 Offset: 0x16F0758 VA: 0x16F4758
	public static void remove_OnDeepLinkReceived(EventHandler value) { }

	// RVA: 0x16F481C Offset: 0x16F081C VA: 0x16F481C
	public void inAppResponseReceived(string response) { }

	// RVA: 0x16F4B6C Offset: 0x16F0B6C VA: 0x16F4B6C
	public void requestResponseReceived(string response) { }

	// RVA: 0x16F4C20 Offset: 0x16F0C20 VA: 0x16F4C20
	public void onDeepLinking(string response) { }

	// RVA: 0x16F48D0 Offset: 0x16F08D0 VA: 0x16F48D0
	private static AppsFlyerRequestEventArgs parseRequestCallback(string response) { }

	// RVA: 0x16ECD48 Offset: 0x16E8D48 VA: 0x16ECD48
	public static Dictionary<string, object> CallbackStringToDictionary(string str) { }

	// RVA: 0x16ECC84 Offset: 0x16E8C84 VA: 0x16ECC84
	public static void AFLog(string methodName, string str) { }

	// RVA: 0x16F5264 Offset: 0x16F1264 VA: 0x16F5264
	public void .ctor() { }

	// RVA: 0x16F526C Offset: 0x16F126C VA: 0x16F526C
	private static void .cctor() { }
}
