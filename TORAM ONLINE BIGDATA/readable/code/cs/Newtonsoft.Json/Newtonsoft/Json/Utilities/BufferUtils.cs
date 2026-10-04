// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(2)]
internal static class BufferUtils // TypeDefIndex: 15932
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x30912FC Offset: 0x308D2FC VA: 0x30912FC
	public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize) { }

	// RVA: 0x30913C4 Offset: 0x308D3C4 VA: 0x30913C4
	public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer) { }

	// RVA: 0x3091474 Offset: 0x308D474 VA: 0x3091474
	public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer) { }
}
