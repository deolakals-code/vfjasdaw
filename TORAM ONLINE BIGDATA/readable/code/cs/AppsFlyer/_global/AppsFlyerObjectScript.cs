// Assembly: AppsFlyer.dll
// Namespace: 
public class AppsFlyerObjectScript : MonoBehaviour, IAppsFlyerConversionData // TypeDefIndex: 17246
{
	// Fields
	public string devKey; // 0x20
	public string appID; // 0x28
	public string UWPAppID; // 0x30
	public string macOSAppID; // 0x38
	public bool isDebug; // 0x40
	public bool getConversionData; // 0x41

	// Methods

	// RVA: 0x16EC6B0 Offset: 0x16E86B0 VA: 0x16EC6B0
	private void Start() { }

	// RVA: 0x16ECC0C Offset: 0x16E8C0C VA: 0x16ECC0C
	private void Update() { }

	// RVA: 0x16ECC10 Offset: 0x16E8C10 VA: 0x16ECC10 Slot: 4
	public void onConversionDataSuccess(string conversionData) { }

	// RVA: 0x16ECDCC Offset: 0x16E8DCC VA: 0x16ECDCC Slot: 5
	public void onConversionDataFail(string error) { }

	// RVA: 0x16ECE38 Offset: 0x16E8E38 VA: 0x16ECE38 Slot: 6
	public void onAppOpenAttribution(string attributionData) { }

	// RVA: 0x16ECEAC Offset: 0x16E8EAC VA: 0x16ECEAC Slot: 7
	public void onAppOpenAttributionFailure(string error) { }

	// RVA: 0x16ECF18 Offset: 0x16E8F18 VA: 0x16ECF18
	public void .ctor() { }
}
