// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(MemoryDebugView<T>))]
public struct Memory<T> : IEquatable<Memory<T>> // TypeDefIndex: 9630
{
	// Fields
	private readonly object _object; // 0x0
	private readonly int _index; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	public Span<T> Span { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA5A14 Offset: 0x2BA1A14 VA: 0x2BA5A14
	|-Memory<byte>..ctor
	|
	|-RVA: 0x2BA67A4 Offset: 0x2BA27A4 VA: 0x2BA67A4
	|-Memory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA5A54 Offset: 0x2BA1A54 VA: 0x2BA5A54
	|-Memory<byte>..ctor
	|
	|-RVA: 0x2BA6950 Offset: 0x2BA2950 VA: 0x2BA6950
	|-Memory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object obj, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA5ACC Offset: 0x2BA1ACC VA: 0x2BA5ACC
	|-Memory<byte>..ctor
	|
	|-RVA: 0x2BA6B30 Offset: 0x2BA2B30 VA: 0x2BA6B30
	|-Memory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA5AF8 Offset: 0x2BA1AF8 VA: 0x2BA5AF8
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x2BA6B5C Offset: 0x2BA2B5C VA: 0x2BA6B5C
	|-Memory<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlyMemory<T> op_Implicit(Memory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA5B58 Offset: 0x2BA1B58 VA: 0x2BA5B58
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x2BA6BA8 Offset: 0x2BA2BA8 VA: 0x2BA6BA8
	|-Memory<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA5B5C Offset: 0x2BA1B5C VA: 0x2BA5B5C
	|-Memory<byte>.get_Length
	|
	|-RVA: 0x2BA6BAC Offset: 0x2BA2BAC VA: 0x2BA6BAC
	|-Memory<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA5B68 Offset: 0x2BA1B68 VA: 0x2BA5B68
	|-Memory<byte>.ToString
	|
	|-RVA: 0x2BA6BB8 Offset: 0x2BA2BB8 VA: 0x2BA6BB8
	|-Memory<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public Memory<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA5D64 Offset: 0x2BA1D64 VA: 0x2BA5D64
	|-Memory<byte>.Slice
	|
	|-RVA: 0x2BA6DEC Offset: 0x2BA2DEC VA: 0x2BA6DEC
	|-Memory<__Il2CppFullySharedGenericType>.Slice
	*/

	// RVA: -1 Offset: -1
	public Span<T> get_Span() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA5E00 Offset: 0x2BA1E00 VA: 0x2BA5E00
	|-Memory<byte>.get_Span
	|
	|-RVA: 0x2BA6E88 Offset: 0x2BA2E88 VA: 0x2BA6E88
	|-Memory<__Il2CppFullySharedGenericType>.get_Span
	*/

	// RVA: -1 Offset: -1
	public MemoryHandle Pin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA6144 Offset: 0x2BA2144 VA: 0x2BA6144
	|-Memory<byte>.Pin
	|
	|-RVA: 0x2BA71FC Offset: 0x2BA31FC VA: 0x2BA71FC
	|-Memory<__Il2CppFullySharedGenericType>.Pin
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA6414 Offset: 0x2BA2414 VA: 0x2BA6414
	|-Memory<byte>.ToArray
	|
	|-RVA: 0x2BA7580 Offset: 0x2BA3580 VA: 0x2BA7580
	|-Memory<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA6488 Offset: 0x2BA2488 VA: 0x2BA6488
	|-Memory<byte>.Equals
	|
	|-RVA: 0x2BA765C Offset: 0x2BA365C VA: 0x2BA765C
	|-Memory<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(Memory<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA6660 Offset: 0x2BA2660 VA: 0x2BA6660
	|-Memory<byte>.Equals
	|
	|-RVA: 0x2BA78D4 Offset: 0x2BA38D4 VA: 0x2BA78D4
	|-Memory<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA6694 Offset: 0x2BA2694 VA: 0x2BA6694
	|-Memory<byte>.GetHashCode
	|
	|-RVA: 0x2BA7908 Offset: 0x2BA3908 VA: 0x2BA7908
	|-Memory<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA672C Offset: 0x2BA272C VA: 0x2BA672C
	|-Memory<byte>.CombineHashCodes
	|
	|-RVA: 0x2BA79D8 Offset: 0x2BA39D8 VA: 0x2BA79D8
	|-Memory<__Il2CppFullySharedGenericType>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int h1, int h2, int h3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA6738 Offset: 0x2BA2738 VA: 0x2BA6738
	|-Memory<byte>.CombineHashCodes
	|
	|-RVA: 0x2BA79E4 Offset: 0x2BA39E4 VA: 0x2BA79E4
	|-Memory<__Il2CppFullySharedGenericType>.CombineHashCodes
	*/
}
