// Assembly: System.Data.dll
// Namespace: System
internal class LocalAppContext // TypeDefIndex: 14642
{
	// Fields
	private static bool s_isDisableCachingInitialized; // 0x0
	private static bool s_disableCaching; // 0x1
	private static object s_syncObject; // 0x8

	// Properties
	private static bool DisableCaching { get; }

	// Methods

	// RVA: 0x31BD490 Offset: 0x31B9490 VA: 0x31BD490
	internal static bool GetCachedSwitchValue(string switchName, ref int switchValue) { }

	// RVA: 0x31BD4B0 Offset: 0x31B94B0 VA: 0x31BD4B0
	private static bool GetCachedSwitchValueInternal(string switchName, ref int switchValue) { }

	// RVA: 0x31BD544 Offset: 0x31B9544 VA: 0x31BD544
	private static bool get_DisableCaching() { }
}
