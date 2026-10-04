// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
public static class Buffer // TypeDefIndex: 9742
{
	// Methods

	// RVA: 0x3011EB0 Offset: 0x300DEB0 VA: 0x3011EB0
	internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount) { }

	// RVA: 0x3011EB4 Offset: 0x300DEB4 VA: 0x3011EB4
	internal static int IndexOfByte(byte* src, byte value, int index, int count) { }

	// RVA: 0x3011FCC Offset: 0x300DFCC VA: 0x3011FCC
	private static int _ByteLength(Array array) { }

	// RVA: 0x3011FD0 Offset: 0x300DFD0 VA: 0x3011FD0
	internal static void ZeroMemory(byte* src, long len) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3012054 Offset: 0x300E054 VA: 0x3012054
	internal static void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len) { }

	// RVA: 0x3012164 Offset: 0x300E164 VA: 0x3012164
	internal static void InternalMemcpy(byte* dest, byte* src, int count) { }

	// RVA: 0x3012168 Offset: 0x300E168 VA: 0x3012168
	public static int ByteLength(Array array) { }

	// RVA: 0x30121FC Offset: 0x300E1FC VA: 0x30121FC
	public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x30123A4 Offset: 0x300E3A4 VA: 0x30123A4
	public static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy) { }

	// RVA: 0x3012458 Offset: 0x300E458 VA: 0x3012458
	internal static void memcpy4(byte* dest, byte* src, int size) { }

	// RVA: 0x30124D4 Offset: 0x300E4D4 VA: 0x30124D4
	internal static void memcpy2(byte* dest, byte* src, int size) { }

	// RVA: 0x3012540 Offset: 0x300E540 VA: 0x3012540
	private static void memcpy1(byte* dest, byte* src, int size) { }

	// RVA: 0x3012084 Offset: 0x300E084 VA: 0x3012084
	internal static void Memcpy(byte* dest, byte* src, int len) { }

	// RVA: 0x3012430 Offset: 0x300E430 VA: 0x3012430
	internal static void Memmove(byte* dest, byte* src, uint len) { }

	// RVA: -1 Offset: -1
	internal static void Memmove<T>(ref T destination, ref T source, ulong elementCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DDC60 Offset: 0x27D9C60 VA: 0x27DDC60
	|-Buffer.Memmove<byte>
	|
	|-RVA: 0x27DDC68 Offset: 0x27D9C68 VA: 0x27DDC68
	|-Buffer.Memmove<char>
	|
	|-RVA: 0x27DDC74 Offset: 0x27D9C74 VA: 0x27DDC74
	|-Buffer.Memmove<int>
	|
	|-RVA: 0x27DDC80 Offset: 0x27D9C80 VA: 0x27DDC80
	|-Buffer.Memmove<ushort>
	|
	|-RVA: 0x27DDC8C Offset: 0x27D9C8C VA: 0x27DDC8C
	|-Buffer.Memmove<uint>
	|
	|-RVA: 0x27DDC98 Offset: 0x27D9C98 VA: 0x27DDC98
	|-Buffer.Memmove<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x27DDD7C Offset: 0x27D9D7C VA: 0x27DDD7C
	|-Buffer.Memmove<jvalue>
	*/
}
