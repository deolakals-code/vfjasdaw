// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
internal class LowLevelList<T> // TypeDefIndex: 10966
{
	// Fields
	private const int _defaultCapacity = 4;
	protected T[] _items; // 0x0
	protected int _size; // 0x0
	protected int _version; // 0x0
	private static readonly T[] s_emptyArray; // 0x0

	// Properties
	public int Capacity { get; set; }
	public int Count { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA2560 Offset: 0x2B9E560 VA: 0x2BA2560
	|-LowLevelList<object>..ctor
	|
	|-RVA: 0x2BA3540 Offset: 0x2B9F540 VA: 0x2BA3540
	|-LowLevelList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA25D0 Offset: 0x2B9E5D0 VA: 0x2BA25D0
	|-LowLevelList<object>..ctor
	|
	|-RVA: 0x2BA35B0 Offset: 0x2B9F5B0 VA: 0x2BA35B0
	|-LowLevelList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA26AC Offset: 0x2B9E6AC VA: 0x2BA26AC
	|-LowLevelList<object>.get_Capacity
	|
	|-RVA: 0x2BA368C Offset: 0x2B9F68C VA: 0x2BA368C
	|-LowLevelList<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA26C8 Offset: 0x2B9E6C8 VA: 0x2BA26C8
	|-LowLevelList<object>.set_Capacity
	|
	|-RVA: 0x2BA36A8 Offset: 0x2B9F6A8 VA: 0x2BA36A8
	|-LowLevelList<__Il2CppFullySharedGenericType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA2804 Offset: 0x2B9E804 VA: 0x2BA2804
	|-LowLevelList<object>.get_Count
	|
	|-RVA: 0x2BA37E4 Offset: 0x2B9F7E4 VA: 0x2BA37E4
	|-LowLevelList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA280C Offset: 0x2B9E80C VA: 0x2BA280C
	|-LowLevelList<object>.get_Item
	|
	|-RVA: 0x2BA37EC Offset: 0x2B9F7EC VA: 0x2BA37EC
	|-LowLevelList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA287C Offset: 0x2B9E87C VA: 0x2BA287C
	|-LowLevelList<object>.set_Item
	|
	|-RVA: 0x2BA38E0 Offset: 0x2B9F8E0 VA: 0x2BA38E0
	|-LowLevelList<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA2904 Offset: 0x2B9E904 VA: 0x2BA2904
	|-LowLevelList<object>.Add
	|
	|-RVA: 0x2BA3A48 Offset: 0x2B9FA48 VA: 0x2BA3A48
	|-LowLevelList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA2998 Offset: 0x2B9E998 VA: 0x2BA2998
	|-LowLevelList<object>.EnsureCapacity
	|
	|-RVA: 0x2BA3BC0 Offset: 0x2B9FBC0 VA: 0x2BA3BC0
	|-LowLevelList<__Il2CppFullySharedGenericType>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA29E8 Offset: 0x2B9E9E8 VA: 0x2BA29E8
	|-LowLevelList<object>.AddRange
	|
	|-RVA: 0x2BA3C14 Offset: 0x2B9FC14 VA: 0x2BA3C14
	|-LowLevelList<__Il2CppFullySharedGenericType>.AddRange
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA2A04 Offset: 0x2B9EA04 VA: 0x2BA2A04
	|-LowLevelList<object>.Clear
	|
	|-RVA: 0x2BA3C34 Offset: 0x2B9FC34 VA: 0x2BA3C34
	|-LowLevelList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA2A40 Offset: 0x2B9EA40 VA: 0x2BA2A40
	|-LowLevelList<object>.Contains
	|
	|-RVA: 0x2BA3C70 Offset: 0x2B9FC70 VA: 0x2BA3C70
	|-LowLevelList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA2ADC Offset: 0x2B9EADC VA: 0x2BA2ADC
	|-LowLevelList<object>.CopyTo
	|
	|-RVA: 0x2BA3E28 Offset: 0x2B9FE28 VA: 0x2BA3E28
	|-LowLevelList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA2AFC Offset: 0x2B9EAFC VA: 0x2BA2AFC
	|-LowLevelList<object>.IndexOf
	|
	|-RVA: 0x2BA3E48 Offset: 0x2B9FE48 VA: 0x2BA3E48
	|-LowLevelList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA2B1C Offset: 0x2B9EB1C VA: 0x2BA2B1C
	|-LowLevelList<object>.Insert
	|
	|-RVA: 0x2BA3F2C Offset: 0x2B9FF2C VA: 0x2BA3F2C
	|-LowLevelList<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public void InsertRange(int index, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA2C14 Offset: 0x2B9EC14 VA: 0x2BA2C14
	|-LowLevelList<object>.InsertRange
	|
	|-RVA: 0x2BA4108 Offset: 0x2BA0108 VA: 0x2BA4108
	|-LowLevelList<__Il2CppFullySharedGenericType>.InsertRange
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA31BC Offset: 0x2B9F1BC VA: 0x2BA31BC
	|-LowLevelList<object>.Remove
	|
	|-RVA: 0x2BA4734 Offset: 0x2BA0734 VA: 0x2BA4734
	|-LowLevelList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public int RemoveAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA3228 Offset: 0x2B9F228 VA: 0x2BA3228
	|-LowLevelList<object>.RemoveAll
	|
	|-RVA: 0x2BA482C Offset: 0x2BA082C VA: 0x2BA482C
	|-LowLevelList<__Il2CppFullySharedGenericType>.RemoveAll
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA33D0 Offset: 0x2B9F3D0 VA: 0x2BA33D0
	|-LowLevelList<object>.RemoveAt
	|
	|-RVA: 0x2BA4B40 Offset: 0x2BA0B40 VA: 0x2BA4B40
	|-LowLevelList<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA3498 Offset: 0x2B9F498 VA: 0x2BA3498
	|-LowLevelList<object>..cctor
	|
	|-RVA: 0x2BA4D04 Offset: 0x2BA0D04 VA: 0x2BA4D04
	|-LowLevelList<__Il2CppFullySharedGenericType>..cctor
	*/
}
