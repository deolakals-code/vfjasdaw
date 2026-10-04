// Assembly: Unity.Services.Core.Device.dll
// Namespace: Unity.Services.Core.Device
internal static class AndroidUtils // TypeDefIndex: 17912
{
	// Methods

	// RVA: 0x37A9E38 Offset: 0x37A5E38 VA: 0x37A9E38
	public static AndroidJavaObject GetUnityActivity() { }

	// RVA: 0x37AA018 Offset: 0x37A6018 VA: 0x37AA018
	public static AndroidJavaObject GetSharedPreferences(AndroidJavaObject context, string name, int mode = 0) { }

	// RVA: 0x37AA164 Offset: 0x37A6164 VA: 0x37AA164
	public static AndroidJavaObject GetSharedPreferences(string name, int mode = 0) { }

	// RVA: 0x37AA2E0 Offset: 0x37A62E0 VA: 0x37AA2E0
	public static string SharedPreferencesGetString(string name, string key, string defValue = "") { }

	// RVA: 0x37AA468 Offset: 0x37A6468 VA: 0x37AA468
	public static string SharedPreferencesGetString(AndroidJavaObject preferences, string key, string defValue = "") { }

	// RVA: 0x37AA6B8 Offset: 0x37A66B8 VA: 0x37AA6B8
	public static void SharedPreferencesPutString(string name, string key, string value) { }

	// RVA: 0x37AA830 Offset: 0x37A6830 VA: 0x37AA830
	public static void SharedPreferencesPutString(AndroidJavaObject preferences, string key, string value) { }
}
