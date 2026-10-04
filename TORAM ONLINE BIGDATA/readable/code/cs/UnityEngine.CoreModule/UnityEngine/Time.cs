// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[StaticAccessor("GetTimeManager()", 0)]
[NativeHeader("Runtime/Input/TimeManager.h")]
public class Time // TypeDefIndex: 16395
{
	// Properties
	[NativeProperty("CurTime")]
	public static float time { get; }
	public static float deltaTime { get; }
	public static float fixedUnscaledTime { get; }
	public static float unscaledDeltaTime { get; }
	public static float timeScale { get; set; }
	[NativeProperty("Realtime")]
	public static float realtimeSinceStartup { get; }

	// Methods

	// RVA: 0x37F1B94 Offset: 0x37EDB94 VA: 0x37F1B94
	public static float get_time() { }

	// RVA: 0x37F1BBC Offset: 0x37EDBBC VA: 0x37F1BBC
	public static float get_deltaTime() { }

	// RVA: 0x37F1BE4 Offset: 0x37EDBE4 VA: 0x37F1BE4
	public static float get_fixedUnscaledTime() { }

	// RVA: 0x37F1C0C Offset: 0x37EDC0C VA: 0x37F1C0C
	public static float get_unscaledDeltaTime() { }

	// RVA: 0x37F1C34 Offset: 0x37EDC34 VA: 0x37F1C34
	public static float get_timeScale() { }

	// RVA: 0x37F1C5C Offset: 0x37EDC5C VA: 0x37F1C5C
	public static void set_timeScale(float value) { }

	// RVA: 0x37F1C94 Offset: 0x37EDC94 VA: 0x37F1C94
	public static float get_realtimeSinceStartup() { }
}
