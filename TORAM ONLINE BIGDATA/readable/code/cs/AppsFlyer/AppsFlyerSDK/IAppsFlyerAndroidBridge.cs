// Assembly: AppsFlyer.dll
// Namespace: AppsFlyerSDK
public interface IAppsFlyerAndroidBridge : IAppsFlyerNativeBridge // TypeDefIndex: 17301
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void updateServerUninstallToken(string token);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void setImeiData(string imei);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void setAndroidIdData(string androidId);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void waitForCustomerUserId(bool wait);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void setCustomerIdAndStartSDK(string id);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string getOutOfStore();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void setOutOfStore(string sourceName);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void setCollectAndroidID(bool isCollect);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void setCollectIMEI(bool isCollect);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void setIsUpdate(bool isUpdate);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void setPreinstallAttribution(string mediaSource, string campaign, string siteId);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool isPreInstalledApp();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string getAttributionId();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void handlePushNotifications();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void validateAndSendInAppPurchase(string publicKey, string signature, string purchaseData, string price, string currency, Dictionary<string, string> additionalParameters, MonoBehaviour gameObject);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void validateAndSendInAppPurchase(AFPurchaseDetailsAndroid details, Dictionary<string, string> purchaseAdditionalDetails, MonoBehaviour gameObject);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void setCollectOaid(bool isCollect);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void setDisableAdvertisingIdentifiers(bool disable);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void setDisableNetworkData(bool disable);
}
