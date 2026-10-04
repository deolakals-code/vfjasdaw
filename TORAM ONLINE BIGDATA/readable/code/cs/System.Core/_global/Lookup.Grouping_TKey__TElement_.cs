// Assembly: System.Core.dll
// Namespace: 
internal class Lookup.Grouping<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement> // TypeDefIndex: 15210
{
	// Fields
	internal TKey key; // 0x0
	internal int hashCode; // 0x0
	internal TElement[] elements; // 0x0
	internal int count; // 0x0
	internal Lookup.Grouping<TKey, TElement> hashNext; // 0x0
	internal Lookup.Grouping<TKey, TElement> next; // 0x0

	// Properties
	public TKey Key { get; }
	private int System.Collections.Generic.ICollection<TElement>.Count { get; }
	private bool System.Collections.Generic.ICollection<TElement>.IsReadOnly { get; }
	private TElement System.Collections.Generic.IList<TElement>.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void Add(TElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12904 Offset: 0x2A0E904 VA: 0x2A12904
	|-Lookup.Grouping<byte, object>.Add
	|
	|-RVA: 0x2A12BB0 Offset: 0x2A0EBB0 VA: 0x2A12BB0
	|-Lookup.Grouping<int, int>.Add
	|
	|-RVA: 0x2A12E54 Offset: 0x2A0EE54 VA: 0x2A12E54
	|-Lookup.Grouping<object, object>.Add
	|
	|-RVA: 0x2A13100 Offset: 0x2A0F100 VA: 0x2A13100
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	[IteratorStateMachine(typeof(Lookup.Grouping.<GetEnumerator>d__7<TKey, TElement>))]
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A129A4 Offset: 0x2A0E9A4 VA: 0x2A129A4
	|-Lookup.Grouping<byte, object>.GetEnumerator
	|
	|-RVA: 0x2A12C48 Offset: 0x2A0EC48 VA: 0x2A12C48
	|-Lookup.Grouping<int, int>.GetEnumerator
	|
	|-RVA: 0x2A12EF4 Offset: 0x2A0EEF4 VA: 0x2A12EF4
	|-Lookup.Grouping<object, object>.GetEnumerator
	|
	|-RVA: 0x2A13360 Offset: 0x2A0F360 VA: 0x2A13360
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12A1C Offset: 0x2A0EA1C VA: 0x2A12A1C
	|-Lookup.Grouping<byte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A12CC0 Offset: 0x2A0ECC0 VA: 0x2A12CC0
	|-Lookup.Grouping<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A12F6C Offset: 0x2A0EF6C VA: 0x2A12F6C
	|-Lookup.Grouping<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A133EC Offset: 0x2A0F3EC VA: 0x2A133EC
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12A2C Offset: 0x2A0EA2C VA: 0x2A12A2C
	|-Lookup.Grouping<byte, object>.get_Key
	|
	|-RVA: 0x2A12CD0 Offset: 0x2A0ECD0 VA: 0x2A12CD0
	|-Lookup.Grouping<int, int>.get_Key
	|
	|-RVA: 0x2A12F7C Offset: 0x2A0EF7C VA: 0x2A12F7C
	|-Lookup.Grouping<object, object>.get_Key
	|
	|-RVA: 0x2A13400 Offset: 0x2A0F400 VA: 0x2A13400
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Collections.Generic.ICollection<TElement>.get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12A34 Offset: 0x2A0EA34 VA: 0x2A12A34
	|-Lookup.Grouping<byte, object>.System.Collections.Generic.ICollection<TElement>.get_Count
	|
	|-RVA: 0x2A12CD8 Offset: 0x2A0ECD8 VA: 0x2A12CD8
	|-Lookup.Grouping<int, int>.System.Collections.Generic.ICollection<TElement>.get_Count
	|
	|-RVA: 0x2A12F84 Offset: 0x2A0EF84 VA: 0x2A12F84
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.get_Count
	|
	|-RVA: 0x2A1349C Offset: 0x2A0F49C VA: 0x2A1349C
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<TElement>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12A3C Offset: 0x2A0EA3C VA: 0x2A12A3C
	|-Lookup.Grouping<byte, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|
	|-RVA: 0x2A12CE0 Offset: 0x2A0ECE0 VA: 0x2A12CE0
	|-Lookup.Grouping<int, int>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|
	|-RVA: 0x2A12F8C Offset: 0x2A0EF8C VA: 0x2A12F8C
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|
	|-RVA: 0x2A134C4 Offset: 0x2A0F4C4 VA: 0x2A134C4
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<TElement>.Add(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12A44 Offset: 0x2A0EA44 VA: 0x2A12A44
	|-Lookup.Grouping<byte, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x2A12CE8 Offset: 0x2A0ECE8 VA: 0x2A12CE8
	|-Lookup.Grouping<int, int>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x2A12F94 Offset: 0x2A0EF94 VA: 0x2A12F94
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x2A134CC Offset: 0x2A0F4CC VA: 0x2A134CC
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.Generic.ICollection<TElement>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12A5C Offset: 0x2A0EA5C VA: 0x2A12A5C
	|-Lookup.Grouping<byte, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x2A12D00 Offset: 0x2A0ED00 VA: 0x2A12D00
	|-Lookup.Grouping<int, int>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x2A12FAC Offset: 0x2A0EFAC VA: 0x2A12FAC
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x2A134E4 Offset: 0x2A0F4E4 VA: 0x2A134E4
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<TElement>.Contains(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12A74 Offset: 0x2A0EA74 VA: 0x2A12A74
	|-Lookup.Grouping<byte, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x2A12D18 Offset: 0x2A0ED18 VA: 0x2A12D18
	|-Lookup.Grouping<int, int>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x2A12FC4 Offset: 0x2A0EFC4 VA: 0x2A12FC4
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x2A134FC Offset: 0x2A0F4FC VA: 0x2A134FC
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12AA8 Offset: 0x2A0EAA8 VA: 0x2A12AA8
	|-Lookup.Grouping<byte, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|
	|-RVA: 0x2A12D4C Offset: 0x2A0ED4C VA: 0x2A12D4C
	|-Lookup.Grouping<int, int>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|
	|-RVA: 0x2A12FF8 Offset: 0x2A0EFF8 VA: 0x2A12FF8
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|
	|-RVA: 0x2A13634 Offset: 0x2A0F634 VA: 0x2A13634
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12AC8 Offset: 0x2A0EAC8 VA: 0x2A12AC8
	|-Lookup.Grouping<byte, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x2A12D6C Offset: 0x2A0ED6C VA: 0x2A12D6C
	|-Lookup.Grouping<int, int>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x2A13018 Offset: 0x2A0F018 VA: 0x2A13018
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x2A136B0 Offset: 0x2A0F6B0 VA: 0x2A136B0
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Collections.Generic.IList<TElement>.IndexOf(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12AE0 Offset: 0x2A0EAE0 VA: 0x2A12AE0
	|-Lookup.Grouping<byte, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x2A12D84 Offset: 0x2A0ED84 VA: 0x2A12D84
	|-Lookup.Grouping<int, int>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x2A13030 Offset: 0x2A0F030 VA: 0x2A13030
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x2A136C8 Offset: 0x2A0F6C8 VA: 0x2A136C8
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12B00 Offset: 0x2A0EB00 VA: 0x2A12B00
	|-Lookup.Grouping<byte, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x2A12DA4 Offset: 0x2A0EDA4 VA: 0x2A12DA4
	|-Lookup.Grouping<int, int>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x2A13050 Offset: 0x2A0F050 VA: 0x2A13050
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x2A137F8 Offset: 0x2A0F7F8 VA: 0x2A137F8
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.IList<TElement>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12B18 Offset: 0x2A0EB18 VA: 0x2A12B18
	|-Lookup.Grouping<byte, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x2A12DBC Offset: 0x2A0EDBC VA: 0x2A12DBC
	|-Lookup.Grouping<int, int>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x2A13068 Offset: 0x2A0F068 VA: 0x2A13068
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x2A13810 Offset: 0x2A0F810 VA: 0x2A13810
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private TElement System.Collections.Generic.IList<TElement>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12B30 Offset: 0x2A0EB30 VA: 0x2A12B30
	|-Lookup.Grouping<byte, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x2A12DD4 Offset: 0x2A0EDD4 VA: 0x2A12DD4
	|-Lookup.Grouping<int, int>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x2A13080 Offset: 0x2A0F080 VA: 0x2A13080
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x2A13828 Offset: 0x2A0F828 VA: 0x2A13828
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12B90 Offset: 0x2A0EB90 VA: 0x2A12B90
	|-Lookup.Grouping<byte, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x2A12E34 Offset: 0x2A0EE34 VA: 0x2A12E34
	|-Lookup.Grouping<int, int>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x2A130E0 Offset: 0x2A0F0E0 VA: 0x2A130E0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x2A1395C Offset: 0x2A0F95C VA: 0x2A1395C
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12BA8 Offset: 0x2A0EBA8 VA: 0x2A12BA8
	|-Lookup.Grouping<byte, object>..ctor
	|
	|-RVA: 0x2A12E4C Offset: 0x2A0EE4C VA: 0x2A12E4C
	|-Lookup.Grouping<int, int>..ctor
	|
	|-RVA: 0x2A130F8 Offset: 0x2A0F0F8 VA: 0x2A130F8
	|-Lookup.Grouping<object, object>..ctor
	|
	|-RVA: 0x2A13974 Offset: 0x2A0F974 VA: 0x2A13974
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
