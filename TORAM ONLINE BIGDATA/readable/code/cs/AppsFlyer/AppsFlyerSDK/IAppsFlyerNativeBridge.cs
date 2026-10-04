// Assembly: AppsFlyer.dll
// Namespace: AppsFlyerSDK
public interface IAppsFlyerNativeBridge // TypeDefIndex: 17304
{
	// Properties
	public abstract bool isInit { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_isInit();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_isInit(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void startSDK(bool onRequestResponse, string CallBackObjectName);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void sendEvent(string eventName, Dictionary<string, string> eventValues, bool onInAppResponse, string CallBackObjectName);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void stopSDK(bool isSDKStopped);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool isSDKStopped();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string getSdkVersion();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void setCustomerUserId(string id);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void setAppInviteOneLinkID(string oneLinkId);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void setAdditionalData(Dictionary<string, string> customData);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void setDeepLinkTimeout(long deepLinkTimeout);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void setResolveDeepLinkURLs(string[] urls);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void setOneLinkCustomDomain(string[] domains);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void setCurrencyCode(string currencyCode);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void recordLocation(double latitude, double longitude);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void anonymizeUser(bool shouldAnonymizeUser);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract string getAppsFlyerId();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void enableTCFDataCollection(bool shouldCollectTcfData);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void setConsentData(AppsFlyerConsent appsFlyerConsent);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void logAdRevenue(AFAdRevenueData adRevenueData, Dictionary<string, string> additionalParameters);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void setMinTimeBetweenSessions(int seconds);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void setHost(string hostPrefixName, string hostName);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void setPhoneNumber(string phoneNumber);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void setSharingFilterForAllPartners();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void setSharingFilter(string[] partners);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void getConversionData(string objectName);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void attributeAndOpenStore(string appID, string campaign, Dictionary<string, string> userParams, MonoBehaviour gameObject);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void recordCrossPromoteImpression(string appID, string campaign, Dictionary<string, string> parameters);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void generateUserInviteLink(Dictionary<string, string> parameters, MonoBehaviour gameObject);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void addPushNotificationDeepLinkPath(string[] paths);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void setUserEmails(EmailCryptType cryptType, string[] userEmails);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void subscribeForDeepLink(string objectName);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract void setIsDebug(bool shouldEnable);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void setPartnerData(string partnerId, Dictionary<string, string> partnerInfo);
}
