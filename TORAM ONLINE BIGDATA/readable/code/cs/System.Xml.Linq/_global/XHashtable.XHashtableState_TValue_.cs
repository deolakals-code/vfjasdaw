// Assembly: System.Xml.Linq.dll
// Namespace: 
private sealed class XHashtable.XHashtableState<TValue> // TypeDefIndex: 17516
{
	// Fields
	private int[] _buckets; // 0x0
	private XHashtable.XHashtableState.Entry<TValue>[] _entries; // 0x0
	private int _numEntries; // 0x0
	private XHashtable.ExtractKeyDelegate<TValue> _extractKey; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D9B854 Offset: 0x2D97854 VA: 0x2D9B854
	|-XHashtable.XHashtableState<object>..ctor
	|
	|-RVA: 0x2D9C040 Offset: 0x2D98040 VA: 0x2D9C040
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public XHashtable.XHashtableState<TValue> Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D9B914 Offset: 0x2D97914 VA: 0x2D9B914
	|-XHashtable.XHashtableState<object>.Resize
	|
	|-RVA: 0x2D9C100 Offset: 0x2D98100 VA: 0x2D9C100
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.Resize
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D9BB64 Offset: 0x2D97B64 VA: 0x2D9BB64
	|-XHashtable.XHashtableState<object>.TryGetValue
	|
	|-RVA: 0x2D9C520 Offset: 0x2D98520 VA: 0x2D9C520
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TValue value, out TValue newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D9BC24 Offset: 0x2D97C24 VA: 0x2D9BC24
	|-XHashtable.XHashtableState<object>.TryAdd
	|
	|-RVA: 0x2D9C6B0 Offset: 0x2D986B0 VA: 0x2D9C6B0
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D9BDF0 Offset: 0x2D97DF0 VA: 0x2D9BDF0
	|-XHashtable.XHashtableState<object>.FindEntry
	|
	|-RVA: 0x2D9CA7C Offset: 0x2D98A7C VA: 0x2D9CA7C
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.FindEntry
	*/

	// RVA: -1 Offset: -1
	private static int ComputeHashCode(string key, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D9BFC4 Offset: 0x2D97FC4 VA: 0x2D9BFC4
	|-XHashtable.XHashtableState<object>.ComputeHashCode
	|
	|-RVA: 0x2D9CE3C Offset: 0x2D98E3C VA: 0x2D9CE3C
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.ComputeHashCode
	*/
}
