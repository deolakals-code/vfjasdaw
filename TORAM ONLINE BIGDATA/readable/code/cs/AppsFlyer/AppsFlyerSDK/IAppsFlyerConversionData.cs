// Assembly: AppsFlyer.dll
// Namespace: AppsFlyerSDK
public interface IAppsFlyerConversionData // TypeDefIndex: 17302
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void onConversionDataSuccess(string conversionData);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void onConversionDataFail(string error);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void onAppOpenAttribution(string attributionData);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void onAppOpenAttributionFailure(string error);
}
