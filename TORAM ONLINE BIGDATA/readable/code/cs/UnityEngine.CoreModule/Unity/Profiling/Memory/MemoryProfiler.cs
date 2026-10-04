// Assembly: UnityEngine.CoreModule.dll
// Namespace: Unity.Profiling.Memory
[NativeHeader("Modules/Profiler/Runtime/MemorySnapshotManager.h")]
public static class MemoryProfiler // TypeDefIndex: 16141
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<string, bool> m_SnapshotFinished; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<MemorySnapshotMetadata> CreatingMetadata; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x37CBB64 Offset: 0x37C7B64 VA: 0x37CBB64
	private static byte[] PrepareMetadata() { }

	// RVA: 0x37CBD78 Offset: 0x37C7D78 VA: 0x37CBD78
	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	// RVA: 0x37CBE04 Offset: 0x37C7E04 VA: 0x37CBE04
	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

	[RequiredByNativeCode]
	// RVA: 0x37CBEF4 Offset: 0x37C7EF4 VA: 0x37CBEF4
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCode]
	// RVA: 0x37CBF88 Offset: 0x37C7F88 VA: 0x37CBF88
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }
}
