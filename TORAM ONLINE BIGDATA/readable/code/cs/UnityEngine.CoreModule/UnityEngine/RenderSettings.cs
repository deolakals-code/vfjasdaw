// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[StaticAccessor("GetRenderSettings()", 0)]
[NativeHeader("Runtime/Camera/RenderSettings.h")]
[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
public sealed class RenderSettings : Object // TypeDefIndex: 16249
{
	// Properties
	[NativeProperty("UseFog")]
	public static bool fog { get; set; }
	[NativeProperty("LinearFogStart")]
	public static float fogStartDistance { get; set; }
	[NativeProperty("LinearFogEnd")]
	public static float fogEndDistance { get; set; }
	public static FogMode fogMode { get; set; }
	public static Color fogColor { get; set; }
	public static float fogDensity { get; set; }
	[NativeProperty("AmbientSkyColor")]
	public static Color ambientLight { get; set; }

	// Methods

	// RVA: 0x37D5758 Offset: 0x37D1758 VA: 0x37D5758
	public static bool get_fog() { }

	// RVA: 0x37D5780 Offset: 0x37D1780 VA: 0x37D5780
	public static void set_fog(bool value) { }

	// RVA: 0x37D57BC Offset: 0x37D17BC VA: 0x37D57BC
	public static float get_fogStartDistance() { }

	// RVA: 0x37D57E4 Offset: 0x37D17E4 VA: 0x37D57E4
	public static void set_fogStartDistance(float value) { }

	// RVA: 0x37D581C Offset: 0x37D181C VA: 0x37D581C
	public static float get_fogEndDistance() { }

	// RVA: 0x37D5844 Offset: 0x37D1844 VA: 0x37D5844
	public static void set_fogEndDistance(float value) { }

	// RVA: 0x37D587C Offset: 0x37D187C VA: 0x37D587C
	public static FogMode get_fogMode() { }

	// RVA: 0x37D58A4 Offset: 0x37D18A4 VA: 0x37D58A4
	public static void set_fogMode(FogMode value) { }

	// RVA: 0x37D58E0 Offset: 0x37D18E0 VA: 0x37D58E0
	public static Color get_fogColor() { }

	// RVA: 0x37D5964 Offset: 0x37D1964 VA: 0x37D5964
	public static void set_fogColor(Color value) { }

	// RVA: 0x37D59E4 Offset: 0x37D19E4 VA: 0x37D59E4
	public static float get_fogDensity() { }

	// RVA: 0x37D5A0C Offset: 0x37D1A0C VA: 0x37D5A0C
	public static void set_fogDensity(float value) { }

	// RVA: 0x37D5A44 Offset: 0x37D1A44 VA: 0x37D5A44
	public static Color get_ambientLight() { }

	// RVA: 0x37D5AC8 Offset: 0x37D1AC8 VA: 0x37D5AC8
	public static void set_ambientLight(Color value) { }

	// RVA: 0x37D5928 Offset: 0x37D1928 VA: 0x37D5928
	private static void get_fogColor_Injected(out Color ret) { }

	// RVA: 0x37D59A8 Offset: 0x37D19A8 VA: 0x37D59A8
	private static void set_fogColor_Injected(ref Color value) { }

	// RVA: 0x37D5A8C Offset: 0x37D1A8C VA: 0x37D5A8C
	private static void get_ambientLight_Injected(out Color ret) { }

	// RVA: 0x37D5B0C Offset: 0x37D1B0C VA: 0x37D5B0C
	private static void set_ambientLight_Injected(ref Color value) { }
}
