// Assembly: mscorlib.dll
// Namespace: System
public static class GC // TypeDefIndex: 9756
{
	// Fields
	internal static readonly object EPHEMERON_TOMBSTONE; // 0x0

	// Methods

	// RVA: 0x301DF60 Offset: 0x3019F60 VA: 0x301DF60
	private static int GetCollectionCount(int generation) { }

	// RVA: 0x301DF64 Offset: 0x3019F64 VA: 0x301DF64
	internal static void register_ephemeron_array(Ephemeron[] array) { }

	// RVA: 0x301DF68 Offset: 0x3019F68 VA: 0x301DF68
	private static object get_ephemeron_tombstone() { }

	// RVA: 0x301DF6C Offset: 0x3019F6C VA: 0x301DF6C
	internal static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out UIntPtr lastRecordedHeapSize, out UIntPtr lastRecordedFragmentation) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x301DF88 Offset: 0x3019F88 VA: 0x301DF88
	public static int CollectionCount(int generation) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x301E044 Offset: 0x301A044 VA: 0x301E044
	public static void KeepAlive(object obj) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x301E048 Offset: 0x301A048 VA: 0x301E048
	private static void _SuppressFinalize(object o) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x301E04C Offset: 0x301A04C VA: 0x301E04C
	public static void SuppressFinalize(object obj) { }

	// RVA: 0x301E0EC Offset: 0x301A0EC VA: 0x301E0EC
	private static void _ReRegisterForFinalize(object o) { }

	// RVA: 0x301E0F0 Offset: 0x301A0F0 VA: 0x301E0F0
	public static void ReRegisterForFinalize(object obj) { }

	// RVA: 0x301E190 Offset: 0x301A190 VA: 0x301E190
	private static void .cctor() { }
}
