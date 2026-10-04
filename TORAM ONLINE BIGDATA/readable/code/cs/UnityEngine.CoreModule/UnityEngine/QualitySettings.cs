// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/QualitySettings.h")]
[StaticAccessor("GetQualitySettings()", 0)]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
public sealed class QualitySettings : Object // TypeDefIndex: 16246
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<int, int> activeQualityLevelChanged; // 0x0

	// Properties
	public static ColorSpace activeColorSpace { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x37D4FD0 Offset: 0x37D0FD0 VA: 0x37D4FD0
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

	[StaticAccessor("GetPlayerSettings()", 0)]
	[NativeName("GetColorSpace")]
	// RVA: 0x37D5050 Offset: 0x37D1050 VA: 0x37D5050
	public static ColorSpace get_activeColorSpace() { }
}
