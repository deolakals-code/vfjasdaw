// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
public sealed class SystemInfo // TypeDefIndex: 16394
{
	// Properties
	[NativeProperty]
	public static float batteryLevel { get; }
	public static string operatingSystem { get; }
	public static OperatingSystemFamily operatingSystemFamily { get; }
	public static string processorType { get; }
	public static int processorCount { get; }
	public static int systemMemorySize { get; }
	public static string deviceUniqueIdentifier { get; }
	public static string deviceName { get; }
	public static string deviceModel { get; }
	public static DeviceType deviceType { get; }
	public static string graphicsDeviceName { get; }
	public static int graphicsShaderLevel { get; }

	// Methods

	// RVA: 0x37F1588 Offset: 0x37ED588 VA: 0x37F1588
	public static float get_batteryLevel() { }

	// RVA: 0x37F15D8 Offset: 0x37ED5D8 VA: 0x37F15D8
	public static string get_operatingSystem() { }

	// RVA: 0x37F1628 Offset: 0x37ED628 VA: 0x37F1628
	public static OperatingSystemFamily get_operatingSystemFamily() { }

	// RVA: 0x37F1678 Offset: 0x37ED678 VA: 0x37F1678
	public static string get_processorType() { }

	// RVA: 0x37F16C8 Offset: 0x37ED6C8 VA: 0x37F16C8
	public static int get_processorCount() { }

	// RVA: 0x37F1718 Offset: 0x37ED718 VA: 0x37F1718
	public static int get_systemMemorySize() { }

	// RVA: 0x37F1768 Offset: 0x37ED768 VA: 0x37F1768
	public static string get_deviceUniqueIdentifier() { }

	// RVA: 0x37F17B8 Offset: 0x37ED7B8 VA: 0x37F17B8
	public static string get_deviceName() { }

	// RVA: 0x37F1808 Offset: 0x37ED808 VA: 0x37F1808
	public static string get_deviceModel() { }

	// RVA: 0x37F1858 Offset: 0x37ED858 VA: 0x37F1858
	public static DeviceType get_deviceType() { }

	// RVA: 0x37F18A8 Offset: 0x37ED8A8 VA: 0x37F18A8
	public static string get_graphicsDeviceName() { }

	// RVA: 0x37F18F8 Offset: 0x37ED8F8 VA: 0x37F18F8
	public static int get_graphicsShaderLevel() { }

	// RVA: 0x37F1948 Offset: 0x37ED948 VA: 0x37F1948
	private static bool IsValidEnumValue(Enum value) { }

	// RVA: 0x37F19C0 Offset: 0x37ED9C0 VA: 0x37F19C0
	public static bool SupportsTextureFormat(TextureFormat format) { }

	[FreeFunction("systeminfo::GetBatteryLevel")]
	// RVA: 0x37F15B0 Offset: 0x37ED5B0 VA: 0x37F15B0
	private static float GetBatteryLevel() { }

	[FreeFunction("systeminfo::GetOperatingSystem")]
	// RVA: 0x37F1600 Offset: 0x37ED600 VA: 0x37F1600
	private static string GetOperatingSystem() { }

	[FreeFunction("systeminfo::GetOperatingSystemFamily")]
	// RVA: 0x37F1650 Offset: 0x37ED650 VA: 0x37F1650
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunction("systeminfo::GetProcessorType")]
	// RVA: 0x37F16A0 Offset: 0x37ED6A0 VA: 0x37F16A0
	private static string GetProcessorType() { }

	[FreeFunction("systeminfo::GetProcessorCount")]
	// RVA: 0x37F16F0 Offset: 0x37ED6F0 VA: 0x37F16F0
	private static int GetProcessorCount() { }

	[FreeFunction("systeminfo::GetPhysicalMemoryMB")]
	// RVA: 0x37F1740 Offset: 0x37ED740 VA: 0x37F1740
	private static int GetPhysicalMemoryMB() { }

	[FreeFunction("systeminfo::GetDeviceUniqueIdentifier")]
	// RVA: 0x37F1790 Offset: 0x37ED790 VA: 0x37F1790
	private static string GetDeviceUniqueIdentifier() { }

	[FreeFunction("systeminfo::GetDeviceName")]
	// RVA: 0x37F17E0 Offset: 0x37ED7E0 VA: 0x37F17E0
	private static string GetDeviceName() { }

	[FreeFunction("systeminfo::GetDeviceModel")]
	// RVA: 0x37F1830 Offset: 0x37ED830 VA: 0x37F1830
	private static string GetDeviceModel() { }

	[FreeFunction("systeminfo::GetDeviceType")]
	// RVA: 0x37F1880 Offset: 0x37ED880 VA: 0x37F1880
	private static DeviceType GetDeviceType() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceName")]
	// RVA: 0x37F18D0 Offset: 0x37ED8D0 VA: 0x37F18D0
	private static string GetGraphicsDeviceName() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsShaderLevel")]
	// RVA: 0x37F1920 Offset: 0x37ED920 VA: 0x37F1920
	private static int GetGraphicsShaderLevel() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
	// RVA: 0x37F1A94 Offset: 0x37EDA94 VA: 0x37F1A94
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
	// RVA: 0x37F1AD0 Offset: 0x37EDAD0 VA: 0x37F1AD0
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
	// RVA: 0x37F1B14 Offset: 0x37EDB14 VA: 0x37F1B14
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
	// RVA: 0x37F1B58 Offset: 0x37EDB58 VA: 0x37F1B58
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }
}
