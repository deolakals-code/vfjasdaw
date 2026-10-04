// Assembly: UnityEngine.UnityAnalyticsModule.dll
// Namespace: UnityEngine
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
public static class RemoteSettings // TypeDefIndex: 17857
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static RemoteSettings.UpdatedEventHandler Updated; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action BeforeFetchFromServer; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<bool, bool, int> Completed; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3823924 Offset: 0x381F924 VA: 0x3823924
	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

	[RequiredByNativeCode]
	// RVA: 0x3823988 Offset: 0x381F988 VA: 0x3823988
	internal static void RemoteSettingsBeforeFetchFromServer() { }

	[RequiredByNativeCode]
	// RVA: 0x38239EC Offset: 0x381F9EC VA: 0x38239EC
	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }
}
