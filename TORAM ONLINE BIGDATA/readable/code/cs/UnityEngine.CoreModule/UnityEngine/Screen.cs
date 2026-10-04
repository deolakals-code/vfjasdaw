// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/WindowLayout.h")]
[StaticAccessor("GetScreenManager()", 0)]
[NativeHeader("Runtime/Graphics/ScreenManager.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
public sealed class Screen // TypeDefIndex: 16239
{
	// Properties
	public static int width { get; }
	public static int height { get; }
	public static float dpi { get; }
	[NativeProperty("ScreenTimeout")]
	public static int sleepTimeout { set; }

	// Methods

	[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
	// RVA: 0x37D40D8 Offset: 0x37D00D8 VA: 0x37D40D8
	public static int get_width() { }

	[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
	// RVA: 0x37D4100 Offset: 0x37D0100 VA: 0x37D4100
	public static int get_height() { }

	[NativeName("GetDPI")]
	// RVA: 0x37D4128 Offset: 0x37D0128 VA: 0x37D4128
	public static float get_dpi() { }

	// RVA: 0x37D4150 Offset: 0x37D0150 VA: 0x37D4150
	public static void set_sleepTimeout(int value) { }
}
