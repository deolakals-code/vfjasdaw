// Assembly: mscorlib.dll
// Namespace: System
[Extension]
internal static class SpanHelpers // TypeDefIndex: 9665
{
	// Methods

	// RVA: 0x2FF8C20 Offset: 0x2FF4C20 VA: 0x2FF8C20
	public static int IndexOfAny(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength) { }

	// RVA: 0x2FF8CA0 Offset: 0x2FF4CA0 VA: 0x2FF8CA0
	public static int IndexOf(ref byte searchSpace, byte value, int length) { }

	// RVA: 0x2FF8F48 Offset: 0x2FF4F48 VA: 0x2FF8F48
	public static bool SequenceEqual(ref byte first, ref byte second, ulong length) { }

	// RVA: 0x2FF90B8 Offset: 0x2FF50B8 VA: 0x2FF90B8
	public static int SequenceCompareTo(ref char first, int firstLength, ref char second, int secondLength) { }

	// RVA: 0x2FF95F8 Offset: 0x2FF55F8 VA: 0x2FF95F8
	public static int IndexOf(ref char searchSpace, char value, int length) { }

	// RVA: 0x2FF9BE8 Offset: 0x2FF5BE8 VA: 0x2FF9BE8
	public static int LastIndexOf(ref char searchSpace, char value, int length) { }

	// RVA: 0x2FFA18C Offset: 0x2FF618C VA: 0x2FFA18C
	private static int LocateFirstFoundChar(Vector<ushort> match) { }

	// RVA: 0x2FFA368 Offset: 0x2FF6368 VA: 0x2FFA368
	private static int LocateFirstFoundChar(ulong match) { }

	// RVA: 0x2FFA388 Offset: 0x2FF6388 VA: 0x2FFA388
	private static int LocateLastFoundChar(Vector<ushort> match) { }

	// RVA: 0x2FFA564 Offset: 0x2FF6564 VA: 0x2FFA564
	private static int LocateLastFoundChar(ulong match) { }

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(ref T searchSpace, T value, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EEBFC Offset: 0x26EABFC VA: 0x26EEBFC
	|-SpanHelpers.IndexOf<byte>
	|
	|-RVA: 0x26EEF10 Offset: 0x26EAF10 VA: 0x26EEF10
	|-SpanHelpers.IndexOf<char>
	|
	|-RVA: 0x26EF37C Offset: 0x26EB37C VA: 0x26EF37C
	|-SpanHelpers.IndexOf<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int IndexOfAny<T>(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EFFB4 Offset: 0x26EBFB4 VA: 0x26EFFB4
	|-SpanHelpers.IndexOfAny<char>
	|
	|-RVA: 0x26F005C Offset: 0x26EC05C VA: 0x26F005C
	|-SpanHelpers.IndexOfAny<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool SequenceEqual<T>(ref T first, ref T second, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F01BC Offset: 0x26EC1BC VA: 0x26F01BC
	|-SpanHelpers.SequenceEqual<char>
	|
	|-RVA: 0x26F06B0 Offset: 0x26EC6B0 VA: 0x26F06B0
	|-SpanHelpers.SequenceEqual<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2FFA590 Offset: 0x2FF6590 VA: 0x2FFA590
	public static bool EndsWithCultureHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo) { }

	// RVA: 0x2FFA6C8 Offset: 0x2FF66C8 VA: 0x2FFA6C8
	public static bool EndsWithCultureIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo) { }

	// RVA: 0x2FFA7E8 Offset: 0x2FF67E8 VA: 0x2FFA7E8
	public static bool EndsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value) { }

	// RVA: 0x2FFA8CC Offset: 0x2FF68CC VA: 0x2FFA8CC
	public static void ClearWithoutReferences(ref byte b, ulong byteLength) { }

	// RVA: 0x2FFAAB4 Offset: 0x2FF6AB4 VA: 0x2FFAAB4
	public static void ClearWithReferences(ref IntPtr ip, ulong pointerSizeLength) { }
}
