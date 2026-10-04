// Assembly: AppsFlyer.dll
// Namespace: AppsFlyerSDK
public interface IAppsFlyerIOSBridge : IAppsFlyerNativeBridge // TypeDefIndex: 17303
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void setDisableCollectAppleAdSupport(bool disable);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void setShouldCollectDeviceName(bool shouldCollectDeviceName);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void setDisableCollectIAd(bool disableCollectIAd);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void setUseReceiptValidationSandbox(bool useReceiptValidationSandbox);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void setUseUninstallSandbox(bool useUninstallSandbox);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void validateAndSendInAppPurchase(string productIdentifier, string price, string currency, string transactionId, Dictionary<string, string> additionalParameters, MonoBehaviour gameObject);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void validateAndSendInAppPurchase(AFSDKPurchaseDetailsIOS details, Dictionary<string, string> purchaseAdditionalDetails, MonoBehaviour gameObject);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void registerUninstall(byte[] deviceToken);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void handleOpenUrl(string url, string sourceApplication, string annotation);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void waitForATTUserAuthorizationWithTimeoutInterval(int timeoutInterval);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void setCurrentDeviceLanguage(string language);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void disableSKAdNetwork(bool isDisabled);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void disableIDFVCollection(bool isDisabled);
}
