// Assembly: Firebase.Platform.dll
// Namespace: Firebase.Platform
internal static class PlatformInformation // TypeDefIndex: 17752
{
	// Fields
	private static string runtimeVersion; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static float <RealtimeSinceStartupSafe>k__BackingField; // 0x8

	// Properties
	internal static bool IsAndroid { get; }
	internal static bool IsIOS { get; }
	internal static string DefaultConfigLocation { get; }
	internal static float RealtimeSinceStartup { get; }
	internal static float RealtimeSinceStartupSafe { set; }
	internal static string RuntimeName { get; }
	internal static string RuntimeVersion { get; }

	// Methods

	// RVA: 0x266B480 Offset: 0x2667480 VA: 0x266B480
	internal static bool get_IsAndroid() { }

	// RVA: 0x266B4DC Offset: 0x26674DC VA: 0x266B4DC
	internal static bool get_IsIOS() { }

	// RVA: 0x266B560 Offset: 0x2667560 VA: 0x266B560
	internal static string get_DefaultConfigLocation() { }

	// RVA: 0x266B674 Offset: 0x2667674 VA: 0x266B674
	internal static float get_RealtimeSinceStartup() { }

	[CompilerGenerated]
	// RVA: 0x266B67C Offset: 0x266767C VA: 0x266B67C
	internal static void set_RealtimeSinceStartupSafe(float value) { }

	// RVA: 0x266B6D0 Offset: 0x26676D0 VA: 0x266B6D0
	internal static string get_RuntimeName() { }

	// RVA: 0x266B710 Offset: 0x2667710 VA: 0x266B710
	internal static string get_RuntimeVersion() { }
}
