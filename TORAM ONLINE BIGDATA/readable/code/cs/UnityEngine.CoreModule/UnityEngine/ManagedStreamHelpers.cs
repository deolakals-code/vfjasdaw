// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
internal static class ManagedStreamHelpers // TypeDefIndex: 16359
{
	// Methods

	// RVA: 0x37EC80C Offset: 0x37E880C VA: 0x37EC80C
	internal static void ValidateLoadFromStream(Stream stream) { }

	[RequiredByNativeCode]
	// RVA: 0x37EC910 Offset: 0x37E8910 VA: 0x37EC910
	internal static void ManagedStreamRead(byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	// RVA: 0x37EC9F4 Offset: 0x37E89F4 VA: 0x37EC9F4
	internal static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	// RVA: 0x37ECAD0 Offset: 0x37E8AD0 VA: 0x37ECAD0
	internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }
}
