// Assembly: UnityEngine.UnityAnalyticsCommonModule.dll
// Namespace: UnityEngine.Analytics
[NativeHeader("Modules/UnityAnalyticsCommon/Public/UnityAnalyticsCommon.h")]
public static class AnalyticsCommon // TypeDefIndex: 17881
{
	// Properties
	[StaticAccessor("GetUnityAnalyticsCommon()", 0)]
	private static bool ugsAnalyticsEnabledInternal { set; }
	public static bool ugsAnalyticsEnabled { set; }

	// Methods

	[NativeMethod("SetUGSAnalyticsUserOptStatus")]
	// RVA: 0x3823870 Offset: 0x381F870 VA: 0x3823870
	private static void set_ugsAnalyticsEnabledInternal(bool value) { }

	// RVA: 0x38238AC Offset: 0x381F8AC VA: 0x38238AC
	public static void set_ugsAnalyticsEnabled(bool value) { }
}
