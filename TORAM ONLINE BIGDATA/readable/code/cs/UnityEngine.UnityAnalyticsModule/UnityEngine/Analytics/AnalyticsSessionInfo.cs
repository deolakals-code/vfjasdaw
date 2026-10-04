// Assembly: UnityEngine.UnityAnalyticsModule.dll
// Namespace: UnityEngine.Analytics
[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
[RequiredByNativeCode]
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
public static class AnalyticsSessionInfo // TypeDefIndex: 17865
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static AnalyticsSessionInfo.SessionStateChanged sessionStateChanged; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3823B58 Offset: 0x381FB58 VA: 0x3823B58
	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	[RequiredByNativeCode]
	// RVA: 0x3823BF4 Offset: 0x381FBF4 VA: 0x3823BF4
	internal static void CallIdentityTokenChanged(string token) { }
}
