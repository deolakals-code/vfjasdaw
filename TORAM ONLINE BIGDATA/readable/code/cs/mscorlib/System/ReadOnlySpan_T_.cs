// Assembly: mscorlib.dll
// Namespace: System
[DebuggerTypeProxy(typeof(SpanDebugView<T>))]
[IsByRefLike]
[IsReadOnly]
[DefaultMember("Item")]
[DebuggerDisplay("{ToString(),raw}")]
[NonVersionable]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct ReadOnlySpan<T> // TypeDefIndex: 9657
{
	// Fields
	internal readonly ByReference<T> _pointer; // 0x0
	private readonly int _length; // 0x0

	// Properties
	[IsReadOnly]
	public T Item { get; }
	public int Length { get; }
	public bool IsEmpty { get; }
	public static ReadOnlySpan<T> Empty { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C51BAC Offset: 0x2C4DBAC VA: 0x2C51BAC
	|-ReadOnlySpan<byte>..ctor
	|
	|-RVA: 0x2C52204 Offset: 0x2C4E204 VA: 0x2C52204
	|-ReadOnlySpan<char>..ctor
	|
	|-RVA: 0x2C5285C Offset: 0x2C4E85C VA: 0x2C5285C
	|-ReadOnlySpan<int>..ctor
	|
	|-RVA: 0x2C52EB4 Offset: 0x2C4EEB4 VA: 0x2C52EB4
	|-ReadOnlySpan<ushort>..ctor
	|
	|-RVA: 0x2C5350C Offset: 0x2C4F50C VA: 0x2C5350C
	|-ReadOnlySpan<uint>..ctor
	|
	|-RVA: 0x2C53B64 Offset: 0x2C4FB64 VA: 0x2C53B64
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2C5453C Offset: 0x2C5053C VA: 0x2C5453C
	|-ReadOnlySpan<jvalue>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C51BCC Offset: 0x2C4DBCC VA: 0x2C51BCC
	|-ReadOnlySpan<byte>..ctor
	|
	|-RVA: 0x2C52224 Offset: 0x2C4E224 VA: 0x2C52224
	|-ReadOnlySpan<char>..ctor
	|
	|-RVA: 0x2C5287C Offset: 0x2C4E87C VA: 0x2C5287C
	|-ReadOnlySpan<int>..ctor
	|
	|-RVA: 0x2C52ED4 Offset: 0x2C4EED4 VA: 0x2C52ED4
	|-ReadOnlySpan<ushort>..ctor
	|
	|-RVA: 0x2C5352C Offset: 0x2C4F52C VA: 0x2C5352C
	|-ReadOnlySpan<uint>..ctor
	|
	|-RVA: 0x2C53B84 Offset: 0x2C4FB84 VA: 0x2C53B84
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2C5455C Offset: 0x2C5055C VA: 0x2C5455C
	|-ReadOnlySpan<jvalue>..ctor
	*/

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1
	public void .ctor(void* pointer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C51C40 Offset: 0x2C4DC40 VA: 0x2C51C40
	|-ReadOnlySpan<byte>..ctor
	|
	|-RVA: 0x2C52298 Offset: 0x2C4E298 VA: 0x2C52298
	|-ReadOnlySpan<char>..ctor
	|
	|-RVA: 0x2C528F0 Offset: 0x2C4E8F0 VA: 0x2C528F0
	|-ReadOnlySpan<int>..ctor
	|
	|-RVA: 0x2C52F48 Offset: 0x2C4EF48 VA: 0x2C52F48
	|-ReadOnlySpan<ushort>..ctor
	|
	|-RVA: 0x2C535A0 Offset: 0x2C4F5A0 VA: 0x2C535A0
	|-ReadOnlySpan<uint>..ctor
	|
	|-RVA: 0x2C53C54 Offset: 0x2C4FC54 VA: 0x2C53C54
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2C545D0 Offset: 0x2C505D0 VA: 0x2C545D0
	|-ReadOnlySpan<jvalue>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(ref T ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C51C74 Offset: 0x2C4DC74 VA: 0x2C51C74
	|-ReadOnlySpan<byte>..ctor
	|
	|-RVA: 0x2C522CC Offset: 0x2C4E2CC VA: 0x2C522CC
	|-ReadOnlySpan<char>..ctor
	|
	|-RVA: 0x2C52924 Offset: 0x2C4E924 VA: 0x2C52924
	|-ReadOnlySpan<int>..ctor
	|
	|-RVA: 0x2C52F7C Offset: 0x2C4EF7C VA: 0x2C52F7C
	|-ReadOnlySpan<ushort>..ctor
	|
	|-RVA: 0x2C535D4 Offset: 0x2C4F5D4 VA: 0x2C535D4
	|-ReadOnlySpan<uint>..ctor
	|
	|-RVA: 0x2C53D1C Offset: 0x2C4FD1C VA: 0x2C53D1C
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2C54604 Offset: 0x2C50604 VA: 0x2C54604
	|-ReadOnlySpan<jvalue>..ctor
	*/

	[NonVersionable]
	[Intrinsic]
	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C51C80 Offset: 0x2C4DC80 VA: 0x2C51C80
	|-ReadOnlySpan<byte>.get_Item
	|
	|-RVA: 0x2C522D8 Offset: 0x2C4E2D8 VA: 0x2C522D8
	|-ReadOnlySpan<char>.get_Item
	|
	|-RVA: 0x2C52930 Offset: 0x2C4E930 VA: 0x2C52930
	|-ReadOnlySpan<int>.get_Item
	|
	|-RVA: 0x2C52F88 Offset: 0x2C4EF88 VA: 0x2C52F88
	|-ReadOnlySpan<ushort>.get_Item
	|
	|-RVA: 0x2C535E0 Offset: 0x2C4F5E0 VA: 0x2C535E0
	|-ReadOnlySpan<uint>.get_Item
	|
	|-RVA: 0x2C53D28 Offset: 0x2C4FD28 VA: 0x2C53D28
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x2C54610 Offset: 0x2C50610 VA: 0x2C54610
	|-ReadOnlySpan<jvalue>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C51CB8 Offset: 0x2C4DCB8 VA: 0x2C51CB8
	|-ReadOnlySpan<byte>.CopyTo
	|
	|-RVA: 0x2C52310 Offset: 0x2C4E310 VA: 0x2C52310
	|-ReadOnlySpan<char>.CopyTo
	|
	|-RVA: 0x2C52968 Offset: 0x2C4E968 VA: 0x2C52968
	|-ReadOnlySpan<int>.CopyTo
	|
	|-RVA: 0x2C52FC0 Offset: 0x2C4EFC0 VA: 0x2C52FC0
	|-ReadOnlySpan<ushort>.CopyTo
	|
	|-RVA: 0x2C53618 Offset: 0x2C4F618 VA: 0x2C53618
	|-ReadOnlySpan<uint>.CopyTo
	|
	|-RVA: 0x2C53DC8 Offset: 0x2C4FDC8 VA: 0x2C53DC8
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0x2C54648 Offset: 0x2C50648 VA: 0x2C54648
	|-ReadOnlySpan<jvalue>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public bool TryCopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C51D40 Offset: 0x2C4DD40 VA: 0x2C51D40
	|-ReadOnlySpan<byte>.TryCopyTo
	|
	|-RVA: 0x2C52398 Offset: 0x2C4E398 VA: 0x2C52398
	|-ReadOnlySpan<char>.TryCopyTo
	|
	|-RVA: 0x2C529F0 Offset: 0x2C4E9F0 VA: 0x2C529F0
	|-ReadOnlySpan<int>.TryCopyTo
	|
	|-RVA: 0x2C53048 Offset: 0x2C4F048 VA: 0x2C53048
	|-ReadOnlySpan<ushort>.TryCopyTo
	|
	|-RVA: 0x2C536A0 Offset: 0x2C4F6A0 VA: 0x2C536A0
	|-ReadOnlySpan<uint>.TryCopyTo
	|
	|-RVA: 0x2C53ED4 Offset: 0x2C4FED4 VA: 0x2C53ED4
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.TryCopyTo
	|
	|-RVA: 0x2C546D0 Offset: 0x2C506D0 VA: 0x2C546D0
	|-ReadOnlySpan<jvalue>.TryCopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C51DC0 Offset: 0x2C4DDC0 VA: 0x2C51DC0
	|-ReadOnlySpan<byte>.ToString
	|
	|-RVA: 0x2C52418 Offset: 0x2C4E418 VA: 0x2C52418
	|-ReadOnlySpan<char>.ToString
	|
	|-RVA: 0x2C52A70 Offset: 0x2C4EA70 VA: 0x2C52A70
	|-ReadOnlySpan<int>.ToString
	|
	|-RVA: 0x2C530C8 Offset: 0x2C4F0C8 VA: 0x2C530C8
	|-ReadOnlySpan<ushort>.ToString
	|
	|-RVA: 0x2C53720 Offset: 0x2C4F720 VA: 0x2C53720
	|-ReadOnlySpan<uint>.ToString
	|
	|-RVA: 0x2C53FE8 Offset: 0x2C4FFE8 VA: 0x2C53FE8
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.ToString
	|
	|-RVA: 0x2C54750 Offset: 0x2C50750 VA: 0x2C54750
	|-ReadOnlySpan<jvalue>.ToString
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> Slice(int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C51F54 Offset: 0x2C4DF54 VA: 0x2C51F54
	|-ReadOnlySpan<byte>.Slice
	|
	|-RVA: 0x2C525AC Offset: 0x2C4E5AC VA: 0x2C525AC
	|-ReadOnlySpan<char>.Slice
	|
	|-RVA: 0x2C52C04 Offset: 0x2C4EC04 VA: 0x2C52C04
	|-ReadOnlySpan<int>.Slice
	|
	|-RVA: 0x2C5325C Offset: 0x2C4F25C VA: 0x2C5325C
	|-ReadOnlySpan<ushort>.Slice
	|
	|-RVA: 0x2C538B4 Offset: 0x2C4F8B4 VA: 0x2C538B4
	|-ReadOnlySpan<uint>.Slice
	|
	|-RVA: 0x2C5417C Offset: 0x2C5017C VA: 0x2C5417C
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.Slice
	|
	|-RVA: 0x2C548E4 Offset: 0x2C508E4 VA: 0x2C548E4
	|-ReadOnlySpan<jvalue>.Slice
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C51FB0 Offset: 0x2C4DFB0 VA: 0x2C51FB0
	|-ReadOnlySpan<byte>.Slice
	|
	|-RVA: 0x2C52608 Offset: 0x2C4E608 VA: 0x2C52608
	|-ReadOnlySpan<char>.Slice
	|
	|-RVA: 0x2C52C60 Offset: 0x2C4EC60 VA: 0x2C52C60
	|-ReadOnlySpan<int>.Slice
	|
	|-RVA: 0x2C532B8 Offset: 0x2C4F2B8 VA: 0x2C532B8
	|-ReadOnlySpan<ushort>.Slice
	|
	|-RVA: 0x2C53910 Offset: 0x2C4F910 VA: 0x2C53910
	|-ReadOnlySpan<uint>.Slice
	|
	|-RVA: 0x2C5423C Offset: 0x2C5023C VA: 0x2C5423C
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.Slice
	|
	|-RVA: 0x2C54940 Offset: 0x2C50940 VA: 0x2C54940
	|-ReadOnlySpan<jvalue>.Slice
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C52014 Offset: 0x2C4E014 VA: 0x2C52014
	|-ReadOnlySpan<byte>.ToArray
	|
	|-RVA: 0x2C5266C Offset: 0x2C4E66C VA: 0x2C5266C
	|-ReadOnlySpan<char>.ToArray
	|
	|-RVA: 0x2C52CC4 Offset: 0x2C4ECC4 VA: 0x2C52CC4
	|-ReadOnlySpan<int>.ToArray
	|
	|-RVA: 0x2C5331C Offset: 0x2C4F31C VA: 0x2C5331C
	|-ReadOnlySpan<ushort>.ToArray
	|
	|-RVA: 0x2C53974 Offset: 0x2C4F974 VA: 0x2C53974
	|-ReadOnlySpan<uint>.ToArray
	|
	|-RVA: 0x2C54304 Offset: 0x2C50304 VA: 0x2C54304
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.ToArray
	|
	|-RVA: 0x2C549A4 Offset: 0x2C509A4 VA: 0x2C549A4
	|-ReadOnlySpan<jvalue>.ToArray
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C52114 Offset: 0x2C4E114 VA: 0x2C52114
	|-ReadOnlySpan<byte>.get_Length
	|
	|-RVA: 0x2C5276C Offset: 0x2C4E76C VA: 0x2C5276C
	|-ReadOnlySpan<char>.get_Length
	|
	|-RVA: 0x2C52DC4 Offset: 0x2C4EDC4 VA: 0x2C52DC4
	|-ReadOnlySpan<int>.get_Length
	|
	|-RVA: 0x2C5341C Offset: 0x2C4F41C VA: 0x2C5341C
	|-ReadOnlySpan<ushort>.get_Length
	|
	|-RVA: 0x2C53A74 Offset: 0x2C4FA74 VA: 0x2C53A74
	|-ReadOnlySpan<uint>.get_Length
	|
	|-RVA: 0x2C5444C Offset: 0x2C5044C VA: 0x2C5444C
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.get_Length
	|
	|-RVA: 0x2C54AA4 Offset: 0x2C50AA4 VA: 0x2C54AA4
	|-ReadOnlySpan<jvalue>.get_Length
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C5211C Offset: 0x2C4E11C VA: 0x2C5211C
	|-ReadOnlySpan<byte>.get_IsEmpty
	|
	|-RVA: 0x2C52774 Offset: 0x2C4E774 VA: 0x2C52774
	|-ReadOnlySpan<char>.get_IsEmpty
	|
	|-RVA: 0x2C52DCC Offset: 0x2C4EDCC VA: 0x2C52DCC
	|-ReadOnlySpan<int>.get_IsEmpty
	|
	|-RVA: 0x2C53424 Offset: 0x2C4F424 VA: 0x2C53424
	|-ReadOnlySpan<ushort>.get_IsEmpty
	|
	|-RVA: 0x2C53A7C Offset: 0x2C4FA7C VA: 0x2C53A7C
	|-ReadOnlySpan<uint>.get_IsEmpty
	|
	|-RVA: 0x2C54454 Offset: 0x2C50454 VA: 0x2C54454
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.get_IsEmpty
	|
	|-RVA: 0x2C54AAC Offset: 0x2C50AAC VA: 0x2C54AAC
	|-ReadOnlySpan<jvalue>.get_IsEmpty
	*/

	[Obsolete("Equals() on ReadOnlySpan will always throw an exception. Use == instead.")]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C5212C Offset: 0x2C4E12C VA: 0x2C5212C
	|-ReadOnlySpan<byte>.Equals
	|
	|-RVA: 0x2C52784 Offset: 0x2C4E784 VA: 0x2C52784
	|-ReadOnlySpan<char>.Equals
	|
	|-RVA: 0x2C52DDC Offset: 0x2C4EDDC VA: 0x2C52DDC
	|-ReadOnlySpan<int>.Equals
	|
	|-RVA: 0x2C53434 Offset: 0x2C4F434 VA: 0x2C53434
	|-ReadOnlySpan<ushort>.Equals
	|
	|-RVA: 0x2C53A8C Offset: 0x2C4FA8C VA: 0x2C53A8C
	|-ReadOnlySpan<uint>.Equals
	|
	|-RVA: 0x2C54464 Offset: 0x2C50464 VA: 0x2C54464
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.Equals
	|
	|-RVA: 0x2C54ABC Offset: 0x2C50ABC VA: 0x2C54ABC
	|-ReadOnlySpan<jvalue>.Equals
	*/

	[Obsolete("GetHashCode() on ReadOnlySpan will always throw an exception.")]
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C52174 Offset: 0x2C4E174 VA: 0x2C52174
	|-ReadOnlySpan<byte>.GetHashCode
	|
	|-RVA: 0x2C527CC Offset: 0x2C4E7CC VA: 0x2C527CC
	|-ReadOnlySpan<char>.GetHashCode
	|
	|-RVA: 0x2C52E24 Offset: 0x2C4EE24 VA: 0x2C52E24
	|-ReadOnlySpan<int>.GetHashCode
	|
	|-RVA: 0x2C5347C Offset: 0x2C4F47C VA: 0x2C5347C
	|-ReadOnlySpan<ushort>.GetHashCode
	|
	|-RVA: 0x2C53AD4 Offset: 0x2C4FAD4 VA: 0x2C53AD4
	|-ReadOnlySpan<uint>.GetHashCode
	|
	|-RVA: 0x2C544AC Offset: 0x2C504AC VA: 0x2C544AC
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.GetHashCode
	|
	|-RVA: 0x2C54B04 Offset: 0x2C50B04 VA: 0x2C54B04
	|-ReadOnlySpan<jvalue>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C521BC Offset: 0x2C4E1BC VA: 0x2C521BC
	|-ReadOnlySpan<byte>.op_Implicit
	|
	|-RVA: 0x2C52814 Offset: 0x2C4E814 VA: 0x2C52814
	|-ReadOnlySpan<char>.op_Implicit
	|
	|-RVA: 0x2C52E6C Offset: 0x2C4EE6C VA: 0x2C52E6C
	|-ReadOnlySpan<int>.op_Implicit
	|
	|-RVA: 0x2C534C4 Offset: 0x2C4F4C4 VA: 0x2C534C4
	|-ReadOnlySpan<ushort>.op_Implicit
	|
	|-RVA: 0x2C53B1C Offset: 0x2C4FB1C VA: 0x2C53B1C
	|-ReadOnlySpan<uint>.op_Implicit
	|
	|-RVA: 0x2C544F4 Offset: 0x2C504F4 VA: 0x2C544F4
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.op_Implicit
	|
	|-RVA: 0x2C54B4C Offset: 0x2C50B4C VA: 0x2C54B4C
	|-ReadOnlySpan<jvalue>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C521F8 Offset: 0x2C4E1F8 VA: 0x2C521F8
	|-ReadOnlySpan<byte>.get_Empty
	|
	|-RVA: 0x2C52850 Offset: 0x2C4E850 VA: 0x2C52850
	|-ReadOnlySpan<char>.get_Empty
	|
	|-RVA: 0x2C52EA8 Offset: 0x2C4EEA8 VA: 0x2C52EA8
	|-ReadOnlySpan<int>.get_Empty
	|
	|-RVA: 0x2C53500 Offset: 0x2C4F500 VA: 0x2C53500
	|-ReadOnlySpan<ushort>.get_Empty
	|
	|-RVA: 0x2C53B58 Offset: 0x2C4FB58 VA: 0x2C53B58
	|-ReadOnlySpan<uint>.get_Empty
	|
	|-RVA: 0x2C54530 Offset: 0x2C50530 VA: 0x2C54530
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.get_Empty
	|
	|-RVA: 0x2C54B88 Offset: 0x2C50B88 VA: 0x2C54B88
	|-ReadOnlySpan<jvalue>.get_Empty
	*/
}
