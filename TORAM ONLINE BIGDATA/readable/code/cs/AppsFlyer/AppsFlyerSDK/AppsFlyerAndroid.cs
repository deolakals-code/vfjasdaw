// Assembly: AppsFlyer.dll
// Namespace: AppsFlyerSDK
public class AppsFlyerAndroid : IAppsFlyerAndroidBridge, IAppsFlyerNativeBridge // TypeDefIndex: 17287
{
	// Fields
	[CompilerGenerated]
	private bool <isInit>k__BackingField; // 0x10
	private static AndroidJavaClass appsFlyerAndroid; // 0x0

	// Properties
	public bool isInit { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x16F53F0 Offset: 0x16F13F0 VA: 0x16F53F0 Slot: 23
	public bool get_isInit() { }

	[CompilerGenerated]
	// RVA: 0x16F53F8 Offset: 0x16F13F8 VA: 0x16F53F8 Slot: 24
	public void set_isInit(bool value) { }

	// RVA: 0x16EF258 Offset: 0x16EB258 VA: 0x16EF258
	public void .ctor() { }

	// RVA: 0x16EF260 Offset: 0x16EB260 VA: 0x16EF260
	public void initSDK(string devkey, MonoBehaviour gameObject) { }

	// RVA: 0x16F5404 Offset: 0x16F1404 VA: 0x16F5404 Slot: 25
	public void startSDK(bool onRequestResponse, string CallBackObjectName) { }

	// RVA: 0x16F556C Offset: 0x16F156C VA: 0x16F556C Slot: 27
	public void stopSDK(bool isSDKStopped) { }

	// RVA: 0x16F569C Offset: 0x16F169C VA: 0x16F569C Slot: 29
	public string getSdkVersion() { }

	// RVA: 0x16F5794 Offset: 0x16F1794 VA: 0x16F5794 Slot: 4
	public void updateServerUninstallToken(string token) { }

	// RVA: 0x16F5884 Offset: 0x16F1884 VA: 0x16F5884 Slot: 55
	public void setIsDebug(bool shouldEnable) { }

	// RVA: 0x16F59B4 Offset: 0x16F19B4 VA: 0x16F59B4 Slot: 5
	public void setImeiData(string aImei) { }

	// RVA: 0x16F5AA4 Offset: 0x16F1AA4 VA: 0x16F5AA4 Slot: 6
	public void setAndroidIdData(string aAndroidId) { }

	// RVA: 0x16F5B94 Offset: 0x16F1B94 VA: 0x16F5B94 Slot: 30
	public void setCustomerUserId(string id) { }

	// RVA: 0x16F5C84 Offset: 0x16F1C84 VA: 0x16F5C84 Slot: 7
	public void waitForCustomerUserId(bool wait) { }

	// RVA: 0x16F5DB4 Offset: 0x16F1DB4 VA: 0x16F5DB4 Slot: 8
	public void setCustomerIdAndStartSDK(string id) { }

	// RVA: 0x16F5EA4 Offset: 0x16F1EA4 VA: 0x16F5EA4 Slot: 9
	public string getOutOfStore() { }

	// RVA: 0x16F5F9C Offset: 0x16F1F9C VA: 0x16F5F9C Slot: 10
	public void setOutOfStore(string sourceName) { }

	// RVA: 0x16F608C Offset: 0x16F208C VA: 0x16F608C Slot: 31
	public void setAppInviteOneLinkID(string oneLinkId) { }

	// RVA: 0x16F617C Offset: 0x16F217C VA: 0x16F617C Slot: 32
	public void setAdditionalData(Dictionary<string, string> customData) { }

	// RVA: 0x16F6628 Offset: 0x16F2628 VA: 0x16F6628 Slot: 33
	public void setDeepLinkTimeout(long deepLinkTimeout) { }

	// RVA: 0x16F674C Offset: 0x16F274C VA: 0x16F674C
	public void setUserEmails(string[] userEmails) { }

	// RVA: 0x16F683C Offset: 0x16F283C VA: 0x16F683C Slot: 45
	public void setPhoneNumber(string phoneNumber) { }

	// RVA: 0x16F692C Offset: 0x16F292C VA: 0x16F692C Slot: 53
	public void setUserEmails(EmailCryptType cryptMethod, string[] emails) { }

	// RVA: 0x16F6B34 Offset: 0x16F2B34 VA: 0x16F6B34 Slot: 11
	public void setCollectAndroidID(bool isCollect) { }

	// RVA: 0x16F6C64 Offset: 0x16F2C64 VA: 0x16F6C64 Slot: 12
	public void setCollectIMEI(bool isCollect) { }

	// RVA: 0x16F6D94 Offset: 0x16F2D94 VA: 0x16F6D94 Slot: 34
	public void setResolveDeepLinkURLs(string[] urls) { }

	// RVA: 0x16F6E84 Offset: 0x16F2E84 VA: 0x16F6E84 Slot: 35
	public void setOneLinkCustomDomain(string[] domains) { }

	// RVA: 0x16F6F74 Offset: 0x16F2F74 VA: 0x16F6F74 Slot: 13
	public void setIsUpdate(bool isUpdate) { }

	// RVA: 0x16F70A4 Offset: 0x16F30A4 VA: 0x16F70A4 Slot: 36
	public void setCurrencyCode(string currencyCode) { }

	// RVA: 0x16F7194 Offset: 0x16F3194 VA: 0x16F7194 Slot: 37
	public void recordLocation(double latitude, double longitude) { }

	// RVA: 0x16F7314 Offset: 0x16F3314 VA: 0x16F7314
	public void sendEvent(string eventName, Dictionary<string, string> eventValues) { }

	// RVA: 0x16F7388 Offset: 0x16F3388 VA: 0x16F7388 Slot: 26
	public void sendEvent(string eventName, Dictionary<string, string> eventValues, bool shouldCallback, string callBackObjectName) { }

	// RVA: 0x16F756C Offset: 0x16F356C VA: 0x16F756C Slot: 38
	public void anonymizeUser(bool isDisabled) { }

	// RVA: 0x16F769C Offset: 0x16F369C VA: 0x16F769C Slot: 40
	public void enableTCFDataCollection(bool shouldCollectTcfData) { }

	// RVA: 0x16F77CC Offset: 0x16F37CC VA: 0x16F77CC
	public void enableFacebookDeferredApplinks(bool isEnabled) { }

	// RVA: 0x16F78FC Offset: 0x16F38FC VA: 0x16F78FC Slot: 41
	public void setConsentData(AppsFlyerConsent appsFlyerConsent) { }

	// RVA: 0x16F7C38 Offset: 0x16F3C38 VA: 0x16F7C38 Slot: 42
	public void logAdRevenue(AFAdRevenueData adRevenueData, Dictionary<string, string> additionalParameters) { }

	// RVA: 0x16F80C8 Offset: 0x16F40C8 VA: 0x16F80C8
	public void setConsumeAFDeepLinks(bool doConsume) { }

	// RVA: 0x16F81F8 Offset: 0x16F41F8 VA: 0x16F81F8 Slot: 14
	public void setPreinstallAttribution(string mediaSource, string campaign, string siteId) { }

	// RVA: 0x16F8360 Offset: 0x16F4360 VA: 0x16F8360 Slot: 15
	public bool isPreInstalledApp() { }

	// RVA: 0x16F8458 Offset: 0x16F4458 VA: 0x16F8458 Slot: 16
	public string getAttributionId() { }

	// RVA: 0x16F8550 Offset: 0x16F4550 VA: 0x16F8550 Slot: 39
	public string getAppsFlyerId() { }

	// RVA: 0x16F8648 Offset: 0x16F4648 VA: 0x16F8648 Slot: 18
	public void validateAndSendInAppPurchase(string publicKey, string signature, string purchaseData, string price, string currency, Dictionary<string, string> additionalParameters, MonoBehaviour gameObject) { }

	// RVA: 0x16F88FC Offset: 0x16F48FC VA: 0x16F88FC Slot: 19
	public void validateAndSendInAppPurchase(AFPurchaseDetailsAndroid details, Dictionary<string, string> purchaseAdditionalDetails, MonoBehaviour gameObject) { }

	// RVA: 0x16F8B6C Offset: 0x16F4B6C VA: 0x16F8B6C Slot: 28
	public bool isSDKStopped() { }

	// RVA: 0x16F8C64 Offset: 0x16F4C64 VA: 0x16F8C64 Slot: 43
	public void setMinTimeBetweenSessions(int seconds) { }

	// RVA: 0x16F8D88 Offset: 0x16F4D88 VA: 0x16F8D88 Slot: 44
	public void setHost(string hostPrefixName, string hostName) { }

	// RVA: 0x16F8EB8 Offset: 0x16F4EB8 VA: 0x16F8EB8
	public string getHostName() { }

	// RVA: 0x16F8FB0 Offset: 0x16F4FB0 VA: 0x16F8FB0
	public string getHostPrefix() { }

	// RVA: 0x16F90A8 Offset: 0x16F50A8 VA: 0x16F90A8 Slot: 46
	public void setSharingFilterForAllPartners() { }

	// RVA: 0x16F918C Offset: 0x16F518C VA: 0x16F918C Slot: 47
	public void setSharingFilter(string[] partners) { }

	// RVA: 0x16F141C Offset: 0x16ED41C VA: 0x16F141C
	public static void setSharingFilterForPartners(string[] partners) { }

	// RVA: 0x16F927C Offset: 0x16F527C VA: 0x16F927C Slot: 48
	public void getConversionData(string objectName) { }

	// RVA: 0x16F936C Offset: 0x16F536C VA: 0x16F936C
	public void initInAppPurchaseValidatorListener(MonoBehaviour gameObject) { }

	// RVA: 0x16F94BC Offset: 0x16F54BC VA: 0x16F94BC Slot: 20
	public void setCollectOaid(bool isCollect) { }

	// RVA: 0x16F95EC Offset: 0x16F55EC VA: 0x16F95EC Slot: 49
	public void attributeAndOpenStore(string promoted_app_id, string campaign, Dictionary<string, string> userParams, MonoBehaviour gameObject) { }

	// RVA: 0x16F9760 Offset: 0x16F5760 VA: 0x16F9760 Slot: 50
	public void recordCrossPromoteImpression(string appID, string campaign, Dictionary<string, string> parameters) { }

	// RVA: 0x16F98D4 Offset: 0x16F58D4 VA: 0x16F98D4 Slot: 51
	public void generateUserInviteLink(Dictionary<string, string> parameters, MonoBehaviour gameObject) { }

	// RVA: 0x16F9A68 Offset: 0x16F5A68 VA: 0x16F9A68 Slot: 17
	public void handlePushNotifications() { }

	// RVA: 0x16F9B4C Offset: 0x16F5B4C VA: 0x16F9B4C Slot: 52
	public void addPushNotificationDeepLinkPath(string[] paths) { }

	// RVA: 0x16F9C3C Offset: 0x16F5C3C VA: 0x16F9C3C Slot: 54
	public void subscribeForDeepLink(string objectName) { }

	// RVA: 0x16F9D2C Offset: 0x16F5D2C VA: 0x16F9D2C Slot: 21
	public void setDisableAdvertisingIdentifiers(bool disable) { }

	// RVA: 0x16F9E5C Offset: 0x16F5E5C VA: 0x16F9E5C Slot: 56
	public void setPartnerData(string partnerId, Dictionary<string, string> partnerInfo) { }

	// RVA: 0x16F9F98 Offset: 0x16F5F98 VA: 0x16F9F98 Slot: 22
	public void setDisableNetworkData(bool disable) { }

	// RVA: 0x16F6A68 Offset: 0x16F2A68 VA: 0x16F6A68
	private static AndroidJavaObject getEmailType(EmailCryptType cryptType) { }

	// RVA: 0x16F7E60 Offset: 0x16F3E60 VA: 0x16F7E60
	private static AndroidJavaObject getMediationNetwork(MediationNetwork mediationNetwork) { }

	// RVA: 0x16F6278 Offset: 0x16F2278 VA: 0x16F6278
	private static AndroidJavaObject convertDictionaryToJavaMap(Dictionary<string, string> dictionary) { }

	// RVA: 0x16FA0C8 Offset: 0x16F60C8 VA: 0x16FA0C8
	private static void .cctor() { }
}
