// Assembly: Firebase.App.dll
// Namespace: Firebase
internal class AppUtil // TypeDefIndex: 17237
{
	// Methods

	// RVA: 0x2660D7C Offset: 0x265CD7C VA: 0x2660D7C
	internal static void PollCallbacks() { }

	// RVA: 0x2651E7C Offset: 0x264DE7C VA: 0x2651E7C
	internal static void AppEnableLogCallback(bool arg0) { }

	// RVA: 0x265D1E4 Offset: 0x26591E4 VA: 0x265D1E4
	internal static void SetEnabledAllAppCallbacks(bool arg0) { }

	// RVA: 0x265D358 Offset: 0x2659358 VA: 0x265D358
	internal static void SetEnabledAppCallbackByName(string arg0, bool arg1) { }

	// RVA: 0x265D298 Offset: 0x2659298 VA: 0x265D298
	internal static bool GetEnabledAppCallbackByName(string arg0) { }

	// RVA: 0x265206C Offset: 0x264E06C VA: 0x265206C
	internal static void SetLogFunction(LogUtil.LogMessageDelegate arg0) { }

	// RVA: 0x265E374 Offset: 0x265A374 VA: 0x265E374
	public static GooglePlayServicesAvailability CheckAndroidDependencies() { }

	// RVA: 0x265F248 Offset: 0x265B248 VA: 0x265F248
	public static Task FixAndroidDependenciesAsync() { }

	// RVA: 0x265E6D0 Offset: 0x265A6D0 VA: 0x265E6D0
	internal static void InitializePlayServicesInternal() { }

	// RVA: 0x265E7E4 Offset: 0x265A7E4 VA: 0x265E7E4
	internal static void TerminatePlayServicesInternal() { }
}
