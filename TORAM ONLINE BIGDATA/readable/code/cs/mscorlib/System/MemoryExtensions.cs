// Assembly: mscorlib.dll
// Namespace: System
[Extension]
public static class MemoryExtensions // TypeDefIndex: 9632
{
	// Methods

	[Extension]
	// RVA: 0x2FE7144 Offset: 0x2FE3144 VA: 0x2FE7144
	internal static bool EqualsOrdinal(ReadOnlySpan<char> span, ReadOnlySpan<char> value) { }

	[Extension]
	// RVA: 0x2FE71E0 Offset: 0x2FE31E0 VA: 0x2FE71E0
	internal static bool EqualsOrdinalIgnoreCase(ReadOnlySpan<char> span, ReadOnlySpan<char> value) { }

	[Extension]
	// RVA: 0x2FE728C Offset: 0x2FE328C VA: 0x2FE728C
	internal static bool Contains(ReadOnlySpan<char> source, char value) { }

	[Extension]
	// RVA: 0x2FE7320 Offset: 0x2FE3320 VA: 0x2FE7320
	public static int ToUpperInvariant(ReadOnlySpan<char> source, Span<char> destination) { }

	[Extension]
	// RVA: 0x2FE7478 Offset: 0x2FE3478 VA: 0x2FE7478
	public static bool EndsWith(ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static Span<T> AsSpan<T>(T[] array, int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D81DC Offset: 0x26D41DC VA: 0x26D81DC
	|-MemoryExtensions.AsSpan<byte>
	|
	|-RVA: 0x26D824C Offset: 0x26D424C VA: 0x26D824C
	|-MemoryExtensions.AsSpan<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x2FE76EC Offset: 0x2FE36EC VA: 0x2FE76EC
	public static ReadOnlySpan<char> AsSpan(string text) { }

	[Extension]
	// RVA: 0x2FE7744 Offset: 0x2FE3744 VA: 0x2FE7744
	public static ReadOnlySpan<char> AsSpan(string text, int start) { }

	[Extension]
	// RVA: 0x2FE77D0 Offset: 0x2FE37D0 VA: 0x2FE77D0
	public static ReadOnlySpan<char> AsSpan(string text, int start, int length) { }

	[Extension]
	// RVA: 0x2FDEFB8 Offset: 0x2FDAFB8 VA: 0x2FDEFB8
	public static ReadOnlySpan<char> Trim(ReadOnlySpan<char> span) { }

	[Extension]
	// RVA: 0x2FE7870 Offset: 0x2FE3870 VA: 0x2FE7870
	public static ReadOnlySpan<char> TrimStart(ReadOnlySpan<char> span) { }

	[Extension]
	// RVA: 0x2FE7964 Offset: 0x2FE3964 VA: 0x2FE7964
	public static ReadOnlySpan<char> TrimEnd(ReadOnlySpan<char> span) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(ReadOnlySpan<T> span, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D8974 Offset: 0x26D4974 VA: 0x26D8974
	|-MemoryExtensions.IndexOf<byte>
	|
	|-RVA: 0x26D8B10 Offset: 0x26D4B10 VA: 0x26D8B10
	|-MemoryExtensions.IndexOf<char>
	|
	|-RVA: 0x26D8CAC Offset: 0x26D4CAC VA: 0x26D8CAC
	|-MemoryExtensions.IndexOf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOfAny<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D8F64 Offset: 0x26D4F64 VA: 0x26D8F64
	|-MemoryExtensions.IndexOfAny<char>
	|
	|-RVA: 0x26D97A0 Offset: 0x26D57A0 VA: 0x26D97A0
	|-MemoryExtensions.IndexOfAny<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DA130 Offset: 0x26D6130 VA: 0x26DA130
	|-MemoryExtensions.SequenceEqual<char>
	|
	|-RVA: 0x26DA1E0 Offset: 0x26D61E0 VA: 0x26DA1E0
	|-MemoryExtensions.SequenceEqual<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool StartsWith<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DA3CC Offset: 0x26D63CC VA: 0x26DA3CC
	|-MemoryExtensions.StartsWith<char>
	|
	|-RVA: 0x26DA47C Offset: 0x26D647C VA: 0x26DA47C
	|-MemoryExtensions.StartsWith<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool EndsWith<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D8650 Offset: 0x26D4650 VA: 0x26D8650
	|-MemoryExtensions.EndsWith<char>
	|
	|-RVA: 0x26D8768 Offset: 0x26D4768 VA: 0x26D8768
	|-MemoryExtensions.EndsWith<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Span<T> AsSpan<T>(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D83EC Offset: 0x26D43EC VA: 0x26D83EC
	|-MemoryExtensions.AsSpan<byte>
	|
	|-RVA: 0x26D8468 Offset: 0x26D4468 VA: 0x26D8468
	|-MemoryExtensions.AsSpan<char>
	|
	|-RVA: 0x26D84E4 Offset: 0x26D44E4 VA: 0x26D84E4
	|-MemoryExtensions.AsSpan<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void CopyTo<T>(T[] source, Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D854C Offset: 0x26D454C VA: 0x26D854C
	|-MemoryExtensions.CopyTo<byte>
	|
	|-RVA: 0x26D85CC Offset: 0x26D45CC VA: 0x26D85CC
	|-MemoryExtensions.CopyTo<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static bool IsTypeComparableAsBytes<T>(out ulong size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D9950 Offset: 0x26D5950 VA: 0x26D9950
	|-MemoryExtensions.IsTypeComparableAsBytes<char>
	|
	|-RVA: 0x26D9D40 Offset: 0x26D5D40 VA: 0x26D9D40
	|-MemoryExtensions.IsTypeComparableAsBytes<__Il2CppFullySharedGenericType>
	*/
}
