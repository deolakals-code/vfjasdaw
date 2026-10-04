// Assembly: mscorlib.dll
// Namespace: System
public static class AppContext // TypeDefIndex: 9733
{
	// Fields
	private static readonly Dictionary<string, AppContext.SwitchValueState> s_switchMap; // 0x0
	private static bool s_defaultsInitialized; // 0x8

	// Methods

	// RVA: 0x300D4F4 Offset: 0x30094F4 VA: 0x300D4F4
	private static void InitializeDefaultSwitchValues() { }

	// RVA: 0x300D668 Offset: 0x3009668 VA: 0x300D668
	public static bool TryGetSwitch(string switchName, out bool isEnabled) { }

	// RVA: 0x300DA70 Offset: 0x3009A70 VA: 0x300DA70
	private static void .cctor() { }
}
