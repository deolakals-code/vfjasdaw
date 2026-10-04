// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics
public static class AnalyticsService // TypeDefIndex: 17431
{
	// Fields
	private static AnalyticsServiceInstance m_Instance; // 0x0
	private static IDispatcherDebug m_DispatcherDebug; // 0x8
	private static IBufferDebug m_BufferDebug; // 0x10
	private static Action<string, string, DateTime, byte[]> m_EventRecordedCallback; // 0x18
	private static Action<HashSet<string>> m_EventsClearingCallback; // 0x20
	private static Action<byte[]> m_FlushStartedCallback; // 0x28
	private static Action<int, bool, bool, bool, bool, byte[]> m_FlushCompletedCallback; // 0x30

	// Methods

	// RVA: 0x379B85C Offset: 0x379785C VA: 0x379B85C
	internal static void Initialize(CoreRegistry registry) { }

	// RVA: 0x379DA04 Offset: 0x3799A04 VA: 0x379DA04
	internal static void TearDown() { }
}
