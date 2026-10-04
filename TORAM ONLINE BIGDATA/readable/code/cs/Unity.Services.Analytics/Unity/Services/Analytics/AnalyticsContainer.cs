// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics
internal class AnalyticsContainer : MonoBehaviour, IAnalyticsContainer, IContainerDebug // TypeDefIndex: 17439
{
	// Fields
	private const float k_AutoFlushPeriod = 60;
	private const float k_GameRunningPeriod = 60;
	private static bool s_Created; // 0x0
	private static GameObject s_Container; // 0x8
	private static AnalyticsContainer m_Instance; // 0x10
	private float m_AutoFlushTime; // 0x20
	private float m_GameRunningTime; // 0x24
	private AnalyticsServiceInstance m_Service; // 0x28

	// Properties
	private float AutoFlushPeriod { get; }
	internal static IContainerDebug ContainerDebug { get; }
	public float TimeUntilNextHeartbeat { get; }

	// Methods

	// RVA: 0x37A0A4C Offset: 0x379CA4C VA: 0x37A0A4C
	private float get_AutoFlushPeriod() { }

	// RVA: 0x37A0A78 Offset: 0x379CA78 VA: 0x37A0A78
	internal static IContainerDebug get_ContainerDebug() { }

	// RVA: 0x37A0AC0 Offset: 0x379CAC0 VA: 0x37A0AC0 Slot: 6
	public float get_TimeUntilNextHeartbeat() { }

	// RVA: 0x379D090 Offset: 0x3799090 VA: 0x379D090
	internal static AnalyticsContainer CreateContainer() { }

	// RVA: 0x379D8B4 Offset: 0x37998B4 VA: 0x379D8B4 Slot: 7
	public void Initialize(AnalyticsServiceInstance service) { }

	// RVA: 0x37A0ADC Offset: 0x379CADC VA: 0x37A0ADC Slot: 4
	public void Enable() { }

	// RVA: 0x37A0AE8 Offset: 0x379CAE8 VA: 0x37A0AE8 Slot: 5
	public void Disable() { }

	// RVA: 0x37A0B08 Offset: 0x379CB08 VA: 0x37A0B08
	private void Update() { }

	// RVA: 0x37A0B8C Offset: 0x379CB8C VA: 0x37A0B8C
	private void OnApplicationPause(bool paused) { }

	// RVA: 0x37A0BA8 Offset: 0x379CBA8 VA: 0x37A0BA8
	private void CleanUp() { }

	// RVA: 0x37A0CA8 Offset: 0x379CCA8 VA: 0x37A0CA8
	public void .ctor() { }
}
