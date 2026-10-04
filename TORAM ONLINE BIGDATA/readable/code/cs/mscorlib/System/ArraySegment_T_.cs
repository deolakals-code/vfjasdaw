// Assembly: mscorlib.dll
// Namespace: System
[DefaultMember("Item")]
[IsReadOnly]
[Serializable]
public struct ArraySegment<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 9548
{
	// Fields
	[CompilerGenerated]
	private static readonly ArraySegment<T> <Empty>k__BackingField; // 0x0
	private readonly T[] _array; // 0x0
	private readonly int _offset; // 0x0
	private readonly int _count; // 0x0

	// Properties
	public static ArraySegment<T> Empty { get; }
	public T[] Array { get; }
	public int Offset { get; }
	public int Count { get; }
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	private T System.Collections.Generic.IReadOnlyList<T>.Item { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static ArraySegment<T> get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2831D84 Offset: 0x282DD84 VA: 0x2831D84
	|-ArraySegment<byte>.get_Empty
	|
	|-RVA: 0x28328A0 Offset: 0x282E8A0 VA: 0x28328A0
	|-ArraySegment<__Il2CppFullySharedGenericType>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2831DF0 Offset: 0x282DDF0 VA: 0x2831DF0
	|-ArraySegment<byte>..ctor
	|
	|-RVA: 0x283290C Offset: 0x282E90C VA: 0x283290C
	|-ArraySegment<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int offset, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2831E4C Offset: 0x282DE4C VA: 0x2831E4C
	|-ArraySegment<byte>..ctor
	|
	|-RVA: 0x2832968 Offset: 0x282E968 VA: 0x2832968
	|-ArraySegment<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Array() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2831EB8 Offset: 0x282DEB8 VA: 0x2831EB8
	|-ArraySegment<byte>.get_Array
	|
	|-RVA: 0x28329D4 Offset: 0x282E9D4 VA: 0x28329D4
	|-ArraySegment<__Il2CppFullySharedGenericType>.get_Array
	*/

	// RVA: -1 Offset: -1
	public int get_Offset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2831EC0 Offset: 0x282DEC0 VA: 0x2831EC0
	|-ArraySegment<byte>.get_Offset
	|
	|-RVA: 0x28329DC Offset: 0x282E9DC VA: 0x28329DC
	|-ArraySegment<__Il2CppFullySharedGenericType>.get_Offset
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2831EC8 Offset: 0x282DEC8 VA: 0x2831EC8
	|-ArraySegment<byte>.get_Count
	|
	|-RVA: 0x28329E4 Offset: 0x282E9E4 VA: 0x28329E4
	|-ArraySegment<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public ArraySegment.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2831ED0 Offset: 0x282DED0 VA: 0x2831ED0
	|-ArraySegment<byte>.GetEnumerator
	|
	|-RVA: 0x28329EC Offset: 0x282E9EC VA: 0x28329EC
	|-ArraySegment<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2831F80 Offset: 0x282DF80 VA: 0x2831F80
	|-ArraySegment<byte>.GetHashCode
	|
	|-RVA: 0x2832ACC Offset: 0x282EACC VA: 0x2832ACC
	|-ArraySegment<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] destination, int destinationIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2832024 Offset: 0x282E024 VA: 0x2832024
	|-ArraySegment<byte>.CopyTo
	|
	|-RVA: 0x2832B70 Offset: 0x282EB70 VA: 0x2832B70
	|-ArraySegment<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28320C0 Offset: 0x282E0C0 VA: 0x28320C0
	|-ArraySegment<byte>.Equals
	|
	|-RVA: 0x2832C40 Offset: 0x282EC40 VA: 0x2832C40
	|-ArraySegment<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool Equals(ArraySegment<T> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28321E0 Offset: 0x282E1E0 VA: 0x28321E0
	|-ArraySegment<byte>.Equals
	|
	|-RVA: 0x2832DA0 Offset: 0x282EDA0 VA: 0x2832DA0
	|-ArraySegment<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2832214 Offset: 0x282E214 VA: 0x2832214
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2832DD4 Offset: 0x282EDD4 VA: 0x2832DD4
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28322DC Offset: 0x282E2DC VA: 0x28322DC
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2832F80 Offset: 0x282EF80 VA: 0x2832F80
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.Generic.IList<T>.IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28323B0 Offset: 0x282E3B0 VA: 0x28323B0
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x28331A0 Offset: 0x282F1A0 VA: 0x28331A0
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.IList<T>.Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x283247C Offset: 0x282E47C VA: 0x283247C
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x28333F8 Offset: 0x282F3F8 VA: 0x28333F8
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2832484 Offset: 0x282E484 VA: 0x2832484
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2833400 Offset: 0x282F400 VA: 0x2833400
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private T System.Collections.Generic.IReadOnlyList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x283248C Offset: 0x282E48C VA: 0x283248C
	|-ArraySegment<byte>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x2833408 Offset: 0x282F408 VA: 0x2833408
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2832554 Offset: 0x282E554 VA: 0x2832554
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x28335B4 Offset: 0x282F5B4 VA: 0x28335B4
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x283255C Offset: 0x282E55C VA: 0x283255C
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x28335BC Offset: 0x282F5BC VA: 0x28335BC
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2832564 Offset: 0x282E564 VA: 0x2832564
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x28335C4 Offset: 0x282F5C4 VA: 0x28335C4
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<T>.Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x283256C Offset: 0x282E56C VA: 0x283256C
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x28335CC Offset: 0x282F5CC VA: 0x28335CC
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<T>.Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x283262C Offset: 0x282E62C VA: 0x283262C
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2833810 Offset: 0x282F810 VA: 0x2833810
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2832644 Offset: 0x282E644 VA: 0x2832644
	|-ArraySegment<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2833828 Offset: 0x282F828 VA: 0x2833828
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28326FC Offset: 0x282E6FC VA: 0x28326FC
	|-ArraySegment<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2833918 Offset: 0x282F918 VA: 0x2833918
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private void ThrowInvalidOperationIfDefault() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28327B4 Offset: 0x282E7B4 VA: 0x28327B4
	|-ArraySegment<byte>.ThrowInvalidOperationIfDefault
	|
	|-RVA: 0x2833A08 Offset: 0x282FA08 VA: 0x2833A08
	|-ArraySegment<__Il2CppFullySharedGenericType>.ThrowInvalidOperationIfDefault
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28327CC Offset: 0x282E7CC VA: 0x28327CC
	|-ArraySegment<byte>..cctor
	|
	|-RVA: 0x2833A20 Offset: 0x282FA20 VA: 0x2833A20
	|-ArraySegment<__Il2CppFullySharedGenericType>..cctor
	*/
}
