// Assembly: System.Core.dll
// Namespace: System.Linq
internal class Set<TElement> // TypeDefIndex: 15214
{
	// Fields
	private int[] buckets; // 0x0
	private Set.Slot<TElement>[] slots; // 0x0
	private int count; // 0x0
	private int freeList; // 0x0
	private IEqualityComparer<TElement> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TElement> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C637BC Offset: 0x2C5F7BC VA: 0x2C637BC
	|-Set<byte>..ctor
	|
	|-RVA: 0x2C63D10 Offset: 0x2C5FD10 VA: 0x2C63D10
	|-Set<char>..ctor
	|
	|-RVA: 0x2C8DB48 Offset: 0x2C89B48 VA: 0x2C8DB48
	|-Set<int>..ctor
	|
	|-RVA: 0x2C8E098 Offset: 0x2C8A098 VA: 0x2C8E098
	|-Set<Int32Enum>..ctor
	|
	|-RVA: 0x2C8E5E8 Offset: 0x2C8A5E8 VA: 0x2C8E5E8
	|-Set<object>..ctor
	|
	|-RVA: 0x2C8EB6C Offset: 0x2C8AB6C VA: 0x2C8EB6C
	|-Set<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Add(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C63894 Offset: 0x2C5F894 VA: 0x2C63894
	|-Set<byte>.Add
	|
	|-RVA: 0x2C63DE8 Offset: 0x2C5FDE8 VA: 0x2C63DE8
	|-Set<char>.Add
	|
	|-RVA: 0x2C8DC20 Offset: 0x2C89C20 VA: 0x2C8DC20
	|-Set<int>.Add
	|
	|-RVA: 0x2C8E170 Offset: 0x2C8A170 VA: 0x2C8E170
	|-Set<Int32Enum>.Add
	|
	|-RVA: 0x2C8E6C0 Offset: 0x2C8A6C0 VA: 0x2C8E6C0
	|-Set<object>.Add
	|
	|-RVA: 0x2C8EC48 Offset: 0x2C8AC48 VA: 0x2C8EC48
	|-Set<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	private bool Find(TElement value, bool add) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C638BC Offset: 0x2C5F8BC VA: 0x2C638BC
	|-Set<byte>.Find
	|
	|-RVA: 0x2C63E10 Offset: 0x2C5FE10 VA: 0x2C63E10
	|-Set<char>.Find
	|
	|-RVA: 0x2C8DC48 Offset: 0x2C89C48 VA: 0x2C8DC48
	|-Set<int>.Find
	|
	|-RVA: 0x2C8E198 Offset: 0x2C8A198 VA: 0x2C8E198
	|-Set<Int32Enum>.Find
	|
	|-RVA: 0x2C8E6E8 Offset: 0x2C8A6E8 VA: 0x2C8E6E8
	|-Set<object>.Find
	|
	|-RVA: 0x2C8ED1C Offset: 0x2C8AD1C VA: 0x2C8ED1C
	|-Set<__Il2CppFullySharedGenericType>.Find
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C63B10 Offset: 0x2C5FB10 VA: 0x2C63B10
	|-Set<byte>.Resize
	|
	|-RVA: 0x2C64064 Offset: 0x2C60064 VA: 0x2C64064
	|-Set<char>.Resize
	|
	|-RVA: 0x2C8DE98 Offset: 0x2C89E98 VA: 0x2C8DE98
	|-Set<int>.Resize
	|
	|-RVA: 0x2C8E3E8 Offset: 0x2C8A3E8 VA: 0x2C8E3E8
	|-Set<Int32Enum>.Resize
	|
	|-RVA: 0x2C8E960 Offset: 0x2C8A960 VA: 0x2C8E960
	|-Set<object>.Resize
	|
	|-RVA: 0x2C8F224 Offset: 0x2C8B224 VA: 0x2C8F224
	|-Set<__Il2CppFullySharedGenericType>.Resize
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C63C6C Offset: 0x2C5FC6C VA: 0x2C63C6C
	|-Set<byte>.InternalGetHashCode
	|
	|-RVA: 0x2C641C0 Offset: 0x2C601C0 VA: 0x2C641C0
	|-Set<char>.InternalGetHashCode
	|
	|-RVA: 0x2C8DFF4 Offset: 0x2C89FF4 VA: 0x2C8DFF4
	|-Set<int>.InternalGetHashCode
	|
	|-RVA: 0x2C8E544 Offset: 0x2C8A544 VA: 0x2C8E544
	|-Set<Int32Enum>.InternalGetHashCode
	|
	|-RVA: 0x2C8EABC Offset: 0x2C8AABC VA: 0x2C8EABC
	|-Set<object>.InternalGetHashCode
	|
	|-RVA: 0x2C8F3FC Offset: 0x2C8B3FC VA: 0x2C8F3FC
	|-Set<__Il2CppFullySharedGenericType>.InternalGetHashCode
	*/
}
