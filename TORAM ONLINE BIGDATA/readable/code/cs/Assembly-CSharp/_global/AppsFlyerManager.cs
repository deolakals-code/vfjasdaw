// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AppsFlyerManager : MonoBehaviour, IAppsFlyerConversionData // TypeDefIndex: 5430
{
	// Properties
	public static bool IsEnableAF { get; }

	// Methods

	// RVA: 0x1766C40 Offset: 0x1762C40 VA: 0x1766C40
	public static bool get_IsEnableAF() { }

	// RVA: 0x1766C48 Offset: 0x1762C48 VA: 0x1766C48
	private void Awake() { }

	// RVA: 0x1766CF0 Offset: 0x1762CF0 VA: 0x1766CF0
	private void Start() { }

	// RVA: 0x1766CF4 Offset: 0x1762CF4 VA: 0x1766CF4
	private void InitAppsFlyer() { }

	// RVA: 0x1766D84 Offset: 0x1762D84 VA: 0x1766D84
	public static void SendEvent(string eventName, Dictionary<string, string> eventValues) { }

	// RVA: 0x1766DEC Offset: 0x1762DEC VA: 0x1766DEC Slot: 4
	public void onConversionDataSuccess(string conversionData) { }

	// RVA: 0x1766E68 Offset: 0x1762E68 VA: 0x1766E68 Slot: 5
	public void onConversionDataFail(string error) { }

	// RVA: 0x1766ED8 Offset: 0x1762ED8 VA: 0x1766ED8 Slot: 6
	public void onAppOpenAttribution(string attributionData) { }

	// RVA: 0x1766F54 Offset: 0x1762F54 VA: 0x1766F54 Slot: 7
	public void onAppOpenAttributionFailure(string error) { }

	// RVA: 0x1766FC4 Offset: 0x1762FC4 VA: 0x1766FC4
	public void .ctor() { }
}
