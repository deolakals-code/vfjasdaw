// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Utilities/PlayerPrefs.h")]
public class PlayerPrefs // TypeDefIndex: 16315
{
	// Methods

	[NativeMethod("SetInt")]
	// RVA: 0x37E8E74 Offset: 0x37E4E74 VA: 0x37E8E74
	private static bool TrySetInt(string key, int value) { }

	[NativeMethod("SetFloat")]
	// RVA: 0x37E8EB8 Offset: 0x37E4EB8 VA: 0x37E8EB8
	private static bool TrySetFloat(string key, float value) { }

	[NativeMethod("SetString")]
	// RVA: 0x37E8F04 Offset: 0x37E4F04 VA: 0x37E8F04
	private static bool TrySetSetString(string key, string value) { }

	// RVA: 0x37E8F48 Offset: 0x37E4F48 VA: 0x37E8F48
	public static void SetInt(string key, int value) { }

	// RVA: 0x37E8FD8 Offset: 0x37E4FD8 VA: 0x37E8FD8
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x37E901C Offset: 0x37E501C VA: 0x37E901C
	public static int GetInt(string key) { }

	// RVA: 0x37E905C Offset: 0x37E505C VA: 0x37E905C
	public static void SetFloat(string key, float value) { }

	// RVA: 0x37E90F4 Offset: 0x37E50F4 VA: 0x37E90F4
	public static float GetFloat(string key, float defaultValue) { }

	// RVA: 0x37E9140 Offset: 0x37E5140 VA: 0x37E9140
	public static void SetString(string key, string value) { }

	// RVA: 0x37E91D0 Offset: 0x37E51D0 VA: 0x37E91D0
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x37E9214 Offset: 0x37E5214 VA: 0x37E9214
	public static string GetString(string key) { }

	// RVA: 0x37E9280 Offset: 0x37E5280 VA: 0x37E9280
	public static bool HasKey(string key) { }

	// RVA: 0x37E92BC Offset: 0x37E52BC VA: 0x37E92BC
	public static void DeleteKey(string key) { }

	[NativeMethod("Sync")]
	// RVA: 0x37E92F8 Offset: 0x37E52F8 VA: 0x37E92F8
	public static void Save() { }
}
