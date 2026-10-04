// Assembly: UnityEngine.UnityAnalyticsModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[ExcludeFromDocs]
public class RemoteConfigSettings // TypeDefIndex: 17858
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<bool> Updated; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3823B24 Offset: 0x381FB24 VA: 0x3823B24
	internal static void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, bool wasLastUpdatedFromServer) { }
}
