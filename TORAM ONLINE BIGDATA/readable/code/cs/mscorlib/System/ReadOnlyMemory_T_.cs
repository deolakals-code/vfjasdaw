// Assembly: mscorlib.dll
// Namespace: System
[DebuggerTypeProxy(typeof(MemoryDebugView<T>))]
[DebuggerDisplay("{ToString(),raw}")]
[IsReadOnly]
public struct ReadOnlyMemory<T> : IEquatable<ReadOnlyMemory<T>> // TypeDefIndex: 9656
{
	// Fields
	private readonly object _object; // 0x0
	private readonly int _index; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	public ReadOnlySpan<T> Span { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C50714 Offset: 0x2C4C714 VA: 0x2C50714
	|-ReadOnlyMemory<byte>..ctor
	|
	|-RVA: 0x2C51014 Offset: 0x2C4D014 VA: 0x2C51014
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C5078C Offset: 0x2C4C78C VA: 0x2C5078C
	|-ReadOnlyMemory<byte>.get_Length
	|
	|-RVA: 0x2C5108C Offset: 0x2C4D08C VA: 0x2C5108C
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C50798 Offset: 0x2C4C798 VA: 0x2C50798
	|-ReadOnlyMemory<byte>.ToString
	|
	|-RVA: 0x2C51098 Offset: 0x2C4D098 VA: 0x2C51098
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> get_Span() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C50990 Offset: 0x2C4C990 VA: 0x2C50990
	|-ReadOnlyMemory<byte>.get_Span
	|
	|-RVA: 0x2C512C8 Offset: 0x2C4D2C8 VA: 0x2C512C8
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.get_Span
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C50CFC Offset: 0x2C4CCFC VA: 0x2C50CFC
	|-ReadOnlyMemory<byte>.Equals
	|
	|-RVA: 0x2C5170C Offset: 0x2C4D70C VA: 0x2C5170C
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ReadOnlyMemory<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C50EB8 Offset: 0x2C4CEB8 VA: 0x2C50EB8
	|-ReadOnlyMemory<byte>.Equals
	|
	|-RVA: 0x2C51990 Offset: 0x2C4D990 VA: 0x2C51990
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C50EEC Offset: 0x2C4CEEC VA: 0x2C50EEC
	|-ReadOnlyMemory<byte>.GetHashCode
	|
	|-RVA: 0x2C519C4 Offset: 0x2C4D9C4 VA: 0x2C519C4
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C50F84 Offset: 0x2C4CF84 VA: 0x2C50F84
	|-ReadOnlyMemory<byte>.CombineHashCodes
	|
	|-RVA: 0x2C51A94 Offset: 0x2C4DA94 VA: 0x2C51A94
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int h1, int h2, int h3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C50F90 Offset: 0x2C4CF90 VA: 0x2C50F90
	|-ReadOnlyMemory<byte>.CombineHashCodes
	|
	|-RVA: 0x2C51AA0 Offset: 0x2C4DAA0 VA: 0x2C51AA0
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	internal object GetObjectStartLength(out int start, out int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C50FFC Offset: 0x2C4CFFC VA: 0x2C50FFC
	|-ReadOnlyMemory<byte>.GetObjectStartLength
	|
	|-RVA: 0x2C51B94 Offset: 0x2C4DB94 VA: 0x2C51B94
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.GetObjectStartLength
	*/
}
