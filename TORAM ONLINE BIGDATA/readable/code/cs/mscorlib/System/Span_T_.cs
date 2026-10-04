// Assembly: mscorlib.dll
// Namespace: System
[DebuggerDisplay("{ToString(),raw}")]
[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsReadOnly]
[NonVersionable]
[DebuggerTypeProxy(typeof(SpanDebugView<T>))]
public struct Span<T> // TypeDefIndex: 9663
{
	// Fields
	internal readonly ByReference<T> _pointer; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public T Item { get; }
	public int Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9BA7C Offset: 0x2C97A7C VA: 0x2C9BA7C
	|-Span<byte>..ctor
	|
	|-RVA: 0x2C9C134 Offset: 0x2C98134 VA: 0x2C9C134
	|-Span<char>..ctor
	|
	|-RVA: 0x2C9C8B4 Offset: 0x2C988B4 VA: 0x2C9C8B4
	|-Span<int>..ctor
	|
	|-RVA: 0x2C9D038 Offset: 0x2C99038 VA: 0x2C9D038
	|-Span<ushort>..ctor
	|
	|-RVA: 0x2C9D7B8 Offset: 0x2C997B8 VA: 0x2C9D7B8
	|-Span<uint>..ctor
	|
	|-RVA: 0x2C9DF3C Offset: 0x2C99F3C VA: 0x2C9DF3C
	|-Span<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2C9FC08 Offset: 0x2C9BC08 VA: 0x2C9FC08
	|-Span<jvalue>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9BA9C Offset: 0x2C97A9C VA: 0x2C9BA9C
	|-Span<byte>..ctor
	|
	|-RVA: 0x2C9C154 Offset: 0x2C98154 VA: 0x2C9C154
	|-Span<char>..ctor
	|
	|-RVA: 0x2C9C8D4 Offset: 0x2C988D4 VA: 0x2C9C8D4
	|-Span<int>..ctor
	|
	|-RVA: 0x2C9D058 Offset: 0x2C99058 VA: 0x2C9D058
	|-Span<ushort>..ctor
	|
	|-RVA: 0x2C9D7D8 Offset: 0x2C997D8 VA: 0x2C9D7D8
	|-Span<uint>..ctor
	|
	|-RVA: 0x2C9E0DC Offset: 0x2C9A0DC VA: 0x2C9E0DC
	|-Span<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2C9FC28 Offset: 0x2C9BC28 VA: 0x2C9FC28
	|-Span<jvalue>..ctor
	*/

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1
	public void .ctor(void* pointer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9BB10 Offset: 0x2C97B10 VA: 0x2C9BB10
	|-Span<byte>..ctor
	|
	|-RVA: 0x2C9C1C8 Offset: 0x2C981C8 VA: 0x2C9C1C8
	|-Span<char>..ctor
	|
	|-RVA: 0x2C9C948 Offset: 0x2C98948 VA: 0x2C9C948
	|-Span<int>..ctor
	|
	|-RVA: 0x2C9D0CC Offset: 0x2C990CC VA: 0x2C9D0CC
	|-Span<ushort>..ctor
	|
	|-RVA: 0x2C9D84C Offset: 0x2C9984C VA: 0x2C9D84C
	|-Span<uint>..ctor
	|
	|-RVA: 0x2C9E310 Offset: 0x2C9A310 VA: 0x2C9E310
	|-Span<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2C9FC9C Offset: 0x2C9BC9C VA: 0x2C9FC9C
	|-Span<jvalue>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(ref T ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9BB44 Offset: 0x2C97B44 VA: 0x2C9BB44
	|-Span<byte>..ctor
	|
	|-RVA: 0x2C9C1FC Offset: 0x2C981FC VA: 0x2C9C1FC
	|-Span<char>..ctor
	|
	|-RVA: 0x2C9C97C Offset: 0x2C9897C VA: 0x2C9C97C
	|-Span<int>..ctor
	|
	|-RVA: 0x2C9D100 Offset: 0x2C99100 VA: 0x2C9D100
	|-Span<ushort>..ctor
	|
	|-RVA: 0x2C9D880 Offset: 0x2C99880 VA: 0x2C9D880
	|-Span<uint>..ctor
	|
	|-RVA: 0x2C9E3D8 Offset: 0x2C9A3D8 VA: 0x2C9E3D8
	|-Span<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2C9FCD0 Offset: 0x2C9BCD0 VA: 0x2C9FCD0
	|-Span<jvalue>..ctor
	*/

	[Intrinsic]
	[NonVersionable]
	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9BB50 Offset: 0x2C97B50 VA: 0x2C9BB50
	|-Span<byte>.get_Item
	|
	|-RVA: 0x2C9C208 Offset: 0x2C98208 VA: 0x2C9C208
	|-Span<char>.get_Item
	|
	|-RVA: 0x2C9C988 Offset: 0x2C98988 VA: 0x2C9C988
	|-Span<int>.get_Item
	|
	|-RVA: 0x2C9D10C Offset: 0x2C9910C VA: 0x2C9D10C
	|-Span<ushort>.get_Item
	|
	|-RVA: 0x2C9D88C Offset: 0x2C9988C VA: 0x2C9D88C
	|-Span<uint>.get_Item
	|
	|-RVA: 0x2C9E3E4 Offset: 0x2C9A3E4 VA: 0x2C9E3E4
	|-Span<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x2C9FCDC Offset: 0x2C9BCDC VA: 0x2C9FCDC
	|-Span<jvalue>.get_Item
	*/

	// RVA: -1 Offset: -1
	public ref T GetPinnableReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9BB88 Offset: 0x2C97B88 VA: 0x2C9BB88
	|-Span<byte>.GetPinnableReference
	|
	|-RVA: 0x2C9C240 Offset: 0x2C98240 VA: 0x2C9C240
	|-Span<char>.GetPinnableReference
	|
	|-RVA: 0x2C9C9C0 Offset: 0x2C989C0 VA: 0x2C9C9C0
	|-Span<int>.GetPinnableReference
	|
	|-RVA: 0x2C9D144 Offset: 0x2C99144 VA: 0x2C9D144
	|-Span<ushort>.GetPinnableReference
	|
	|-RVA: 0x2C9D8C4 Offset: 0x2C998C4 VA: 0x2C9D8C4
	|-Span<uint>.GetPinnableReference
	|
	|-RVA: 0x2C9E484 Offset: 0x2C9A484 VA: 0x2C9E484
	|-Span<__Il2CppFullySharedGenericType>.GetPinnableReference
	|
	|-RVA: 0x2C9FD14 Offset: 0x2C9BD14 VA: 0x2C9FD14
	|-Span<jvalue>.GetPinnableReference
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9BBA0 Offset: 0x2C97BA0 VA: 0x2C9BBA0
	|-Span<byte>.Clear
	|
	|-RVA: 0x2C9C258 Offset: 0x2C98258 VA: 0x2C9C258
	|-Span<char>.Clear
	|
	|-RVA: 0x2C9C9D8 Offset: 0x2C989D8 VA: 0x2C9C9D8
	|-Span<int>.Clear
	|
	|-RVA: 0x2C9D15C Offset: 0x2C9915C VA: 0x2C9D15C
	|-Span<ushort>.Clear
	|
	|-RVA: 0x2C9D8DC Offset: 0x2C998DC VA: 0x2C9D8DC
	|-Span<uint>.Clear
	|
	|-RVA: 0x2C9E49C Offset: 0x2C9A49C VA: 0x2C9E49C
	|-Span<__Il2CppFullySharedGenericType>.Clear
	|
	|-RVA: 0x2C9FD2C Offset: 0x2C9BD2C VA: 0x2C9FD2C
	|-Span<jvalue>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Fill(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9BBB4 Offset: 0x2C97BB4 VA: 0x2C9BBB4
	|-Span<byte>.Fill
	|
	|-RVA: 0x2C9C26C Offset: 0x2C9826C VA: 0x2C9C26C
	|-Span<char>.Fill
	|
	|-RVA: 0x2C9C9EC Offset: 0x2C989EC VA: 0x2C9C9EC
	|-Span<int>.Fill
	|
	|-RVA: 0x2C9D170 Offset: 0x2C99170 VA: 0x2C9D170
	|-Span<ushort>.Fill
	|
	|-RVA: 0x2C9D8F0 Offset: 0x2C998F0 VA: 0x2C9D8F0
	|-Span<uint>.Fill
	|
	|-RVA: 0x2C9E5D0 Offset: 0x2C9A5D0 VA: 0x2C9E5D0
	|-Span<__Il2CppFullySharedGenericType>.Fill
	|
	|-RVA: 0x2C9FD40 Offset: 0x2C9BD40 VA: 0x2C9FD40
	|-Span<jvalue>.Fill
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9BBCC Offset: 0x2C97BCC VA: 0x2C9BBCC
	|-Span<byte>.CopyTo
	|
	|-RVA: 0x2C9C34C Offset: 0x2C9834C VA: 0x2C9C34C
	|-Span<char>.CopyTo
	|
	|-RVA: 0x2C9CAD0 Offset: 0x2C98AD0 VA: 0x2C9CAD0
	|-Span<int>.CopyTo
	|
	|-RVA: 0x2C9D250 Offset: 0x2C99250 VA: 0x2C9D250
	|-Span<ushort>.CopyTo
	|
	|-RVA: 0x2C9D9D4 Offset: 0x2C999D4 VA: 0x2C9D9D4
	|-Span<uint>.CopyTo
	|
	|-RVA: 0x2C9F468 Offset: 0x2C9B468 VA: 0x2C9F468
	|-Span<__Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0x2C9FE2C Offset: 0x2C9BE2C VA: 0x2C9FE2C
	|-Span<jvalue>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public bool TryCopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9BC54 Offset: 0x2C97C54 VA: 0x2C9BC54
	|-Span<byte>.TryCopyTo
	|
	|-RVA: 0x2C9C3D4 Offset: 0x2C983D4 VA: 0x2C9C3D4
	|-Span<char>.TryCopyTo
	|
	|-RVA: 0x2C9CB58 Offset: 0x2C98B58 VA: 0x2C9CB58
	|-Span<int>.TryCopyTo
	|
	|-RVA: 0x2C9D2D8 Offset: 0x2C992D8 VA: 0x2C9D2D8
	|-Span<ushort>.TryCopyTo
	|
	|-RVA: 0x2C9DA5C Offset: 0x2C99A5C VA: 0x2C9DA5C
	|-Span<uint>.TryCopyTo
	|
	|-RVA: 0x2C9F574 Offset: 0x2C9B574 VA: 0x2C9F574
	|-Span<__Il2CppFullySharedGenericType>.TryCopyTo
	|
	|-RVA: 0x2C9FEB4 Offset: 0x2C9BEB4 VA: 0x2C9FEB4
	|-Span<jvalue>.TryCopyTo
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> op_Implicit(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9BCD4 Offset: 0x2C97CD4 VA: 0x2C9BCD4
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x2C9C454 Offset: 0x2C98454 VA: 0x2C9C454
	|-Span<char>.op_Implicit
	|
	|-RVA: 0x2C9CBD8 Offset: 0x2C98BD8 VA: 0x2C9CBD8
	|-Span<int>.op_Implicit
	|
	|-RVA: 0x2C9D358 Offset: 0x2C99358 VA: 0x2C9D358
	|-Span<ushort>.op_Implicit
	|
	|-RVA: 0x2C9DADC Offset: 0x2C99ADC VA: 0x2C9DADC
	|-Span<uint>.op_Implicit
	|
	|-RVA: 0x2C9F688 Offset: 0x2C9B688 VA: 0x2C9F688
	|-Span<__Il2CppFullySharedGenericType>.op_Implicit
	|
	|-RVA: 0x2C9FF34 Offset: 0x2C9BF34 VA: 0x2C9FF34
	|-Span<jvalue>.op_Implicit
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9BD0C Offset: 0x2C97D0C VA: 0x2C9BD0C
	|-Span<byte>.ToString
	|
	|-RVA: 0x2C9C48C Offset: 0x2C9848C VA: 0x2C9C48C
	|-Span<char>.ToString
	|
	|-RVA: 0x2C9CC10 Offset: 0x2C98C10 VA: 0x2C9CC10
	|-Span<int>.ToString
	|
	|-RVA: 0x2C9D390 Offset: 0x2C99390 VA: 0x2C9D390
	|-Span<ushort>.ToString
	|
	|-RVA: 0x2C9DB14 Offset: 0x2C99B14 VA: 0x2C9DB14
	|-Span<uint>.ToString
	|
	|-RVA: 0x2C9F6C0 Offset: 0x2C9B6C0 VA: 0x2C9F6C0
	|-Span<__Il2CppFullySharedGenericType>.ToString
	|
	|-RVA: 0x2C9FF6C Offset: 0x2C9BF6C VA: 0x2C9FF6C
	|-Span<jvalue>.ToString
	*/

	// RVA: -1 Offset: -1
	public Span<T> Slice(int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9BEA0 Offset: 0x2C97EA0 VA: 0x2C9BEA0
	|-Span<byte>.Slice
	|
	|-RVA: 0x2C9C620 Offset: 0x2C98620 VA: 0x2C9C620
	|-Span<char>.Slice
	|
	|-RVA: 0x2C9CDA4 Offset: 0x2C98DA4 VA: 0x2C9CDA4
	|-Span<int>.Slice
	|
	|-RVA: 0x2C9D524 Offset: 0x2C99524 VA: 0x2C9D524
	|-Span<ushort>.Slice
	|
	|-RVA: 0x2C9DCA8 Offset: 0x2C99CA8 VA: 0x2C9DCA8
	|-Span<uint>.Slice
	|
	|-RVA: 0x2C9F854 Offset: 0x2C9B854 VA: 0x2C9F854
	|-Span<__Il2CppFullySharedGenericType>.Slice
	|
	|-RVA: 0x2CA0100 Offset: 0x2C9C100 VA: 0x2CA0100
	|-Span<jvalue>.Slice
	*/

	// RVA: -1 Offset: -1
	public Span<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9BEFC Offset: 0x2C97EFC VA: 0x2C9BEFC
	|-Span<byte>.Slice
	|
	|-RVA: 0x2C9C67C Offset: 0x2C9867C VA: 0x2C9C67C
	|-Span<char>.Slice
	|
	|-RVA: 0x2C9CE00 Offset: 0x2C98E00 VA: 0x2C9CE00
	|-Span<int>.Slice
	|
	|-RVA: 0x2C9D580 Offset: 0x2C99580 VA: 0x2C9D580
	|-Span<ushort>.Slice
	|
	|-RVA: 0x2C9DD04 Offset: 0x2C99D04 VA: 0x2C9DD04
	|-Span<uint>.Slice
	|
	|-RVA: 0x2C9F914 Offset: 0x2C9B914 VA: 0x2C9F914
	|-Span<__Il2CppFullySharedGenericType>.Slice
	|
	|-RVA: 0x2CA015C Offset: 0x2C9C15C VA: 0x2CA015C
	|-Span<jvalue>.Slice
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9BF60 Offset: 0x2C97F60 VA: 0x2C9BF60
	|-Span<byte>.ToArray
	|
	|-RVA: 0x2C9C6E0 Offset: 0x2C986E0 VA: 0x2C9C6E0
	|-Span<char>.ToArray
	|
	|-RVA: 0x2C9CE64 Offset: 0x2C98E64 VA: 0x2C9CE64
	|-Span<int>.ToArray
	|
	|-RVA: 0x2C9D5E4 Offset: 0x2C995E4 VA: 0x2C9D5E4
	|-Span<ushort>.ToArray
	|
	|-RVA: 0x2C9DD68 Offset: 0x2C99D68 VA: 0x2C9DD68
	|-Span<uint>.ToArray
	|
	|-RVA: 0x2C9F9DC Offset: 0x2C9B9DC VA: 0x2C9F9DC
	|-Span<__Il2CppFullySharedGenericType>.ToArray
	|
	|-RVA: 0x2CA01C0 Offset: 0x2C9C1C0 VA: 0x2CA01C0
	|-Span<jvalue>.ToArray
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9C060 Offset: 0x2C98060 VA: 0x2C9C060
	|-Span<byte>.get_Length
	|
	|-RVA: 0x2C9C7E0 Offset: 0x2C987E0 VA: 0x2C9C7E0
	|-Span<char>.get_Length
	|
	|-RVA: 0x2C9CF64 Offset: 0x2C98F64 VA: 0x2C9CF64
	|-Span<int>.get_Length
	|
	|-RVA: 0x2C9D6E4 Offset: 0x2C996E4 VA: 0x2C9D6E4
	|-Span<ushort>.get_Length
	|
	|-RVA: 0x2C9DE68 Offset: 0x2C99E68 VA: 0x2C9DE68
	|-Span<uint>.get_Length
	|
	|-RVA: 0x2C9FB24 Offset: 0x2C9BB24 VA: 0x2C9FB24
	|-Span<__Il2CppFullySharedGenericType>.get_Length
	|
	|-RVA: 0x2CA02C0 Offset: 0x2C9C2C0 VA: 0x2CA02C0
	|-Span<jvalue>.get_Length
	*/

	[Obsolete("Equals() on Span will always throw an exception. Use == instead.")]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9C068 Offset: 0x2C98068 VA: 0x2C9C068
	|-Span<byte>.Equals
	|
	|-RVA: 0x2C9C7E8 Offset: 0x2C987E8 VA: 0x2C9C7E8
	|-Span<char>.Equals
	|
	|-RVA: 0x2C9CF6C Offset: 0x2C98F6C VA: 0x2C9CF6C
	|-Span<int>.Equals
	|
	|-RVA: 0x2C9D6EC Offset: 0x2C996EC VA: 0x2C9D6EC
	|-Span<ushort>.Equals
	|
	|-RVA: 0x2C9DE70 Offset: 0x2C99E70 VA: 0x2C9DE70
	|-Span<uint>.Equals
	|
	|-RVA: 0x2C9FB2C Offset: 0x2C9BB2C VA: 0x2C9FB2C
	|-Span<__Il2CppFullySharedGenericType>.Equals
	|
	|-RVA: 0x2CA02C8 Offset: 0x2C9C2C8 VA: 0x2CA02C8
	|-Span<jvalue>.Equals
	*/

	[Obsolete("GetHashCode() on Span will always throw an exception.")]
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9C0B0 Offset: 0x2C980B0 VA: 0x2C9C0B0
	|-Span<byte>.GetHashCode
	|
	|-RVA: 0x2C9C830 Offset: 0x2C98830 VA: 0x2C9C830
	|-Span<char>.GetHashCode
	|
	|-RVA: 0x2C9CFB4 Offset: 0x2C98FB4 VA: 0x2C9CFB4
	|-Span<int>.GetHashCode
	|
	|-RVA: 0x2C9D734 Offset: 0x2C99734 VA: 0x2C9D734
	|-Span<ushort>.GetHashCode
	|
	|-RVA: 0x2C9DEB8 Offset: 0x2C99EB8 VA: 0x2C9DEB8
	|-Span<uint>.GetHashCode
	|
	|-RVA: 0x2C9FB74 Offset: 0x2C9BB74 VA: 0x2C9FB74
	|-Span<__Il2CppFullySharedGenericType>.GetHashCode
	|
	|-RVA: 0x2CA0310 Offset: 0x2C9C310 VA: 0x2CA0310
	|-Span<jvalue>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static Span<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9C0F8 Offset: 0x2C980F8 VA: 0x2C9C0F8
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x2C9C878 Offset: 0x2C98878 VA: 0x2C9C878
	|-Span<char>.op_Implicit
	|
	|-RVA: 0x2C9CFFC Offset: 0x2C98FFC VA: 0x2C9CFFC
	|-Span<int>.op_Implicit
	|
	|-RVA: 0x2C9D77C Offset: 0x2C9977C VA: 0x2C9D77C
	|-Span<ushort>.op_Implicit
	|
	|-RVA: 0x2C9DF00 Offset: 0x2C99F00 VA: 0x2C9DF00
	|-Span<uint>.op_Implicit
	|
	|-RVA: 0x2C9FBBC Offset: 0x2C9BBBC VA: 0x2C9FBBC
	|-Span<__Il2CppFullySharedGenericType>.op_Implicit
	|
	|-RVA: 0x2CA0358 Offset: 0x2C9C358 VA: 0x2CA0358
	|-Span<jvalue>.op_Implicit
	*/
}
