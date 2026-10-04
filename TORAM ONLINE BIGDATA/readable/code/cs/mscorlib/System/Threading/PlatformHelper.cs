// Assembly: mscorlib.dll
// Namespace: System.Threading
internal static class PlatformHelper // TypeDefIndex: 9875
{
	// Fields
	private static int s_processorCount; // 0x0
	private static int s_lastProcessorCountRefreshTicks; // 0x4
	internal static readonly bool IsSingleProcessor; // 0x8

	// Properties
	internal static int ProcessorCount { get; }

	// Methods

	// RVA: 0x3049C04 Offset: 0x3045C04 VA: 0x3049C04
	internal static int get_ProcessorCount() { }

	// RVA: 0x3049CF0 Offset: 0x3045CF0 VA: 0x3049CF0
	private static void .cctor() { }
}
